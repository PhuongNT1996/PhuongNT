namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Account()
        {
            Account_Modification = new HashSet<Account_Modification>();
            Account_Modification1 = new HashSet<Account_Modification>();
            Bill = new HashSet<Bill>();
            Bill_Modification = new HashSet<Bill_Modification>();
            Product_Modification = new HashSet<Product_Modification>();
            Order_Modification = new HashSet<Order_Modification>();
            Product = new HashSet<Product>();
        }

        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Employee_ID { get; set; }

        public int Level_Access { get; set; }

        public bool Enable { get; set; }

        public DateTime? Created_Date { get; set; }

        [StringLength(50)]
        public string Created_By_Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account_Modification> Account_Modification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account_Modification> Account_Modification1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Modification> Bill_Modification { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Modification> Product_Modification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Modification> Order_Modification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
