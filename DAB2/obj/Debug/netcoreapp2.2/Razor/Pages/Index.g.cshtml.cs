#pragma checksum "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c03458b8496b0f8c56aea1124caf98df553798c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DAB2.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(DAB2.Pages.Pages_Index), null)]
namespace DAB2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/_ViewImports.cshtml"
using DAB2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c03458b8496b0f8c56aea1124caf98df553798c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbd30c68bef76bce8d82b05c56389d6a507902c1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 354, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<h5>List of Courses</h5>

<table>
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>ContentId</th>
        <th>CalendarId</th>
    </tr>

");
            EndContext();
#line 22 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
     foreach (var course in @Model.Courses)
    {

#line default
#line hidden
            BeginContext(477, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(508, 15, false);
#line 25 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
           Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(523, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(547, 11, false);
#line 26 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
           Write(course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(558, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(582, 16, false);
#line 27 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
           Write(course.ContentId);

#line default
#line hidden
            EndContext();
            BeginContext(598, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(622, 17, false);
#line 28 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
           Write(course.CalendarId);

#line default
#line hidden
            EndContext();
            BeginContext(639, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(668, 120, true);
            WriteLiteral("</table>\r\n\r\n<br/>\r\n\r\n<h5>List of Teachers</h5>\r\n\r\n<table>\r\n    <th>Id</th>\r\n    <th>Birthday</th>\r\n    <th>Name</th>\r\n\r\n");
            EndContext();
#line 42 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
     foreach (var teacher in @Model.Teachers)
    {

#line default
#line hidden
            BeginContext(842, 12, true);
            WriteLiteral("        <td>");
            EndContext();
            BeginContext(855, 17, false);
#line 44 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(teacher.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(872, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(892, 16, false);
#line 45 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(teacher.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(908, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(928, 12, false);
#line 46 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(940, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(954, 174, true);
            WriteLiteral("</table>\r\n\r\n<h5>List of Students</h5>  \r\n\r\n<table>\r\n    <th>Au-id</th>\r\n    <th>Name</th>\r\n    <th>Enrolled Date</th>\r\n    <th>Graduation Date</th>\r\n    <th>Group-id</th>\r\n\r\n");
            EndContext();
#line 59 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
     foreach (var student in @Model.Students)
    {

#line default
#line hidden
            BeginContext(1182, 12, true);
            WriteLiteral("        <td>");
            EndContext();
            BeginContext(1195, 17, false);
#line 61 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(student.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1232, 12, false);
#line 62 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1264, 20, false);
#line 63 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(student.EnrolledDate);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1304, 22, false);
#line 64 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(student.GraduationDate);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1346, 15, false);
#line 65 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
       Write(student.GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 66 "/Users/danielappelgren/Documents/GitHub/Assignment2EFCore/DAB2/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1375, 16, true);
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
