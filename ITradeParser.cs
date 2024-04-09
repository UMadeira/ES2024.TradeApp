namespace TradeApp
{
    public interface ITradeParser
    {
        IEnumerable<TradeRecord> Parse( IEnumerable<string> lines );
    }
}
