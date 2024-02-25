using EFCoreCodefirst.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodefirst.Data.Config
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e=>e.Title).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();


            builder.ToTable("Schedules");

            builder.HasData(LoadSchedules());
        }

        private static List<Schedule> LoadSchedules()
        {
            return new List<Schedule> {
                new Schedule {Id = 1, Title = "Daily", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false},
                new Schedule {Id = 2, Title = "DayAfterDAy", SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = true},
                new Schedule {Id = 3, Title = "Twice-a-Week", SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false},
                new Schedule {Id = 4, Title = "Weekend", SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true},
                new Schedule {Id = 5, Title = "Compact", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true},



             };
        }
    }
}
