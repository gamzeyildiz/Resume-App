using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.Entities
{
    [Table("Resume")]
    public class Resume 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [StringLength(50)]
        public String Name { get; set; }
        
        public String Title { get; set; }

        public String About { get; set; }       



    }
}
