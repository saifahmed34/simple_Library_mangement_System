using Library_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        DbSet<Loan> loans { get; set; }
        DbSet<Member> member { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Library;Integrated Security=True");
        }
    }
}
