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

    [Table("Working_days")]
    public class Working_day
    {
        [Key]
        public int IdWorkingDay { get; set; }

        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }

        public int Worker_id { get; set; }

        [ForeignKey(nameof(Worker_id))]
        public Worker Worker { get; set; }

    }
}
