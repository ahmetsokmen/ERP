using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class Message
{
    public int Id { get; set; }

    public int MessagingGroupId { get; set; }

    public int SenderEmployeeId { get; set; }

    public virtual MessagingGroup MessagingGroup { get; set; }

    public virtual Employee Sender { get; set; }
}