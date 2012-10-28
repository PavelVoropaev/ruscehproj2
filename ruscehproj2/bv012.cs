using System;

namespace ruscehproj2
{
    public partial class bv012 : genericForm
    {
        #region Delegates

        public delegate void EventHandler(object _in, CustomEventArgs e);

        #endregion

        public bool vkl = false;

        public bv012()
        {
            InitializeComponent();
            voltageCheck.setPosNum(5);
            bulb1.setLampType("green");
        }

        public event EventHandler onSelsinCheck;

        private void vkl12_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl14.Name))
            {
            }
        }

        private void otkl_Click(object sender, EventArgs e)
        {
            vkl14.state = false;
            bulb1.setState(false);
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl.Name))
            {
            }
        }

        private void otkl14_Click(object sender, EventArgs e)
        {
            vkl14.state = false;
            if (FormManager.hlp.hlpRefresh(Name + "_" + otkl14.Name))
            {
            }
        }

        private void selsin_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("bv012_selsin"))
            {
                try
                {
                    FormManager.bk0061.Show();
                    FormManager.bk0061.Left = Left + Width;
                    FormManager.bk0061.TopMost = true;
                    FormManager.bk0061.connect(this);
                }
                catch
                {
                }
            }
        }

        private void potenzhiomert1_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            var selsinPos = new CustomEventArgs(selsinZero.getValue(), "selsin");
            if (onSelsinCheck != null) onSelsinCheck(this, selsinPos);
        }

        private void voltageCheck_Click(object sender, EventArgs e)
        {
            switch (voltageCheck.Step)
            {
                case 0:
                    voltmetr1.Set_Value = 0;
                    break;
                case 1:
                    voltmetr1.Set_Value = 70;
                    break;
                case 2:
                    voltmetr1.Set_Value = 75;
                    break;
                case 3:
                    voltmetr1.Set_Value = 85;
                    break;
                case 4:
                    voltmetr1.Set_Value = 99;
                    break;
            }

            if (FormManager.hlp.hlpRefresh(Name + "_" + voltageCheck.Name + "_" + voltageCheck.Step.ToString()))
            {
            }
        }

        private void vkl1_Click(object sender, EventArgs e)
        {
            bulb1.setState(true);
            if (FormManager.hlp.hlpRefresh(Name + "_" + vkl1.Name))
            {
            }
        }
    }
}