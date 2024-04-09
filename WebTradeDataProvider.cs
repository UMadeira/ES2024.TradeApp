namespace TradeApp
{
    public class WebTradeDataProvider : ITradeDataProvider
    {
        public WebTradeDataProvider( string url ) 
        { 
            Url = url;
        }

        private string Url { get; }

        public IEnumerable<string> GetTradeData()
        {
            //...
            return new[ ] { "", "" };
        }
    }
}
