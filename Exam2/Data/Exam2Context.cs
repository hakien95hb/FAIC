using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exam2.Models;

namespace Exam2.Models
{
    public class Exam2Context : DbContext
    {
        public Exam2Context (DbContextOptions<Exam2Context> options)
            : base(options)
        {
        }

        public DbSet<Exam2.Models.Category> Category { get; set; }

        public DbSet<Exam2.Models.Product> Product { get; set; }
    }
}
