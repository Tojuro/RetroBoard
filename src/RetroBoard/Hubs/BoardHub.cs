using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace RetroBoard.Hubs
{
    public class BoardHub : Hub
    {
        public void HandleProductMessage(string receivedString)
        {
            var responseString = string.Empty;

            //bool dataProcessedSuccessfully =
            //    ProductMessageHandler.HandleMessage(receivedString, ref responseString);

            Thread.Sleep(1000);

            if (true)
            {
                Clients.All.handleProductMessage(responseString);
            }
            else
            {
                Clients.Caller.handleProductMessage(responseString);
            }
        }
    }
}
