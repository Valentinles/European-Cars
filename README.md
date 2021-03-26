# European-Cars
**European Cars** is ASP .NET Core Blazor Server Side application for car advertisements.To create an advertisement you need to register. The advertisement itself includes the most important information about any car such as brand, model, year of production, conditon, engine type, price and so on.

**Images**  </br>
<img src="https://i.postimg.cc/NMF5KPwM/Screenshot-3.png" width="30%"></img> <img src="https://i.postimg.cc/bJ5dkHzR/Screenshot-4.png" width="30%"></img> <img src="https://i.postimg.cc/3NDNB4NQ/Screenshot-5.png" width="30%"></img>

## Getting Started

###### To run the application you need:
- .NET Core 5.0 

- If you don't have *Sql server* on your machine you should replace the configuration in *EuCars.Web/appsettings.json* with this code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=EuCars;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
- In your *package manger console* type: 

```
update-database
```

## Used technologies
- C#
- .NET Core 5.0
- Blazor
- Entity Framework Core
- Bootstrap
- HTML
- CSS
