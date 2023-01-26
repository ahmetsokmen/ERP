using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class MessagingGroup
{
    public int Id { get; set; }

    public virtual ICollection<Message> Messages { get; } = new List<Message>();

    public virtual ICollection<EmployeeToMessagingGroup> EmployeesToMessagingGroups { get; } = new List<EmployeeToMessagingGroup>();
}