using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.DTO;

namespace WebHomeFinance.Models
{
    public class FinanceDBContext:DbContext
    {
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        public DbSet<NameTransaction> NameTransactions { get; set; }
       
        public DbSet<RegisterTransaction> RegisterTransactions { get; set; }
        public DbSet<ModelReport> ModelReports { get; set; }
       
        public FinanceDBContext(DbContextOptions<FinanceDBContext> options) : base(options)
        {          
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 1, Name = "salary", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 2, Name = "gift", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 3, Name = "bonus", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 4, Name = "dividents", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 5, Name = "sales", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 6, Name = "inheritance", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 7, Name = "other income", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 8, Name = "stimulus check", TypeTransaction = 1 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 9, Name = "rent", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 10, Name = "lease", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 11, Name = "insurance", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 12, Name = "utilities", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 13, Name = "bank interest ", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 14, Name = "car costs", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 15, Name = "cell phone", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 16, Name = "TV + internet", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 17, Name = "food", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 18, Name = "education", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 19, Name = "family expense", TypeTransaction = 2 });
            modelBuilder.Entity<NameTransaction>().HasData(new NameTransaction { Id = 20, Name = "other expense", TypeTransaction = 2 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 1, DateTransaction = new DateTime(2021, 05, 01), NameTransactionId = 1, Amount = 5250 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 2, DateTransaction = new DateTime(2021, 05, 03), NameTransactionId = 2, Amount = 250 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 3, DateTransaction = new DateTime(2021, 05, 03), NameTransactionId = 3, Amount = 1380 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 4, DateTransaction = new DateTime(2021, 05, 05), NameTransactionId = 4, Amount = 245 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 5, DateTransaction = new DateTime(2021, 05, 04), NameTransactionId = 5, Amount = 1800 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 6, DateTransaction = new DateTime(2021, 05, 02), NameTransactionId = 9, Amount = 1496 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 7, DateTransaction = new DateTime(2021, 05, 02), NameTransactionId = 10, Amount = 379 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 8, DateTransaction = new DateTime(2021, 05, 01), NameTransactionId = 11, Amount = 229 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 9, DateTransaction = new DateTime(2021, 05, 10), NameTransactionId = 12, Amount = 148 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 10, DateTransaction = new DateTime(2021, 05, 14), NameTransactionId = 7, Amount = 210 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 11, DateTransaction = new DateTime(2021, 05, 05), NameTransactionId = 15, Amount = 104 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 12, DateTransaction = new DateTime(2021, 05, 01), NameTransactionId = 16, Amount = 79 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 13, DateTransaction = new DateTime(2021, 05, 01), NameTransactionId = 17, Amount = 28 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 14, DateTransaction = new DateTime(2021, 05, 03), NameTransactionId = 17, Amount = 15 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 15, DateTransaction = new DateTime(2021, 05, 07), NameTransactionId = 17, Amount = 46 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 16, DateTransaction = new DateTime(2021, 05, 11), NameTransactionId = 17, Amount = 25 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 17, DateTransaction = new DateTime(2021, 05, 17), NameTransactionId = 17, Amount = 52 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 18, DateTransaction = new DateTime(2021, 05, 18), NameTransactionId = 17, Amount = 50 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 19, DateTransaction = new DateTime(2021, 05, 23), NameTransactionId = 17, Amount = 21 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 20, DateTransaction = new DateTime(2021, 05, 25), NameTransactionId = 17, Amount = 107 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 21, DateTransaction = new DateTime(2021, 05, 30), NameTransactionId = 17, Amount = 14 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 22, DateTransaction = new DateTime(2021, 05, 02), NameTransactionId = 19, Amount = 340 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 23, DateTransaction = new DateTime(2021, 05, 12), NameTransactionId = 19, Amount = 145 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 24, DateTransaction = new DateTime(2021, 05, 20), NameTransactionId = 20, Amount = 106 });
            modelBuilder.Entity<RegisterTransaction>().HasData(new RegisterTransaction { Id = 25, DateTransaction = new DateTime(2021, 05, 30), NameTransactionId = 18, Amount = 140 });
            modelBuilder.Entity<TypeTransaction>().HasData(new TypeTransaction { Id = 1, TypeTrans = "income" });
            modelBuilder.Entity<TypeTransaction>().HasData(new TypeTransaction { Id = 2, TypeTrans = "expense" });
        }
    }
}
