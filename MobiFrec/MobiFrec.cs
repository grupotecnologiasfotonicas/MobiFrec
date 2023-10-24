using Serie;
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace MobiFrec
{
    public partial class MobiFrec : Form
    {
        PuertoSerie miPuerto;
        PuertoSerie miPuertoArduino;
        
        public MobiFrec()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            miPuerto = new PuertoSerie(comboBoxPuertos.Text, "\r\n", false);
            string cadena = textBoxComando.Text;
            byte[] mensaje = new byte[cadena.Length/2];
            for (int i = 0; i < mensaje.Length; i++)
            {
                mensaje[i] = byte.Parse(cadena.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
            }
            textBoxRespuesta.Text = (miPuerto.Enviar(mensaje, 6)).ToString();
        }


        public void PanelControl(string cadena)
        {
            miPuerto = new PuertoSerie(comboBoxPuertos.Text, "\r\n", false);
            textBoxComando.Text = cadena;//para sacar por pantalla lo que se ha enviado
            byte[] mensaje = new byte[cadena.Length / 2];
            for (int i = 0; i < mensaje.Length; i++)
            {
                mensaje[i] = byte.Parse(cadena.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
            }
           
            textBoxRespuesta.Text = (miPuerto.Enviar(mensaje, 6)).ToString();
            if (cadena == "7E017B076207447E")  textBoxRespuesta.Text = "Parámetros iniciales enviados"; 

        }

        private void buttonEnviarArduino_Click(object sender, EventArgs e)
        {
            miPuertoArduino = new PuertoSerie(comboBoxPuertosArduino.Text, "\r\n", false);//puerto d arduino
            string cadena = textBoxComandoArduino.Text;// mensaje enviado
            textBoxRespuestaArduino.Text = (miPuertoArduino.Enviar(cadena));//mensaje recibido
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
   
        public void hacerLinea(int x,int y)
        {
            miPuertoArduino = new PuertoSerie(comboBoxPuertosArduino.Text, "\r\n", false);//puerto d arduino
            string cadena = "P_" + x.ToString()+"_" + y.ToString();//mensaje enviado al arduino
            textBoxComandoArduino.Text = cadena;
            textBoxRespuestaArduino.Text = (miPuertoArduino.Enviar(cadena));//primera respuesta-> nos manda el ok, ->esto es que ha recibido el mensaje el arduino
            textBoxRespuestaArduino.Text = miPuertoArduino.LeeEsperando();// enviamos dos comandos porque el itmepo de espera de la recepcion de la respuesta es grande, ya que no responde hasta que no ha acabado de realizar la línea-> ya ha acabado el arduino
        }

        public void irAUnPunto(int x, int y)
        {
            miPuertoArduino = new PuertoSerie(comboBoxPuertosArduino.Text, "\r\n", false);//puerto d arduino
            string cadena = "F_" + x.ToString() + "_" + y.ToString();//mensaje enviado al arduino
            textBoxComandoArduino.Text = cadena;
            textBoxRespuestaArduino.Text = (miPuertoArduino.Enviar(cadena));
        }

        public void circulo(int radio)  //FUNCION QUE PIDE EL RADIO PARA PINTAR LA CIRCUNFERENCIA
        {
            //mandar el radio al arduino
            miPuertoArduino = new PuertoSerie(comboBoxPuertosArduino.Text, "\r\n", false);//puerto d arduino
            string cadena = "C_" + radio.ToString();//mensaje enviado al arduino
            textBoxComandoArduino.Text = cadena;
            textBoxRespuestaArduino.Text = (miPuertoArduino.Enviar(cadena));

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombre=BuscarPuerto(textBoxBuscar.Text);
            comboBoxPuertos.Text = nombre;
        }

        private void buttonBuscarArduino_Click(object sender, EventArgs e)
        {
            string nombre = BuscarPuerto(textBoxBuscarArduino.Text);
            comboBoxPuertosArduino.Text = nombre;
        }

 
    }
}
