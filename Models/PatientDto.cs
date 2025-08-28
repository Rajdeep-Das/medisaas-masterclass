public class PatientDto
{
    [Phi("Identifier")]
    public string? PatientId { get; set; }

    [Phi("Name")]
    public string? FirstName { get; set; }

    [Phi("Name")]
    public string? LastName { get; set; }

    [Phi("Contact")]
    public string? Email { get; set; }

    [Phi("Contact")]
    public string? Phone { get; set; }

    [Phi("Clinical")]
    public string? Diagnosis { get; set; }

    public int Age { get; set; }
}
