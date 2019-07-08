using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicky
{
    public partial class Form1 : Form
    {
        Random r1 = new Random();
        Random r2 = new Random(555);
        Random r3 = new Random(9001);

        int TickTeller = 0;
        int TickTeller2 = 0;
        double Points = 0;
        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int r1Int = r1.Next(0, Size.Height - button1.Height);
            int r1Int2 = r1.Next(0, Size.Width - button1.Width);

            timer1.Start();

            TickTeller2 += 1;
            if (TickTeller < TickTeller2)
            {
                button1.Location = new Point(r1Int2, r1Int);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show(Points.ToString());
            }

            Points += Math.Pow(1 / (Math.Abs((double)MousePosition.X - ((double)button1.Location.X + (double)button1.Width)/2)), 2);
            Console.WriteLine(Points);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            TickTeller += 1;

            button1.Height -= 5;
            button1.Width -= 5;

            int r2Int1 = r2.Next(0,255);
            int r2Int2 = r2.Next(0,255);
            int r2Int3 = r2.Next(0,255);

            int r3Int1 = r3.Next(0, 255);
            int r3Int2 = r3.Next(0, 255);
            int r3Int3 = r3.Next(0, 255);
            int r3Int4 = r3.Next(0, 255);


            if (button1.Height <= 0)
            {
                timer1.Stop();
                MessageBox.Show(Points.ToString());
            }

            BackColor = Color.FromArgb(r2Int1, r2Int2, r2Int3);
            button1.BackColor = Color.FromArgb(r3Int1, r3Int2, r3Int3, r3Int4);
        }
    }
}
