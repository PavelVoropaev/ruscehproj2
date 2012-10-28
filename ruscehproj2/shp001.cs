using System;

namespace ruscehproj2
{
    public partial class shp001 : genericForm
    {
        private readonly phazoukaz ph1 = new phazoukaz();
        public bool On1;
        public bool On2;
        public bool isEjected = false;
        private bool tfon1;
        private bool tfon2;

        public shp001()
        {
            InitializeComponent();

            bulb1.setLampType("yellow");
            bulb2.setLampType("green");
            bulb3.setLampType("green");
            bulb4.setLampType("green");
            bulb5.setLampType("green");
            bulb6.setLampType("green");
            bulb15.setLampType("green");

            bulb16.setLampType("green");
            bulb19.setLampType("green");

            bulb15.setState(true);
            charge.Step = 1;
            mode.setPosNum(3);
            A1.Setskin(3);
            pwr400.Setskin(2);
            pwr50.Setskin(3);
            A2.Setskin(3);
            D1.Setskin(3);
            D2.Setskin(3);
            reg1.Enabled = false;
            reg2.Enabled = false;
            charge.skin = 2;
            nPosSwitch1.skin = 2;
            nPosSwitch2.skin = 2;
            nPosSwitch3.skin = 2;
            nPosSwitch4.skin = 2;
            charge.setPosNum(2);
            nPosSwitch1.setPosNum(2);
            nPosSwitch2.setPosNum(2);
            nPosSwitch3.setPosNum(2);
            nPosSwitch4.setPosNum(2);
            nPosSwitch2.Step = (1);
            nPosSwitch1.Step = (0);
            nPosSwitch3.Step = (1);
            nPosSwitch4.Step = (1);
            tumbler1.State = true;
            mode.Step = 0;
            if (FormManager.hlp.scenarioId == 2)
            {
                mode.Step = 2;
                bulb15.setState(false);
                bulb16.setState(false);
                bulb19.setState(true);
            }
        }

