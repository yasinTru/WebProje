#pragma checksum "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afdee1914267b1f68b94fc1d43459f963273f833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
using WebApplication1.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afdee1914267b1f68b94fc1d43459f963273f833", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afdee1914267b1f68b94fc1d43459f963273f8333922", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 446, "\"", 456, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 483, "\"", 493, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" href=\"https://getbootstrap.com/docs/3.4/favicon.ico\">\r\n    <link rel=\"canonical\" href=\"index.html\">\r\n\r\n    <title>");
#nullable restore
#line 19 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - WebApplication1</title>

    <!-- Bootstrap core CSS -->
    <link href=""/admin/dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <link href=""/admin/assets/css/ie10-viewport-bug-workaround.css"" rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""/admin/dashboard.css"" rel=""stylesheet"">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src=""../../assets/js/ie8-responsive-file-warning.js""></script><![endif]-->
    <script src=""/admin/assets/js/ie-emulation-modes-warning.js""></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
      <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afdee1914267b1f68b94fc1d43459f963273f8336920", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-controls=""navbar"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""#"">Project name</a>
            </div>
            <div id=""navbar"" class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""#""><span style=""color:#fff"">");
#nullable restore
#line 56 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                        Write(Context.Session.GetString("UserEmail"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></a></li>
                    <li><a href=""/Login/SignOut""><span style=""color:#fff"">Sign Out</span></a></li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-3 col-md-2 sidebar"">
                <ul class=""nav nav-sidebar"">
                    <li><a href=""/"">Home Page <span class=""sr-only"">(current)</span></a></li>
                    <li><a href=""/Admin"">Overview <span class=""sr-only"">(current)</span></a></li>
");
#nullable restore
#line 69 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
                     if (Context.Session.GetInt32("UserRole") == (int)Enums.UserRole.Admin)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a href=\"/Admin/Users\">\r\n                                Users\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 76 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/Admin/Products/New"">
                            Create Products
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Admin/Products"">
                            Products
                        </a>
                    </li>
                </ul>
            </div>
            <div class=""col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main"">
                ");
#nullable restore
#line 90 "C:\Users\yasin\Desktop\Ecommerce\Ecommerce\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src=""//code.jquery.com/jquery-1.12.4.min.js"" integrity=""sha384-nvAa0+6Qg9clwYCGGPpDQLVpLNn0fRaROjHqs13t4Ggj3Ez50XnGQqc/r8MhnRDZ"" crossorigin=""anonymous""></script>
    <script src=""/admin/dist/js/bootstrap.min.js""></script>
    <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
    <script src=""/admin/assets/js/vendor/holder.min.js""></script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src=""/admin/assets/js/ie10-viewport-bug-workaround.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from getbootstrap.com/docs/3.4/examples/dashboard/ by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 19 Dec 2019 09:04:21 GMT -->\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591