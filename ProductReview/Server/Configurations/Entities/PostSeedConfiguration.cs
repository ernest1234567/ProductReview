using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
	public class PostSeedConfiguration : IEntityTypeConfiguration<Post>
	{
		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.HasData(
				new Post
				{
					Id = 1,
					Title = "Yayoi",
					Description = "This restaurant is so good",
					DateCreated = DateTime.Now.AddMonths(-3),
					DateUpdated = DateTime.Now.AddMonths(-3),
					CreatedBy = "System",
					UpdatedBy = "System"
				}
				);
		}
	}
}
