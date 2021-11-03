using System;
using System.Text;
using System.Threading.Tasks;
using IndustrialProtocol.Controllers;

namespace IndustrialProtocol
{
    class Program
    {
        static int boPru = 0;
        static Lab rose = new Lab();
        static Random random = new Random(4);
        static void prue(byte[] payback, bool err)
        {
            if (err)
            {
                string str = Encoding.Default.GetString(payback);
                Console.WriteLine(str);
            }
            else
                Console.WriteLine("Error!");
        }
        static void Main(string[] args)
        {
            Pro1();
        }
        static async void Pro()
        {
            var protocol = new Protocol();
            int inStart = random.Next(0,4956);
            int inLengt = random.Next(1,20);
            protocol.get(inStart, inLengt, prue);
        }
        static async void Pro1()
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                Pro();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
