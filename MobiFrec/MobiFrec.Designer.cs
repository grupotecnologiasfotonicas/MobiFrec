namespace PruebaPuertoSerie
{
    partial class MobiFrec
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxComando = new System.Windows.Forms.TextBox();
            this.comboBoxPuertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Respuesta:";
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(82, 102);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(61, 20);
            this.textBoxRespuesta.TabIndex = 43;
            this.textBoxRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(158, 62);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(58, 36);
            this.buttonEnviar.TabIndex = 42;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Comando:";
            // 
            // textBoxComando
            // 
            this.textBoxComando.Location = new System.Drawing.Point(78, 71);
            this.textBoxComando.Name = "textBoxComando";
            this.textBoxComando.Size = new System.Drawing.Size(61, 20);
            this.textBoxComando.TabIndex = 40;
            this.textBoxComando.Text = "7E0164BD337E";
            this.textBoxComando.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxPuertos
            // 
            this.comboBoxPuertos.FormattingEnabled = true;
            this.comboBoxPuertos.Location = new System.Drawing.Point(62, 25);
            this.comboBoxPuertos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPuertos.Name = "comboBoxPuertos";
            this.comboBoxPuertos.Size = new System.Drawing.Size(61, 21);
            this.comboBoxPuertos.TabIndex = 45;
            this.comboBoxPuertos.Text = "COM11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Puerto:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(136, 24);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(58, 21);
            this.buttonBuscar.TabIndex = 47;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(200, 25);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(30, 20);
            this.textBoxBuscar.TabIndex = 48;
            this.textBoxBuscar.Text = "0";
            this.textBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MobiFrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 195);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPuertos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxComando);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MobiFrec";
            this.Text = "Prueba de puerto serie";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRespuesta;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxComando;
        private System.Windows.Forms.ComboBox comboBoxPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
    }
}

