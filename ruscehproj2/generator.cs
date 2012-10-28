using System;

namespace ruscehproj2
{
    public partial class generator : genericForm
    {
        public bool tuned = false;

        public generator()
        {
            InitializeComponent();
        }

        public generator(bool _in)
        {
            InitializeComponent();
            tuned = _in;
        }

        private void atten_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + atten.Name + "_" + atten.getValue());
            try
            {
                if (tuned)
                {
                    FormManager.BSH001.voltmetr1.Set_Value = atten.getValue();
                    voltmetr1.Set_Value = atten.getValue()/2;
                }
                else
                {
                    FormManager.BSH001.voltmetr1.Set_Value = atten.getValue();
                    voltmetr1.Set_Value = atten.getValue();
                }
            }
            catch
            {
            }
        }

        private void freq_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + freq.Name + "_" + freq.getValue());
            /*
            FormManager.OSC.gain = amp.getValue() * 0.01;
            FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mY = FormManager.OSC.voltageY.Set_Value * FormManager.OSC.gain;
            FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mY *= 0.001 * FormManager.OSC.picture_Box_for_Oscilloscope1.Set_step_Y;
            FormManager.OSC.refresh();
            FormManager.hlp.hlpRefresh("bk006_panel1_amp_" + amp.getValue());
             * */
        }

        private void output_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + output.Name + "_" + output.getValue());
        }

        private void levelControl_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + levelControl.Name);
            levelControl.BackgroundImage = Resources.wire1;
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.State.ToString());
        }

        private void sinhr_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + sinhr.Name);
        }
    }
}