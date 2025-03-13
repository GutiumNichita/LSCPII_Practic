using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    class Persoana
    {
        public string Name;
        public int Cash;
        public int GiveCash(int suma)
        {
            if (suma <= Cash && suma > 0)
            {
                Cash -= suma;
                return suma;
            }
            else
            {
                MessageBox.Show(
                    "Nu am suficienti bani ",
                   Name + " spune");
                return 0;
            }
        }

        public int ReceiveCash(int suma)
        {
            if (suma > 0)
            {
                Cash += suma;
                return suma;
            }
            else
            {
                MessageBox.Show(suma + "Nu am nevoie",
                   "spune" + Name);
                return 0;
            }
        }

    }
}
