//Francisco Herrera 8-1005-1990

namespace FranciscoHerrera_Lab1
{
    partial class VentanaNeto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaNeto));
            this.botonNetoCerrar = new System.Windows.Forms.Button();
            this.botonNetoRegresar = new System.Windows.Forms.Button();
            this.etiquetaResultadoFijoSalarioNeto = new System.Windows.Forms.Label();
            this.etiquetaResultadoFijoSeguroEducativo = new System.Windows.Forms.Label();
            this.etiquetaResultadoFijoSeguroSocial = new System.Windows.Forms.Label();
            this.etiquetaCambiaSalarioNeto = new System.Windows.Forms.Label();
            this.etiquetaCambiaSeguroEducativo = new System.Windows.Forms.Label();
            this.etiquetaCambiaSeguroSocial = new System.Windows.Forms.Label();
            this.etiquetaResultadoFijoISR = new System.Windows.Forms.Label();
            this.etiquetaCambiaISR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonNetoCerrar
            // 
            this.botonNetoCerrar.BackColor = System.Drawing.Color.Red;
            this.botonNetoCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.botonNetoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNetoCerrar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNetoCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonNetoCerrar.Location = new System.Drawing.Point(36, 186);
            this.botonNetoCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonNetoCerrar.Name = "botonNetoCerrar";
            this.botonNetoCerrar.Size = new System.Drawing.Size(83, 28);
            this.botonNetoCerrar.TabIndex = 11;
            this.botonNetoCerrar.Text = "Cerrar";
            this.botonNetoCerrar.UseVisualStyleBackColor = false;
            this.botonNetoCerrar.Click += new System.EventHandler(this.botonNetoCerrar_Click);
            // 
            // botonNetoRegresar
            // 
            this.botonNetoRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonNetoRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNetoRegresar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNetoRegresar.Location = new System.Drawing.Point(359, 186);
            this.botonNetoRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonNetoRegresar.Name = "botonNetoRegresar";
            this.botonNetoRegresar.Size = new System.Drawing.Size(83, 28);
            this.botonNetoRegresar.TabIndex = 10;
            this.botonNetoRegresar.Text = "Regresar";
            this.botonNetoRegresar.UseVisualStyleBackColor = true;
            this.botonNetoRegresar.Click += new System.EventHandler(this.botonNetoRegresar_Click);
            // 
            // etiquetaResultadoFijoSalarioNeto
            // 
            this.etiquetaResultadoFijoSalarioNeto.AutoSize = true;
            this.etiquetaResultadoFijoSalarioNeto.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaResultadoFijoSalarioNeto.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaResultadoFijoSalarioNeto.Location = new System.Drawing.Point(175, 50);
            this.etiquetaResultadoFijoSalarioNeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaResultadoFijoSalarioNeto.Name = "etiquetaResultadoFijoSalarioNeto";
            this.etiquetaResultadoFijoSalarioNeto.Size = new System.Drawing.Size(129, 20);
            this.etiquetaResultadoFijoSalarioNeto.TabIndex = 12;
            this.etiquetaResultadoFijoSalarioNeto.Text = "Salario mensual neto:";
            // 
            // etiquetaResultadoFijoSeguroEducativo
            // 
            this.etiquetaResultadoFijoSeguroEducativo.AutoSize = true;
            this.etiquetaResultadoFijoSeguroEducativo.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaResultadoFijoSeguroEducativo.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaResultadoFijoSeguroEducativo.Location = new System.Drawing.Point(80, 80);
            this.etiquetaResultadoFijoSeguroEducativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaResultadoFijoSeguroEducativo.Name = "etiquetaResultadoFijoSeguroEducativo";
            this.etiquetaResultadoFijoSeguroEducativo.Size = new System.Drawing.Size(224, 20);
            this.etiquetaResultadoFijoSeguroEducativo.TabIndex = 13;
            this.etiquetaResultadoFijoSeguroEducativo.Text = "Cantidad de pago de seguro educativo:";
            // 
            // etiquetaResultadoFijoSeguroSocial
            // 
            this.etiquetaResultadoFijoSeguroSocial.AutoSize = true;
            this.etiquetaResultadoFijoSeguroSocial.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaResultadoFijoSeguroSocial.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaResultadoFijoSeguroSocial.Location = new System.Drawing.Point(98, 111);
            this.etiquetaResultadoFijoSeguroSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaResultadoFijoSeguroSocial.Name = "etiquetaResultadoFijoSeguroSocial";
            this.etiquetaResultadoFijoSeguroSocial.Size = new System.Drawing.Size(204, 20);
            this.etiquetaResultadoFijoSeguroSocial.TabIndex = 14;
            this.etiquetaResultadoFijoSeguroSocial.Text = "Cantidad de pago de seguro social:";
            // 
            // etiquetaCambiaSalarioNeto
            // 
            this.etiquetaCambiaSalarioNeto.AutoSize = true;
            this.etiquetaCambiaSalarioNeto.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaCambiaSalarioNeto.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCambiaSalarioNeto.Location = new System.Drawing.Point(318, 50);
            this.etiquetaCambiaSalarioNeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaCambiaSalarioNeto.Name = "etiquetaCambiaSalarioNeto";
            this.etiquetaCambiaSalarioNeto.Size = new System.Drawing.Size(47, 20);
            this.etiquetaCambiaSalarioNeto.TabIndex = 17;
            this.etiquetaCambiaSalarioNeto.Text = "000.00";
            // 
            // etiquetaCambiaSeguroEducativo
            // 
            this.etiquetaCambiaSeguroEducativo.AutoSize = true;
            this.etiquetaCambiaSeguroEducativo.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaCambiaSeguroEducativo.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCambiaSeguroEducativo.Location = new System.Drawing.Point(318, 80);
            this.etiquetaCambiaSeguroEducativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaCambiaSeguroEducativo.Name = "etiquetaCambiaSeguroEducativo";
            this.etiquetaCambiaSeguroEducativo.Size = new System.Drawing.Size(47, 20);
            this.etiquetaCambiaSeguroEducativo.TabIndex = 18;
            this.etiquetaCambiaSeguroEducativo.Text = "000.00";
            // 
            // etiquetaCambiaSeguroSocial
            // 
            this.etiquetaCambiaSeguroSocial.AutoSize = true;
            this.etiquetaCambiaSeguroSocial.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaCambiaSeguroSocial.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCambiaSeguroSocial.Location = new System.Drawing.Point(318, 111);
            this.etiquetaCambiaSeguroSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaCambiaSeguroSocial.Name = "etiquetaCambiaSeguroSocial";
            this.etiquetaCambiaSeguroSocial.Size = new System.Drawing.Size(47, 20);
            this.etiquetaCambiaSeguroSocial.TabIndex = 19;
            this.etiquetaCambiaSeguroSocial.Text = "000.00";
            this.etiquetaCambiaSeguroSocial.Click += new System.EventHandler(this.etiquetaCambiaSeguroSocial_Click);
            // 
            // etiquetaResultadoFijoISR
            // 
            this.etiquetaResultadoFijoISR.AutoSize = true;
            this.etiquetaResultadoFijoISR.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaResultadoFijoISR.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaResultadoFijoISR.Location = new System.Drawing.Point(200, 151);
            this.etiquetaResultadoFijoISR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaResultadoFijoISR.Name = "etiquetaResultadoFijoISR";
            this.etiquetaResultadoFijoISR.Size = new System.Drawing.Size(102, 20);
            this.etiquetaResultadoFijoISR.TabIndex = 20;
            this.etiquetaResultadoFijoISR.Text = "Cantidad de ISR:";
            // 
            // etiquetaCambiaISR
            // 
            this.etiquetaCambiaISR.AutoSize = true;
            this.etiquetaCambiaISR.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaCambiaISR.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCambiaISR.Location = new System.Drawing.Point(318, 151);
            this.etiquetaCambiaISR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaCambiaISR.Name = "etiquetaCambiaISR";
            this.etiquetaCambiaISR.Size = new System.Drawing.Size(47, 20);
            this.etiquetaCambiaISR.TabIndex = 21;
            this.etiquetaCambiaISR.Text = "000.00";
            // 
            // VentanaNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(516, 359);
            this.Controls.Add(this.etiquetaCambiaISR);
            this.Controls.Add(this.etiquetaResultadoFijoISR);
            this.Controls.Add(this.etiquetaCambiaSeguroSocial);
            this.Controls.Add(this.etiquetaCambiaSeguroEducativo);
            this.Controls.Add(this.etiquetaCambiaSalarioNeto);
            this.Controls.Add(this.etiquetaResultadoFijoSeguroSocial);
            this.Controls.Add(this.etiquetaResultadoFijoSeguroEducativo);
            this.Controls.Add(this.etiquetaResultadoFijoSalarioNeto);
            this.Controls.Add(this.botonNetoCerrar);
            this.Controls.Add(this.botonNetoRegresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaNeto";
            this.Text = "Ver Salario Neto";
            this.Load += new System.EventHandler(this.Ventana2Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonNetoCerrar;
        private System.Windows.Forms.Button botonNetoRegresar;
        private System.Windows.Forms.Label etiquetaResultadoFijoSalarioNeto;
        private System.Windows.Forms.Label etiquetaResultadoFijoSeguroEducativo;
        private System.Windows.Forms.Label etiquetaResultadoFijoSeguroSocial;
        private System.Windows.Forms.Label etiquetaCambiaSalarioNeto;
        private System.Windows.Forms.Label etiquetaCambiaSeguroEducativo;
        private System.Windows.Forms.Label etiquetaCambiaSeguroSocial;
        private System.Windows.Forms.Label etiquetaResultadoFijoISR;
        private System.Windows.Forms.Label etiquetaCambiaISR;
    }
}