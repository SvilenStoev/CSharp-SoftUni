using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstExercises.Models
{
    public class SliDoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=SliDo");
            }
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
