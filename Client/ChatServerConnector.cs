using Client.ServiceReference4;
using System.Windows.Forms;

namespace Client
{
    public class ChatServerConnector : IChatServiceCallback
    {      
        private static ChatServerConnector Instance = null;
        private ChatServiceClient Client;
        private int UserId;
        private ChatServerConnector()
        {
            Client = new ChatServiceClient(new System.ServiceModel.InstanceContext(this));
        }
        static ChatServerConnector()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
        }
        public static ChatServerConnector GetInstance()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
            return Instance;
        }
        internal static void Connect(string text)
        {
            Instance.UserId = Instance.Client.Connect(text);
        }
        public void SendMessageToServer(string message, string nickname)
        {
            GetInstance().Client.SendMessage(message, nickname);
        }
        public void SendMessageToClient(string message, string nickname)
        {
            (Application.OpenForms["MyChat"] as MyChat).listBox_chat.Items.Add($"({nickname})=> {message}");
        }
        public void UserJoinMain(string nickname)
        {
            GetInstance().Client.UserJoin(nickname);
        }
        public void UserJoinToServer(string nickname) 
        {
            (Application.OpenForms["MyChat"] as MyChat).listBox_nicknames.Items.Add(nickname);
        } 
    }
}
