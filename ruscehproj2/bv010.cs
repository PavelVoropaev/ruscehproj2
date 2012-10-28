using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bv010 : genericForm
    {
        private readonly priborC4353 pribor = new priborC4353();
        private readonly Random r = new Random();
        private int time = 100;
        private int tmp = -1;

        public bv010()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            bulb2.setLampType("green");
        }

        private void sar1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + sar1.Name))
                bulb1.setState(true);
            timer1.Start();
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name))
            {
                bulb1.setState(false);
                bulb2.setState(false);
                voltmetr1.Set_Value = 0;
                timer1.Stop();
            }
        }

        private void kit1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + kit1.Name))
                bulb1.setState(true);
            voltmetr1.Set_Value = 50;
        }

        private void kit2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + kit2.Name))
                bulb2.setState(true);
            voltmetr1.Set_Value = 50;
        }

        private void eject_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(amp.Name.ToString());

            if (panel1.Visible)
            {
                panel1.Visible = false;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_Off");
                //voltmetr1.Left = 230;
                voltmetr1.Top = 186;
            }
            else
            {
                panel1.Visible = true;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_On");
                //voltmetr1.Left = 230;
                voltmetr1.Top = 230;
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_panel1_" + amp.Name + "_" + amp.getValue());
        }

        private void feedb_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            //  if (FormManager.hlp.hlpRefresh(this.Name + "_panel1_" + feedb.Name + "_" + feedb.getValue()))
            {
                if (feedb.getValue() < 40 || feedb.getValue() > 90 || phase.getValue() < 40 || phase.getValue() > 90)
                {
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    voltmetr1.Set_Value = 50;
                }
            }
        }

        private void phase_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            //if (FormManager.hlp.hlpRefresh(this.Name + "_panel1_" + phase.Name + "_" + phase.getValue()))
            {
                if (feedb.getValue() < 40 || feedb.getValue() > 90 || phase.getValue() < 40 || phase.getValue() > 90)
                {
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    voltmetr1.Set_Value = 50;
                }
            }
        }

        private void zeroPd_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (!pribor.isOpened)
            {
                pribor.Show();
                pribor.TopMost = true;
                pribor.Text = "Прибор Ц-4353 (подключён к гнезду СИГНАЛ ТГП блока БВ-004)";
                pribor.Top = Top + Height;
            }
            FormManager.hlp.hlpRefresh(Name + "_panel1_" + zeroPd.Name + "_" + zeroPd.getValue());
            pribor.setInitialValue(zeroPd.getValue() + 10);
        }

        private void bv010_Load(object sender, EventArgs e)
        {
        }

        private void bv010_FormClosing(object sender, FormClosingEventArgs e)
        {
            //timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FormManager.hlp.scenarioId == 4)
                voltmetr1.Set_Value = 45 + r.Next(10);
            if (FormManager.hlp.scenarioId != 4)
            {
                if (time*time > 16)
                    time--;
                tmp = -tmp;
                voltmetr1.Set_Value = 50 + r.Next(time/2)*tmp;
            }
        }
    }
}