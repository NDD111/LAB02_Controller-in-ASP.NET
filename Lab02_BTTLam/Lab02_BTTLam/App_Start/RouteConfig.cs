using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab02_BTTLam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Song",
               url: "Bai-Hat/Danh-Sach-Bai-Hat",
               defaults: new { controller = "Song", action = "ShowSong" }
            );
            routes.MapRoute(
                name: "Details Song",
                url: "Bai-Hat/Chi-Tiet/{SongName}",
                defaults: new { controller = "Song", action = "DetailSong", SongName = (string)null }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
