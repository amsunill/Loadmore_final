#pragma checksum "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\Loadmore\Emplist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91517090bb5cb308ba316a322510ac0dcdabe221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loadmore_Emplist), @"mvc.1.0.view", @"/Views/Loadmore/Emplist.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\_ViewImports.cshtml"
using LOADMORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\_ViewImports.cshtml"
using LOADMORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91517090bb5cb308ba316a322510ac0dcdabe221", @"/Views/Loadmore/Emplist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e8dba04ac8de51b97e1794b998182882dfddd", @"/Views/_ViewImports.cshtml")]
    public class Views_Loadmore_Emplist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LOADMORE.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\Loadmore\Emplist.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\Loadmore\Emplist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\Loadmore\Emplist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 11 "C:\Users\lenovo\Desktop\TASKS\LOADMORE\Views\Loadmore\Emplist.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LOADMORE.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591