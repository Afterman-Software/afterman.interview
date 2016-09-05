using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

namespace Afterman.Interview.Problem3
{
    public class EmailService: IHandleMessages<OrderPlaced>, IDisposable
    {
        private IBus emailBus;

        public EmailService()
        {
            if(this.emailBus == null)
                this.emailBus = InitEmailBus();
        }

        private IBus InitEmailBus()
        {
            var busConfig = new BusConfiguration();
            busConfig.EndpointName("Afterman.Interview.EmailService");
            busConfig.UseSerialization<JsonSerializer>();
            busConfig.EnableInstallers();
            busConfig.UsePersistence<InMemoryPersistence>();
            return Bus.Create(busConfig).Start();
        }

        static ILog log = LogManager.GetLogger<EmailService>();

        public void Handle(OrderPlaced message)
        {
            log.Info(String.Format("Handling OrderPlaced: Email sent for Order Id: {0}", message.OrderId));
            // Send email ...
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (emailBus != null)
                    {
                        emailBus.Dispose();
                        disposed = true;
                    }
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
