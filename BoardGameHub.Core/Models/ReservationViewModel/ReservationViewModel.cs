using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationViewModel
	{
        public int Id { get; set; }
        public string ReservationImage { get; set; } = string.Empty;
        public string ReservationName { get; set; } = string.Empty;
        public string DateTime { get; set; } = string.Empty;

    }
}
