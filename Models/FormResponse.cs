using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class FormResponse
    {
        //here we need to have the time info, its part of the form but its not editable 
        //routed to a form that has the date info set --> we need to make the time come into this? 

        //not sure if we need this?
        [Key]
        [Required]
        public int TourId { get; set; }
<<<<<<< Updated upstream
     
=======

>>>>>>> Stashed changes
        [Required]
        public string GroupName {get; set;}

        [Required]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TourDate { get; set; }
    }
}
