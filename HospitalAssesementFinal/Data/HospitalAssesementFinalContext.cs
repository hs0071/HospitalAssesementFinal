using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalAssesementFinal.Models;

namespace HospitalAssesementFinal.Data
{
    public class HospitalAssesementFinalContext : DbContext
    {
        public HospitalAssesementFinalContext (DbContextOptions<HospitalAssesementFinalContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalAssesementFinal.Models.Hospital> Hospital { get; set; }

        public DbSet<HospitalAssesementFinal.Models.Doctor> Doctor { get; set; }

        public DbSet<HospitalAssesementFinal.Models.Patient> Patient { get; set; }
    }
}
