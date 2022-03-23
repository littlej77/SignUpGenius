using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class SignUpGeniusContext : DbContext
    {
        //constructor
        public SignUpGeniusContext()
        {
        }

        public SignUpGeniusContext(DbContextOptions<SignUpGeniusContext> options): base(options)
        {
        }

        public DbSet<FormResponse> FormResponses { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeSlotID = 1, TourTime = Convert.ToDateTime(8) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(9) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(10) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(11) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(12) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(13) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(14) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(15) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(16) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(17) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(18) },
                new TimeSlot { TimeSlotID = 2, TourTime = Convert.ToDateTime(19) }

                );
        }

    }
}

