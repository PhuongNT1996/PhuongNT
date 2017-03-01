namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Cart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_ID { get; set; }

        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual User_Account User_Account { get; set; }
    }
}
