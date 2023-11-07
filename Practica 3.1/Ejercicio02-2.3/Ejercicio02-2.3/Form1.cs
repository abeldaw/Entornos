using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTelegrama.Text;
            string[] tipoTelegrama = textoTelegrama.Split(' ');
            int numPalabras = textoTelegrama.Split(' ').Length;
            double coste = 0;

            if (cbUrgente.Checked)
            {
                coste = 2.5;
                
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 * 0.75 * (numPalabras - 10);
                }
            }
            else
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 * 0.5 * (numPalabras - 10);
                }
            }
            
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
