﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Data.Data.DataModels
{
    public class GameReview
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(GameReviewMaxLength)]
        public string ReviewText { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Boardgame Boardgame { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Boardgame))]
        public int BoardGameId { get; set; }

        [Required]
        public User User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
    }
}
