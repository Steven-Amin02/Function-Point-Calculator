using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Point_Calculator.UI
{
    public partial class DI_Calculator : Form
    {
        public int FinalDI { get; private set; }
        private TrackBar[] trackBars;
        private Label[] valLabels;

        public DI_Calculator()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            trackBars = new TrackBar[] { trackBar1, trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar8, trackBar9, trackBar10, trackBar11, trackBar12, trackBar13, trackBar14, trackBar15 };
            valLabels = new Label[] { lblVal1, lblVal2, lblVal3, lblVal4, lblVal5, lblVal6, lblVal8, lblVal9, lblVal10, lblVal11, lblVal12, lblVal13, lblVal14, lblVal15 };

            Label[] factorLabels = new Label[] { label2, label3, label4, label5, label6, label1, label14, label13, label12, label11, label10, label9, label8, label7 };
            string[] tooltips = new string[] {
                "Distributed Data Processing", "Performance", "Heavily Used Configuration", "Transaction Rate", "On-line Data Entry", "Data Communication", "Facilitate Change", "Multiple Sites", "Operational Ease", "Installation Ease", "Reusability", "Complex Processing", "On-Line Updates", "End-user Efficiency"
            };

            for (int i = 0; i < trackBars.Length; i++)
            {
                trackBars[i].Minimum = 0;
                trackBars[i].Maximum = 5;
                trackBars[i].Value = 0;

                int index = i; // for closure
                trackBars[i].Scroll += (s, e) => UpdateTrackBarDisplay(index);

                if (i < factorLabels.Length && factorLabels[i] != null)
                {
                    toolTip1.SetToolTip(factorLabels[i], tooltips[i]);
                }

                // Initial update
                UpdateTrackBarDisplay(index);
            }
        }

        private void UpdateTrackBarDisplay(int index)
        {
            int value = trackBars[index].Value;
            string meaning = "";
            Color color = Color.Green;

            switch (value)
            {
                case 0: meaning = "No Influence"; color = Color.Green; break;
                case 1: meaning = "Incidental"; color = Color.Green; break;
                case 2: meaning = "Moderate"; color = Color.Orange; break;
                case 3: meaning = "Average"; color = Color.Orange; break;
                case 4: meaning = "Significant"; color = Color.Red; break;
                case 5: meaning = "Essential"; color = Color.Red; break;
            }

            valLabels[index].Text = $"{value} ({meaning})";
            valLabels[index].ForeColor = color;

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            int totalDI = 0;
            foreach (var tb in trackBars)
            {
                totalDI += tb.Value;
            }

            FinalDI = totalDI;
            lblTotalDI.Text = $"Total DI = {totalDI}";

            if (totalDI < 25) lblTotalDI.ForeColor = Color.Green;
            else if (totalDI < 50) lblTotalDI.ForeColor = Color.Orange;
            else lblTotalDI.ForeColor = Color.Red;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var tb in trackBars)
            {
                tb.Value = 0;
            }
            for (int i = 0; i < trackBars.Length; i++)
            {
                UpdateTrackBarDisplay(i);
            }
            trackBarMaster.Value = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void trackBarMaster_Scroll(object sender, EventArgs e)
        {
            int masterValue = trackBarMaster.Value;

            for (int i = 0; i < trackBars.Length; i++)
            {
                trackBars[i].Value = masterValue;
                UpdateTrackBarDisplay(i);
            }
        }
    }
}
