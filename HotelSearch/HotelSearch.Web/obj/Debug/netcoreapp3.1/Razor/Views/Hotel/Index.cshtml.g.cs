#pragma checksum "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbcf6a65cbf89f0f1d94130eb22350ee7c7d65a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Index), @"mvc.1.0.view", @"/Views/Hotel/Index.cshtml")]
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
#line 1 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\_ViewImports.cshtml"
using HotelSearch.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\_ViewImports.cshtml"
using HotelSearch.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbcf6a65cbf89f0f1d94130eb22350ee7c7d65a0", @"/Views/Hotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113b11eb6e038eaa1d0bb12cd832db1db84d1616", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1> USER LIST</h1>
<input type=""text"" id=""cities"" name=""cities"" class=""acInput""/>
<table class=""mt-4 table table-hover table-bordered table-sm"">
    <thead>
        <tr>
            <td>Ülke id</td>
            <td>Ülke</td>
            <td>Şehir</td> 
             
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
         foreach (var item in Model.body.items.Where(a=>a.country.id.Equals("TR")))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
               Write(item.country.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
               Write(item.country.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
               Write(item.city.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         \r\n\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#cities\").autocomplete(\'");
#nullable restore
#line 38 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\Index.cshtml"
                                  Write(Url.Action("CityList", "Hotel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
