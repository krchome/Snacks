#pragma checksum "D:\Projects\RazorPages\Snacks\Pages\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa69ad257d68f0e9f1b64acef281154c606a885e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Snacks.Pages.Pages_OrderSuccess), @"mvc.1.0.razor-page", @"/Pages/OrderSuccess.cshtml")]
namespace Snacks.Pages
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
#line 1 "D:\Projects\RazorPages\Snacks\Pages\_ViewImports.cshtml"
using Snacks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa69ad257d68f0e9f1b64acef281154c606a885e", @"/Pages/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df710e048c374448bc21fe9583312edc069b749e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ol id=""orderProcess"">
    <li><span class=""step-number"">1</span>Choose Item</li>
    <li><span class=""step-number"">2</span>Details &amp; Submit</li>
    <li class=""current""><span class=""step-number"">3</span>Receipt</li>
</ol>
<h1>Order Confirmation</h1>
<div class=""message order-success"">
    <h2>Thank you for your order!</h2>
    <p>We are processing your order and have sent a confirmation email. Thank you for your business and enjoy!</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Snacks.Pages.OrderSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Snacks.Pages.OrderSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Snacks.Pages.OrderSuccessModel>)PageContext?.ViewData;
        public Snacks.Pages.OrderSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591