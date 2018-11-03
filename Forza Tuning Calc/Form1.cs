using Forza_Tuning_Calculator.DTO;
using Forza_Tuning_Calculator.DTO.Constants;
using Forza_Tuning_Calculator.DTO.Input;
using Forza_Tuning_Calculator.DTO.Result;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Forza_Tuning_Calculator
{

    public partial class ForzaTuningCalc : Form
    {
        private Utils _utils;
        private BaseTune _base;
        private FineTune _fineTune;

        public ForzaTuningCalc()
        {
            InitializeComponent();
            PopulateDataSources();
            _utils = new Utils();
        }

        private void PopulateDataSources()
        {
            cmbDrivetrain.Items.AddRange(DataConstants.DrivetrainOptions.ToArray());
        }

        private void btnTune_Click(object sender, EventArgs e)
        {
            //if (_fineTune != null)
            //{
            //    ResetFineTuneStages();
            //}

            bool valid = CheckUserInput();

            if (valid)
            {
                var input = GetUserInput();

                var baseTune = _utils.BuildBaseTune(input);

                _utils.BaseTuneCalculations(baseTune, input);

                _base = baseTune;

                SetResult(baseTune);

                SetResultVisible();

                baseTune.BaseComplete = true;
            }
        }

        private void SetResult(BaseTune result)
        {
            foreach (ListViewItem item in resultsList.Items)
            {
                if (result.BaseComplete)
                {
                    item.SubItems.Clear();
                }

                item.SubItems.AddRange(AddSubItemData(item.Text, result));
            }

            //resBumpFront50.Text = "Soft: " + result.Suspension.Damping.Bump.Front50.ToString("n2");
            //resBumpRear50.Text = "Soft: " + result.Damping.Bump.Rear50.ToString("n2");
            //resBumpFront63.Text = "Medium: " + result.Damping.Bump.Front63.ToString("n2");
            //resBumpRear63.Text = "Medium: " + result.Damping.Bump.Rear63.ToString("n2");
            //resBumpFront75.Text = "Stiff: " + result.Damping.Bump.Front75.ToString("n2");
            //resBumpRear75.Text = "Stiff: " + result.Damping.Bump.Rear75.ToString("n2");

            //resRebFront.Text = result.Damping.Rebound.Front.ToString("n2");
            //resRebRear.Text = result.Damping.Rebound.Rear.ToString("n2");

            //resSpringFront.Text = result.Springs.SpringRate.Front.ToString("n2");
            //resSpringRear.Text = result.Springs.SpringRate.Rear.ToString("n2");
            //frontSpringVar.Text = "+/-" + result.Springs.SpringRate.FrontVar.ToString("n2");
            //rearSpringVar.Text = "+/-" + result.Springs.SpringRate.RearVar.ToString("n2");

            //resFrontArb.Text = result.ARB.Front.ToString("n2");
            //resRearArb.Text = result.ARB.Rear.ToString("n2");
            //frontArbVar.Text = "+/-" + result.ARB.FrontVar.ToString("n2");
            //rearArbVar.Text = "+/-" + result.ARB.RearVar.ToString("n2");
        }

        private ListViewSubItem[] AddSubItemData(string source, BaseTune result)
        {
            var list = new List<ListViewSubItem>();

            switch (source)
            {
                case SuspensionConstants.SpringRates:
                    list.Add(CreateSubItem(SuspensionConstants.FrontSpringRate, result.Suspension.Springs.SpringRate.Front));
                    list.Add(CreateSubItem(SuspensionConstants.RearSpringRate, result.Suspension.Springs.SpringRate.Rear));
                    break;

                case SuspensionConstants.Rebound:
                    list.Add(CreateSubItem(SuspensionConstants.ReboundFront, result.Suspension.Damping.Rebound.Front));
                    list.Add(CreateSubItem(SuspensionConstants.ReboundRear, result.Suspension.Damping.Rebound.Rear));
                    break;

                case SuspensionConstants.Bump:
                    list.Add(CreateSubItem(SuspensionConstants.BumpFront, result.Suspension.Damping.Bump.Front50));
                    list.Add(CreateSubItem(SuspensionConstants.BumpRear, result.Suspension.Damping.Bump.Rear50));
                    break;

                case ArbConstants.ARB:
                    list.Add(CreateSubItem(ArbConstants.ArbFront, result.ARB.Front));
                    list.Add(CreateSubItem(ArbConstants.ArbRear, result.ARB.Rear));
                    break;
            }

            return list.ToArray();
        }

        private ListViewSubItem CreateSubItem(string name, double value)
        {
            var result = new ListViewSubItem()
            {
                Name = name,
                Text = value.ToString("n2")
            };

            return result;
        }

        private void SetTuningStages(FineTune fineTune)
        {
            //ftOvrSoftStage.Text = "Stage: " + result.Springs.SpringRate.FrontStage;
            //ftOvrStiffStage.Text = "Stage: " + result.Springs.SpringRate.FrontStage;

            //ftuExitStage.Text = "Stage: " + result.Damping.Rebound.FrontStage;
        }

        private void SetTuningResult(FineTune fineTune)
        {
            //if (result.Springs.SpringRate.FtFront != 0)
            //{
            //    resSpringFront.Text = result.Springs.SpringRate.FtFront.ToString("n2");
            //}

            //if (result.Springs.SpringRate.FtRear != 0)
            //{
            //    resSpringRear.Text = result.Springs.SpringRate.FtRear.ToString("n2");
            //}

            //if (result.ARB.FtFront != 0)
            //{
            //    resFrontArb.Text = result.ARB.FtFront.ToString("n2");
            //}

            //if (result.ARB.FtRear != 0)
            //{
            //    resRearArb.Text = result.ARB.FtRear.ToString("n2");
            //}

            //if (result.Damping.Rebound.FtFront != 0)
            //{
            //    resRebFront.Text = result.Damping.Rebound.FtFront.ToString("n2");
            //}

            //if (result.Damping.Rebound.FtRear != 0)
            //{
            //    resRebRear.Text = result.Damping.Rebound.FtRear.ToString("n2");
            //}
        }

        private void SetResultVisible()
        {
            resultsList.Refresh();
            //resBumpFront50.Visible = true;
            //resBumpRear50.Visible = true;
            //resBumpFront63.Visible = true;
            //resBumpRear63.Visible = true;
            //resBumpFront75.Visible = true;
            //resBumpRear75.Visible = true;

            //resRebFront.Visible = true;
            //resRebRear.Visible = true;

            //resSpringFront.Visible = true;
            //resSpringRear.Visible = true;
            //frontSpringVar.Visible = true;
            //rearSpringVar.Visible = true;

            //resRearArb.Visible = true;
            //resFrontArb.Visible = true;
            //frontArbVar.Visible = true;
            //rearArbVar.Visible = true;
        }

        private bool CheckUserInput()
        {
            if (string.IsNullOrEmpty(cmbDrivetrain.SelectedItem.ToString()))
            {
                _utils.ShowError(StringConstants.Drivetrain);
                return false;
            }

            if (chkWeightBased.CheckState == CheckState.Unchecked && (string.IsNullOrEmpty(inputSpringMin.Text) || string.IsNullOrEmpty(inputSpringMax.Text)))
            {
                _utils.ShowError("Springs min/max");
                return false;
            }

            if (chkWeightBased.CheckState == CheckState.Checked && string.IsNullOrEmpty(inputWeight.Text))
            {
                _utils.ShowError("Weight");
                return false;
            }

            return true;
        }

        //private void ResetFineTuneStages()
        //{
        //    _result.Springs.SpringRate.FrontStage = 0;
        //    _result.Springs.SpringRate.RearStage = 0;

        //    _result.ARB.FrontStage = 0;
        //    _result.ARB.RearStage = 0;

        //    _result.Damping.Rebound.FrontStage = 0;
        //    _result.Damping.Rebound.RearStage = 0;
        //}

        public UserInput GetUserInput()
        {
            var result = new UserInput();

            if (chkWeightBased.CheckState == CheckState.Checked)
            {
                result.WeightBasedTune = true;

                try
                {
                    result.Weight.WeightKg = Int32.Parse(inputWeight.Text);
                    result.Weight.WeightLb = _utils.GetWeightInLbs(result.Weight.WeightKg);
                }

                catch (Exception e)
                {
                    // Do something here
                }
            }

            else
            {
                result.WeightBasedTune = false;
            }

            result.Weight.FrontWeight = Int32.Parse(inputFrontWeight.Text);
            result.Damping.ReboundMin = float.Parse(inputReboundMin.Text);
            result.Damping.ReboundMax = float.Parse(inputReboundMax.Text);

            if (!result.WeightBasedTune)
            {
                result.Springs.Min = float.Parse(inputSpringMin.Text);
                result.Springs.Max = float.Parse(inputSpringMax.Text);
            }

            result.ARB.Min = float.Parse(inputArbMin.Text);
            result.ARB.Max = float.Parse(inputArbMax.Text);

            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRebound_Click(object sender, EventArgs e)
        {

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

        private void resBumpFront63_Click(object sender, EventArgs e)
        {

        }

        private void resBumpFront75_Click(object sender, EventArgs e)
        {

        }

        private void resBumpRear75_Click(object sender, EventArgs e)
        {

        }

        private void resBumpRear63_Click(object sender, EventArgs e)
        {

        }

        private void frontSpringVar_Click(object sender, EventArgs e)
        {

        }

        private void rearSpringVar_Click(object sender, EventArgs e)
        {

        }

        private void frontArbVar_Click(object sender, EventArgs e)
        {

        }

        private void rearArbVar_Click(object sender, EventArgs e)
        {

        }

        private void lblFrontSpring_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ftuOvrSoft_Click(object sender, EventArgs e)
        {
            //if (_result != null && _result.BaseComplete)
            //{
            //    _utils.FineTuneOverallStiffness(_result, FineTuneConstants.Soften);

            //    SetTuningResult(_result);

            //    SetTuningStages(_result);
            //}
        }

        private void ftuOvrStiff_Click(object sender, EventArgs e)
        {
            //if (_result != null && _result.BaseComplete)
            //{
            //    _utils.FineTuneOverallStiffness(_result, FineTuneConstants.Stiffen);

            //    SetTuningResult(_result);

            //    SetTuningStages(_result);
            //}
        }

        private void ftuExit_Click(object sender, EventArgs e)
        {
            //if (_result != null && _result.BaseComplete)
            //{
            //    _utils.FineTuneRebound(_result, FineTuneConstants.Soften, FineTuneConstants.Front);

            //    SetTuningResult(_result);

            //    SetTuningStages(_result);
            //}
        }

        private void ftuEntryHs_Click(object sender, EventArgs e)
        {
            // TODO: Set ride height
            //if (_result != null && _result.BaseComplete)
            //{
            //    _utils.AdjustRideHeight(_result, FineTuneConstants.Lower, FineTuneConstants.Front);

            //    ftrFrontHeight.Text = "Lower front ride height. Stage: " + _result.Springs.Height.Front;
            //    ftrFrontHeight.ForeColor = Color.Blue;

            //    SetTuningStages(_result);
            //}
        }

        private void chkWeightBased_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkWeightBased.CheckState)
            {
                case CheckState.Checked:
                    inputWeight.ReadOnly = false;
                    break;
                case CheckState.Unchecked:
                    inputWeight.ReadOnly = true;
                    break;
            }
        }

        private void txtWeight_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ftoExit_Click(object sender, EventArgs e)
        {

        }

        private void ftuEntryMid_Click(object sender, EventArgs e)
        {
            //if (_result != null && _result.BaseComplete)
            //{
            //    _utils.CornerEntryUs(_result);

            //    ftrCastor.Text = "Increase castor angle: " + _result.Alignment.CastorAngle.ToString("n2");
            //    ftrCastor.ForeColor = Color.Blue;

            //    ftrToeOut.Text = "Increase front toe out: " + _result.Alignment.ToeOut.ToString("n2");
            //    ftrToeOut.ForeColor = Color.Blue;

            //    ftrFrontHeight.Text = "Lower front ride height. Stage: " + _result.Springs.Height.Front;
            //    ftrFrontHeight.ForeColor = Color.Blue;
            //}
        }

        private void cmbDrivetrain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
