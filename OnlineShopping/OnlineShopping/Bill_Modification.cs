namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill_Modification
    {
        [Key]
        public int Modification_ID { get; set; }

        [StringLength(50)]
        public string Username_Modify { get; set; }

        public int? Bill_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime? Modified_Date { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Employee_Account Employee_Account { get; set; }
    }
}
