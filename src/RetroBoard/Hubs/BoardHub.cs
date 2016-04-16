using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace RetroBoard.Hubs
{

    [HubName("boardHub")]
    public class BoardHub : Hub
    {
        [HubMethodName("sendUpdate")]
        public void SendUpdate(string boardId, string categoryId, string cardId, string cardText)
        {
            Thread.Sleep(1000);

            Clients.All.broadcastMessage(boardId, categoryId, cardId, cardText);
        }


        public override Task OnConnected() //override OnConnect, OnReconnected and OnDisconnected  to know if a user is connected or disconnected 
        { 
            //UserHandler.ConnectedIds.Add(Context.ConnectionId); //add a connection id to the list 
            //Clients.All.usersConnected(UserHandler.ConnectedIds.Count()); //this will send to ALL the clients the number of users connected 
            return base.OnConnected(); 
        } 
  
        public override Task OnReconnected()
        { 
            //UserHandler.ConnectedIds.Add(Context.ConnectionId); 
            //Clients.All.usersConnected(UserHandler.ConnectedIds.Count()); 
            return base.OnReconnected(); 
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            //UserHandler.ConnectedIds.Remove(Context.ConnectionId); 
            //Clients.All.usersConnected(UserHandler.ConnectedIds.Count()); 
            return base.OnDisconnected(stopCalled); 
        } 

    }
}
