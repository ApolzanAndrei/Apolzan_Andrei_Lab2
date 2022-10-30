using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apolzan_Andrei_Lab2.Models;

namespace Apolzan_Andrei_Lab2.Data
{
    public class Apolzan_Andrei_Lab2Context : DbContext
    {
        public Apolzan_Andrei_Lab2Context (DbContextOptions<Apolzan_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Apolzan_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Apolzan_Andrei_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
