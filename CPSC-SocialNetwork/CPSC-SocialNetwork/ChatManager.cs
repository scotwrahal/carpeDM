using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CPSC_SocialNetwork
{
    class ChatManager
    {
        public static MainWindow chatmanager;

        public static void Load(UserControl chat)
        {
            chatmanager.OpenChatWindow(chat);
        }

        public static void Delete(UserControl chat)
        {
            chatmanager.CloseChatWindow(chat);
        }
    }
}
