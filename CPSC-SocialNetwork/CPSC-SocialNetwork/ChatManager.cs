using CPSC_SocialNetwork.Campaigns;
using CPSC_SocialNetwork.UserDisplay;
using CPSC_SocialNetwork.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CPSC_SocialNetwork
{
    class ChatManager
    {
        public static MainWindow chatmanager;

        public static void Load(ChatWindowDirect chat)
        {
            chat.OpenWindow.Visibility = Visibility.Visible;
            chat.ClosedWindow.Visibility = Visibility.Hidden;
            chatmanager.OpenChatWindow(chat);            
        }

        public static void Load(ChatWindowGroup chat)
        {
            chat.OpenWindow.Visibility = Visibility.Visible;
            chat.ClosedWindow.Visibility = Visibility.Hidden;
            chatmanager.OpenChatWindow(chat);
        }

        public static ChatWindowDirect Get(User user)
        {
            if (user.Chat == null)
            {
               user.Chat = new ChatWindowDirect(user);
            }

            return user.Chat;
        }

        public static ChatWindowGroup Get(Campaign user)
        {
            if (user.Chat == null)
            {
                user.Chat = new ChatWindowGroup(user);
            }

            return user.Chat;
        }


        public static void Delete(UserControl chat)
        {
            chatmanager.CloseChatWindow(chat);
        }
    }
}
