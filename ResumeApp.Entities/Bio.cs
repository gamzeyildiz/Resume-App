using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeApp.Entities
{
    public class Bio 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BioID { get; set; }

        public int Age { get; set; }

        public String Email { get; set; }

        public String Skype { get; set; }

        public String Phone { get; set; }

        public String Address { get; set; }
    }
}
