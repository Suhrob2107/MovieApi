using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using MovieApi.Persistance.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistance.Context
{
    public class MovieContext:IdentityDbContext<AppUser> // burasi ilk basta DbContext idi simdi IdentityDbContext yaptik ve AppUser den tablodaki sutunlari ekledik
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1GEE0JQ;Initial Catalog=ApiMovieDb;User Id=sa;Password=1;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
