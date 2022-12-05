using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    internal class AddBlogRatingConfig : IEntityTypeConfiguration<BlogRating>
    {
        public void Configure(EntityTypeBuilder<BlogRating> builder)
        {
            builder.HasKey(br => br.Stars);
        }
    }
}
