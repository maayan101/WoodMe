using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodMe.Models
{
    public class Discount
    {
        public int Id { get; set; }

        public double DiscountPrecentage { get; set; }

        public string Name { get; set; }
    }
}
