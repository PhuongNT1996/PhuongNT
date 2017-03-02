namespace OnlineShopping
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopping : DbContext
    {
        public OnlineShopping()
            : base("name=OnlineShoppingContext")
        {
        }

        public virtual DbSet<Account_Modification> Account_Modification { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Bill_Modification> Bill_Modification { get; set; }
        public virtual DbSet<Catalogue> Catalogue { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee_Account> Employee_Account { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Order_Modification> Order_Modification { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_Modification> Product_Modification { get; set; }
        public virtual DbSet<Product_Order_Details> Product_Order_Details { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<User_Account> User_Account { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogue>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Catalogue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Bill)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Shipper_ID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_Account)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Account_Modification)
                .WithRequired(e => e.Employee_Account)
                .HasForeignKey(e => e.Username_Modify)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Account_Modification1)
                .WithRequired(e => e.Employee_Account1)
                .HasForeignKey(e => e.Modified_Username)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Bill)
                .WithRequired(e => e.Employee_Account)
                .HasForeignKey(e => e.Responsible_Man)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Bill_Modification)
                .WithOptional(e => e.Employee_Account)
                .HasForeignKey(e => e.Username_Modify);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Product_Modification)
                .WithRequired(e => e.Employee_Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Order_Modification)
                .WithRequired(e => e.Employee_Account)
                .HasForeignKey(e => e.Username_Modify)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee_Account>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Employee_Account)
                .HasForeignKey(e => e.Created_Username)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_Details>()
                .HasMany(e => e.Bill)
                .WithRequired(e => e.Order_Details)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_Details>()
                .HasMany(e => e.Order_Modification)
                .WithRequired(e => e.Order_Details)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order_Details>()
                .HasMany(e => e.Product_Order_Details)
                .WithRequired(e => e.Order_Details)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product_Modification)
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
        }
    }
}
