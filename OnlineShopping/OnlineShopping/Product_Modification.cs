namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Modification
    {
        [Key]
        public int Modification_ID { get; set; }

        public int Product_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        public DateTime Modified_Date { get; set; }

        public virtual Employee_Account Employee_Account { get; set; }

        public virtual Product Product { get; set; }
    }
}
