using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc12122024.Models
{
    public class tblGender
    {
        [Key]
        public int gid { get; set; }
        public string gender { get; set; }
    }
}