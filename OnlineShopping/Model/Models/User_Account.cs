namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Account()
        {
            Order_Details = new HashSet<Order_Details>();
            Product_Cart = new HashSet<Product_Cart>();
        }

        [Key]
        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Full_Name { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(250)]
        public string Gender { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        public int? Cancel_Amount { get; set; }

        public DateTime? created_Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Cart> Product_Cart { get; set; }
    }
}
