#pragma checksum "C:\Users\Administrator\source\repos\NetCoreProject\NetCoreProject1\Content\RouteBinding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee43f021c172212db0c262d1c422daaa3164763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreProject1.Pages.Content_RouteBinding), @"mvc.1.0.razor-page", @"/Content/RouteBinding.cshtml")]
namespace NetCoreProject1.Pages
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
#line 1 "C:\Users\Administrator\source\repos\NetCoreProject\NetCoreProject1\Content\_ViewImports.cshtml"
using NetCoreProject1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/register/{Fullname?}/{Email}/{Age?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee43f021c172212db0c262d1c422daaa3164763", @"/Content/RouteBinding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec7159d1fcdfa801a339432b787b0921cb3f817", @"/Content/_ViewImports.cshtml")]
    public class Content_RouteBinding : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\NetCoreProject\NetCoreProject1\Content\RouteBinding.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreProject1.Content.RouteBindingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.RouteBindingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.RouteBindingModel>)PageContext?.ViewData;
        public NetCoreProject1.Content.RouteBindingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
