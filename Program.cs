
namespace TradeApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("TradeApp v1.0!");

            using var stream = File.OpenRead( "TradeData.txt" );

            var provider = new FileTradeDataProvider( stream );
            var store = new JsonTradeStore();

            var validator = new SimpleTradeValidator();
            var mapper = new SimpleTradeMapper();
            var parser = new SimpleTradeParser( validator, mapper );

            var processor = new TradeProcessor( provider, store, parser );
            processor.ProcessTrades();
        }
    }
}