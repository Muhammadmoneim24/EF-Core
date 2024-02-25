using EFCoreCodefirst.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodefirst.Data.Config
{
    public class EnrollmentsConfiguration : IEntityTypeConfiguration<Enrollments>
    {
        public void Configure(EntityTypeBuilder<Enrollments> builder)
        {
            builder.HasKey(e => new {e.SectionId,e.StudentId});

            builder.ToTable("Enrollments");

            builder.HasData(LoadEnrollments());
        }

        private static List<Enrollments> LoadEnrollments()
        {
            return new List<Enrollments> {

                  new Enrollments {StudentId=1,SectionId=6},
                  new Enrollments {StudentId=2,SectionId=6},
                  new Enrollments {StudentId=3,SectionId=7},
                  new Enrollments {StudentId=4,SectionId=7},
                  new Enrollments {StudentId=5,SectionId=8},
                  new Enrollments {StudentId=6,SectionId=8},
                  new Enrollments {StudentId=7,SectionId=9},
                  new Enrollments {StudentId=8,SectionId=9},
                  new Enrollments {StudentId=9,SectionId=10},
                  new Enrollments {StudentId=10,SectionId=10}

             };
        }
    }
}
