using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myWpf
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        
         public DbSet<Tovar> tovar { get; set; }

        public DbSet<Postav> postav { get; set; }

        public DbSet<Prihod> prihod { get; set; }

        public DbSet<Gorod> gorod { get; set; }

        public DbSet<Ulica> ulica { get; set; }

       // public DbSet<Test> test { get; set; } //Для тестерования запросов

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //Connected MariyDB 10.6
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=testdb;", new MySqlServerVersion(new Version(10, 6, 0)));
           //Connected MSSQL Server
           // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=TestDB; Trusted_Connection=True");
        }
    }
}