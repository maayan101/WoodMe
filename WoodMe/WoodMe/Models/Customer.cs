using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodMe.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int HomeNumber { get; set; }

        public int PhoneNumber { get; set; }

        public string  Email { get; set; }
    }
}
