using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABD_CRM.Models;

public partial class ABDContext : DbContext
{
    public ABDContext()
    {
    }

    public ABDContext(DbContextOptions<ABDContext> options)
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
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__5F5D193281345454");

            entity.ToTable("tbl_Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("Company_ID");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company_Address");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company_Name");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CreatedById).HasColumnName("Created_By_ID");
            entity.Property(e => e.DpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DP_Name");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated");
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Num");
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__tbl_Cont__82ACC1CDAB26E04A");

            entity.ToTable("tbl_Contact");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("Contact_ID");
            entity.Property(e => e.CompanyId).HasColumnName("Company_ID");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Contact_Name");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.TblContacts)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__tbl_Conta__Compa__4D94879B");
        });

        modelBuilder.Entity<TblStaff>(entity =>
        {
            entity.HasKey(e => e.SUserId).HasName("PK__tbl_Staf__66D6D1C1AF8EA491");

            entity.ToTable("tbl_Staff");

            entity.Property(e => e.SUserId)
                .ValueGeneratedNever()
                .HasColumnName("S_User_ID");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.StaffName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Staff_Name");
            entity.Property(e => e.StaffPassword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Staff_Password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Tickets");

            entity.Property(e => e.Assignee)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssigneeDept)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_Date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated");
            entity.Property(e => e.Resolved)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TicketDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ticket_Description");
            entity.Property(e => e.TicketId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ticket_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
