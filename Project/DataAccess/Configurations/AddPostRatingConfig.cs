using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess.Configurations
{
    internal class AddPostRatingConfig :IEntityTypeConfiguration<PostRating>
    {
        public void Configure(EntityTypeBuilder<PostRating> builder)
        {
            builder.HasKey(pr => pr.Stars);
        }
    }
}
