using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BookStore.Models.ViewModels
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Ordermsts = new HashSet<Ordermst>();
        }

        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; } = null!;
        [Required]
        public string Lastname { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8, 20}$")]
        public string Password { get; set; } = null!;
        [Required]
        public int Roleid { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Ordermst> Ordermsts { get; set; }
    }
}
