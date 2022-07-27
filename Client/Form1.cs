using System;
using System.Windows.Forms;

namespace Client
{
    public partial class MyChat : Form
    {
        public MyChat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_chat.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatServerConnector.Connect(textBox_Nickname.Text);
            ChatServerConnector.GetInstance().UserJoinMain(textBox_Nickname.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatServerConnector.GetInstance().SendMessageToServer(textBox_sendMessage.Text, textBox_Nickname.Text);
            textBox_sendMessage.Text = "";
        }
    }
}
