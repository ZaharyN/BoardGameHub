using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Constants
{
    public static class DataConstants
    {
        //Boardgame constants:

        public const int BoardgameNameMaxLength = 200;
        public const int BoardgameNameMinLength = 1;

        public const int BoardGameDescriptionMaxLength = 1500;
        public const int BoardGameDescriptionMinLength = 50;

        public const string BoardGamePriceInShopMaxValue = "1000";
        public const string BoardGamePriceInShopMinValue = "0";

        public const int BoardGameMinimumPlayersMinValue = 2;
        public const int BoardGameMinimumPlayersMaxValue = 4;

        public const int BoardGameMaximumPlayersMinValue = 2;
        public const int BoardGameMaximumPlayersMaxValue = 20;

        //Category constants:

        public const int CategoryNameMaxLength = 50;
        public const int CategoryNameMinLength = 3;
    }
}
