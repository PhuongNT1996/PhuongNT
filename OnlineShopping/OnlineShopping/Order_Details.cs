namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Details()
        {
            Bill = new HashSet<Bill>();
            Order_Modification = new HashSet<Order_Modification>();
            Product_Order_Details = new HashSet<Product_Order_Details>();
        }

        [Key]
        public int Order_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        public DateTime? Ordered_Date { get; set; }

        public bool Delivered { get; set; }

        public bool? Cancelled_Order { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason_Cancel { get; set; }

        [StringLength(250)]
        public string Order_Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Exact_Address { get; set; }

        [StringLength(20)]
        public string Order_Phone { get; set; }

        public int? Province_ID { get; set; }

        public int? District_ID { get; set; }

        public int? Town_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        public virtual District District { get; set; }

        public virtual Province Province { get; set; }

        public virtual Town Town { get; set; }

        public virtual User_Account User_Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Modification> Order_Modification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Order_Details> Product_Order_Details { get; set; }
    }
}
