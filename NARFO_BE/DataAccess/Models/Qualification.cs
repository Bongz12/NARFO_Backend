using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Qualification
    {
        public int QualificationId { get; set; }
        public string MemNo { get; set; }
        public string AssessmentNo { get; set; }
        public string Assessment { get; set; }
        public double? Result { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string LinkDoc { get; set; }
    }
}
