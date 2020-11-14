using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class ContainerReport
	{

		public Guid ID { get; set; }
		public string WO { get; set; }
		public string PortOfArrival { get; set; }
		public string VesselLineContainerOwner { get; set; }
		public string ExportReturnPort { get; set; }
		public string VesselLineName { get; set; }
		public string Customer1BillingParty { get; set; }
		public string Destination { get; set; }
		public string ContainerNo { get; set; }
		public string Size { get; set; }
		public string OBLBooking { get; set; }
		public string PierPass { get; set; }
		public string CustomerReference { get; set; }
		public string Weight { get; set; }
		public string TE { get; set; }
		public string Status { get; set; }
		public string OrderReceivedDate { get; set; }
		public string VesselArrivalDate { get; set; }
		public string AvailableDate { get; set; }
		public string LastFreeDat { get; set; }
		public string CustomerApptDate { get; set; }
		public string TerminalPickUpDate { get; set; }
		public string CXTUSYardArrivalDate { get; set; }
		public string CrossingDate { get; set; }
		public string CustomerDeliveryDate { get; set; }
		public string CustomerNotificationDate { get; set; }
		public string CustomerPickUpDate { get; set; }
		public string PerdiemLastFreeDay {get;set;}
		public string TerminationDate { get; set; }
		public string Location { get; set; }
		public string Invoice { get; set; }
		public string ArrivalDate { get; set; }
		public string ExportDate { get; set; }


	}
}
