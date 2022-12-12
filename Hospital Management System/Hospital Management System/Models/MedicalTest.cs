using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class MedicalTest
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
    
        public string Status { get; set; }
    }
}