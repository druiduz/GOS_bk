using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        bool ledState = false;

        public Form1()
        {
            InitializeComponent();
           
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;        
            serialPort1.Open();            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {            
            serialPort1.Write("1");
            textBox1.Text = "LED is on!";
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
            ledState = true;          
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            textBox1.Text = "LED is off!";
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            ledState = false;
        }

        private void send_mail(string address)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(address);
            message.Subject = "Hi there.";
            message.From = new System.Net.Mail.MailAddress("you@example.com");

            if (ledState == true)
            {
                message.Body = "The LED is on";
            }

            if (ledState == false)
            {
                message.Body = "The LED is off";
            }
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.ukgateway.net");
            smtp.Send(message);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            send_mail(textBox_mail.Text);
        }  
    }
}
