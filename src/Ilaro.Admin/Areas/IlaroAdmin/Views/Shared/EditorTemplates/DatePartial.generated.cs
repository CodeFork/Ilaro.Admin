﻿#pragma warning disable 1591
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Core.Extensions;
    using Ilaro.Admin.Core.Models;
    using Ilaro.Admin.Core.Models.Paging;
    using Ilaro.Admin.Extensions;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Shared/EditorTemplates/DatePartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_EditorTemplates_DatePartial_cshtml_ : System.Web.Mvc.WebViewPage<PropertyValue>
    {
        public _Areas_IlaroAdmin_Views_Shared_EditorTemplates_DatePartial_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"input-group date date-picker\"");

WriteLiteral(" data-date-format=\"");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\DatePartial.cshtml"
                                                           Write(Model.Property.GetUIDateFormat());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\DatePartial.cshtml"
   Write(Html.TextBox(Model.Property.Name, Model.AsObject.ToShortDateString(Model.Property), Model.Property, new { @class = "form-control", data_date_format = Model.Property.GetUIDateFormat() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"glyphicon glyphicon-calendar\"");

WriteLiteral("></span>\r\n        </span>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\DatePartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Property.Description), () => "<span class=\"help-block\">" + Model.Property.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 12 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\DatePartial.cshtml"
Write(Html.ValidationMessage(Model.Property.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
