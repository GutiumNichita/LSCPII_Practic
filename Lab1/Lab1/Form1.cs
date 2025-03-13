namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float.TryParse(textBox3.Text, out float txt3);
            MessageBox.Show($"numele este {textBox1.Text}\nx este {textBox2.Text}\nd este {Math.Sqrt(txt3)}", "Informații");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            if (x != 10)
            {
                MessageBox.Show("x nu este 10");
            }
            else if (x == 10)
            {
                MessageBox.Show("x trebuie sa fie 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            if (x == 3)
            {
                MessageBox.Show($"x este 3 si numele este {textBox1.Text}");
            }
            else if (x != 3)
            {
                MessageBox.Show("nu conteaza ce apare");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0; // Inițializăm variabila count

            // Ciclul WHILE: creștem count până ajunge la 10
            while (count < 10)
            {
                count += 1; // count = count + 1;
            }

            // Ciclul FOR: scădem count dacă i < 5
            for (int i = 0; i < 5; i++)
            {
                count -= 1; // count = count - 1;
            }

            // Afișăm rezultatul final într-un MessageBox
            MessageBox.Show($"Valoarea finală a lui count este: {count}", "Rezultat");

        }
    }
}
