using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApplicant.Models
{
    public class ApplicantsModel
    {
        public string Doctor_Name { get; set; }
        public string Department { get; set; }
        public int Floor { get; set; }
        public int SSN { get; set; }

    }
}
