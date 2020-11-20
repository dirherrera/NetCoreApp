#pragma checksum "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\ContainersReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56f1e50acf000b0654a55f141682d2861de49a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContainersReport_Index), @"mvc.1.0.view", @"/Views/ContainersReport/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56f1e50acf000b0654a55f141682d2861de49a3", @"/Views/ContainersReport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_ContainersReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\ContainersReport\Index.cshtml"
  
	//Layout = "~/Views/Shared/_LayoutReport.cshtml";
	ViewData["Title"] = "DeliveryOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table id=""report"" class=""table table-striped"" style=""font-size: small;"">
	<thead class=""thead-dark text-nowrap"">
		<tr>
			<th>No.</th>
			<th>WO</th>
			<th>Port of Arrival</th>
			<th>Vessel line/<br />Container owner</th>
			<th>Export Return Port</th>
			<th>Vessel Line Name</th>
			<th>Customer 1/ Billing Party</th>
			<th>Destination</th>
			<th>Container #</th>
			<th>Size</th>
			<th>OBL/Booking #</th>
			<th>Pier Pass</th>
			<th>Customer Reference</th>
			<th>Weight</th>
			<th>T&E</th>
			<th>Status</th>
			<th>Order Received Date</th>
			<th>Vessel Arrival Date</th>
			<th>Available Date</th>
			<th>Last Free Day/Cut off Date</th>
			<th>Customer Appt Date & Time</th>
			<th>Terminal Pick Up Date</th>
			<th>CXT US Yard Arrival Date</th>
			<th>Crossing Date</th>
			<th>Customer Delivery Date</th>
			<th>Customer E/L Notification Date</th>
			<th>Pick Up Date from Customer</th>
			<th>Perdiem Last Free Day</th>
			<th>Termination Date</th>
			<th>Location</th>
	");
            WriteLiteral(@"		<th>Invoice #</th>
			<th>Arrival Date</th>
			<th>Export Date</th>
		</tr>
	</thead>
	<tbody>
	</tbody>
</table>
<link type=""text/css"" rel=""stylesheet"" href=""//cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" />
<link type=""text/css"" rel=""stylesheet"" href=""//cdn.datatables.net/fixedcolumns/3.3.2/css/fixedColumns.dataTables.min.css"" />
<script type=""text/javascript"" src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""//cdn.datatables.net/fixedcolumns/3.3.2/js/dataTables.fixedColumns.min.js""></script>
<script type=""text/javascript"" src=""//editor.datatables.net/extensions/Editor/js/dataTables.editor.min.js""></script>
<script>
	$(document).ready(function () {
		var report = $('#report').DataTable({
			scrollY: ""560px"",
			scrollX: true,
			fixedColumns: {
				leftColumns: 2
			},
			ajax: ""api/ContainerReport/Get""
		});

		$(""#report tbody"").on(""click"", ""tr"", function (e) {
			var td = e.target;
			var rep = report;
		");
            WriteLiteral(@"	var i = $(td).index();
			var row = this;
			var data = report.row(this).data();
			var value = $(td).text().trim();
			var input = $(`<input type=""text"" value=""${value}"" class=""temp-edit"">`);
			$(td).html('').append(input);
			$(input).blur(function () {
				$(td).text($(this).val());
				$(this).remove();
				data[i] = $(input).val();
				rep.row(row).data(data).draw();
				data = rep.row(row).data();
				Edit(rep.row(row).data());
				console.log(rep.row(row).data());
			});
			$(input).focus();
		});

		function Edit(data) {
			var rep = report;
			var cr = new Object();
			cr.wo = data[1];
			cr.portOfArrival = data[2];
			cr.vesselLineContainerOwner = data[3];
			cr.exportReturnPort = data[4];
			cr.vesselLineName = data[5];
			cr.customer1BillingParty = data[6];
			cr.destination = data[7];
			cr.containerNo = data[8];
			cr.size = data[9];
			cr.oblBooking = data[10];
			cr.pierPass = data[11];
			cr.customerReference = data[12];
			cr.weight = data[13];
			cr.te = ");
            WriteLiteral(@"data[14];
			cr.status = data[15];
			cr.orderReceivedDate = data[16];
			cr.vesselArrivalDate = data[17];
			cr.availableDate = data[18];
			cr.lastFreeDate = data[19];
			cr.customerApptDate = data[20];
			cr.terminalPickupDate = data[21];
			cr.cxtusYardArrivalDate = data[22];
			cr.crossingDate = data[23];
			cr.customerDeliveryDate = data[24];
			cr.customerNotificationDate = data[25];
			cr.customerPickupDate = data[26];
			cr.perdiemLastFreeDay = data[27];
			cr.terminationDate = data[28];
			cr.location = data[29];
			cr.invoice = data[30];
			cr.arrivalDate = data[31];
			cr.exportDate = data[32];
			cr.rowNo = data[0];
			cr.id = data[33];
			var json = ajaxJson(cr);
			console.log(json);
			//$.ajax({
			//	url: ""api/ContainerReport/Edit"",
			//	type: ""post"",
			//	data: ,
			//	dataType: ""json"",
			//	contentType: ""application/json;charset=utf8"",
			//	success: function (data) {
			//		console.log(data);
			//		console.log(rep);
			//	}
			//});
		}

		function ");
            WriteLiteral("ajaxJson(obj) {\r\n\t\t\tvar json = \"\";\r\n\t\t\tvar u = \"\";\r\n\t\t\tfor (x in obj) {\r\n\t\t\t\tjson += `\"${u}${x}\" = \"${obj[x]}\"`;\r\n\t\t\t\tu = \",\";\r\n\t\t\t}\r\n\t\t\treturn `{${json}}`\r\n\t\t}\r\n\t});\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591