using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;

namespace ProductReview.Shared.Domain
{
	public class Reviewer : BaseDomainModel
	{
		[Required]
		public string Name { get; set; }
		
	}
}
