using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CoursMultithreading
{
    internal class Program
    {
        static string resultat = "";

        static object _lock = new object();

        static Mutex m1 = new Mutex();
        static void Main(string[] args)
        {
            //Thread ta = new Thread(() => Afficher("A"));
            //ta.Start();
            //Thread tb = new Thread(() => Afficher("B"));
            //tb.Start();
            //Thread tc = new Thread(() => Afficher("C"));
            //tc.Start();
            //ThreadPool.SetMinThreads(2,3);

            //ThreadPool.QueueUserWorkItem((obj) => Afficher("A"));
            //ThreadPool.QueueUserWorkItem((obj) => Afficher("B"));

            //Thread.Sleep(10000);

            //La synchronisation des threads peut se faire à l'aide de la fonction lock

            //La synchronisation des threads peut se faire également par des mutexs

            //La synchronisation des threads peut se faire également par des semaphores
            //Random rand = new Random();
            //SemaphoreSlim semaphore = new SemaphoreSlim(3);
            //int i = 1;
            //while(i <= 10)
            //{

            //    Thread t = new Thread(
            //        () =>
            //        {
            //            int compteur = i;
            //            i++;
            //            semaphore.Wait();
            //            Console.WriteLine($"Le thread numéro {compteur} va commencer");
            //            Console.WriteLine($"Le thread numéro {compteur} est en cours d'execution ");
            //            Thread.Sleep(rand.Next(3000, 5000));
            //            Console.WriteLine($"Le thread numéro {compteur} terminé");
            //            semaphore.Release();
            //        }
            //        );
            //    t.Start();
            //}
            //Utilisation des tasks

            //Task t = new Task(() => Afficher("A"));
            //t.Start();
            Task<string> t = Task.Run(() => ActionWithResult());
            Console.WriteLine(t.Status);
            t.Wait();
            Console.WriteLine(t.Status);
            Console.WriteLine(t.Result);
        }

        static void Afficher(string chaine)
        {
            //lock (_lock)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        resultat += chaine;
            //        Console.WriteLine(resultat);
            //    }
            //}
            //m1.WaitOne();
            for (int i = 1; i <= 10; i++)
            {
                resultat += chaine;
                Console.WriteLine(resultat);
            }
            //m1.ReleaseMutex();
        }

        public static string ActionWithResult()
        {
            Thread.Sleep(3000);
            return "toto";
        }
    }
}
