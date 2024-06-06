/// <summary>
/// Interface incapsulating strategy
/// </summary>
internal interface ITaxiService
{
    /// <summary>
    /// Strategy to get price from taxi service
    /// </summary>
    /// <param name="startPoint"></param>
    /// <param name="endPoint"></param>
    /// <returns></returns>
    Task<DeliveryRequestOption> GetDeliveryEstimate(AddressInfo startPoint, AddressInfo endPoint);
    /// <summary>
    /// Strategy to create order with taxi service
    /// </summary>
    /// <param name="id"></param>
    /// <param name="startPoint"></param>
    /// <param name="endPoint"></param>
    /// <returns></returns>
    Task<TaxiOrder> CreateOrder(Guid id, AddressInfo startPoint, AddressInfo endPoint);
    /// <summary>
    /// Strategy to cancel order with taxi service
    /// </summary>
    /// <param name="taxiOrderId"></param>
    /// <returns></returns>
    Task CancelOrder(string taxiOrderId);
}
