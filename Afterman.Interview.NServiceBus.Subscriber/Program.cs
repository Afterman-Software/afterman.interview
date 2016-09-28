using System;
using NServiceBus;

namespace Afterman.Interview.NServiceBus.Subscriber
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.Title = "Samples.StepByStep.Subscriber";
            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName( "Samples.StepByStep.Subscriber" );
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.EnableInstallers();
            busConfiguration.UsePersistence<InMemoryPersistence>();

            using ( var bus = Bus.Create( busConfiguration ).Start() )
            {
                Console.WriteLine( "Press any key to exit" );
                Console.ReadKey();
            }

        }
    }
}
