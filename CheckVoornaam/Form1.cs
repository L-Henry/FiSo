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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                f2.ShowDialog();
                if (f2.Validate())
                {
                    listBox1.Items.Add(f2.persoon);
                }
                f2.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }     
    }
}
