using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFCM
{
    class Product
    {
        private string productName;
        private DateTime productDate;

        public Product(string _productName, DateTime _productDate)
        {
            productName = _productName;
            productDate = _productDate;
        }

        public string ProductName 
        { 
            get { return productName; } 
        }

        public DateTime ProductDate
        {
            get { return productDate; }
        }
    }
}
