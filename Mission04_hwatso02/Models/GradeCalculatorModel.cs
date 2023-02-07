using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_hwatso02.Models
{
    //Getters and Setters for Form
    public class GradeCalculatorModel
    {
        //Make sure that input value is valid, if not, give an error
        [Range(0, 100, ErrorMessage = "Assignments must be between 0 and 100")]
        public int Assignment { get; set; }

        [Range(0, 100, ErrorMessage = "Project must be between 0 and 100")]
        public int Project { get; set; }

        [Range(0, 100, ErrorMessage = "Quiz must be between 0 and 100")]
        public int Quiz { get; set; }

        [Range(0, 100, ErrorMessage = "Midterm Exam must be between 0 and 100")]
        public int Midterm { get; set; }

        [Range(0, 100, ErrorMessage = "Final Exam must be between 0 and 100")]
        public int Final { get; set; }

        [Range(0, 100, ErrorMessage = "INTEX must be between 0 and 100")]
        public int Death { get; set; }
    }
}
