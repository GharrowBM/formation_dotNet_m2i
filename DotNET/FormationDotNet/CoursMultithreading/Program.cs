using System;
using System.Diagnostics;
using System.Threading;

namespace CoursMultithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread ta = new Thread(() => Afficher("A"));
            //ta.Start();
            //Thread tb = new Thread(() => Afficher("B"));
            //tb.Start();

            ThreadPool.SetMinThreads(2,3);

            ThreadPool.QueueUserWorkItem((obj) => Afficher("A"));
            ThreadPool.QueueUserWorkItem((obj) => Afficher("B"));

            Thread.Sleep(10000);

        }

        static void Afficher(string chaine)
        {
            for(int i = 1; i <= 10000; i++)
            {
                Debug.WriteLine(chaine);
                Console.Write(chaine);
            }
        }
    }
}
