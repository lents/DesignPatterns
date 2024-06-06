/// <summary>
/// strategies to work with Maxim taxi company
/// </summary>
public class MaximTaxiService : ITaxiService
{
    public async Task<TaxiOrder> CreateOrder(Guid id, AddressInfo startPoint, AddressInfo endPoint)
    {
       // var internalId = Guid.NewGuid();
        //var createdOrder =
        //     await HttpClientHelper.Post<OrderMaximResponse>(BASE_API + CREATE_UPDATE_REQUEST_URL, order.ToTaxiModel(internalId, TARIFF), CreateClient());
        Console.WriteLine("Make an API call to Create Order in Maxim Taxi");
        return new TaxiOrder();
    }

   
    public async Task CancelOrder(string taxiOrderId)
    {
        //var requestUrl = "set_status?order_id=" + taxiOrderId + "&status=" + "Cancelled";
        //await HttpClientHelper.Post<BaseMaximResponse>(BASE_API + requestUrl, null, CreateClient());
        Console.WriteLine("Make an API call to Cancel Order in Maxim Taxi");
    }

    public async Task<DeliveryRequestOption> GetDeliveryEstimate(AddressInfo startPoint, AddressInfo endPoint)
    {
        //var deliveryResponse =
        //    await HttpClientHelper.Post<DeliveryMaximResponse>(BASE_API + PRICE_REQUEST_URL, deliveryPointRequest.ToTaxiModel(TARIFF), CreateClient());
        Console.WriteLine("Make an API call to Ask Price in Maxim Taxi");
        return new DeliveryRequestOption { Price = 100, TaxiName="Maxim" };
    }

   
    private static HttpClient CreateClient()
    {
        var client = new HttpClient();
        //client.DefaultRequestHeaders.Accept.Clear();
        //client.DefaultRequestHeaders.Accept.Add(
        //    new MediaTypeWithQualityHeaderValue("application/json"));
        //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
        //client.DefaultRequestHeaders.Add("X-API-KEY", API_KEY);
        return client;
    }
}