using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePriceisRightCosoleGame.Data
{

    public class GameRepo
    { //methods for games to operate correctly

        private List<Item> _listOfItem = new List<Item>();
        public bool AddItem(Item item)
        {
            int itemCount = _listOfItem.Count;
            _listOfItem.Add(item);
            bool itemAdd = _listOfItem.Count > itemCount;
            return itemAdd;

        }
        public bool GuessCheck(decimal userGuess, Item item)
        {
            if (userGuess < item.ItemPrice - 20 || userGuess > item.ItemPrice + 20)
            {
                return false;
            }
            return true;

        }



        
    }
}
