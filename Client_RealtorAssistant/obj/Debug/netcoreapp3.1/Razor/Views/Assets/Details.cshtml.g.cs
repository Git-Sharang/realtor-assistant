#pragma checksum "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda90592d7cdd0c05d45c5426ad6ba5da6523aca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_Details), @"mvc.1.0.view", @"/Views/Assets/Details.cshtml")]
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
#line 1 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\_ViewImports.cshtml"
using Client_RealtorAssistant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\_ViewImports.cshtml"
using Client_RealtorAssistant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda90592d7cdd0c05d45c5426ad6ba5da6523aca", @"/Views/Assets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ecd27cdcff11da223fe7539b2500802cf080dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client_RealtorAssistant.Models.Asset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary rounded px-5 py-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 14px; font-weight: 500; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssetIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger backBtn ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 20px; font-weight: 500; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n    <div class=\"col\">\r\n        <h2>Details</h2>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <hr />\r\n    </div>\r\n</div>\r\n<dl class=\"row mt-3\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 19 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 22 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 25 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 28 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 31 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 34 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        <!-- ");
#nullable restore
#line 37 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
        Write(Html.DisplayNameFor(model => model.isOwned));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        -->\r\n        Owned\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 42 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayFor(model => model.isOwned));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 45 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.isSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 48 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
   Write(Html.DisplayFor(model => model.isSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n\r\n<div class=\"row mt-2\">\r\n    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda90592d7cdd0c05d45c5426ad6ba5da6523aca10145", async() => {
                WriteLiteral("EDIT");
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
#nullable restore
#line 54 "F:\MyStudy\HANDS-ON COLLEGE WORK\Semester5\API & Cloud Computing\Assignments\FinalProject\RealtorAssistant_FinalProject\Client_RealtorAssistant\Views\Assets\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda90592d7cdd0c05d45c5426ad6ba5da6523aca12552", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client_RealtorAssistant.Models.Asset> Html { get; private set; }
    }
}
#pragma warning restore 1591