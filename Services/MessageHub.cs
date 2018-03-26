using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRDemoHub.Services
{
    public class MessageHub : Hub
    {

        public  Task SendMessage(string message)
        {
            string timestamp = DateTime.UtcNow.ToString();
            Console.WriteLine($"MessageHub Send Message: {message} at: {timestamp}");
            return Clients.All.SendAsync("SendMessage", new { message, timestamp });

        }
    }
}
