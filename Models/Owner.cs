using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        [Key]
        public int Owner_id { get; set; }

        public string Owner_fname { get; set; }
        public string Owner_lname { get; set; }
        public string Owner_address { get; set; }

        public string Owner_workphone { get; set; }
        public string Owner_homephone { get; set; }



    }
}