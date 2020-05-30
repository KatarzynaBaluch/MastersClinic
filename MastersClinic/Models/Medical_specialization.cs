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

    [Table("Medical_specializations")]
    public class Medical_specialization
    {
        [Key]
        public int IdSpecialization { get; set; }

        public string Specialization_name { get; set; }


    }
}
