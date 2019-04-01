using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OrgChart.Data.Pocos;

namespace OrgChart.Data
{
    public partial class DSDBContext : DbContext
    {
        public DSDBContext()
        {
        }

        public DSDBContext(DbContextOptions<DSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppCompositeRole> AppCompositeRole { get; set; }
        public virtual DbSet<AppCompositeRoleItem> AppCompositeRoleItem { get; set; }
        public virtual DbSet<AppDocumentNo> AppDocumentNo { get; set; }
        public virtual DbSet<AppLog> AppLog { get; set; }
        public virtual DbSet<AppMenu> AppMenu { get; set; }
        public virtual DbSet<AppSingleRole> AppSingleRole { get; set; }
        public virtual DbSet<ApprovalRight> ApprovalRight { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttachmentRequest> AttachmentRequest { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<AuthorityCompany> AuthorityCompany { get; set; }
        public virtual DbSet<BoardUser> BoardUser { get; set; }
        public virtual DbSet<Bs> Bs { get; set; }
        public virtual DbSet<Bscompany> Bscompany { get; set; }
        public virtual DbSet<Bspayee> Bspayee { get; set; }
        public virtual DbSet<Bssigner> Bssigner { get; set; }
        public virtual DbSet<Ca> Ca { get; set; }
        public virtual DbSet<CaacceptEmail> CaacceptEmail { get; set; }
        public virtual DbSet<CaemailNotification> CaemailNotification { get; set; }
        public virtual DbSet<CalockUser> CalockUser { get; set; }
        public virtual DbSet<CalockUserTransection> CalockUserTransection { get; set; }
        public virtual DbSet<Careceive> Careceive { get; set; }
        public virtual DbSet<CompanyBankInfo> CompanyBankInfo { get; set; }
        public virtual DbSet<CompanyManager> CompanyManager { get; set; }
        public virtual DbSet<CompanyManagerItem> CompanyManagerItem { get; set; }
        public virtual DbSet<ConfigureValue> ConfigureValue { get; set; }
        public virtual DbSet<ConnectionLog> ConnectionLog { get; set; }
        public virtual DbSet<CostCenter> CostCenter { get; set; }
        public virtual DbSet<CostCenterManager> CostCenterManager { get; set; }
        public virtual DbSet<CostCenterManagerItem> CostCenterManagerItem { get; set; }
        public virtual DbSet<EmailOverDealInterval> EmailOverDealInterval { get; set; }
        public virtual DbSet<EmailTask> EmailTask { get; set; }
        public virtual DbSet<EmailTaskContent> EmailTaskContent { get; set; }
        public virtual DbSet<EmailTaskReceiver> EmailTaskReceiver { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<ExecutiveUser> ExecutiveUser { get; set; }
        public virtual DbSet<HolidayCalendar> HolidayCalendar { get; set; }
        public virtual DbSet<HrbusinessPlace> HrbusinessPlace { get; set; }
        public virtual DbSet<Hrcompany> Hrcompany { get; set; }
        public virtual DbSet<Hremployee> Hremployee { get; set; }
        public virtual DbSet<HremployeeMobile> HremployeeMobile { get; set; }
        public virtual DbSet<Hrorg> Hrorg { get; set; }
        public virtual DbSet<HrorgRelation> HrorgRelation { get; set; }
        public virtual DbSet<Hrposition> Hrposition { get; set; }
        public virtual DbSet<Otp> Otp { get; set; }
        public virtual DbSet<Pv> Pv { get; set; }
        public virtual DbSet<PvactivitySap> PvactivitySap { get; set; }
        public virtual DbSet<Pvgroup> Pvgroup { get; set; }
        public virtual DbSet<PvgroupItem> PvgroupItem { get; set; }
        public virtual DbSet<Pvitem> Pvitem { get; set; }
        public virtual DbSet<PvitemSap> PvitemSap { get; set; }
        public virtual DbSet<Pvsap> Pvsap { get; set; }
        public virtual DbSet<RespGroup> RespGroup { get; set; }
        public virtual DbSet<RespGroupAdmin> RespGroupAdmin { get; set; }
        public virtual DbSet<RespGroupComp> RespGroupComp { get; set; }
        public virtual DbSet<RespGroupEmp> RespGroupEmp { get; set; }
        public virtual DbSet<RespGroupOrg> RespGroupOrg { get; set; }
        public virtual DbSet<ReviewManager> ReviewManager { get; set; }
        public virtual DbSet<ReviewManagerItem> ReviewManagerItem { get; set; }
        public virtual DbSet<UserPostal> UserPostal { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<ValueHelp> ValueHelp { get; set; }
        public virtual DbSet<WorkflowActivityLog> WorkflowActivityLog { get; set; }
        public virtual DbSet<WorkflowActivityStep> WorkflowActivityStep { get; set; }
        public virtual DbSet<WorkflowDelegate> WorkflowDelegate { get; set; }
        public virtual DbSet<WorkflowProcess> WorkflowProcess { get; set; }
        public virtual DbSet<WorkflowProcessInstance> WorkflowProcessInstance { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<AppDocumentNo>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.Year, e.Additional01, e.Additional02, e.Additional03 });
            });

            modelBuilder.Entity<AppMenu>(entity =>
            {
                entity.Property(e => e.MenuCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<AppSingleRole>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CaemailNotification>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Aduser, e.Email })
                    .HasName("PK__CAEmailN__387C40C44F742A9D");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CalockUser>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Aduser })
                    .HasName("PK__CALockUs__0CD591C10809A23F");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.EmailType).ValueGeneratedNever();
            });

            modelBuilder.Entity<HrbusinessPlace>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPlace, e.ComCode })
                    .HasName("PK__HRBusine__41A0C720128B9458");
            });

            modelBuilder.Entity<Hrcompany>(entity =>
            {
                entity.HasKey(e => e.ComCode)
                    .HasName("PK__HRCompan__C6A8FD5D49E46FE7");

                entity.Property(e => e.ComCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Hremployee>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__HREmploy__AF2D66D38BF38D71");

                entity.Property(e => e.EmpNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Hrorg>(entity =>
            {
                entity.Property(e => e.OrgId).ValueGeneratedNever();
            });

            modelBuilder.Entity<HrorgRelation>(entity =>
            {
                entity.HasKey(e => new { e.ParentOrgId, e.ChildOrgId });
            });

            modelBuilder.Entity<Hrposition>(entity =>
            {
                entity.Property(e => e.PosId).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserPostal>(entity =>
            {
                entity.Property(e => e.EmpNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowActivityLog>(entity =>
            {
                entity.HasKey(e => new { e.ProcessInstanceId, e.SerialNo });
            });

            modelBuilder.Entity<WorkflowActivityStep>(entity =>
            {
                entity.HasKey(e => new { e.ProcessInstanceId, e.Step, e.ActionUser });
            });

            modelBuilder.Entity<WorkflowProcess>(entity =>
            {
                entity.Property(e => e.ProcessCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkflowProcessInstance>(entity =>
            {
                entity.Property(e => e.ProcessInstanceId).ValueGeneratedNever();
            });
        }
    }
}
