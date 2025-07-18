using AppointmentManagementSystem.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Application.Queries
{
    public class GetAllAppointmentsQuery : IRequest<List<AppointmentDto>> { }
}
