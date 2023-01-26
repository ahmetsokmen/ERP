﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class TaskMedia
	{
		public int Id { get; set; }

		public int TaskId { get; set; }

		public virtual Task Task { get; set; }

	}
}
