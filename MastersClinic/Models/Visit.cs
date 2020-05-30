using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MastersClinic.Models
{

    [Table("Visits")]
    public class Visit
    {
        [Key]
        public int IdVisit { get; set; }

        public string Visits_description { get; set; }

        public DateTime Date { get; set; }

        public bool Compleated { get; set; }


        public string Patient_id { get; set; }

        [ForeignKey(nameof(Patient_id))]
        public Patient Patient { get; set; }

        public int Doctor_id { get; set; }

        [ForeignKey(nameof(Doctor_id))]
        public Worker Doctor { get; set; }


    }
}
