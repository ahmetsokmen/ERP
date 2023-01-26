using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class EmployeeToCompany
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public int CompanyId { get; set; }

		public virtual Employee Employee { get; set; }

		public virtual Company Company { get; set; }




}
}
