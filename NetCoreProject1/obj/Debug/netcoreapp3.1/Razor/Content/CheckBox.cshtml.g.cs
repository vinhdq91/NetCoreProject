#pragma checksum "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d569ffc37c4d598f0b890481c93729303c145a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreProject1.Pages.Content_CheckBox), @"mvc.1.0.razor-page", @"/Content/CheckBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d569ffc37c4d598f0b890481c93729303c145a", @"/Content/CheckBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec7159d1fcdfa801a339432b787b0921cb3f817", @"/Content/_ViewImports.cshtml")]
    public class Content_CheckBox : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d569ffc37c4d598f0b890481c93729303c145a3547", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
         foreach (string item in Model.ListLanguage)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"custom-control\">\r\n                <input type=\"checkbox\" class=\"custom-checkbox\" name=\"languages\"");
                BeginWriteAttribute("id", " id=\"", 316, "\"", 326, 1);
#nullable restore
#line 11 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
WriteAttributeValue("", 321, item, 321, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 327, "\"", 340, 1);
#nullable restore
#line 11 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
WriteAttributeValue("", 335, item, 335, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <label class=\"custom-control-label\"");
                BeginWriteAttribute("for", " for=\"", 397, "\"", 408, 1);
#nullable restore
#line 12 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
WriteAttributeValue("", 403, item, 403, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 12 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
                                                           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n");
#nullable restore
#line 14 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <button type=\"submit\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>You have choosen</h3>\r\n    <ul>\r\n");
#nullable restore
#line 23 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
         foreach (string item in Model.Language)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 25 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 28 "D:\.Net Core Project\NetCoreProject1\NetCoreProject1\Content\CheckBox.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreProject1.Content.CheckBoxModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.CheckBoxModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreProject1.Content.CheckBoxModel>)PageContext?.ViewData;
        public NetCoreProject1.Content.CheckBoxModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
