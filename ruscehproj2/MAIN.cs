using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class MAIN : genericForm
    {
        public bool EndBut = false;

        public MAIN()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(bg0011, "БГ-001");
            tt.SetToolTip(bg0012, "БГ-001");
            tt.SetToolTip(bg0021, "БГ-002");
            tt.SetToolTip(bg0022, "БГ-002");
            tt.SetToolTip(bg0031, "БГ-003");
            tt.SetToolTip(bg0032, "БГ-003");
            tt.SetToolTip(bg0041, "БГ-004");
            tt.SetToolTip(bg0042, "БГ-004");
            tt.SetToolTip(bg0051, "БГ-005");
            tt.SetToolTip(bg0052, "БГ-005");
            tt.SetToolTip(bk005, "БК-005");
            tt.SetToolTip(bk0061, "БК-006");
            tt.SetToolTip(bk0062, "БК-006");
            tt.SetToolTip(bk0071, "БК-007");
            tt.SetToolTip(bk0072, "БК-007");
            tt.SetToolTip(bk008, "БК-008");
            tt.SetToolTip(bm0051, "БM-005");
            tt.SetToolTip(bm0052, "БM-005");
            tt.SetToolTip(bm0061, "БM-006");
            tt.SetToolTip(bm0062, "БM-006");
            tt.SetToolTip(bp103, "БП-103");
            tt.SetToolTip(bp1161, "БП-116 БП-117");
            tt.SetToolTip(bp1162, "БП-116 БП-117");
            tt.SetToolTip(bp119, "БП-119");
            tt.SetToolTip(br0031, "БP-003");
            tt.SetToolTip(br0032, "БP-003");
            tt.SetToolTip(br0041, "БP-004");
            tt.SetToolTip(br0042, "БP-004");
            tt.SetToolTip(br0071, "БP-007");
            tt.SetToolTip(br0072, "БP-007");
            tt.SetToolTip(bsh0011, "БШ-001");
            tt.SetToolTip(bsh0012, "БШ-001");
            tt.SetToolTip(bsh0021, "БШ-002");
            tt.SetToolTip(bsh0022, "БШ-002");
            tt.SetToolTip(bsh0031, "БШ-003");
            tt.SetToolTip(bsh0032, "БШ-003");
            tt.SetToolTip(bsh0032, "БШ-003");
            tt.SetToolTip(bt006, "БТ-005 и БТ-006");
            tt.SetToolTip(bv001, "БВ-001");
            tt.SetToolTip(bv002, "БВ-002");
            tt.SetToolTip(bv0041, "БВ-004");
            tt.SetToolTip(bv0042, "БВ-004");
            tt.SetToolTip(bv0091, "БВ-009");
            tt.SetToolTip(bv0092, "БВ-009");
            tt.SetToolTip(bv010, "БВ-010");
            tt.SetToolTip(bv012, "БВ-012");
            tt.SetToolTip(bya001, "БЯ-001");
            tt.SetToolTip(shp001, "ЩП-001");
            tt.SetToolTip(shp002, "ЩП-002");
            tt.SetToolTip(vi001, "ВИ-001");
            tt.SetToolTip(vi002, "ВИ-002");
            tt.SetToolTip(IKO, "ИКО");
            MegaMain = true;
        }

        private void bsh0011_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0011.Name) || "bsh001" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0011.Name);
            }
        }

        private void bsh0012_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0012.Name) || "bsh001" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0012.Name);
            }
        }

        private void bk0062_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk0062.Name) || "bk006" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bk0062.Name);
            }
        }

        private void bk0061_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk0061.Name) || "bk006" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bk0061.Name);
            }
        }

        private void bsh0021_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0021.Name) || "bsh002" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0021.Name);
            }
        }

        private void bsh0022_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0022.Name) || "bsh002" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0022.Name);
            }
        }

        private void bk0071_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk0071.Name) || "bk007" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bk0071.Name);
            }
        }

        private void bk0072_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk0072.Name) || "bk007" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bk0072.Name);
            }
        }

        private void bt006_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bt006.Name) || bt006.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bt006.Name);
            }
        }

        private void bk005_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk005.Name) || bk005.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bk005.Name);
            }
        }

        private void shp001_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + shp001.Name) || shp001.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(shp001.Name);
            }
        }

        private void bp119_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bp119.Name) || bp119.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bp119.Name);
            }
        }

        private void br0032_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0032.Name) || "br31" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0032.Name);
            }
        }

        private void br0031_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0031.Name) || "br32" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0031.Name);
            }
        }

        private void br0041_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0041.Name) || "br004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0041.Name);
            }
        }

        private void br0042_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0042.Name) || "br004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0042.Name);
            }
        }

        private void bya001_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bya001.Name) || bya001.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bya001.Name);
            }
        }

        private void bv001dal_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv002.Name) || "bv002" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv002.Name);
                //здесь должен быть блок дальности (картинка другая)
            }
        }

        private void bv001az_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv001.Name) || "bv001" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv001.Name);
            }
        }

        private void bk008_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bk008.Name) || bk008.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("bk008");
            }
        }

        private void bv010_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv010.Name) || bv010.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv010.Name);
            }
        }

        private void bv0041_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv0041.Name) || "bv004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("bv0041");
            }
        }

        private void bv0042_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv0042.Name) || "bv004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("bv0042");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh("MAIN_IKO") || IKO.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(IKO.Name);
            }
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (!FormManager.hlp.helpEnabled())
            {
                MessageBox.Show("Помощь выключена!");
            }
        }

        private void bv009kit1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv0091.Name) || "bv009" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv0091.Name);
            }
        }

        private void bv009kit2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv0092.Name) || "bv009" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv0092.Name);
            }
        }

        private void br0071_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0071.Name) || "br007" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0071.Name);
            }
        }

        private void br0072_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + br0072.Name) || "br007" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(br0072.Name);
            }
        }

        private void bg0041_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0041.Name) || "bg004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0041.Name);
            }
        }

        private void bg0011_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0011.Name) || "bg001" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0011.Name);
            }
        }

        private void bg0042_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0042.Name) || "bg004" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0042.Name);
            }
        }

        private void bg0012_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0012.Name) || "bg001" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0012.Name);
            }
        }

        private void bm0051_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bm0051.Name) || "bm005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bm0051.Name);
            }
        }

        private void bm0052_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bm0052.Name) || "bm005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bm0052.Name);
            }
        }

        private void bm0053_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bm0061.Name) || "bm005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("bm0061");
            }
        }

        private void bm0054_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bm0062.Name) || "bm005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bm0061.Name);
            }
        }

        private void bg0051_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0051.Name) || "bg005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0051.Name);
            }
        }

        private void bg0052_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0052.Name) || "bg005" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0052.Name);
            }
        }

        private void bg0031_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0031.Name) || "bg003" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("bg0031");
            }
        }

        private void bg0032_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0032.Name) || "bg003" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0032.Name);
            }
        }

        private void bg0021_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0021.Name) || "bg002" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0021.Name);
            }
        }

        private void bg0022_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bg0022.Name) || "bg002" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bg0022.Name);
            }
        }

        private void bp1161_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bp1161.Name) || "bp116" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bp1161.Name);
            }
        }

        private void bp1162_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bp1162.Name) || "bp116" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bp1162.Name);
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bv012.Name) || bv012.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bv012.Name);
            }
        }

        private void bp103_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bp103.Name) || bp103.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bp103.Name);
            }
        }

        private void bsh003_1_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0031.Name) || "bsh003" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0031.Name);
            }
        }

        private void bsh003_2_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + bsh0032.Name) || "bsh003" == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(bsh0032.Name);
            }
        }

        private void BSH002(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + shp002.Name) || shp002.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e(shp002.Name);
            }
        }

        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(!EndBut)  FormManager.hlp.hlpRefresh("End");
            FormManager.hlp.Hide();
            FormManager.disp();
        }

        private void vi001_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vi001.Name) || vi001.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("vi001");
            }
        }

        private void vi002_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + vi002.Name) || vi002.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("vi002");
            }
        }

        private void uvch_Click(object sender, EventArgs e)
        {
            if (FormManager.hlp.hlpRefresh(Name + "_" + uvch.Name) || uvch.Name == FormManager.hlp.nextBlock)
            {
                FormManager.hlp.Hide();
                FormManager.Init_e("uvch");
            }
        }

        private void END_Click(object sender, EventArgs e)
        {
            EndBut = true;
            FormManager.hlp.hlpRefresh("End");
        }

        private void MAIN_Activated(object sender, EventArgs e)
        {
            FormManager.hlp.hlpRefresh(Name);
        }
    }
}