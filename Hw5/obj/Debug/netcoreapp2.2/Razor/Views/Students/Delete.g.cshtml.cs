#pragma checksum "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee08cce60c10cb9058c5d901e2e7df23b1bbcbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Delete), @"mvc.1.0.view", @"/Views/Students/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Delete.cshtml", typeof(AspNetCore.Views_Students_Delete))]
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
#line 1 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\_ViewImports.cshtml"
using Hw5;

#line default
#line hidden
#line 2 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\_ViewImports.cshtml"
using Hw5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee08cce60c10cb9058c5d901e2e7df23b1bbcbb", @"/Views/Students/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd91d18aae48c2d21f1b20b933ae8e65cff0c62", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hw5.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(69, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 40, false);
#line 16 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(322, 36, false);
#line 19 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(402, 43, false);
#line 22 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(489, 39, false);
#line 25 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(572, 41, false);
#line 28 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(613, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(657, 37, false);
#line 31 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(694, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(738, 46, false);
#line 34 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(828, 48, false);
#line 37 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Department.Dname));

#line default
#line hidden
            EndContext();
            BeginContext(876, 28, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
            EndContext();
#line 40 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(951, 23, false);
#line 42 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(978, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(1114, 40, false);
#line 46 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1179, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hw5.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
