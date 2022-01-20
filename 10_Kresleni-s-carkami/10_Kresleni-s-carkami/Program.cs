using System;
using Figgle;
using System.Threading;

namespace _10_Kresleni_s_carkami
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new ThreadStart(VypsatCas);
            var bt = new Thread(ts);
            bt.Start();
        }
        static void VypsatCas()
        {
            while (true)
            {
                Console.WriteLine(FiggleFonts.Standard.Render($"{ DateTime.Now.Hour}:{ DateTime.Now.Minute}:{ DateTime.Now.Second}"));
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
