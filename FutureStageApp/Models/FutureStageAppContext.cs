using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FutureStageApp.Models
{
    public class FutureStageAppContext : DbContext
    {
        public FutureStageAppContext(DbContextOptions<FutureStageAppContext> opt) : base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            foreach (var rel in mb.Model.GetEntityTypes().SelectMany(p => p.GetForeignKeys()))
            {
                rel.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<EducationBoard> EducationBoards { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Medium> Mediums { get; set; }
        public DbSet<Quota> Quotas { get; set; }
        public DbSet<SchoolStandard> SchoolStandards { get; set; }
        public DbSet<StandardSeatQuota> StandardSeatQuotas { get; set; }
        public DbSet<SchoolFacility> SchoolFacilities { get; set; }
        public DbSet<FeeHead> FeeHeads { get; set; }
        public DbSet<StandardFees> StandardFees { get; set; }
        public DbSet<SchoolAchivement> SchoolAchivements { get; set; }
        public DbSet<AddmissionPrerequisite> AddmissionPrerequisites { get; set; }
        public DbSet<AddmissionProcess> AddmissionProcesses { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<AddmissionEnquiry> AddmissionEnquiries { get; set; }
        public DbSet<GeneralEnquiryReply> GeneralEnquiryReplies { get; set; }
        public DbSet<AddmissionConfirmation> AddmissionConfirmations { get; set; }
        public DbSet<SiteAdmin> SiteAdmins { get; set; }
        public DbSet<ConfirmedEnquiry> ConfirmedEnquiries { get; set; }
    }
}
