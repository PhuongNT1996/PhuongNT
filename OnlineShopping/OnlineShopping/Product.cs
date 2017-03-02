namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Image = new HashSet<Image>();
            Product_Modification = new HashSet<Product_Modification>();
            Product_Order_Details = new HashSet<Product_Order_Details>();
            Promotion = new HashSet<Promotion>();
        }

        [Key]
        public int Product_ID { get; set; }

        public int Catalogue_ID { get; set; }

        public bool Is_Sale { get; set; }

        [Required]
        [StringLength(250)]
        public string Product_Name { get; set; }

        public float Price { get; set; }

        public int Level_Trending { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int? Products_Available { get; set; }

        public int? Total_Sold { get; set; }

        public DateTime? Created_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Created_Username { get; set; }

        [Column(TypeName = "ntext")]
        public string Guarantee_Description { get; set; }

        [StringLength(250)]
        public string Title_Image { get; set; }

        public float? Tax_Percent { get; set; }

        [StringLength(250)]
        public string Manufacturer { get; set; }

        public virtual Catalogue Catalogue { get; set; }

        public virtual Employee_Account Employee_Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Modification> Product_Modification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Order_Details> Product_Order_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotion { get; set; }
    }
}
