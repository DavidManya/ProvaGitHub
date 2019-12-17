using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructurasCondicionales2
{
    public partial class frclima : Form
    {
        public frclima()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            byte temperatura;
            string clima;
            //Entrada de datos
            temperatura = Convert.ToByte(txttemperatura.Text);
            //Proceso
            if (temperatura < 10)
            {
                clima = "Frío";
            }
            else if (temperatura >= 10 && temperatura <= 20)
            {
                clima = "Nublado";
            }
            else if (temperatura > 20 && temperatura <= 30)
            {
                clima = "Calor";
            }
            else
            {
                clima = "Tropical";
            }
            //Salida de la Información
            txtclima.Text = clima;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txttemperatura.Clear();
            txtclima.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
