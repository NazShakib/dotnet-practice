#pragma checksum "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098684a84078f11ecf62d18ca31d019888335d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_admin), @"mvc.1.0.view", @"/Views/User/admin.cshtml")]
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
#line 1 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\_ViewImports.cshtml"
using OA.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\_ViewImports.cshtml"
using OA.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098684a84078f11ecf62d18ca31d019888335d2e", @"/Views/User/admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb48f179d7e2a69b6253e8aa1b2540d0b15434f2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OA.Web.Models.AdminViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        
        <div class=""col-md-1"">

        </div>
        <div class=""col-md-10"">
            <h1 class=""text-center"">Admin View</h1>
            <br />
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 20 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 35 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 52 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 53 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 56 "D:\dot net\OA_EmployeeHealthTrace\OA.Web\Views\User\admin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-md-1\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OA.Web.Models.AdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
