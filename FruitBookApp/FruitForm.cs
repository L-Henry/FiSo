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
    public partial class FruitForm : Form
    {
        public Fruit FruitStuk { get; set; }
        public string FilePath { get; set; }
        public DateTime Datum { get; set; }

        public FruitForm()
        {
            InitializeComponent();
        }

        private void CreateButton2_Click(object sender, EventArgs e)
        {       
            if (this.ValidateChildren())
            {
                FruitStuk = new Fruit
                {
                    Naam = fruitNaamTextBox.Text,
                    Houdbaarheidsdatum = Datum,
                    Filepath = FilePath
                };
                //MainForm mf = (MainForm)this.Owner;
                //mf.listBox1.Items.Add(fruit);
                Console.WriteLine("Added");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void FruitNaamTextBox_Validating(object sender, CancelEventArgs e)
        {
            var errorList = new List<string>();
            if (fruitNaamTextBox.Text.Length == 0)
            {
                errorList.Add("Please enter a name");
            }
            else
            {
                if (!char.IsUpper(fruitNaamTextBox.Text[0]))
                {
                    errorList.Add("First name should start with a capital letter.");
                }
                if (!fruitNaamTextBox.Text.Substring(1).All(c => char.IsLower(c)))
                {
                    errorList.Add("Only the first letter of the name should be capital.");
                }
                if (fruitNaamTextBox.Text.Length < 2)
                {
                    errorList.Add("Naam te kort.");
                }
            }
            string errorMsg = null;
            if (errorList.Any())
            {
                e.Cancel = true;
                errorMsg = errorList.Aggregate((a, b) => $"{a},\r\n{b}");
            }
            errorProvider1.SetError((Control)sender, errorMsg);
        }

        private void HoudbaarheidTextBox_Validating(object sender, CancelEventArgs e)
        {
            var errors = new List<string>();
            if (houdbaarheidTextBox.Text.Length == 0)
            {
                errors.Add("Geef datum.");
            }
            string errorMsg = null;
            if (errors.Any())
            {
                e.Cancel = true;
                errorMsg = errors.Aggregate((a, b) => $"{a},\r\n{b}");
            }
            errorProvider1.SetError((Control)sender, errorMsg);
        }

        private void FilePathButton_Click(object sender, EventArgs e)
        {
            using (var fp = new OpenFileDialog())
            {
                fp.ShowDialog();
                FilePath = fp.FileName;
            }
            filePathBox.Text = FilePath;
            fruitPictureBox.ImageLocation = FilePath;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Datum = dateTimePicker1.Value.Date;
            houdbaarheidTextBox.Text = dateTimePicker1.Text;
        }

        private void FilePathBox_Validating(object sender, CancelEventArgs e)
        {
            var errors = new List<string>();
            if (filePathBox.Text.Length == 0)
            {
                errors.Add("Kies foto.");
            }
            string errorMsg = null;
            if (errors.Any())
            {
                e.Cancel = true;
                errorMsg = errors.Aggregate((a, b) => $"{a},\r\n{b}");
            }
            errorProvider1.SetError((Control)sender, errorMsg);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }

        private void DateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            var errors = new List<string>();
            if (dateTimePicker1.Value.Date < DateTime.Now.AddDays(1))
            {
                errors.Add("Datum moet minstens morgen zijn.");
            }
            string errorMsg = null;
            if (errors.Any())
            {
                e.Cancel = true;
                errorMsg = errors.Aggregate((a, b) => $"{a},\r\n{b}");
            }
            errorProvider1.SetError((Control)sender, errorMsg);
        }
    }
}
