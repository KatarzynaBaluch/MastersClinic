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

    [Table("Workers")]
    public class Worker
    {
        [Key]
        public int IdWorker { get; set; }

        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public int Role_id { get; set; }


        [ForeignKey(nameof(Role_id))]
        public Role Role { get; set; }

    }
}
