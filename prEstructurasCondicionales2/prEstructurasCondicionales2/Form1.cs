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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pxcuadrado.Visible = false;
            pxrectangulo.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            double ladoa, ladob;
            double area, perimetro;
            //Entrada de datos
            ladoa = Convert.ToDouble(txtladoa.Text);
            ladob = Convert.ToDouble(txtladob.Text);
            //Proceso
            //Evaluamos si es un cuadrado o un rectángulo
            if (ladoa == ladob) 
            {
                pxcuadrado.Visible = true;
                pxrectangulo.Visible = false;
            }
            else 
            {
                pxcuadrado.Visible = false;
                pxrectangulo.Visible = true;
            }
            //Calcular área y perímetro
            area = ladoa * ladob;
            perimetro = 2 * (ladoa + ladob);
            //Salida de la información
            txtarea.Text = Convert.ToString(area);
            txtperimetro.Text = Convert.ToString(perimetro);

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtladoa.Clear();
            txtladob.Clear();
            txtarea.Clear();
            txtperimetro.Clear();
            pxcuadrado.Visible = false;
            pxrectangulo.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
