#pragma checksum "D:\MVC Project\InlineEditingJobTask\InlineEditingJobTask\Views\Shared\EditorTemplates\Number.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182d21ec1df046324b3d7f9b246d9d4740e4abe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Number), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Number.cshtml")]
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
#line 1 "D:\MVC Project\InlineEditingJobTask\InlineEditingJobTask\Views\_ViewImports.cshtml"
using InlineEditingJobTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVC Project\InlineEditingJobTask\InlineEditingJobTask\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182d21ec1df046324b3d7f9b246d9d4740e4abe8", @"/Views/Shared/EditorTemplates/Number.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b76d2d0b3bfdea016c7efe415e3cb70eb06be5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Number : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<double?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MVC Project\InlineEditingJobTask\InlineEditingJobTask\Views\Shared\EditorTemplates\Number.cshtml"
Write(Html.Kendo().NumericTextBoxFor(m => m)
      .HtmlAttributes(new { style = "width:100%" })
);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<double?> Html { get; private set; }
    }
}
#pragma warning restore 1591
