
# Soft Routing for ASP.NET MVC (0.1)

## Getting Started 

> nuget install softrouting

## Why Soft Routing?

* Easy Development | Простота разработки 
* Understandable API | Понятный API

Area Main  

// Areas
        //Main
            //Controllers
                //HomeController
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

### Routing to this controller with default page

```
RouteTable.Routes
            .InArea("Main")
            .WithController("Home")
            .MapIndexPage("index"); // index => action name

            //will map to index page | Будет перенаправлен главную страницу
```

### AutoRouting

```
RouteTable.Routes
            .InArea("Main")
            .WithController("Home")
            .AutoMap();
            
```

> READ DOCS
https://github.com/aliskhanoff/SoftRouting/wiki