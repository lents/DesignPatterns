///context
var taxiServices = new List<ITaxiService>();
var maximTaxiService = new MaximTaxiService();
var yandexTaxiService = new YandexTaxiService();
taxiServices.Add(yandexTaxiService);
taxiServices.Add(maximTaxiService);

var startPoint = new AddressInfo { Address = "My start Address" };
var endPoint = new AddressInfo { Address = "My end Address" };

var taxiCalls = new List<Task<DeliveryRequestOption>>();
foreach (var service in taxiServices)
{
    taxiCalls.Add(service.GetDeliveryEstimate(startPoint, endPoint));
}
var results = await Task.WhenAll(taxiCalls);
Console.WriteLine(string.Join(", ", results.Select(r=> $"{r.TaxiName} costs {r.Price}").ToList()));
// Wait for user
Console.ReadKey();
