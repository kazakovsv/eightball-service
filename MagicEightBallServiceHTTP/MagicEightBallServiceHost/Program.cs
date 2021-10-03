using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host *****");

            using (ServiceHost serviceHost =
                new ServiceHost(typeof(MagicEightBallService)))
            {
                // Открыть хост и начать прослушивание входящих сообщений.
                serviceHost.Open();
                DisplayHostInfo(serviceHost);

                // Оставить службу функционирующей до тех пор,
                // пока не будет нажата клавиша <Enter>.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");

            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", endpoint.Address);
                Console.WriteLine("Binding: {0}", endpoint.Binding.Name);
                Console.WriteLine("Contract: {0}", endpoint.Contract.Name);
                Console.WriteLine();
            }

            Console.WriteLine("*********************");
        }
    }
}
