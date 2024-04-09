using BoardGameHub.Data.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationDetailsViewModel
	{
        public int Id { get; set; }
        public string DateTime { get; set; } = string.Empty;
        public string AdditionalComment { get; set; } = string.Empty;
        public List<ReservationPlace> PlacesReserved { get; set; } = new List<ReservationPlace>();
        public List<Boardgame> BoardgamesReserved { get; set; } = new List<Boardgame>();
    }
}
