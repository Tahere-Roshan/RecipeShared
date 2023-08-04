using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeShared.Model;

namespace RecipeShared.Model
{
    public class RecipeContext : DbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Category { get; set; }
        public RecipeContext(DbContextOptions options) : base(options)
        {

        }

    }
}
