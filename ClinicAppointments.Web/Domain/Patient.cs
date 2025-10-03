using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAppointments.Web.Domain;

public enum Gender {Male, Female}
public class Patient : User
{
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }

    //Bunlar da duruma göre eklenebilir Önay abiye sor
    //public string? NationalId { get; set; }
    //public string? EmergencyName { get; set; }
    //public string? EmergencyPhoneNumber { get; set; }
    //public string? Adress { get; set; }
    //public string? Allergy { get; set; }
    //public string? ChronicCondition { get; set; }
    //public bool PregnancyStatus { get; set; } = false;
    //public bool SmokingStatus { get; set; } = false;
    //public string? BloodType { get; set; }
}
public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder
            .ToTable("Patients");
    }
}
