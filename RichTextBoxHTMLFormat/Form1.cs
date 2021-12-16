using System;
using System.Diagnostics;
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

        private void btnLink_Click(object sender, EventArgs e)
        {            
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<a:https://google.com.br>" + textBox1.Text + "</a>", true);
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<bc:blue>" + textBox1.Text + "</bc>", true);
        }

        private void btnFs_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<fs:20>" + textBox1.Text + "</fs>", true);
        }

        private void btnfc_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<fc:red>" + textBox1.Text + "</fc>", true);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
           // richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<a:https://yahoo.com.br>" + textBox1.Text + "</a>", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RichHTMLFormatting.RichAddLineFmt(richTextBox1, "<a:https://bing.com.br>" + textBox1.Text + "</a>", true);            
        }

    }
     
}
