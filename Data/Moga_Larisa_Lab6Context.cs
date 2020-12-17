using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moga_Larisa_Lab6.Models;

namespace Moga_Larisa_Lab6.Data
{
    public class Moga_Larisa_Lab6Context : DbContext
    {
        public Moga_Larisa_Lab6Context (DbContextOptions<Moga_Larisa_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Moga_Larisa_Lab6.Models.Book> Book { get; set; }
    }
}
