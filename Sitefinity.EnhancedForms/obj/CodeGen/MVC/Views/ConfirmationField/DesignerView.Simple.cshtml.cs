#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 8 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Sitefinity.EnhancedForms;
    
    #line default
    #line hidden
    
    #line 5 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Sitefinity.EnhancedForms.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 1 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 7 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.StringResources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Localization;
    
    #line default
    #line hidden
    
    #line 4 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ConfirmationField/DesignerView.Simple.cshtml")]
    public partial class _MVC_Views_ConfirmationField_DesignerView_Simple_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _MVC_Views_ConfirmationField_DesignerView_Simple_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<uib-tabset");

WriteLiteral(" class=\"nav-tabs-wrapper\"");

WriteLiteral(">\r\n    <uib-tab");

WriteAttribute("heading", Tuple.Create(" heading=\"", 443), Tuple.Create("\"", 485)
            
            #line 11 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 453), Tuple.Create<System.Object, System.Int32>(Html.Resource("MainFieldLabel")
            
            #line default
            #line hidden
, 453), false)
);

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"title\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 15 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().Label);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"title\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"properties.Model.MetaField.Title.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 22 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                              Write(Res.Get<EnhancedFormsResources>().ExamplePassword);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"placeholderText\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().PlaceholderText);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"placeholderText\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"properties.Model.PlaceholderText.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" ng-hide=\"showInstructionalText || properties.Model.MetaField.Description.Propert" +
"yValue\"");

WriteLiteral(" ng-click=\"showInstructionalText=true;\"");

WriteLiteral(">");

            
            #line 36 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                                                                                                                          Write(Res.Get<FieldResources>().AddInstructionalText);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <div");

WriteLiteral(" ng-show=\"showInstructionalText || properties.Model.MetaField.Description.Propert" +
"yValue\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"example\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                Write(Res.Get<FieldResources>().InstructionalText);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-9\"");

WriteLiteral(">\r\n                        <textarea");

WriteLiteral(" id=\"example\"");

WriteLiteral(" ng-model=\"properties.Model.MetaField.Description.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                        <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 44 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                          Write(Res.Get<FieldResources>().ExampleExplanation);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n " +
"       </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"predefinedValue\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().PredefinedValue);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"predefinedValue\"");

WriteLiteral(" type=\"{{fieldInputType}}\"");

WriteLiteral(" ng-model=\"defaultValue.value\"");

WriteLiteral(" ng-value=\"properties.Model.MetaField.DefaultValue.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div" +
"");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.Required.PropertyValue\"");

WriteLiteral("\r\n                           ng-true-value=\"\'True\'\"");

WriteLiteral(" ng-false-value=\"\'False\'\"");

WriteLiteral(" ng-checked=\"properties.Model.ValidatorDefinition.Required.PropertyValue === \'Tru" +
"e\'\"");

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 68 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                Write(Res.Get<FieldResources>().RequiredField);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-show=\"properties.Model.ValidatorDefinition.Required.PropertyValue === \'True\'\"" +
"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"example\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 75 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().RequiredErrorMessageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"example\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.RequiredViolationMessage.Property" +
"Value\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"properties.Model.Hidden.PropertyValue\"");

WriteLiteral("\r\n                           ng-true-value=\"\'True\'\"");

WriteLiteral(" ng-false-value=\"\'False\'\"");

WriteLiteral(" ng-checked=\"properties.Model.Hidden.PropertyValue === \'True\'\"");

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 85 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                Write(Res.Get<FieldResources>().HiddenField);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n\r\n        <expand" +
"er");

WriteAttribute("expander-title", Tuple.Create(" expander-title=\'", 4183), Tuple.Create("\'", 4240)
            
            #line 90 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 4200), Tuple.Create<System.Object, System.Int32>(Res.Get<FieldResources>().MoreOptions
            
            #line default
            #line hidden
, 4200), false)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"textFieldTemplateName\"");

WriteLiteral(">");

            
            #line 92 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                               Write(Res.Get<FieldResources>().Template);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                        <select");

WriteLiteral(" id=\"textFieldTemplateName\"");

WriteLiteral(" ng-model=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n");

            
            #line 96 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 96 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                             foreach (var viewName in Html.GetViewNames(((Telerik.Sitefinity.Mvc.Proxy.MvcProxyBase)Model).GetController(), @"^Write\.(?<viewName>[\w\s]*)$"))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4841), Tuple.Create("\"", 4858)
            
            #line 98 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 4849), Tuple.Create<System.Object, System.Int32>(viewName
            
            #line default
            #line hidden
, 4849), false)
);

WriteLiteral("> ");

            
            #line 98 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                                      Write(viewName.SplitCamelCase());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 99 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </select>\r\n                    </div>\r\n                </" +
"div>\r\n            </div>\r\n            <style-dropdown");

