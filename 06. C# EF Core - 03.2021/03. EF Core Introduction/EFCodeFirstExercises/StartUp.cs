using EFCodeFirstExercises.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCodeFirstExercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var db = new SliDoDbContext();
            db.Database.Migrate();

        }
    }
}
