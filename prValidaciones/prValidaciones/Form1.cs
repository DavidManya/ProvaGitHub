using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prValidaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnombre, "Ingrese un nombre");
            this.ttmensaje.SetToolTip(this.txtedad, "Ingrese Edad");
            this.ttmensaje.SetToolTip(this.txtsalario, "Ingrese Salario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {
                erroricono.Clear();
                MessageBox.Show("Datos agregados correctamente", "validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool is_validate()
        {
            bool no_error = true;

            if (txtnombre.Text == string.Empty)
            {
                erroricono.SetError(txtnombre, "Ingrese su nombre");
                no_error = false;
            }
            else
            {
                try
                {
                    int i = Convert.ToInt32(txtedad.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtedad, "Ingrese Edad");
                    return false;
                }
                try
                {
                    double j = Convert.ToDouble(txtsalario.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtsalario, "Ingrese salario válido");
                    return false;
                }
            }
            return no_error;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