WriteLiteral(" selected-class=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" view-name=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral("></style-dropdown>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"cssClass\"");

WriteLiteral(">");

            
            #line 106 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                  Write(Res.Get<FieldResources>().CssClasses);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"cssClass\"");

WriteLiteral(" ng-model=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n            </div>\r\n        </expander>\r\n    </uib-tab>\r\n    <uib-tab");

WriteAttribute("heading", Tuple.Create(" heading=\"", 5514), Tuple.Create("\"", 5564)
            
            #line 111 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 5524), Tuple.Create<System.Object, System.Int32>(Html.Resource("ConfirmationFieldLabel")
            
            #line default
            #line hidden
, 5524), false)
);

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"title\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 115 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().Label);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"title\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"properties.Model.ConfirmationTitle.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 122 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                              Write(Res.Get<EnhancedFormsResources>().ExampleConfirmPassword);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"placeholderText\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 126 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().PlaceholderText);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"placeholderText\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"properties.Model.ConfirmationPlaceholder.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"predefinedValue\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 137 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
            Write(Res.Get<FieldResources>().PredefinedValue);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"predefinedValue\"");

WriteLiteral(" type=\"{{fieldInputType}}\"");

WriteLiteral(" ng-model=\"properties.Model.ConfirmationDefaultValue.PropertyValue\"");

WriteLiteral(" ng-value=\"properties.Model.ConfirmationDefaultValue.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <exp" +
"ander");

WriteAttribute("expander-title", Tuple.Create(" expander-title=\'", 7067), Tuple.Create("\'", 7124)
            
            #line 147 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 7084), Tuple.Create<System.Object, System.Int32>(Res.Get<FieldResources>().MoreOptions
            
            #line default
            #line hidden
, 7084), false)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"textFieldTemplateName\"");

WriteLiteral(">");

            
            #line 149 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                               Write(Res.Get<FieldResources>().Template);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                        <select");

WriteLiteral(" id=\"textFieldTemplateName\"");

WriteLiteral(" ng-model=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n");

            
            #line 153 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 153 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                             foreach (var viewName in Html.GetViewNames(((Telerik.Sitefinity.Mvc.Proxy.MvcProxyBase)Model).GetController(), @"^Write\.(?<viewName>[\w\s]*)$"))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 7725), Tuple.Create("\"", 7742)
            
            #line 155 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 7733), Tuple.Create<System.Object, System.Int32>(viewName
            
            #line default
            #line hidden
, 7733), false)
);

WriteLiteral("> ");

            
            #line 155 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                                      Write(viewName.SplitCamelCase());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 156 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </select>\r\n                    </div>\r\n                </" +
"div>\r\n            </div>\r\n            <style-dropdown");

WriteLiteral(" selected-class=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" view-name=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral("></style-dropdown>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"cssClass\"");

WriteLiteral(">");

            
            #line 163 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                  Write(Res.Get<FieldResources>().CssClasses);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"cssClass\"");

WriteLiteral(" ng-model=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n            </div>\r\n        </expander>\r\n    </uib-tab>\r\n    <uib-tab");

WriteAttribute("heading", Tuple.Create(" heading=\"", 8398), Tuple.Create("\"", 8448)
            
            #line 168 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 8408), Tuple.Create<System.Object, System.Int32>(Res.Get<FieldResources>().Limitations
            
            #line default
            #line hidden
, 8408), false)
);

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"inputType\"");

WriteLiteral(">");

            
            #line 170 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                               Write(Res.Get<FieldResources>().Type);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <select");

WriteLiteral(" id=\"inputType\"");

WriteLiteral(" ng-model=\"properties.Model.InputType.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n");

            
            #line 174 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 174 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                         foreach (var typeName in Enum.GetNames(typeof(TextType)))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 8899), Tuple.Create("\"", 8916)
            
            #line 176 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 8907), Tuple.Create<System.Object, System.Int32>(typeName
            
            #line default
            #line hidden
, 8907), false)
);

WriteLiteral(">");

            
            #line 176 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                                  Write(((TextType)Enum.Parse(typeof(TextType), typeName)).ToHtmlInputType());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 177 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n      " +
"  </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label>");

            
            #line 183 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
               Write(Res.Get<FieldResources>().Range);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"row row-xs\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"minLength\"");

WriteLiteral(">");

            
            #line 186 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                       Write(Res.Get<FieldResources>().Min);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xs-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"maxLength\"");

WriteLiteral(">");

            
            #line 189 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                                       Write(Res.Get<FieldResources>().Max);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row row-xs sfDisplayFlex sfDisplayFlexCenteredHorizontally\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-2\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"minLength\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.MinLength.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xs-2\"");

WriteLiteral(">\r\n\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"maxLength\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.MaxLength.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xs-8\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 201 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                Write(Res.Get<FieldResources>().Characters);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"tooLarge\"");

WriteLiteral(">");

            
            #line 207 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                              Write(Res.Get<FieldResources>().TooLargeErrorMessageTitle);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"tooLarge\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.MaxLengthViolationMessage.Propert" +
"yValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"tooLarge\"");

WriteLiteral(">");

            
            #line 212 "..\..\MVC\Views\ConfirmationField\DesignerView.Simple.cshtml"
                             Write(Html.Resource("FieldsDoNotMatchErrorTitle"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"tooLarge\"");

WriteLiteral(" ng-model=\"properties.Model.ConfirmValidatorDefinition.FieldsDoNotMatchMessage.Pr" +
"opertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n        </div>\r\n    </uib-tab>\r\n</uib-tabset>\r\n");

        }
    }
}
#pragma warning restore 1591