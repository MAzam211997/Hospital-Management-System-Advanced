using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.CollectionViewModels
{
    public class OperationTheatreCollection
    {
        public Appointment Appointment { get; set; }
        public OperationTheatre OperationTheatre { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<MedicalTest> MedicalTests { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}