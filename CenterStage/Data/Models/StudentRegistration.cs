using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class StudentRegistration
    {
        [Key]
        public int ID { get; set; }

        public int ClassID { get; set; }

        public virtual Class Class { get; set; }

        public int StudentID { get; set; }

        public virtual StudentInfo Student { get; set; }

    }
}
