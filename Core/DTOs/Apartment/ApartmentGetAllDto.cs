namespace Core.DTOs.Apartment;

public class ApartmentGetAllDto
{
    public Guid Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public Guid PropertyId { get; set; }
}