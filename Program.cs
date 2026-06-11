using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_01
{
	class Program
	{
		static void Main(string[] args)
		{
			RailwayStation lab_01 = new RailwayStation();
			Console.WriteLine ("Default railway name: " + lab_01.StationName);
			Console.WriteLine ("Default ticket cost: " + lab_01.TicketCost);
			Console.WriteLine ("Default ticket cost: " + lab_01.TicketSoldCount);
			lab_01.TicketCost = 150;
			lab_01.SeatCount = 2000;
			lab_01.TicketSoldCount = 1483;
			Console.WriteLine ("New ticket cost: " + lab_01.TicketCost);
			Console.WriteLine ("New ticket cost: " + lab_01.TicketSoldCount);
			Console.WriteLine ("Unsold ticket revenue: " + lab_01.TicketUnsoldRevenue());
			Console.ReadKey();
		}
	}
}
