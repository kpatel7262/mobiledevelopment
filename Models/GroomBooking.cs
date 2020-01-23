using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */
        [Key]
        public int booking_id { get; set; }

        public string booking_date { get; set; }
        public string booking_time { get; set; }
        public string booking_price { get; set; }

        public int service_id { get; set; }

        public int pet_id { get; set; }

        public int owner_id { get; set; }
        public int groomer_id { get; set; }
        

    }
}