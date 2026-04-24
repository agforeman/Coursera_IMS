using System;

namespace IMS
{
   public class ProductCatalogue : ICollection<ProductListing>
   {
      // Backing data store
      private ICollection<ProductListing> _products = new HashSet<ProductListing>();
      
      public int Count => _products.Count;
      public bool IsReadOnly => _products.IsReadOnly;

      public ProductCatalogue()
      {
      }

      public void Add(ProductListing p) => _products.Add(p);
      public bool Remove(ProductListing p) => _products.Remove(p);
      
      public void Clear() => _products.Clear();
      
      public bool Contains(ProductListing p) => _products.Contains(p);
      public void CopyTo(ProductListing[] array, int arrayIndex) => _products.CopyTo(array, arrayIndex);
      
      
      public IEnumerator<ProductListing> GetEnumerator() => _products.GetEnumerator();
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
   }

   public class ProductListing(Product product, int quantity)
   {
      public Product Product{get; set;} = product;
      public int Quantity{get; set;} = quantity;
   }
}