namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        [Key]
        public int Image_ID { get; set; }

        public int? Product_ID { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        public virtual Product Product { get; set; }
    }
}
