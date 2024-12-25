using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc12122024.Models
{
    public class tblState
    {
        [Key]
        public int sid { get; set; }
        public int cid { get; set; }
        public string sname { get; set; }

    }
}