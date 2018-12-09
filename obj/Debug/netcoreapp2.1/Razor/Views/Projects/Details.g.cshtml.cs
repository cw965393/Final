#pragma checksum "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b75aaadc075d205d6741d21dcd2f17acc1cfe249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
#line 1 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite;

#line default
#line hidden
#line 2 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75aaadc075d205d6741d21dcd2f17acc1cfe249", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45fcdfe59cbc6eb4c5ec57a208b4bd7d61e026", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuffteksWebsite.Models.ProjectDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProjectParticipant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 105, true);
            WriteLiteral("\n<h2>Details for projects</h2>\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(200, 58, false);
#line 13 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TheProject.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(258, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(299, 54, false);
#line 16 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.TheProject.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(353, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(394, 65, false);
#line 19 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TheProject.ProjectDescription));

#line default
#line hidden
            EndContext();
            BeginContext(459, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(500, 61, false);
#line 22 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.TheProject.ProjectDescription));

#line default
#line hidden
            EndContext();
            BeginContext(561, 409, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div>
    <h4>
        Participants - Client
    </h4>
    <hr />    
    <table class=""table"">
        <thead>
            <tr>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 44 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
     foreach (var client in Model.ProjectClients) {

#line default
#line hidden
            BeginContext(1022, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1081, 38, false);
#line 47 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(c => client.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1184, 37, false);
#line 50 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(c => client.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1285, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf5acc0805f47a9b9f33a9c38f190a8", async() => {
                BeginContext(1389, 68, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Delete</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                WriteLiteral(Model.TheProject.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                                                    WriteLiteral(client.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1461, 181, true);
            WriteLiteral("\n                    <!--<span class=\"text-danger\">TODO: We need to cascade delete members if a project is deleted</span>-->\n                </td>                \n            </tr>\n");
            EndContext();
#line 57 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1648, 418, true);
            WriteLiteral(@"        </tbody>
    </table>    
</div>
<div>
    <h4>
        Participants - Member
    </h4>
    <hr />    
    <table class=""table"">
        <thead>
            <tr>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 79 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
     foreach (var member in Model.ProjectMembers) {

#line default
#line hidden
            BeginContext(2118, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(2177, 38, false);
#line 82 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(m => member.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2215, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2280, 37, false);
#line 85 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(m => member.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2381, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4e6c1d93d647e5bf3e34f6c53cdbb7", async() => {
                BeginContext(2485, 68, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Delete</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                WriteLiteral(Model.TheProject.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                                                    WriteLiteral(member.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2557, 165, true);
            WriteLiteral("\n                    <!--<span class=\"text-danger\">TODO: We need to cascade delete members if a project is deleted</span>-->\n                </td>\n            </tr>\n");
            EndContext();
#line 92 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2728, 52, true);
            WriteLiteral("\n        </tbody>\n    </table>    \n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2780, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7faf079a4bef44a4a8bd53c0a6c8cef1", async() => {
                BeginContext(2837, 66, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Edit</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\cory4\OneDrive\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                           WriteLiteral(Model.TheProject.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2907, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2914, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4819e2f0a8b049b0911cfd8dadc51346", async() => {
                BeginContext(2936, 74, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-sm\">Back to list</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3014, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuffteksWebsite.Models.ProjectDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
