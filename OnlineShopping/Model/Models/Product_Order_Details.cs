namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Order_Details
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        public int Order_Quantity { get; set; }

        public float Price { get; set; }

        public int? Discount_Percent { get; set; }

        [Column(TypeName = "ntext")]
        public string Promotion_Description { get; set; }

        public virtual Order_Details Order_Details { get; set; }

        public virtual Product Product { get; set; }
    }
}
