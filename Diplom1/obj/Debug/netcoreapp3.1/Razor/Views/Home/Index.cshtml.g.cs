#pragma checksum "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf60e652eeee18e239e1753508f620fdb82f4ed"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf60e652eeee18e239e1753508f620fdb82f4ed", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Diplom1.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Все пользователи";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a asp-action=\"Create\">Добавить товар</a>\r\n<table class=\"table\">\r\n    <tr><td>Имя</td><td>Цена</td><td>Описание</td></tr>\r\n");
#nullable restore
#line 8 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 10 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 10 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 10 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
                                                  Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 11 "C:\Users\Egorka\Desktop\Diplom1\Diplom1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div class=\"form-group\">\r\n    <input type=\"submit\" value=\"Отправить\" class=\"btn btn-default\" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Diplom1.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591