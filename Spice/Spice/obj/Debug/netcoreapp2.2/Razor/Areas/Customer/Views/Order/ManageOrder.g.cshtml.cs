#pragma checksum "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b55dbcd08c662e9f538555601571353c21e244c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_ManageOrder), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/ManageOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Order/ManageOrder.cshtml", typeof(AspNetCore.Areas_Customer_Views_Order_ManageOrder))]
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
#line 1 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#line 2 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
using Spice.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b55dbcd08c662e9f538555601571353c21e244c1", @"/Areas/Customer/Views/Order/ManageOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_ManageOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Spice.Models.ViewModels.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded border form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:75px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderPrepare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderReady", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(86, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 3 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
      
        ViewData["Title"] = "ManageOrder";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
            BeginContext(196, 53, true);
            WriteLiteral("\r\n    <h2 class=\"text-info\">Manage Order\'s</h2>\r\n    ");
            EndContext();
            BeginContext(249, 4422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c17913", async() => {
                BeginContext(269, 18, true);
                WriteLiteral("\r\n        <br />\r\n");
                EndContext();
#line 11 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
                BeginContext(329, 74, true);
                WriteLiteral("            <div class=\"container row bg-white p-2 border mb-3 rounded\">\r\n");
                EndContext();
#line 14 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(468, 273, true);
                WriteLiteral(@"                    <div class=""col-12 pb-3 pt-3"">
                        <div class=""backgroundWhiteBorder10Padding"">
                            <div class=""row"">
                                <div class=""col-4"">
                                    Order Number : ");
                EndContext();
                BeginContext(742, 19, false);
#line 20 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                              Write(item.OrderHeader.Id);

#line default
#line hidden
                EndContext();
                BeginContext(761, 62, true);
                WriteLiteral("\r\n                                    <ul class=\"text-info\">\r\n");
                EndContext();
#line 22 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                         foreach (var details in item.OrderDetails)
                                        {

#line default
#line hidden
                BeginContext(951, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(1000, 12, false);
#line 24 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                           Write(details.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1012, 3, true);
                WriteLiteral(" x ");
                EndContext();
                BeginContext(1016, 13, false);
#line 24 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                                           Write(details.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1029, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 25 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                        }

#line default
#line hidden
                BeginContext(1079, 522, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""col-4 pb-2"">
                                    <div class=""input-group pb-2"">
                                        <div class=""input-group-append"">
                                            <span class=""input-group-text"">Time</span>
                                        </div>
                                        <input type=""text"" class=""border rounded form-control"" readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1601, "\"", 1637, 1);
#line 33 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
WriteAttributeValue("", 1609, item.OrderHeader.PickUpTime, 1609, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1638, 49, true);
                WriteLiteral(" />\r\n                                    </div>\r\n");
                EndContext();
#line 35 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                      
                                        var comments = item.OrderHeader.Comments;
                                        if (comments == null || comments.Trim().Length == 0)
                                        {
                                            item.OrderHeader.Comments = "No Instructions";
                                        }

                                    

#line default
#line hidden
                BeginContext(2123, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2159, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c113104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 43 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.OrderHeader.Comments);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2294, 132, true);
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-3 offset-1 d-flex align-content-center\">\r\n");
                EndContext();
#line 46 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                     if (item.OrderHeader.Status.Equals(SD.StatusSubmitted))
                                    {

#line default
#line hidden
                BeginContext(2559, 106, true);
                WriteLiteral("                                        <div class=\"col-12\">\r\n                                            ");
                EndContext();
                BeginContext(2665, 282, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c115901", async() => {
                    BeginContext(2793, 145, true);
                    WriteLiteral("\r\n                                                <i class=\"fas fa-check\"></i> &nbsp; Start Cooking\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 49 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                                                                                   WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2947, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(2993, 282, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c118867", async() => {
                    BeginContext(3122, 144, true);
                    WriteLiteral("\r\n                                                <i class=\"fas fa-times\"></i> &nbsp; Cancel Order\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 52 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                                                                                  WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3275, 50, true);
                WriteLiteral("\r\n                                        </div>\r\n");
                EndContext();
#line 56 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#line 59 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                         if (item.OrderHeader.Status.Equals(SD.StatusInProcess))
                                        {

#line default
#line hidden
                BeginContext(3586, 114, true);
                WriteLiteral("                                            <div class=\"col-12\">\r\n                                                ");
                EndContext();
                BeginContext(3700, 298, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c122660", async() => {
                    BeginContext(3829, 160, true);
                    WriteLiteral("\r\n                                                    <i class=\"fas fa-flag-checkered\"></i> &nbsp; Order Ready\r\n                                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 62 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                                                                                     WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3998, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(4048, 290, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b55dbcd08c662e9f538555601571353c21e244c125647", async() => {
                    BeginContext(4177, 152, true);
                    WriteLiteral("\r\n                                                    <i class=\"fas fa-times\"></i> &nbsp; Cancel Order\r\n                                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 65 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                                                                                      WriteLiteral(item.OrderHeader.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4338, 54, true);
                WriteLiteral("\r\n                                            </div>\r\n");
                EndContext();
#line 69 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                        }

#line default
#line hidden
#line 69 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                                         
                                    }

#line default
#line hidden
                BeginContext(4474, 136, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 75 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
                }

#line default
#line hidden
                BeginContext(4629, 20, true);
                WriteLiteral("            </div>\r\n");
                EndContext();
#line 77 "C:\Users\WORKDESK\Desktop\PMIT MSC PROJECT\Spice\Spice\Areas\Customer\Views\Order\ManageOrder.cshtml"
        }

#line default
#line hidden
                BeginContext(4660, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4671, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Spice.Models.ViewModels.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
