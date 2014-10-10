﻿/* Adapted from Brian Peek's code which can be downloaded from http://www.codeplex.com/WiimoteLib
 * By Nam Tran
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        // Creates the Wii remote
        private Wiimote wiimote;

        // Decimal points to round to
        private int decimalPoints;

        // Initialises the form
        public frmWiiInterface()
        {
            InitializeComponent();
        }

        // Loads the form as well as connects a Wii remote
        private void frmWiiInterface_Load(object sender, EventArgs e)
        {
            wiimote = new Wiimote();

            // Sets the event for when the state of the Wii remote changes
            wiimote.WiimoteChanged += wiimote_WiimoteChanged;

            // Sets the event for when an extension to the remote is added or removed
            wiimote.WiimoteExtensionChanged += wiimote_WiimoteExtensionChanged;

            // Connects the Wii remote to the computer
            wiimote.Connect();

            // Sets the program to report the IR and Accelerometer data from the remote
            wiimote.SetReportType(InputReport.IRAccel, true);

            // Sets the player LEDS
            wiimote.SetLEDs(true, false, false, false);
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

        // Disconnects the remote from the program if the form closes
        public void frmWiiInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            wiimote.Disconnect();
        }

        private void menuDecimalPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimalPoints = Int32.Parse(menuDecimalPlaces.Text);
        }
    }
}
