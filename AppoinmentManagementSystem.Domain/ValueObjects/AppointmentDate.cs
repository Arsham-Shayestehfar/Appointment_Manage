using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManagementSystem.Domain.ValueObjects
{
    public class AppointmentDate
    {
        public DateTime Value { get;  }
        public AppointmentDate(DateTime value)
        {
            if (value <= DateTime.Now)
                throw new ArgumentException("value is not valid");

            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is AppointmentDate other && Value == other.Value;
        }

        public override int GetHashCode()
         => Value.GetHashCode();
    }
}
