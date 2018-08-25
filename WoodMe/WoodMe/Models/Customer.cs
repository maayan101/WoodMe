using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WoodMe.Models
{
    public class Customer
    {
        [Display(Name = "מספר לקוח")]
        public int Id { get; set; }

        [Display(Name = "שם")]
        public string Name { get; set; }

        [Display(Name = "עיר מגורים")]
        public string City { get; set; }

        [Display(Name = "רחוב")]
        public string Street { get; set; }

        [Display(Name = "מספר בית")]
        public int HomeNumber { get; set; }

        [Display(Name = "פלאפון")]
        public int PhoneNumber { get; set; }

        public string  Email { get; set; }
    }
}
