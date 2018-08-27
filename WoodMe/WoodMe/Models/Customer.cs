using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WoodMe.Models
{
    public class Customer
    {
        [Required]
        [Display(Name = "מספר לקוח")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "שם")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "עיר מגורים")]
        public string City { get; set; }

        [Required]
        [Display(Name = "רחוב")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "מספר בית")]
        public int HomeNumber { get; set; }

        [Required]
        [RegularExpression(@"^05+[0-9]{8}")]
        [Display(Name = "פלאפון")]
        public int PhoneNumber { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string  Email { get; set; }
    }
}
