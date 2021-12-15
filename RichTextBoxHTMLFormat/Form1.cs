using System;
using System.Windows.Forms;

namespace RichTextBoxHTMLFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNegrito_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<b>" + textBox1.Text + "</b>", true);
        }

        private void btnItalico_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<i>" + textBox1.Text + "</i>", true);
        }

        private void btnSublinhado_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<u>" + textBox1.Text + "</u>", true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, textBox1.Text , true);
        }
    }
}
