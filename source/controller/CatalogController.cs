using IMS.models;

namespace IMS.controllers
{
   /// <summary>
   /// This class is responsible for managing the product catalog, including adding new products and displaying the catalog to the user.
   /// </summary>
   /// <param name="productController">The product controller used to create products.</param>
   /// <param name="catalog">The product catalog that holds the product listings.</param>
   public class CatalogController(ProductController productController, ProductCatalogue catalog)
   {
      private readonly ProductController _productController = productController;
      private readonly ProductCatalogue _catalog = catalog;

      /// <summary>
      /// Adds a product to the catalog.
      /// </summary>
      /// <param name="name">The name of the product.</param>
      /// <param name="price">The price of the product.</param>
      /// <param name="quantity">The stock quantity of the product.</param>
      /// <returns>True if the product was added successfully; otherwise, false.</returns>
      public bool AddProductToCatalog(string name, decimal price, int quantity)
      {
         var product = _productController.CreateProduct(name, price);
         _catalog.Add(new ProductListing(product, quantity));
         return true;
      }

      /// <summary>
      /// Removes a product from the catalog by product name.
      /// </summary>
      /// <param name="name">The name of the product to remove.</param>
      /// <returns>True if the product was removed successfully; otherwise, false.</returns>
      public bool RemoveProductFromCatalog(string name)
      {
         var productFound = GetProductListing(name, out var listing);
         if(!productFound)
            return false;
         else
            return _catalog.Remove(listing);
      }

      /// <summary>
      /// Gets a product listing from the catalog by product name.
      /// </summary>
      /// <param name="productName">The name of the product to retrieve.</param>
      /// <returns>The product listing if found; otherwise, null.</returns>
      private bool GetProductListing(string productName, out ProductListing listing)
      {
         listing = _catalog.FirstOrDefault(listing => listing.Product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
         return listing != default;
      }

      /// <summary>
      /// Gets the product catalog for the user.
      /// </summary>
      /// <returns>The product catalog.</returns>
      public IEnumerable<ProductListing> GetCatalog()
      {
         return _catalog;
      }

      /// <summary>
      /// Updates the stock quantity of a product in the catalog by product name.
      /// </summary>
      /// <param name="productName">The name of the product to update.</param>
      /// <param name="newQuantity">The new stock quantity of the product.</param>
      /// <returns>True if the product quantity was updated successfully; otherwise, false.</returns>
      public bool UpdateProductQuantity(string productName, int newQuantity)
      {
         var productFound = GetProductListing(productName, out var listing);
         if(!productFound)
            return false;
         else
         {
            _catalog.Remove(listing);
            _catalog.Add(new ProductListing(listing.Product, newQuantity));
            return true;
         }
      }

      /// <summary>
      /// Updates the price of a product in the catalog by product name.
      /// </summary>
      /// <param name="productName">The name of the product to update.</param>
      /// <param name="newPrice">The new price of the product.</param>
      /// <returns>True if the product price was updated successfully; otherwise, false.</returns>
      public bool UpdateProductPrice(string productName, decimal newPrice)
      {
         var productFound = GetProductListing(productName, out var listing);
         if(!productFound)
            return false;
         else
         {
            _catalog.Remove(listing);
            _catalog.Add(new ProductListing(_productController.CreateProduct(productName, newPrice), listing.Quantity));
            return true;
         }
      }
   }
}