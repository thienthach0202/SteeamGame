using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProGame.Models;

namespace ProGame.Data
{
    public class ProGameContext : DbContext
    {
        public ProGameContext (DbContextOptions<ProGameContext> options)
            : base(options)
        {
        }

        public DbSet<ProGame.Models.Game> Game { get; set; }
    }
}
