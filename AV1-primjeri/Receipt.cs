using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
     public class Receipt
    {
        private string id;
        private decimal price;
        private decimal tax;
        public string Id { 
            get { return id; } 
            set { this.id = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public decimal Tax
        {
            get { return tax; }
            set { this.tax = value; }
        }
        public decimal GetTotal()
        {
            return Price * ((Tax + 100)/100);
        }
        public decimal GetSale(decimal saleFactor)
        {
            return Price * (saleFactor / 100);
        }
    }
}
