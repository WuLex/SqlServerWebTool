#pragma checksum "E:\mynetcoreProject\SqlServerWebTool\SqlServerWebToolProject\Views\Manager\Explorer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37b2e63cdcaaea5c5129960070d4dceec270c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Explorer), @"mvc.1.0.view", @"/Views/Manager/Explorer.cshtml")]
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
#line 1 "E:\mynetcoreProject\SqlServerWebTool\SqlServerWebToolProject\Views\_ViewImports.cshtml"
using SqlServerWebToolProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\mynetcoreProject\SqlServerWebTool\SqlServerWebToolProject\Views\_ViewImports.cshtml"
using SqlServerWebToolProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37b2e63cdcaaea5c5129960070d4dceec270c23", @"/Views/Manager/Explorer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed1d9939d19c8c63fef2ca9af7cbd6c20467ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Explorer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("easyui-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\mynetcoreProject\SqlServerWebTool\SqlServerWebToolProject\Views\Manager\Explorer.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37b2e63cdcaaea5c5129960070d4dceec270c234739", async() => {
                WriteLiteral(@"
    <title>Database 浏览器 - SqlServerWebTool</title>
    <link type=""text/css"" rel=""Stylesheet"" href=""/js/jquery/jquery-easyui-1.9/themes/default/easyui.css"" />
    <link type=""text/css"" rel=""Stylesheet"" href=""/js/jquery/jquery-easyui-1.9/themes/icon.css"" />
    <link type=""text/css"" rel=""Stylesheet"" href=""/js/syntaxhighlighter/shCore.css"" />
    <link type=""text/css"" rel=""Stylesheet"" href=""/js/syntaxhighlighter/shThemeDefault.css"" />
    <link type=""text/css"" rel=""Stylesheet"" href=""/css/StyleSheet.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37b2e63cdcaaea5c5129960070d4dceec270c235546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"" src=""/js/jquery/jquery.cookie.js""></script>
    <script type=""text/javascript"" src=""/js/jquery/jquery-easyui-1.9/jquery.easyui.min.js""></script>
    <script type=""text/javascript"" src=""/js/jquery/jquery-easyui-1.9/easyui-lang-zh_CN.js""></script>
    <script type=""text/javascript"" src=""/js/syntaxhighlighter/shCore.js""></script>
    <script type=""text/javascript"" src=""/js/syntaxhighlighter/shBrushSql.js""></script>
    <script type=""text/javascript"" src=""/js/my/fish.js""></script>
    <script type=""text/javascript"" src=""/js/my/Explorer.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37b2e63cdcaaea5c5129960070d4dceec270c238057", async() => {
                WriteLiteral(@"
    <div data-options=""region:'north',split:true,hideCollapsedContent:false"" style=""height: 100px; overflow: hidden; padding: 3px 10px; ""
         title=""数据库连接参数"">
        <table cellpadding=""3"" cellspacing=""0"" id=""tblConnectionInfo"" style=""border: 0px; float: left;"">
            <tr>
                <td>
                    <b id=""labDbType"" class=""redText""></b>&nbsp;连接参数
                </td>
                <td>
                    Server
                </td>
                <td>
                    <input type=""text"" id=""txtServer"" style=""width: 230px"" readonly=""readonly"" />
                </td>
                <td>
                    UserName
                </td>
                <td>
                    <input type=""text"" id=""txtUserName"" style=""width: 170px"" readonly=""readonly"" />
                </td>
                <td style=""display: none"">
                    Password
                </td>
                <td style=""display: none"">
                    <input type=""passw");
                WriteLiteral(@"ord"" id=""txtPassword"" style=""width: 150px"" readonly=""readonly"" />
                </td>
                <td>
                    <a href=""#"" id=""btnRefresh"" class=""easyui-linkbutton"" iconcls=""icon-reload"">刷新对象列表</a>
                </td>
            </tr>
        </table>
        <div style=""float: right; padding-top: 12px;"">
            <label title=""显示代码时显示行号"">
                <input type=""checkbox"" id=""chkEnableGutter"" />行号
            </label>
        </div>
    </div>

    <div data-options=""region:'west',split:true"" style=""width: 350px;"" title=""对象列表"">
        <ul id=""ulTree"">
        </ul>
    </div>

    <div data-options=""region:'center'"" style=""overflow: hidden;"">
        <div id=""tabs"" class=""easyui-tabs"" fit=""true"" border=""false"" style=""overflow: hidden;"">
            <div title=""操作说明"" style=""overflow: scroll;"" closable=""true"">
                <div style=""padding: 20px"">
                    <p>
                        １、点击“刷新对象列表”按钮，然后点击左边树节点即可查看相关的存储过程或表定义。
               ");
                WriteLiteral(@"     </p>
                    <p style=""padding-top: 25px"">
                        ２、直接点击或右击表名或存储过程名，然后点击弹出的右键菜单项。如图：<img src=""/Images/menu1.png"" />
                    </p>
                    <p style=""padding-top: 25px"">
                        ３、如果打开了多个标签页，可以在标签上右击鼠标。如图：<img src=""/Images/menu2.png"" />
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""waitMessageStyle"">
        <img src=""/Images/progress_loading.gif"" /><span>请稍后......</span>
    </div>


    <div id=""mm_tab"" class=""easyui-menu"" style=""width: 160px;"">
        <div id=""mm_closeCurrent"" iconcls=""icon-close"">
            关闭当前页
        </div>
        <div id=""mm_closeAll"">
            关闭全部页
        </div>
        <div id=""mm_closeOthers"">
            关闭其它标签页
        </div>
    </div>
    <div id=""mm_tree"" class=""easyui-menu"" style=""width: 160px;"">
        <div id=""mm_open"" iconcls=""icon-open"">
            当前页打开
        </div>
        <div id=""mm_openInNew");
                WriteLiteral(@"Tab"">
            在新标签页中打开
        </div>
        <div class=""menu-sep"">
        </div>
        <div id=""mm_CopyItemName"" iconcls=""icon-Copy"">
            复制项目名称
        </div>
        <div id=""mm_Search1"" iconcls=""icon-Search2"">
            在数据库中搜索
        </div>
        <div class=""menu-sep"">
        </div>
        <div id=""mm_ShowMultiItem"" iconcls=""icon-sql"">
            显示所有勾选项代码
        </div>
        <div id=""mm_DeleteSelectedItems1"" iconcls=""icon-delete2"">
            删除所有勾选项
        </div>
    </div>
    <div id=""mm_tree2"" class=""easyui-menu"" style=""width: 160px;"">
        <div id=""mm_RefreshNodes"" iconcls=""icon-Refresh"">
            刷新数据库对象
        </div>
        <div class=""menu-sep"">
        </div>
        <div id=""mm_CopyItemName2"" iconcls=""icon-Copy"">
            复制项目名称
        </div>
        <div id=""mm_Search2"" iconcls=""icon-Search2"">
            在数据库中搜索
        </div>
        <div class=""menu-sep"">
        </div>
        <div id=""mm_ShowMultiItem2"" iconcls=""i");
                WriteLiteral(@"con-sql"">
            显示所有勾选项代码
        </div>
        <div id=""mm_DeleteSelectedItems2"" iconcls=""icon-delete2"">
            删除所有勾选项
        </div>
    </div>
    <div id=""mm_tree3"" class=""easyui-menu"" style=""width: 160px;"">
        <div id=""mm_Search3"" iconcls=""icon-Search2"">
            在数据库中搜索
        </div>
        <div class=""menu-sep"">
        </div>
        <div id=""mm_ShowMultiItem3"" iconcls=""icon-sql"">
            显示所有勾选项代码
        </div>
        <div id=""mm_DeleteSelectedItems3"" iconcls=""icon-delete2"">
            删除所有勾选项
        </div>
    </div>
    <div style=""display: none"">
        <input type=""hidden"" id=""hidden_ConnectionId"" />
    </div>
    <div id=""divSearchDialog"" style=""padding: 10px; width: 450px; height: 260px; display: none;""
         title=""在数据库中搜索"">
        <table cellpadding=""4"" cellspacing=""0"" style=""width: 100%; border: 0px;"">
            <tr>
                <td style=""width: 80px"">
                    数据库
                </td>
                <td>");
                WriteLiteral(@"
                    <span id=""spanCurrentSearchDB""></span>
                </td>
            </tr>
            <tr>
                <td>
                    关键词
                </td>
                <td>
                    <input type=""text"" id=""txtSearchWord"" class=""myTextbox"" style=""width: 300px"" />
                </td>
            </tr>
            <tr>
                <td>
                    匹配方式
                </td>
                <td>
                    <label>
                        <input type=""checkbox"" id=""chkWholeMatch"" />全字符匹配
                    </label>
                    <label>
                        <input type=""checkbox"" id=""chkCaseSensitive"" />区分大小写
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    搜索范围
                </td>
                <td id=""tdSearchScope"">
                    <label title=""需要搜索表定义"">
                        <input type=""checkbox"" id=""chkTable"" />T
   ");
                WriteLiteral(@"                 </label>
                    <label title=""需要搜索视图定义"">
                        <input type=""checkbox"" id=""chkView"" />V
                    </label>
                    <label title=""需要搜索存储过程"">
                        <input type=""checkbox"" id=""chkProcedure"" checked=""checked"" />P
                    </label>
                    <label title=""需要搜索自定义函数"">
                        <input type=""checkbox"" id=""chkFunction"" />F
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    限制结果
                </td>
                <td>
                    最多显示<input type=""text"" id=""txtLimitCount"" value=""50"" class=""myTextbox"" style=""width: 40px; height: 17px;"" title=""请注意：如果找到的结果太多，有些浏览器在显示时会比较慢，而且也没多大意义。"" />个结果，0 表示不限制。
                </td>
            </tr>
        </table>
    </div>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
