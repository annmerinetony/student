#pragma checksum "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9432b2fc6d2921975acd471d7e0e9be6a52f50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9432b2fc6d2921975acd471d7e0e9be6a52f50", @"/Views/Student/Index.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CRUD_Operations.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 932, true);
            WriteLiteral(@"<ul class=""sidebar-menu"" data-widget=""tree"">

<li class=""treeview"">
    <a href=""#""> <span>Students</span>
    
    <ul class=""treeview-menu"">
    <li><a href=""/Student/Create"">Add Student</a></li>
    <li><a href=""/Student""> View Student</a></li>
    </ul>
</li>
</ul>
   

<section class=""content"">
    
    <div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
        <div class=""box-header"">
            <h3 class=""box-title"">Manage Students</h3>
        </div>
        <!-- /.box-header -->
        <div class=""box-body"">
            <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Gender</th>
                <th>Dob</th>
                <th>Action</th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 38 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1046, 49, true);
            WriteLiteral("                    <tr>\n                    <td>");
            EndContext();
            BeginContext(1096, 37, false);
#line 41 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1164, 39, false);
#line 42 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1234, 40, false);
#line 43 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1305, 40, false);
#line 44 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1376, 41, false);
#line 45 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1448, 38, false);
#line 46 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 32, true);
            WriteLiteral("</td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1518, "\"", 1548, 2);
            WriteAttributeValue("", 1525, "Student/Update/", 1525, 15, true);
#line 47 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
WriteAttributeValue("", 1540, item.Id, 1540, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1549, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1573, "\"", 1601, 3);
            WriteAttributeValue("", 1583, "Delete(\'", 1583, 8, true);
#line 47 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
WriteAttributeValue("", 1591, item.Id, 1591, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1599, "\')", 1599, 2, true);
            EndWriteAttribute();
            BeginContext(1602, 43, true);
            WriteLiteral(">Delete</a></td>\n                    </tr>\n");
            EndContext();
#line 49 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1663, 197, true);
            WriteLiteral("            </table>\n        </div>\n        <!-- /.box-body -->\n        </div>\n        <!-- /.box -->\n    </div>\n    <!-- /.col -->\n    </div>\n    <!-- /.row -->\n</section>\n   \n<!-- DataTables -->\n");
            EndContext();
            BeginContext(1860, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9432b2fc6d2921975acd471d7e0e9be6a52f508827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1945, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1946, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9432b2fc6d2921975acd471d7e0e9be6a52f5010004", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2037, 322, true);
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {
            
            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(2360, 31, false);
#line 77 "C:\Users\hp\Downloads\StudentManagment\StudentManagment\Views\Student\Index.cshtml"
                 Write(Url.Action("Delete", "Student"));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 552, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Student"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        } 
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CRUD_Operations.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
