using System;

namespace ruscehproj2
{
    public partial class bsh003 : genericForm
    {
        public bsh003()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            bulb2.setLampType("green");
            bulb3.setLampType("green");
            rsbnMode.setPosNum(2);
        }

        private void otkl1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl1.Name))
                bulb2.setState(false);
        }

        private void vkl1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl1.Name))
                bulb1.setState(true);
        }

        private void vkl2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl2.Name))
                bulb2.setState(true);
        }

        private void otkl2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl2.Name))
                bulb1.setState(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bulb3.setState(!bulb3.getState());
        }

        private void tumbler1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh003_callTumb_" + callTumb.State.ToString()))
            {
                if (callTumb.State)
                {
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    bulb3.setState(false);
                }
            }
        }

        private void rsbnMode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bsh003_rsbnMode_" + rsbnMode.Step.ToString());
        }

        private void sovm36_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh003_sovm36"))
            {
                if (FormManager.hlp.scenarioId == 6)
                {
                    FormManager.Init_e("MAH");
                    FormManager.Init_e("OSC");
                    FormManager.OSC.refresh(@"graph\step.txt");
                    FormManager.MAH.TopMost = true;
                    Top = 0;
                    Left = 0;
                    FormManager.MAH.Top = 0;
                    FormManager.MAH.Left = Width + 10;
                    FormManager.MAH.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
                else
                {
                    var OSC = new Oscilloscope(@"graph\step.txt");
                    OSC.Show();
                }
            }
        }

        private void sovm35_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bsh003_sovm35");
        }

        private void signC_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh003_signC_On"))
            {
                FormManager.Init_e("MAH");
                FormManager.Init_e("OSC");
                FormManager.MAH.TopMost = true;
                Top = 0;
                Left = 0;
                FormManager.MAH.Top = 0;
                FormManager.MAH.Left = Width + 10;
                FormManager.MAH.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            if (FormManager.hlp.hlpRefresh("bsh003_signC_Off"))
            {
                FormManager.OSC.refresh(@"graph\clean.txt");
                FormManager.Init_e("MAH");
                FormManager.Init_e("OSC");
                FormManager.MAH.TopMost = true;
                Top = 0;
                Left = 0;
                FormManager.MAH.Top = 0;
                FormManager.MAH.Left = Width + 10;
            }
        }

        private void sign180_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh003_sign180"))
            {
                FormManager.Init_e("MAH");
                FormManager.Init_e("OSC");
                FormManager.MAH.TopMost = true;
                Top = 0;
                Left = 0;
                FormManager.MAH.Top = 0;
                FormManager.MAH.Left = Width + 10;
                FormManager.MAH.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void sovmSign180_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh003_sovmSign180"))
            {
                FormManager.OSC.refresh(@"graph\steps.txt");
                FormManager.Init_e("MAH");
                FormManager.Init_e("OSC");
                FormManager.MAH.TopMost = true;
                Top = 0;
                Left = 0;
                FormManager.MAH.Top = 0;
                FormManager.MAH.Left = Width + 10;
                FormManager.MAH.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void bsh003_Load(object sender, EventArgs e)
        {
        }

        private void signC_Load(object sender, EventArgs e)
        {
        }
    }
}