#pragma checksum "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c962768bbbaa7507172fd3c0818f18e8f683dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblUsers_Details), @"mvc.1.0.view", @"/Views/TblUsers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c962768bbbaa7507172fd3c0818f18e8f683dc2", @"/Views/TblUsers/Details.cshtml")]
    public class Views_TblUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApi1.Models.TblUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TblUser</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AadharCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AadharCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PanCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PanCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TraderLicense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.TraderLicense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VerificationStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.VerificationStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApprovedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3617, "\"", 3645, 1);
#nullable restore
#line 112 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Details.cshtml"
WriteAttributeValue("", 3632, Model.UserId, 3632, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApi1.Models.TblUser> Html { get; private set; }
    }
}
#pragma warning restore 1591