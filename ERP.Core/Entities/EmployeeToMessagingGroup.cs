using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class EmployeeToMessagingGroup
{
    public int MessagingGroupId { get; set; }

    public int EmployeeId { get; set; }

    public bool IsOwner { get; set; }

    public virtual MessagingGroup MessagingGroup { get; set; }

    public virtual Employee Employee { get; set; }
}