﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Coderoom.Web
{
	public class Application : HttpApplication
	{
		public void Application_Start()
		{
			GlobalFilters.Filters.Add(new HandleErrorAttribute());

			RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			RouteTable.Routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
				);
		}
	}
}