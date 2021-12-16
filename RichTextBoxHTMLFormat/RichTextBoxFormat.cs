using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxHTMLFormat
{

    /*
     * Classe criado por Rodrigo Dalpiaz (@digao-dalpiaz) em VB.NET
     * Convertida por Giovani da Silva (@GiovaniDaSilva)
     */

    public class MotorRichFmt
    {

        private RichTextBox Rich;
        
        public StringBuilder PureText = new StringBuilder();
       
        //Link
        public static Token LT_Link = new("A", true);

        //Bold
        private static Token LT_Bold = new Token("B", false);

        //Italic
        private static Token LT_Italic = new Token("I", false);

        //Underline
        private static Token LT_Underline = new Token("U", false);

        //Font Color
        private static Token LT_Color = new Token("FC", true);

        //Font Size
        private static Token LT_Size = new Token("FS", true);

        //Font Name
        private static Token LT_Name = new Token("FN", true);

        //Background Color
        private static Token LT_Backgound = new Token("BC", true);


        public Token[] Tokens { get; set; } = { LT_Link, LT_Bold, LT_Italic, LT_Underline, LT_Color, LT_Size, LT_Name, LT_Backgound };

        public MotorRichFmt(RichTextBox Rich)
        {
            this.Rich = Rich;
        }

        private  FontStyle GetStyleByValues(bool bBold, bool bItalic, bool bUnderline)
        {
            FontStyle fs = 0;
            if (bBold)
                fs = fs | FontStyle.Bold;
            if (bItalic)
                fs = fs | FontStyle.Italic;
            if (bUnderline)
                fs = fs | FontStyle.Underline;
            return fs;
        }

        private void InitListas()
        {
            Font f = Rich.Font;
            LT_Bold.Lst.Add(f.Bold);
            LT_Italic.Lst.Add(f.Italic);
            LT_Underline.Lst.Add(f.Underline);
            LT_Color.Lst.Add(Rich.ForeColor);
            LT_Size.Lst.Add(f.Size);
            LT_Name.Lst.Add(f.Name);
            LT_Backgound.Lst.Add(Rich.BackColor);
        }

        private void VerTag(string tag)
        {
            string cmd = Strings.Mid(tag, 2, tag.Length - 2);
            bool Final = cmd.StartsWith("/");
            if (Final)
                cmd = cmd.Remove(0, 1);
            int x = cmd.IndexOf(":") + 1;
            string par = string.Empty;
            if (x > 0) // Tag tem parâmetro
            {
                par = Strings.Mid(cmd, x + 1);
                cmd = Strings.Mid(cmd, 1, x - 1);
            }

            cmd = cmd.ToUpper();
            var Tk = (from _tk in Tokens
                      where (_tk.Tag ?? "") == (cmd ?? "")
                      select _tk).FirstOrDefault();
            if (Tk is null)
            {
                throw new Exception("Token inválido");
            }

            if (Final)
            {
                int ult = 1;
                if (ReferenceEquals(Tk, LT_Link))
                    ult = 0;
                if (Tk.Lst.Count == ult)
                    throw new Exception("Fechamento excedido");
                Tk.DelLast();
            }
            else
            {
                if (Tk.ParRequired & (par ?? "") == (string.Empty ?? ""))
                {
                    throw new Exception("Parâmetro requerido");
                }

                Tk.AddMethod(par);
            }

            if (ReferenceEquals(Tk, LT_Link))
                return;
            Rich.SelectionFont = new Font(Conversions.ToString(LT_Name.Prop),
                                          Conversions.ToSingle(LT_Size.Prop), 
                                          GetStyleByValues(Conversions.ToBoolean(LT_Bold.Prop), 
                                                           Conversions.ToBoolean(LT_Italic.Prop), 
                                                           Conversions.ToBoolean(LT_Underline.Prop)));
            Rich.SelectionColor = (Color)LT_Color.Prop;
            Rich.SelectionBackColor = (Color)LT_Backgound.Prop;          
        }

  

        public void DoFmt(string Text)
        {
            InitListas();
            while ((Text ?? "") != (string.Empty ?? ""))
            {
                string a;
                int x;
                if (Conversions.ToString(Text[0]) == "<")
                {
                    // Tag
                    x = Text.IndexOf(">") + 1;
                    if (x == 0)
                        throw new Exception($"Finalizador da tag '{Text}' não encontrado");
                    a = Strings.Mid(Text, 1, x);
                    Text = Text.Remove(0, x);
                    try
                    {
                        VerTag(a);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Erro na tag {a}: {ex.Message}");
                    }
                }
                else
                {
                    // Texto
                    x = Text.IndexOf("<") + 1; // Localizar próxima tag
                    if (x == 0)
                        x = Text.Length + 1;
                    a = Strings.Mid(Text, 1, x - 1);
                    Text = Text.Remove(0, x - 1);
                    a = a.Replace("&lt;", "<");
                    a = a.Replace("&gt;", ">");
                    



                    LinkLabel link = new LinkLabel();
                    link.Text = "http://google.com.br";
                    link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
                    LinkLabel.Link data = new LinkLabel.Link();
                    data.LinkData = "http://google.com.br";
                    link.Links.Add(data);
                    link.AutoSize = true;
                    link.Location = Rich.GetPositionFromCharIndex(Rich.TextLength);
                    this.Rich.Controls.Add(link);


                    Rich.SelectedText = a;

                    PureText.Append(a);
                }
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.Link.LinkData.ToString());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e, LinkLabel llLinkLabel)
        {
            UseHyperlink(llLinkLabel);
        }

        public void UseHyperlink(LinkLabel llLinkLabel)
        {
            try
            {
                if (llLinkLabel.Links.Count > 0)
                {
                    string sLink = llLinkLabel.Links[0].LinkData.ToString();
                    System.Diagnostics.Process.Start(sLink);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Link error!", ex);
            }
        }
    }


    public class Token
    {
        public List<object> Lst = new List<object>();
        public string Tag;
        public bool ParRequired;
        //public Action<string> AddMethod;

        public void AddMethod(string str)
        {
            if (this.Tag.Contains("FC") || this.Tag.Contains("BC"))
            {
                this.Lst.Add(Color.FromName(str));
            }
            else if (this.Tag.Equals("B") || this.Tag.Equals("I") || this.Tag.Equals("U"))
            {
                this.Lst.Add(true);
            }
            else
            {
                this.Lst.Add(str);
            }
        }

        public Token(string tag, bool parRequired)
        {
            Tag = tag;
            ParRequired = parRequired;
        }

        public void DelLast()
        {
            Lst.RemoveAt(Lst.Count - 1);
        }

        public object Prop
        {
            get
            {
                return Lst.Last();
            }
        }
    }


    public static partial class RichHTMLFormatting
    {
        public static void RichGoToEnd(RichTextBox Rich)
        {
            Rich.SelectionStart = Rich.TextLength;
        }

        public static void RichAddFmt(RichTextBox Rich, string Text, bool AtEnd = true)
        {
            if (AtEnd)
                RichGoToEnd(Rich);
            MotorRichFmt motor = new MotorRichFmt(Rich);
            motor.DoFmt(Text);
        }

        public static void RichAddLineFmt(RichTextBox Rich, string Text, bool AtEnd = true)
        {
            RichAddFmt(Rich, Text + Environment.NewLine, AtEnd);
        }

        public partial class clsRichHTMLFmtVar
        {
            public int StartPos;
            public int Length;
        }

        public static clsRichHTMLFmtVar RichAddFmtVar(RichTextBox Rich, string Text, bool AtEnd = true)
        {
            if (AtEnd)
                RichGoToEnd(Rich);
            var v = new clsRichHTMLFmtVar();
            v.StartPos = Rich.SelectionStart;
            RichAddFmt(Rich, Text, false);
            v.Length = Rich.TextLength - v.StartPos;
            return v;
        }

        public static void RichSetVar(RichTextBox Rich, string Text, clsRichHTMLFmtVar Var)
        {
            var old_pos = Rich.SelectionStart;
            Rich.SelectionStart = Var.StartPos;
            Rich.SelectionLength = Var.Length;
            var old_length = Rich.TextLength;
            RichAddFmt(Rich, Text, false);
            var len_dif = Rich.TextLength - old_length;
            Var.Length += len_dif; // Atualizar tamanho da variável
            Rich.SelectionStart = old_pos + len_dif;
        }

        public static string StringToRtf(string a)
        {            
            a = a.Replace(@"\", @"\\");
            return a;
        }
    }
}
