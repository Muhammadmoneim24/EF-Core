using EFCoreCodefirst.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace EFCoreCodefirst.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder) 
        {
            builder.HasKey(e => e.Id);
            builder.Property(e=>e.Id).ValueGeneratedNever();

            builder.Property(e=>e.CourseName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(e => e.Price).HasPrecision(15, 2);

            builder.ToTable("Courses");

            builder.HasData(LoadCourses());
        }

        private static  List<Course> LoadCourses() 
        {
             return new List<Course> { 
                 new Course{Id = 1,CourseName = "Math",Price= 1000m  },
                 new Course{Id = 2,CourseName = "Physics",Price= 2000m  },
                 new Course{Id = 3,CourseName = "Chemistry",Price= 1500m  },
                 new Course{Id = 4,CourseName = "Biology",Price= 3000m  },
                 new Course{Id = 5,CourseName = "CS-50",Price= 2500m  }



             };
        }
    }

}
