#pragma checksum "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0efdc9764348e5636eddbcfc96f00c48f2c7e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0efdc9764348e5636eddbcfc96f00c48f2c7e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113b11eb6e038eaa1d0bb12cd832db1db84d1616", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelSearch.Web.Models.Response.HotelProduct.GetArrivalAutocompleteResponse>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sulta\source\repos\SanTsgBootcampProject\HotelSearch\HotelSearch.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0efdc9764348e5636eddbcfc96f00c48f2c7e84647", async() => {
                WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<style>
* {
  box-sizing: border-box;
}

body {
  font: 16px Arial;  
}

/the container must be positioned relative:/
.autocomplete {
  position: relative;
  display: inline-block;
}

input {
  border: 1px solid transparent;
  background-color: #f1f1f1;
  padding: 10px;
  font-size: 16px;
}

input[type=text] {
  background-color: #f1f1f1;
  width: 100%;
}

input[type=submit] {
  background-color: DodgerBlue;
  color: #fff;
  cursor: pointer;
}

.autocomplete-items {
  position: absolute;
  border: 1px solid #d4d4d4;
  border-bottom: none;
  border-top: none;
  z-index: 99;
  /position the autocomplete items to be the same width as the container:/
  top: 100%;
  left: 0;
  right: 0;
}

.autocomplete-items div {
  padding: 10px;
  cursor: pointer;
  background-color: #fff; 
  border-bottom: 1px solid #d4d4d4; 
}

/when hovering an item:/
.autocomplete-items div:hover {
  background-col");
                WriteLiteral("or: #e9e9e9; \r\n}\r\n\r\n/when navigating through the items using the arrow keys:/\r\n.autocomplete-active {\r\n  background-color: DodgerBlue !important; \r\n  color: #ffffff; \r\n}\r\n</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("     \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0efdc9764348e5636eddbcfc96f00c48f2c7e86877", async() => {
                WriteLiteral("\r\n\r\n<h2>Autocomplete</h2>\r\n\r\n<p>Start typing:</p>\r\n\r\n<!--Make sure the form has the autocomplete function switched off:-->\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0efdc9764348e5636eddbcfc96f00c48f2c7e87269", async() => {
                    WriteLiteral("\r\n  <div class=\"autocomplete\" style=\"width:300px;\">\r\n    <input id=\"myInput\" type=\"text\" name=\"myCountry\" placeholder=\"Country\">\r\n  </div>\r\n  <input type=\"submit\">\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script>
function autocomplete(inp, arr) {
  /*the autocomplete function takes two arguments,
  the text field element and an array of possible autocompleted values:*/
  var currentFocus;
  /execute a function when someone writes in the text field:/
  inp.addEventListener(""input"", function(e) {
      var a, b, i, val = this.value;
      /close any already open lists of autocompleted values/
      closeAllLists();
      if (!val) { return false;}
      currentFocus = -1;
      /create a DIV element that will contain the items (values):/
      a = document.createElement(""DIV"");
      a.setAttribute(""id"", this.id + ""autocomplete-list"");
      a.setAttribute(""class"", ""autocomplete-items"");
      /append the DIV element as a child of the autocomplete container:/
      this.parentNode.appendChild(a);
      /for each item in the array.../
      for (i = 0; i < arr.length; i++) {
        /check if the item starts with the same letters as the text field value:/
        if (arr[i].substr(0, val");
                WriteLiteral(@".length).toUpperCase() == val.toUpperCase()) {
          /create a DIV element for each matching element:/
          b = document.createElement(""DIV"");
          /make the matching letters bold:/
          b.innerHTML = ""<strong>"" + arr[i].substr(0, val.length) + ""</strong>"";
          b.innerHTML += arr[i].substr(val.length);
          /insert a input field that will hold the current array item's value:/
          b.innerHTML += ""<input type='hidden' value='"" + arr[i] + ""'>"";
          /execute a function when someone clicks on the item value (DIV element):/
          b.addEventListener(""click"", function(e) {
              /insert the value for the autocomplete text field:/
              inp.value = this.getElementsByTagName(""input"")[0].value;
              /*close the list of autocompleted values,
              (or any other open lists of autocompleted values:*/
              closeAllLists();
          });
          a.appendChild(b);
        }
      }
  });
  /execute a function presses ");
                WriteLiteral(@"a key on the keyboard:/
  inp.addEventListener(""keydown"", function(e) {
      var x = document.getElementById(this.id + ""autocomplete-list"");
      if (x) x = x.getElementsByTagName(""div"");
      if (e.keyCode == 40) {
        /*If the arrow DOWN key is pressed,
        increase the currentFocus variable:*/
        currentFocus++;
        /and and make the current item more visible:/
        addActive(x);
      } else if (e.keyCode == 38) { //up
        /*If the arrow UP key is pressed,
        decrease the currentFocus variable:*/
        currentFocus--;
        /and and make the current item more visible:/
        addActive(x);
      } else if (e.keyCode == 13) {
        /If the ENTER key is pressed, prevent the form from being submitted,/
        e.preventDefault();
        if (currentFocus > -1) {
          /and simulate a click on the ""active"" item:/
          if (x) x[currentFocus].click();
        }
      }
  });
  function addActive(x) {
    /a function to classify an item as");
                WriteLiteral(@" ""active"":/
    if (!x) return false;
    /start by removing the ""active"" class on all items:/
    removeActive(x);
    if (currentFocus >= x.length) currentFocus = 0;
    if (currentFocus < 0) currentFocus = (x.length - 1);
    /add class ""autocomplete-active"":/
    x[currentFocus].classList.add(""autocomplete-active"");
  }
  function removeActive(x) {
    /a function to remove the ""active"" class from all autocomplete items:/
    for (var i = 0; i < x.length; i++) {
      x[i].classList.remove(""autocomplete-active"");
    }
  }
  function closeAllLists(elmnt) {
    /*close all autocomplete lists in the document,
    except the one passed as an argument:*/
    var x = document.getElementsByClassName(""autocomplete-items"");
    for (var i = 0; i < x.length; i++) {
      if (elmnt != x[i] && elmnt != inp) {
        x[i].parentNode.removeChild(x[i]);
      }
    }
  }
  /execute a function when someone clicks in the document:/
  document.addEventListener(""click"", function (e) {
      clos");
                WriteLiteral("eAllLists(e.target);\r\n  });\r\n \r\nautocomplete(document.getElementById(\"myInput\"), countries);\r\n</script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
