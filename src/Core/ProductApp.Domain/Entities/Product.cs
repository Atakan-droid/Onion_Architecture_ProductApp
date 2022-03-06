using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get;private set; }
        public decimal Value { get;private set; }
        public int Quantity { get;private set; }

        public Product(string productName,decimal value,int quantity)
        {
            ProductName = productName;
            Value = value;
            Quantity = quantity;

            AddEvent();
        }
    }
}
