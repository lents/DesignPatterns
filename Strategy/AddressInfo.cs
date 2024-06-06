/// <summary>
/// Customer address
/// </summary>
public class AddressInfo
{
    public string Address { get; set; } //Строка адреса (для обогащения данных используется сервис DaData)
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}