using System;
using System.Text;
using System.Threading.Tasks;
using IndustrialProtocol.Controllers;

namespace IndustrialProtocol
{
    class Program
    {
        static int boPru = 0;
        static Random random = new Random(4);
        static void demoFunction(byte[] payback, bool err)
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
            asyncListener();
        }
        static async void TestRequest()
        {
            var crtProtocol = new Protocol();
            int inStart = random.Next(0,4956);
            int inLengt = random.Next(1,20);
            crtProtocol.get(inStart, inLengt, demoFunction);
        }
        static async void asyncListener()
        {
            //Exec a test request when push any key
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                TestRequest();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
