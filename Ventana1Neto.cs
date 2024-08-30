using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Francisco Herrera 8-1005-1990

namespace Grupal_Lab2
{
    public partial class VentanaEntrada : Form
    {
        public VentanaEntrada()
        {
            InitializeComponent();
        }

        private void botonEntradaNeto_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salarioBruto = decimal.Parse(txtSalarioBruto.Text);
                decimal salarioBrutoAnual;
                salarioBrutoAnual = (salarioBruto * 13); //dividor por numero de meses en un año incluyendo decimo tercer mes

                decimal calcularISR;
                calcularISR = salarioBrutoAnual; //pasar para calcular ISR



                if (calcularISR <= Convert.ToDecimal(11000))
                {
                    calcularISR = calcularISR;

                }
                else if (calcularISR > Convert.ToDecimal(11000) && calcularISR < Convert.ToDecimal(50000))
                {
                    calcularISR = (((calcularISR - Convert.ToDecimal(11000)) * Convert.ToDecimal(0.15)) / 13);
                }
                else //despues de 50,000 dolares
                {
                    calcularISR = ((calcularISR - Convert.ToDecimal(50000)) * Convert.ToDecimal(0.25));
                    calcularISR = ((calcularISR + Convert.ToDecimal(5850)) / 13);

                }

                calcularISR = decimal.Round(calcularISR, 2);

                decimal pagoSeguroSocial = decimal.Round((salarioBruto * Convert.ToDecimal(0.0975)), 2);

                decimal pagoSeguroEducativo = decimal.Round((salarioBruto * Convert.ToDecimal(0.0125)), 2);

                decimal salarioNeto = decimal.Round((salarioBruto - pagoSeguroSocial - pagoSeguroEducativo - calcularISR), 2);

                //crear objeto con segunda ventana y mostrarla, usando nuestros datos como argumentos

                VentanaNeto ventana2Resultado = new VentanaNeto(salarioNeto, pagoSeguroSocial, pagoSeguroEducativo, calcularISR.ToString());
                ventana2Resultado.Show();
                this.Hide();
            }
            catch { // si algo falla
                VentanaNeto ventana2Resultado = new VentanaNeto(0.0m, 0.0m, 0.0m, "No paga ISR");
                ventana2Resultado.Show();
                this.Hide();
            }

        }

        private void botonEntradaCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra el programa

        }

        private void EliminarTexto(TextBox cajaTxt, String patron) {
            if (System.Text.RegularExpressions.Regex.IsMatch(cajaTxt.Text, patron))
            {
                cajaTxt.Text = cajaTxt.Text.Remove(cajaTxt.Text.Length - 1);
                cajaTxt.SelectionStart = cajaTxt.Text.Length;
            }
        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            EliminarTexto(txtNombreEmpleado, "[^A-Z ]");
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            EliminarTexto(txtCedula, "[^0-9-E]");

        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {

            EliminarTexto(txtSalarioBruto, "[^0-9.]");
            EliminarTexto(txtSalarioBruto, @"\.\d\d\d");

        }
    }
}
