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
//Nathan Carrasco 8-1010-606 
//Roberto Mojica 3-755-2291 

namespace Grupal_Lab2
{
    public partial class VentanaNeto : Form
    {
        private decimal valorSalarioNetoLocal;
        private decimal valorSeguroSocialLocal;
        private decimal valorSeguroEducativoLocal;
        private string valorISRLocal;

        public VentanaNeto(decimal entradaSalarioNeto, 
            decimal entradaSeguroSocial, decimal entradaSeguroEducativo, string entradaISR)
        {
            InitializeComponent();
             valorSalarioNetoLocal = entradaSalarioNeto;
             valorSeguroSocialLocal = entradaSeguroSocial;
             valorSeguroEducativoLocal = entradaSeguroEducativo;
            valorISRLocal = entradaISR;

        }



        private void Ventana2Resultado_Load(object sender, EventArgs e)
        {
            etiquetaCambiaSalarioNeto.Text = valorSalarioNetoLocal.ToString();
            etiquetaCambiaSeguroEducativo.Text = valorSeguroSocialLocal.ToString();
            etiquetaCambiaSeguroSocial.Text = valorSeguroEducativoLocal.ToString();
            etiquetaCambiaISR.Text = valorISRLocal;
            
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
