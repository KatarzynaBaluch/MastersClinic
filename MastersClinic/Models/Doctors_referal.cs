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

    [Table("Doctors_referals")]
    public class Doctors_referal
    {
        [Key]
        public int IdReferal { get; set; }

        public string Description { get; set; }
        public DateTime Date_of_issue { get; set; }
        public DateTime Expiration_day { get; set; }


        public int Visit_id { get; set; }


        [ForeignKey(nameof(Visit_id))]
        public Visit Visit { get; set; }

    }
}
