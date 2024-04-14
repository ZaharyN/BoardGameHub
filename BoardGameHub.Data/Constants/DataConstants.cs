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

        public const int BoardgameNameMaxLength = 100;
        public const int BoardgameNameMinLength = 1;

        public const int BoardGameDescriptionMaxLength = 1500;
        public const int BoardGameDescriptionMinLength = 50;

        public const string BoardGamePriceInShopMaxValue = "1000";
        public const string BoardGamePriceInShopMinValue = "0";

        public const int BoardGameYearMinValue = 1980;
        public const int BoardGameYearMaxValue = 2024;

        public const int BoardGameMinimumPlayersMinValue = 2;
        public const int BoardGameMinimumPlayersMaxValue = 4;

        public const int BoardGameMaximumPlayersMinValue = 2;
        public const int BoardGameMaximumPlayersMaxValue = 20;

        public const double BoardgameRatingMinValue = 0;
        public const double BoardgameRatingMaxValue = 5;

        public const double BoardgameDifficultyMinValue = 0.00;
        public const double BoardgameDifficultyMaxValue = 5.00;

        public const int BoardgameAppropriateAgeMinValue = 0;
        public const int BoardgameAppropriateAgeMaxValue = 18;

        //Category constants:

        public const int CategoryNameMaxLength = 50;
        public const int CategoryNameMinLength = 3;

        //Place constants:

        public const int PlaceCapacityMinValue = 2;
        public const int PlaceCapacityMaxValue = 10;

        public const string PlacePricePerHourMinValue = "10.00";
        public const string PlacePricePerHourMaxValue = "300.00";

        //GameReview constants:

        public const int GameReviewMinLength = 10;
        public const int GameReviewMaxLength = 1000;

        //Reservation constants:

        public const int ReservationAdditionalCommentMaxValue = 300;

        public const string ReservationTotalPriceMinValue = "10.00";
        public const string ReservationTotalPriceMaxValue = "900.00";

        public const string ReservationDateTimeFormat = "dd/MM/yyyy HH:mm";

		//Application user constants:

		public const string ApplicationUserPhoneNumber = @"^(\+?359|0)?(87[0-9]{7}|88[789][0-9]{6}|89[0-9]{7}|98[0-9]{7})$";

        public const int UserFirstNameMinLength = 2;
        public const int UserFirstNameMaxLength = 30;

        public const int UserLastNameMinLength = 2;
        public const int UserLastNameMaxLength = 30;

        //Claim constants:

        public const string UserFullNameClaim = "userFullName";

        //Role constant:

        public const string AdminRole = "Administrator";
	}
}
