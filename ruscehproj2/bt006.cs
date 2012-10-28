using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class bt006 : genericForm
    {
        private readonly Oscilloscope OC = new Oscilloscope(@"graph\step.txt");
        private readonly Timer Time = new Timer();
        public int pwrAzNepr;

        public int pwrAzOp;
        public int pwrDalOp;

        public bt006()
        {
            InitializeComponent();
            tmb.isSided = true;
            //tmb.State = true;
            bulb1.setLampType("green");
            bulb1.setState(true);
            mode1.Step = 0;
            mode2.Step = 0;
        }


        private void mode2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bt006_mode2_" + mode2.Step.ToString()))
            {
                if (FormManager.hlp.scenarioId == 8) setNull2.Set_Value = 90;
            }
            if (mode1.Step == 0)
            {
                voltmetr2.Set_Bar_step = 0.2;
                voltmetr2.Set_Center_str = "КБВн";
            }
            if (mode1.Step == 1)
            {
                voltmetr2.Set_Value = 30;
                voltmetr2.Set_Bar_step = 20;
                voltmetr2.Set_Center_str = "KW";
            }
            if (mode1.Step == 2)
            {
                voltmetr2.Set_Value = 60;
            }

            //voltmetr1.Set_Value = 30;

            FormManager.hlp.hlpRefresh("bt006_mode2_" + mode2.Step.ToString());
        }

        private void setNull_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (!OC.isOpened)
            {
                OC.Show();
                OC.TopMost = true;
            }
            Activate();
            FormManager.hlp.hlpRefresh("");
            if (setNull2.getValue() > 0)
            {
                if (FormManager.hlp.hlpRefresh("bt006_setNull2_" + setNull2.getValue().ToString()))
                    OC.Dispose();
                if (setNull2.getValue() != 0)
                {
                    OC.gain = setNull2.getValue()*0.01;
                    OC.picture_Box_for_Oscilloscope1.Set_mY = OC.voltageY.Set_Value*OC.gain;
                    OC.picture_Box_for_Oscilloscope1.Set_mY *= 0.001*OC.picture_Box_for_Oscilloscope1.Set_step_Y;
                    OC.picture_Box_for_Oscilloscope1.pictureBox1.Invalidate();
                }
                OC.resY = OC.voltageY.getValue();
            }
        }

        private void setNull1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            Time.Start();
            voltmetr1.Set_Value = setNull1.getValue()/2;
            FormManager.hlp.hlpRefresh("bt006_setNull1_" + voltmetr1.current_Value.ToString());
        }


        private void mode1_Click(object sender, EventArgs e)
        {
            if (mode1.Step == 0)
            {
                voltmetr1.Set_Value = 30;
                KBVn1.Set_Value = 30;
                voltmetr1.Validate();
                voltmetr1.Set_Bar_step = 0.2;
                voltmetr1.Set_Center_str = "КБВн";
                Time.Stop();
            }
            if (mode1.Step == 1)
            {
                voltmetr1.Set_Value = 30;
                setNull1.Set_Value = 30;
                voltmetr1.Validate();
                voltmetr1.Set_Bar_step = 20;
                voltmetr1.Set_Center_str = "KW";
                Time.Tick += Time_Tick;
                Time.Interval = 100;
                Time.Start();
            }
            if (mode1.Step == 2)
            {
                voltmetr1.Set_Value = 35;
            }
            voltmetr1.Set_Value = 30;

            FormManager.hlp.hlpRefresh("bt006_mode1_" + mode1.Step.ToString());
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            voltmetr1.Set_Value = setNull1.getValue()/2 + r.Next(15) - 10;
            voltmetr1.Validate();
        }

        private void tumbler1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bt006_tmb_" + tmb.State.ToString());
        }

        private void voltmetr1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bt006_voltmetr1");
        }

        private void KBVn1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (mode1.Step == 1 && tmb.State)
            {
                pwrAzOp = KBVn1.getValue()/2;
            }
            if (mode1.Step == 1 && tmb.State == false)
            {
                pwrDalOp = KBVn1.getValue()/2;
            }
            Time.Stop(); //можно?
            voltmetr1.Set_Value = KBVn1.getValue()/2;
            FormManager.hlp.hlpRefresh("bt006_KBVn1_" + KBVn1.getValue().ToString());
        }

        private void setNull1_MouseLeave(object sender, EventArgs e)
        {
            Time.Stop();
        }

        private void KBVn2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            voltmetr2.Set_Value = KBVn2.getValue();
            if (mode2.Step == 1)
            {
                pwrAzNepr = KBVn2.getValue();
            }
            FormManager.hlp.hlpRefresh("bt006_KBVn2_" + KBVn2.getValue().ToString());
        }

        private void bt006_FormClosing(object sender, FormClosingEventArgs e)
        {
            OC.Hide();
        }
    }
}