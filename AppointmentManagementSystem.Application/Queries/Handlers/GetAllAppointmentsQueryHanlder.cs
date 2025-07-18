using AppointmentManagementSystem.Application.Contracts;
using AppointmentManagementSystem.Application.Dtos;
using MediatR;

namespace AppointmentManagementSystem.Application.Queries.Handlers
{
    public class GetAllAppointmentsQueryHanlder : IRequestHandler<GetAllAppointmentsQuery, List<AppointmentDto>>
    {
        private readonly IAppointmentRepository _repository;
        public GetAllAppointmentsQueryHanlder(IAppointmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<AppointmentDto>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            var appointment = await _repository.GetAllAsync();

            return appointment.Select(a=>new AppointmentDto
            {
                Id = a.Id,
                ClientName = a.Client.Value,
                Date = a.Date.Value,
                Description = a.Description,
                IsCompleted = a.IsComplited,
            }).ToList();
        }
    }
}
