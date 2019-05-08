using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class About
    {
        [Key]
        [Required, StringLength(50, MinimumLength = 3)]
        public string StudioName { get; set; }


        [Required, StringLength(150, MinimumLength = 10), Display(Name = "Mission")]
        public string MissionStmt { get; set; }

        [Required, StringLength(500, MinimumLength = 25), Display(Name = "About")]
        public string AboutStudio { get; set; }





    }
}
