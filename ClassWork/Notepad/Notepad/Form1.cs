using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmMain : Form
    {
        string OurFileName;

        string LastFindWord;
        bool LastFindDown;
        bool LastFindMatchCase;

        void DoSave (string fileName)
        {
            OurFileName = fileName;
            textBox1.SaveFile(fileName);
        }

        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        bool CheckChanes()
        {
            return true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanes())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurFileName))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(OurFileName);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFind find = new frmFind();
            find.Show(this);
        }

        public void DoFind(string search, bool down, bool match_case)
        {
            LastFindWord = search;
            LastFindDown = down;
            LastFindMatchCase = match_case;

            if (down)
            {
                if (match_case)
                {
                    textBox1.Find(search, textBox1.SelectionStart + 1, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    textBox1.Find(search, textBox1.SelectionStart + 1, RichTextBoxFinds.None);
                }
            }
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain parent_firm = (frmMain)Owner;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
