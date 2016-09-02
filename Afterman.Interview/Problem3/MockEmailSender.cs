using System.Threading;

namespace Afterman.Interview.Problem3
{
    public class MockEmailSender
    {
        public ManualResetEvent EmailSentEvent { get; private set; }

        public MockEmailSender()
        {
            this.EmailSentEvent = new ManualResetEvent(false);
        }
    }
}
