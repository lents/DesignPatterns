/// <summary>
/// DTO for customer to choose better taxi
/// </summary>
public class DeliveryRequestOption
{
    public decimal Price { get; set; }
    public int Duration { get; set; }
    public decimal EstimatedArrivalTimeInMinutes { get; set; }
    public string TaxiName { get; set; }
}