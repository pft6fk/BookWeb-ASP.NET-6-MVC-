using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description{ get; set; }
        [Required]
        public string ISBN{ get; set; }
        [Required]
        public string Author{ get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CoverTypeID { get; set; }
        public CoverType CoverType{ get; set; }



    }
}
