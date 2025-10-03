namespace ClinicAppointments.Web.Domain;

public class EntityBase
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public bool IsEnabled { get; set; } = true;
}
