namespace Model.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShoppingDbContext : DbContext
    {
        public OnlineShoppingDbContext()
            : base("name=OnlineShoppingDbContext1")
        {
        }

        public virtual DbSet<Catalogue> Catalogues { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Cart> Product_Cart { get; set; }
        public virtual DbSet<Product_Order_Details> Product_Order_Details { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<User_Account> User_Account { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogue>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Catalogue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_Details>()
                .HasMany(e => e.Product_Order_Details)
                .WithRequired(e => e.Order_Details)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product_Cart)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product_Order_Details)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User_Account>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.User_Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User_Account>()
                .HasMany(e => e.Product_Cart)
                .WithRequired(e => e.User_Account)
                .WillCascadeOnDelete(false);
        }
    }
}
