#pragma checksum "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42145d5bbf55690caa0479bfa20a944a4f6c6c17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RoleAuth.Pages.EmployeeTypes.Pages_EmployeeTypes_Index), @"mvc.1.0.razor-page", @"/Pages/EmployeeTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeeTypes/Index.cshtml", typeof(RoleAuth.Pages.EmployeeTypes.Pages_EmployeeTypes_Index), null)]
namespace RoleAuth.Pages.EmployeeTypes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\_ViewImports.cshtml"
using RoleAuth;

#line default
#line hidden
#line 3 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\_ViewImports.cshtml"
using RoleAuth.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42145d5bbf55690caa0479bfa20a944a4f6c6c17", @"/Pages/EmployeeTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74ae1ded6395e2eb057b79551b9b013c7a76aa9f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeeTypes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 102, true);
            WriteLiteral("\r\n<h1>Employee Types</h1>\r\n\r\n<br />\r\n<br />\r\n<div>\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t");
            EndContext();
            BeginContext(239, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42145d5bbf55690caa0479bfa20a944a4f6c6c176576", async() => {
                BeginContext(283, 55, true);
                WriteLiteral("\r\n\t\t\t\t<i class=\"fas fa-plus\"></i>&nbsp; Create New\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(342, 54, true);
            WriteLiteral("\r\n\t\t</div>\t\t\r\n\t</div>\r\n</div>\r\n<br />\r\n<br />\r\n<div>\r\n");
            EndContext();
#line 24 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
     if (Model.EmployeeType.Count == 0)
	{

#line default
#line hidden
            BeginContext(438, 57, true);
            WriteLiteral("\t\t<p>No Employee types exist! Please add a new one.</p>\r\n");
            EndContext();
#line 27 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
	}
	else
	{

#line default
#line hidden
            BeginContext(510, 94, true);
            WriteLiteral("\t\t<table class=\"table table-striped border\">\r\n\t\t\t<tr class=\"table-secondary\">\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(605, 48, false);
#line 33 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.EmployeeType[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(653, 28, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(682, 51, false);
#line 36 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.EmployeeType[0].PayType));

#line default
#line hidden
            EndContext();
            BeginContext(733, 38, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 40 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
             foreach (var item in Model.EmployeeType)
			{

#line default
#line hidden
            BeginContext(823, 27, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(851, 31, false);
#line 44 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(882, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(914, 34, false);
#line 47 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
                   Write(Html.DisplayFor(m => item.PayType));

#line default
#line hidden
            EndContext();
            BeginContext(948, 97, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td style=\"width:150px;\">\r\n\t\t\t\t\t\t<div class=\"btn-group\" role=\"group\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1045, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42145d5bbf55690caa0479bfa20a944a4f6c6c1711163", async() => {
                BeginContext(1123, 46, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-edit\"></i>\r\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1173, 9, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1182, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42145d5bbf55690caa0479bfa20a944a4f6c6c1713731", async() => {
                BeginContext(1263, 50, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"far fa-list-alt\"></i>\r\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1317, 9, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1326, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42145d5bbf55690caa0479bfa20a944a4f6c6c1716306", async() => {
                BeginContext(1405, 51, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-trash-alt\"></i>\r\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1460, 41, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 64 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(1507, 12, true);
            WriteLiteral("\t\t</table>\r\n");
            EndContext();
#line 66 "D:\Semester-VI\COMP306 API Engineering\Final Alternative\Cloud-Automation\RoleAuth\Pages\EmployeeTypes\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(1523, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleAuth.Pages.EmployeeTypes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RoleAuth.Pages.EmployeeTypes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RoleAuth.Pages.EmployeeTypes.IndexModel>)PageContext?.ViewData;
        public RoleAuth.Pages.EmployeeTypes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
