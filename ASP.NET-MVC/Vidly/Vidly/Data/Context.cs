//using System.Configuration;
//using Microsoft.EntityFrameworkCore;
//using Vidly.Data.EntityConfigurations;
//using Vidly.Models;
//
//namespace Vidly.Data
//{
//    public class Context: DbContext
//    {
//        public DbSet<Customer> Customers { get; set; }
//        public DbSet<MembershipType> MembershipTypes { get; set; }
//
//
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);
//            optionsBuilder.UseMySql(@"server=localhost;database=Vidly;user=root;password=Ah293077");
//        }
//
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
//            modelBuilder.ApplyConfiguration(new MembershipTypeConfigurations());
//        }
//    }
//}