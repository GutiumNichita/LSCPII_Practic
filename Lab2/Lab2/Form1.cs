namespace Lab2
{
    public partial class Form1 : Form
    {
        Persoana ion;
        Persoana alex;
        int bank = 100;
        public void UpdateForm()
        {
            ionCashLabel.Text = ion.Name + " are  $" + ion.Cash;
            alexCashLabel.Text = alex.Name + " are  $" + alex.Cash;
            bankCashLabel.Text = "In baca sunt  $" + bank;
        }

        public Form1()
        {
            InitializeComponent();


            alex = new Persoana();
            alex.Name = "Alex";
            alex.Cash = 100;

            ion = new Persoana();
            ion.Name = "Ion";
            ion.Cash = 50;
            UpdateForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= ion.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("In banca nu sunt bani ");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bank += alex.GiveCash(5);
            UpdateForm();
        }

        private void ionGivesToAlex_Click(object sender, EventArgs e)
        {
            if (ion.Cash >= 10)
            {
                ion.GiveCash(10);
                alex.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Ion nu are destui bani");
            }
        }

        private void alexGivesToIon_Click(object sender, EventArgs e)
        {
            if (alex.Cash >= 5)
            {
                alex.GiveCash(5);
                ion.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Alex nu are destui bani");
            }
        }
    }

}
