#pragma checksum "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8277053697498b883e072ccf9cc2d09e2407d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Edit.cshtml", typeof(AspNetCore.Views_Students_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8277053697498b883e072ccf9cc2d09e2407d1", @"/Views/Students/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd91d18aae48c2d21f1b20b933ae8e65cff0c62", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
  
    ViewData["Title"] = "Edit ";

#line default
#line hidden
            BeginContext(57, 21, true);
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(113, 23, false);
#line 11 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(140, 90, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>StudentModel</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(231, 64, false);
#line 16 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(295, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(306, 33, false);
#line 17 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(339, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(390, 93, false);
#line 20 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(483, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(539, 93, false);
#line 22 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(632, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(651, 82, false);
#line 23 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(733, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(820, 96, false);
#line 28 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Surname, htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(972, 96, false);
#line 30 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Surname, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1087, 85, false);
#line 31 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1259, 94, false);
#line 36 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1409, 94, false);
#line 38 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1522, 83, false);
#line 39 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 88, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n\r\n            ");
            EndContext();
            BeginContext(1693, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d8277053697498b883e072ccf9cc2d09e2407d19360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 45 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Department);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1751, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1765, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d8277053697498b883e072ccf9cc2d09e2407d110975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 46 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DepartmentId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 46 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DepartmentId;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1859, 237, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 57 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(2099, 19, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2119, 40, false);
#line 63 "C:\Users\Begum\Desktop\Hw5\Hw5\Views\Students\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
