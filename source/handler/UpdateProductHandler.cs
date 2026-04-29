using System.ComponentModel;
using IMS.controllers;
using IMS.views;

namespace IMS.handlers
{
   public class UpdateProductHandler(IDisplayService display, CatalogController controller) : IMenuHandler
   {
      private readonly IDisplayService _display = display;
      private readonly CatalogController _controller = controller;

      public void Execute()
      {
         return;
      }
   }
}