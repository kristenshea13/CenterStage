using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class StudentInfo
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 3),
            Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }


        //@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"

        [Required, DataType(DataType.PhoneNumber),
            Display(Name = "Phone Number"),
            RegularExpression(@"^\(([0-9]{3})\)[ ]([0-9]{3})[-]([0-9]{4})$",
            ErrorMessage = "Please enter as (###) ###-####")]
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual IList<StudentRegistration> StudentRegistrations { get; set; }

    }
}
