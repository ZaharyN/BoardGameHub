using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationDeleteFormModel
	{
        public int Id { get; set; }
        public string ReservationName { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
    }
}
