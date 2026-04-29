using IMS.controllers;
using IMS.views;

namespace IMS.handlers
{
   public class DisplayCatalogHandler(IDisplayService display, CatalogController controller) : IMenuHandler
   {
      private readonly IDisplayService _display = display;
      private readonly CatalogController _controller = controller;

      public void Execute()
      {
         _display.DisplayCatalog(_controller.GetCatalog());
      }
   }
}