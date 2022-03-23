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
                new TimeSlot { TimeSlotID = 1, TourTime = (2022, 4, 2, 8, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 10, 0)},
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 11, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 12, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 13, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 14, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 15, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 16, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 17, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 18, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 19, 0) },
                new TimeSlot { TimeSlotID = 2, TourTime = (2022, 4, 2, 20, 0) },

                );
        }

    }
}

