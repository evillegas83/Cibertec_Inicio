using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Display(Name = "Product_id", ResourceType = typeof(Resource))]
        public int Id { get; set; }

        [Display(Name = "Product_Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }

        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]
        public double Price { get; set; }

        [Display(Name = "Product_CreateDate", ResourceType = typeof(Resource))]
        public DateTime? CreateDate { get; set; }
    }
}
