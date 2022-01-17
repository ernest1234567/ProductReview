using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
	public class FoodAndBeverageSeedConfiguration : IEntityTypeConfiguration<FoodAndBeverage>
	{
		public void Configure(EntityTypeBuilder<FoodAndBeverage> builder)
		{
			builder.HasData(
				new FoodAndBeverage
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
