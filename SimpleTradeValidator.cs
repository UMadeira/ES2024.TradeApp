namespace TradeApp
{
    public class SimpleTradeValidator : ITradeValidator
    {
        public bool Validate( string[ ] fields, int lineCount )
        {
            if ( fields.Length != 3 )
            {
                Console.WriteLine( "WARN: Line {0} malformed. Only {1} field(s) found.",
                lineCount, fields.Length );
                return false;
            }
            if ( fields[0].Length != 6 )
            {
                Console.WriteLine( "WARN: Trade currencies on line {0} malformed: '{1}'",
                lineCount, fields[0] );
                return false;
            }
            if ( !int.TryParse( fields[1], out int amount ) )
            {
                Console.WriteLine( "WARN: Trade amount on line {0} not a valid integer: '{1}'", lineCount, fields[1] );
                return false;
            }
            if ( ! decimal.TryParse( fields[2], out decimal price ) )
            {
                Console.WriteLine( "WARN: Trade price on line {0} not a valid decimal: '{1}'", lineCount, fields[2] );
                return false;
            }
            return true;
        }
    }
}
