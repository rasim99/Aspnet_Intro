#pragma checksum "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\Group\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d4267b49031aa0a02147e7c8d88b3705c75967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Detail), @"mvc.1.0.view", @"/Views/Group/Detail.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\_ViewImports.cshtml"
using StudentGroupMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\_ViewImports.cshtml"
using StudentGroupMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d4267b49031aa0a02147e7c8d88b3705c75967", @"/Views/Group/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f41ebfbc7a3e2c25d111000fd8761a0b6fe5538", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Group_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Group>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Detail</h1>\r\n");
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\Group\Detail.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p> Group Id =>>>>");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\Group\Detail.cshtml"
                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t<p> Group Name =>>>>");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\Group\Detail.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t<hr />\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\BACKEND\StudentGroupMVC\StudentGroupMVC\Views\Group\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Group>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
