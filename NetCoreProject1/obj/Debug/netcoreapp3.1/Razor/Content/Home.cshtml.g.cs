#pragma checksum "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f1168c74a9bd7981e532bb1a8e8175bed7fe5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreProject1.Pages.Content_Home), @"mvc.1.0.razor-page", @"/Content/Home.cshtml")]
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
#line 1 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\_ViewImports.cshtml"
using NetCoreProject1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f1168c74a9bd7981e532bb1a8e8175bed7fe5b", @"/Content/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec7159d1fcdfa801a339432b787b0921cb3f817", @"/Content/_ViewImports.cshtml")]
    public class Content_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
  
    void SayHello(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>");
#nullable restore
#line 6 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
      Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 7 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
         Write(name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
                          
    }

    double Calculate(double a, double b)
    {
        return (a * b) + (a / b);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>This is default page from Content Directory</h5>\r\n<hr/>\r\n\r\n<div>\r\n    Please say hello to ");
#nullable restore
#line 20 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
                          SayHello("Corona");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    The result of calculation between 5,5 and 3,5 is: ");
#nullable restore
#line 24 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
                                                 Write(Calculate(5.5, 3.5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<hr/>\r\n<div>\r\n    ");
#nullable restore
#line 28 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
Write(Model.SayHello());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 31 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Home.cshtml"
Write(Model.SayGoodbye());

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</div>

<a class=""btn btn-primary"" href=""/MultiForms"">MultiForms</a>
<a class=""btn btn-primary"" href=""/MultiActions"">MultiActions</a>
<a class=""btn btn-primary"" href=""/Solve/2_-3_-4"">Equation</a>
<a class=""btn btn-primary"" href=""/Form"">Form</a>
<a class=""btn btn-primary"" href=""/Upload"">Upload</a>
<a class=""btn btn-primary"" href=""/CheckBox"">Checkbox</a>
<a class=""btn btn-primary"" href=""/FormBinding"">Form Binding</a>
<a class=""btn btn-primary"" href=""/register/Donald%20Trump/trump@gmail.com/29"">Route Binding</a>
<a class=""btn btn-primary"" href=""/ObjectBinding"">Object Binding</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreProject1.Content.TestChangeDirectory.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.TestChangeDirectory.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.TestChangeDirectory.IndexModel>)PageContext?.ViewData;
        public NetCoreProject1.Content.TestChangeDirectory.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
