using System;

namespace ruscehproj2
{
    public partial class bv004 : genericForm
    {
        private readonly int kitId; //первый или второй комплект ололол задавать при ините
        private readonly priborC4353 pribor = new priborC4353();

        public bv004(int _id)
        {
            InitializeComponent();
            bulb1.setLampType("green");
            kitId = _id;
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

        private void bv004_Load(object sender, EventArgs e)
        {
            try
            {
                if ((kitId == 1 && FormManager.bv10.kit1.state) || (kitId == 2 && FormManager.bv10.kit2.state))
                    bulb1.setState(true);
                else bulb1.setState(false);
            }
            catch
            {
            }
        }

        private void vol220_400_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bv004_vol220400"))
            {
                pribor.setInitialValue(75);
                pribor.Show();
            }
        }

        private void minus105_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bv004_minus105"))
            {
                pribor.setInitialValue(30);
                pribor.Show();
            }
        }

        private void plus250_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bv004_plus250"))
            {
                pribor.setInitialValue(85);
                pribor.Show();
            }
        }

        private void signalVU_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bv004_signalVU"))
            {
                FormManager.Init_e("OSC");
                FormManager.OSC.refresh(@"graph\pila.txt");
            }
        }

        private void fuse1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bv004_fuse1");
        }
    }
}