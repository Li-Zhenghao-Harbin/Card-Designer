using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Designer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll ")]
        private static extern bool BitBlt(
            IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            System.Int32 dwRop
        );

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            Rtx_Description.Focus();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Lbl_CardTitle.Parent = Pic_Background;
            Lbl_CardPoints.Parent = Pic_Background;
            Lbl_CardShape.Parent = Pic_Background;
            Lbl_CardDescription.Parent = Pic_Background;
            Lbl_CardTitle.BackColor = Lbl_CardPoints.BackColor = Lbl_CardShape.BackColor = Lbl_CardDescription.BackColor = Color.Transparent;
            Combo_Level.SelectedIndex = 0;
            Rtx_Description.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
        }

        private void Btn_Icon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Insert image",
                Filter = "JPG|*.jpg|PNG|*.png",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
            {
                try
                {
                    Pic_Icon.Image = Image.FromFile(Tx_Icon.Text = openFileDialog.FileName);
                }
                catch { }
            }
            openFileDialog.Dispose();
        }

        private void Combo_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Combo_Level.SelectedIndex)
            {
                case 0:
                    Pic_Background.Image = Properties.Resources.BG1;
                    break;
                case 1:
                    Pic_Background.Image = Properties.Resources.BG2;
                    break;
                case 2:
                    Pic_Background.Image = Properties.Resources.BG3;
                    break;
                case 3:
                    Pic_Background.Image = Properties.Resources.BG4;
                    break;
            }
        }

        private void Tx_Title_TextChanged(object sender, EventArgs e)
        {
            Lbl_CardTitle.Text = Tx_Title.Text;
        }

        private void Num_Points_ValueChanged(object sender, EventArgs e)
        {
            Lbl_CardPoints.Text = Num_Points.Value.ToString();
        }

        private void AppendShape(string shape)
        {
            if (Tx_Shapes.TextLength < 3)
            {
                Tx_Shapes.AppendText(shape);
                Lbl_CardShape.Text = Tx_Shapes.Text;
            }
        }

        private void Btn_Shapes_Square_Click(object sender, EventArgs e)
        {
            AppendShape("■");
        }

        private void Btn_Shapes_UpperTriangle_Click(object sender, EventArgs e)
        {
            AppendShape("▲");
        }

        private void Btn_Shapes_LowerTriangle_Click(object sender, EventArgs e)
        {
            AppendShape("▼");
        }

        private void Btn_Shapes_Clear_Click(object sender, EventArgs e)
        {
            Tx_Shapes.Text = Lbl_CardShape.Text = "";
        }

        private void Rtx_Description_TextChanged(object sender, EventArgs e)
        {
            Lbl_CardDescription.Text = Rtx_Description.Text;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Export image",
                Filter = "JPG|*.jpg",
                FileName = ""
            };
            try
            {
                Graphics g1 = Pic_Background.CreateGraphics();
                Bitmap img = new Bitmap(Pic_Background.Width, Pic_Background.Height, g1);
                Graphics g2 = Graphics.FromImage(img);
                IntPtr dc1 = g1.GetHdc();
                IntPtr dc2 = g2.GetHdc();
                BitBlt(dc2, 0, 0, this.Pic_Background.Width, this.Pic_Background.Height, dc1, 0, 0, 13369376);
                g1.ReleaseHdc(dc1);
                g2.ReleaseHdc(dc2);
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                {
                    img.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutCardDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Card Designer\n\nv 1.0.0\n\nAnthor: Zhenghao Li");
        }
    }
}
