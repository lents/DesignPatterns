/// <summary>
/// Dto to make order 
/// </summary>
public class TaxiOrder
{
    public string OrderInfo { get; set; }
    public Guid Id { get; set; }
    public int? EtaPoint { get; set; }
    public int? EtaClient { get; set; }
    public Guid? AcceptedByCourierUserId { get; set; }
    public DateTimeOffset AcceptedTimeStamp { get; set; }
    public int CurrentStatus { get; set; }
}