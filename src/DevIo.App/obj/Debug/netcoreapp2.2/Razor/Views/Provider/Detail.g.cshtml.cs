#pragma checksum "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a789736d12e4603ca598bbfffc151bb259900f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Detail), @"mvc.1.0.view", @"/Views/Provider/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Provider/Detail.cshtml", typeof(AspNetCore.Views_Provider_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a789736d12e4603ca598bbfffc151bb259900f", @"/Views/Provider/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ccf9dfa6325c6667d978b9a769cdc79ab47e9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIo.App.Models.ProviderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
  
    ViewData["Title"] = "Detail: " + Model.Name;

#line default
#line hidden
            BeginContext(102, 46, true);
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"mt-4\">");
            EndContext();
            BeginContext(149, 17, false);
#line 7 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 211, true);
            WriteLiteral("</h3>\r\n    <hr class=\"my-4\" />\r\n    <div class=\"row jumbotron\">\r\n        <div class=\"col-md-4\">\r\n            <h4>Information</h4>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Name: </samp>");
            EndContext();
            BeginContext(378, 10, false);
#line 12 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(388, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Document: </samp>");
            EndContext();
            BeginContext(479, 14, false);
#line 13 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                               Write(Model.Document);

#line default
#line hidden
            EndContext();
            BeginContext(493, 91, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Is Active: </samp>");
            EndContext();
            BeginContext(585, 14, false);
#line 14 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                                Write(Model.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(599, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Type: </samp>");
            EndContext();
            BeginContext(686, 18, false);
#line 15 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.ProviderType);

#line default
#line hidden
            EndContext();
            BeginContext(704, 166, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h4>Address</h4>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Street: </samp>");
            EndContext();
            BeginContext(871, 20, false);
#line 19 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                             Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(891, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">District: </samp>");
            EndContext();
            BeginContext(982, 22, false);
#line 20 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                               Write(Model.Address.District);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">City: </samp>");
            EndContext();
            BeginContext(1091, 18, false);
#line 21 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 87, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">State: </samp>");
            EndContext();
            BeginContext(1197, 19, false);
#line 22 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                            Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 80, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h4>Products: ");
            EndContext();
            BeginContext(1297, 22, false);
#line 25 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                     Write(Model.Products.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1319, 54, true);
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1373, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a789736d12e4603ca598bbfffc151bb259900f9709", async() => {
                BeginContext(1447, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1455, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1461, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a789736d12e4603ca598bbfffc151bb259900f12100", async() => {
                BeginContext(1516, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1532, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
