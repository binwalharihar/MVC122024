using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc12122024.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("abc") 
        { }
        public DbSet<tblRegistration> tblRegistrations { get; set; }
        public DbSet<tblCountry> tblCountries { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tblGender> tblGenders { get; set; }
        public DbSet<tblHobbies> tblHobbies { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }

    }
}