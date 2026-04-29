using IMS.handlers;
using IMS.views;

namespace IMS.source
{
   public class Menu(IDictionary<string, IMenuHandler> handlers, IDisplayService display)
   {
      private readonly IDisplayService _display = display;
      private readonly IDictionary<string, IMenuHandler> _handlers = handlers;
      private readonly string[] options = ["Display Catalog", "Add Product", "Remove Product", "Update Product", "Exit"];

      public void Run()
      {
         var exit = false;
         do
         {
            // First diplay the menu to the user
            _display.Clear();
            _display.DisplayMenu(options);

            // Then get the user's input
            var choice = Console.ReadLine()?.Trim()?.ToLower() ?? string.Empty;
            if( choice is "e" or "5" or "exit" or "q" or "quit" )
            {
               exit = true;
            }
            else
            {
               if( _handlers.TryGetValue(choice, out var handler) )
               {
                  handler.Execute();
               }
            }
         } while (!exit);
      }
   }
}