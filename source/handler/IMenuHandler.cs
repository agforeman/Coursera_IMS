namespace IMS.handlers
{
   /// <summary>
   /// Defines a handler that performs work related to a menu option.
   /// </summary>
   public interface IMenuHandler
   {
      /// <summary>
      /// This runs the concrete menu handler's code.
      /// </summary>
      public void Execute();
   }
}