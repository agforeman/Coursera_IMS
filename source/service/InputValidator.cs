using IMS.views;

namespace IMS.services
{

   public class InputValidator(IDisplayService displayService) : IInputValidator
   {
      private readonly IDisplayService _displayService = displayService;

      public string GetValidName()
      {
         // Todo: Implement
         // while not valid
            // get input
            // check validity
            // if valid return
            // else error
         return string.Empty;
      }

      public decimal GetValidPrice()
      {
         // Todo: implement
         // while not valid
            // get input
            // check validity
            // if valid return
            // else error
         return 0;
      }

      public int GetValidQuantity()
      {
         // Todo: implement
         // while not valid
            // get input
            // check validity
            // if valid return
            // else error
         return 0;
      }
   }

}