using System;
using System.Drawing;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class splashScreen : Form
    {
        private bool FirstOpen = true;
        public bool[] mass = new bool[32];

        public splashScreen()
        {
            InitializeComponent();
            radioButton1.Left = SystemInformation.PrimaryMonitorSize.Width/2 - radioButton1.Width;
            radioButton2.Left = SystemInformation.PrimaryMonitorSize.Width/2 + 10;
            listBox1.Left = SystemInformation.PrimaryMonitorSize.Width/2 - listBox1.Width/2;
            label1.Left = SystemInformation.PrimaryMonitorSize.Width/2 - label1.Width/2;
            start.Left = SystemInformation.PrimaryMonitorSize.Width/2 - start.Width/2;
            hlp_on.Left = SystemInformation.PrimaryMonitorSize.Width/2 - hlp_on.Width/2;
            close.Left = SystemInformation.PrimaryMonitorSize.Width - 32;
            about.Left = SystemInformation.PrimaryMonitorSize.Width - 64;
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            label2.Top = SystemInformation.PrimaryMonitorSize.Height - label2.Height;
            label2.Left = SystemInformation.PrimaryMonitorSize.Width - label2.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormManager.hlp.helpEnabled(hlp_on.Checked);
            }
            catch
            {
            }
            if (listBox1.SelectedIndex != 0 && listBox1.SelectedIndex != 21 && listBox1.SelectedIndex != 24 &&
                listBox1.SelectedIndex != 27 && listBox1.SelectedIndex != 31)
            {
                BackgroundImage = null;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                FirstOpen = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                listBox1.Visible = false;
                hlp_on.Visible = false;
                start.Visible = false;
            }
            if (listBox1.SelectedIndex == 2
                || listBox1.SelectedIndex == 5
                || listBox1.SelectedIndex == 6
                || listBox1.SelectedIndex == 7
                || listBox1.SelectedIndex == 9
                || listBox1.SelectedIndex == 10
                || listBox1.SelectedIndex == 23
                || listBox1.SelectedIndex == 26
                || listBox1.SelectedIndex == 4
                || listBox1.SelectedIndex == 17
                || listBox1.SelectedIndex == 8
                || listBox1.SelectedIndex == 10
                || listBox1.SelectedIndex == 18
                || listBox1.SelectedIndex == 16
                || listBox1.SelectedIndex == 15
                || listBox1.SelectedIndex == 11
                || listBox1.SelectedIndex == 13)
            {
                FormManager.Init_e("hlp");
                FormManager.hlp.helpEnabled(hlp_on.Checked);
                FormManager.hlp.scenarioId = listBox1.SelectedIndex;
                FormManager.hlp.scenarioControl = radioButton2.Checked;
                FormManager.Init_e("MAIN1");
            }

            if (listBox1.SelectedIndex == 20)
            {
                FormManager.Init_e("hlp");
                FormManager.hlp.helpEnabled(hlp_on.Checked);
                FormManager.hlp.scenarioId = listBox1.SelectedIndex;
                FormManager.hlp.scenarioControl = radioButton2.Checked;
                FormManager.Init_e("tuts2");
                FormManager.bya1.Top = 0;
                FormManager.bya1.Left = 0;
                FormManager.tuts1.Top = 0;
                FormManager.tuts1.Left = FormManager.bya1.Width;
            }
            if (listBox1.SelectedIndex == 30)
            {
                FormManager.Init_e("hlp");
                FormManager.hlp.helpEnabled(hlp_on.Checked);
                FormManager.hlp.scenarioId = listBox1.SelectedIndex;
                FormManager.hlp.scenarioControl = radioButton2.Checked;
                FormManager.Init_e("tuts");
            }

            if (listBox1.SelectedIndex == 1)
            {
                var viewer = new docsViewer(@"\res\initialPwrOnPrep.html");
                viewer.ShowDialog();
            }

            if (listBox1.SelectedIndex == 12)
            {
                var viewer = new docsViewer(@"\res\senseCheck.htm");
                viewer.ShowDialog();
            }

            if (listBox1.SelectedIndex == 14)
            {
                var viewer = new docsViewer(@"\res\geterodin.htm");
                viewer.ShowDialog();
            }

            if (listBox1.SelectedIndex == 22)
            {
                var viewer = new docsViewer(@"\res\localRepairUsage.htm");
                viewer.ShowDialog();
            }


            if (listBox1.SelectedIndex == 25)
            {
                var viewer = new docsViewer(@"\res\localWorkUsage.htm");
                viewer.ShowDialog();
            }

            if (listBox1.SelectedIndex == 28)
            {
                var viewer = new docsViewer(@"\res\remoteWorkUsage.htm");
                viewer.ShowDialog();
            }

            if (listBox1.SelectedIndex == 29)
            {
                var viewer = new docsViewer(@"\res\tutsSignals.htm");
                viewer.ShowDialog();
            }
            if (listBox1.SelectedIndex == 19)
            {
                var viewer = new docsViewer(@"\res\aftCheck.htm");
                viewer.ShowDialog();
            }
            if (listBox1.SelectedIndex == 3)
            {
                var viewer = new docsViewer(@"\res\sarTeor.htm");
                viewer.ShowDialog();
            }
            if (listBox1.SelectedIndex == 32)
            {
                var viewer = new docsViewer(@"\res\error.htm");
                viewer.ShowDialog();
            }
            if (listBox1.SelectedIndex == 33)
            {
                var viewer = new docsViewer(@"\res\errorTabl.htm");
                viewer.ShowDialog();
            }
        }

        private void next()
        {
            {
                BackgroundImage = null;
                label1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                //       tmp = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                listBox1.Visible = true;
                hlp_on.Visible = true;
                start.Visible = true;
                label2.Visible = false;
            }
        }

        private void splashScreen_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            int index = 0;

            foreach (bool X in mass)
            {
                if (X && index == e.Index)
                {
                    e.Graphics.FillRectangle(Brushes.Green, e.Bounds);
                    myBrush = Brushes.Yellow;
                }
                index++;
            }
            e.Graphics.DrawString(
                ((ListBox) sender).Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds,
                StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void splashScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            next();
        }

        private void splashScreen_Activated(object sender, EventArgs e)
        {
            if (!FirstOpen)
                next();
        }

        private void about_Click(object sender, EventArgs e)
        {
            var viewer = new docsViewer(@"\res\about.html");
            viewer.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) hlp_on.Checked = false;
            hlp_on.Enabled = !radioButton2.Checked;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}