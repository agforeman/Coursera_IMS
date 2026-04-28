using IMS.models;

namespace IMS.controllers
{
   /// <summary>
   /// This class is responsible for managing products, including creating new products and validating product information.
   /// </summary>
   public class ProductController()
   {
      /// <summary>
      /// Creates a new product with the given name and price.
      /// </summary>
      /// <param name="name">The name of the product.</param>
      /// <param name="price">The price of the product.</param>
      /// <returns>The created product.</returns>
      public Product CreateProduct(string name, decimal price)
      {
         return new Product(name, price);
      }
   }   
}