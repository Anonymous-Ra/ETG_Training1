#pragma checksum "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cef713bd5099d220223a712938fa0452db04b45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWebApp.Pages.Pages_Sample), @"mvc.1.0.razor-page", @"/Pages/Sample.cshtml")]
namespace MyWebApp.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cef713bd5099d220223a712938fa0452db04b45", @"/Pages/Sample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb5dbd8c67ad376bb086277504a9baceee69ab3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Sample : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Hello</p>\r\n");
#nullable restore
#line 6 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
  
    string message = "foreignObject example with Scalable Vector Graphics (SVG)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<svg width=\"250\" height=\"300\" xmlns=\"http://www.w3.org/2000/svg\">\r\n    <rect x=\"0\" y=\"0\" rx=\"10\" ry=\"10\" width=\"250\" height=\"300\" stroke=\"black\"\r\n          fill=\"none\" />\r\n    <foreignObject x=\"20\" y=\"20\" width=\"160\" height=\"200\">\r\n        <p>");
#nullable restore
#line 14 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
      Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 15 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
      Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <span>Is Leap Year?</span>\r\n        <p>");
#nullable restore
#line 17 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
      Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </foreignObject>\r\n</svg>\r\n\r\n<p>Last week this time: ");
#nullable restore
#line 21 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
                    Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 23 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
  
    var joe = new Person { Name = "Joe", Age = 33 };

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Name");
#nullable restore
#line 26 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
   Write(joe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Age");
#nullable restore
#line 27 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
  Write(joe.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 29 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
Write("<span>Hello World</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 31 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
Write(Html.Raw("<span>Hello World</span>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 33 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
  
    void RenderName(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: <strong>");
#nullable restore
#line 36 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
                    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 37 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
    }

    RenderName("Mahatma Gandhi");
    RenderName("Martin Luther King, Jr.");

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
   String[] People = { "A", "B", "C", "D" };

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 for (var i = 0; i < People.Length; i++)
{
    var person = People[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Name: ");
#nullable restore
#line 46 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
           Write(person);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 48 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
   int value = 87680;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 53 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 57 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}
else if (value >= 1337)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is large.</p>\r\n");
#nullable restore
#line 61 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is odd and small.</p>\r\n");
#nullable restore
#line 65 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 switch (value)
{
    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value is 1!</p>\r\n");
#nullable restore
#line 70 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        break;
    case 1337:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number is 1337!</p>\r\n");
#nullable restore
#line 73 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number wasn\'t 1 or 1337.</p>\r\n");
#nullable restore
#line 76 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 79 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
  
    var people = new Person[]
    {
          new Person{Name="Weston", Age=33 },
          new Person{Name="Johnathon", Age=41 }

                                    };

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 for (var i = 0; i < people.Length; i++)
{
    var person = people[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 90 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 91 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 92 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 foreach (var person in people)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 96 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 97 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 98 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
   var j = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 while (j < people.Length)
{
    var person = people[j];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 103 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
        Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 104 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
       Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 105 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"

    j++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 110 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 2314, "\"", 2322, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Register</button>\r\n    </div>\r\n");
#nullable restore
#line 116 "D:\ETG_training1\ASP.net_Core\MyWebApp\Pages\Sample.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Pages.SampleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp.Pages.SampleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp.Pages.SampleModel>)PageContext?.ViewData;
        public MyWebApp.Pages.SampleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
