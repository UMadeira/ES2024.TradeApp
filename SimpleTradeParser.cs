namespace TradeApp
{
    public class SimpleTradeParser : ITradeParser
    {
        public SimpleTradeParser( ITradeValidator validator, ITradeMapper mapper ) 
        { 
            Validator = validator;
            Mapper = mapper;
        }

        ITradeValidator Validator { get;}
        ITradeMapper Mapper { get;}

        public IEnumerable<TradeRecord> Parse( IEnumerable<string> lines )
        {
            var trades = new List<TradeRecord>();
            var lineCount = 1;
            foreach ( var line in lines )
            {
                var fields = line.Split( new char[] { ',' } );
                if ( ! Validator.Validate( fields, lineCount ) ) continue;

                var trade = Mapper.Map( fields );
                trades.Add( trade );

                lineCount++;
            }

            return trades;
        }

    }
}
