using IMS.models;

namespace IMS.views
{
   /// <summary>
   /// This interface defines the contract for a display service that is responsible for displaying the product catalog and related information to the user.
   /// </summary>
   public interface IDisplayService
   {
      /// <summary>
      /// Displays the product catalog to the user.
      /// </summary>
      /// <param name="catalog">The product catalog to display.</param>
      void DisplayCatalog(IEnumerable<ProductListing> catalog);

      /// <summary>
      /// Displays a single product to the user.
      /// </summary>
      /// <param name="product">The product to display.</param>
      void DisplayProduct(Product product);

      /// <summary>
      /// Displays a message to the user.
      /// </summary>
      /// <param name="message">The message to display.</param>
      void DisplayMessage(string message);
      
      /// <summary>
      /// Displays an error message to the user.
      /// </summary>
      /// <param name="errorMessage">The error message to display.</param>
      void DisplayError(string errorMessage);
      
      /// <summary>
      /// Displays a menu to the user.
      /// </summary>
      /// <param name="options">The options to display.</param>
      void DisplayMenu(string[] options);
   }
   
}