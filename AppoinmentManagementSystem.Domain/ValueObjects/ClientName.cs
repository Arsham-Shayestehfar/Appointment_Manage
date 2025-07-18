using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Domain.ValueObjects
{
    public class ClientName
    {
        public string Value { get; }
        public ClientName(string value)
        {
           if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentNullException("name is empty or invalid");
            }
           Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is ClientName other && Value==other.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
