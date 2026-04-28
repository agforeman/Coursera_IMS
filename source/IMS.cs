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

         // Then begin the main loop of the application
            // First diplay the menu to the user
            // Then get the users input
               // If user chooses diplay catalog
                  // Display the catalog to the user
                  // Psueudo code for displaying the catalog:
                  // Get the catalog from the CatalogController
                  // Pass the catalog to the DisplayService to display it to the user.
               // If user chooses add product
                  // Get product details from the user
                  // Add the product to the catalog
                  // Psueudo code for adding a product:
                  // Get the product name, price, and quantity from the user
                  // Call the AddProductToCatalog method of the CatalogController with the product details
                  // If the product is added successfully, display a success message to the user; otherwise, display an error message.
               // If user chooses remove product
                  // Get product name from the user
                  // Remove the product from the catalog
                  // Psueudo code for removing a product:
                  // Get the product name from the user
                  // Call the RemoveProductFromCatalog method of the CatalogController with the product name
                  // If the product is removed successfully, display a success message to the user; otherwise, display an error message.
               // If user chooses update product
                  // Get product name and new details from the user
                  // Update the product in the catalog 
                  // Psueudo code for updating a product:
                  // First ask if the user wants to see the catalog to find the product name
                  // If yes, display the catalog to the user
                  // Then ask the user for the product name they want to update
                  // Then ask the user for the new price and new quantity of the product.
                  // Call the UpdateProductInCatalog method of the CatalogController with the product details
                  // If the product is updated successfully, display a success message to the user; otherwise, display an error message.
               // If user chooses exit
                  // Exit the application
               // Else display an error message and show the menu again
      }
   }
}