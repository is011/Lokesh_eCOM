#pragma checksum "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2b343070c012d66b9d148f975edac6a383340d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FoodSummary), @"mvc.1.0.view", @"/Views/Shared/FoodSummary.cshtml")]
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
#line 1 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\_ViewImports.cshtml"
using LS_HW_eCOM;

#line default
#line hidden
#line 2 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\_ViewImports.cshtml"
using LS_HW_eCOM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2b343070c012d66b9d148f975edac6a383340d", @"/Views/Shared/FoodSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2809459acb64ac104f56d6de106c6cd23b8ccf66", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FoodSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LS_HW_eCOM.ViewModels.Food.FoodListingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:20%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("oninput", new global::Microsoft.AspNetCore.Html.HtmlString("this.value = this.value.replace(/[^0-9.]/g, \'\').replace(/(\\..*)\\./g, \'$1\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Add to cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"btn-addToCart\">\n    <div class=\"categoryPrice\"> <input readonly class=\"form-control\" style=\"outline:none\"");
            BeginWriteAttribute("id", " id=\"", 169, "\"", 206, 2);
            WriteAttributeValue("", 174, "foodTotal-", 174, 10, true);
#line 4 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 184, Model.GetHashCode(), 184, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 207, "\"", 227, 1);
#line 4 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 215, Model.Total, 215, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("></div>\n");
#line 5 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
     if(User.IsInRole("Admin"))
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"categoryPrice\">In Stock: ");
#line 7 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
                                        Write(Model.InStock);

#line default
#line hidden
            WriteLiteral("</div>\n");
#line 8 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
    } 

#line default
#line hidden
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2b343070c012d66b9d148f975edac6a383340d9821", async() => {
                WriteLiteral("\n        <a");
                BeginWriteAttribute("onclick", " onclick=\"", 465, "\"", 628, 9);
                WriteAttributeValue("", 475, "changeValue(document.getElementById(\'amount-input-\'+", 475, 52, true);
#line 10 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 527, Model.Id.ToString(), 527, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 547, "),", 547, 2, true);
                WriteAttributeValue(" ", 549, "document.getElementById(\'foodTotal-", 550, 36, true);
#line 10 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 585, Model.GetHashCode(), 585, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 607, "\'),\'", 607, 4, true);
#line 10 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 611, Model.Total, 611, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 623, "\',", 623, 2, true);
                WriteAttributeValue(" ", 625, "1)", 626, 3, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-plus-circle\"></i></a>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2b343070c012d66b9d148f975edac6a383340d11395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 688, "amount-input-", 688, 13, true);
#line 11 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
AddHtmlAttributeValue("", 701, Model.Id, 701, 9, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#line 11 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <a");
                BeginWriteAttribute("onclick", " onclick=\"", 856, "\"", 1020, 9);
                WriteAttributeValue("", 866, "changeValue(document.getElementById(\'amount-input-\'+", 866, 52, true);
#line 12 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 918, Model.Id.ToString(), 918, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 938, "),document.getElementById(\'foodTotal-", 938, 37, true);
#line 12 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 975, Model.GetHashCode(), 975, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 997, "\'),", 997, 3, true);
                WriteAttributeValue(" ", 1000, "\'", 1001, 2, true);
#line 12 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 1002, Model.Total, 1002, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 1014, "\',", 1014, 2, true);
                WriteAttributeValue(" ", 1016, "-1)", 1017, 4, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-minus-circle\"></i></a>\n        <div class=\"btn-cart\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2b343070c012d66b9d148f975edac6a383340d15128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 14 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
                                                                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 14 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
                                                                                                                                                           WriteLiteral(Model.Amount);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["amount"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-amount", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["amount"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 14 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
                                                                                                                                                                                                WriteLiteral(Context.Request.Path);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<div class=\"foodData\">\n    <div class=\"foodName\">\n        <div class=\"categoryLogo\"");
            BeginWriteAttribute("style", " style=\"", 1439, "\"", 1486, 4);
            WriteAttributeValue("", 1447, "background-image:", 1447, 17, true);
            WriteAttributeValue(" ", 1464, "url(", 1465, 5, true);
#line 21 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
WriteAttributeValue("", 1469, Model.ImageUrl, 1469, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1484, ");", 1484, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2b343070c012d66b9d148f975edac6a383340d22049", async() => {
                WriteLiteral("\n            ");
#line 23 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
                WriteLiteral("\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\Proffesional\Code Heap\Lokesh_eCOM\Lokesh_eCOM\LS_HW_eCOM\Views\Shared\FoodSummary.cshtml"
                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LS_HW_eCOM.ViewModels.Food.FoodListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591