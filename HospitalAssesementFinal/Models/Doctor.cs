using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssesementFinal.Models
{
    public class Doctor
    {
        [Key]
        //Doctor Id
        public int Id { get; set; }
        //Doctor Name
        public string Doctor_Name { get; set; }
        //Doctor Address
        public string Doctor_Address { get; set; }
        //Doctor Contact
        public string Doctor_Contact { get; set; }
    }
}
