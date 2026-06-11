using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_01
{
	class RailwayStation
	{
		private string stationName;
		private double ticketCost;
		private int seatCount;
		private int ticketSoldCount;
		public RailwayStation()
		{
			stationName = "Lab_01";
			ticketCost = 0;
			seatCount = 0;
			ticketSoldCount = 0;
		}
		public string StationName
		{
			set {stationName = value;}
			get {return stationName;}
		}
		public double TicketCost
		{
			set {ticketCost = value;}
			get {return ticketCost;}
		}
		public int SeatCount
		{
			set {seatCount = value;}
		}
		public int TicketSoldCount
		{
			set {ticketSoldCount = value;}
			get {return ticketSoldCount;}
		}
		public double TicketUnsoldRevenue()
		{
			double ticketUnsoldRevenue = 0;
			ticketUnsoldRevenue = (seatCount-ticketSoldCount)*ticketCost;
			return ticketUnsoldRevenue;
		}
	}
}
