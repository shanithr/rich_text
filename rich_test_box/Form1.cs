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

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font current, target;
            current = richTextBox1.SelectionFont;
            if (current.Underline)
                target = new Font(current, current.Style & ~FontStyle.Underline);
            else
                target = new Font(current, current.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = target;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionColor == Color.Red)
                richTextBox1.SelectionColor = Color.Black;
            else
                richTextBox1.SelectionColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionColor == Color.Green)
                richTextBox1.SelectionColor = Color.Black;
            else
                richTextBox1.SelectionColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionColor == Color.Blue)
                richTextBox1.SelectionColor = Color.Black;
            else
                richTextBox1.SelectionColor = Color.Blue;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            colordlg.Color =richTextBox1.SelectionColor;
            if (colordlg.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = colordlg.Color;
            }

        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        ToolTip ex = new ToolTip();

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            ex.Show("exit", exitButton);
        }
    }
}