        private void tfOn1_Click_1(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + PrOn1.Name))
            {
                tfon2 = false;
                tfon1 = true;
                bulb2.setState(tfon2);
                bulb6.setState(tfon1);
                bulb1.setState(true);
                reg1.Enabled = tfon1;
                reg2.Enabled = tfon2;
            }
        }

        private void tfOn2_Click_1(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + PrOn2.Name))
            {
                tfon1 = false;
                tfon2 = true;
                bulb2.setState(tfon2);
                bulb6.setState(tfon1);
                bulb1.setState(true);
                reg1.Enabled = tfon1;
                reg2.Enabled = tfon2;
                voltmetr_zar.Set_Value = 60;
            }
        }

        private void potenzhiomert1_Click(object sender, EventArgs e)
        {
        }

        private void potenzhiomert2_Click(object sender, EventArgs e)
        {
        }

        private void potenzhiomert2_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            voltmetr400.Set_Value = reg2.getValue();
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            voltmetr400.Set_Value = reg1.getValue();
            FormManager.hlp.hlpRefresh(Name + "_" + reg2.Name + "_" + voltmetr400.current_Value.ToString());
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + D1.Name + "_" + A1.State.ToString() + A2.State.ToString() +
                                           D1.State.ToString() + D2.State.ToString()))
            {
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + D1.Name + "_" + A1.State.ToString() + A2.State.ToString() +
                                           D1.State.ToString() + D2.State.ToString()))
            {
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + D1.Name + "_" + A1.State.ToString() + A2.State.ToString() +
                                           D1.State.ToString() + D2.State.ToString()))
            {
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + D1.Name + "_" + A1.State.ToString() + A2.State.ToString() +
                                           D1.State.ToString() + D2.State.ToString()))
            {
            }
        }

        private void pwr400_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + pwr400.Name + "_" + pwr400.State.ToString()))
            {
                voltmetr400.Set_Value = 75;
            }
        }

        private void voltage_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            voltmetr_zar.Set_Value = voltage.getValue();
            FormManager.hlp.hlpRefresh(Name + "_" + voltage.Name + "_" + voltmetr_zar.current_Value.ToString());
            //    voltage.Enabled = false;
        }

        private void nPosSwitch2_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + nPosSwitch3.Name + "_" + nPosSwitch1.Step.ToString() +
                                           nPosSwitch2.Step.ToString() + nPosSwitch3.Step.ToString() +
                                           nPosSwitch4.Step.ToString() + tumbler1.State.ToString()))
            {
                nPosSwitch2.Enabled = false;
                nPosSwitch3.Enabled = false;
                nPosSwitch4.Enabled = false;
            }
        }

        private void tumbler1_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + nPosSwitch3.Name + "_" + nPosSwitch1.Step.ToString() +
                                           nPosSwitch2.Step.ToString() + nPosSwitch3.Step.ToString() +
                                           nPosSwitch4.Step.ToString() + tumbler1.State.ToString()))
            {
                nPosSwitch2.Enabled = false;
                nPosSwitch3.Enabled = false;
                nPosSwitch4.Enabled = false;
            }
        }

        private void nPosSwitch3_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + nPosSwitch3.Name + "_" + nPosSwitch1.Step.ToString() +
                                           nPosSwitch2.Step.ToString() + nPosSwitch3.Step.ToString() +
                                           nPosSwitch4.Step.ToString() + tumbler1.State.ToString()))
            {
                nPosSwitch2.Enabled = false;
                nPosSwitch3.Enabled = false;
                nPosSwitch4.Enabled = false;
            }
        }

        private void nPosSwitch4_Click(object sender, EventArgs e)
        {
            if (
                FormManager.hlp.hlpRefresh(Name + "_" + nPosSwitch3.Name + "_" + nPosSwitch1.Step.ToString() +
                                           nPosSwitch2.Step.ToString() + nPosSwitch3.Step.ToString() +
                                           nPosSwitch4.Step.ToString() + tumbler1.State.ToString()))
            {
                nPosSwitch2.Enabled = false;
                nPosSwitch3.Enabled = false;
                nPosSwitch4.Enabled = false;
            }
        }

        private void nPosSwitch1_Click(object sender, EventArgs e)
        {
            if (!FormManager.hlp.hlpRefresh("shp001_nPosSwitch1_" + nPosSwitch1.Step.ToString()))
                if (
                    FormManager.hlp.hlpRefresh(Name + "_" + nPosSwitch3.Name + "_111" + nPosSwitch1.Step.ToString() +
                                               tumbler1.State.ToString()))
                {
                    nPosSwitch2.Enabled = false;
                    nPosSwitch3.Enabled = false;
                    nPosSwitch4.Enabled = false;
                }
        }

        private void mode_Click(object sender, EventArgs e)
        {
            if (mode.Step == 0)
            {
                bulb15.setState(true);
                bulb16.setState(false);
                bulb19.setState(false);
            }
            if (mode.Step == 1)
            {
                bulb15.setState(false);
                bulb16.setState(true);
                bulb19.setState(false);
            }
            if (mode.Step == 2)
            {
                bulb15.setState(false);
                bulb16.setState(false);
                bulb19.setState(true);
            }
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
        }

        private void charge_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + charge.Name + "_" + charge.Step.ToString());
        }

        private void PrOff_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + PrOff.Name))
            {
                bulb15.setState(false);
                bulb16.setState(false);
                bulb19.setState(false);
                bulb1.setState(false);
                bulb2.setState(false);
                bulb6.setState(false);
                bulb5.setState(false);
                bulb3.setState(false);
                bulb4.setState(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("shp001_eject"))
            {
                if (!isEjected)
                {
                    wires.BringToFront();
                    wires.Visible = true;

                    isEjected = true;
                }
                else
                {
                    ph1.Hide();
                    wires.Visible = false;
                    wires.SendToBack();
                    isEjected = false;
                }
            }
        }

        private void wires_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("shp001_wires"))
            {
            }
            ph1.TopMost = true;
            ph1.Show();
        }

        private void camin_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("shp001_camin"))
            {
                ph1.TopMost = true;
                ph1.Show();
            }
        }

        private void pwr50_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + pwr50.Name + "_" + pwr50.State.ToString()))
            {
                voltmetr50.Set_Value = 75;
            }
        }

        private void fence_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + fence.Name + "_" + fence.State.ToString());
        }
    }
}