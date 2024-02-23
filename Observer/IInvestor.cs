// Fluctuating prices will notify investors
// Wait for user
/// <summary>
/// The 'Observer' interface
/// </summary>
public interface IInvestor
{
    void Update(Stock stock);
}
