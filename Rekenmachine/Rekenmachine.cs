using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Rekenmachine : Form
    {
        public Rekenmachine()
        {
            InitializeComponent();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            double result = Program.Bereken(textBox1.Text);
            textBox1.Text = result.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void ButtonMaal_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void ButtonDeel_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void ButtonOpenHaak_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void ButtonCloseHaak_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                BackColor = Color.Gray;
                if (result > 0 && result < 500)
                {
                    ForeColor = Color.Goldenrod;
                }
                else if (result > 500 && result < 9000)
                {
                    ForeColor = Color.CadetBlue;
                }
                else if (result > 9000)
                {
                    ForeColor = Color.GhostWhite;
                }
                else
                {
                    ForeColor = Color.Gold;
                }
            }
            else
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}
