﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_DbFirst.Models;

public partial class CollegeContext : DbContext
{
    public CollegeContext()
    {
    }

    public CollegeContext(DbContextOptions<CollegeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Studentss> Studentsses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = LAPTOP-4J9P4KK5\\SQLEXPRESS; initial catalog = College; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.CourseId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Studentss>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("Studentss");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("Student_Id");
            entity.Property(e => e.StudNames).HasColumnName("Stud_Names");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
