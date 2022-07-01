using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VaporStore.Data.Models
{
   public class User
    {
        public User()
        {
            this.Cards = new HashSet<Card>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [RegularExpression(@"[A-Z][a-z]+\s[A-Z][a-z]+")]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}