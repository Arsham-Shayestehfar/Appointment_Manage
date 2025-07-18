using AppointmentManagementSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public ClientName Client { get;private set; }
        public AppointmentDate Date { get;private set; }
        public string? Description { get; private set; }
        public bool IsComplited { get; private set; }

        public Appointment(ClientName client , AppointmentDate appointment , string? desc)
        {
            Id = Guid.NewGuid();
            Client = client;
            Date = appointment;
            Description = desc;
            IsComplited = false;
        }

        public void MarkAsComplited()
        {
            IsComplited = true;
        }
        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }
    }
}
