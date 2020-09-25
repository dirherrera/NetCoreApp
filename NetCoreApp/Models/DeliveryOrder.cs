﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class DeliveryOrder
	{

		public Guid ID { get; set; }
		public string Reference { get; set; }
		public string Customer { get; set; }
		public string Vessel { get; set; }
		public string Container { get; set; }
		public string Weight { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime Created { get; set; }
		
	}
}
