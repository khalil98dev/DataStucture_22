using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;



namespace TestDownloadlingWithMulti_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void DownloadString(string URL)
            {
                string Contetnt;

                using (WebClient Client = new WebClient())
                {
                    Contetnt = Client.DownloadString(URL);

                }

                Console.WriteLine($"{URL} Downloaded with {Contetnt.Length} Charechter");


            }

            void DownloadBuildString(string URL)
            {
                StringBuilder Contetnt = new StringBuilder();

                using (WebClient Client = new WebClient())
                {
                    Contetnt.Append(Client.DownloadString(URL));

                }

                Console.WriteLine($"{URL} Downloaded with {Contetnt.Length} Charechter");


            }



            Stopwatch stopwatch = new Stopwatch();  

            
            //Thread T1 = new Thread(() => DownloadString("https://programmingadvices.com"));
            //Thread T2 = new Thread(() => DownloadString("https://www.notion.so"));
            //Thread T3 = new Thread(() => DownloadString("https://www.linkedin.com/learning"));
            //Thread T4 = new Thread(() => DownloadString("https://plateforme-ceil.univ-setif.dz"));
            //Thread T5 = new Thread(() => DownloadString("https://progres.mesrs.dz/epaiement/epaiementH.xhtml"));

            Thread T1 = new Thread(() => DownloadBuildString("https://programmingadvices.com"));
            Thread T2 = new Thread(() => DownloadBuildString("https://www.notion.so"));
            Thread T3 = new Thread(() => DownloadBuildString("https://www.linkedin.com/learning"));
            Thread T4 = new Thread(() => DownloadBuildString("https://plateforme-ceil.univ-setif.dz"));
            Thread T5 = new Thread(() => DownloadBuildString("https://progres.mesrs.dz/epaiement/epaiementH.xhtml"));

            stopwatch.Start();
            T1.Start();
            Console.WriteLine("Thread 1 start"); 
            T2.Start();
            Console.WriteLine("Thread 2 start");
            T3.Start();
            Console.WriteLine("Thread 3 start");
            T4.Start();
            Console.WriteLine("Thread 4 start");
            T5.Start();
            Console.WriteLine("Thread 5 start");


            T1.Join();
            Console.WriteLine("Thread 1 Finish");
            T2.Join();
            Console.WriteLine("Thread 2 Finsh");
            T3.Join();                  
            Console.WriteLine("Thread 3 Finsh");
            T4.Join();                  
            Console.WriteLine("Thread 4 Finsh");
            T5.Join();                  
            Console.WriteLine("Thread 5 Finsh");

            stopwatch.Stop();


            Console.WriteLine($"\n\nDone,All Links Downloaded with time {stopwatch.ElapsedMilliseconds} ms");



            Console.ReadKey();


        }
    }
}