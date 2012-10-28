using System;

namespace ruscehproj2
{
    public partial class br004 : genericForm
    {
        private readonly int kitId;

        public br004(int _id)
        {
            InitializeComponent();
            mode.setPosNum(6);
            bad.setLampType("red");
            norm.setLampType("green");
            kitId = _id;
            kanal.setValue(1);
        }


        private void vkl_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + vkl.Name);
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name);
            voltmetr1.Set_Value = 0;
        }

        private void br004_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormManager.bk008.tokSHG.getValue() > 32 && FormManager.bk008.tokSHG.getValue() < 37)
                {
                    voltmetr1.Set_Value = 10;
                }
                if (FormManager.bk008.mode.Step == 2 && kitId == 1)
                {
                    bad.setState(true);
                    norm.setState(false);
                }
                else
                {
                    bad.setState(false);
                    norm.setState(false);
                }
                if (FormManager.bk008.mode.Step == 3 && kitId == 2)
                {
                    bad.setState(true);
                    norm.setState(false);
                }
            }
            catch
            {
            }
        }

        private void mode_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + mode.Name + "_" + mode.Step.ToString());
            switch (mode.Step)
            {
                case 3:
                    voltmetr1.Set_Value = 100;
                    break;
                case 2:
                    bad.setState(true); //voltmetr1.Set_Value = 100;
                    break;
                case 4:
                    voltmetr1.Set_Value = 100;
                    break;
                case 5:
                    voltmetr1.Set_Value = 27;
                    break;
                default:
                    voltmetr1.Set_Value = 0;
                    norm.setState(false);
                    bad.setState(false);
                    break;
            }
        }

        private void amp_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_" + amp.Name + "_" + amp.getValue());
            voltmetr1.Set_Value = amp.getValue() + 5;
            if (amp.getValue() < 20)
            {
                norm.setState(true);
                bad.setState(false);
            }
        }

        private void kanal_Value_Changed(object sender, CustomEventArgs e)
        {
            kanalN.Text = kanal.getValue().ToString();
        }

        private void krist1_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_krist1");
            voltmetr1.Set_Value = 15;
        }

        private void krist2_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name + "_krist2");
            voltmetr1.Set_Value = 20;
        }
    }
}