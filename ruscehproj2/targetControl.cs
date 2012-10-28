using System;

namespace ruscehproj2
{
    public partial class targetControl : genericForm
    {
        public targetControl()
        {
            InitializeComponent();
            refresh(0);
        }

        public void refresh(int num)
        {
            switch (num)
            {
                case 0:
                    numericUpDown1.Value = FormManager.IKO.ikO_control1.Targ1.Az;
                    numericUpDown2.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ1.Dal);
                    numericUpDown4.Value = FormManager.IKO.ikO_control1.Targ2.Az;
                    numericUpDown3.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ2.Dal);
                    numericUpDown8.Value = FormManager.IKO.ikO_control1.Targ3.Az;
                    numericUpDown7.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ3.Dal);
                    numericUpDown6.Value = FormManager.IKO.ikO_control1.Targ4.Az;
                    numericUpDown5.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ4.Dal);
                    numericUpDown12.Value = FormManager.IKO.ikO_control1.Targ5.Az;
                    numericUpDown11.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ5.Dal);
                    numericUpDown10.Value = FormManager.IKO.ikO_control1.Targ6.Az;
                    numericUpDown9.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ6.Dal);
                    break;
                case 1:
                    numericUpDown1.Value = FormManager.IKO.ikO_control1.Targ1.Az;
                    numericUpDown2.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ1.Dal);
                    break;
                case 2:
                    numericUpDown4.Value = FormManager.IKO.ikO_control1.Targ2.Az;
                    numericUpDown3.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ2.Dal);
                    break;
                case 3:
                    numericUpDown8.Value = FormManager.IKO.ikO_control1.Targ3.Az;
                    numericUpDown7.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ3.Dal);
                    break;
                case 4:
                    numericUpDown6.Value = FormManager.IKO.ikO_control1.Targ4.Az;
                    numericUpDown5.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ4.Dal);
                    break;
                case 5:
                    numericUpDown12.Value = FormManager.IKO.ikO_control1.Targ5.Az;
                    numericUpDown11.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ5.Dal);
                    break;
                case 6:
                    numericUpDown10.Value = FormManager.IKO.ikO_control1.Targ6.Az;
                    numericUpDown9.Value = Convert.ToInt32(FormManager.IKO.ikO_control1.Targ6.Dal);
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ1.Az = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ1.Dal = Convert.ToDouble(numericUpDown2.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ2.Az = Convert.ToInt32(numericUpDown4.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ2.Dal = Convert.ToDouble(numericUpDown3.Value);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ3.Az = Convert.ToInt32(numericUpDown8.Value);
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ3.Dal = Convert.ToDouble(numericUpDown7.Value);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ4.Az = Convert.ToInt32(numericUpDown6.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ4.Dal = Convert.ToDouble(numericUpDown5.Value);
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ5.Az = Convert.ToInt32(numericUpDown12.Value);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ5.Dal = Convert.ToDouble(numericUpDown11.Value);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ6.Az = Convert.ToInt32(numericUpDown10.Value);
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            FormManager.IKO.ikO_control1.Targ6.Dal = Convert.ToDouble(numericUpDown9.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
            numericUpDown2.Enabled = checkBox1.Checked;
            FormManager.IKO.ikO_control1.Targ1.show = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = checkBox2.Checked;
            numericUpDown4.Enabled = checkBox2.Checked;
            FormManager.IKO.ikO_control1.Targ2.show = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown7.Enabled = checkBox3.Checked;
            numericUpDown8.Enabled = checkBox3.Checked;
            FormManager.IKO.ikO_control1.Targ3.show = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown5.Enabled = checkBox4.Checked;
            numericUpDown6.Enabled = checkBox4.Checked;
            FormManager.IKO.ikO_control1.Targ4.show = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown11.Enabled = checkBox5.Checked;
            numericUpDown12.Enabled = checkBox5.Checked;
            FormManager.IKO.ikO_control1.Targ5.show = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown9.Enabled = checkBox6.Checked;
            numericUpDown10.Enabled = checkBox6.Checked;
            FormManager.IKO.ikO_control1.Targ6.show = checkBox6.Checked;
        }
    }
}