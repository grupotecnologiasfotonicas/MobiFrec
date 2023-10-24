using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiFrec
{
    public partial class Principal : Form 
    {
        MobiFrec miMobiFrec;
        public Principal()
        {
            InitializeComponent();
            miMobiFrec = new MobiFrec();
        }


        private void panelDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miMobiFrec.Show();
            //enviamos comandos al arrancar la ventana
            miMobiFrec.PanelControl("7E017D5D066622CD7E");//frecuencia 40kHz (3.6.15)
            miMobiFrec.PanelControl("7E017191747E");//select internal Q (3.6.8)
            miMobiFrec.PanelControl("7E017B076207447E");// corriente 30A (3.6.16)
        }

        private void buttonHacerLinea_Click(object sender, EventArgs e)
        {
            miMobiFrec.hacerLinea(Convert.ToInt32(textBoxCoordenadaXLinea.Text), Convert.ToInt32(textBoxCoordenadaYLinea.Text));
        }

        private void buttonIrAUnPunto_Click(object sender, EventArgs e)
        {
            miMobiFrec.irAUnPunto(Convert.ToInt32(textBoxCoordenadaXPunto.Text), Convert.ToInt32(textBoxCoordenadaYPunto.Text));
        }

        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            miMobiFrec.circulo(Convert.ToInt32(textBoxRadio.Text));
        }

        private void cheskBoxCooler_CheckedChanged(object sender, EventArgs e)//pump on
        {
            if (checkBoxCooler.Checked) { 
              miMobiFrec.PanelControl("7E0164BD337E");
            }
        }

        private void checkBoxLaser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLaser.Checked)
            {
                miMobiFrec.PanelControl("7E016534227E");//Láser ON
            }
            else
            {
                miMobiFrec.PanelControl("7E016634227E");//Láser OFF
            }
            
        }

        private void checkBoxShutter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShutter.Checked)
            {
                miMobiFrec.PanelControl("7E016726017E");//Shutter ON
            }
            else
            {
                miMobiFrec.PanelControl("7E0168D1F97E");//Shutter OFF
            }
        }

        private void checkBoxReset_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReset.Checked)
            {
                miMobiFrec.PanelControl("7E016110647E");
            }
        }
    }

}
