using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog
            {
                ShowColor = true,
                ShowEffects = true,
                Font = richText.Font
            };

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.SelectionFont = fontDlg.Font;
                richText.SelectionColor = fontDlg.Color;
            }
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
            toolStripComboBox1.Text = fontDlg.Font.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void nhậpVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt",
                Title = "Open File"
            };
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                richText.LoadFile(openDlg.FileName, openDlg.FilterIndex == 1 ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf",
                Title = "Save File"
            };
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont;
            FontStyle newStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            richText.SelectionFont = new Font(currentFont, newStyle);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont;
            FontStyle newStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
            richText.SelectionFont = new Font(currentFont, newStyle);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font currentFont = richText.SelectionFont;
            FontStyle newStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
            richText.SelectionFont = new Font(currentFont, newStyle);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf",
                Title = "Save File"
            };
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}