using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }


        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }


        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OwnDate { get; set; }
    }
}

