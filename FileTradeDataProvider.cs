namespace TradeApp
{
    public class FileTradeDataProvider : ITradeDataProvider
    {
        public FileTradeDataProvider( Stream stream ) 
        { 
            Stream = stream;
        }

        private Stream Stream { get; }

        public IEnumerable<string> GetTradeData()
        {
            var lines = new List<string>();
            using ( var reader = new StreamReader( Stream ) )
            {
                string line;
                while ( ( line = reader.ReadLine() ) != null )
                {
                    lines.Add( line );
                }
            }
            return lines;
        }
    }
}
