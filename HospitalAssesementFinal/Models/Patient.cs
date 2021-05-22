using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssesementFinal.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        //Name of the Patient
        public string Patient_Name { get; set; }
        //Address of the Patient
        public string Patient_Address { get; set; }
        //Contact number of the Patient
        public string Patient_Contact { get; set; }
        //Foreign Key
        //public int HospitalID { get; set; }
        //public Hospital Hospital_obj { get; set; }
        //Foreign Key
        public int DoctorID { get; set; }
        public Doctor Doctor_ID { get; set; }
    }
}
