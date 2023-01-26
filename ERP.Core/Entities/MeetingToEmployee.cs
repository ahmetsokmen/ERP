using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class MeetingToEmployee
	{
		public int Id { get; set; }

		public int MeetingId { get; set; }

		public int EmployeeId { get; set; }


		public virtual Employee Employee { get; set; }

		public virtual Meeting Meeting{ get; set; }


	}
}
