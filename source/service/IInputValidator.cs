namespace IMS.services
{
   /// <summary>
   /// This interface defines the contract for an input validation service that is responsible for ensuring valid input to the system.
   /// </summary>
   public interface IInputValidator
   {
      /// <summary>
      /// Prompts the user to enter a product name. If the name is invalid displays an error and reprompts for input.
      /// </summary>
      /// <returns>The valid string representing a string name.</returns>
      public string GetValidName();

      /// <summary>
      /// Prompts the user to enter a product price. If the price is invalid displays an error and reprompts for input.
      /// </summary>
      /// <returns>The valid product price.</returns>
      public decimal GetValidPrice();
      
      /// <summary>
      /// Prompts the user to enter a stock quantity. If the quantity is invalid displays an error and reprompts for input.
      /// </summary>
      /// <returns>The valid stock quantity.</returns>
      public int GetValidQuantity();
   }

}