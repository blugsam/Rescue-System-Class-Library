namespace RescueSystem.Contracts.Contracts.Responses;

public class UserDetailsDto : UserSummaryDto
{
    public DateOnly? DateOfBirth { get; set; }
    public string? MedicalNotes { get; set; }
    public string? EmergencyContact { get; set; }
}