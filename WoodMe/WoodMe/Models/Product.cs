using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoodMe.AdditionalClasses;

namespace WoodMe.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public Texture Texture { get; set; }

        public double Price { get; set; }

    }
}
