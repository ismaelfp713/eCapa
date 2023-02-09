using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class QAD_QMSContext : DbContext
    {
        public QAD_QMSContext()
        {
        }

        public QAD_QMSContext(DbContextOptions<QAD_QMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DCapaExtraMembers> DCapaExtraMembers { get; set; }
        public virtual DbSet<DClauses> DClauses { get; set; }
        public virtual DbSet<DDepartment> DDepartment { get; set; }
        public virtual DbSet<DDepartmentProcesses> DDepartmentProcesses { get; set; }
        public virtual DbSet<DProcessRoles> DProcessRoles { get; set; }
        public virtual DbSet<DProcesses> DProcesses { get; set; }
        public virtual DbSet<DRoles> DRoles { get; set; }
        public virtual DbSet<DStandardClause> DStandardClause { get; set; }
        public virtual DbSet<DSubClauses> DSubClauses { get; set; }
        public virtual DbSet<Deight> Deight { get; set; }
        public virtual DbSet<Developers> Developers { get; set; }
        public virtual DbSet<Dfive> Dfive { get; set; }
        public virtual DbSet<DfiveActions> DfiveActions { get; set; }
        public virtual DbSet<Dfour> Dfour { get; set; }
        public virtual DbSet<DocumentHistory> DocumentHistory { get; set; }
        public virtual DbSet<Dseven> Dseven { get; set; }
        public virtual DbSet<DsevenCross> DsevenCross { get; set; }
        public virtual DbSet<Dstandards> Dstandards { get; set; }
        public virtual DbSet<Dthree> Dthree { get; set; }
        public virtual DbSet<Dtwo> Dtwo { get; set; }
        public virtual DbSet<DtwoPictures> DtwoPictures { get; set; }
        public virtual DbSet<GeneralInformation> GeneralInformation { get; set; }
        public virtual DbSet<InputRisk> InputRisk { get; set; }
        public virtual DbSet<InputRiskControl> InputRiskControl { get; set; }
        public virtual DbSet<OutputRisk> OutputRisk { get; set; }
        public virtual DbSet<OutputRiskControl> OutputRiskControl { get; set; }
        public virtual DbSet<PartNumbers> PartNumbers { get; set; }
        public virtual DbSet<RDepartments> RDepartments { get; set; }
        public virtual DbSet<RoutesUsers> RoutesUsers { get; set; }
        public virtual DbSet<THows> THows { get; set; }
        public virtual DbSet<TInputs> TInputs { get; set; }
        public virtual DbSet<TMeasurements> TMeasurements { get; set; }
        public virtual DbSet<TOutputs> TOutputs { get; set; }
        public virtual DbSet<TRoutes> TRoutes { get; set; }
        public virtual DbSet<TUsers> TUsers { get; set; }
        public virtual DbSet<TWhats> TWhats { get; set; }
        public virtual DbSet<TWhos> TWhos { get; set; }
        public virtual DbSet<Turtle> Turtle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=10.131.40.44;Initial Catalog=QAD_QMS;Persist Security Info=True;User ID=qauser;Password=Panasonic1#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DCapaExtraMembers>(entity =>
            {
                entity.Property(e => e.IdRole).HasDefaultValueSql("('Team Member')");

                entity.HasOne(d => d.IdCapaNavigation)
                    .WithMany(p => p.DCapaExtraMembers)
                    .HasForeignKey(d => d.IdCapa)
                    .HasConstraintName("FK_dCapaExtraMembers_GeneralInformation");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.DCapaExtraMembers)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_dCapaExtraMembers_dRoles");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DCapaExtraMembers)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_dCapaExtraMembers_AspNetUsers");
            });

            modelBuilder.Entity<DClauses>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DDepartment>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DDepartmentProcesses>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.ProcessId })
                    .HasName("PK_DatabaseLists")
                    .IsClustered(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DDepartmentProcesses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_dDepartmentProcesses_dDepartment");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DDepartmentProcesses)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dDepartmentProcesses_dProcesses");
            });

            modelBuilder.Entity<DProcessRoles>(entity =>
            {
                entity.HasKey(e => new { e.ProcessId, e.UserId, e.RoleId })
                    .HasName("PK_DatabaseProcessRoleUserIds")
                    .IsClustered(false);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DProcessRoles)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_dProcessRoles_dProcesses");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DProcessRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dProcessRoles_dRoles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DProcessRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dProcessRoles_AspNetUsers");
            });

            modelBuilder.Entity<DProcesses>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DRoles>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DStandardClause>(entity =>
            {
                entity.HasKey(e => e.IdStandardClause)
                    .HasName("PK_dStandardClause_1");

                entity.HasOne(d => d.Clause)
                    .WithMany(p => p.DStandardClause)
                    .HasForeignKey(d => d.ClauseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dStandardClause_dClauses");

                entity.HasOne(d => d.Standard)
                    .WithMany(p => p.DStandardClause)
                    .HasForeignKey(d => d.StandardId)
                    .HasConstraintName("FK_dStandardClause_DStandards");
            });

            modelBuilder.Entity<DSubClauses>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubClauseName).IsUnicode(false);

                entity.Property(e => e.SubClauseNumber).IsUnicode(false);

                entity.HasOne(d => d.Clause)
                    .WithMany(p => p.DSubClauses)
                    .HasForeignKey(d => d.ClauseId)
                    .HasConstraintName("FK_dSubClauses_dClauses");
            });

            modelBuilder.Entity<Deight>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.GeneralInformation)
                    .WithMany(p => p.Deight)
                    .HasForeignKey(d => d.GeneralInformationId)
                    .HasConstraintName("FK_DEight_GeneralInformation");
            });

            modelBuilder.Entity<Dfive>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FunctionalApprovalStatus).IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QaApprovalStatus).IsUnicode(false);

                entity.HasOne(d => d.GeneralInformartion)
                    .WithMany(p => p.Dfive)
                    .HasForeignKey(d => d.GeneralInformartionId)
                    .HasConstraintName("FK_DFive_GeneralInformation");
            });

            modelBuilder.Entity<DfiveActions>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelayReason).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonOne).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonThree).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonTwo).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusOne).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusThree).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusTwo).IsUnicode(false);

                entity.Property(e => e.Evidence).IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.IdActionPlanNavigation)
                    .WithMany(p => p.DfiveActions)
                    .HasForeignKey(d => d.IdActionPlan)
                    .HasConstraintName("FK_DFiveActions_DFive");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.DfiveActions)
                    .HasForeignKey(d => d.Owner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DFiveActions_AspNetUsers");
            });

            modelBuilder.Entity<Dfour>(entity =>
            {
                entity.HasKey(e => e.IdFour)
                    .HasName("PK__tmp_ms_x__007D2AB006F89E02");

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Why).IsUnicode(false);

                entity.HasOne(d => d.GeneralInformartion)
                    .WithMany(p => p.Dfour)
                    .HasForeignKey(d => d.GeneralInformartionId)
                    .HasConstraintName("FK_DFour_GeneralInformation");
            });

            modelBuilder.Entity<DocumentHistory>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Process).IsUnicode(false);

                entity.Property(e => e.Purpose).IsUnicode(false);

                entity.Property(e => e.Revision).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.DocumentHistory)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_DocumentHistory_tRoutes");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocumentHistory)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentHistory_AspNetUsers");

                entity.HasOne(d => d.Turtle)
                    .WithMany(p => p.DocumentHistory)
                    .HasForeignKey(d => d.TurtleId)
                    .HasConstraintName("FK_DocumentHistory_Turtle");
            });

            modelBuilder.Entity<Dseven>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelayReason).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusOne).IsUnicode(false);

                entity.Property(e => e.Evidence).IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.GeneralInformartion)
                    .WithMany(p => p.Dseven)
                    .HasForeignKey(d => d.GeneralInformartionId)
                    .HasConstraintName("FK_DSeven_GeneralInformation");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Dseven)
                    .HasForeignKey(d => d.Owner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DSeven_AspNetUsers");
            });

            modelBuilder.Entity<DsevenCross>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.GeneralInformation)
                    .WithMany(p => p.DsevenCross)
                    .HasForeignKey(d => d.GeneralInformationId)
                    .HasConstraintName("FK_DsevenCross_GeneralInformation");
            });

            modelBuilder.Entity<Dstandards>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Dthree>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelayReason).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonOne).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonThree).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationDelayReasonTwo).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusOne).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusThree).IsUnicode(false);

                entity.Property(e => e.EffectivenessVerificationStatusTwo).IsUnicode(false);

                entity.Property(e => e.Evidence).IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Open')");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DthreeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DThree_AspNetUsers1");

                entity.HasOne(d => d.GeneralInformartion)
                    .WithMany(p => p.Dthree)
                    .HasForeignKey(d => d.GeneralInformartionId)
                    .HasConstraintName("FK_DThree_GeneralInformation");

                entity.HasOne(d => d.ResponsibleNavigation)
                    .WithMany(p => p.DthreeResponsibleNavigation)
                    .HasForeignKey(d => d.Responsible)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DThree_AspNetUsers");
            });

            modelBuilder.Entity<Dtwo>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.GeneralInformartion)
                    .WithMany(p => p.Dtwo)
                    .HasForeignKey(d => d.GeneralInformartionId)
                    .HasConstraintName("FK_DTwo_GeneralInformation");
            });

            modelBuilder.Entity<DtwoPictures>(entity =>
            {
                entity.Property(e => e.Filename).IsUnicode(false);

                entity.HasOne(d => d.IdTwoNavigation)
                    .WithMany(p => p.DtwoPictures)
                    .HasForeignKey(d => d.IdTwo)
                    .HasConstraintName("FK_DTwoPictures_DTwo");
            });

            modelBuilder.Entity<GeneralInformation>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("(N'In Process')");

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GeneralInformationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralInformation_AspNetUsers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.GeneralInformation)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralInformation_Customers");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.GeneralInformation)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralInformation_dDepartment");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.GeneralInformationOwnerNavigation)
                    .HasForeignKey(d => d.Owner)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GeneralInformation_AspNetUsers1");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.GeneralInformation)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralInformation_dProcesses");
            });

            modelBuilder.Entity<InputRisk>(entity =>
            {
                entity.Property(e => e.PossibleRisk).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Aprobacion')");

                entity.HasOne(d => d.Input)
                    .WithMany(p => p.InputRisk)
                    .HasForeignKey(d => d.InputId)
                    .HasConstraintName("FK_InputRisk_tInputs");
            });

            modelBuilder.Entity<InputRiskControl>(entity =>
            {
                entity.Property(e => e.Control).IsUnicode(false);

                entity.Property(e => e.Implemented).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.HasOne(d => d.InputRisk)
                    .WithMany(p => p.InputRiskControl)
                    .HasForeignKey(d => d.InputRiskId)
                    .HasConstraintName("FK_InputRiskControl_InputRisk");
            });

            modelBuilder.Entity<OutputRisk>(entity =>
            {
                entity.Property(e => e.PossibleRisk).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Aprobacion')");

                entity.HasOne(d => d.Output)
                    .WithMany(p => p.OutputRisk)
                    .HasForeignKey(d => d.OutputId)
                    .HasConstraintName("FK_OutputRisk_tOutputs");
            });

            modelBuilder.Entity<OutputRiskControl>(entity =>
            {
                entity.Property(e => e.Control).IsUnicode(false);

                entity.Property(e => e.Implemented).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Aprobacion')");

                entity.HasOne(d => d.OutputRisk)
                    .WithMany(p => p.OutputRiskControl)
                    .HasForeignKey(d => d.OutputRiskId)
                    .HasConstraintName("FK_OutputRiskControl_OutputRisk");
            });

            modelBuilder.Entity<PartNumbers>(entity =>
            {
                entity.Property(e => e.LastModifiedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PartNumbers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PartNumbers_Customers");
            });

            modelBuilder.Entity<RDepartments>(entity =>
            {
                entity.Property(e => e.Acronym).IsFixedLength();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RoutesUsers>(entity =>
            {
                entity.HasOne(d => d.IdrouteNavigation)
                    .WithMany(p => p.RoutesUsers)
                    .HasForeignKey(d => d.Idroute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoutesUsers_tRoutes");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.RoutesUsers)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("FK_RoutesUsers_AspNetUsers");
            });

            modelBuilder.Entity<THows>(entity =>
            {
                entity.Property(e => e.How).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.THows)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tHows_DocumentHistory");
            });

            modelBuilder.Entity<TInputs>(entity =>
            {
                entity.Property(e => e.Input).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.TInputs)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tInputs_DocumentHistory");
            });

            modelBuilder.Entity<TMeasurements>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Measurement).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Aprobacion')");

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.TMeasurements)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tMeasurements_DocumentHistory");
            });

            modelBuilder.Entity<TOutputs>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Output).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.TOutputs)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tOutputs_DocumentHistory");
            });

            modelBuilder.Entity<TRoutes>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<TUsers>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Password).IsUnicode(false);
            });

            modelBuilder.Entity<TWhats>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.Property(e => e.What).IsUnicode(false);

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.TWhats)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tWhats_DocumentHistory");
            });

            modelBuilder.Entity<TWhos>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Draft')");

                entity.Property(e => e.Who).IsUnicode(false);

                entity.HasOne(d => d.DocumentHistory)
                    .WithMany(p => p.TWhos)
                    .HasForeignKey(d => d.DocumentHistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tWhos_DocumentHistory");
            });

            modelBuilder.Entity<Turtle>(entity =>
            {
                entity.Property(e => e.DocumentNumber).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
