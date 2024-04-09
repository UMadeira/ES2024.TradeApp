namespace TradeApp
{
    public class FileTradeStore : ITradeStore
    {
        public FileTradeStore( string filename ) 
        { 
        }

        private string Filename { get; }

        public void Persist( IEnumerable<TradeRecord> trades )
        {
            //..
        }
    }
}
