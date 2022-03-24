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

        //public DbSet<TimeSlot> DayOfWeekSlot { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeSlotID = 1, TourTime = "8AM", Taken = false },
                new TimeSlot { TimeSlotID = 2, TourTime = "9AM", Taken = false },
                new TimeSlot { TimeSlotID = 3, TourTime = "10AM", Taken = false },
                new TimeSlot { TimeSlotID = 4, TourTime = "11AM", Taken = false },
                new TimeSlot { TimeSlotID = 5, TourTime = "12PM", Taken = false },
                new TimeSlot { TimeSlotID = 6, TourTime = "1PM", Taken = false },
                new TimeSlot { TimeSlotID = 7, TourTime = "2PM", Taken = false },
                new TimeSlot { TimeSlotID = 8, TourTime = "4PM", Taken = false },
                new TimeSlot { TimeSlotID = 9, TourTime = "5PM", Taken = false },
                new TimeSlot { TimeSlotID = 10, TourTime = "6PM", Taken = false },
                new TimeSlot { TimeSlotID = 11, TourTime = "7PM", Taken = false },
                new TimeSlot { TimeSlotID = 12, TourTime = "8PM", Taken = false }
                );

            // I Think we need another field for day of the week

            //mb.Entity<DayOfWeekSlot>().HasData(
            //    new DayOfWeekSlot { DayOfWeekSlotID = 1, DayOfWeek = "MON"},
            //    new DayOfWeekSlot { DayOfWeekSlotID = 2, DayOfWeek = "TUE"},
            //    new DayOfWeekSlot { DayOfWeekSlotID = 3, DayOfWeek = "WED"},
            //    new DayOfWeekSlot { DayOfWeekSlotID = 4, DayOfWeek = "THU"},
            //    new DayOfWeekSlot { DayOfWeekSlotID = 5, DayOfWeek = "FRI"},
            //    new DayOfWeekSlot { DayOfWeekSlotID = 6, DayOfWeek = "SAT"}
            //    );

            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    TourId =1,
                    TimeSlotID = 1,
                    GroupName = "Kylie",
                    GroupSize = 5,
                    Email = "kyliefromm@gmail.com",
                    Phone = "801-555-5555",
                }
            );
        }

    }
}

