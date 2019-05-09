using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data.Models
{
    public class AboutModel
    {
        
        public int ID { get; set; }

        


        [Required, StringLength(300, MinimumLength = 10), Display(Name = "Mission")]
        public string MissionStmt { get; set; }

        [Required, StringLength(1500, MinimumLength = 25), Display(Name = "About")]
        public string AboutStudio { get; set; }



    }
}
