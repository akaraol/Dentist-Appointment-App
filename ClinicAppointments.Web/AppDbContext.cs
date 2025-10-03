using ClinicAppointments.Web.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ClinicAppointments.Web;

public class AppDbContext (DbContextOptions options) : IdentityDbContext<
    User,
    Role,
    Guid,
    IdentityUserClaim<Guid>,
    UserRole,
    IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>,
    IdentityUserToken<Guid>
    >(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public required DbSet<Session> Sessions { get; set; }
    public required DbSet<Room> Rooms { get; set; }
    public required DbSet<Service> Services { get; set; }
    public required DbSet<Dentist> Dentists { get; set; }
    public required DbSet<Appointment> Appointments { get; set; }
    public required DbSet<Patient> Patients { get; set; }



}
