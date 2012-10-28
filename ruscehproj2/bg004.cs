using System;

namespace ruscehproj2
{
    public partial class bg004 : genericForm
    {
        public bg004()
        {
            InitializeComponent();
            mode.setPosNum(6);
            mode.Step = 1;
        }

        private void nPosSwitch1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg004_mode_" + mode.Step.ToString()))
            {
                Top = 0;
                Left = 0;
                if (mode.Step < 3)
                {
                    FormManager.bg51.Show();
                    FormManager.bg51.TopMost = true;
                    FormManager.bg51.Left = Width;
                    FormManager.bg51.Top = 0;
                    FormManager.bg51.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
            }
            var R = new Random();
            voltmetr1.Set_Value = R.Next(15);
        }

        private void ground1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg004_ground1"))
            {
                FormManager.Init_e("OSC");
                FormManager.OSC.refresh(@"graph\steps.txt");
                Top = 0;
                Left = 0;
                FormManager.OSC.Top = 0;
                FormManager.OSC.Left = Width + 10;
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert1.getValue();
            FormManager.hlp.hlpRefresh("bg004_potenzhiomert1_" + potenzhiomert1.getValue().ToString());
        }

        private void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert2.getValue();
            FormManager.hlp.hlpRefresh("bg004_potenzhiomert2_" + potenzhiomert2.getValue().ToString());
        }

        private void potenzhiomert3_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.bg0041.voltmetr1.Set_Value = potenzhiomert3.getValue();
            FormManager.hlp.hlpRefresh("bg004_potenzhiomert3_" + potenzhiomert3.getValue().ToString());
        }
    }
}