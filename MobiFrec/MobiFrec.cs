using System;
using System.IO.Ports;
using Serie;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace PruebaPuertoSerie
{
    public partial class MobiFrec : Form
    {
        PuertoSerie miPuerto;
        public MobiFrec()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            miPuerto = new PuertoSerie(comboBoxPuertos.Text, "\r\n", false);
            
            //mensaje[0] = 1;
            string cadena = textBoxComando.Text;
            byte[] mensaje = new byte[cadena.Length/2];
            for (int i = 0; i < mensaje.Length; i++)
            {
                mensaje[i] = byte.Parse(cadena.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
            }
            textBoxRespuesta.Text = (miPuerto.Enviar(mensaje, 5)).ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            comboBoxPuertos.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPuertos.SelectedIndex = 0;
        }

        public static string BuscarPuerto(string numeroSerie)
        {
            string[] listaPuertos = SerialPort.GetPortNames();
            SerialPort miPuerto;
            string resp;
            bool error = false;
            string puertoBueno = "VIRTUAL";

            foreach (string nombrePuerto in listaPuertos)
            {
                error = false;
                miPuerto = new SerialPort(nombrePuerto);
                miPuerto.ReadTimeout = 50;
                miPuerto.WriteTimeout = 50;
                miPuerto.BaudRate = 9600;
                miPuerto.NewLine = "\r\n";
                try
                {
                    miPuerto.Open();
                    Thread.Sleep(500);
                    resp = miPuerto.ReadExisting();//para quitar posibles restos
                    miPuerto.WriteLine("S");//devuelve el número de serie, hay que programarlo en el Arduino. Se puede hacer hardware si se sueldan entradas digitales
                    resp = miPuerto.ReadLine();
                    if (resp != numeroSerie)
                        error = true;
                    miPuerto.Close();
                }
                catch
                {
                    error = true;
                    miPuerto.Close();
                }
                if (!error)
                {
                    puertoBueno = nombrePuerto;
                    break;
                }
            }
            return puertoBueno;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombre=BuscarPuerto(textBoxBuscar.Text);
            comboBoxPuertos.Text = nombre;
        }
    }
}
