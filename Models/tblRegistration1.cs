using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc12122024.Models
{
    public class tblRegistration1
    {
        public int rid { get; set; }
        public string rname { get; set; }
        public string remail { get; set; }
        public string rpassword { get; set; }
        public int rgender { get; set; }
        public int rcountry { get; set; }
        public int rstate { get; set; }
        public string rhobbies { get; set; }
        public List<tblCountry> lstcountry { get; set; }
        public List<tblState> lststate { get; set; }
        public List<tblHobbies1> lsthobby1 { get; set; }
        public List<tblGender> lstgender { get; set; }
    }
}