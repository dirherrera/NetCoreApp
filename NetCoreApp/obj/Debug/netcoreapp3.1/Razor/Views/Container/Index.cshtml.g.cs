#pragma checksum "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd48da736c6ee3806d3975c35127797ab6f4b8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Container_Index), @"mvc.1.0.view", @"/Views/Container/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd48da736c6ee3806d3975c35127797ab6f4b8f", @"/Views/Container/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_Container_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
  
	ViewData["Title"] = "Containers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\r\n\t<!-- Add form -->\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd48da736c6ee3806d3975c35127797ab6f4b8f5227", async() => {
                WriteLiteral("\r\n\t\t<h4>Add ");
#nullable restore
#line 12 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<label for=\"name\">Name</label>\r\n\t\t\t<input type=\"text\" id=\"name\" class=\"form-control\" name=\"name\" />\r\n\t\t</div>\r\n\r\n\t\t<button class=\"btn btn-primary\">Add</button>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 218, "/", 218, 1, true);
#nullable restore
#line 11 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
AddHtmlAttributeValue("", 219, ViewBag.Controller, 219, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 238, "/", 238, 1, true);
#nullable restore
#line 11 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
AddHtmlAttributeValue("", 239, ViewBag.AddMethod, 239, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t<!-- Edit form -->\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd48da736c6ee3806d3975c35127797ab6f4b8f8240", async() => {
                WriteLiteral("\r\n\t\t<h4>Edit ");
#nullable restore
#line 24 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
            Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\t\t<input type=\"hidden\" id=\"id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 712, "\"", 720, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

		<div class=""form-group"">
			<label for=""name"">Name</label>
			<input type=""text"" id=""name"" class=""form-control"" name=""name"" />
		</div>

		<button class=""btn btn-primary"">Edit</button>
		<button id=""cancel"" class=""btn btn-danger"">Cancel</button>
	");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 567, "/", 567, 1, true);
#nullable restore
#line 23 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
AddHtmlAttributeValue("", 568, ViewBag.Controller, 568, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 587, "/", 587, 1, true);
#nullable restore
#line 23 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
AddHtmlAttributeValue("", 588, ViewBag.EditMethod, 588, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<hr />\r\n\r\n<h4>");
#nullable restore
#line 40 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<div>\r\n\t<table id=\"table\" class=\"table table-striped table-bordered table-hover\">\r\n\t\t<thead class=\"thead-dark\">\r\n\t\t\t<tr align=\"center\">\r\n\t\t\t\t<th>Name</th>\r\n\t\t\t\t<th>Edit</th>\r\n\t\t\t\t<th>Delete</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
             foreach (var da in ViewBag.Data)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 55 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
                   Write(da.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td align=\"center\">\r\n\t\t\t\t\t\t<button type=\"button\" class=\"edit-data btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1440, "\"", 1476, 5);
            WriteAttributeValue("", 1450, "Edit(\'", 1450, 6, true);
#nullable restore
#line 57 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
WriteAttributeValue("", 1456, da.ID, 1456, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1462, "\',\'", 1462, 3, true);
#nullable restore
#line 57 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
WriteAttributeValue("", 1465, da.Name, 1465, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1473, "\');", 1473, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 58 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
                       Write(Html.Partial("_IconEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td align=\"center\">\r\n\t\t\t\t\t\t<button type=\"button\" class=\"delete-data btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1633, "\"", 1670, 5);
            WriteAttributeValue("", 1643, "Delete(\'", 1643, 8, true);
#nullable restore
#line 62 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
WriteAttributeValue("", 1651, da.ID, 1651, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1657, "\',\'", 1657, 3, true);
#nullable restore
#line 62 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
WriteAttributeValue("", 1660, da.Name, 1660, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1668, "\')", 1668, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 63 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
                       Write(Html.Partial("_IconDelete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 67 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		</tbody>
	</table>
</div>
<link type=""text/css"" rel=""stylesheet"" href=""//cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" />
<script type=""text/javascript"" src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"">
	function Edit(id, name, code) {
		$(""#id"").val(id);
		$(""#edit #name"").val(name);
		$(""#edit"").removeClass(""d-none"");
		$(""#add"").addClass(""d-none"");
	}
	$(""#cancel"").click(function (e) {
		e.preventDefault();
		$(""#add"").removeClass(""d-none"");
		$(""#edit"").addClass(""d-none"");
	});
	function Delete(ID, Name) {
		if (confirm(`Delete ${Name}?`)) {
			window.location = `/");
#nullable restore
#line 87 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
                           Write(ViewBag.Controller);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 87 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Container\Index.cshtml"
                                               Write(ViewBag.DeleteMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("/${ID}`;\r\n\t\t}\r\n\t}\r\n\t$(\"#table\").DataTable({\r\n\t\tscrollY: \'400px\',\r\n\t\tscrollCollapse: true,\r\n\t\tpaging: true\r\n\t});\r\n</script>");
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