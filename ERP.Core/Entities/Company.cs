using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class Company
{
    public int Id { get; set; }
	public string? Name { get; set; }



	public virtual ICollection<EmployeeToCompany> EmployeesToCompaines { get; } = new List<EmployeeToCompany>();

	public virtual ICollection<CompanyToDepartment> CompaniesToDepartments { get; } = new List<CompanyToDepartment>();

	public virtual ICollection<MeetingToCompany> MeetingsToCompanies { get; } = new List<MeetingToCompany>();


}