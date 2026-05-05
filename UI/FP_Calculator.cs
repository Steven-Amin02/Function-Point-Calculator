using System;
using System.Windows.Forms;
using Function_Point_Calculator.Logic;

namespace Function_Point_Calculator
{
    public partial class FP_Calculator : Form
    {
        private int currentUFP = 0;
        private double currentTCF = 0;
        private double currentFP = 0;
        private double estimatedLOC;

        public FP_Calculator()
        {
            InitializeComponent();
        }

        private void FP_Calculator_Load(object sender, EventArgs e)
        {
            cmbLanguage.Items.Clear();

            foreach (string languageName in Data.MetricsData.AVC.Keys)
            {
                cmbLanguage.Items.Add(languageName);
            }
        }

        private void btnManualDI_Click(object sender, EventArgs e)
        {
            using (UI.DI_Calculator diForm = new UI.DI_Calculator())
            {
                if (diForm.ShowDialog() == DialogResult.OK)
                {
                    txtDI.Text = diForm.FinalDI.ToString();
                }
            }
        }

        private void btnCalcUFP_Click(object sender, EventArgs e)
        {
            try
            {
                int[] ei = { int.Parse(txtEI_Simple.Text), int.Parse(txtEI_Avg.Text), int.Parse(txtEI_Complex.Text) };
                int[] eo = { int.Parse(txtEO_Simple.Text), int.Parse(txtEO_Avg.Text), int.Parse(txtEO_Complex.Text) };
                int[] eq = { int.Parse(txtEQ_Simple.Text), int.Parse(txtEQ_Avg.Text), int.Parse(txtEQ_Complex.Text) };
                int[] ilf = { int.Parse(txtILF_Simple.Text), int.Parse(txtILF_Avg.Text), int.Parse(txtILF_Complex.Text) };
                int[] eif = { int.Parse(txtEIF_Simple.Text), int.Parse(txtEIF_Avg.Text), int.Parse(txtEIF_Complex.Text) };

                currentUFP = CalculatorEngine.CalculateUFP(ei, eo, eq, ilf, eif);

                lblUFPResult.Text = $"Total UFP: {currentUFP}";
            }
            catch (Exception)
            {
                MessageBox.Show("Please ensure all 15 UFP boxes contain a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcTCF_Click(object sender, EventArgs e)
        {
            try
            {
                int di = int.Parse(txtDI.Text);

                currentTCF = CalculatorEngine.CalculateTCF(di);

                lblTCFResult.Text = $"TCF: {currentTCF:F2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for Degree of Influence.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentUFP == 0 || currentTCF == 0)
            {
                MessageBox.Show("Please calculate UFP and TCF first!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentFP = CalculatorEngine.CalculateFP(currentUFP, currentTCF);

            lblFPResult.Text = $"Function Points: {currentFP:F2}";
        }

        private void btnCalcFP_Click(object sender, EventArgs e)
        {
            if (currentFP == 0)
            {
                MessageBox.Show("Please calculate the Function Points (FP) first!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string? selectedLanguage = cmbLanguage.SelectedItem?.ToString();

            if (selectedLanguage == null)
            {
                MessageBox.Show("Please select a valid language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            estimatedLOC = CalculatorEngine.CalculateLOC(currentFP, selectedLanguage);

            lblLOCResult.Text = $"Est. Lines of Code: {estimatedLOC:F2}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            // Reset internal state
            currentUFP = 0;
            currentTCF = 0;
            currentFP = 0;
            estimatedLOC = 0;

            // Reset UFP input fields to their default values (designer defaults are "0")
            txtEI_Simple.Text = "0";
            txtEI_Avg.Text = "0";
            txtEI_Complex.Text = "0";

            txtEO_Simple.Text = "0";
            txtEO_Avg.Text = "0";
            txtEO_Complex.Text = "0";

            txtEQ_Simple.Text = "0";
            txtEQ_Avg.Text = "0";
            txtEQ_Complex.Text = "0";

            txtILF_Simple.Text = "0";
            txtILF_Avg.Text = "0";
            txtILF_Complex.Text = "0";

            txtEIF_Simple.Text = "0";
            txtEIF_Avg.Text = "0";
            txtEIF_Complex.Text = "0";

            // Reset DI and language selection
            txtDI.Text = string.Empty;
            cmbLanguage.SelectedIndex = -1;

            // Reset result labels to their initial text
            lblUFPResult.Text = "Total UFP: 0";
            lblTCFResult.Text = "TCF: 0.00";
            lblFPResult.Text = "Function Points: 0";
            lblLOCResult.Text = "Est. Lines of Code: 0";
        }




        private void lblTCFResult_Click(object sender, EventArgs e)
        {

        }

        private void lblUFPResult_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




            
    }
}
