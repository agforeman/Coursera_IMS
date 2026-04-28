using IMS.models;

namespace IMS.views
{
   /// <summary>
   /// This class implements the <see cref="IDisplayService"/> interface and is responsible for displaying the product catalog and related information to the user in the console.
   /// </summary>
   public class ConsoleDisplayService : IDisplayService
   {
      public void DisplayCatalog(IEnumerable<ProductListing> catalog)
      {
         Console.WriteLine("Product Catalog:");
         foreach (var listing in catalog)
         {
            Console.WriteLine($"- {listing.Product.Name}: ${listing.Product.Price:C2} (Stock: {listing.Quantity})");
         }
      }

      public void DisplayProduct(Product product)
      {
         Console.WriteLine($"Product: {product.Name}");
         Console.WriteLine($"Price: ${product.Price}");
      }

      public void DisplayMessage(string message)
      {
         Console.WriteLine(message);
      }

      public void DisplaySuccess(string successMessage)
      {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine(successMessage);
         Console.ResetColor();
      }

      public void DisplayError(string errorMessage)
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine($"Error: {errorMessage}");
         Console.ResetColor();
      }

      public void DisplayMenu(string[] options)
      {
         Console.WriteLine("Menu:");
         for (int i = 0; i < options.Length; i++)
         {
            Console.WriteLine($"{i + 1}. {options[i]}");
         }
      }
   }
}