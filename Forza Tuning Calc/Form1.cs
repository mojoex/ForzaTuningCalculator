using Forza_Tuning_Calculator.DTO;
using Forza_Tuning_Calculator.DTO.Constants;
using Forza_Tuning_Calculator.DTO.Input;
using Forza_Tuning_Calculator.DTO.Result;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Forza_Tuning_Calculator
{

    public partial class ForzaTuningCalc : Form
    {
        private Utils _utils;
        private BaseTune _base;
        private FineTune _fineTune;

        int windowHeight;

        bool baseComplete = false;

        public ForzaTuningCalc()
        {
            InitializeComponent();
            PopulateDataSources();
            _utils = new Utils();

            windowHeight = this.Height;

            this.MinimumSize = new Size(this.Width, this.Height - gbFineTuning.Size.Height);
            this.Height = windowHeight - gbFineTuning.Size.Height;
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

                SetResult(baseTune);

                SetResultVisible();

                _base = baseTune;
            }
        }

        private void SetResult(BaseTune result)
        {
            foreach (ListViewItem item in resultsList.Items)
            {
                if (_base != null && _base != result)
                {
                    while (item.SubItems.Count > 1)
                    {
                        item.SubItems.RemoveAt(1);
                    }
                }

                item.SubItems.AddRange(AddSubItemData(item.Text, result));
            }
        }

        private ListViewSubItem[] AddSubItemData(string source, BaseTune result)
        {
            var list = new List<ListViewSubItem>();

            switch (source)
            {
                // Suspension
                case SuspensionConstants.SpringRatesTitle:
                    list.Add(CreateSubItem(SuspensionConstants.FrontSpringRate, result.Suspension.Springs.SpringRate.Front));
                    list.Add(CreateSubItem(SuspensionConstants.RearSpringRate, result.Suspension.Springs.SpringRate.Rear));
                    break;

                case SuspensionConstants.RideHeightTitle:
                    list.Add(CreateStringSubItem(SuspensionConstants.FrontRideHeight, result.Suspension.Springs.RideHeight.StringFront));
                    list.Add(CreateStringSubItem(SuspensionConstants.RearRideHeight, result.Suspension.Springs.RideHeight.StringRear));
                    break;

                case SuspensionConstants.Rebound:
                    list.Add(CreateSubItem(SuspensionConstants.ReboundFront, result.Suspension.Damping.Rebound.Front));
                    list.Add(CreateSubItem(SuspensionConstants.ReboundRear, result.Suspension.Damping.Rebound.Rear));
                    break;

                case SuspensionConstants.Bump:
                    list.Add(CreateSubItem(SuspensionConstants.BumpFront, result.Suspension.Damping.Bump.Front50));
                    list.Add(CreateSubItem(SuspensionConstants.BumpRear, result.Suspension.Damping.Bump.Rear50));
                    break;

                // ARB
                case ArbConstants.ARB:
                    list.Add(CreateSubItem(ArbConstants.ArbFront, result.ARB.Front));
                    list.Add(CreateSubItem(ArbConstants.ArbRear, result.ARB.Rear));
                    break;

                // Alignment
                case AlignmentConstants.CamberTitle:
                    list.Add(CreateSubItem(AlignmentConstants.FrontCamber, result.Alignment.CamberFront));
                    list.Add(CreateSubItem(AlignmentConstants.RearCamber, result.Alignment.CamberRear));
                    break;

                case AlignmentConstants.Castor:
                    list.Add(CreateSubItem(AlignmentConstants.Castor, result.Alignment.CastorAngle));
                    break;

                case AlignmentConstants.ToeTitle:
                    list.Add(CreateSubItem(AlignmentConstants.FrontToe, result.Alignment.ToeFront));
                    list.Add(CreateSubItem(AlignmentConstants.RearToe, result.Alignment.ToeRear));
                    break;

                // Diff
                case DifferentialConstants.AccelTitle:
                    list.Add(CreateSubItem(DifferentialConstants.FrontAccel, result.Diff.FrontAccel));
                    list.Add(CreateSubItem(DifferentialConstants.RearAccel, result.Diff.RearAccel));
                    break;

                case DifferentialConstants.DecelTitle:
                    list.Add(CreateSubItem(DifferentialConstants.FrontDecel, result.Diff.FrontDecel));
                    list.Add(CreateSubItem(DifferentialConstants.RearDecel, result.Diff.RearDecel));
                    break;

                case DifferentialConstants.DiffBias:
                    list.Add(CreateSubItem(DifferentialConstants.DiffBias, result.Diff.Bias));
                    break;

                // Tyres
                case TyrePressureConstants.PressureTitle:
                    list.Add(CreateSubItem(TyrePressureConstants.FrontPressure, result.TyrePressure.FrontPsi));
                    list.Add(CreateSubItem(TyrePressureConstants.RearPressure, result.TyrePressure.RearPsi));
                    break;

                // Aero
                case AeroConstants.DownforceTitle:
                    list.Add(CreateStringSubItem(AeroConstants.FrontAero, result.Aero.StringFront));
                    list.Add(CreateStringSubItem(AeroConstants.RearAero, result.Aero.StringRear));
                    break;
            }

            return list.ToArray();
        }

        private ListViewSubItem CreateSubItem(string name, double value)
        {
            var result = new ListViewSubItem()
            {
                Name = name,
                Text = value != -99 ? value.ToString("n2") : "n/a"
            };

            return result;
        }

        private ListViewSubItem CreateStringSubItem(string name, string value)
        {
            var result = new ListViewSubItem()
            {
                Name = name,
                Text = value
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
            if (string.IsNullOrEmpty(inputFrontWeight.Text))
            {
                _utils.ShowError("Front Weight %");
                return false;
            }

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

            result.Drivetrain = cmbDrivetrain.SelectedItem.ToString();

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

        private void gbFineTuning_Enter(object sender, EventArgs e)
        {

        }

        private void chkFineTuning_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkFineTuning.CheckState)
            {
                case CheckState.Checked:
                    gbFineTuning.Visible = true;
                    this.Height = windowHeight;
                    break;

                case CheckState.Unchecked:
                    gbFineTuning.Visible = false;
                    this.Height = windowHeight - gbFineTuning.Size.Height;
                    break;
            }
        }
    }
}
