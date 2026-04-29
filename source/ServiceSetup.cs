using IMS.controllers;
using IMS.handlers;
using IMS.models;
using IMS.services;
using IMS.views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace IMS.source
{
   public static class ServiceSetup
   {
      public static Menu CreateMenu()
      {
         var services = new ServiceCollection();
         services.AddSingleton<IDisplayService, ConsoleDisplayService>();
         services.AddSingleton<ProductCatalogue>();
         services.AddSingleton<ProductController>();
         services.AddSingleton<CatalogController>();
         services.AddSingleton<IInputValidator, InputValidator>();

         // create handlers for each menu action and add them to the collection
         services.AddSingleton<AddProductHandler>();
         services.AddSingleton<DisplayCatalogHandler>();
         services.AddSingleton<RemoveProductHandler>();
         services.AddSingleton<UpdateProductHandler>();

         var provider = services.BuildServiceProvider();

         var handlers = new Dictionary<string, IMenuHandler>
         {
            {"1", provider.GetRequiredService<DisplayCatalogHandler>()},
            {"display", provider.GetRequiredService<DisplayCatalogHandler>()},
            {"catalog", provider.GetRequiredService<DisplayCatalogHandler>()},
            {"disp", provider.GetRequiredService<DisplayCatalogHandler>()},
            {"display catalog", provider.GetRequiredService<DisplayCatalogHandler>()},

            {"2", provider.GetRequiredService<AddProductHandler>()},
            {"add", provider.GetRequiredService<AddProductHandler>()},
            {"add product", provider.GetRequiredService<AddProductHandler>()},
         
            {"3", provider.GetRequiredService<RemoveProductHandler>()},
            {"remove", provider.GetRequiredService<RemoveProductHandler>()},
            {"remove product", provider.GetRequiredService<RemoveProductHandler>()},

            {"4", provider.GetRequiredService<UpdateProductHandler>()},
            {"update", provider.GetRequiredService<UpdateProductHandler>()},
            {"update product", provider.GetRequiredService<UpdateProductHandler>()},
         };

         // Then create a menu from a dictionary. Each key is the string a user can use to access 
         // the option. The values retrieve the correct handler from provider.

         return new Menu(handlers, provider.GetRequiredService<IDisplayService>());
      }

   }
}