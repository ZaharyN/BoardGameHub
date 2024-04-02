﻿namespace BoardGameHub.Core.Models.BoardgameViewModels
{
	public class BoardgameActiveViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<BoardgameGenreViewModel> BoardgameGenres { get; set; } = null!;
        public double? Rating { get; set; }
        public int AppropriateAge { get; set; }
        public double Difficulty { get; set; }
        public string CardImageUrl { get; set; } = string.Empty;
        public string DetailsImageUrl { get; set; } = string.Empty;
        public int MinimumPlayersAllowedToPlay { get; set; }
        public int MaximumPlayersAllowedToPlay { get; set; }
    }
}