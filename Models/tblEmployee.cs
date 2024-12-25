using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc12122024.Models
{
    public class tblEmployee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public int empage { get; set; }
        public string empimage { get; set; }

    }
}