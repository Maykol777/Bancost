using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(txtMontoCredito.Text);
            int cuotas = int.Parse(txtCantidadCuotas.Text);
            if (monto >= 500000)
            {
                if (cuotas >= 1 && cuotas <= 36)
                {
                    float interes = 0;
                    if (cuotas >= 1 && cuotas <= 12)
                    {
                        interes = monto * float.Parse("0,1");
                    }
                    else if (cuotas >= 13 && cuotas <= 24)
                    {
                        interes = monto * float.Parse("0,2");
                    }
                    else if (cuotas >= 25 && cuotas <= 36)
                    {
                        interes = monto * float.Parse("0,35");
                    }
                    float montototal = monto + interes;
                    float valorcuota = montototal / cuotas;
                    txtTotal.Text = Convert.ToString(montototal);
                    txtCuota.Text = Convert.ToString(valorcuota);

                }
                else
                {
                    MessageBox.Show("La cuota debe estar entre 1 y 36 minimo");
                }
            }
            else
            {
                MessageBox.Show("Monto minimo  de 500000");
            }      

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
          
        }
    }
}
