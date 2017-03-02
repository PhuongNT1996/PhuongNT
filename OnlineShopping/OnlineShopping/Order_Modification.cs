namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Modification
    {
        [Key]
        public int Modification_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username_Modify { get; set; }

        public int Order_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime? Modified_Date { get; set; }

        public virtual Employee_Account Employee_Account { get; set; }

        public virtual Order_Details Order_Details { get; set; }
    }
}
