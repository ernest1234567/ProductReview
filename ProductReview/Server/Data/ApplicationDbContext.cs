using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductReview.Server.Configurations.Entities;
using ProductReview.Server.Models;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}
		public DbSet<Post> Clothings { get; set; }
		public DbSet<FoodAndBeverage> FoodAndBeverages { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new ClothingSeedConfiguration());
			builder.ApplyConfiguration(new FoodAndBeverageSeedConfiguration());
			
		}
	}
}
