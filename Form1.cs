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
using System.Net.Sockets;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using static MySql.Data.MySqlClient.MySqlException;


namespace rpi
{

    public partial class Form1 : Form
    {
        int port;
        string message;
        int byteCount;
        NetworkStream stream;
        byte[] sendData;
        TcpClient client;
        string username;
        string password;
        string towho;
        string sifrelimetin;
        string sifresizmetin;
        string id_user;
        int sayac = 0;

        IPAddress localAdd = IPAddress.Parse("192.168.137.10");
        TcpListener listener = new TcpListener(IPAddress.Any, 1234);
       
        
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listener.Start();
            timer1.Interval = 3000;
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_port.Text,out port))
            {
                MessageBox.Show("port number not valied");
            }
            try
            {
                client = new TcpClient(txt_ip.Text, port);
                MessageBox.Show("connection made");

            }
            catch(System.Net.Sockets.SocketException)
            {
                MessageBox.Show("connection failed");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                aes crypto = new aes();

                message = crypto.AESsifrele(txt_message.Text);
                byteCount = Encoding.ASCII.GetByteCount(message);
                sendData = new byte[byteCount];
                sendData = Encoding.ASCII.GetBytes(message);
                stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                listBox_sending.Items.Add("Sent Message: " + crypto.AESsifre_Coz(message));

                towho = comboBox_towho.Text;
                byteCount = Encoding.ASCII.GetByteCount(towho);
                sendData = new byte[byteCount];
                sendData = Encoding.ASCII.GetBytes(towho);
                stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("connection not installised");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            username = comboBox_username.Text;
            password = txt_password.Text;

            byteCount = Encoding.ASCII.GetByteCount(username);
            sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(username);
            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            byteCount = Encoding.ASCII.GetByteCount(password);
            sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(password);
            stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);


            listbox_messages.Visible = true;

            aes crypto = new aes();

            TcpClient clientt = listener.AcceptTcpClient();
            NetworkStream nwStream = clientt.GetStream();

            int i = 2;
            while (i > 0)
            {
                byte[] buffer = new byte[clientt.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, clientt.ReceiveBufferSize);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                nwStream.Write(buffer, 0, bytesRead);
                int uzunluk = dataReceived.Length;
                if (dataReceived == "wrong")
                {
                    MessageBox.Show("wrong password");
                    this.Close(); 

                }

                if (uzunluk > 10)
                {
                    sifrelimetin = crypto.AESsifre_Coz(dataReceived);
                    listbox_messages.Items.Add("Latest Message: " + sifrelimetin);
                }
                if (uzunluk < 10)
                {
                    sifresizmetin = dataReceived;
                    listbox_messages.Items.Add("From: " + sifresizmetin);
                }
                i--;

                timer1.Start();
            }
            


            pictureBox_member.Visible = false;
                lbl_memberlogin.Visible = false;
                lbl_sentbox.Visible = true;
                lbl_inbox.Visible = true;
                lbl_secure.Visible = true;
                pictureBox_secure.Visible = true;
                listBox_sending.Visible = true;
                lbl_password.Visible = false;
                txt_password.Visible = false;
                lbl_username.Visible = false;
                comboBox_username.Visible = false;
                btn_login.Visible = false;
                lbl_message.Visible = true;
                txt_message.Visible = true;
                lbl_towho.Visible = true;

                comboBox_towho.Visible = true;
                if (comboBox_username.Text == "ali")
                {
                    comboBox_towho.Items.Add("veli");
                    comboBox_towho.Items.Add("ahmet");
                    comboBox_towho.Items.Add("hasan");
                }

                if (comboBox_username.Text == "veli")
                {
                    comboBox_towho.Items.Add("ali");
                    comboBox_towho.Items.Add("ahmet");
                    comboBox_towho.Items.Add("hasan");
                }

                if (comboBox_username.Text == "ahmet")
                {
                    comboBox_towho.Items.Add("ali");
                    comboBox_towho.Items.Add("veli");
                    comboBox_towho.Items.Add("hasan");
                }
                if (comboBox_username.Text == "hasan")
                {
                    comboBox_towho.Items.Add("ali");
                    comboBox_towho.Items.Add("veli");
                    comboBox_towho.Items.Add("ahmet");
                }



            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 3 == 0)
            {
                aes crypto = new aes();

                MySqlConnection conn;
                String constring = "Server=192.168.137.10;Port=3306;Username=ozi;Password=12345;Database=users;";
                conn = new MySqlConnection(constring);
                conn.Open();

                string y;
                string x = username;
                MySqlCommand cmd = new MySqlCommand("select * from messages where towho=@x", conn);
                cmd.Parameters.Add("x", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    listbox_messages.Items.Clear();
                    listbox_messages.Items.Add("Latest Message: " + crypto.AESsifre_Coz(reader["message"].ToString()));

                    id_user = reader["id_user"].ToString();

                }
                conn.Close();

                conn.Open();

                cmd = new MySqlCommand("select * from user where id=@y", conn);
                cmd.Parameters.Add("y", id_user);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listbox_messages.Items.Add("From : " + reader["name"].ToString());

                }
                conn.Close();


            }
        }
    }
}
