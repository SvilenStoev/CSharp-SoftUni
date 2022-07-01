using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Data.Models.Enums;

namespace VaporStore.Data.Models
{
   public class Card
    {
        public Card()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{4}\s\d{4}\s\d{4}\s\d{4}")]
        public string Number { get; set; }

        [Required]
        [RegularExpression(@"\d{3}")]
        public string Cvc { get; set; }

        public CardType Type { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}