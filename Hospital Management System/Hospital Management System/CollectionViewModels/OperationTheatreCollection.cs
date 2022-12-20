using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital_Management_System.Migrations;
using Hospital_Management_System.Models;
using MedicalTest = Hospital_Management_System.Models.MedicalTest;
using OperationTheatre = Hospital_Management_System.Models.OperationTheatre;

namespace Hospital_Management_System.CollectionViewModels
{
    public class OperationTheatreCollection
    {
        public Appointment Appointment { get; set; }
        public OperationTheatre OperationTheatre { get; set; }
        public MedicalTest MedicalTestModel { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<MedicalTest> MedicalTests { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}