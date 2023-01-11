using Fiotec_exc.Repositories;

namespace Fiotec_exc
{
    public class Program
    {
        public static void Main(string[] args)
        {

            LerArquivo ler = new LerArquivo();
            ler.Lerarquivo();

            Console.ReadKey();
        }

    }
}