using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bk007 : genericForm
    {
        private int delay;

        public bk007()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            bulb2.setLampType("red");
            bulb2.setState(true);
            missing180.setLampType("red");
            mode.setPosNum(2);
            FormManager.Init_e("OSC");
            FormManager.OSC.Hide();
        }

        private void vkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name))
            {
                bulb1.setState(true);
            }
        }

        public void connect(bsh001 bsh)
        {
            bsh.onRegZadChange += bsh_onRegZadChange;
        }

        private void bsh_onRegZadChange(object _in, CustomEventArgs e)
        {
            int sum = e.value*10 + e.value1;
            if (sum > 80 && sum < 96)
            {
                bulb2.setState(true);
            }
            bulb2.setState(sum < 73);
        }

        private void eject_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_Off");
            }
            else
            {
                pictureBox1.Visible = true;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_On");
            }
        }

        private void selfControl_MouseDown(object sender, MouseEventArgs e)
        {
            bulb2.setState(false);
            FormManager.hlp.hlpRefresh("bk007_selfTest_down");
        }

        private void selfTest_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            delay++;
            if (delay > 25)
            {
                bulb2.setState(true);
                delay = 0;
                FormManager.hlp.hlpRefresh("bk007_selfTest_release");
                timer1.Stop();
            }
        }

        private void bk007_Load(object sender, EventArgs e)
        {
            try
            {
                missing180.setState(FormManager.bsh03.rsbnMode.Step == 0);
                if (FormManager.BSH001.msek.Step == 5 && FormManager.BSH001.regZad.Step == 9)
                {
                    timer1.Stop();
                    bulb2.setState(false);
                    missing180.setState(false);
                }
            }
            catch
            {
                bulb2.setState(false);
                missing180.setState(false);
            }
        }


        private void mode_Click_1(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
        }

        private void vhodCPU_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_vhodCPU"))
            {
                Top = 0;
                Left = 0;
                FormManager.OSC.Top = 0;
                FormManager.OSC.Left = Width + 10;
                FormManager.OSC.refresh(@"graph\vhodCPU.txt");
                FormManager.OSC.Show();
            }
        }

        private void otvetny_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_otvetny"))
            {
                FormManager.OSC.refresh(@"graph\otvetny.txt");
                FormManager.OSC.Show();
            }
        }

        private void signal180_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_signal180"))
            {
                FormManager.OSC.refresh(@"graph\signal180.txt");
                FormManager.OSC.Show();
            }
        }

        private void quarz_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_quarz"))
            {
                FormManager.OSC.refresh(@"graph\quarz.txt");
                FormManager.OSC.Show();
            }
        }

        private void modOtrImp_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_modOtrImp"))
            {
                FormManager.OSC.refresh(@"graph\modOtrImp.txt");
                FormManager.OSC.Show();
            }
        }

        private void modGss_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk007_modGss"))
            {
                FormManager.OSC.refresh(@"graph\modGss.txt");
                FormManager.OSC.Show();
            }
        }

        private void contrReg_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bk007_contrReg");
            try
            {
                FormManager.BSH001.Show();
                bulb2.setState(true);
                connect(FormManager.BSH001);
                FormManager.BSH001.Activate();
                FormManager.hlp.hlpRefresh("");
            }
            catch
            {
            }
        }
    }
}