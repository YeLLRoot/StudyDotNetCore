#pragma checksum "F:\dotnet\CoreDemo\CoreDemo\Views\Shared\Components\UserCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1aef10ad5ee2e12bc878fe8849baa1509b5dc24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserCount_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserCount/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserCount/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_UserCount_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1aef10ad5ee2e12bc878fe8849baa1509b5dc24", @"/Views/Shared/Components/UserCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e649cb77bbf3dc2af22bfc20812b4fe9f17503", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 22, true);
            WriteLiteral("\r\n<h2>User:</h2>\r\n<h2>");
            EndContext();
            BeginContext(56, 10, false);
#line 4 "F:\dotnet\CoreDemo\CoreDemo\Views\Shared\Components\UserCount\Default.cshtml"
Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(66, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
