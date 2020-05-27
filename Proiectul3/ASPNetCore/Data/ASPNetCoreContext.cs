using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.Models;

namespace ASPNetCore.Data
{
    public class ASPNetCoreContext : DbContext
    {
        public ASPNetCoreContext (DbContextOptions<ASPNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetCore.Models.DataDTO> Datas { get; set; }
    }
}
