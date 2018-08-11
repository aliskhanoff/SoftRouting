
# SoftRouting for ASP.NET MVC (0.1.2)

## Getting Started 

> nuget Install-Package softrouting -Version 0.1.2

## Why SoftRouting?

* Ease of development
* Clear code
* Simple routes

# EXAMPLES

# Example 1

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
using SoftRouting; //very important ¯\_(ツ)_/¯ 

RouteTable.Routes.MapRoute(null, "", new { 
    controller: "Home",
    action: "index"
 });

```

> Routing with SoftRouting:

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
> Routing with SoftRouting:
```
RouteTable.Routes.InController("Home")
                        .Map("about")
                        .Map("contacts");
```

> Or you can use automatic routing

```
RouteTable.Routes.InController("Home").AutoMap(); //will map to ~/index, ~/about, ~/contacts
```

> Auto routing with UrlPrefix

```
RouteTable.Routes.InController("Home").AutoMap("blogs"); //will map to ~/blogs/about, ~/blogs/contacts
```

> Also you can use url expressions in map:

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
> You can switсh controller and area

```

RouteTable.Routes.InController("Home").AutoMap("us").SwitchArea("accounts").WithController("Login").AutoMap();

RouteTable.Routes.InController("Home").AutoMap("us").SwitchController("Login").AutoMap();

```

# Example 2

> Routing in AreaRegistration class

```
using SoftRouting; ¯\_(ツ)_/¯

public class MainAreaRegistration : AreaRegistration  {

        public override string AreaName => "Main";

        public override void RegisterArea(AreaRegistrationContext context)  {
        
                context.WithController("Home")
                            .AutoMap();
        }
}

```

> You can switch controllers

```
context.WithController("Home")
                            .AutoMap()
                                .SwitchController("Info")
                                        .AutoMap("info");
```

> And you can switch Area


```            context.WithController("Home")
                    .AutoMap()
                    .SwithArea("Account")
                        .WithController("Login")
                            .AutoMap("accounts"); //~/accounts/login, ~/accounts/register etc...
```


>  # Thanks for installation!

## [Looking for a job](https://www.facebook.com/badcoded) - Visit my page
