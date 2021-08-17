using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeApp.Entities
{
    public class Certificate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateID { get; set; }

        public String CertificateTitle { get; set; }

        public String CertificateLocation { get; set; }

        public String CertificateStart { get; set; }

        public String CertificateFinish { get; set; }

        public String CertificateExplanation { get; set; }
    }
}
