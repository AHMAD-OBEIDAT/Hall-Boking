#pragma checksum "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ccb96f944d4b3f17e4219b556884e50fcd7370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Index), @"mvc.1.0.view", @"/Views/Reservations/Index.cshtml")]
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
#line 1 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\_ViewImports.cshtml"
using Hall_Boking_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\_ViewImports.cshtml"
using Hall_Boking_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ccb96f944d4b3f17e4219b556884e50fcd7370", @"/Views/Reservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7fbca9e00289477df31c87863086b52fd2c85d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hall_Boking_System.Models.Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminDashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customers.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hall.HallName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Reservations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hall_Boking_System.Models.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
