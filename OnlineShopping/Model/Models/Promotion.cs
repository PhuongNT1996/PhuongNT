namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promotion")]
    public partial class Promotion
    {
        [Key]
        public int Promotion_ID { get; set; }

        public int? Product_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Promotion_Description { get; set; }

        public int? Discount_Percent { get; set; }

        public DateTime? From_Date { get; set; }

        public DateTime? To_Date { get; set; }

        public bool? Enable { get; set; }

        public virtual Product Product { get; set; }
    }
}
