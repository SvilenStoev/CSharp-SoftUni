using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCodeFirstExercises.Models
{
    public class Question
    {
        public Question()
        {
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public string Author { get; set; }

    }
}
