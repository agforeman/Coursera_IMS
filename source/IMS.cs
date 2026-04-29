using IMS.controllers;
using IMS.models;
using IMS.views;

namespace IMS.source
{
   class IMS
   { 
      public static void Main()
      {
         // Initialize controllers and services
         var displayService = new ConsoleDisplayService();
         var productController = new ProductController();
         var catalog = new ProductCatalogue();
         var catalogController = new CatalogController(productController, catalog);

         // Begin program execution
         var menu = new Menu(catalogController, displayService);
         menu.Run();
      }
   }
}