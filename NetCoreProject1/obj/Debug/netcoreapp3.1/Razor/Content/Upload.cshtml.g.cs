#pragma checksum "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e82bb4b84d92c25ee5314b5ec4a39be1455ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreProject1.Pages.Content_Upload), @"mvc.1.0.razor-page", @"/Content/Upload.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e82bb4b84d92c25ee5314b5ec4a39be1455ff8", @"/Content/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec7159d1fcdfa801a339432b787b0921cb3f817", @"/Content/_ViewImports.cshtml")]
    public class Content_Upload : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e82bb4b84d92c25ee5314b5ec4a39be1455ff83662", async() => {
                WriteLiteral("\r\n    <input type=\"file\" name=\"file\" />\r\n    <button type=\"submit\" class=\"btn btn-info\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
 if (Request.Method.ToUpper() == "POST")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
     if (Model.Success)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>The file ");
#nullable restore
#line 14 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
                Write(ViewData["file"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been uploaded successfully !</h3>\r\n");
#nullable restore
#line 15 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>The file ");
#nullable restore
#line 18 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
                Write(ViewData["file"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been uploaded failed !</h3>\r\n");
#nullable restore
#line 19 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
     

    if (!string.IsNullOrEmpty(Model.FilePath)){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 545, "\"", 566, 1);
#nullable restore
#line 22 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
WriteAttributeValue("", 551, Model.FilePath, 551, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 23 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\Upload.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreProject1.Content.UploadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.UploadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.UploadModel>)PageContext?.ViewData;
        public NetCoreProject1.Content.UploadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
