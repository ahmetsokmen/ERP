using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class Department
{
    public int Id { get; set; }

	public string? Name { get; set; }



	public virtual ICollection<CompanyToDepartment> CompaniesToDepartments { get; } = new List<CompanyToDepartment>();

	public virtual ICollection<EmployeeToDepartment> EmployeessToDepartments { get; } = new List<EmployeeToDepartment>();
}