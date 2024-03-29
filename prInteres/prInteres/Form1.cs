﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prInteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            double capital, razon, tiempo;
            double interes, monto;
            //Entrada de datos
            capital = double.Parse(txtcapital.Text);
            razon = double.Parse(txtrazon.Text);
            tiempo = double.Parse(txttiempo.Text);
            //Proceso
            monto = Math.Pow((1 + razon), tiempo) * capital;
            interes = monto - capital;
            //Salida de la información
            txtmontofinal.Text = Convert.ToString(monto);
            txttotalinteres.Text = Convert.ToString(interes);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtmontofinal.Clear();
            txtcapital.Clear();
            txtrazon.Clear();
            txttiempo.Clear();
            txttotalinteres.Clear();
        }
    }
}
