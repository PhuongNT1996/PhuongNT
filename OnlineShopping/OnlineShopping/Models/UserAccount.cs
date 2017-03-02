using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class UserAccount
    {
        [Key]
        [Required(ErrorMessage ="Email is required")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        public string full_name { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        [DataType(DataType.DateTime)]
        public DateTime birthday { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string address { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_date { get; set; }

        public int cancel_amount { get; set; }
    }
}