using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SignUpGenius.Models
{
    public class TimeSlot
    {
        [Key]
        [Required(ErrorMessage = "TimeslotID on new one")]
        public int TimeSlotID { get; set; }

        public string TourTime { get; set; }

        public Boolean Taken { get; set; }

    }
}
