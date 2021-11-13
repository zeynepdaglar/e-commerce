using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerSurname { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerPhone { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerAdress { get; set; }
    }
}
