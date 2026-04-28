namespace IMS.models
{
   /// <summary>
   /// This is the product that holds the name and price of a product.
   /// </summary>
   public record struct Product
   {
      /// <summary>
      /// The name of the product.
      /// </summary>
      public string Name {get; set;}

      /// <summary>
      /// The price of the product.
      /// </summary>
      public decimal Price {get; set;}

      /// <summary>
      /// Initializes a new instance of the <see cref="Product"/> struct.
      /// </summary>
      /// <param name="name">The name of the product.</param>
      /// <param name="price">The price of the product.</param>
      /// </summary>
      public Product(string name, decimal price)
      {
         // Todo: Add class invariant checks
         Name = name;
         Price = price;
      }
   }
}