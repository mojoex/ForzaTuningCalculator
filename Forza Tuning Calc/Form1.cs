using Forza_Tuning_Calculator.DTO;
using Forza_Tuning_Calculator.DTO.Input;
using System;
using System.Windows.Forms;

namespace Forza_Tuning_Calculator
{

    public partial class ForzaTuningCalc : Form
    {
        private Utils _utils;

        public ForzaTuningCalc()
        {
            InitializeComponent();
            _utils = new Utils(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRebound_Click(object sender, EventArgs e)
        {

        }

        private void btnTune_Click(object sender, EventArgs e)
        {
            var input = GetUserInput();

            var result = _utils.PerformCalculations(input);

            SetResult(result);

            SetResultVisible();
        }

        private void SetResult(ResultObject result)
        {
            resBumpFront.Text = result.Damping.Bump.Front.ToString("n2");
            resBumpRear.Text = result.Damping.Bump.Rear.ToString("n2");

            resRebFront.Text = result.Damping.Rebound.Front.ToString("n2");
            resRebRear.Text = result.Damping.Rebound.Rear.ToString("n2");

            resSpringFront.Text = result.Springs.SpringRate.Front.ToString("n2");
            resSpringRear.Text = result.Springs.SpringRate.Rear.ToString("n2");

            resFrontArb.Text = result.ARBs.Front.ToString("n2");
            resRearArb.Text = result.ARBs.Rear.ToString("n2");
        }

        private void SetResultVisible()
        {
            resBumpFront.Visible = true;
            resBumpRear.Visible = true;

            resRebFront.Visible = true;
            resRebRear.Visible = true;

            resSpringFront.Visible = true;
            resSpringRear.Visible = true;

            resRearArb.Visible = true;
            resFrontArb.Visible = true;
        }

        private void resRebFront_Click(object sender, EventArgs e)
        {

        }

        private void resRebRear_Click(object sender, EventArgs e)
        {

        }

        private void resBumpFront_Click(object sender, EventArgs e)
        {

        }

        private void resBumpRear_Click(object sender, EventArgs e)
        {

        }

        private void resSpringFront_Click(object sender, EventArgs e)
        {

        }

        private void resSpringRear_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrontWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRebMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRebMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBumpMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBumpMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrontSpringMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrontSpringMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRearMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRearMax_TextChanged(object sender, EventArgs e)
        {

        }

        public UserInput GetUserInput()
        {
            var result = new UserInput();

            //result.Weight.Weight = Int32.Parse(txtWeight.Text);
            result.Weight.FrontWeight = Int32.Parse(txtFrontWeight.Text);
            result.Damping.ReboundMin = float.Parse(txtRebMin.Text);
            result.Damping.ReboundMax = float.Parse(txtRebMax.Text);
            result.Springs.FrontMin = float.Parse(txtFrontSpringMin.Text);
            result.Springs.FrontMax = float.Parse(txtFrontSpringMax.Text);
            result.Springs.RearMin = result.Springs.FrontMin; //float.Parse(txtRearSpringMin.Text);
            result.Springs.RearMax = result.Springs.FrontMax; //float.Parse(txtRearSpringMax.Text);
            result.ARBs.FrontMin = float.Parse(txtFrontArbMin.Text);
            result.ARBs.FrontMax = float.Parse(txtFrontArbMax.Text);
            result.ARBs.RearMin = result.ARBs.FrontMin; //float.Parse(txtRearArbMin.Text);
            result.ARBs.RearMax = result.ARBs.FrontMax; //float.Parse(txtRearArbMax.Text);

            return result;
        }

        private void txtFrontArbMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrontArbMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRearArbMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRearArbMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
