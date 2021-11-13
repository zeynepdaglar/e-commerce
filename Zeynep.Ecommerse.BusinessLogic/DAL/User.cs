using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }


        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Surname { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }


        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        public string Password { get; set; }


        private static string SALT = "8436543684137532";

        public static string GetPasswordHash(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(SALT + input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

               
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
