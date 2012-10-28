using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class genericForm : Form
    {
        public bool MegaMain = false;
        public bool isOpened = false;
        private bool on = true;
        public byte onStep = 0;

        public genericForm()
        {
            InitializeComponent();
        }

        private void genericForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MegaMain)
            {
                isOpened = false;
                e.Cancel = true;
                Hide();
            }
            FormManager.hlp.hlpRefresh(Name + "_Off");
        }

        private void genericForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                isOpened = false;
                Close();
            }
        }

        private void genericForm_Load(object sender, EventArgs e)
        {
            on = true;
            isOpened = true;
        }

        public void draw_str(Control contr)
        {
            if (FormManager.hlp.helpActive)
            {
                str.Location = new Point(contr.Location.X + contr.Size.Width - 8,
                                         contr.Location.Y + contr.Size.Height - 8);
            }
        }

        private void genericForm_Activated(object sender, EventArgs e)
        {
            if (on)
            {
                on = false;
                FormManager.hlp.hlpRefresh(Name + "_On");
                if (FormManager.hlp.helpEnabled())
                    FormManager.hlp.hlp_show(this);
            }
        }
    }
}