using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace ruscehproj2
{
    public partial class helper : Form
    {
        private readonly XmlDocument helpdb = new XmlDocument();
        private readonly Control str = new PictureBox();
        private readonly Timer time_machine = new Timer();
        private string Contrl = "";

        private int errorCount;
        public bool helpActive = false;
        private int maxStep = 1;
        public string nextBlock = "";
        private string nextContrl = "";
        public XmlNodeList nodes;
        public bool scenarioControl = false;
        public int scenarioId;
        public int step = 1;

        private int str_x;
        private int str_y;

        public helper()
        {
            InitializeComponent();
            time_machine.Interval = 1000;
        }

        private void Load_xml()
        {
            if (scenarioId == 2)
            {
                helpdb.Load(@"res\initPwrOn.xml");
            }
            if (scenarioId == 4)
            {
                helpdb.Load(@"res\sarCheck.xml");
            }
            if (scenarioId == 5)
            {
                helpdb.Load(@"res\bkCheck.xml");
            }
            if (scenarioId == 6)
            {
                helpdb.Load(@"res\emSensor.xml");
            }
            if (scenarioId == 8)
            {
                helpdb.Load(@"res\IPIM.xml");
            }
            if (scenarioId == 9)
            {
                helpdb.Load(@"res\IPNM.xml");
            }
            if (scenarioId == 10)
            {
                helpdb.Load(@"res\bkMethod.xml");
            }

            if (scenarioId == 11)
            {
                helpdb.Load(@"res\PRM.xml");
            }

            if (scenarioId == 13)
            {
                helpdb.Load(@"res\senseCheckDC.xml");
            }

            if (scenarioId == 15)
            {
                helpdb.Load(@"res\bk008.xml");
            }

            if (scenarioId == 16)
            {
                helpdb.Load(@"res\br003.xml");
            }

            if (scenarioId == 17)
            {
                helpdb.Load(@"res\bshCheck.xml");
            }

            if (scenarioId == 18)
            {
                helpdb.Load(@"res\IKO.xml");
            }

            if (scenarioId == 23)
            {
                helpdb.Load(@"res\localRepOn.xml");
            }
            if (scenarioId == 30)
            {
                helpdb.Load(@"res\remotePwrOn.xml");
            }
            if (scenarioId == 26)
            {
                helpdb.Load(@"res\localWrkOn.xml");
            }
            if (scenarioId == 17)
            {
                helpdb.Load(@"res\bshCheck.xml");
            }
            if (scenarioId == 7)
            {
                helpdb.Load(@"res\PRD.xml");
            }
            if (scenarioId == 20)
            {
                helpdb.Load(@"res\tuts.xml");
            }
            FormManager.hlp.nodes = helpdb.GetElementsByTagName("hlpEntry");
            hlpRefresh("MAIN_On");
        }

        public bool hlpRefresh(string _input) // местный ремонт
        {
            nextBlock = "";
            signal.Text = _input;
            auxInfo.Text = (step - 1).ToString() + " шаг из " + (maxStep - 1).ToString();
            bool result = false;
            string scenarioName = "";
            nextContrl = "";
            if (scenarioId == 13 || scenarioId == 11 || scenarioId == 15 || scenarioId == 16 || scenarioId == 23 ||
                scenarioId == 30 || scenarioId == 26 || scenarioId == 2 || scenarioId == 4 || scenarioId == 5 ||
                scenarioId == 6 || scenarioId == 8 || scenarioId == 9 || scenarioId == 10 || scenarioId == 17 ||
                scenarioId == 18 || scenarioId == 7 || scenarioId == 20)
            {
                try
                {
                    foreach (XmlNode node in nodes)
                    {
                        if (node.FirstChild.InnerText == "1") scenarioName = node.FirstChild.NextSibling.InnerText;
                        if (_input == "End")
                        {
                            TopMost = true;

                            MessageBox.Show("Вы не закончили " + scenarioName + " .Вами было совершено " +
                                            errorCount.ToString() + " ошибок...");
                            errorCount = 0;
                            FormManager.disp();
                            Dispose();
                            break;
                        }
                        if (node.FirstChild.NextSibling.NextSibling.InnerText == "disp")
                        {
                            maxStep = Convert.ToInt32(node.FirstChild.InnerText);
                        }
                        if (node.FirstChild.NextSibling.NextSibling.InnerText == "disp" &&
                            node.FirstChild.InnerText == step.ToString())
                        {
                            step = 1;
                            Hide();
                            TopMost = true;
                            if (!helpActive)
                            {
                                var EndScen =
                                    new End("Вы закончили " + scenarioName + ". Из " + maxStep +
                                            " пунктов. Вами было совершено " + errorCount.ToString() + " ошибок...");
                                EndScen.ShowDialog();
                            }
                            else MessageBox.Show("Вы закончили " + scenarioName);
                            errorCount = 0;
                            FormManager.disp();
                        }
                        if ((node.FirstChild.NextSibling.NextSibling.InnerText == _input || _input == "cheat") &&
                            node.FirstChild.InnerText == step.ToString())
                        {
                            hlpText.Text = node.NextSibling.FirstChild.NextSibling.InnerText;
                            auxInfo.Text = step.ToString();
                            step++;
                            result = true;
                            if (_input == "cheat") break;
                        }

                        string[] Signal = _input.Split('_');
                        if (node.FirstChild.InnerText == step.ToString())
                        {
                            string inp = node.FirstChild.NextSibling.NextSibling.InnerText;
                            label1.Text = inp;
                            string[] nextSignal = inp.Split('_');
                            nextBlock = nextSignal[0];
                            nextContrl = nextSignal[1];
                            Contrl = Signal[1];
                            if (helpActive)
                            {
                                try
                                {
                                    bool findSuccess = false;
                                    foreach (Control X in ActiveForm.Controls)
                                    {
                                        if (X.Name == nextContrl && ActiveForm.Name == nextBlock)
                                        {
                                            draw_str(X);
                                            findSuccess = true;
                                        }
                                    }
                                    if (!findSuccess && ActiveForm.Name != "helper" && ActiveForm.Name != "MAIN" &&
                                        ActiveForm.Name != "splashScreen") draw_str();
                                }
                                catch
                                {
                                    label1.Text = "Error";
                                }
                            }
                        }
                    }
                    if (!result && Contrl != "mechZero" && Contrl != "On" &&
                        Contrl != "potenzhiometr1" && Contrl != "Off" && nextContrl != Contrl && Contrl != "reg2" &&
                        Contrl != "reg1" && Contrl != "voltage" && Contrl != "volt" && Contrl != "potenzhiomert1" &&
                        Contrl != "" && Contrl != "potenzhiomert2" && Contrl != "potenzhiomert3" &&
                        Contrl != "potenzhiomert4" && Contrl != "potenzhiomert5" && Contrl != "zeroAzSet" &&
                        Contrl != "zeroDalSet" && Contrl != "amp" && Contrl != "feedb" && Contrl != "phase" &&
                        Contrl != "zeroPd" && Contrl != "tokSHG" && Contrl != "preVyh" && Contrl != "vyhod" &&
                        Contrl != "getPwr" && Contrl != "tokSmes" && Contrl != "getNastr" && Contrl != "tokSmes" &&
                        Contrl != "getNastr" && Contrl != "voltage" && Contrl != "kalibr" && Contrl != "regNach" &&
                        Contrl != "setNull1" && Contrl != "setNull2" && Contrl != "KBVn1" && Contrl != "KBVn2" &&
                        Contrl != "feedb" && Contrl != "phase" && Contrl != "zeroPd" && Contrl != "selsinZero" &&
                        Contrl != "atten" && Contrl != "freq" && Contrl != "output" && Contrl != "brightness" &&
                        Contrl != "voltageX" && Contrl != "voltageY" && Contrl != "chuv") // Счётчик ОШИБОК
                    {
                        errorCount++;
                        error_count.Text = "Ошибки: " + errorCount.ToString();
                        if (errorCount > 7 && !helpActive)
                        {
                            try
                            {
                                FormManager.MAIN1.END.Visible = true;
                            }
                            catch
                            {
                            }
                            try
                            {
                                FormManager.tuts1.End.Visible = true;
                            }
                            catch
                            {
                            }
                        }
                    }
                }

                catch
                {
                    Load_xml();
                }
            }
            if (checkBox1.Checked) result = true;
            return result;
        }

        private void draw_str()
        {
            str_x = ActiveForm.Width - 36;
            str_y = 0;
            str.BackColor = Color.Transparent;
            str.BackgroundImage = Resources.arrow;
            str.BackgroundImageLayout = ImageLayout.Stretch;
            str.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            str.Location = new Point(str_x, str_y);
            str.Name = "str";
            str.Size = new Size(32, 32);
            ActiveForm.Controls.Add(str);
            str.BringToFront();
        }

        private void draw_str(Control contr)
        {
            str_x = contr.Location.X + contr.Size.Width - 10;
            str_y = contr.Location.Y + contr.Size.Height;
            str.BackColor = Color.Transparent;
            str.BackgroundImage = Resources.arrow;
            str.BackgroundImageLayout = ImageLayout.Stretch;
            if (contr.Location.X + contr.Size.Width + 10 > contr.Parent.Size.Width)
                str_x = contr.Parent.Size.Width - 50;
            if (contr.Top + contr.Size.Height + 40 > contr.Parent.Size.Height)
                str_y = contr.Parent.Size.Height - 60;
            str.Location = new Point(str_x, str_y);
            str.Name = "str";
            str.Size = new Size(32, 32);
            ActiveForm.Controls.Add(str);
            str.BringToFront();
        }

        private void helper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.F1)
            {
                Hide();
            }
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.F2)
            {
                signal.Visible = !signal.Visible;
                label1.Visible = !label1.Visible;
            }
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            hlpRefresh("cheat");
        }

        public void hlp_show(Form this_form)
        {
            if (helpEnabled())
                FormManager.Init_e("hlp");
        }

        public void helpEnabled(bool input)
        {
            helpActive = input;
        }

        public bool helpEnabled()
        {
            return helpActive;
        }

        //публичный метод уменьшает кол-во ошибок на один либо на число

        public void decrErrorCount()
        {
            errorCount--;
            error_count.Text = "Ошибки: " + errorCount.ToString();
        }

        public void decrErrorCount(int val)
        {
            errorCount = errorCount - val;
            error_count.Text = "Ошибки: " + errorCount.ToString();
        }

        private void helper_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorCount = 0;
        }
    }
}