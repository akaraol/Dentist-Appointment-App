using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAppointments.Web.Domain;

public enum Status 
{
    Scheduled,
    Completed,
    Canceled,
    NoShow
}

public class Appointment : EntityBase
{
    public Guid SessionId { get; set; }
    public Guid DentistId { get; set; }
    public Guid PatientId { get; set; }
    public string? Note { get; set; }
    public Status Status { get; set; }

    public Dentist? Dentist { get; set; }
    public Patient? Patient { get; set; }
    public ICollection<Service> Services { get; set; } = new HashSet<Service>();
    public Session? Session { get; set; }

}

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder
            .ToTable("Appointments");

        builder
            .Property(p => p.PatientId)
            .IsRequired();
        builder
            .Property(p => p.DentistId)
            .IsRequired();
        builder
            .Property(p => p.Status)
            .HasDefaultValue(Status.Scheduled);
        builder
            .HasMany(p => p.Services)
            .WithOne(p => p.Appointment);
    }
}
