#pragma checksum "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da7005ce964fe2ae539e42eb641b2c3b2ec6af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\_ViewImports.cshtml"
using WEB_953506_SLIZH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\_ViewImports.cshtml"
using WEB_953506_SLIZH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\_ViewImports.cshtml"
using WEB_953506_SLIZH.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da7005ce964fe2ae539e42eb641b2c3b2ec6af0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbc55d496985bdc841f6fee25b4297664a4d5df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Main page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"container\">\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
   Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Список</h3>\r\n    <ol type=\"A\">\r\n");
#nullable restore
#line 10 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
         for (int i = 1; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>элемент ");
#nullable restore
#line 12 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" списка</li>\r\n");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n    <hr />  \r\n    <h2>Форма</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da7005ce964fe2ae539e42eb641b2c3b2ec6af04743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 17 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da7005ce964fe2ae539e42eb641b2c3b2ec6af06128", async() => {
                WriteLiteral(@"
        <div class=""form-group row"">
            <div class=""col-sm-2"">Флаг</div>
            <div class=""col-sm-10"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"" />
                    <label class=""form-check-label"" for=""gridCheck1"">
                        Флаг1
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" id=""gridCheck2"" />
                    <label class=""form-check-label"" for=""gridCheck2"">
                        Флаг2
                    </label>
                </div>
            </div>
        </div>

        <fieldset class=""form-group"">
            <div class=""row"">
                <legend class=""col-form-label col-sm-2 pt-0"">Радио</legend>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOp");
                WriteLiteral(@"tions"" id=""inlineRadio1"" value=""option1"">
                    <label class=""form-check-label"" for=""inlineRadio1"">Радио-1</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
                    <label class=""form-check-label"" for=""inlineRadio2"">Радио-2</label>
                </div>
                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio3"" value=""option2"">
                    <label class=""form-check-label"" for=""inlineRadio3"">Радио-3</label>
                </div>
            </div>
        </fieldset>

        <div class=""form-group row"">
            <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Логин</label>
            <div class=""col-sm-10"">
                <input type=""email""
                       class=""fo");
                WriteLiteral(@"rm-control""
                       id=""inputEmail3""
                       placeholder=""Введите имя"" />
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль</label>
            <div class=""col-sm-10"">
                <input type=""password""
                       class=""form-control""
                       id=""inputPassword3""
                       placeholder=""Введите пароль"" />
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""col-sm-10"">
                <button type=""submit"" class=""btn btn-primary"">Sign in</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>\r\n\r\n");
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
