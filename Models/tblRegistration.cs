using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc12122024.Models
{
    public class tblRegistration
    {
        [Key]
        public int rid { get; set; }
        public string rname { get; set; }
        public string remail { get; set; }
        public string rpassword { get; set; }
        public int rgender { get; set; }
        public int rcountry { get; set; }
        public int rstate { get; set; }
        public string rhobbies { get; set; }
    }
}