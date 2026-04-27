using IMS.models;

namespace IMS.source
{
   class IMS
   { 
      public static void Main()
      {
         // Create a product catalog
         var catalog = new ProductCatalogue();

         // Create some products
         var apple = new Product("Apple", 0.5);
         var banana = new Product("Banana", 0.3);

         // Add products to the catalog
         catalog.Add(new ProductListing(apple, 100));

         Console.WriteLine($"{catalog.Contains("Apple")}"); // True}");

      }
   }
}