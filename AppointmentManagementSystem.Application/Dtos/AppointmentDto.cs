using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Application.Dtos
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
