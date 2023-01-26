using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class CompanyToDepartment
	{
		public int Id{ get; set; }
		public int CompanyId { get; set; }
		public int DepartmentId { get; set; }


		public virtual Department Department { get; set; }
		public virtual Company Company { get; set; }

		public virtual ICollection<Task> Tasks { get; } = new List<Task>();









	}
}
