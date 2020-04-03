using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PersonalTouchMVC.Models;

namespace PersonalTouchMVC.Data
{
    public partial class PersonalTouchDbContext : DbContext
    {
        public PersonalTouchDbContext()
        {
        }

        public PersonalTouchDbContext(DbContextOptions<PersonalTouchDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CardBank> CardBank { get; set; }
        public virtual DbSet<CardTemplate> CardTemplate { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<EventDates> EventDates { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JTV6PJIS\\SQLEXPRESS;Database=Personal Touch Database;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardBank>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__CardBank__55FECD8E7B0DC1BC");

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardBackImagePath).HasColumnName("Card Back Image Path");

                entity.Property(e => e.CardFrontImagePath).HasColumnName("Card Front Image Path");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.CardBank)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__CardBank__EventI__68487DD7");
            });

            modelBuilder.Entity<CardTemplate>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__CardTemp__55FECD8E233446C1");

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardCategory).HasColumnName("Card Category");

                entity.Property(e => e.CardName).HasColumnName("Card Name");

                entity.Property(e => e.TimesTemplateSelected).HasColumnName("Times Template Selected");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__Contacts__5C6625BB9627D6ED");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FirstName).HasColumnName("First Name");

                entity.Property(e => e.LastName).HasColumnName("Last Name");

                entity.Property(e => e.MiddleName).HasColumnName("Middle Name");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Contacts__Custom__5CD6CB2B");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B87F31EF41");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateAccountCreated)
                    .HasColumnName("Date Account Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("First Name");

                entity.Property(e => e.LastName).HasColumnName("Last Name");

                entity.Property(e => e.MiddleName).HasColumnName("Middle Name");

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone Number");

                entity.Property(e => e.UserName).HasColumnName("User Name");
            });

            modelBuilder.Entity<EventDates>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__EventDat__7944C87080AA5B29");

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.EventDate)
                    .HasColumnName("Event Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventName).HasColumnName("Event Name");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.EventDates)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK__EventDate__Conta__628FA481");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__Payments__9B556A5846032466");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillingAddress).HasColumnName("Billing Address");

                entity.Property(e => e.CardExperationDate)
                    .HasColumnName("Card Experation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditCardName).HasColumnName("Credit Card Name");

                entity.Property(e => e.CreditCardNumber).HasColumnName("Credit Card Number");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CvcCode).HasColumnName("CVC Code");

                entity.Property(e => e.NameOnCard).HasColumnName("Name on Card");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Payments__Custom__5FB337D6");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK__Pictures__8C2866F8CD8FAD64");

                entity.Property(e => e.PictureId)
                    .HasColumnName("PictureID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PictureName).HasColumnName("Picture Name");

                entity.Property(e => e.TimesPhotoSelected).HasColumnName("Times Photo Selected");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
