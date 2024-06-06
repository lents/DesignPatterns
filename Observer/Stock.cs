/// <summary>
/// The 'Publisher' abstract class. 
/// Fluctuating prices will notify investors.
/// Wait for user.
/// </summary>
public abstract class Stock
{
    private string symbol;
    private double price;
    /// <summary>
    /// list of observers(subscribers)
    /// </summary>
    private List<IInvestor> investors = new List<IInvestor>();
    /// <summary>
    /// constructor for publisher
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="price"></param>
    public Stock(string symbol, double price)
    {
        this.symbol = symbol;
        this.price = price;
    }
    /// <summary>
    /// Subscribe method
    /// </summary>
    /// <param name="investor"></param>
    public void Attach(IInvestor investor)
    {
        investors.Add(investor);
    }
    /// <summary>
    /// Unsubscribe mehtod
    /// </summary>
    /// <param name="investor"></param>
    public void Detach(IInvestor investor)
    {
        investors.Remove(investor);
    }
    /// <summary>
    /// Notify subscribers
    /// </summary>
    public void Notify()
    {
        foreach (IInvestor investor in investors)
        {
            investor.Update(this);
        }
        Console.WriteLine("");
    }
    /// <summary>
    /// Gets or sets the price
    /// </summary>
    public double Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                price = value;
                Notify();
            }
        }
    }

    /// <summary>
    /// Gets the symbol
    /// </summary>
    public string Symbol
    {
        get { return symbol; }
    }
}
