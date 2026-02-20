using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkinClinicProject.Models;

namespace SkinClinicProject.My_Context
{
    public class AppDbContext : IdentityDbContext<User>
    {       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<UserExamination> UserExaminations { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Booking>()
                .Property(u => u.BookingDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Entity<Booking>()
                .Property(u => u.BookingConfirmation)
                .HasDefaultValue(false);

            builder.Entity<Examination>()
                .Property(u => u.ExaminationDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Entity<Examination>()
                .Property(u => u.ExaminationConsultation)
                .HasDefaultValue(false);

            builder.Entity<Session>()
                .Property(u => u.SessionDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Entity<Session>()
                .Property(u => u.Sessionconsultation)
                .HasDefaultValue(false);

            builder.Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETDATE()");



            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Doctor", NormalizedName = "DOCTOR" , ConcurrencyStamp = "1"},
                new IdentityRole { Id = "2", Name = "Receptionist", NormalizedName = "RECEPTIONIST", ConcurrencyStamp = "2" },
                new IdentityRole { Id = "3", Name = "Nurse", NormalizedName = "NURSE", ConcurrencyStamp = "3" },
                new IdentityRole { Id = "4", Name = "Patient", NormalizedName = "PATIENT", ConcurrencyStamp = "4" }
                );
        }
    }
}   