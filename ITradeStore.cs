namespace TradeApp
{
    public interface ITradeStore
    {
        void Persist( IEnumerable<TradeRecord> trades );
    }
}
