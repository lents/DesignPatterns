/// <summary>
/// strategies to work with Yandex taxi company
/// </summary>
public class YandexTaxiService : ITaxiService
{
    public async Task<TaxiOrder> CreateOrder(Guid id, AddressInfo startPoint, AddressInfo endPoint)
    {
        Console.WriteLine("Make an API call to Create Order in Yandex Taxi");
        return new TaxiOrder();
    }

   
    public async Task CancelOrder(string taxiOrderId)
    {   Console.WriteLine("Make an API call to Cancel Order in Yandex Taxi");
    }

    public async Task<DeliveryRequestOption> GetDeliveryEstimate(AddressInfo startPoint, AddressInfo endPoint)
    {
        Console.WriteLine("Make an API call to Ask Price in Yandex Taxi");
        return new DeliveryRequestOption { Price = 200, TaxiName ="Yandex" };
    }

   
    private static HttpClient CreateClient()
    {
        var client = new HttpClient();
        return client;
    }
}