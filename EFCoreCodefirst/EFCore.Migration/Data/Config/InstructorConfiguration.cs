using EFCoreCodefirst.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodefirst.Data.Config
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name).HasColumnType("VARCHAR").HasMaxLength(255);

            builder.HasOne(e=>e.Office).WithOne(e=> e.Instructor).HasForeignKey<Instructor>(e=>e.OfficeId).IsRequired(false);

            builder.ToTable("Instructors");

            builder.HasData(LoadInstructors());
        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor> {
                 new Instructor{Id = 1,Name = "Ahmed Ali",OfficeId=1} ,
                 new Instructor{Id = 2,Name = "Mohamed Ahmed",OfficeId=2} ,
                 new Instructor{Id = 3,Name = "Issam Abdelnabi", OfficeId = 3} ,
                 new Instructor{Id = 4,Name = "Osama Elzero", OfficeId = 4},
                 new Instructor{Id = 5,Name = "Mohamed", OfficeId = 5}

             };
        }
    }
}
