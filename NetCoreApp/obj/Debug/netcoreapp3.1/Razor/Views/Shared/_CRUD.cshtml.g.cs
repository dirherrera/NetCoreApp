#pragma checksum "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2407b8a4e4a93a582bb3a11d808f9b07755e0981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CRUD), @"mvc.1.0.view", @"/Views/Shared/_CRUD.cshtml")]
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
#line 1 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2407b8a4e4a93a582bb3a11d808f9b07755e0981", @"/Views/Shared/_CRUD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CRUD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Configuration/AddPrivilege"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Configuration/EditPrivilege"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n\t<div>\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2407b8a4e4a93a582bb3a11d808f9b07755e09815691", async() => {
                WriteLiteral("\r\n\t\t\t<h4>Add ");
#nullable restore
#line 7 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<label for=\"Name\">Name</label>\r\n\t\t\t\t<input type=\"text\" id=\"Name\" class=\"form-control\" name=\"name\" />\r\n\t\t\t</div>\r\n\t\t\t<button class=\"btn btn-primary\">Add</button>\r\n\t\t");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2407b8a4e4a93a582bb3a11d808f9b07755e09817875", async() => {
                WriteLiteral("\r\n\t\t\t<h4>Edit ");
#nullable restore
#line 15 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
                Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\t\t\t<input type=\"hidden\" id=\"ID\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 524, "\"", 532, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
			<div class=""form-group"">
				<label for=""Name"">Name</label>
				<input type=""text"" id=""Name"" class=""form-control"" name=""name"" />
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
            WriteLiteral("\r\n\t</div>\r\n\r\n\t<hr />\r\n\r\n\t<h4>");
#nullable restore
#line 28 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n\t<div>\r\n\t\t<table class=\"table table-striped table-bordered table-hover\">\r\n\t\t\t<thead class=\"thead-dark\">\r\n\t\t\t\t<tr align=\"center\">\r\n\t\t\t\t\t<th>Name</th>\r\n\t\t\t\t\t<th>Edit</th>\r\n\t\t\t\t\t<th>Delete</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
                 foreach (var da in ViewBag.Data)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 43 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
                       Write(da.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td align=\"center\">\r\n\t\t\t\t\t\t\t<button type=\"button\" class=\"edit-data btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1261, "\"", 1297, 5);
            WriteAttributeValue("", 1271, "Edit(\'", 1271, 6, true);
#nullable restore
#line 45 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
WriteAttributeValue("", 1277, da.ID, 1277, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1283, "\',\'", 1283, 3, true);
#nullable restore
#line 45 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
WriteAttributeValue("", 1286, da.Name, 1286, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1294, "\');", 1294, 3, true);
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
            BeginWriteAttribute("onclick", " onclick=\"", 2051, "\"", 2088, 5);
            WriteAttributeValue("", 2061, "Delete(\'", 2061, 8, true);
#nullable restore
#line 53 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
WriteAttributeValue("", 2069, da.ID, 2069, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2075, "\',\'", 2075, 3, true);
#nullable restore
#line 53 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
WriteAttributeValue("", 2078, da.Name, 2078, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2086, "\')", 2086, 2, true);
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
#line 61 "C:\Users\Programador 2\source\repos\NetCoreApp\NetCoreApp\Views\Shared\_CRUD.cshtml"
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
			$(""#Edit"").addClass(""d-block"").removeClass(""d-none"");
			$(""#Add"").addClass(""d-none"").removeClass(""d-block"");
		}
		$(""#cancel"").click(function (e) {
			e.preventDefault();
			$(""#Add"").addClass(""d-block"").removeClass(""d-none"");
			$(""#Edit"").addClass(""d-none"").removeClass(""d-block"");
		});
		function Delete(ID, Name) {
			if (confirm(`Delete ${Name}?`)) {
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
