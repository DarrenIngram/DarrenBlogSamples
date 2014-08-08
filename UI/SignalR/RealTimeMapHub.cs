using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace DarrenBlogSamples.UI.SignalR
{
    public class RealTimeMapHub : Hub
    {
        public void Send(string name, string stateFipsCode, string color, string note)
        {
            Clients.All.mapUpdate(name, stateFipsCode, color, note);
        }
    }
}