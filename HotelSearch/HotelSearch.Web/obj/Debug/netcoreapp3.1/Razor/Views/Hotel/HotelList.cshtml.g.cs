#pragma checksum "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8053a732f71dd4dbe9fcb5f64a0aa78966033248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_HotelList), @"mvc.1.0.view", @"/Views/Hotel/HotelList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8053a732f71dd4dbe9fcb5f64a0aa78966033248", @"/Views/Hotel/HotelList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113b11eb6e038eaa1d0bb12cd832db1db84d1616", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_HotelList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n \r\n<table class=\"mt-4 table table-hover table-bordered table-sm\">\r\n    <thead>\r\n        <tr> \r\n            <td>Otel</td>\r\n            <td>Şehir</td> \r\n             \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
               Write(item.hotel.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
               Write(item.city.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         \r\n\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#cities\").autocomplete(\'");
#nullable restore
#line 35 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Hotel\HotelList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
