using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Hubs
{
	public class NotificationsHub : Hub
	{
		public async Task SendNotification(string notification)
		{
			await Clients.All.SendAsync("NewNotification", notification);
		}
	}
}
