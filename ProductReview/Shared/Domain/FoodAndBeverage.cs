﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;

namespace ProductReview.Shared.Domain
{
	public class FoodAndBeverage : BaseDomainModel
	{
		[Required]
		public string Name { get; set; }
		public string Review { get; set; }
	}
}
