using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoodMe.AdditionalClasses;

namespace WoodMe.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }

        public string ImageLink { get; set; }

        public CreditCard CreditCard { get; set; }

        public Discount Discount { get; set; }
    }
}
