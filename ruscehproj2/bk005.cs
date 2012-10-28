using System;

namespace ruscehproj2
{
    public partial class bk005 : genericForm
    {
        private readonly priborC4353 pribor = new priborC4353();
        private string isSet = "";

        public bk005()
        {
            InitializeComponent();
            pribor.setBarStep(5);
            dalOpBad.setLampType("red");
            azNeprBad.setLampType("red");
            azOpBad.setLampType("red");
            dalOpNorm.setLampType("green");
            azNeprNorm.setLampType("green");
            azOpNorm.setLampType("green");
        }

        private void door_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk005_door"))
            {
                enter.Visible = true;
                ground.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                zeroAz.Visible = true;
                zeroDal.Visible = true;
                zeroDalSet.Visible = true;
                zeroAzSet.Visible = true;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk005_enter"))
            {
                enter.wireOn();
            }
        }

        private void ground_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bk005_ground"))
            {
                ground.wireOn();
            }
        }

        private void wire_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bk005_wire");
        }

        private void zeroAzSet_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + zeroAzSet.Name + "_" + zeroAzSet.getValue().ToString());
            if (isSet == "az") pribor.setInitialValue(zeroAzSet.getValue() - 35);
        }

        private void zeroDalSet_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + zeroDalSet.Name + "_" + zeroDalSet.getValue().ToString());
            if (isSet == "dal") pribor.setInitialValue(zeroDalSet.getValue() - 24);
        }

        private void bk005_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormManager.BT006.pwrAzNepr >= 50)
                {
                    azNeprNorm.setState(true);
                    azNeprBad.setState(false);
                }
                else
                {
                    azNeprBad.setState(true);
                    azNeprNorm.setState(false);
                }

                if (FormManager.BT006.pwrAzOp >= 20)
                {
                    azOpNorm.setState(true);
                    azOpBad.setState(false);
                }

                else
                {
                    azOpNorm.setState(false);
                    azOpBad.setState(true);
                }
                if (FormManager.BT006.pwrDalOp >= 20)
                {
                    dalOpNorm.setState(true);
                    dalOpBad.setState(false);
                }
                else
                {
                    dalOpNorm.setState(false);
                    dalOpBad.setState(true);
                }
            }
            catch
            {
                dalOpBad.setState(true);
                azOpBad.setState(true);
                azNeprBad.setState(true);
            }
        }

        private void azVoltage_Click_1(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bk005_azVoltage");
            isSet = "az";
            pribor.Hide();
            pribor.setInitialValue(15);
            pribor.Show();
            pribor.Top = Top + Height;
            Activate();
            FormManager.hlp.hlpRefresh("");
            azVoltage.wireOn();
            dalVoltage.wireOff();
        }

        private void dalVoltage_Click_1(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("bk005_dalVoltage");
            isSet = "dal";
            pribor.Hide();
            pribor.setInitialValue(10);
            pribor.Show();
            pribor.Top = Top + Height;
            Activate();
            FormManager.hlp.hlpRefresh("");
            dalVoltage.wireOn();
            azVoltage.wireOff();
        }
    }
}