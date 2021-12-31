using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFCM
{
    class User
    {
        private string userId;
        private string fcmToken;
        private readonly List<List> lists = new List<List>();

        public User(string _userId)
        {
            userId = _userId;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string FcmToken
        {
            get { return fcmToken; }
            set { fcmToken = value; }
        }

        public List<List> Lists
        {
            get { return lists; } 
        }

        public void AddListToUser(string _listId, int _notificationTime)
        {
            lists.Add(new List(_listId, _notificationTime));
        }
    }
}
