using System;

namespace ruscehproj2
{
    public partial class bg002 : genericForm
    {
        private readonly Random R = new Random();

        public bg002()
        {
            InitializeComponent();
            mode.setPosNum(6);
        }

        private void mode_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg002_mode_" + mode.Step.ToString()))
            {
                Top = 0;
                Left = 0;
                FormManager.bg31.Top = 0;
                FormManager.bg31.Left = Width + 10;
                FormManager.bg31.Show();
                FormManager.bg31.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            if (mode.Step != 4)
            {
                voltmetr1.Set_Value = R.Next(15);
            }
            if (FormManager.hlp.hlpRefresh("bg002_mode_" + mode.Step.ToString())) FormManager.hlp.decrErrorCount();
        }

        private void ground1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bg002_ground1"))
            {
                FormManager.Init_e("OSC");
                FormManager.OSC.refresh(@"graph\steps.txt");
                Top = 0;
                Left = 0;
                FormManager.OSC.Top = 0;
                FormManager.OSC.Left = Width + 10;
            }
        }
    }
}