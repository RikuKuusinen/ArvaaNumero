using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvaaNumero
{
    public partial class Form1 : Form
    {
        public int numero;
        public int arvauksia;
        public Random rng;
     
        public Form1()
        {
            InitializeComponent();
            Random rng = new Random();
            numero = rng.Next(10) + 1;
            alusta();

        }

        private void arvaa_Click_1(object sender, EventArgs e)
        {
            int arvattuNumero;
            if (int.TryParse(arvaus.Text, out arvattuNumero) && (arvattuNumero >= 1 && arvattuNumero <= 10))
            {
                if (arvattuNumero == numero)
                { 
                    MessageBox.Show("Onneksi olkoon!\nArvasit oikein!");
                alusta();
            }
            else if (arvattuNumero > numero)
            {
                arvauksia--;
                MessageBox.Show("Arvaamasi numero oli liian suuri!");
            }
            else if (arvattuNumero < numero)
            {
                arvauksia--;
                MessageBox.Show("Arvaamasi numero oli liian pieni!");
            }
            arvauksiaJaljella.Text = "Arvauksia jäljellä: " + arvauksia;

            if (arvauksia == 0)
            {
                MessageBox.Show("Arvauksesi loppuivat kesken");
                alusta();
            }
        }
            else
            {
                MessageBox.Show("Arvauksen tulee olla numero 1-10!");
            }

        }
        private void alusta()
        {
        
            arvauksia = 3;
            arvauksiaJaljella.Text = "Arvauksia jäljellä: " + arvauksia;

        }

    }
}
