using Microsoft.AspNetCore.Identity;

namespace ClinicAppointments.Web.Domain;

public class Role : IdentityRole<Guid>
{
    public required string DisplayName { get; set; }
}
