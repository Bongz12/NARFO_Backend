using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Branch
    {
        public string Branch1 { get; set; }
        public Branch(string Branch1) { this.Branch1 = Branch1;}
    }
}
