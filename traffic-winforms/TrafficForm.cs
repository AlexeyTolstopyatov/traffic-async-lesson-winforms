using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_winforms
{
    public partial class TrafficForm : Form
    {
        public TrafficForm()
        {
            InitializeComponent();
        }

        private async Task RunTraffic(TrafficLights light)
        {
            // 1) define mode
            switch (light)
            {
                case TrafficLights.RED:
                    // switch light with delay
                    // 1) turn Yellow ON
                    yellowPanel.BackColor = Color.Yellow;
                    yellowLabel.Enabled = true;

                    // 2) async calls

                    await Task.Delay(1000);
                    await SwitchPanel(true);
                    await SwitchLabel(true);

                    // 3) all tasks completed, turn Yellow OFF
                    yellowPanel.BackColor = Color.Black;
                    yellowLabel.Enabled = false;


                    break;

                case TrafficLights.GREEN:
                    // switch light with delay
                    // 1) turn Yellow ON
                    yellowPanel.BackColor = Color.Yellow;
                    yellowLabel.Enabled = true;

                    // 2) async calls
                    await Task.Delay(1000);
                    await SwitchPanel(false);
                    await SwitchLabel(false);

                    // 3) all tasks completed, turn Yellow OFF
                    yellowPanel.BackColor = Color.Black;
                    yellowLabel.Enabled = false;
            
                    break;
            }

        }

        private void StopTraffic() 
        {
            // restore background state
            redPanel.BackColor = 
            yellowPanel.BackColor = 
            greenPanel.BackColor =
            Color.FromKnownColor(KnownColor.Control);

            // enable all controls
            redLabel.Enabled =
            yellowLabel.Enabled =
            greenLabel.Enabled = 
            true;
        }

        private Task SwitchPanel(bool isRed)
        {
            Task.Delay(1000);

            if (isRed)
            {
                redPanel.BackColor = Color.Red;
                yellowPanel.BackColor = Color.Black;
                greenPanel.BackColor = Color.Black;
            }
            else
            {
                redPanel.BackColor = Color.Black;
                yellowPanel.BackColor = Color.Black;
                greenPanel.BackColor = Color.Green;
            }

            return Task.CompletedTask;
        }

        private Task SwitchLabel(bool isRed)
        {
            Task.Delay(500);

            if (isRed)
            {
                // turn RED slowly
                redLabel.Enabled = true;
                yellowLabel.Enabled = false;
                greenLabel.Enabled = false;
            }
            else
            {
                greenLabel.Enabled = true;
                yellowLabel.Enabled = false;
                redLabel.Enabled = false;
            }

            return Task.CompletedTask; 
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // run Task async'like but arguments dont care.
            _ = RunTraffic(TrafficLights.RED);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _ = RunTraffic(TrafficLights.GREEN);
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            // permanently stop traffic lights. for run it again \_(*-*)_/
            StopTraffic();
        }
    }
}
