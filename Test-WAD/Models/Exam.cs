using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_WAD.Models
{
    public class Exam
    {
        
        public int Id { get; set; }
        public string ExamSubject { get; set; }
      
        public string StartTime { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public string ExamDate { get; set; }
        [DataType(DataType.DateTime)]

        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}", ApplyFormatInEditMode = true)]
        public string ExamDuration { get; set; }
        public string ClassRoom{ get; set; }
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
   
}