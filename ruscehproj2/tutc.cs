using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class tuts : genericForm
    {
        private const int time = 80;
        private readonly Random R = new Random();
        private readonly Timer T = new Timer();

        private readonly Timer Time = new Timer();
        private readonly Timer time_machine = new Timer();
        private int gain = 7;

        private int time1;
        private int time2;
        private int tmp = -1;

        public tuts()
        {
            InitializeComponent();
            vpl_sw.isSided = true;
            tumbler2.isSided = true;
            tumbler2.State = false;
            bulb1.setLampType("red");
            ContrPar.setPosNum(11);
            balans.setPosNum(11);
            T.Tick += T_Tick;
            chuv.Set_Value = 50;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + fence.Name))
            {
            }
        }

        private void pwr_Click(object sender, EventArgs e)
        {
            Time.Tick += Time_Tick;
            Time.Start();
            if (FormManager.hlp.scenarioId == 20)
                FormManager.bya1.Activate();
            if (FormManager.hlp.hlpRefresh(Name + "_" + pwr.Name + "_" + pwr.State.ToString()))
            {
                if (FormManager.hlp.scenarioId == 19)
                {
                    FormManager.bya1.Activate();
                    FormManager.hlp.hlpRefresh("");
                }
                else
                {
                    textBox14.BackColor = Color.Green;
                    textBox15.BackColor = Color.Green;
                }
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            tmp = -tmp;
            voltmetr1.Set_Value = 50 + (time/2)*tmp;
        }

        private void vkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name))
            {
                textBox10.BackColor = Color.Green;
                time_machine.Tick += time_machine_Tick;
                time_machine.Start();
            }
        }

        private void time_machine_Tick(object sender, EventArgs e)
        {
            time1++;
            if (time1 == 10)
            {
                textBox16.BackColor = Color.Green;
                textBox1.BackColor = Color.Yellow;
                textBox6.BackColor = Color.Yellow;
                time1 = 102;
                voltmetr1.Set_Value = 67;
                time_machine.Stop();
            }
        }

        private void tuts_Load(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("");
            if (FormManager.hlp.helpEnabled())
                FormManager.hlp.Show();
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + d1.Name))
            {
                textBox9.BackColor = Color.Green;
            }
        }

        private void d2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + d1.Name))
            {
                textBox13.BackColor = Color.Green;
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + a1.Name))
            {
                textBox7.BackColor = Color.Green;
                time_machine.Tick -= time_machine_Tick;
                time_machine.Tick += time_machine_Tick2;
                time_machine.Start();
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + a1.Name))
            {
                textBox11.BackColor = Color.Green;
                time_machine.Tick -= time_machine_Tick;
                time_machine.Tick += time_machine_Tick2;
                time_machine.Start();
            }
        }

        private void time_machine_Tick2(object sender, EventArgs e)
        {
            time2++;
            if (time2 == 10)
            {
                FormManager.tuts1.textBox4.BackColor = Color.White;
                FormManager.tuts1.textBox3.BackColor = Color.White;
                FormManager.tuts1.textBox1.BackColor = Color.Gray;
                FormManager.tuts1.textBox6.BackColor = Color.Gray;
                time2 = 0;
                FormManager.hlp.hlpRefresh("tuts_a1_done");
                time_machine.Stop();
            }
        }

        private void a2off_Click(object sender, EventArgs e)
        {
            if (textBox11.BackColor == Color.Green)
                if (FormManager.hlp.hlpRefresh(Name + "_" + a1off.Name))
                {
                    textBox11.BackColor = Color.Gray;
                }
        }

        private void a1off_Click(object sender, EventArgs e)
        {
            if (textBox7.BackColor == Color.Green)
                if (FormManager.hlp.hlpRefresh(Name + "_" + a1off.Name))
                {
                    textBox7.BackColor = Color.Gray;
                }
        }

        private void d1off_Click(object sender, EventArgs e)
        {
            if (textBox9.BackColor == Color.Green)
                if (FormManager.hlp.hlpRefresh(Name + "_" + d1off.Name))
                {
                    textBox9.BackColor = Color.Gray;
                }
        }

        private void d2off_Click(object sender, EventArgs e)
        {
            if (textBox13.BackColor == Color.Green)
                if (FormManager.hlp.hlpRefresh(Name + "_" + d1off.Name))
                {
                    textBox13.BackColor = Color.Gray;
                }
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name))
            {
                textBox15.BackColor = Color.Gray;
                textBox14.BackColor = Color.Gray;
                textBox16.BackColor = Color.Gray;
                textBox10.BackColor = Color.Gray;
                textBox4.BackColor = Color.Gray;
                textBox3.BackColor = Color.Gray;
            }
        }

        private void tuts_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.disp();
        }

        private void ContrPar_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("tuts_ContrPar_" + ContrPar.Step.ToString()))
            {
                if (ContrPar.Step == 9)
                {
                    T.Tick -= T_Tick;
                    T.Tick += T_Tick2;
                    T.Interval = 100;
                    T.Start();
                }
            }
        }

        private void tumbler2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("tuts_tumbler2_" + tumbler2.State.ToString()))
            {
                bulb1.setState(true);
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            bulb1.setState(!bulb1.getState());
        }

        private void balans_Click(object sender, EventArgs e)
        {
            T.Start();
            if (balans.Step != 0)
                T.Interval = balans.Step*100;
            if (FormManager.hlp.hlpRefresh("tuts_balans_" + balans.Step.ToString()))
            {
                T.Stop();
                textBox15.BackColor = Color.Green;
                bulb1.setState(false);
                FormManager.bya1.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }

        private void chuv_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("tuts_chuv_" + chuv.getValue().ToString());
        }

        private void T_Tick2(object sender, EventArgs e)
        {
            gain *= -1;
            voltmetr1.Set_Value = 50 + gain + R.Next(chuv.getValue()/4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("End");
        }
    }
}