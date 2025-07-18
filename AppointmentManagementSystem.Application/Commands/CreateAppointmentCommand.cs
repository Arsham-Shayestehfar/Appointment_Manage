using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AppointmentManagementSystem.Application.Commands
{
    public class CreateAppointmentCommand:IRequest<Guid>
    {
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string ClientName {  get; set; }

    }
}
