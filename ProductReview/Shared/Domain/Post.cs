using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;

namespace ProductReview.Shared.Domain
{
	public class Post : BaseDomainModel
	{
		[Required]
		public string Title { get; set; }
		public DateTime Date  { get; set; }
		public string Rating { get; set; }
		public string Description { get; set; }
		public virtual Reviewer Reviewer { get; set; }
	}
}
