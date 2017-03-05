namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            Bill_Modification = new HashSet<Bill_Modification>();
        }

        [Key]
        public int Bill_ID { get; set; }

        public int Order_ID { get; set; }

        public DateTime Created_Date { get; set; }

        public float Total_Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Responsible_Man { get; set; }

        public DateTime? Delivered_Date { get; set; }

        public DateTime? Received_Date { get; set; }

        public bool? Cancelled_Bill { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason_Cancel { get; set; }

        [StringLength(50)]
        public string Shipper_ID { get; set; }

        [StringLength(250)]
        public string Reciever_Name { get; set; }

        [StringLength(50)]
        public string Reciever_Phone { get; set; }

        [Column(TypeName = "ntext")]
        public string Reciever_Addresss { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee_Account Employee_Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Modification> Bill_Modification { get; set; }

        public virtual Order_Details Order_Details { get; set; }
    }
}
