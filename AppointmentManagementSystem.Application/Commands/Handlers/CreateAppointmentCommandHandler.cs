using AppointmentManagementSystem.Application.Contracts;
using AppointmentManagementSystem.Domain.Entities;
using AppointmentManagementSystem.Domain.ValueObjects;
using MediatR;

namespace AppointmentManagementSystem.Application.Commands.Handlers
{
    public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand, Guid>
    {
        private readonly IAppointmentRepository _repository;
        public CreateAppointmentCommandHandler(IAppointmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var date =new AppointmentDate(request.Date);
            var clientName = new ClientName(request.ClientName);
            var appointment = new Appointment(clientName,date,request.Description);
            
            await _repository.AddAsync(appointment);
            return appointment.Id;

        }
    }
}
