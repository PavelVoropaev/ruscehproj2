using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bk006 : genericForm
    {
        private int _delay;
        private bool _flag3Steps;

        public bk006()
        {
            InitializeComponent();
            bulb1.setLampType("green");
            mode.setPosNum(3);
            nPosSwitch2.setPosNum(3);
            indikacia.setPosNum(9);
            bulb2.setLampType("red");
            bulb3.setLampType("red");
            bulb4.setLampType("green");
            left.setLampType("green");
            right.setLampType("green");
            //potenzhiometr1.Set_Value = 50;
            FormManager.OSC = new Oscilloscope(@"graph\clean.txt");
        }


        //подрубаем обработчик к осциллографу

        public void connect(Oscilloscope OSC) //на входе осциллограф
        {
            OSC.onResolutionChange += OSC_onResolutionChange; //линкуемся, нажимаем TAB 
        }

        public void disconnect(Oscilloscope OSC)
        {
            OSC.onResolutionChange -= OSC_onResolutionChange;
        }

        public void connect(bv012 _bv) //на входе осциллограф
        {
            //OSC.onResolutionChange += new Oscilloscope.EventHandler(OSC_onResolutionChange); //линкуемся, нажимаем TAB 
            _bv.onSelsinCheck += _bv_onSelsinCheck;
        }

        private void _bv_onSelsinCheck(object _in, CustomEventArgs e)
        {
            FormManager.hlp.hlpRefresh("bv012_selsinZero_" + e.value);
            if (e.value > 60)
            {
                left.setState(true);
                right.setState(false);
            }
            if (e.value < 40)
            {
                left.setState(false);
                right.setState(true);
            }
            if (e.value > 49 && e.value < 51)
            {
                left.setState(true);
                right.setState(true);
                //System.Threading.Thread.Sleep(1000);
                Activate();
                FormManager.hlp.hlpRefresh("");
                //this.Hide();
            }
            if (e.value > 80 && e.value < 90)
            {
                timer1.Interval = 1300;
            }
            if (e.value == 98)
            {
                //timer1.Stop();
                bulb2.setState(true);
                FormManager.OSC.Activate();
                FormManager.hlp.hlpRefresh("");
                Hide();
            }
            if (e.value == 2)
            {
                //timer1.Stop();
                bulb2.setState(true);
                FormManager.OSC.Activate();
                FormManager.hlp.hlpRefresh("");
                Hide();
            }
        }

        //создаётся местная реализация метода onResolutionChange

        private void OSC_onResolutionChange(object potezhiometer, CustomEventArgs scrollInfo)
        {
            //throw new NotImplementedException(); я не знаю что это писал не я 
            // MessageBox.Show("Oscilloscope resolution changed!"); // делаем чего хотим кидаем алёрты например

            if (scrollInfo.axis == "x")
            {
                FormManager.hlp.hlpRefresh(FormManager.OSC.Name + "_voltageX_" + scrollInfo.value);
            }
            if (scrollInfo.value > 80 && scrollInfo.axis == "x")
            {
                timer3.Start();
            }
            if (scrollInfo.value < 70 && scrollInfo.axis == "x")
            {
                timer3.Stop();

                FormManager.OSC.refresh(@"graph\vhodAz.txt");
            }
        }

        private void vkl_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name))
            {
                bulb1.setState(true);
            }
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
            if (mode.Step == 2)
            {
                bulb2.setState(true);
                bulb3.setState(true);
            }
            else
            {
                bulb2.setState(false);
                bulb3.setState(false);
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + potenzhiometr1.Name + "_" + potenzhiometr1.getValue());
            if (potenzhiometr1.getValue() < 5)
            {
                bulb2.setState(false);
                bulb3.setState(false);
            }
            if (potenzhiometr1.getValue() > 90)
            {
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bulb4.setState(!bulb4.getState());
        }

        private void indikacia_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + indikacia.Name + "_" + indikacia.Step.ToString());
            if ((indikacia.Step == 1) || (indikacia.Step == 2) || (indikacia.Step == 4) || (indikacia.Step == 6) ||
                (indikacia.Step == 7) || (indikacia.Step == 8))
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                bulb4.setState(false);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _delay++;
            if (_delay > 100)
            {
                bulb2.setState(true);
                bulb3.setState(true);
                _delay = 0;
                timer2.Stop();
            }
        }

        private void vhodAz_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_vhodAz"))
            {
                connect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\vhodAz.txt");
                FormManager.OSC.Show();
                FormManager.OSC.Activate();
                FormManager.hlp.hlpRefresh("");
            }
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!_flag3Steps)
            {
                FormManager.OSC.refresh(@"graph\steps3.txt");
                _flag3Steps = true;
            }
            else
            {
                FormManager.OSC.refresh(@"graph\steps.txt");
                _flag3Steps = false;
            }
        }

        private void eject_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_Off");
                //voltmetr1.Left = 230;
            }
            else
            {
                panel1.Visible = true;
                FormManager.hlp.hlpRefresh(Name + "_" + eject.Name + "_On");
                //voltmetr1.Left = 230;
            }
        }

        private void kaskadSravn_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_kaskadSravn"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\kaskadSravn.txt");
                FormManager.OSC.Show();
                FormManager.OSC.Left = Left + Width;
            }
        }

        private void amp_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            //timer3.Stop();
            //disconnect(OSC);
            FormManager.OSC.gain = amp.getValue()*0.01;
            FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mY = FormManager.OSC.voltageY.Set_Value*
                                                                   FormManager.OSC.gain;
            FormManager.OSC.picture_Box_for_Oscilloscope1.Set_mY *= 0.001*
                                                                    FormManager.OSC.picture_Box_for_Oscilloscope1.
                                                                        Set_step_Y;
            FormManager.OSC.refresh();
            FormManager.hlp.hlpRefresh("bk006_panel1_amp_" + amp.getValue());
        }

        private void nachImp_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_nachImp"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\nachImp.txt");
                FormManager.OSC.Show();
            }
        }

        private void otmKvp_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_otmKvp"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\otmKvp.txt");
                FormManager.OSC.Show();
            }
        }

        private void strob1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_strob1"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\strob12.txt");
                FormManager.OSC.Show();
            }
        }

        private void strob2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_strob2"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\strob12.txt");
                FormManager.OSC.Show();
            }
        }

        private void strob3_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_strob3"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\strob34.txt");
                FormManager.OSC.Show();
            }
        }

        private void strob4_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_strob4"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\strob34.txt");
                FormManager.OSC.Show();
            }
        }

        private void sinhrOsc_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_sinhrOsc"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\sinhrOsc.txt");
                FormManager.OSC.Show();
            }
        }

        private void vhodOporn_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_vhodOporn"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\vhodOporn.txt");
                FormManager.OSC.Show();
            }
        }

        private void impulsPhantastr_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk006_impulsPhantastr"))
            {
                timer3.Stop();
                disconnect(FormManager.OSC);
                FormManager.OSC.refresh(@"graph\impulsPhantastr.txt");
                FormManager.OSC.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}