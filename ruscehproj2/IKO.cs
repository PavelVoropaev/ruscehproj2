using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class IKO : genericForm
    {
        public IKO()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            scale.isSided = true;
            //scale.State = true;
            ikO_control1.Brightness = brightness.getValue();
        }

        private void IKO_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormManager.bv012.vkl14.state)
                {
                    ikO_control1.start();
                }
                else
                {
                    ikO_control1.stop();
                }
            }
            catch
            {
                ikO_control1.stop();
            }
        }

        private void IKO_FormClosing(object sender, FormClosingEventArgs e)
        {
            ikO_control1.stop();
        }

        private void IKO_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("IKO_forced");
        }

        private void brightness_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            FormManager.hlp.hlpRefresh("IKO_brightness_" + brightness.getValue().ToString());
            ikO_control1.Brightness = brightness.getValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.Init_e("targetCtrl");
            FormManager.IKO.ikO_control1.Ctrl = true;
        }

        private void scale_Click(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh("IKO_scale_" + scale.State.ToString());
        }
    }
}