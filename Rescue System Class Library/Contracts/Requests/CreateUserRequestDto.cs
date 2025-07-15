namespace RescueSystem.Contracts.Contracts.Requests;

public class CreateUserRequestDto
{
    public string FullName { get; set; } = null!;
    public DateOnly? DateOfBirth { get; set; }
    public string? MedicalNotes { get; set; }
    public string? EmergencyContact { get; set; }
}
