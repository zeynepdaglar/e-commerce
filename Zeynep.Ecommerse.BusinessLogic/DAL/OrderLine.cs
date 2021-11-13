using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class OrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderLineId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int OrderLineNumber { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int OrderLineNumberPrice { get; set; }


        [Required]
        [Column(TypeName = "int")]
        public int OrderLineTotalPrice { get; set; }

        [ForeignKey ("OrderId")]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
