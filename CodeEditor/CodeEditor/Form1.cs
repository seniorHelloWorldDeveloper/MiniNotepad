using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeEditor
{
    public partial class Form1 : Form
    {
        Files files = new Files();
        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 20, FontStyle.Regular);
            files.opf.FileName = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            files.openFile(richTextBox1);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            files.saveFileAs(richTextBox1);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            files.saveFile(richTextBox1);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            files.opf.FileName = "";
            richTextBox1.Text = "";
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 20, FontStyle.Regular);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }
    }
}
