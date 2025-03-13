using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int startKilometraj, stopKilometraj;
            double kilometriParcurs, rataRambursata = 40, sumaRambursata;

            if (!int.TryParse(textBox1.Text, out startKilometraj) || !int.TryParse(textBox2.Text, out stopKilometraj))
            {
                MessageBox.Show("Introduceți valori numerice valide!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startKilometraj > stopKilometraj)
            {
                MessageBox.Show("Distanta initiala nu poate fi mai mare ca cea finala", "Nu se poate calcula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kilometriParcurs = stopKilometraj - startKilometraj;
            sumaRambursata = kilometriParcurs * rataRambursata;
            labelSuma.Text = sumaRambursata.ToString() + " Lei";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int startKilometraj, stopKilometraj;
            double kilometriParcurs;

            if (!int.TryParse(textBox1.Text, out startKilometraj) || !int.TryParse(textBox2.Text, out stopKilometraj))
            {
                MessageBox.Show("Introduceți valori numerice valide!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startKilometraj > stopKilometraj)
            {
                MessageBox.Show("Distanta initiala nu poate fi mai mare ca cea finala", "Nu Pot Calcula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kilometriParcurs = stopKilometraj - startKilometraj;
            MessageBox.Show("Distanta este: " + kilometriParcurs.ToString() + " km", "Distanta parcursa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
