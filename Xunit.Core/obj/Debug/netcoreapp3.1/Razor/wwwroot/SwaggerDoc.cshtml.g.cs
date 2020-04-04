#pragma checksum "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea05e7db03ec7a6a30b043d040f5fd840a0dfcbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_SwaggerDoc), @"mvc.1.0.view", @"/wwwroot/SwaggerDoc.cshtml")]
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
#line 1 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
using Swashbuckle.AspNetCore.Swagger;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea05e7db03ec7a6a30b043d040f5fd840a0dfcbd", @"/wwwroot/SwaggerDoc.cshtml")]
    public class wwwroot_SwaggerDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea05e7db03ec7a6a30b043d040f5fd840a0dfcbd2806", async() => {
                WriteLiteral(@"
    <title>Swagger API文档代码文件</title>
    <style type='text/css'>

        table, table td, table th {
            border: 1px solid #000000;
            border-collapse: collapse;
        }

        table {
            table-layout: fixed;
            word-break: break-all;
        }

        tr {
            height: 20px;
            font-size: 12px;
        }
    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea05e7db03ec7a6a30b043d040f5fd840a0dfcbd4166", async() => {
                WriteLiteral("\r\n    <div style=\'width:1000px; margin: 0 auto\'>\r\n        <span><i>Word接口文档</i></span>\r\n        <h1 align=\"center\">");
#line 27 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                      Write(Model.Info.Title);

#line default
#line hidden
                WriteLiteral("</h1>\r\n        <h1 align=\"center\">接口文档 ");
#line 28 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                           Write(Model.Info.Version);

#line default
#line hidden
                WriteLiteral("</h1>\r\n        <h4>联系方式</h4>\r\n        <span>作者：");
#line 30 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
            Write(Model.Info.Contact.Name);

#line default
#line hidden
                WriteLiteral("</span>\r\n        <br>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 777, "\"", 816, 2);
                WriteAttributeValue("", 784, "mailto:", 784, 7, true);
#line 32 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
WriteAttributeValue("", 791, Model.Info.Contact.Email, 791, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" rel=\"noopener noreferrer\" class=\"link\">Send email to Xunit.Core</a>\r\n        <br>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 911, "\"", 941, 1);
#line 34 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
WriteAttributeValue("", 918, Model.Info.Contact.Url, 918, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" rel=\"noopener noreferrer\" class=\"link\">");
#line 34 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                            Write(Model.Info.Contact.Name);

#line default
#line hidden
                WriteLiteral(" - Website</a>\r\n        <br>\r\n        <h3>接口描述</h3>\r\n        <span>");
#line 37 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
         Write(Model.Info.Description);

#line default
#line hidden
                WriteLiteral(@"</span>
        <br>
        <table border='1' cellspacing='0' cellpadding='0' style=""table-layout: fixed; word-break: break-all;border: 1px solid #000000;border-collapse: collapse;"" width='100%'>
            <tr style=""border: 1px solid #000000;border-collapse: collapse;"">
                <td align=""center"" style=""background-color: rgb(84, 127, 177);"">说明</td>
                <td></td>
            </tr>
            <tr style=""border: 1px solid #000000;border-collapse: collapse;"">
                <td align=""center"" style=""background-color: rgb(84, 127, 177);"">类型</td>
                <td></td>
            </tr>

        </table>
");
#line 50 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
         foreach (var item in Model.Paths)
        {
            if (item.Value.Operations != null)
            {
                foreach (var operation in item.Value.Operations)
                {

#line default
#line hidden
                WriteLiteral("                    <h3>");
#line 56 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                   Write(operation.Value.Summary);

#line default
#line hidden
                WriteLiteral(@"</h3>
                    <table border='1' cellspacing='0' cellpadding='0' width='100%' style=""table-layout: fixed; word-break: break-all;border: 1px solid #000000;border-collapse: collapse;"">
                        <tr style=""background-color: rgb(84, 127, 177);"" align=""center"">
                            <td colspan='5'></td>
                        </tr>
                     
                        <tr style=""border: 1px solid #000000;border-collapse: collapse;"">
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"">URL</td>
                            <td colspan='4'>");
#line 64 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                       Write(item.Key);

#line default
#line hidden
                WriteLiteral(@"</td>
                        </tr>
                        <tr style=""border: 1px solid #000000;border-collapse: collapse;"">
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"">请求方式</td>
                            <td colspan='4'>
                                ");
#line 69 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                           Write(operation.Key);

#line default
#line hidden
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                       \r\n");
#line 73 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                         if (operation.Value.Parameters != null && operation.Value.Parameters.Count > 0)
                        {

#line default
#line hidden
                WriteLiteral(@"                            <tr style=""background-color: rgb(84, 127, 177);"" align='center'>
                                <td style=""border: 1px solid #000000;border-collapse: collapse;"">参数名</td>
                                <td style=""border: 1px solid #000000;border-collapse: collapse;"">参数类型</td>
                                <td style=""border: 1px solid #000000;border-collapse: collapse;"">是否必填</td>
                                <td style=""border: 1px solid #000000;border-collapse: collapse;"" colspan='2'>说明</td>
                            </tr>
");
#line 81 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                             foreach (var param in operation.Value.Parameters)
                            {

#line default
#line hidden
                WriteLiteral("                                <tr align=\'center\' style=\"border: 1px solid #000000;border-collapse: collapse;\">\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\">");
#line 84 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                Write(param.Name);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\">");
#line 85 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                Write(param.In);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\">");
#line 86 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                Write(param.Required);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\" colspan=\'2\'>");
#line 87 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                            Write(param.Description);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#line 89 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                            }

#line default
#line hidden
#line 89 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                             
                        }

#line default
#line hidden
                WriteLiteral(@"
                        <tr style=""background-color: rgb(84, 127, 177);"" align='center'>
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"">状态码</td>
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"" colspan='4'>说明</td>
                        </tr>
");
#line 96 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                         if (operation.Value.Responses != null && operation.Value.Responses.Count > 0)
                        {
                            foreach (var response in operation.Value.Responses)
                            {

#line default
#line hidden
                WriteLiteral("                                <tr align=\'center\' style=\"border: 1px solid #000000;border-collapse: collapse;\">\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\">");
#line 101 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                Write(response.Key);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                    <td style=\"border: 1px solid #000000;border-collapse: collapse;\" colspan=\'4\'>");
#line 102 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                                                                                                            Write(response.Value.Description);

#line default
#line hidden
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#line 104 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"

                            }
                        }

#line default
#line hidden
                WriteLiteral(@"                        <tr style=""background-color: rgb(84, 127, 177);"">
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"" colspan='5'>示例</td>
                        </tr>
                        <tr style=""height: 40px;"" style=""border: 1px solid #000000;border-collapse: collapse;"">
                            <td style=""background-color: rgb(84, 127, 177);"">请求参数</td>
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"" colspan='4'></td>
                        </tr>
                        <tr style=""height: 40px;"" style=""border: 1px solid #000000;border-collapse: collapse;"">
                            <td style=""background-color: rgb(84, 127, 177);"">返回值</td>
                            <td style=""border: 1px solid #000000;border-collapse: collapse;"" colspan='4'></td>
                        </tr>
                    </table>
                    <br>
");
#line 120 "D:\共享文件\XUnit.Core\wwwroot\SwaggerDoc.cshtml"
                }

            }
            
        }

#line default
#line hidden
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
