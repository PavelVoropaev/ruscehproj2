using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class button : UserControl
    {
        public bool state = false;

        public button()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            state = !state;
        }
    }
}