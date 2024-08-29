using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Francisco Herrera 8-1005-1990


namespace FranciscoHerrera_Lab1
{
    public partial class VentanaNeto : Form
    {
        private string nombreLocal;
        private string cedulaLocal;
        private decimal valorSalarioNetoLocal;
        private decimal valorSeguroSocialLocal;
        private decimal valorSeguroEducativoLocal;
        public VentanaNeto(string entradaNombre, string entradaCedula, decimal entradaSalarioNeto, 
            decimal entradaSeguroSocial, decimal entradaSeguroEducativo)
        {
            InitializeComponent();
             nombreLocal = entradaNombre;
             cedulaLocal = entradaCedula;
             valorSalarioNetoLocal = entradaSalarioNeto;
             valorSeguroSocialLocal = entradaSeguroSocial;
             valorSeguroEducativoLocal = entradaSeguroEducativo;
        }



        private void Ventana2Resultado_Load(object sender, EventArgs e)
        {
            etiquetaCambiaNombreEmpleado.Text = nombreLocal;
            if (nombreLocal == "") 
            {
                etiquetaCambiaNombreEmpleado.Text = "Prueba Prueba";

            }
            etiquetaCambiaCedula.Text = cedulaLocal;
            if (cedulaLocal == "")
            {
                etiquetaCambiaCedula.Text = "0-0000-0000";
            }

            etiquetaCambiaSalarioNeto.Text = valorSalarioNetoLocal.ToString();
            etiquetaCambiaSeguroEducativo.Text = valorSeguroSocialLocal.ToString();
            etiquetaCambiaSeguroSocial.Text = valorSeguroEducativoLocal.ToString();
        }


        private void botonNetoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra el programa

        }



        private void botonNetoRegresar_Click(object sender, EventArgs e)
        {
            VentanaEntrada ventana1Neto = new VentanaEntrada();
            ventana1Neto.Show();
            this.Hide();
        }

        private void etiquetaCambiaSeguroSocial_Click(object sender, EventArgs e)
        {

        }
    }
}
