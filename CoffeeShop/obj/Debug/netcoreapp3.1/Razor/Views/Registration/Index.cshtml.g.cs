#pragma checksum "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab85125be8c0626f20449735aefda7ef7180dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Index), @"mvc.1.0.view", @"/Views/Registration/Index.cshtml")]
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
#line 1 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab85125be8c0626f20449735aefda7ef7180dfe", @"/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShop.Models.UserRegistration>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
  
    if (ViewData["errorMsg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 12 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
      Write(ViewData["errorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe5652", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 20 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 28 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 32 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.EditorFor(m => m.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 36 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 40 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.CoffeePreference));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe9557", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
                      
                        string[] type = MenuItems.CoffeeType;
                        foreach (string t in type)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe10257", async() => {
#nullable restore
#line 47 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
                               Write(t);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 42 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CoffeePreference);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 54 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
           Write(Html.LabelFor(m => m.Newsletter));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe13551", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe13840", async() => {
                        WriteLiteral("Yes");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab85125be8c0626f20449735aefda7ef7180dfe14928", async() => {
                        WriteLiteral("No");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 56 "C:\Users\skatrivesis\OneDrive - Knex\Documents\GrandCircus\Labs\CoffeeShop\CoffeeShop\Views\Registration\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Newsletter);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th><input type=\"submit\" value=\"Register!\" /></th>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShop.Models.UserRegistration> Html { get; private set; }
    }
}
#pragma warning restore 1591
