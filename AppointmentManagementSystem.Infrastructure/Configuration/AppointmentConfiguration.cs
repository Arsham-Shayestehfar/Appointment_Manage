using AppointmentManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppointmentManagementSystem.Infrastructure.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a=>a.Id);

            builder.OwnsOne(a => a.Date, date =>
            {
                date.Property(d => d.Value)
                     .HasColumnName("Date")
                     .IsRequired();
            });

            builder.OwnsOne(c => c.Client, client =>
            {
                client.Property(c => c.Value)
                .HasColumnName("Client")
                .IsRequired();
            });

            builder.Property(a => a.Description)
              .HasMaxLength(500);

            builder.Property(a => a.IsComplited)
                   .HasDefaultValue(false);

        }
    }
}
