#pragma checksum "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717f58415908dcec2bab63aa339845c629bdd359"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LentList), @"mvc.1.0.view", @"/Views/Shared/LentList.cshtml")]
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
#line 1 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using LibraryManagmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717f58415908dcec2bab63aa339845c629bdd359", @"/Views/Shared/LentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fc1187f0828b3657e34845ad9b7c89383f04e7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_LentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryManagmentSystem.Models.LendRequest>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@" <div class=""container"">
  <div class=""row justify-content-md-center""> 
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           <h4>Lended Books List</h4>
                        </center>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <hr>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <table class=""table table-striped table-bordered"" >
                            <thead>
                                <tr>
                                <td>Lend Id </td>
                                <td>User Name </td>
                                <td>Book Id</td>
                                <td>Book Name</td>
               ");
            WriteLiteral(@"                 <td>LendDate</td>
                                <td>ReturnDate</td>
                                <td>Status</td>
                                <td colspan=""2""></td>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 36 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                 foreach (var lendList in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.LendId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 40 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.BooksInfo.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.LendDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                       Write(lendList.LendStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                     \r\n                                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\muthu\Desktop\LMSAlpha\LMSAlpha\LibraryManagmentSystem\Views\Shared\LentList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        </table>\r\n                     </div>\r\n                  </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryManagmentSystem.Models.LendRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
