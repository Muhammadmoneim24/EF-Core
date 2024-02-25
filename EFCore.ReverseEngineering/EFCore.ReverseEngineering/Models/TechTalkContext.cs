using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore.ReverseEngineering.Models;

public partial class TechTalkContext : DbContext
{
    public TechTalkContext()
    {
    }

    public TechTalkContext(DbContextOptions<TechTalkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Speaker> Speakers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-MN6ULTF\\SSEXP;Database=TechTalk;Trusted_Connection=True; TrustServerCertificate = True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Events__3214EC0700DB5E42");

            entity.Property(e => e.EndAt).HasColumnType("datetime");
            entity.Property(e => e.StartAt).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Speaker).WithMany(p => p.Events)
                .HasForeignKey(d => d.SpeakerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Events__SpeakerI__38996AB5");
        });

        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Speakers__3214EC0715B53714");

            entity.Property(e => e.FirstName).HasMaxLength(25);
            entity.Property(e => e.LastName).HasMaxLength(25);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
