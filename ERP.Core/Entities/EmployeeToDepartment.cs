using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class EmployeeToDepartment
	{
		public int Id { get; set; }

		public int EmployeeId { get; set; }

		public int DeparmentId { get; set; }

		public virtual Department Department { get; set; }

		public virtual Employee Employee { get; set; }

	}
}
