#pragma checksum "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2dff9ac1ead7c5d0b935ac2c582e9d96e69f2e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamLead_Team), @"mvc.1.0.view", @"/Views/TeamLead/Team.cshtml")]
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
#line 1 "D:\Develpment\Vacation-Manager\VManager\Views\_ViewImports.cshtml"
using VManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Develpment\Vacation-Manager\VManager\Views\_ViewImports.cshtml"
using VManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2dff9ac1ead7c5d0b935ac2c582e9d96e69f2e7", @"/Views/TeamLead/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a725a7aba3467548896b764a7d9e1b4af1debed6", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamLead_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
  
    ViewData["Title"] = "TeamLead | Team ";
    Layout = "_TeamLeadLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Team Name - ");
#nullable restore
#line 6 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
           Write(ViewBag.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
 foreach (var item in Model)
{
    if (item.IsLeader)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Team Leader: ");
#nullable restore
#line 13 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                    Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                                    Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h2>\r\n");
#nullable restore
#line 14 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n    Project Name:  ");
#nullable restore
#line 17 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
              Write(ViewBag.Team.Project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n\r\n");
#nullable restore
#line 20 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <h3>Developers List</h3>\r\n        <td>\r\n            ");
#nullable restore
#line 25 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                       Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n\r\n    </tr>\r\n");
#nullable restore
#line 30 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n\r\n<h2>Add Developer</h2>\r\n<select name=\"developers\" id=\"developers\">\r\n");
#nullable restore
#line 36 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2dff9ac1ead7c5d0b935ac2c582e9d96e69f2e75977", async() => {
#nullable restore
#line 38 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 38 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                                            Write(item.Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</select>\r\n\r\n<hr />\r\n\r\n<h2>Remove Developer</h2>\r\n<select name=\"developers\" id=\"developers\">\r\n");
#nullable restore
#line 49 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2dff9ac1ead7c5d0b935ac2c582e9d96e69f2e78503", async() => {
#nullable restore
#line 51 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 51 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
                                            Write(item.Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"
           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Develpment\Vacation-Manager\VManager\Views\TeamLead\Team.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</select>");
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