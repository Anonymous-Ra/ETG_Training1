#pragma checksum "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\TaskPages\Helo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2f7159cd09528953f92f24aed63b5d1f9ade159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWebApp.Pages.TaskPages.Pages_TaskPages_Helo), @"mvc.1.0.razor-page", @"/Pages/TaskPages/Helo.cshtml")]
namespace MyWebApp.Pages.TaskPages
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
#line 1 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\_ViewImports.cshtml"
using MyWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f7159cd09528953f92f24aed63b5d1f9ade159", @"/Pages/TaskPages/Helo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb5dbd8c67ad376bb086277504a9baceee69ab3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TaskPages_Helo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>This is hello Page</h1>\r\n    <img src=\"/Images/i.png\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Pages.TaskPages.HeloModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp.Pages.TaskPages.HeloModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp.Pages.TaskPages.HeloModel>)PageContext?.ViewData;
        public MyWebApp.Pages.TaskPages.HeloModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
