#pragma checksum "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\Assets\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79b070d6c58c2cda54c284e54eefc28e3b14af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_List), @"mvc.1.0.view", @"/Views/Assets/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assets/List.cshtml", typeof(AspNetCore.Views_Assets_List))]
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
#line 1 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#line 2 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79b070d6c58c2cda54c284e54eefc28e3b14af8", @"/Views/Assets/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\Assets\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 799, true);
            WriteLiteral(@"

<div class=""page-content"">

    <div class=""row"">
        <div class=""col-sm-10 page-content"">
            <h3 class=""page-title"">Details List</h3>
            <br />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-10"">
            <div class=""control-container form-horizontal"">
                <div class=""table-scroll"" style=""height:550px"">
                    <table id=""tblAssets"" class=""table table-hover table-bordered table-striped results"" >
                        <thead>
                            <tr>
                                <th class=""col-sm-4"">Name</th>
                                <th class=""col-sm-8"">Description</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 28 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\Assets\List.cshtml"
                             for(int i = 0; i < 14; i++)
                            {

#line default
#line hidden
            BeginContext(977, 189, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"col-sm-4\"></td>\r\n                                <td class=\"col-sm-8\"></td>\r\n                            </tr>\r\n");
            EndContext();
#line 34 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\Assets\List.cshtml"
                            }

#line default
#line hidden
            BeginContext(1197, 382, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-sm-2"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <a class=""btn btn-block btn-outer"">Refresh</a>
                </div>
            </div>
        </div>
    </div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1597, 431, true);
                WriteLiteral(@"

    <script type=""text/javascript"">

        document.addEventListener('DOMContentLoaded', function () {

            InitViewAssetsList();
        });

        function InitViewAssetsList() {

            var tblAssets = document.getElementById('tblAssets')
            var body = tblAssets.tBodies[0];
            body.innerHTML = '';

            $.ajax({
                method: 'GET',
                url: '");
                EndContext();
                BeginContext(2029, 23, false);
#line 69 "D:\LIGHUEN\GIT\Dealership\App\App.Web\Views\Assets\List.cshtml"
                 Write(Url.Action("","Assets"));

#line default
#line hidden
                EndContext();
                BeginContext(2052, 807, true);
                WriteLiteral(@"',
                success: function (data) {

                    if (data) {

                        for (var i = 0; i < data.length; i++) {
                            var registro = data[i];

                            var row = document.createElement('tr');

                            row.innerHTML =
                                '<td class=""col-sm-4"">' + registro['name'] + '</td>' +
                                '<td class=""col-sm-8"">' + registro['description'] + '</td>';

                            body.appendChild(row);
                        }
                    }

                },
                error: function (XHR, textStatus, errorThrown) {
                    alert(XHR.responseText);
                }
            });

        }

    </script>
");
                EndContext();
            }
            );
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
