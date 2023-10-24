namespace MobiFrec
{
    partial class Principal
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
            this.buttonHacerLinea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCirculo = new System.Windows.Forms.Button();
            this.textBoxCoordenadaXLinea = new System.Windows.Forms.TextBox();
            this.textBoxCoordenadaYLinea = new System.Windows.Forms.TextBox();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCoordenadaXPunto = new System.Windows.Forms.TextBox();
            this.textBoxCoordenadaYPunto = new System.Windows.Forms.TextBox();
            this.buttonIrAUnPunto = new System.Windows.Forms.Button();
            this.checkBoxShutter = new System.Windows.Forms.CheckBox();
            this.checkBoxCooler = new System.Windows.Forms.CheckBox();
            this.checkBoxLaser = new System.Windows.Forms.CheckBox();
            this.checkBoxStop = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxReset = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHacerLinea
            // 
            this.buttonHacerLinea.Location = new System.Drawing.Point(397, 86);
            this.buttonHacerLinea.Name = "buttonHacerLinea";
            this.buttonHacerLinea.Size = new System.Drawing.Size(108, 35);
            this.buttonHacerLinea.TabIndex = 0;
            this.buttonHacerLinea.Text = "Hacer línea";
            this.buttonHacerLinea.UseVisualStyleBackColor = true;
            this.buttonHacerLinea.Click += new System.EventHandler(this.buttonHacerLinea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coordenadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Radio:";
            // 
            // buttonCirculo
            // 
            this.buttonCirculo.Location = new System.Drawing.Point(397, 196);
            this.buttonCirculo.Name = "buttonCirculo";
            this.buttonCirculo.Size = new System.Drawing.Size(108, 36);
            this.buttonCirculo.TabIndex = 5;
            this.buttonCirculo.Text = "Círculo";
            this.buttonCirculo.UseVisualStyleBackColor = true;
            this.buttonCirculo.Click += new System.EventHandler(this.buttonCirculo_Click);
            // 
            // textBoxCoordenadaXLinea
            // 
            this.textBoxCoordenadaXLinea.Location = new System.Drawing.Point(270, 94);
            this.textBoxCoordenadaXLinea.Name = "textBoxCoordenadaXLinea";
            this.textBoxCoordenadaXLinea.Size = new System.Drawing.Size(31, 20);
            this.textBoxCoordenadaXLinea.TabIndex = 6;
            this.textBoxCoordenadaXLinea.Text = "0";
            // 
            // textBoxCoordenadaYLinea
            // 
            this.textBoxCoordenadaYLinea.Location = new System.Drawing.Point(345, 94);
            this.textBoxCoordenadaYLinea.Name = "textBoxCoordenadaYLinea";
            this.textBoxCoordenadaYLinea.Size = new System.Drawing.Size(31, 20);
            this.textBoxCoordenadaYLinea.TabIndex = 7;
            this.textBoxCoordenadaYLinea.Text = "0";
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(345, 203);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(31, 20);
            this.textBoxRadio.TabIndex = 8;
            this.textBoxRadio.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeControlToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // panelDeControlToolStripMenuItem
            // 
            this.panelDeControlToolStripMenuItem.Name = "panelDeControlToolStripMenuItem";
            this.panelDeControlToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.panelDeControlToolStripMenuItem.Text = "Panel de control...";
            this.panelDeControlToolStripMenuItem.Click += new System.EventHandler(this.panelDeControlToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Y:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "X:";
            // 
            // textBoxCoordenadaXPunto
            // 
            this.textBoxCoordenadaXPunto.Location = new System.Drawing.Point(270, 149);
            this.textBoxCoordenadaXPunto.Name = "textBoxCoordenadaXPunto";
            this.textBoxCoordenadaXPunto.Size = new System.Drawing.Size(31, 20);
            this.textBoxCoordenadaXPunto.TabIndex = 40;
            this.textBoxCoordenadaXPunto.Text = "0";
            // 
            // textBoxCoordenadaYPunto
            // 
            this.textBoxCoordenadaYPunto.Location = new System.Drawing.Point(345, 149);
            this.textBoxCoordenadaYPunto.Name = "textBoxCoordenadaYPunto";
            this.textBoxCoordenadaYPunto.Size = new System.Drawing.Size(31, 20);
            this.textBoxCoordenadaYPunto.TabIndex = 41;
            this.textBoxCoordenadaYPunto.Text = "0";
            // 
            // buttonIrAUnPunto
            // 
            this.buttonIrAUnPunto.Location = new System.Drawing.Point(397, 140);
            this.buttonIrAUnPunto.Name = "buttonIrAUnPunto";
            this.buttonIrAUnPunto.Size = new System.Drawing.Size(108, 35);
            this.buttonIrAUnPunto.TabIndex = 42;
            this.buttonIrAUnPunto.Text = "Ir a un punto";
            this.buttonIrAUnPunto.UseVisualStyleBackColor = true;
            this.buttonIrAUnPunto.Click += new System.EventHandler(this.buttonIrAUnPunto_Click);
            // 
            // checkBoxShutter
            // 
            this.checkBoxShutter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShutter.AutoSize = true;
            this.checkBoxShutter.Location = new System.Drawing.Point(48, 183);
            this.checkBoxShutter.Name = "checkBoxShutter";
            this.checkBoxShutter.Size = new System.Drawing.Size(51, 23);
            this.checkBoxShutter.TabIndex = 51;
            this.checkBoxShutter.Text = "Shutter";
            this.checkBoxShutter.UseVisualStyleBackColor = true;
            this.checkBoxShutter.CheckedChanged += new System.EventHandler(this.checkBoxShutter_CheckedChanged);
            // 
            // checkBoxCooler
            // 
            this.checkBoxCooler.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCooler.AutoSize = true;
            this.checkBoxCooler.Location = new System.Drawing.Point(48, 101);
            this.checkBoxCooler.Name = "checkBoxCooler";
            this.checkBoxCooler.Size = new System.Drawing.Size(47, 23);
            this.checkBoxCooler.TabIndex = 52;
            this.checkBoxCooler.Text = "Cooler";
            this.checkBoxCooler.UseVisualStyleBackColor = true;
            this.checkBoxCooler.CheckedChanged += new System.EventHandler(this.cheskBoxCooler_CheckedChanged);
            // 
            // checkBoxLaser
            // 
            this.checkBoxLaser.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLaser.AutoSize = true;
            this.checkBoxLaser.Location = new System.Drawing.Point(48, 130);
            this.checkBoxLaser.Name = "checkBoxLaser";
            this.checkBoxLaser.Size = new System.Drawing.Size(43, 23);
            this.checkBoxLaser.TabIndex = 53;
            this.checkBoxLaser.Text = "Láser";
            this.checkBoxLaser.UseVisualStyleBackColor = true;
            this.checkBoxLaser.CheckedChanged += new System.EventHandler(this.checkBoxLaser_CheckedChanged);
            // 
            // checkBoxStop
            // 
            this.checkBoxStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxStop.AutoSize = true;
            this.checkBoxStop.Location = new System.Drawing.Point(143, 114);
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.Size = new System.Drawing.Size(39, 23);
            this.checkBoxStop.TabIndex = 54;
            this.checkBoxStop.Text = "Stop";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Panel de control";
            // 
            // checkBoxReset
            // 
            this.checkBoxReset.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxReset.AutoSize = true;
            this.checkBoxReset.Location = new System.Drawing.Point(48, 267);
            this.checkBoxReset.Name = "checkBoxReset";
            this.checkBoxReset.Size = new System.Drawing.Size(53, 23);
            this.checkBoxReset.TabIndex = 61;
            this.checkBoxReset.Text = "RESET";
            this.checkBoxReset.UseVisualStyleBackColor = true;
            this.checkBoxReset.CheckedChanged += new System.EventHandler(this.checkBoxReset_CheckedChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 324);
            this.Controls.Add(this.checkBoxReset);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBoxStop);
            this.Controls.Add(this.checkBoxLaser);
            this.Controls.Add(this.checkBoxCooler);
            this.Controls.Add(this.checkBoxShutter);
            this.Controls.Add(this.buttonIrAUnPunto);
            this.Controls.Add(this.textBoxCoordenadaYPunto);
            this.Controls.Add(this.textBoxCoordenadaXPunto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxRadio);
            this.Controls.Add(this.textBoxCoordenadaYLinea);
            this.Controls.Add(this.textBoxCoordenadaXLinea);
            this.Controls.Add(this.buttonCirculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHacerLinea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHacerLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCirculo;
        private System.Windows.Forms.TextBox textBoxCoordenadaXLinea;
        private System.Windows.Forms.TextBox textBoxCoordenadaYLinea;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCoordenadaXPunto;
        private System.Windows.Forms.TextBox textBoxCoordenadaYPunto;
        private System.Windows.Forms.Button buttonIrAUnPunto;
        private System.Windows.Forms.CheckBox checkBoxShutter;
        private System.Windows.Forms.CheckBox checkBoxCooler;
        private System.Windows.Forms.CheckBox checkBoxLaser;
        private System.Windows.Forms.CheckBox checkBoxStop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxReset;
    }
}