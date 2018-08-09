
# THE SOFT ROUTING PROJECT V.01

### SoftRouting for Asp.Net MVC | SoftRouting для Asp.Net MVC

## Getting Started | Начните использовать

## Why Soft Routing? | Почему SoftRouting?

* Easy Development | Простота разработки 
* Understandable API | Понятный API

Area Main | Область Main 

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
            .MapArea("Main")
            .WithController("Home")
            .MapIndexPage("index"); // index => action name

            //will map to index page | Будет перенаправлен главную страницу
```

### Routing Automatic || Автоматическая маршрутизация

```
RouteTable.Routes
            .MapArea("Main")
            .WithController("Home")
            .AutoMap();
            
```


