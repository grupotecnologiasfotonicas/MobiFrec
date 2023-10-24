namespace MobiFrec
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPuertosArduino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComandoArduino = new System.Windows.Forms.TextBox();
            this.buttonEnviarArduino = new System.Windows.Forms.Button();
            this.buttonBuscarArduino = new System.Windows.Forms.Button();
            this.textBoxBuscarArduino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRespuestaArduino = new System.Windows.Forms.TextBox();
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
            this.textBoxRespuesta.Location = new System.Drawing.Point(83, 103);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(167, 20);
            this.textBoxRespuesta.TabIndex = 43;
            this.textBoxRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(256, 63);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(96, 36);
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
            this.textBoxComando.Location = new System.Drawing.Point(79, 72);
            this.textBoxComando.Name = "textBoxComando";
            this.textBoxComando.Size = new System.Drawing.Size(171, 20);
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
            this.comboBoxPuertos.Text = "COM1";
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
            this.buttonBuscar.Location = new System.Drawing.Point(256, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(60, 21);
            this.buttonBuscar.TabIndex = 47;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(322, 26);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(30, 20);
            this.textBoxBuscar.TabIndex = 48;
            this.textBoxBuscar.Text = "0";
            this.textBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Puerto Arduino:";
            // 
            // comboBoxPuertosArduino
            // 
            this.comboBoxPuertosArduino.FormattingEnabled = true;
            this.comboBoxPuertosArduino.Location = new System.Drawing.Point(105, 159);
            this.comboBoxPuertosArduino.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPuertosArduino.Name = "comboBoxPuertosArduino";
            this.comboBoxPuertosArduino.Size = new System.Drawing.Size(61, 21);
            this.comboBoxPuertosArduino.TabIndex = 50;
            this.comboBoxPuertosArduino.Text = "COM5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Comando Arduino:";
            // 
            // textBoxComandoArduino
            // 
            this.textBoxComandoArduino.Location = new System.Drawing.Point(126, 199);
            this.textBoxComandoArduino.Name = "textBoxComandoArduino";
            this.textBoxComandoArduino.Size = new System.Drawing.Size(77, 20);
            this.textBoxComandoArduino.TabIndex = 52;
            this.textBoxComandoArduino.Text = "S";
            this.textBoxComandoArduino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonEnviarArduino
            // 
            this.buttonEnviarArduino.Location = new System.Drawing.Point(211, 190);
            this.buttonEnviarArduino.Name = "buttonEnviarArduino";
            this.buttonEnviarArduino.Size = new System.Drawing.Size(96, 36);
            this.buttonEnviarArduino.TabIndex = 53;
            this.buttonEnviarArduino.Text = " Enviar Arduino";
            this.buttonEnviarArduino.UseVisualStyleBackColor = true;
            this.buttonEnviarArduino.Click += new System.EventHandler(this.buttonEnviarArduino_Click);
            // 
            // buttonBuscarArduino
            // 
            this.buttonBuscarArduino.Location = new System.Drawing.Point(211, 154);
            this.buttonBuscarArduino.Name = "buttonBuscarArduino";
            this.buttonBuscarArduino.Size = new System.Drawing.Size(58, 21);
            this.buttonBuscarArduino.TabIndex = 54;
            this.buttonBuscarArduino.Text = "Buscar";
            this.buttonBuscarArduino.UseVisualStyleBackColor = true;
            this.buttonBuscarArduino.Click += new System.EventHandler(this.buttonBuscarArduino_Click);
            // 
            // textBoxBuscarArduino
            // 
            this.textBoxBuscarArduino.Location = new System.Drawing.Point(277, 155);
            this.textBoxBuscarArduino.Name = "textBoxBuscarArduino";
            this.textBoxBuscarArduino.Size = new System.Drawing.Size(30, 20);
            this.textBoxBuscarArduino.TabIndex = 55;
            this.textBoxBuscarArduino.Text = "0";
            this.textBoxBuscarArduino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Respuesta Arduino:";
            // 
            // textBoxRespuestaArduino
            // 
            this.textBoxRespuestaArduino.Location = new System.Drawing.Point(126, 233);
            this.textBoxRespuestaArduino.Name = "textBoxRespuestaArduino";
            this.textBoxRespuestaArduino.Size = new System.Drawing.Size(77, 20);
            this.textBoxRespuestaArduino.TabIndex = 57;
            this.textBoxRespuestaArduino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MobiFrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 307);
            this.Controls.Add(this.textBoxRespuestaArduino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuscarArduino);
            this.Controls.Add(this.buttonBuscarArduino);
            this.Controls.Add(this.buttonEnviarArduino);
            this.Controls.Add(this.textBoxComandoArduino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPuertosArduino);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPuertosArduino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComandoArduino;
        private System.Windows.Forms.Button buttonEnviarArduino;
        private System.Windows.Forms.Button buttonBuscarArduino;
        private System.Windows.Forms.TextBox textBoxBuscarArduino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRespuestaArduino;
    }
}

