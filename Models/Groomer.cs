﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */
        [Key]
        public int groomer_id { get; set; }

        public string groomer_fname { get; set; }
        public string groomer_lname { get; set; }
        public string groomer_dob { get; set; }

        public string groomer_phone { get; set; }
        public string groomer_pay { get; set; }
    }
}