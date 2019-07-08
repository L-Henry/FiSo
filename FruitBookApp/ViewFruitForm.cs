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
    public partial class ViewFruitForm : Form
    {

        public List<Fruit> FruitLijst { get; set; }
            
        public ViewFruitForm(List<Fruit> fruitlijst)
        {
            InitializeComponent();
            FruitLijst = fruitlijst.OrderBy(c => c.Naam).ThenBy(c => c.Houdbaarheidsdatum).ToList();
            for (int i = 0; i < FruitLijst.Count(); i++)
            {
                comboBox1.Items.Add(FruitLijst[i]);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fruit fr = comboBox1.SelectedItem as Fruit;
            label1.Text = fr.Naam;
            label2.Text = fr.Houdbaarheidsdatum.ToLongDateString();
            pictureBox1.ImageLocation = fr.Filepath;            
        } 
    }
}
