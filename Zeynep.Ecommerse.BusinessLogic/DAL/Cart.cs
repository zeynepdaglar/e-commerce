using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Customer { get; set; }


        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public Product Product { get; set; }


        [Required]
        [Column(TypeName = "decimal")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public int ProductTotalPrice { get; set; }
    }
}
