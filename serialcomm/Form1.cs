﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using serialcomm.Properties;
using System.Globalization;
using System.Threading;

namespace serialcomm
{
    public partial class Form1 : Form
    {
        public String DataReceived;
        public Form1()
        {
            InitializeComponent();
            tbSliderValue.Text = slSlider1.Value.ToString();
            List<string> portList = new List<string>(SerialPort.GetPortNames());
            if (portList.Count!= 0)
            {
                foreach (var VARIABLE in portList)
                {
                    cbChosenSerial.Items.Add(VARIABLE);
                }
                cbChosenSerial.SelectedIndex = 0;
                serialPort1.PortName = cbChosenSerial.Text; // nazwa portu gdzie jest Arduino podłączone
                serialPort1.BaudRate = int.Parse(cbBaudrate.Text);
                StringBuilder sb=new StringBuilder();
                lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Closed"; // wyświetlenie informacji o otwarciu portu w polu 'stan'
            }
            else
            {
                cbChosenSerial.Text = aStrings.brak_portow; // nazwa portu gdzie jest Arduino podłączone
                lbStatusPortu.Text = aStrings.brak_portow;
            }
        }

        private void cbChosenSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cbChosenSerial.Text; // nazwa portu gdzie jest Arduino podłączone
            
        }

        private void cbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(cbBaudrate.Text);
        }

        private void btnOpenClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) // Jeżeli port nie jest otwarty, otwieramy go
                {
                    serialPort1.Open(); // otwarcie portu
                    StringBuilder sb = new StringBuilder();
                    lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Opened.";
                    // wyświetlenie informacji o otwarciu portu w polu 'stan'
                    MessageBox.Show("sprawdz czy baudrate nadajnika i odbiornika sa takie same");
                    btnOpenClosePort.Text = aStrings.Close_port;
                }
                else // Jeżeli port  jest otwarty, zamykamy go
                {
                    this.BeginInvoke(new EventHandler(ClosePort)); // wywołanie metody
                    StringBuilder sb = new StringBuilder();
                    lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Closed.";
                        // wyświetlenie informacji o otwarciu portu w polu 'stan'
                    btnOpenClosePort.Text = aStrings.Openport;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Wybrany port jest zajety");
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) // Instrukcje jakie mają się wykonac w momencie odebrania danych z portu szeregowego.
        {
            try
            {
                    DataReceived = serialPort1.ReadLine(); // odczyt linii 
                if (DataReceived == "512")
                {
                    MessageBox.Show("juhu");
                }
                    this.BeginInvoke(new EventHandler(DisplayDataReceived)); // wywołanie metody
            }
            catch (Exception ex)
            {
                Report(ex);
            }
                
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            tbDataReceived.Text = DataReceived; // wstawienie wartości do pola tekstowego
        }

        private void DisplayDataReceived(object sender, EventArgs e)
        {
            tbDataContinuoslyReceived.Text = DataReceived; // wstawienie wartości do pola tekstowego
        }

        private void ClosePort(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
        void Report(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n\n" + ex.GetType()+"\n\n" + ex.StackTrace);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // instrukcje jakie mają się wykonac w przypadku wyłączenia okna programu
        {
            serialPort1.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                String sendingData = tbSendingData.Text;
                serialPort1.Write(sendingData);
                MessageBox.Show("wyslano: " + sendingData);
                //serialPort1.ReadLine();
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbSliderValue.Text = slSlider1.Value.ToString();
        }

        private void tbSliderValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                slSlider1.Value = int.Parse(tbSliderValue.Text);
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }


        private void btnSendSliderValue_Click(object sender, EventArgs e)
        {
            try
            {
                String sendingData = tbSliderValue.Text;
                serialPort1.Write(sendingData);
                MessageBox.Show("wyslano: " + sendingData);
                serialPort1.ReadLine();
            }
            catch (Exception ex)
            {
                    Report(ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbDataReceived_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //        CultureInfo ci = new CultureInfo("pl-PL");
        //        Thread.CurrentThread.CurrentUICulture = ci;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    CultureInfo ci = new CultureInfo("en-US");
        //    Thread.CurrentThread.CurrentUICulture = ci;
        //}

    }
}
