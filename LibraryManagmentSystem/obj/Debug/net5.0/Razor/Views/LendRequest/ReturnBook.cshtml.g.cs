#pragma checksum "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\ReturnBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b354155eee0591c54b451eb0b272e7dff0d9f8b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LendRequest_ReturnBook), @"mvc.1.0.view", @"/Views/LendRequest/ReturnBook.cshtml")]
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
#line 1 "E:\LMSAlpha\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using LibraryManagmentSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LMSAlpha\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b354155eee0591c54b451eb0b272e7dff0d9f8b4", @"/Views/LendRequest/ReturnBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ed63fcf584b27fa2d42a455dd3bf05997e2746", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LendRequest_ReturnBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagmentSystem.Models.LendRequest>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\ReturnBook.cshtml"
  
	Layout="_userLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""container"">
  <div class=""row justify-content-md-center""> 
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           <h4> Book Returned...!!! </h4>
");
#nullable restore
#line 14 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\ReturnBook.cshtml"
                            if(Model.FineAmount > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <p>\r\n                                    You Need to Pay &#8377; ");
#nullable restore
#line 16 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\ReturnBook.cshtml"
                                                       Write(Model.FineAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                               </p>\r\n");
#nullable restore
#line 18 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\ReturnBook.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                        </center>\r\n                     </div>\r\n                  </div>   \r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagmentSystem.Models.LendRequest> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
