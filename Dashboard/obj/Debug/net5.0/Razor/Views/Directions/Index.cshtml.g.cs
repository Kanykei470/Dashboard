#pragma checksum "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c009fabdf5340f5ef829aa6a03e990aac32d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directions_Index), @"mvc.1.0.view", @"/Views/Directions/Index.cshtml")]
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
#line 1 "D:\Dashboard\Dashboard\Views\_ViewImports.cshtml"
using Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dashboard\Dashboard\Views\_ViewImports.cshtml"
using Dashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c009fabdf5340f5ef829aa6a03e990aac32d25", @"/Views/Directions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb225a8b7775b6d65d4bc41cad2c9bd60636940", @"/Views/_ViewImports.cshtml")]
    public class Views_Directions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dashboard.Models.Direction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("forma"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\"  href=\"Ds.css\">\r\n\r\n");
#nullable restore
#line 5 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
<h1 class=""text-center"">Направления</h1>
 <h5 class=""text-center"" >
     <input id=""ID"" readonly>
 </h5>
 <style>
     #ID{
         border: none;
         align-self: center;
         background-color:#72b9f3;
         outline:none;
        text-align: center;
     }
 </style>
 </div>
 
<script>
    addEventListener('DOMContentLoaded', function() {
    var tr = document.querySelectorAll('tr');
    let input = document.querySelector(""#ID"");
    input.value="" ""+tr.length+"" Направления "";
    
    });


    
</script>




<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c009fabdf5340f5ef829aa6a03e990aac32d255695", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c009fabdf5340f5ef829aa6a03e990aac32d256862", async() => {
                WriteLiteral(" \r\n    <input type=\"hidden\" name=\"Id\" id=\"Idinput\">\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script >\r\n    function func(ID){\r\n        let a = document.querySelector(\"#Idinput\");\r\n        a.value=ID;\r\n        let form = document.forms.forma;\r\n        form.submit();\r\n    };\r\n</script>\r\n\r\n");
            WriteLiteral("<div class=\"container-fluid\" style=\"margin-top:10px\" >\r\n    <div class=\"row display-flex\"   style=\"cursor: pointer;\"&gt;&lt;/div&gt;>\r\n\r\n");
#nullable restore
#line 61 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
         foreach (var pur in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div  class=""col-sm-4"" >
            <table class=""table table-bordered"" style=""border-color:transparent; box-shadow: 0 1px 9px 0 rgba(0, 0, 0, 0.1), 0 1px 10px 0 rgba(0, 0, 0, 0.19);border-top-left-radius:30px;border-top-right-radius:30px;"">
                <tr  style=""text-align:center"">

                    <td colspan=""2"" style=""border-color:transparent;"">
                       
                         <span style=""color:#337ab7"">");
#nullable restore
#line 69 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
                                                Write(pur.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                         <span style=\"color:indianred\">Completion : </span>");
#nullable restore
#line 70 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
                                                                      Write(pur.Completion);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                         <span style=\"color:indianred\">Priority : </span>");
#nullable restore
#line 71 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
                                                                    Write(pur.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                        <span id=\"Id\" style=\"color:indianred\">id : </span>");
#nullable restore
#line 72 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
                                                                     Write(pur.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                        <input type=\"hidden\" id=\"Idpr\"");
            BeginWriteAttribute("value", " value=\"", 2086, "\"", 2101, 1);
#nullable restore
#line 73 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
WriteAttributeValue("", 2094, pur.Id, 2094, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <input type=\"button\" value=\"B\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2159, "\"", 2182, 3);
            WriteAttributeValue("", 2169, "func(", 2169, 5, true);
#nullable restore
#line 74 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
WriteAttributeValue("", 2174, pur.Id, 2174, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, ")", 2181, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                 </tr>\r\n            </table>\r\n            </div>\r\n");
#nullable restore
#line 79 "D:\Dashboard\Dashboard\Views\Directions\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n");
            WriteLiteral(@"
<div class=""box"">
    <div class=""wave lightblue""></div>
</div>
<script>

   
    
    var wave =document.querySelector('.wave');
    var bottom=-170;

    window.addEventListener('load',function(){
        move();
    });

    function move(){
        var id =setInterval(frame,2000);
    }

    function frame(){
        if(bottom>=-120){
            wave.style.bottom=bottom+""%"";
            bottom=bottom-25%;
        }else{
             wave.style.bottom=bottom+""%"";
            bottom=bottom--15%;
        }
    }
</script>

");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dashboard.Models.Direction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
