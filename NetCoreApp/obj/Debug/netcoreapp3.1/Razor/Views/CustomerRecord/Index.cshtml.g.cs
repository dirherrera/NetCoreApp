#pragma checksum "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\CustomerRecord\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9d607984f13221aa82c911f95514bfdc5c7e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerRecord_Index), @"mvc.1.0.view", @"/Views/CustomerRecord/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9d607984f13221aa82c911f95514bfdc5c7e87", @"/Views/CustomerRecord/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerRecord_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\CustomerRecord\Index.cshtml"
  
	ViewData["Title"] = "Customer Record";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""form-inline"">
    <button role=""button"" class=""btn btn-primary"">Add</button>
    <div class=""input-group col-3"">
        <input type=""search"" class=""form-control"" id=""search-customer"" placeholder=""Search customer"" />
        <div class=""input-group-append"">
            <button class=""btn btn-outline-secondary"">Search</button>
        </div>
    </div>
</div>

<hr />

<script>

    $(function () {

		$(""#search-customer"").typeahead({
            ajax: '/CustomerRecord/SearchCustomer',
            displayField: ""Name"",
            valueField: ""ID"",
            onSelect: function (item) {
                console.log(item);
			}
		});

    });

    function CustomerRecord(id) {
        $.ajax({
            url: """",
            type: """"
        });
	}

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
