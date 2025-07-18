using AppointmentManagementSystem.Application.Contracts;
using AppointmentManagementSystem.Domain.Entities;
using AppointmentManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Infrastructure.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentDbContext _context;
        public AppointmentRepository(AppointmentDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Appointment appointment)
        {
           await _context.Appointments.AddAsync(appointment);
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment?> GetByIdAsync(Guid id)
        {
          return await  _context.Appointments.FirstOrDefaultAsync(a=>a.Id == id);
        }

        public async Task SaveChangesAsync()
        {
          await  _context.SaveChangesAsync();
        }
    }
}
