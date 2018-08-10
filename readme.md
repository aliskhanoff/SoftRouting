
# SoftRouting for ASP.NET MVC (0.1.2)

## Getting Started 

> nuget Install-Package softrouting

## Why Soft Routing?

* Easy Development 
* LightWeight routes

## EXAMPLES

> Standart Asp.net MVC application Controller in Controllers folder:

```
public class HomeController: Controller {

        public HomeController() {

        }

        public ActionResult Index() {
            return Content("index");
        }

        public ActionResult About() {
            return Content("about");
        }

        public ActionResult Contacts() {
            return Content("contacts");
        }
}
```

> Routing to index page with standart Asp.Net routing (action index):

```
RouteTable.Routes.MapRoute(null, "", new { 
    controller: "Home",
    action: "index"
 });

```

> Routing with SoftRouting Wrapper:

```
RouteTable.Routes.InController("Home").MapIndexPage("index"); //action name "index" as default page
```

> Routing to actions "about" && "contacts" with Asp.Net routing 

```
RouteTable.Routes.MapRoute(null, "about", new { 
    controller: "Home",
    action: "about"
 });

RouteTable.Routes.MapRoute(null, "contacts", new { 
    controller: "Home",
    action: "contacts"
 });

```
> Or you can use automatic routing: 

```
RouteTable.Routes.MapRoute(null, "{action}", new { 
    controller: "Home"
 });

```
> Routing with SoftRouting Wrapper:
```
RouteTable.Routes.InController("Home")
                        .Map("about")
                        .Map("contacts");
```

> Or Automatic routing

```
RouteTable.Routes.InController("Home").AutoMap();
```

> Auto routing with url prefix

```
RouteTable.Routes.InController("Home").AutoMap("blogs");
```

> Also you can use url expressions:

```

RouteTable.Routes.InController("Home")
                        .Map("about", "us/about")
                        .Map("contacts", "us/contacts");

```

> And you can use prefix for route:

```
RouteTable.Routes.InController("Main").AutoMap("us"); 
```

> You can create routes in areas

```

RouteTable.Routes.InArea("Main").WithController("Home")
                        .Map("about", "us/about")
                        .Map("contacts", "us/contacts");

```
> You can swith controller and area

```

RouteTable.Routes.InController("Home").AutoMap("us").SwitchArea("accounts").WithController("Login").AutoMap();

RouteTable.Routes.InController("Home").AutoMap("us").SwitchController("Login").AutoMap();

```

> Thanks for installation!
