using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MastersClinic.Models
{
    public class MastersClinicDb : DbContext
    {
   
        public DbSet<Doctor_specialization> Doctor_specializations { get; set; }
        public DbSet<Doctors_referal> Doctors_referals { get; set; }
        public DbSet<Medical_specialization> Medical_specializations { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Working_day> Working_days { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=MastersClinic_DataBase;
                                            Integrated Security=True;Connect Timeout=30;
                                            Encrypt=False;TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .UseLoggerFactory(MyLoggerFactory);
        }

     

    }
}

