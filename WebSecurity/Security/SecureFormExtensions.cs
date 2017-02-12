using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace WebSecurity
{
    //
    // Summary:
    //     Represents support for HTML in an application.
    public static class SecureFormExtensions
    {
        //
        // Summary:
        //     Writes an opening <form> tag to the response. The form uses the POST method,
        //     and the request is processed by the action method for the view.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper)
        {
            var form = htmlHelper.BeginForm();
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and includes the route values in
        //     the action attribute. The form uses the POST method, and the request is processed
        //     by the action method for the view.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, object routeValues)
        {
            var form = htmlHelper.BeginForm(routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and includes the route values from
        //     the route value dictionary in the action attribute. The form uses the POST method,
        //     and the request is processed by the action method for the view.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, RouteValueDictionary routeValues)
        {
            var form = htmlHelper.BeginForm(routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller and action. The form uses the POST method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response, and sets the action tag to the
        //     specified controller, action, and route values. The form uses the POST method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response, and sets the action tag to the
        //     specified controller, action, and route values from the route value dictionary.
        //     The form uses the POST method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller and action. The form uses the specified HTTP method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller, action, and route values. The form uses the specified HTTP method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }
        //
        // Summary:
        //     Writes an opening <form> tag to the response, and sets the action tag to the
        //     specified controller, action, and route values from the route value dictionary.
        //     The form uses the specified HTTP method.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller and action. The form uses the specified HTTP method and includes the
        //     HTML attributes.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method, object htmlAttributes)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller and action. The form uses the specified HTTP method and includes the
        //     HTML attributes from a dictionary.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response, and sets the action tag to the
        //     specified controller, action, and route values from the route value dictionary.
        //     The form uses the specified HTTP method, and includes the HTML attributes from
        //     the dictionary.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues, method,  htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response and sets the action tag to the specified
        //     controller, action, and route values. The form uses the specified HTTP method
        //     and includes the HTML attributes.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   actionName:
        //     The name of the action method.
        //
        //   controllerName:
        //     The name of the controller.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method, object htmlAttributes)
        {
            var form = htmlHelper.BeginForm(actionName, controllerName, routeValues, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, object routeValues)
        {
            var form = htmlHelper.BeginRouteForm(routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeValues:
        //     An object that contains the parameters for a route
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, RouteValueDictionary routeValues)
        {
            var form = htmlHelper.BeginRouteForm(routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName)
        {
            var form = htmlHelper.BeginRouteForm(routeName);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, object routeValues)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, RouteValueDictionary routeValues)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, FormMethod method)
        {
            var form = htmlHelper.BeginRouteForm(routeName, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }
        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, object routeValues, FormMethod method)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, RouteValueDictionary routeValues, FormMethod method)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues, method);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, FormMethod method, object htmlAttributes)
        {
            var form = htmlHelper.BeginRouteForm(routeName, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            var form = htmlHelper.BeginRouteForm(routeName, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }

        //
        // Summary:
        //     Writes an opening <form> tag to the response. When the user submits the form,
        //     the request will be processed by the route target.
        //
        // Parameters:
        //   htmlHelper:
        //     The HTML helper instance that this method extends.
        //
        //   routeName:
        //     The name of the route to use to obtain the form-post URL.
        //
        //   routeValues:
        //     An object that contains the parameters for a route. The parameters are retrieved
        //     through reflection by examining the properties of the object. This object is
        //     typically created by using object initializer syntax.
        //
        //   method:
        //     The HTTP method for processing the form, either GET or POST.
        //
        //   htmlAttributes:
        //     An object that contains the HTML attributes to set for the element.
        //
        // Returns:
        //     An opening <form> tag.
        public static MvcForm BeginSecureRouteForm(this HtmlHelper htmlHelper, string routeName, object routeValues, FormMethod method, object htmlAttributes)
        {
            var form = htmlHelper.BeginRouteForm(routeName, routeValues, method, htmlAttributes);
            htmlHelper.ViewContext.Writer.Write(htmlHelper.AntiForgeryToken().ToHtmlString());
            return form;
        }
    }
}