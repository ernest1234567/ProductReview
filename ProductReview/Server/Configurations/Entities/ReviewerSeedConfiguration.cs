using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
	public class ReviewerSeedConfiguration : IEntityTypeConfiguration<Reviewer>
	{
		public void Configure(EntityTypeBuilder<Reviewer> builder)
		{
			builder.HasData(
				new Reviewer
				{
					Id = 1,
					Name = "Cake",
					Review = "This Cake is so delicious",
					DateCreated = DateTime.Now.AddMonths(-3),
					DateUpdated = DateTime.Now.AddMonths(-3),
					CreatedBy = "System",
					UpdatedBy = "System"
				}
				);
		}
	}
}
