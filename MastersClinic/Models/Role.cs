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

        [Table("Roles")]
        public class Role
        {
        [Key]
        public int IdRole { get; set; }

        public string Role_name { get; set; }
    }
}
