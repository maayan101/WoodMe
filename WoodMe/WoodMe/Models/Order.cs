using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WoodMe.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }

        public string ImageLink { get; set; }

        public string CardNumber { get; set; }

        public int ExperationMonth { get; set; }

        public int ExperationYear { get; set; }

        public String CVV { get; set; }

        public Discount Discount { get; set; }
    }
}
