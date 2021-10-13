using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePriceisRightCosoleGame.Data
{   //classes/POCO
    public class Item

    {   // prop string item type, prop decimal for price
        public string ItemName { get; set; } //field = item name 
        public decimal ItemPrice { get; set; }
        public decimal UserGuess { get; set; }

        public Item() //empty constructor
        {
            
        }
        public Item(string itemName, decimal itemPrice, decimal userGuess) //overloaded constructor
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            UserGuess = userGuess;
        }

      
    }

    




    }
