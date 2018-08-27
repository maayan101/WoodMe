using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WoodMe.Models
{
    public class Order
    {
        [Required]
        [Display(Name = "מספר הזמנה")]
        public int OrderId { get; set; }

        [Required]
        [Display(Name="תאריך הזמנה")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "מוצרים")]
        public ICollection<Product> Products { get; set; }

        [Required]
        [Display(Name = "לקוח")]
        public Customer Customer { get; set; }

        [Required]
        [Display(Name = "תמונה")]
        public string ImageLink { get; set; }

        [Required]
        [Display(Name = "מספר כרטיס")]
        [RegularExpression(@"[0-9]{12}")]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "תוקף - חודש")]
        [Range(0, 12)]
        public int ExperationMonth { get; set; }

        [Required]
        [Display(Name = "תוקף - שנה")]
        [Range(2018,2029)]
        public int ExperationYear { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{3}")]
        public String CVV { get; set; }

        [Display(Name = "הנחה")]
        public Discount Discount { get; set; }
    }
}
