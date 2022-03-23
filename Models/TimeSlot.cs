using System;
using System.ComponentModel.DataAnnotations;

namespace SignUpGenius.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotID { get; set; }

        public DateTime TourTime { get; set; }

        public Boolean Taken { get; set; }

    }
}
