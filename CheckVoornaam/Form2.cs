using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVoornaam
{
    public partial class Form2 : Form
    {
        public Persoon persoon { get; set; }
        public Color KleurKeuze { get; set; }
        public  List<string> ErrorList { get; set; }

        public Form2()
        {
            InitializeComponent();     
        }

        public void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.All(c => char.IsLetter(c)) && char.IsUpper(textBox1.Text.First()))
            {
                
            }
            else
            {
                
                ErrorList.Add("Voornaam is niet aanvaard.");
            }
        }

        public void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox2.Text.All(c => char.IsLetter(c)))
            {
                
            }
            else
            {
                
                ErrorList.Add("Kleur is niet aanvaard.");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (ErrorList.Count() == 0)
            {
                persoon = new Persoon { Voornaam = textBox1.Text, Kleur = KleurKeuze };
                Close();
            }
            else
            {
               
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (var clr = new ColorDialog())
            {
                clr.ShowDialog();
                textBox2.Text = clr.Color.Name;
                KleurKeuze = clr.Color;
            }
        }
    }
}
