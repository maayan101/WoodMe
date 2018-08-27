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
        [Required]
        [Display(Name = "מספר מוצר")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "שם המוצר")]
        public string Name { get; set; }

        [Required]
        [Range(5.5, 15.5)]
        [Display(Name = "אורך")]
        public double Length { get; set; }

        [Required]
        [Range(5.5, 15.5)]
        [Display(Name = "רוחב")]
        public double Width { get; set; }

        [Required]
        [Display(Name = "טקסטורה")]
        public Texture Texture { get; set; }

        [Required]
        [Range(20, 200)]
        [Display(Name = "מחיר")]
        public double Price { get; set; }

    }
}
