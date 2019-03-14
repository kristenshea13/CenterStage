using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }

        public string CartID { get; set; }

        public string ClassTitle { get; set; }

        [Display(Name = "Students Registered")]
        public int NumberStudentsRegistered { get; set; }

        [DataType(DataType.Currency), RegularExpression(@"\d{1,20}(\.\d{1,2})?")]
        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }



    }
}
