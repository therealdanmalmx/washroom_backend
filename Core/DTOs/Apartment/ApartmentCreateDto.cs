namespace Core.DTOs.Apartment;

public class ApartmentCreateDto
{
    public string Number { get; set; } = string.Empty;
    public Guid PropertyId { get; set; }
}