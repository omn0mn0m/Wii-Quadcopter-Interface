/* Wii Remote Code adapted from Brian Peek's code which can be downloaded from http://www.codeplex.com/WiimoteLib
 * By Nam Tran
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;

namespace Wii_Interface
{
    public partial class frmWiiInterface : Form
    {
        // Delegates for updated remote status events
        private delegate void UpdateWiimoteStateDelegate(WiimoteChangedEventArgs args);
        private delegate void UpdateExtensionChangedDelegate(WiimoteExtensionChangedEventArgs args);
        private delegate void UpdateCoordinatesDelegate(int[] coordinates);

        // For the IR stats
        private Bitmap b = new Bitmap(256, 192, PixelFormat.Format24bppRgb);
        private Graphics g;

        // Creates the Wii remote
        private Wiimote wiimote;

        // Decimal points to round to
        private int decimalPoints = 4;

        // Background worker for multitasking
        private BackgroundWorker bwGetResponse = new BackgroundWorker();

        // Engines for the speech recognition and synthesis
        private SpeechRecognitionEngine speechRecognition;
        private SpeechSynthesizer speechSynthesiser;
        private Grammar grammar;

        // Whether to be listening for a command for the indicator for the command
        private bool listenForCommand = false;

        // Information about the voice control demo
        private string name = "tex";
        private bool offGround = false;
        private int throttle, roll, pitch = 0;
        private int x, y, z = 0;
        private int maxDistance = 50;

        private bool useSpeech = true;

        // Initialises the form
        public frmWiiInterface()
        {
            wiimote = new Wiimote();

            // Sets the event for when the state of the Wii remote changes
            wiimote.WiimoteChanged += wiimote_WiimoteChanged;

            // Sets the event for when an extension to the remote is added or removed
            wiimote.WiimoteExtensionChanged += wiimote_WiimoteExtensionChanged;

            // Sets the program to report the IR and Accelerometer data from the remote
            wiimote.SetReportType(InputReport.IRAccel, true);

            // Sets the player LEDS
            wiimote.SetLEDs(true, false, false, false);

            // Creates the choices of commands
            Choices commands = new Choices();
            commands.Add(new string[] { "take off", "land", "swag", 
                "go forwards", "go backwards", "go right", "go left", "go up", "go down", 
                "hover", "rotate clockwise", "rotate anticlockwise", "stop", "beam me up", "open the pod bay doors", name });

            // Sets the grammar of the speech recognition
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);
            grammar = new Grammar(grammarBuilder);

            // Initialises the AI speech
            speechSynthesiser = new SpeechSynthesizer();

            // Initialises the speech recognition
            speechRecognition = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            speechRecognition.LoadGrammarAsync(grammar);
            speechRecognition.SetInputToDefaultAudioDevice();
            speechRecognition.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognition_SpeechRecognized);

            // Sets up the background worker
            bwGetResponse.DoWork += new DoWorkEventHandler(bwGetResponse_DoWork);
            bwGetResponse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwGetReponse_RunWorkerCompleted);
            bwGetResponse.WorkerSupportsCancellation = true;

            InitializeComponent();
        }

        // Loads the form as well as connects a Wii remote
        private void frmWiiInterface_Load(object sender, EventArgs e)
        {
            try
            {
                wiimote.Connect();          // Connects the Wii remote to the computer
            } catch (WiimoteNotFoundException) {}

            Say("I am " + name + ", and I will be your pilot today. It is a pleasure to meet you.");
        }

        private void wiimote_WiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            // Attempts to update the Wii remote status, but will catch an exception if the remote is unavailable
            try
            {
                BeginInvoke(new UpdateWiimoteStateDelegate(UpdateWiimoteChanged), args);
            }
            catch (System.InvalidOperationException){}
            
        }

        private void wiimote_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs args)
        {
            // Attempts to update the Wii remote status, but will catch an exception if the remote is unavailable
            try
            {
                BeginInvoke(new UpdateExtensionChangedDelegate(UpdateExtensionChanged), args);
            }
            catch (System.InvalidOperationException){}

            // If an extension is plugged in, then IR values will be reported from a Wii Motion Plus (assuming there is one)
            if (args.Inserted)
            {
                wiimote.SetReportType(InputReport.IRExtensionAccel, true);
            }
            else
            {
                wiimote.SetReportType(InputReport.IRAccel, true);
            }
        }

        private void UpdateWiimoteChanged(WiimoteChangedEventArgs args)
        {
            // Creates object for the Wii remote states
            WiimoteState wiimoteState = args.WiimoteState;

            // Wii remote button states
            checkWiiRemoteStats(wiimoteState);

            // If there is a nunchuck plugged in, then nunchuck stats will be displayed
            if (wiimoteState.ExtensionType.Equals(ExtensionType.Nunchuk)) {
                checkNunchuckStats(wiimoteState);
            }

            // Battery information
            checkRemoteBatteryStats(wiimoteState);

            // Displays the Wii remote's HID path
            txtDevicePath.Text = wiimote.HIDDevicePath;
        }

        // Changes the value of the Enabled checkbox in the Nunchuck box
        private void UpdateExtensionChanged(WiimoteExtensionChangedEventArgs args)
        {
            cbEnabled.Checked = args.Inserted;
        }

        private void checkWiiRemoteStats(WiimoteState wiimoteState)
        {
            // Checks for each Wii remote button and displays their values as checkmarks
            clbWiimote.SetItemChecked(0, wiimoteState.ButtonState.A);
            clbWiimote.SetItemChecked(1, wiimoteState.ButtonState.B);
            clbWiimote.SetItemChecked(2, wiimoteState.ButtonState.Minus);
            clbWiimote.SetItemChecked(3, wiimoteState.ButtonState.Home);
            clbWiimote.SetItemChecked(4, wiimoteState.ButtonState.Plus);
            clbWiimote.SetItemChecked(5, wiimoteState.ButtonState.One);
            clbWiimote.SetItemChecked(6, wiimoteState.ButtonState.Two);
            clbWiimote.SetItemChecked(7, wiimoteState.ButtonState.Up);
            clbWiimote.SetItemChecked(8, wiimoteState.ButtonState.Down);
            clbWiimote.SetItemChecked(9, wiimoteState.ButtonState.Left);
            clbWiimote.SetItemChecked(10, wiimoteState.ButtonState.Right);

            // Displays the Wii remote's accelerometer values
            lblWiimoteX.Text = decimal.Round((decimal)wiimoteState.AccelState.Values.X, decimalPoints).ToString();
            lblWiimoteY.Text = decimal.Round((decimal)wiimoteState.AccelState.Values.Y, decimalPoints).ToString();
            lblWiimoteZ.Text = decimal.Round((decimal)wiimoteState.AccelState.Values.Z, decimalPoints).ToString();
        }

        private void checkNunchuckStats(WiimoteState wiimoteState)
        {
            // Displays nunchuck accelerometer values
            lblNunchuckX.Text = decimal.Round((decimal)wiimoteState.NunchukState.AccelState.Values.X, decimalPoints).ToString();
            lblNunchuckY.Text = decimal.Round((decimal)wiimoteState.NunchukState.AccelState.Values.Y, decimalPoints).ToString();
            lblNunchuckZ.Text = decimal.Round((decimal)wiimoteState.NunchukState.AccelState.Values.Z, decimalPoints).ToString();

            // Displays nunchuck joystick values
            lblNunJoyX.Text = decimal.Round((decimal)wiimoteState.NunchukState.Joystick.X, decimalPoints).ToString();
            lblNunJoyY.Text = decimal.Round((decimal)wiimoteState.NunchukState.Joystick.Y, decimalPoints).ToString();

            // Checks for each nunchuck button and displays their values
            clbNunchuck.SetItemChecked(0, wiimoteState.NunchukState.C);
            clbNunchuck.SetItemChecked(1, wiimoteState.NunchukState.Z);
        }

        private void checkRemoteBatteryStats(WiimoteState wiimoteState)
        {
            // Displays the battery level as a progress bar in the status bar
            tbpbBattery.Value = (wiimoteState.Battery > 0xc8 ? 0xc8 : (int)wiimoteState.Battery);
            // Displays the battery level as a decimal between 0.0 and 1.0
            tblblBatteryPercent.Text = Decimal.Round((decimal)wiimoteState.Battery, decimalPoints).ToString();
        }

        private void checkIRStats(WiimoteState wiimoteState)
        {
            g.Clear(Color.Black);

            UpdateIR(wiimoteState.IRState.IRSensors[0], lblIR1, lblIR1Raw, chkFound1, Color.Red);
            UpdateIR(wiimoteState.IRState.IRSensors[1], lblIR2, lblIR2Raw, chkFound2, Color.Blue);
            UpdateIR(wiimoteState.IRState.IRSensors[2], lblIR3, lblIR3Raw, chkFound3, Color.Yellow);
            UpdateIR(wiimoteState.IRState.IRSensors[3], lblIR4, lblIR4Raw, chkFound4, Color.Orange);

            if (wiimoteState.IRState.IRSensors[0].Found && wiimoteState.IRState.IRSensors[1].Found)
                g.DrawEllipse(new Pen(Color.Green), (int)(wiimoteState.IRState.RawMidpoint.X / 4), (int)(wiimoteState.IRState.RawMidpoint.Y / 4), 2, 2);

            pbIR.Image = b;
        }

        private void UpdateIR(IRSensor irSensor, Label lblNorm, Label lblRaw, CheckBox chkFound, Color color)
        {
            chkFound.Checked = irSensor.Found;

            if (irSensor.Found)
            {
                lblNorm.Text = irSensor.Position.ToString() + ", " + irSensor.Size;
                lblRaw.Text = irSensor.RawPosition.ToString();
                g.DrawEllipse(new Pen(color), (int)(irSensor.RawPosition.X / 4), (int)(irSensor.RawPosition.Y / 4),
                             irSensor.Size + 1, irSensor.Size + 1);
            }
        }

        // Disconnects the remote from the program if the form closes
        public void frmWiiInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            wiimote.Disconnect();
        }

        private void menuDecimalPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimalPoints = Int32.Parse(menuDecimalPlaces.Text);
        }

        private void speechRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (listenForCommand)
            {
                txtOutput.AppendText(System.Environment.NewLine + e.Result.Text);
                interpretInput(e.Result.Text);
                listenForCommand = false;
            }

            listenForCommand = (e.Result.Text.ToLower().Equals(name));

            if (listenForCommand)
            {
                Say("Yes?");
            }
        }

        private void interpretInput(string input)
        {
            switch (input.ToLower())
            {
                case "take off":
                    if (!offGround)
                    {
                        Say("Preparing the quadcopter for take-off. Throttle to full power. Have a safe flight.");
                    }
                    else
                    {
                        Say("You have already taken off...");
                    }

                    offGround = true;
                    //if (!bwGetResponse.IsBusy)
                    //{
                    //    bwGetResponse.RunWorkerAsync();
                    //}
                    break;
                case "land":
                    if (offGround)
                    {
                        Say("Sloping off throttle. Preparing for a safe landing. Hope nothing is below me.");
                    }
                    else
                    {
                        Say("You can't land if you are already landed...");
                    }
                    offGround = false;
                    //if (bwGetResponse.IsBusy)
                    //{
                    //    bwGetResponse.CancelAsync();
                    //}
                    break;
                case "swag":
                    Say("Swiggity swaggity, what's in the baggity?");
                    break;
                case "beam me up":
                    Say("This is not the Starship Enterprise...");
                    break;
                case "go forwards":
                    if (offGround)
                    {
                        if (z < maxDistance)
                        {
                            Say("Increasing pitch to 10 percent");
                            pitch += 10;
                        }
                        else
                        {
                            Say("Dangerous distance reached. Holding pitch at neutral.");
                        }
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "go backwards":
                    if (offGround)
                    {
                        if (z > -maxDistance)
                        {
                            Say("Decreasing pitch to minus 10 percent");
                            pitch -= 10;
                        }
                        else
                        {
                            Say("Dangerous distance reached. Holding pitch at neutral.");
                        }
                        
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "go right":
                    if (offGround)
                    {
                        if (x < maxDistance)
                        {
                            Say("Increasing roll to 10 percent");
                            roll += 10;
                        }
                        else
                        {
                            Say("Dangerous distance reached. Holding roll at neutral.");
                        }
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "go left":
                    if (offGround)
                    {
                        if (x > -maxDistance)
                        {
                            Say("Decreasing roll to 10 percent");
                            roll -= 10;
                        }
                        else
                        {
                            Say("Dangerous distance reached. Holding roll at neutral.");
                        }
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "go up":
                    if (offGround)
                    {
                        if (y < maxDistance)
                        {
                            Say("Increasing throttle by 10 percent");
                            throttle += 10;
                        }
                        else
                        {
                            Say("Dangerous altitude reached. Holding throttle at neutral.");
                        }
                        
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "go down":
                    if (offGround)
                    {
                        if (y > -maxDistance)
                        {
                            Say("Decreasing throttle by 10 percent");
                            throttle -= 10;
                        }
                        else
                        {
                            Say("Dangerous altitude reached. Holding throttle at neutral.");
                        }
                        
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "stop":
                case "hover":
                    if (offGround)
                    {
                        Say("Setting throttle to hold. Setting roll and pitch to neutral.");
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "rotate clockwise":
                    if (offGround)
                    {
                        Say("Increasing yaw to 10 percent");
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "rotate anticlockwise":
                    if (offGround)
                    {
                        Say("Decreasing yaw to minus 10 percent");
                    }
                    else
                    {
                        Say("You must take off before moving.");
                    }
                    break;
                case "open the pod bay doors":
                default:
                    Say("I'm sorry, Dave, I can't do that.");
                    break;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Say(string message)
        {
            speechRecognition.RecognizeAsyncCancel();
            txtOutput.AppendText(System.Environment.NewLine + message);

            if (useSpeech)
            {
                speechSynthesiser.Speak(message);
            }

            try {
                speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            } catch(InvalidOperationException) {}
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (listenForCommand)
            {
                txtOutput.AppendText(System.Environment.NewLine + txtInput.Text);
                interpretInput(txtInput.Text);
                listenForCommand = false;
            }

            listenForCommand = (txtInput.Text.ToLower().Equals(name));

            if (listenForCommand)
            {
                Say("Yes?");
            }

            txtInput.Clear();
        }

        private void UpdateDistances(int[] coords)
        {
            txtDemoX.Text = coords[0].ToString();
            txtDemoY.Text = coords[1].ToString();
            txtDemoZ.Text = coords[2].ToString();
        }

        private void bwGetReponse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && (e.Error == null))
            {
                string response = (string)e.Result;
                Say(response);
            }
            else if (e.Cancelled)
            {
                Say("Quadcopter stop confirmed.");
            }
            else
            {
                Say("An error has occured");
            }
        }

        private void bwGetResponse_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker sendingWorker = (BackgroundWorker)sender;

            x += roll;
            y += throttle;
            z += pitch;

            try
            {
                BeginInvoke(new UpdateCoordinatesDelegate(UpdateDistances), new int[] { x, y, z });
            }
            catch (System.InvalidOperationException) { }
        }

        private void cbDisableSpeech_CheckedChanged(object sender, EventArgs e)
        {
            useSpeech = !cbDisableSpeech.Enabled;
        }

        private void cbDisableRecognition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDisableRecognition.Enabled)
            {
                speechRecognition.RecognizeAsyncCancel();
            }
            else
            {
                speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            }
        }
    }
}
