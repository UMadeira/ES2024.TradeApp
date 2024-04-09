namespace TradeApp
{
    public class TradeProcessor
    {
        public TradeProcessor( ITradeDataProvider provider, ITradeStore store, ITradeParser parser ) 
        { 
            Provider = provider;
            Store = store;
            Parser = parser;
        }

        private ITradeDataProvider Provider { get; }
        private ITradeStore Store { get; }

        private ITradeParser Parser { get; }

        public void ProcessTrades()
        {
            var lines = Provider.GetTradeData();
            var trades = Parser.Parse( lines );
            Store.Persist( trades );

            Console.WriteLine("INFO: {0} trades processed", trades.Count() );
        }

    }
}