using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class ContainerReport
	{

		public static List<ContainerReport> Get()
		{
			List<ContainerReport> list = new List<ContainerReport>();
			string query = $"Select * From ContainerReport";
			DataTable table = DataAccess.Fill(query);
			list = DataTableAdapter.Get<ContainerReport>(table);
			return list;
		}

		public static ContainerReport Get(string id)
		{
			string query = $"Select * From ContainerReport Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			ContainerReport containerReport = DataTableAdapter.Get<ContainerReport>(table)[0];
			return containerReport;
		}

		public static void Update(string id, string wo, string portOfArrival, string vesselLineContainerOwner, string exportReturnPort, string vesselLineName,
			string customer1BillingParty, string destination, string containerNo, string size, string oblBooking, string pierPass, string customerReference,
			string weight, string te, string status, string orderReceivedDate, string vesselArrivalDate, string availableDate, string lastFreeDate,
			string customerApptDate, string terminalPickupDate, string cxtusYardArrivalDate, string crossingDate, string customerDeliveryDate,
			string customerNotificationDate, string customerPickupDate, string perdiemLastFreeDay, string terminationDate, string location,
			string invoice, string arrivalDate, string exportDate)
		{
			string query = $"Update ContainerReport " +
				$"SET WO = '{wo}', PortOfArrival = '{portOfArrival}',  VesselLineContainerOwner = '{vesselLineContainerOwner}', " +
				$"ExportReturnPort = '{exportReturnPort}', VesselLineName = '{vesselLineName}', Customer1BillingParty = '{customer1BillingParty}', " +
				$"Destination = '{destination}', ContainerNo = '{containerNo}', Size = '{size}', OBLBooking = '{oblBooking}', PierPass = '{pierPass}', " +
				$"CustomerReference = '{customerReference}', Weight = '{weight}', TE = '{te}', Status = '{status}', OrderReceivedDate = '{orderReceivedDate}', " +
				$"VesselArrivalDate = '{vesselArrivalDate}', AvailableDate = '{availableDate}', LastFreeDate = '{lastFreeDate}', CustomerApptDate = '{customerApptDate}', " +
				$"TerminalPickUpDate = '{terminalPickupDate}', CXTUSYardArrivalDate = '{cxtusYardArrivalDate}', CrossingDate = '{crossingDate}', " +
				$"CustomerDeliveryDate = '{customerDeliveryDate}', CustomerNotificationDate = '{customerNotificationDate}', CustomerPickUpDate = '{customerPickupDate}', " +
				$"PerdiemLastFreeDay = '{perdiemLastFreeDay}', TerminationDate = '{terminationDate}', Location = '{location}', Invoice = '{invoice}', " +
				$"ArrivalDate = '{arrivalDate}', ExportDate = '{exportDate}', Modified" +
				$"WHERE ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static List<object> ToArray(List<ContainerReport> list)
		{
			List<object> records = new List<object>();
			PropertyInfo[] properties = typeof(ContainerReport).GetProperties();
			int total = list.Count;
			foreach (ContainerReport report in list)
			{
				List<object> row = new List<object>();
				row.Add(total);
				total--;
				row.Add(report.WO);
				row.Add(report.PortOfArrival);
				row.Add(report.VesselLineContainerOwner);
				row.Add(report.ExportReturnPort);
				row.Add(report.VesselLineName);
				row.Add(report.Customer1BillingParty);
				row.Add(report.Destination);
				row.Add(report.ContainerNo);
				row.Add(report.Size);
				row.Add(report.OBLBooking);
				row.Add(report.PierPass);
				row.Add(report.CustomerReference);
				row.Add(report.Weight);
				row.Add(report.TE);
				row.Add(report.Status);
				row.Add(report.OrderReceivedDate);
				row.Add(report.VesselArrivalDate);
				row.Add(report.AvailableDate);
				row.Add(report.LastFreeDate);
				row.Add(report.CustomerApptDate);
				row.Add(report.TerminalPickUpDate);
				row.Add(report.CXTUSYardArrivalDate);
				row.Add(report.CrossingDate);
				row.Add(report.CustomerDeliveryDate);
				row.Add(report.CustomerNotificationDate);
				row.Add(report.CustomerPickUpDate);
				row.Add(report.PerdiemLastFreeDay);
				row.Add(report.TerminationDate);
				row.Add(report.Location);
				row.Add(report.Invoice);
				row.Add(report.ArrivalDate);
				row.Add(report.ExportDate);
				row.Add(report.ID);
				records.Add(row);
			}
			return records;
		}

		public static List<object> ToArray(ContainerReport containerReport, int rowNo)
		{
			List<object> row = new List<object>();
			row.Add(rowNo);
			row.Add(containerReport.WO);
			row.Add(containerReport.PortOfArrival);
			row.Add(containerReport.VesselLineContainerOwner);
			row.Add(containerReport.ExportReturnPort);
			row.Add(containerReport.VesselLineName);
			row.Add(containerReport.Customer1BillingParty);
			row.Add(containerReport.Destination);
			row.Add(containerReport.ContainerNo);
			row.Add(containerReport.Size);
			row.Add(containerReport.OBLBooking);
			row.Add(containerReport.PierPass);
			row.Add(containerReport.CustomerReference);
			row.Add(containerReport.Weight);
			row.Add(containerReport.TE);
			row.Add(containerReport.Status);
			row.Add(containerReport.OrderReceivedDate);
			row.Add(containerReport.VesselArrivalDate);
			row.Add(containerReport.AvailableDate);
			row.Add(containerReport.LastFreeDate);
			row.Add(containerReport.CustomerApptDate);
			row.Add(containerReport.TerminalPickUpDate);
			row.Add(containerReport.CXTUSYardArrivalDate);
			row.Add(containerReport.CrossingDate);
			row.Add(containerReport.CustomerDeliveryDate);
			row.Add(containerReport.CustomerNotificationDate);
			row.Add(containerReport.CustomerPickUpDate);
			row.Add(containerReport.PerdiemLastFreeDay);
			row.Add(containerReport.TerminationDate);
			row.Add(containerReport.Location);
			row.Add(containerReport.Invoice);
			row.Add(containerReport.ArrivalDate);
			row.Add(containerReport.ExportDate);
			row.Add(containerReport.ID);
			return row;
		}

	}
}
