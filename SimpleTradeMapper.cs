namespace TradeApp
{
    public class SimpleTradeMapper : ITradeMapper
    {
        public TradeRecord Map( string[ ] fields )
        {
            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);
            var tradeAmount = int.Parse( fields[1] );
            var tradePrice = decimal.Parse( fields[2] );

            // calculate values
            return new TradeRecord {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };
        }

        private static float LotSize = 100000f;
    }
}
