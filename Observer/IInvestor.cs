
/// <summary>
/// The 'Observer' interface.
/// Fluctuating prices will notify investors. 
/// Wait for notification from publisher. 
/// </summary>
public interface IInvestor
{
    void Update(Stock stock);
}
