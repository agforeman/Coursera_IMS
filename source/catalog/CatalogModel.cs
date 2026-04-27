using System.Linq;

namespace IMS.models
{
   /// <summary>
   /// This is the product catalog that holds all product listings.
   /// </summary>
   public class ProductCatalogue : ICollection<ProductListing>
   {
      /// <summary>
      /// Backing data store for the product catalog.
      /// </summary>
      private readonly ICollection<ProductListing> _products = 
         new HashSet<ProductListing>(20);
      
      /// <summary>
      /// Gets the number of product listings in the catalog.
      /// </summary>
      public int Count => _products.Count;

      /// <summary>
      /// Is the product catalog read-only
      /// </summary>
      public bool IsReadOnly => _products.IsReadOnly;

      /// <summary>
      /// Initializes a new instance of the <see cref="ProductCatalogue"/> class.
      /// </summary>
      public ProductCatalogue()
      {
      }

      /// <summary>
      /// Adds a product listing to the catalog.
      /// </summary>
      /// <param name="productListing">The product listing to add.</param>
      /// <remarks>todo: Add validation for duplicate product listings</remarks>
      public void Add(ProductListing productListing) => _products.Add(productListing);
      
      /// <summary>
      /// Removes a product listing from the catalog.
      /// </summary>
      /// <param name="productListing">The product listing to remove.</param>
      /// <returns>true if the product listing was removed; otherwise, false.</returns>
      public bool Remove(ProductListing productListing) => _products.Remove(productListing);
      
      /// <summary>
      /// Clears all product listings from the catalog.
      /// </summary>
      public void Clear() => _products.Clear();
      
      /// <summary>
      /// Checks if the catalog contains a specific product listing.
      /// </summary>
      /// <param name="productListing">The product listing to check for.</param>
      /// <returns>true if the product listing is in the catalog; otherwise, false.</returns>
      /// <param name="productListing"></param>
      /// <returns></returns>
      public bool Contains(ProductListing productListing) => _products.Contains(productListing);

      /// <summary>
      /// Copies the product listings to an array.
      /// </summary>
      /// <param name="array">The array to copy the product listings to.</param>
      /// <param name="arrayIndex">The index in the array at which to start copying.</param>
      public void CopyTo(ProductListing[] array, int arrayIndex) => _products.CopyTo(array, arrayIndex);
      
      /// <summary>
      /// Returns an enumerator that iterates through the product listings.
      /// </summary>
      /// <returns>An enumerator for the product listings.</returns>
      public IEnumerator<ProductListing> GetEnumerator() => _products.GetEnumerator();
      
      /// <summary>
      /// Returns an enumerator that iterates through the product listings.
      /// </summary>
      /// <returns>An enumerator for the product listings.</returns>
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
   }
}