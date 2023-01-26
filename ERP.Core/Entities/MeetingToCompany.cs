using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class MeetingToCompany
	{
		public int Id { get; set; }
		public int MeetingId { get; set; }
		public int CompanyId { get; set; }

		public virtual Meeting Meeting { get; set; }
		public virtual Company Company { get; set; }

	}
}
