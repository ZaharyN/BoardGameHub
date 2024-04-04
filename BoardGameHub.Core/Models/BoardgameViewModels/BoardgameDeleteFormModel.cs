using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.BoardgameViewModels
{
    public class BoardgameDeleteFormModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
