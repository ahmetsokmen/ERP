using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class CommentMedia
{
    public int Id { get; set; }

    public int TaskCommentId { get; set; }

    public virtual TaskComment TaskComment { get; set; }




}