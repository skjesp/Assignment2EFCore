#pragma checksum "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a42673db929b6dbe9e4b6f9814d5da2ceb88079"
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
#line 1 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\_ViewImports.cshtml"
using DAB2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a42673db929b6dbe9e4b6f9814d5da2ceb88079", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbd30c68bef76bce8d82b05c56389d6a507902c1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 344, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<h5>Courses</h5>
<table>
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>ContentId</th>
        <th>CalendarId</th>
    </tr>

");
            EndContext();
#line 21 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
     foreach (var course in @Model.Courses)
    {

#line default
#line hidden
            BeginContext(467, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(498, 15, false);
#line 24 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(513, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(537, 11, false);
#line 25 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(548, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(572, 16, false);
#line 26 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(course.ContentId);

#line default
#line hidden
            EndContext();
            BeginContext(588, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(612, 17, false);
#line 27 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(course.CalendarId);

#line default
#line hidden
            EndContext();
            BeginContext(629, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(658, 212, true);
            WriteLiteral("</table>\r\n\r\n<br/>\r\n\r\n<h5>Students</h5>\r\n<table>\r\n    <tr>\r\n        <th>Au-id</th>\r\n        <th>Name</th>\r\n        <th>Enrolled Date</th>\r\n        <th>Graduation Date</th>\r\n        <th>Group-id</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
     foreach (var student in @Model.Students)
    {

#line default
#line hidden
            BeginContext(924, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(955, 17, false);
#line 47 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(student.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(972, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(996, 12, false);
#line 48 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1032, 20, false);
#line 49 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(student.EnrolledDate);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1076, 22, false);
#line 50 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(student.GraduationDate);

#line default
#line hidden
            EndContext();
            BeginContext(1098, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1122, 15, false);
#line 51 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(student.GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1166, 143, true);
            WriteLiteral("</table>\r\n\r\n<br/>\r\n\r\n<h5>Teachers</h5>\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Birthday</th>\r\n        <th>Name</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 66 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
     foreach (var teacher in @Model.Teachers)
    {

#line default
#line hidden
            BeginContext(1363, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1394, 17, false);
#line 69 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(teacher.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1435, 16, false);
#line 70 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(teacher.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(1451, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1475, 12, false);
#line 71 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1516, 173, true);
            WriteLiteral("</table>\r\n\r\n<br/>\r\n\r\n<h5>Assignments</h5>\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>DueDate</th>\r\n        <th>GroupSize</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 87 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
     foreach (var assignment in @Model.Assignments)
    {

#line default
#line hidden
            BeginContext(1749, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1780, 23, false);
#line 90 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(assignment.AssignmentId);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1827, 15, false);
#line 91 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(assignment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1866, 18, false);
#line 92 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(assignment.DueDate);

#line default
#line hidden
            EndContext();
            BeginContext(1884, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1908, 20, false);
#line 93 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
           Write(assignment.GroupSize);

#line default
#line hidden
            EndContext();
            BeginContext(1928, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "C:\Users\aliel\Desktop\IKT Noter og opgaver\4 semester\DAB\Assignment2EFCore\DAB2\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1957, 16, true);
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
