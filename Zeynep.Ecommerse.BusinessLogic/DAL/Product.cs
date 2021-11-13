using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductCode { get; set; }


        [Required]
        [Column(TypeName = "int")]
        public int ProductNumber { get; set; }


        [Required]
        [Column(TypeName = "int")]
        public int ProductPrice { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string ProductInformation { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductPhoto1 { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductPhoto2 { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductPhoto3 { get; set; }

    }
}
