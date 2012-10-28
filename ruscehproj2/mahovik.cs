using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class mahovik : genericForm
    {
        public mahovik()
        {
            InitializeComponent();
        }


        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (potenzhiomert1.getValue() > 9)
            {
                if (FormManager.hlp.hlpRefresh("mahovik_potenzhiomert1_" + potenzhiomert1.getValue().ToString()))
                {
                    if (potenzhiomert1.getValue() == 99)
                        Dispose();
                    FormManager.bsh03.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
                FormManager.OSC.gain = potenzhiomert1.getValue()*0.01;
                FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mX = FormManager.OSC.voltageX.Set_Value*
                                                                       FormManager.OSC.gain;
                FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mX *= 0.001*
                                                                        FormManager.OSC.picture_Box_for_Oscilloscope1.
                                                                            Set_step_X;
                FormManager.OSC.picture_Box_for_Oscilloscope1.pictureBox1.Invalidate();
            }
            FormManager.OSC.resY = FormManager.OSC.voltageY.getValue();
        }

        private void mahovik_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormManager.OSC.Dispose();
            FormManager.OSC.Hide();
        }

        private void mahovik_Load(object sender, EventArgs e)
        {
            FormManager.Init_e("OSC");
            FormManager.OSC.Top = Height;
            FormManager.OSC.Left = FormManager.bsh03.Width;
        }
    }
}