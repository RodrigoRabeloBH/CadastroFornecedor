#pragma checksum "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab9254d2bee7cc21be05dd2c2e8dea62326668b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Delete), @"mvc.1.0.view", @"/Views/Provider/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Provider/Delete.cshtml", typeof(AspNetCore.Views_Provider_Delete))]
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
#line 1 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\_ViewImports.cshtml"
using DevIo.App;

#line default
#line hidden
#line 2 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\_ViewImports.cshtml"
using DevIo.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab9254d2bee7cc21be05dd2c2e8dea62326668b", @"/Views/Provider/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ccf9dfa6325c6667d978b9a769cdc79ab47e9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIo.App.Models.ProviderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
  
    ViewData["Title"] = "Delete: " + Model.Name;

#line default
#line hidden
            BeginContext(102, 46, true);
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"mt-4\">");
            EndContext();
            BeginContext(149, 17, false);
#line 7 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 282, true);
            WriteLiteral(@"</h3>
    <h4>Are you sure you want to delete this?</h4>
    <hr class=""my-4"" />
    <div class=""row jumbotron"">
        <div class=""col-md-6"">
            <h4 class=""text-muted"">Information</h4>
            <p class=""text-muted""><samp class=""font-weight-bolder"">Name: </samp>");
            EndContext();
            BeginContext(449, 10, false);
#line 13 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(459, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Document: </samp>");
            EndContext();
            BeginContext(550, 14, false);
#line 14 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                               Write(Model.Document);

#line default
#line hidden
            EndContext();
            BeginContext(564, 91, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Is Active: </samp>");
            EndContext();
            BeginContext(656, 14, false);
#line 15 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                                Write(Model.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(670, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Type: </samp>");
            EndContext();
            BeginContext(757, 18, false);
#line 16 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                           Write(Model.ProviderType);

#line default
#line hidden
            EndContext();
            BeginContext(775, 185, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h4 class=\"text-muted\">Address</h4>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Street: </samp>");
            EndContext();
            BeginContext(961, 20, false);
#line 20 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                             Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(981, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">District: </samp>");
            EndContext();
            BeginContext(1072, 22, false);
#line 21 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                               Write(Model.Address.District);

#line default
#line hidden
            EndContext();
            BeginContext(1094, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">City: </samp>");
            EndContext();
            BeginContext(1181, 18, false);
#line 22 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                           Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 87, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">State: </samp>");
            EndContext();
            BeginContext(1287, 19, false);
#line 23 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
                                                                            Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 47, true);
            WriteLiteral("</p>\r\n        </div>     \r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1353, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab9254d2bee7cc21be05dd2c2e8dea62326668b9712", async() => {
                BeginContext(1379, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1385, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bab9254d2bee7cc21be05dd2c2e8dea62326668b10099", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1421, 80, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger btn-sm\" />\r\n    ");
                EndContext();
                BeginContext(1501, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab9254d2bee7cc21be05dd2c2e8dea62326668b11991", async() => {
                    BeginContext(1556, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1566, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1575, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIo.App.Models.ProviderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
