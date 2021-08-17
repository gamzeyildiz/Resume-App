using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeApp.Entities
{
    public class Experience
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperienceID { get; set; }

        public String ExperienceTitle { get; set; }

        public String ExperienceLocation { get; set; }

        public String ExperienceStart { get; set; }

        public String ExperienceFinish{ get; set; }        

        public String ExperienceExplanation { get; set; }

    }
}
