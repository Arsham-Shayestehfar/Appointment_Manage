using AppointmentManagementSystem.Domain.Entities;
using AppointmentManagementSystem.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Infrastructure.Context
{
    public class AppointmentDbContext :DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) :base(options) 
        {
            
        }


        public DbSet<Appointment> Appointments => Set<Appointment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
        }
    }
}
