namespace OnlineShopping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Bill = new HashSet<Bill>();
            Employee_Account = new HashSet<Employee_Account>();
        }

        [Key]
        [StringLength(50)]
        public string Employee_ID { get; set; }

        [StringLength(250)]
        public string Full_Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        [StringLength(250)]
        public string Role_ID { get; set; }

        [StringLength(250)]
        public string Department_ID { get; set; }

        [StringLength(50)]
        public string Phone_Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Account> Employee_Account { get; set; }

        public virtual Role Role { get; set; }
    }
}
