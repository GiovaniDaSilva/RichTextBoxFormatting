﻿namespace RichTextBoxHTMLFormat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNegrito = new System.Windows.Forms.Button();
            this.btnItalico = new System.Windows.Forms.Button();
            this.btnSublinhado = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnNegrito
            // 
            this.btnNegrito.Location = new System.Drawing.Point(12, 249);
            this.btnNegrito.Name = "btnNegrito";
            this.btnNegrito.Size = new System.Drawing.Size(75, 23);
            this.btnNegrito.TabIndex = 2;
            this.btnNegrito.Text = "Negrito";
            this.btnNegrito.UseVisualStyleBackColor = true;
            this.btnNegrito.Click += new System.EventHandler(this.btnNegrito_Click);
            // 
            // btnItalico
            // 
            this.btnItalico.Location = new System.Drawing.Point(93, 249);
            this.btnItalico.Name = "btnItalico";
            this.btnItalico.Size = new System.Drawing.Size(75, 23);
            this.btnItalico.TabIndex = 3;
            this.btnItalico.Text = "Italico";
            this.btnItalico.UseVisualStyleBackColor = true;
            this.btnItalico.Click += new System.EventHandler(this.btnItalico_Click);
            // 
            // btnSublinhado
            // 
            this.btnSublinhado.Location = new System.Drawing.Point(174, 249);
            this.btnSublinhado.Name = "btnSublinhado";
            this.btnSublinhado.Size = new System.Drawing.Size(75, 23);
            this.btnSublinhado.TabIndex = 4;
            this.btnSublinhado.Text = "Sublinhado";
            this.btnSublinhado.UseVisualStyleBackColor = true;
            this.btnSublinhado.Click += new System.EventHandler(this.btnSublinhado_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSublinhado);
            this.Controls.Add(this.btnItalico);
            this.Controls.Add(this.btnNegrito);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNegrito;
        private System.Windows.Forms.Button btnItalico;
        private System.Windows.Forms.Button btnSublinhado;
        private System.Windows.Forms.Button btnAdd;
    }
}