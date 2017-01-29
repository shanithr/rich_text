using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rich_test_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font current, target;
            current = richTextBox1.SelectionFont;
            if(current.Bold)
                target = new Font(current, current.Style & ~FontStyle.Bold);
            else
                target = new Font(current,current.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = target;

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font current, target;
            current = richTextBox1.SelectionFont;
            if (current.Italic)
                target = new Font(current, current.Style & ~FontStyle.Italic);
            else
                target = new Font(current,current.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = target;
        }
    }
}
