using System.Web.Mvc;
using System.Web.Routing;

namespace EasyBootstrapMvc
{
    /// <summary>
    /// This is where you set up all of the routes that make a URL go to your app.
    /// For example http://localhost:65018/Home/Index will go to HomeController, which then renders the "Index" View.
    /// The "defaults" provide default values, so that http://localhost:65018/ will actually go to http://localhost:65018/Home/Index by default!
    /// </summary>
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // this is a special route that .NET generates when making bundles. Ignore it for now.

            // TODO: Put your new route here (routes match in order, so depending on the route you create, it might never be reached if other routes match first!)

            routes.MapRoute(
                name: "Default",                                        // name of the route
                url: "{controller}/{action}",                           // Values that go into the URL (for example, localhost/{Home}/{Index}
                defaults: new { controller = "Home", action = "Index" } // Default values provided for the route URL
            );

        }
    }
}
