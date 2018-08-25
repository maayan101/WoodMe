using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WoodMe.Models
{
    public class Discount
    {
        [Display(Name = "קוד הנחה")]
        public int Id { get; set; }

        [Display(Name = "אחוזי הנחה")]
        public double DiscountPrecentage { get; set; }

        [Display(Name = "שם ההנחה")]
        public string Name { get; set; }
    }
}
