#pragma checksum "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\ContainersReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75765b41881451f9663af263939e2e18988559c2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75765b41881451f9663af263939e2e18988559c2", @"/Views/ContainersReport/Index.cshtml")]
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
			<th>Vessel line/ Container owner</th>
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
			<th");
            WriteLiteral(">Invoice #</th>\r\n\t\t\t<th>Arrival Date</th>\r\n\t\t\t<th>Export Date</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            WriteLiteral(@"	</tbody>
</table>
<link type=""text/css"" rel=""stylesheet"" href=""//cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" />
<link type=""text/css"" rel=""stylesheet"" href=""//cdn.datatables.net/fixedcolumns/3.3.2/css/fixedColumns.dataTables.min.css"" />
<script type=""text/javascript"" src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""//cdn.datatables.net/fixedcolumns/3.3.2/js/dataTables.fixedColumns.min.js""></script>
<script type=""text/javascript"" src=""//editor.datatables.net/extensions/Editor/js/dataTables.editor.min.js""></script>
<script>
	$(document).ready(function () {
		$('#report').DataTable({
			scrollY: ""560px"",
			scrollX: true,
			fixedColumns: {
				leftColumns: 2
			},
			ajax: ""ContainerReport/Report""
		});
	});
</script>");
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
