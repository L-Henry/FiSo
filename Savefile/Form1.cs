using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savefile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            using (var save = new FolderBrowserDialog())
            {
                DialogResult result = save.ShowDialog();

                if (save.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(save.SelectedPath);
                }
                else
                {
                    MessageBox.Show("Er is geen pad gekozen.");
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("hhh");
            if (e.KeyCode == Keys.Return)
            {
                Button1_Click(this,e);
            }
        }


        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Console.WriteLine("Enter is ingeduwd.");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
