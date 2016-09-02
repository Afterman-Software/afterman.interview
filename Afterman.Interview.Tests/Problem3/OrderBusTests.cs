using Afterman.Interview.Problem3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Afterman.Interview.Tests.Problem3
{
    [TestClass]    
    public class OrderBusTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public void OrderSendAndEmailReceivedTest()
        {
            // NOTE:  executing this integration test requires locally installed Microsoft MQ Server
            // On Windows 7, run this command to install MSMQ:  DISM.exe /Online /NoRestart /English /Enable-Feature /FeatureName:MSMQ-Container /FeatureName:MSMQ-Server
            // On Windows 8.x & 10, run this command to install MSMQ:  DISM.exe /Online /NoRestart /English /Enable-Feature /all /FeatureName:MSMQ-Server

            // arrange            
            MockOnlineStore store = new MockOnlineStore();
            MockOrderManagementService oms = new MockOrderManagementService();
            MockSupplyChainService supplyChainService = new MockSupplyChainService();

            // act
            store.PlaceOrder("wiley.e.coyote@acme.com", "TnT5000");

            // assert
            bool actual = false;
            if (MockSupplyChainService.EmailSender.EmailSentEvent.WaitOne(TimeSpan.FromSeconds(30)))
                actual = true;
            
            store.Dispose();
            oms.Dispose();
            supplyChainService.Dispose();

            Assert.IsTrue(actual);
        }        
    }
}
