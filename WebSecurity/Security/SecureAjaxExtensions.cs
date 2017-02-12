using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace WebSecurity
{

    //Summary:
    //    Represents support for ASP.NET AJAX within an ASP.NET MVC application.
    public static class AjaxExtensions
    {
        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, object routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, string controllerName, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, controllerName, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(actionName, routeValues, ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element..
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(actionName, routeValues, ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, controllerName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, string controllerName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(actionName, controllerName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, string controllerName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   actionName:
        //     The name of the action method that will handle the request.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response using the specified routing information.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   routeName:
        //     The name of the route to use to obtain the form post URL.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this AjaxHelper ajaxHelper, string routeName, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(routeName, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response using the specified routing information.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   routeName:
        //     The name of the route to use to obtain the form post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this AjaxHelper ajaxHelper, string routeName, object routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(routeName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response using the specified routing information.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   routeName:
        //     The name of the route to use to obtain the form post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this AjaxHelper ajaxHelper, string routeName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions)
        {
            var form = ajaxHelper.BeginForm(routeName, routeValues, ajaxOptions);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response using the specified routing information.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   routeName:
        //     The name of the route to use to obtain the form post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this AjaxHelper ajaxHelper, string routeName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(routeName, routeValues, ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response using the specified routing information.
        //
        // Parameters:
        //   ajaxHelper:
        //     The AJAX helper.
        //
        //   routeName:
        //     The name of the route to use to obtain the form post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   ajaxOptions:
        //     An object that provides options for the asynchronous request.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this AjaxHelper ajaxHelper, string routeName, RouteValueDictionary routeValues, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes)
        {
            var form = ajaxHelper.BeginForm(routeName,  routeValues,  ajaxOptions, htmlAttributes);
            ajaxHelper.ViewContext.Writer.Write(AntiForgery.GetHtml());
            return form;
        }

    }
}