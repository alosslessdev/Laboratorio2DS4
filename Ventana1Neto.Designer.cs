using System.Windows.Forms;

//Francisco Herrera 8-1005-1990

namespace Grupal_Lab2
{
    partial class VentanaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEntrada));
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.etiquetaFijoNombreEmpleado = new System.Windows.Forms.Label();
            this.etiquetaFijoCédula = new System.Windows.Forms.Label();
            this.etiquetaFijoSalarioNeto = new System.Windows.Forms.Label();
            this.botonEntradaNeto = new System.Windows.Forms.Button();
            this.botonEntradaCerrar = new System.Windows.Forms.Button();
            this.etiquetaFijoBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(297, 80);
            this.txtNombreEmpleado.MaxLength = 64;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(184, 22);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Location = new System.Drawing.Point(297, 134);
            this.txtCedula.MaxLength = 14;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(184, 22);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(297, 190);
            this.txtSalarioBruto.MaxLength = 7;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(184, 22);
            this.txtSalarioBruto.TabIndex = 2;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            // 
            // etiquetaFijoNombreEmpleado
            // 
            this.etiquetaFijoNombreEmpleado.AutoSize = true;
            this.etiquetaFijoNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaFijoNombreEmpleado.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaFijoNombreEmpleado.Location = new System.Drawing.Point(113, 80);
            this.etiquetaFijoNombreEmpleado.Name = "etiquetaFijoNombreEmpleado";
            this.etiquetaFijoNombreEmpleado.Size = new System.Drawing.Size(200, 28);
            this.etiquetaFijoNombreEmpleado.TabIndex = 3;
            this.etiquetaFijoNombreEmpleado.Text = "Nombre del Empleado:";
            // 
            // etiquetaFijoCédula
            // 
            this.etiquetaFijoCédula.AutoSize = true;
            this.etiquetaFijoCédula.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaFijoCédula.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaFijoCédula.Location = new System.Drawing.Point(223, 132);
            this.etiquetaFijoCédula.Name = "etiquetaFijoCédula";
            this.etiquetaFijoCédula.Size = new System.Drawing.Size(75, 28);
            this.etiquetaFijoCédula.TabIndex = 4;
            this.etiquetaFijoCédula.Text = "Cédula:";
            // 
            // etiquetaFijoSalarioNeto
            // 
            this.etiquetaFijoSalarioNeto.AutoSize = true;
            this.etiquetaFijoSalarioNeto.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaFijoSalarioNeto.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaFijoSalarioNeto.Location = new System.Drawing.Point(113, 190);
            this.etiquetaFijoSalarioNeto.Name = "etiquetaFijoSalarioNeto";
            this.etiquetaFijoSalarioNeto.Size = new System.Drawing.Size(193, 28);
            this.etiquetaFijoSalarioNeto.TabIndex = 5;
            this.etiquetaFijoSalarioNeto.Text = "Salario bruto mensual:";
            // 
            // botonEntradaNeto
            // 
            this.botonEntradaNeto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonEntradaNeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntradaNeto.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEntradaNeto.Location = new System.Drawing.Point(434, 281);
            this.botonEntradaNeto.Name = "botonEntradaNeto";
            this.botonEntradaNeto.Size = new System.Drawing.Size(147, 35);
            this.botonEntradaNeto.TabIndex = 6;
            this.botonEntradaNeto.Text = "Ver salario neto";
            this.botonEntradaNeto.UseVisualStyleBackColor = true;
            this.botonEntradaNeto.Click += new System.EventHandler(this.botonEntradaNeto_Click);
            // 
            // botonEntradaCerrar
            // 
            this.botonEntradaCerrar.BackColor = System.Drawing.Color.Red;
            this.botonEntradaCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.botonEntradaCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntradaCerrar.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEntradaCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonEntradaCerrar.Location = new System.Drawing.Point(35, 281);
            this.botonEntradaCerrar.Name = "botonEntradaCerrar";
            this.botonEntradaCerrar.Size = new System.Drawing.Size(111, 35);
            this.botonEntradaCerrar.TabIndex = 7;
            this.botonEntradaCerrar.Text = "Cerrar";
            this.botonEntradaCerrar.UseVisualStyleBackColor = false;
            this.botonEntradaCerrar.Click += new System.EventHandler(this.botonEntradaCerrar_Click);
            // 
            // etiquetaFijoBienvenida
            // 
            this.etiquetaFijoBienvenida.AutoSize = true;
            this.etiquetaFijoBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.etiquetaFijoBienvenida.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaFijoBienvenida.Location = new System.Drawing.Point(242, 34);
            this.etiquetaFijoBienvenida.Name = "etiquetaFijoBienvenida";
            this.etiquetaFijoBienvenida.Size = new System.Drawing.Size(109, 22);
            this.etiquetaFijoBienvenida.TabIndex = 8;
            this.etiquetaFijoBienvenida.Text = "Ver salario neto";
            // 
            // VentanaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 343);
            this.Controls.Add(this.etiquetaFijoBienvenida);
            this.Controls.Add(this.botonEntradaCerrar);
            this.Controls.Add(this.botonEntradaNeto);
            this.Controls.Add(this.etiquetaFijoSalarioNeto);
            this.Controls.Add(this.etiquetaFijoCédula);
            this.Controls.Add(this.etiquetaFijoNombreEmpleado);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "VentanaEntrada";
            this.Text = "Ver Salario Neto";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label etiquetaFijoNombreEmpleado;
        private System.Windows.Forms.Label etiquetaFijoCédula;
        private System.Windows.Forms.Label etiquetaFijoSalarioNeto;
        private System.Windows.Forms.Button botonEntradaNeto;
        private System.Windows.Forms.Button botonEntradaCerrar;
        private Label etiquetaFijoBienvenida;
    }
}

