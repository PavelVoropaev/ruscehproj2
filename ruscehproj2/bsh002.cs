using System;

namespace ruscehproj2
{
    public partial class bsh002 : genericForm
    {
        public bsh002()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            codes.setPosNum(4);
            voltageChk.setPosNum(3);
            FormManager.Init_e("OSC");
            FormManager.OSC.Hide();
        }

        private void vkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name))
                bulb1.setState(true);
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name))
                bulb1.setState(false);
        }

        private void voltageChk_Click(object sender, EventArgs e)
        {
            switch (voltageChk.Step)
            {
                case 0:
                    voltmetr1.Set_Value = 0;
                    break;
                case 1:
                    voltmetr1.Set_Value = 45;
                    break;
                case 2:
                    voltmetr1.Set_Value = 95;
                    break;
            }
        }

        private void vhodVU_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_vhodVU"))
            {
                FormManager.OSC.refresh(@"graph\vhodVU.txt");
                FormManager.OSC.Show();
            }
        }

        private void vyhodVU_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_vyhodVU"))
            {
                FormManager.OSC.refresh(@"graph\vyhodVU.txt");
                FormManager.OSC.Show();
            }
        }

        private void vyhDshDal_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_vyhDshDal"))
            {
                FormManager.OSC.refresh(@"graph\vyhDshDal.txt");
                FormManager.OSC.Show();
            }
        }

        private void indikac_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_indikac"))
            {
                FormManager.OSC.refresh(@"graph\indikac.txt");
                FormManager.OSC.Show();
            }
        }

        private void zapShaShd_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_zapShaShd"))
            {
                FormManager.OSC.refresh(@"graph\zapShaShd.txt");
                FormManager.OSC.Show();
            }
        }

        private void pomehVyhod_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bsh002_pomehVyhod"))
            {
                FormManager.OSC.refresh(@"graph\pomehVyhod.txt");
                FormManager.OSC.Show();
            }
        }

        private void codes_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + codes.Name + "_" + codes.Step.ToString());
        }
    }
}