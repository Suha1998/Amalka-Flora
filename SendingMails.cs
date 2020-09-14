using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;

namespace AmalkaFlora
{
    public partial class SendingMails : Form
    {
        static SendingMails mail;
        public SendingMails()
        {
            InitializeComponent();
            mail = this;

        }

        private void SendingMails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get sender's email and receiver's email and pass them to 'message '
            var message = new MailMessage(textBox1.Text, textBox4.Text);
            message.Subject = textBox5.Text;
            message.Body = textBox2.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                try
                {
                    mailer.Credentials = new NetworkCredential(textBox1.Text, textBox3.Text);
                    mailer.EnableSsl = true;//to secure the connection
                    mailer.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            textBox4.Text = null;
            textBox5.Text = null;
            textBox2.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartReceiving();
        }

        private void StartReceiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, textBox1.Text,
                  textBox3.Text, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        MessageBox.Show("Server doesn't support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(onNewMessage);
                    while (true) ;

                }
            });

        }

        static void onNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New Message receieved");
            MailMessage mails = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            mail.Invoke((MethodInvoker)delegate
            {
                mail.textBox6.AppendText("From: " + mails.From + "\n" +
                    "Subject: " + mails.Subject + "\n" +
                    "Body:" + mails.Body + "\n");
            });
        }
    }
}

