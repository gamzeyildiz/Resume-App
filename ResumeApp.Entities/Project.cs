using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeApp.Entities
{
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        public String ProjectLanguage { get; set; }

        public String ProjectTitle { get; set; }

        public String ProjectExplanation { get; set; }

    }
}
