using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WoodMe.Models
{
    public class Order
    {
        [Display(Name = "מספר הזמנה")]
        public int OrderId { get; set; }

        [Display(Name="תאריך הזמנה")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "מוצרים")]
        public ICollection<Product> Products { get; set; }

        [Display(Name = "לקוח")]
        public Customer Customer { get; set; }

        [Display(Name = "תמונה")]
        public string ImageLink { get; set; }

        [Display(Name = "מספר כרטיס")]
        public string CardNumber { get; set; }

        [Display(Name = "תוקף - חודש")]
        public int ExperationMonth { get; set; }

        [Display(Name = "תוקף - שנה")]
        public int ExperationYear { get; set; }

        public String CVV { get; set; }

        [Display(Name = "הנחה")]
        public Discount Discount { get; set; }
    }
}
