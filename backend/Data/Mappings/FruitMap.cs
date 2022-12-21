
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.Entities;

namespace src.Data.Mappings
{
    public class FruitMap : IEntityTypeConfiguration<Fruit>
    {
        public void Configure(EntityTypeBuilder<Fruit> builder)
        {
            builder.ToTable("Fruit");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).ValueGeneratedOnAdd();

            builder.Property(f => f.Name).IsRequired()
                .HasColumnName("name").HasColumnType("VARCHAR");

            builder.Property(f => f.PriceA).IsRequired()
                .HasColumnName("priceA").HasColumnType("real");

            builder.Property(f => f.PriceB).IsRequired()
                .HasColumnName("priceB").HasColumnType("real");
        }
    }
}