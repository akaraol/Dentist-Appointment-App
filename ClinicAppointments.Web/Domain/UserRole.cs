using Microsoft.AspNetCore.Identity;

namespace ClinicAppointments.Web.Domain
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public User? User { get; set; }
        public Role? Role { get; set; }
    }

}
