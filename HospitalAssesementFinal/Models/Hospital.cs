using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssesementFinal.Models
{
    public class Hospital
    {
        [Key]
        //Hospital  Id
        public int Id { get; set; }
        //Hospital Name
        public string Hospital_Name { get; set; }
        
    }
}
