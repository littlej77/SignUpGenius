using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class SignUpGeniusContext : DbContext
    {
        public SignUpGeniusContext()
        {
        }

        public SignUpGeniusContext(DbContextOptions<SignUpGeniusContext> options): base(options)
        {
        }

        public DbSet<FormResponse> FormResponses { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

    }
}

