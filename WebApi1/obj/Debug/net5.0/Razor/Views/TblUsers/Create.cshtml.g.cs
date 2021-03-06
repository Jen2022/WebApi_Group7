#pragma checksum "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95b3005786a50cd760791db619486b839cde734e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblUsers_Create), @"mvc.1.0.view", @"/Views/TblUsers/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b3005786a50cd760791db619486b839cde734e", @"/Views/TblUsers/Create.cshtml")]
    public class Views_TblUsers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApi1.Models.TblUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>TblUser</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
");
            WriteLiteral(@"            </div>
            <div class=""form-group"">
                <label asp-for=""Address1"" class=""control-label""></label>
                <input asp-for=""Address1"" class=""form-control"" />
                <span asp-validation-for=""Address1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address2"" class=""control-label""></label>
                <input asp-for=""Address2"" class=""form-control"" />
                <span asp-validation-for=""Address2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
   ");
            WriteLiteral(@"             <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Pincode"" class=""control-label""></label>
                <input asp-for=""Pincode"" class=""form-control"" />
                <span asp-validation-for=""Pincode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AadharCard"" class=""control-label""></label>
                <input asp-for=""AadharCard"" class=""form-control"" />
                <span asp-validation-for=""AadharCard"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PanCard"" class=""control-label""></label>
                <input asp-for=""PanCard"" class=""form-control"" />
                <span asp-validation-for=""PanCard"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Certificate"" class=");
            WriteLiteral(@"""control-label""></label>
                <input asp-for=""Certificate"" class=""form-control"" />
                <span asp-validation-for=""Certificate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TraderLicense"" class=""control-label""></label>
                <input asp-for=""TraderLicense"" class=""form-control"" />
                <span asp-validation-for=""TraderLicense"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ApprovedBy"" class=""control-label""></label>
                <input asp-for=""ApprovedBy"" class=""form-control"" />
                <span asp-validation-for=""ApprovedBy"" class=""text-");
            WriteLiteral(@"danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ApprovedDate"" class=""control-label""></label>
                <input asp-for=""ApprovedDate"" class=""form-control"" />
                <span asp-validation-for=""ApprovedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\jfern\source\repos\WebApi1\WebApi1\Views\TblUsers\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
