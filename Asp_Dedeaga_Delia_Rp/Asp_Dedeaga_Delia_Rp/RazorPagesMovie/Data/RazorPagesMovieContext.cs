using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<RazorPagesMovie.Models.Movie> Movie
        {
            get; set;
        }
    }
}
