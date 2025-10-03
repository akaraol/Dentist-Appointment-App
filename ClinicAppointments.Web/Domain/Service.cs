using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAppointments.Web.Domain;

public class Service : EntityBase
{
    public Guid AppointmentId { get; set; }
    public string? Name { get; set; }
    public decimal? Price { get; set; }

    public Appointment? Appointment { get; set; }
}
public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder
            .ToTable("Services");
    }
}
