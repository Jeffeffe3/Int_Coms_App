using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABD_CRM.Models;

public partial class ABD_DBContext : DbContext
{
    public ABD_DBContext()
    {
    }

    public ABD_DBContext(DbContextOptions<ABD_DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblStaff> TblStaffs { get; set; }

    public virtual DbSet<TblTicket> TblTickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NISH33L\\SQLEXPRESS;Initial Catalog=CRM_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__5F5D193238FD56B6");

            entity.ToTable("tbl_Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("Company_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Company_Name");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CreatedById).HasColumnName("Created_By_ID");
            entity.Property(e => e.DpName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DP_Name");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated");
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Phone_Num");
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__tbl_Cont__206D9190C3037A79");

            entity.ToTable("tbl_Contact");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_ID");
            entity.Property(e => e.CompanyId).HasColumnName("Company_ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated");
            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.TblContacts)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__tbl_Conta__Compa__38996AB5");
        });

        modelBuilder.Entity<TblStaff>(entity =>
        {
            entity.HasKey(e => e.SUserId).HasName("PK__tbl_Staf__66D6D1C19F8239BE");

            entity.ToTable("tbl_Staff");

            entity.Property(e => e.SUserId)
                .ValueGeneratedNever()
                .HasColumnName("S_User_ID");
            entity.Property(e => e.Department)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.Username)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Tickets");

            entity.Property(e => e.Assignee)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AssigneeDept)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Resolved)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TicketId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TicketID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
