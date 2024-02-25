using EFCoreCodefirst.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodefirst.Data.Config
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.OfficeName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(e => e.OfficeLocation).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();


            //builder.HasOne(e=>e.Office).WithOne(e=> e.Instructor).HasForeignKey<Instructor>(e=>e.OfficeId).IsRequired(false);

            builder.ToTable("Offices");

            builder.HasData(LoadOffices());
        }

        private static List<Office> LoadOffices()
        {
            return new List<Office> {
                 new Office{Id = 1,OfficeName = "Off_05",OfficeLocation="building A"} ,
                 new Office{Id = 2,OfficeName = "Off_12", OfficeLocation = "building B"} ,
                 new Office{Id = 3,OfficeName = "Off_32", OfficeLocation = "Adminstration"} ,
                 new Office{Id = 4,OfficeName = "Off_45", OfficeLocation = "IT Department"} ,
                 new Office{Id = 5,OfficeName = "Off_4",OfficeLocation = "IT Department"} 

             };
        }
    }
}
