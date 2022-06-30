using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCodeFirstExercises.Models
{
    [Index(nameof(QuestionId), Name = "IX_QuestionId123")]
    public class Comment
    {
        public Comment()
        {
            this.Question = new Question();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
