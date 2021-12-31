using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFCM
{
    class List
    {
        private string listId;
        private int notificationTime;
        private readonly List<Product> products = new List<Product>();

        public List(string _listId, int _notificationTime)
        {
            listId = _listId;
            notificationTime = _notificationTime;
        }

        public string ListId 
        { 
            get { return listId; }
        }

        public int NoitificationTime
        {
            get { return notificationTime; }
        }

        public List<Product> Products 
        { 
            get { return products; } 
        }

        public void AddProduct(string _productName, DateTime _productDate)
        {
            products.Add(new Product(_productName, _productDate));
        }
    }
}
