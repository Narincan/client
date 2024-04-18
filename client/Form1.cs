using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        bool terminating = false;
        bool connected = false;
        Socket clientSocket;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox_ip.Text;

            int portNum;
            if(Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    button_connect.Enabled = false;
                    textBox_message.Enabled = true;
                    button_send.Enabled = true;
                    connected = true;
                    logs.AppendText("Connected to the server!\n");

                    Thread receiveThread = new Thread(Receive);
                    receiveThread.Start();

                }
                catch
                {
                    logs.AppendText("Could not connect to the server!\n");
                }
            }
            else
            {
                logs.AppendText("Check the port\n");
            }

        }

        private void Receive()
        {
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[1024];
                    int bytesReceived = clientSocket.Receive(buffer);
                    if (bytesReceived > 0)
                    {
                        string incomingMessage = Encoding.Default.GetString(buffer, 0, bytesReceived);
                        ProcessReceivedMessage(incomingMessage);
                    }
                    else
                    {
                        throw new SocketException();
                    }
                }
                catch (SocketException)
                {
                    if (!terminating)
                    {
                        logs.Invoke(new MethodInvoker(delegate { logs.AppendText("The server has disconnected.\n"); }));
                        ResetConnectionControls();
                    }

                    clientSocket.Close();
                    connected = false;
                    break;
                }
            }
        }

        private void ResetConnectionControls()
        {
            // Reset the UI controls to enable reconnection
            button_connect.Invoke(new MethodInvoker(delegate { button_connect.Enabled = true; }));
            textBox_message.Invoke(new MethodInvoker(delegate { textBox_message.Enabled = false; }));
            button_send.Invoke(new MethodInvoker(delegate { button_send.Enabled = false; }));
        }



        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string username = textBox_message.Text.Trim();  // Assuming textBox_message is where the username is entered
            if (!string.IsNullOrEmpty(username) && username.Length <= 64)
            {
                string message = "NAME:" + username;  // Format the message as expected by the server
                Byte[] buffer = Encoding.Default.GetBytes(message);
                clientSocket.Send(buffer);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            SendMove("ROCK");
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            SendMove("PAPER");
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            SendMove("SCISSORS");
        }

        private void SendMove(string move)
        {
            if (connected)
            {
                string message = "MOVE:" + move;
                Byte[] buffer = Encoding.Default.GetBytes(message);
                clientSocket.Send(buffer);
            }
            else
            {
                logs.AppendText("Not connected to the server.\n");
            }
        }

        private void ProcessReceivedMessage(string message)
        {
            if (message.StartsWith("USERS:"))
            {
                string[] users = message.Substring(6).Split(',');
                userListBox.Invoke(new MethodInvoker(delegate
                {
                    userListBox.Items.Clear();
                    foreach (var user in users)
                    {
                        userListBox.Items.Add(user);
                    }
                }));
            }
            else if (message.StartsWith("Welcome to Rock-Paper-Scissors,"))
            {
                logs.Invoke(new MethodInvoker(delegate
                {
                    logs.AppendText(message + "\n");
                }));
            }
            else if (message.StartsWith("Game is starting in") || message.StartsWith("Game started!"))
            {
                logs.Invoke(new MethodInvoker(delegate
                {
                    logs.AppendText(message + "\n");
                }));
            }
            else if (message.StartsWith("ERROR:"))
            {
                logs.Invoke(new MethodInvoker(delegate
                {
                    logs.AppendText(message + "\n");
                }));
            }
            else
            {
                logs.Invoke(new MethodInvoker(delegate
                {
                    logs.AppendText("Received message: " + message + "\n");
                }));
            }
        }


        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
