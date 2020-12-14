using System.Reflection;
using schoolapi.Models;
using Microsoft.EntityFrameworkCore;

namespace schoolapi {
    public class ArchaosDbContext : DbContext
    {
        public DbSet<AddressRecord> Addresses { get; set; }
        public DbSet<ClassRecord> Classes { get; set; }
        public DbSet<FamilyMemberRecord> FamilyMembers { get; set; }
        public DbSet<FamilyRecord> Families { get; set; }
        public DbSet<HomeworkRecord> Homeworks { get; set; }
        public DbSet<ParentAddressRecord> ParentAddresses { get; set; }
        public DbSet<ParentRecord> Parents { get; set; }
        public DbSet<ReportRecord> Reports { get; set; }
        public DbSet<SchoolRecord> Schools { get; set; }
        public DbSet<StudentAddressRecord> StudentAddresses { get; set; }
        public DbSet<StudentClassRecord> StudentClasses { get; set; }
        public DbSet<StudentParentRecord> StudentParents { get; set; }
        public DbSet<StudentRecord> Students { get; set; }
        public DbSet<SubjectRecord> Subjects { get; set; }
        public DbSet<TeacherRecord> Teachers { get; set; }

        public ArchaosDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=archaos.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}