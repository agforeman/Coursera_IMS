using System;

namespace IMS
{
   /// This is the product class that handles all product specific functionality.
   public record struct Product
   {
      /// Product name
      public string Name {get; set;} 
      /// Product price
      public double Price {get; set;}
   
      /// Constructor
      public Product(string name, double price)
      {
         Name = name;
         Price = price;
      }
   }
}