namespace TradeApp
{
    public interface ITradeValidator
    {
        bool Validate( string[ ] fields, int lineCount );
    }
}
