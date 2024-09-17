using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagment.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required, MinLength(4), MaxLength(50)]
        public string Username { get; set; }

        [Required, MinLength(3), MaxLength(60)]
        public string HashPassword { get; set; }
    }
}
