using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAppointments.Web.Domain;

public class Session : EntityBase
{
    public Guid DentistId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public string? Note { get; set; }

    public Dentist? Dentist { get; set; }
    public Patient? Patient { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();

}
public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder
            .ToTable("Sessions");

        builder
            .HasMany(p => p.Appointments)
            .WithOne(p => p.Session);
    }
}
