using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Serie
{
    public class PuertoSerie
    {
        private SerialPort serialPort;
        public bool ocupado = false;
        public bool simulado = false;
        public string NumeroPuerto
        {
            get
            {
                return serialPort.PortName;
            }
        }
        public PuertoSerie(string numero, string finalLinea, bool handshake)
        {
            if (numero == "VIRTUAL")
            {
                simulado = true;
                return;
            }
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.ReadBufferSize = 100;
            serialPort.ReadTimeout = 3000;//Tiempo en milisegundos para que el puerto de una excepción de timeout.
            serialPort.PortName = numero;
            serialPort.StopBits = StopBits.One;
            serialPort.WriteBufferSize = 100;
            serialPort.WriteTimeout = 500;
            if (handshake)
                serialPort.Handshake = Handshake.RequestToSend;
            else
                serialPort.Handshake = Handshake.None;
            serialPort.DataBits = 8;
            serialPort.NewLine = finalLinea;
            //serialPort.DtrEnable=true;
            //serialPort.DtrEnable = false;
        }

        public string Enviar(string instruccion)
        {
            DialogResult respuesta;
            if (simulado)
                return "%0000100";

            while (ocupado)
                Application.DoEvents();
            ocupado = true;
            try
            {
                serialPort.Open();
                serialPort.WriteLine(instruccion);
                string resp = serialPort.ReadLine();
                serialPort.Close();
                ocupado = false;
                return resp;
            }
            catch (Exception ex)
            {
                respuesta = MessageBox.Show(ex.Message, "Error en el puerto " + serialPort.PortName, MessageBoxButtons.AbortRetryIgnore);
                if (respuesta == DialogResult.Retry)
                {              
                    serialPort.Close();
                    ocupado = false;
                    return Enviar(instruccion);
                }
                if (respuesta == DialogResult.Abort)
                    simulado = true;
            }
            ocupado = false;
            return "%0000100";
        }

        public int Enviar(byte[] instruccion, int nBytesRespuesta) //para el monocromador
        { 
            DialogResult respuesta;
            bool espera = false;
            if (nBytesRespuesta == 0)
                espera = true;
            byte[] respB = new byte[nBytesRespuesta];
            int resp=0;
            byte[] statusB = new byte[10];
            byte[] cancelB = new byte[10];

            if (simulado)
            {
                return 1;
            }

            while (ocupado)
                Application.DoEvents();
            ocupado = true;
            try
            {
                serialPort.Open();
                serialPort.Write(instruccion, 0, instruccion.Length);

                for (int i = 0; i < nBytesRespuesta; i++)
                    serialPort.Read(respB, i, 1);//hay que leer de uno en uno porque si no se lía
                //serialPort.Read(statusB, 0, 1);
                if (statusB[0] > 127)
                    MessageBox.Show("Comando no aceptado");
                cancelB[0] = 0;
                Cursor cursorAnterior = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                if (espera)
                {
                    while (serialPort.BytesToRead == 0)
                        Application.DoEvents();
                }
                //serialPort.Read(cancelB, 0, 1);
    
                Cursor.Current = cursorAnterior;
                //if (cancelB[0] != 24)
                //    MessageBox.Show("Acción no realizada");
            }

            catch (Exception ex)
            {
                serialPort.Close();
                respuesta = MessageBox.Show(ex.Message, "Error en el puerto " + serialPort.PortName, MessageBoxButtons.AbortRetryIgnore);
                if (respuesta == DialogResult.Retry)
                {
                    ocupado = false;
                    resp = Enviar(instruccion, nBytesRespuesta);
                }
                if (respuesta == DialogResult.Abort)
                    simulado = true;
            }
            serialPort.Close();
            ocupado = false;
            if (nBytesRespuesta == 1)
                resp = respB[0];
            if (nBytesRespuesta == 2)
                resp = 256*respB[0]+respB[1];
            return resp;
        }

        public string LeeEsperando()
        {
            if (simulado)
                return "%0000100";

            while (ocupado)
                Application.DoEvents();

            ocupado = true;
            try
            {
                serialPort.Open();
                DateTime inicio = DateTime.Now;
                while((serialPort.BytesToRead == 0)&&((DateTime.Now-inicio).TotalSeconds<10))
                    Application.DoEvents();
                string resp = serialPort.ReadLine();
                serialPort.Close();
                ocupado = false;
                return resp;
            }
            catch
            {
                //string resp = serialPort.ReadLine();
                //MessageBox.Show(ex.Message, "Error en el puerto " + serialPort.PortName);
                serialPort.Close();
                ocupado = false;
                return "%0000100";
            }
        }
        public void Reinicia()
        {
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
        }
    }
}
