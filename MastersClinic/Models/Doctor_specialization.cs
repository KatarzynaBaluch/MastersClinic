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

    [Table("Doctor_specializations")]
    public class Doctor_specialization
    {
        [Key]
        public int IdDoctor_specialization { get; set; }
        public int Doctor_id { get; set; }

        [ForeignKey(nameof(Doctor_id))]
        public Worker worker { get; set; }



        public int Specialization_id { get; set; }

        [ForeignKey(nameof(Specialization_id))]
        public Medical_specialization Medical_Specialization { get; set; }

    }
}
