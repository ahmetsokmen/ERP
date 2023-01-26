using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class Meeting
	{
		public int Id { get; set; }

		public DateTime? MeetingDate { get; set; }
		public virtual ICollection<MeetingToEmployee> MeetingsToEmployees { get; } = new List<MeetingToEmployee>();

		public virtual ICollection<MeetingToCompany> MeetingsToCompanies { get; } = new List<MeetingToCompany>();


	}
}
