namespace RichTextBoxHTMLFormat
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
            this.btnLink = new System.Windows.Forms.Button();
            this.btnfc = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnFs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
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
            this.btnNegrito.Location = new System.Drawing.Point(12, 263);
            this.btnNegrito.Name = "btnNegrito";
            this.btnNegrito.Size = new System.Drawing.Size(75, 23);
            this.btnNegrito.TabIndex = 2;
            this.btnNegrito.Text = "Negrito";
            this.btnNegrito.UseVisualStyleBackColor = true;
            this.btnNegrito.Click += new System.EventHandler(this.btnNegrito_Click);
            // 
            // btnItalico
            // 
            this.btnItalico.Location = new System.Drawing.Point(93, 263);
            this.btnItalico.Name = "btnItalico";
            this.btnItalico.Size = new System.Drawing.Size(75, 23);
            this.btnItalico.TabIndex = 3;
            this.btnItalico.Text = "Italico";
            this.btnItalico.UseVisualStyleBackColor = true;
            this.btnItalico.Click += new System.EventHandler(this.btnItalico_Click);
            // 
            // btnSublinhado
            // 
            this.btnSublinhado.Location = new System.Drawing.Point(174, 263);
            this.btnSublinhado.Name = "btnSublinhado";
            this.btnSublinhado.Size = new System.Drawing.Size(75, 23);
            this.btnSublinhado.TabIndex = 4;
            this.btnSublinhado.Text = "Sublinhado";
            this.btnSublinhado.UseVisualStyleBackColor = true;
            this.btnSublinhado.Click += new System.EventHandler(this.btnSublinhado_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(411, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Manual";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(332, 309);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(91, 23);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Link 1";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnfc
            // 
            this.btnfc.Location = new System.Drawing.Point(12, 309);
            this.btnfc.Name = "btnfc";
            this.btnfc.Size = new System.Drawing.Size(237, 23);
            this.btnfc.TabIndex = 7;
            this.btnfc.Text = "Fonte Color Red";
            this.btnfc.UseVisualStyleBackColor = true;
            this.btnfc.Click += new System.EventHandler(this.btnfc_Click);
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(13, 367);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(236, 23);
            this.btnBC.TabIndex = 8;
            this.btnBC.Text = "Backgroud Color Blue";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnFs
            // 
            this.btnFs.Location = new System.Drawing.Point(13, 338);
            this.btnFs.Name = "btnFs";
            this.btnFs.Size = new System.Drawing.Size(236, 23);
            this.btnFs.TabIndex = 9;
            this.btnFs.Text = "Fonte Size 20";
            this.btnFs.UseVisualStyleBackColor = true;
            this.btnFs.Click += new System.EventHandler(this.btnFs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Link 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Link 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFs);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnfc);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSublinhado);
            this.Controls.Add(this.btnItalico);
            this.Controls.Add(this.btnNegrito);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RichTextBox Formatting";
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
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnfc;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnFs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
