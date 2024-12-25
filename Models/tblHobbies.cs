using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc12122024.Models
{
    public class tblHobbies
    {
        [Key]
        public int hid { get; set; }
        public string hname { get; set; }
    }
}