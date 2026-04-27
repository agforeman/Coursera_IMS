   namespace IMS.models
{
   /// <summary>
   /// This is the product listing that holds a product and its 
   /// quantity in the catalog.
   /// </summary>
   public record struct ProductListing
   {
      /// <summary>
      /// The product that is being listed.
      /// </summary>
      public Product Product{get; set;}

      /// <summary>
      /// The stock quantity of the product in the catalog.
      /// </summary>
      public int Quantity{get; set;}

      /// <summary>
      /// Initializes a new instance of the <see cref="ProductListing"/> struct.
      /// </summary>
      /// <param name="product">The product to list.</param>
      /// <param name="quantity">The stock quantity of the product.</param>
      public ProductListing(Product product, int quantity)
      {
         // Todo: Add invariant checks
         Product = product;
         Quantity = quantity;
      }
   }
}