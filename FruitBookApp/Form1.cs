using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitBookApp
{
    public partial class MainForm : Form
    {
        public List<Fruit> FruitLijst = new List<Fruit>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void CreateFruitButton_Click(object sender, EventArgs e)
        {
            var fruitForm = new FruitForm();
            fruitForm.Show();
            fruitForm.FormClosing += FruitForm_FormClosing;
            //fruitForm.Owner = this;
        }

        private void FruitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FruitForm fruitForm2 = sender as FruitForm;
            if (fruitForm2.DialogResult == DialogResult.OK)
            {
                FruitLijst.Add(fruitForm2.FruitStuk);
                this.listBox1.Items.Add(fruitForm2.FruitStuk);
            }

            //ViewFruitForm viewer = new ViewFruitForm(FruitLijst);
            //viewer.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewFruitForm viewer = new ViewFruitForm(FruitLijst);
            viewer.Show();
            
        }
    }
}
