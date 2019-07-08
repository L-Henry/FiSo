using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int turns = 1;
        Form2 f2;

        public void AddExcl()
        {
            textBox1.Text += "!";
        }

        public Form1()
        {
            //InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            f2 = new Form2();
            f2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Is clicked.");
            //AddExcl();

            Size = new Size(400, 400);
            Location = new Point(200, 200);

            timer1.Start();

            using (f2)
            {
                if (f2.progressBar2.Value == f2.progressBar2.Maximum)
                {
                    textBox1.Clear();
                    f2.progressBar2.Value = 0;
                    turns += 1;
                }
                else
                {
                    textBox1.Text += "!";
                    Click += TextBox1_TextChanged;
                    f2.progressBar2.Value += 1;
                }
                if (turns == 3)
                {
                    Close();
                }
            }
            /*
            if (f2.progressBar1.Value == progressBar1.Maximum)
            {
                textBox1.Clear();
                progressBar1.Value = 0;
                turns += 1;
            }
            else
            {
                textBox1.Text += "!";
                Click += TextBox1_TextChanged;
                progressBar1.Value += 1;
            }
            if (turns == 3)
            {
                Close();
            }
            */
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Is geactiveerd.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Activated += Form1_Activated;
            Console.WriteLine("Is geladen.");
            Size = new Size(750, 500);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.TextLength.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) % 3 == 0)
            {
                Button1_Click(this, e);
                //AddExcl();
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Location changed.");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 300;
            Button1_Click(this, e);
        }
    }
}
