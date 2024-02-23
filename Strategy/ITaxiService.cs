using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

internal interface ITaxiService
{
    Task<DeliveryRequestOption> GetDeliveryEstimate(AddressInfo startPoint, AddressInfo endPoint);
    Task<TaxiOrder> CreateOrder(Guid id, AddressInfo startPoint, AddressInfo endPoint);
    Task CancelOrder(string taxiOrderId);

}
