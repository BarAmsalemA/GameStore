#pragma checksum "C:\Users\baram\source\repos\GameStore_IL\GameStore_IL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d438921a34818c7ef3a35f574e5b8803b88d8097"
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
#line 1 "C:\Users\baram\source\repos\GameStore_IL\GameStore_IL\Views\_ViewImports.cshtml"
using GameStore_IL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\baram\source\repos\GameStore_IL\GameStore_IL\Views\_ViewImports.cshtml"
using GameStore_IL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d438921a34818c7ef3a35f574e5b8803b88d8097", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00f72ce0b24a262203393191ffee3dc39394825", @"/Views/_ViewImports.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\baram\source\repos\GameStore_IL\GameStore_IL\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d438921a34818c7ef3a35f574e5b8803b88d80973287", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">ברוכים הבאים לחנות המשחקים הגדולה בישראל</h1>\r\n    </div>\r\n    <div id=\"body\">\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
    console.log(""Works!"");
    const body = document.getElementById(""body"");

    const mock = [
        {
            title: ""משחקי חשיבה"",
            text: 'שחק חשיבה הוא אחד האמצעים הטובים לפיתוח מיומנויות חשיבה בשילוב הנאה. המשחקים מהווים ""תרגילי התעמלות למוח"" ומפתחים מגוון מיומנויות חשיבה',
            img: '/Photos/suduku.jpg'
        },
        {
            title: ""משחקי קופסא"",
            text: ""משחקי לוח, משחקי קלפים, משחקי קוביות, משחקי מלחמה ועוד."",
            img: '/Photos/BoxGame.png.jpg'
        },
        {
            title: ""משחקי ואביזרי ספורט"",
            text: ""אביזרי התעמלות, כדורים, ציוד התעמלות."",
            img: ' /Photos/ballgames.jpg'
        },
        {
            title: ""משחקי מחשב וקונסולה"",
            text: ""משחקים חדישים, ציוד היקפי"",
            img: ' /Photos/CmGames.jpg'
        },
        {
            title: ""משחקי לגו"",
            text: ""ציוד לגו להרכבה ובנייה"",
            img: ' /Photos/Lego_bricks.jpg'
        }");
            WriteLiteral(@",
        {
            title: ""משחקי מחשב וקונסולה"",
            text: ""משחקים חדישים, ציוד היקפי"",
            img: ' /Photos/CmGames.jpg'
        }
    ]
    setTimeout(() => {
        for (let i = 0; i < mock.length; i++) {
            $(""#body"").append(
                '<div class= ""card col-sm-4"" > <img src=' + mock[i].img + ' class=""card-img-top"" alt=""..."">' +
                '<div class=""card-body"">' +
                '<h5 class=""card-title"">' + mock[i].title + '</h5>' +
                '<p class=""card-text"">' + mock[i].text + '</p>' +
                '<a href=""#"" class=""btn btn-primary"">Go somewhere</a>' +
                '</div>' +
                '</div>'
            )
        };
    },2000)


</script>

<style>
    .card {
        transition: all 0.5s;
    }
    .card:hover {
        box-shadow: 5px 5px 15px 5px #000000
    }
</style>");
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