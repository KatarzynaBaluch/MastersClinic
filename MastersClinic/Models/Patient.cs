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

    [Table("Patients")]
    public class Patient
    {
        [Key]
        public string Pesel { get; set; }

        public string Surname { get; set; }

        public string Maiden_name { get; set; }

        public string Forename { get; set; }

        public string Second_forename { get; set; }

        public bool Sex { get; set; }

        public DateTime Date_of_birth { get; set; }

        public DateTime Date_of_death { get; set; }

        public string City_of_birth { get; set; }

        public string City { get; set; }

        public string Street { get; set; }


        public string Building_number { get; set; }

        public string Flat_number { get; set; }


        public string Phone_number { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }





    }
}
