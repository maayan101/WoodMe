using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WoodMe.AdditionalClasses;

namespace WoodMe.Models
{
    public class Product
    {
        [Display(Name = "מספר מוצר")]
        public int Id { get; set; }

        [Display(Name = "שם המוצר")]
        public string Name { get; set; }

        [Display(Name = "אורך")]
        public double Length { get; set; }

        [Display(Name = "רוחב")]
        public double Width { get; set; }

        [Display(Name = "טקסטורה")]
        public Texture Texture { get; set; }

        [Display(Name = "מחיר")]
        public double Price { get; set; }

    }
}
