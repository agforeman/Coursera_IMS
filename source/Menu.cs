using System.Reflection;
using IMS.controllers;
using IMS.views;

namespace IMS.source
{
   public class Menu(CatalogController controller, IDisplayService display)
   {
      private readonly CatalogController _controller = controller;
      private readonly IDisplayService _display = display;

      private readonly string[] mainMenu = ["Display Catalog", "Add Product", "Remove Product", "Update Product", "Exit"];

      public void Run()
      {
         var exit = false;
         do
         {
            // First diplay the menu to the user
            _display.Clear();
            _display.DisplayMenu(mainMenu);
            // Then get the users input
            string input = Console.ReadLine()?.Trim().ToLower() ?? "";
            switch(input)
            {
               // Display Catalog
               case "display" or "disp" or "display catalog" or "cat" or "catalog" or "1":
                  //DisplayCatalog();
                  break;

               // Add product
               case "add" or "add product" or "2":
                  //AddProductToCatalog();
                  break;

               case "remove" or "remove product" or "3":
                  //RemoveProductFromCatalog();
                  break;
                  
               case "update" or "update product" or "4":
                  //UpdateProduct
                  break;

               // Exit
               case "exit" or "quit" or "q" or "5":
                  exit = true;
                  break;

               // Unknown input
               default:
                  // Else display an error message and show the menu again
                  _display.DisplayError("Invalid menu option.");
                  break;
            }
         } while (!exit);
      }
   } 
}