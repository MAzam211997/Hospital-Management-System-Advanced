using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class OperationTheatre
    {
        public int Id { get; set; }

        public Patient Patient { get; set; }
        [Display(Name = "Patient Name")]
        public int PatientId { get; set; }

        public Doctor Doctor { get; set; }
        [Display(Name = "Doctor Name")]
        public int DoctorId { get; set; }

        public MedicalTest MedicalTest { get; set; }
        [Display(Name = "Medical Test Report")]
        public int MedicalTestId { get; set; }
        public Appointment Appointment { get; set; }
        [Display(Name = "Appointmen Report")]
        public int AppointmentId { get; set; }

        [Display(Name = "Operation Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OperationDate { get; set; }

        public string Problem { get; set; }

        public bool Status { get; set; }

    }
}