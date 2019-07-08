using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressenBeheren
{
    public partial class Form1 : Form
    {
        public List<Person> PersonList { get; set; }
        public bool Down { get; set; } = true;

        public Form1()
        {
            InitializeComponent();
            PersonList = new List<Person>();
            PersonList.Add(new Person { Voornaam = "Kenny", Achternaam = "Kan", GeboorteDatum = new DateTime(2000,02,22), Id = 1, Kleur = Color.Gold});
            PersonList.Add(new Person { Voornaam = "Lars", Achternaam = "Khan", GeboorteDatum = new DateTime(1988,12,21), Id = 2, Kleur = Color.Goldenrod });
            PersonList.Add(new Person { Voornaam = "Raymond", Achternaam = "Longe", GeboorteDatum = new DateTime(1987,12,11), Id = 3, Kleur = Color.GreenYellow });
            PersonList.Add(new Person { Voornaam = "Joris", Achternaam = "Uitloop", GeboorteDatum = new DateTime(1995,09,08), Id = 4, Kleur = Color.Indigo });
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person persoon = listBox1.SelectedItem as Person;
            voornaamLabel.Text = persoon.Voornaam;
            voornaamLabel.BackColor = persoon.Kleur;
            achternaamLabel.Text = persoon.Achternaam;
            achternaamLabel.BackColor = persoon.Kleur;
            leeftijdLabel.Text = persoon.Leeftijd + " jaar";
            listBox1.BackColor = persoon.Kleur;
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex -= 1;
            }
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < PersonList.Count() - 1)
            {
                listBox1.SelectedIndex += 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = PersonList;
            listBox1.DisplayMember = "Voornaam";
            listBox1.ValueMember = "Id";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;

            if (listBox1.SelectedIndex == PersonList.Count() - 1)
            {
                Down = false;
            }
            else if (listBox1.SelectedIndex == 0)
            {
                Down = true;
            }

            if (Down)
            {
                ButtonDown_Click(this, e);
            }
            else
            {
                Button1_Click(this, e);
            }
        }
    }
}
