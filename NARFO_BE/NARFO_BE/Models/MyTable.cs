using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public class MyTable
    {
        [Key]
        public int ID { get; set; }
        public string Weather { get; set; }
        public string TblName { get; set; }
    }
}
