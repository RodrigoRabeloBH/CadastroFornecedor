#pragma checksum "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe270a02ea3c7074355dd7fc63f37801e8b5300"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe270a02ea3c7074355dd7fc63f37801e8b5300", @"/Views/Provider/Detail.cshtml")]
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
    double price = 0;

#line default
#line hidden
            BeginContext(125, 46, true);
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"mt-4\">");
            EndContext();
            BeginContext(172, 17, false);
#line 8 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(189, 230, true);
            WriteLiteral("</h3>\r\n    <hr class=\"my-4\" />\r\n    <div class=\"row jumbotron\">\r\n        <div class=\"col-md-4\">\r\n            <h4 class=\"text-muted\">Information</h4>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Name: </samp>");
            EndContext();
            BeginContext(420, 10, false);
#line 13 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(430, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Document: </samp>");
            EndContext();
            BeginContext(521, 14, false);
#line 14 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                               Write(Model.Document);

#line default
#line hidden
            EndContext();
            BeginContext(535, 91, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Is Active: </samp>");
            EndContext();
            BeginContext(627, 14, false);
#line 15 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                                Write(Model.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(641, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Type: </samp>");
            EndContext();
            BeginContext(728, 18, false);
#line 16 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.ProviderType);

#line default
#line hidden
            EndContext();
            BeginContext(746, 185, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h4 class=\"text-muted\">Address</h4>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Street: </samp>");
            EndContext();
            BeginContext(932, 20, false);
#line 20 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                             Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(952, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(955, 20, false);
#line 20 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                                                    Write(Model.Address.Number);

#line default
#line hidden
            EndContext();
            BeginContext(975, 90, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">District: </samp>");
            EndContext();
            BeginContext(1066, 22, false);
#line 21 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                               Write(Model.Address.District);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 86, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">City: </samp>");
            EndContext();
            BeginContext(1175, 18, false);
#line 22 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                           Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 87, true);
            WriteLiteral("</p>\r\n            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">State: </samp>");
            EndContext();
            BeginContext(1281, 19, false);
#line 23 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                            Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 100, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h4 class=\"text-muted\">Products: (");
            EndContext();
            BeginContext(1401, 22, false);
#line 26 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                         Write(Model.Products.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1423, 8, true);
            WriteLiteral(")</h4>\r\n");
            EndContext();
#line 27 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
             foreach (var product in Model.Products)
            {

                price += Convert.ToDouble(product.Price);
            }

#line default
#line hidden
            BeginContext(1576, 85, true);
            WriteLiteral("            <p class=\"text-muted\"><samp class=\"font-weight-bolder\">Amount: </samp>R$ ");
            EndContext();
            BeginContext(1662, 5, false);
#line 32 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
                                                                                Write(price);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 53, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1720, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fe270a02ea3c7074355dd7fc63f37801e8b530011064", async() => {
                BeginContext(1794, 4, true);
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
#line 37 "C:\Dev\CadastroFornecedor\src\DevIo.App\Views\Provider\Detail.cshtml"
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
            BeginContext(1802, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1808, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fe270a02ea3c7074355dd7fc63f37801e8b530013456", async() => {
                BeginContext(1863, 12, true);
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
            BeginContext(1879, 10, true);
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
