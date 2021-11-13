using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class GlobalException 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExceptionId { get; set; }


        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ExceptionDate { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(4000)")]
        public string ErrorMessage { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(4000)")]
        public string StackTrace { get; set; }
    }
}
