using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc12122024.Models
{
    public class tblCountry
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
    }
}