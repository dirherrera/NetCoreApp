#pragma checksum "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d26fe32bcc9fcbd167373da575d1ec1ff41a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Index), @"mvc.1.0.view", @"/Views/Configuration/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d26fe32bcc9fcbd167373da575d1ec1ff41a6b", @"/Views/Configuration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Configuration/AddData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Configuration/EditData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
  
	ViewData["Title"] = "Configuracion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n\t<div>\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53d26fe32bcc9fcbd167373da575d1ec1ff41a6b5998", async() => {
                WriteLiteral(@"
			<h4>Add Class</h4>
			<div class=""form-group"">
				<label for=""Name"">Name</label>
				<input type=""text"" id=""Name"" class=""form-control"" name=""Name"" />
			</div>
			<div class=""form-group"">
				<label for=""Description"">Description</label>
				<input type=""text"" id=""Description"" class=""form-control"" name=""Description"" />
			</div>
			<button class=""btn btn-primary"">Add</button>
		");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53d26fe32bcc9fcbd167373da575d1ec1ff41a6b8101", async() => {
                WriteLiteral("\r\n\t\t\t<h4>Edit Class</h4>\r\n\t\t\t<input type=\"hidden\" id=\"ID\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 837, "\"", 845, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
			<div class=""form-group"">
				<label for=""Name"">Name</label>
				<input type=""text"" id=""Name"" class=""form-control"" name=""Name"" />
			</div>
			<div class=""form-group"">
				<label for=""Description"">Description</label>
				<input type=""text"" id=""Description"" class=""form-control"" name=""Description"" />
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	</div>

	<hr />

	<h4>Classes</h4>

	<div>
		<table class=""table table-striped table-bordered table-hover"">
			<thead class=""thead-dark"">
				<tr align=""center"">
					<th>Name</th>
					<th>Description</th>
					<th>Editar</th>
					<th>Eliminar</th>
				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 54 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
                 foreach (Data da in ViewBag.Data)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 57 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
                   Write(da.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 58 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
                   Write(da.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td align=\"center\">\r\n\t\t\t\t\t\t<button type=\"button\" class=\"edit-data btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1796, "\"", 1850, 7);
            WriteAttributeValue("", 1806, "Edit(\'", 1806, 6, true);
#nullable restore
#line 60 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
WriteAttributeValue("", 1812, da.ID, 1812, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1818, "\',\'", 1818, 3, true);
#nullable restore
#line 60 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
WriteAttributeValue("", 1821, da.Name, 1821, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1829, "\',\'", 1829, 3, true);
#nullable restore
#line 60 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
WriteAttributeValue("", 1832, da.Description, 1832, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "\');", 1847, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
							<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-pencil-square"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
								<path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z""></path>
								<path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z""></path>
							</svg>
						</button>
					</td>
					<td align=""center"">
						<button type=""button"" class=""delete-data btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 2596, "\"", 2633, 5);
            WriteAttributeValue("", 2606, "Delete(\'", 2606, 8, true);
#nullable restore
#line 68 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
WriteAttributeValue("", 2614, da.ID, 2614, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2620, "\',\'", 2620, 3, true);
#nullable restore
#line 68 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
WriteAttributeValue("", 2623, da.Name, 2623, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2631, "\')", 2631, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
							<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-trash"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
								<path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z""></path>
								<path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z""></path>
							</svg>
						</button>
					</td>
				</tr>
");
#nullable restore
#line 76 "C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\NetCoreApp\Views\Configuration\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</tbody>
		</table>
	</div>
<script type=""text/javascript"">
	function Edit(ID, Name, Description) {
		$(""#ID"").val(ID);
		$(""#Edit #Name"").val(Name);
		$(""#Edit #Description"").val(Description);
		$(""#Edit"").addClass(""d-block"").removeClass(""d-none"");
		$(""#Add"").addClass(""d-none"").removeClass(""d-block"");
	}
	$(""#cancel"").click(function (e) {
		e.preventDefault();
		$(""#Add"").addClass(""d-block"").removeClass(""d-none"");
		$(""#Edit"").addClass(""d-none"").removeClass(""d-block"");
	});
	function Delete(ID, Name) {
		if(confirm(`Delete ${Name}?`)){
			window.location = `/Configuration/DeleteData/${ID}`;
		}
	}
</script>
</div>");
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
