using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class Class
    {
        [Required, StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required, StringLength(200)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Minimum Age")]
        public int AgeMin { get; set; }

        [Display(Name = "Maximum Age")]
        public int AgeMax { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string Prerequisite { get; set; }

        [DataType(DataType.Currency), RegularExpression(@"\d{1,20}(\.\d{1,2})?")]
        public decimal Price { get; set; }

        public virtual IList<StudentRegistration> StudentRegistrations { get; set; }

        public int ID { get; set; }




    }
}
