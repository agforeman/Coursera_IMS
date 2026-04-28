using IMS.models;

namespace IMS.controllers
{
   public class ProductController
   {
      /// <summary>
      /// Creates a new product with the given name and price.
      /// </summary>
      /// <param name="name">The name of the product.</param>
      /// <param name="price">The price of the product.</param>
      /// <returns>The created product.</returns>
      /// <exception cref="ArgumentException">Thrown when the name is empty or the price is zero or negative.</exception>
      /// <remarks>This method validates the input parameters and throws an exception if they are invalid. It then creates and returns a new Product instance.</remarks>   
      public Product CreateProduct(string name, decimal price)
      {
         ValidateName(name);
         ValidatePrice(price);
         return new Product(name, price);
      }

      private void ValidateName(string name)
      {
         if (string.IsNullOrWhiteSpace(name))
         {
            throw new ArgumentException("Product name cannot be empty.");
         }
      }

      private void ValidatePrice(decimal price)
      {
         if (price <= 0)
         {
            throw new ArgumentException("Product price cannot be zero or negative.");
         }
      }
   }   
}