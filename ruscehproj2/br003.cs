using System;

namespace ruscehproj2
{
    public partial class br003 : genericForm
    {
        public br003()
        {
            InitializeComponent();
            mode.setPosNum(9);
        }

        private void vkl_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name);
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name);
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
            switch (mode.Step)
            {
                case 6:
                    voltmetr1.Set_Value = 75;
                    preVyh.Enabled = false;
                    vyhod.Enabled = false;
                    getPwr.Enabled = false;
                    timer1.Stop();
                    break;
                case 7:
                    voltmetr1.Set_Value = 50;
                    preVyh.Enabled = false;
                    vyhod.Enabled = false;
                    getPwr.Enabled = false;
                    timer1.Stop();
                    break;
                case 8:
                    voltmetr1.Set_Value = 32;
                    preVyh.Enabled = false;
                    vyhod.Enabled = false;
                    getPwr.Enabled = false;
                    timer1.Stop();
                    break;
                case 1:
                    voltmetr1.Set_Value = 80;
                    preVyh.Enabled = true;
                    getPwr.Enabled = true;
                    vyhod.Enabled = false;
                    timer1.Stop();
                    break;
                case 2:
                    voltmetr1.Set_Value = 80;
                    preVyh.Enabled = false;
                    vyhod.Enabled = true;
                    getPwr.Enabled = true;
                    timer1.Stop();
                    break;
                case 3:
                    voltmetr1.Set_Value = 80;
                    preVyh.Enabled = false;
                    vyhod.Enabled = false;
                    getPwr.Enabled = false;
                    timer1.Start();
                    break;
                default:
                    voltmetr1.Set_Value = 10;
                    preVyh.Enabled = false;
                    vyhod.Enabled = false;
                    getPwr.Enabled = false;
                    timer1.Stop();
                    break;
            }
        }

        private void mechZero_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mechZero.Name + "_" + mechZero.getValue().ToString());
            voltmetr1.Set_Value = mechZero.getValue()/5 - 10;
        }

        private void voltmetr1_Click(object sender, EventArgs e)
        {
        }

        private void preVyh_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + preVyh.Name + "_" + preVyh.getValue().ToString());
            voltmetr1.Set_Value = preVyh.getValue() + 20;
        }

        private void vyhod_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + vyhod.Name + "_" + vyhod.getValue().ToString());
            voltmetr1.Set_Value = vyhod.getValue() + 20;
        }

        private void getPwr_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + getPwr.Name + "_" + getPwr.getValue().ToString());
            voltmetr1.Set_Value = getPwr.getValue() + 60;
        }

        private void de_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_de"))
            {
                FormManager.Init_e("OSC");
                FormManager.OSC.refresh(@"graph\steps.txt");
                FormManager.OSC.Show();
                FormManager.OSC.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_a"))
            {
                FormManager.Init_e("OSC");
                FormManager.OSC.refresh(@"graph\vhodAz.txt");
                FormManager.OSC.Show();
                FormManager.OSC.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            voltmetr1.Set_Value = 40 + r.Next(20);
        }
    }
}