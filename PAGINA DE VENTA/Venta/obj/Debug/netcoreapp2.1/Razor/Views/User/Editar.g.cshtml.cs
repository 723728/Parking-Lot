#pragma checksum "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d510da303024a4f12177dffc5333b11b36fbc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Editar), @"mvc.1.0.view", @"/Views/User/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Editar.cshtml", typeof(AspNetCore.Views_User_Editar))]
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
#line 1 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot;

#line default
#line hidden
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\_ViewImports.cshtml"
using Parking_Lot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d510da303024a4f12177dffc5333b11b36fbc6", @"/Views/User/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba31bce4d6792040e1e3028d4de7935a6682c098", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Masculino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Femenino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 137, true);
            WriteLiteral("\r\n\r\n<div class=\"well\">\r\n    <div id=\"myTabContent\" class=\"tab-content\">\r\n        <div class=\"tab-pane active in\" id=\"home\">\r\n            ");
            EndContext();
            BeginContext(166, 1034, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bc7770fb79740699c744bed6d0bceaa", async() => {
                BeginContext(208, 92, true);
                WriteLiteral("\r\n                <label>Nombre</label>\r\n                <input type=\"text\" name=\"FirstName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 300, "\"", 324, 1);
#line 12 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
WriteAttributeValue("", 308, Model.FirstName, 308, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(325, 115, true);
                WriteLiteral(" class=\"input-xlarge\">\r\n                <label>Apellido</label>\r\n                <input type=\"text\" name=\"LastName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 440, "\"", 463, 1);
#line 14 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
WriteAttributeValue("", 448, Model.LastName, 448, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(464, 123, true);
                WriteLiteral(" class=\"input-xlarge\">\r\n                <label>Correo Electronico</label>\r\n                <input type=\"email\" name=\"Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 587, "\"", 607, 1);
#line 16 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
WriteAttributeValue("", 595, Model.Email, 595, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(608, 119, true);
                WriteLiteral(" class=\"input-xlarge\">\r\n                <label>Fecha Nacimiento</label>\r\n                <input type=\"date\" name=\"Date\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 727, "\"", 769, 1);
#line 18 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
WriteAttributeValue("", 735, Model.Date.ToString("dd-MM-yyyy"), 735, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(770, 100, true);
                WriteLiteral(" class=\"input-xlarge\">\r\n                <label>Genero</label>\r\n                <select name=\"Genero\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 870, "\"", 891, 1);
#line 20 "C:\Users\CyberCup\Desktop\Parking_Lot\Parking_Lot\Views\User\Editar.cshtml"
WriteAttributeValue("", 878, Model.Genero, 878, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(892, 44, true);
                WriteLiteral(" class=\"input-xlarge\">\r\n                    ");
                EndContext();
                BeginContext(936, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d70235638a1a4a6cbf486a40b162037c", async() => {
                    BeginContext(962, 9, true);
                    WriteLiteral("Masculino");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(980, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1002, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf45e2f86e16421baf13ff408d1eab94", async() => {
                    BeginContext(1027, 8, true);
                    WriteLiteral("Femenino");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1044, 149, true);
                WriteLiteral("\r\n                </select>\r\n                <div>\r\n                    <button class=\"btn\">Actualizar</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1200, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
