using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.DataModels
{
    
    public class BoardgameCategory
    {
        public Boardgame Boardgame { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Boardgame))]
        public int BoardgameId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }
    }
}
