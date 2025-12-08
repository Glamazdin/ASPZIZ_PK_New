using System;
using System.Collections.Generic;
using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Data;

public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    #region Entities
    public virtual DbSet<Abitur> Abiturs { get; set; }

    public virtual DbSet<AbiturOcenki> AbiturOcenkis { get; set; }

    public virtual DbSet<AbiturPolupr> AbiturPoluprs { get; set; }

    public virtual DbSet<AbiturRegStepChangeLog> AbiturRegStepChangeLogs { get; set; }

    public virtual DbSet<AbiturZayvl> AbiturZayvls { get; set; }

    public virtual DbSet<Accept> Accepts { get; set; }

    //public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    //public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    //public virtual DbSet<AspnetPath> AspnetPaths { get; set; }

    //public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }

    //public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

    //public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }

    //public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    //public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    //public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    //public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }

    public virtual DbSet<ConsentForPdp> ConsentForPdps { get; set; }

    public virtual DbSet<ConsentPdp> ConsentPdps { get; set; }

    public virtual DbSet<CtCertificaty> CtCertificaties { get; set; }

    public virtual DbSet<CtUchastniki> CtUchastnikis { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<EntrantsOfInnerExam> EntrantsOfInnerExams { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamType> ExamTypes { get; set; }

    public virtual DbSet<ExamType100Ballov> ExamType100Ballovs { get; set; }

    public virtual DbSet<Gragdanstvo> Gragdanstvos { get; set; }

    public virtual DbSet<GroupOfSpeciality> GroupOfSpecialities { get; set; }

    public virtual DbSet<GroupsOfSpecialitiesRelationship> GroupsOfSpecialitiesRelationships { get; set; }

    public virtual DbSet<LgotiBezEkz> LgotiBezEkzs { get; set; }

    public virtual DbSet<LgotiVneKonk> LgotiVneKonks { get; set; }

    public virtual DbSet<LgotyPolupr> LgotyPoluprs { get; set; }

    public virtual DbSet<ObrDokType> ObrDokTypes { get; set; }

    public virtual DbSet<ObrFroma> ObrFromas { get; set; }

    public virtual DbSet<ObrSrBal510> ObrSrBal510s { get; set; }

    public virtual DbSet<ObrUchregd> ObrUchregds { get; set; }

    public virtual DbSet<ObrUroven> ObrUrovens { get; set; }

    public virtual DbSet<ObrVid> ObrVids { get; set; }

    public virtual DbSet<OkskSpec> OkskSpecs { get; set; }

    public virtual DbSet<OkskSpecSpecialization> OkskSpecSpecializations { get; set; }

    public virtual DbSet<OkskSpecialization> OkskSpecializations { get; set; }

    public virtual DbSet<PassportType> PassportTypes { get; set; }

    public virtual DbSet<PermissionUser> PermissionUsers { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<PlaceAfterAccept> PlaceAfterAccepts { get; set; }

    public virtual DbSet<PlaceUser> PlaceUsers { get; set; }

    public virtual DbSet<Prikaz> Prikazs { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<SpetializationGrade> SpetializationGrades { get; set; }

    public virtual DbSet<SsuzSpec> SsuzSpecs { get; set; }

    public virtual DbSet<StatSpecGroup> StatSpecGroups { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TablesAbitur> TablesAbiturs { get; set; }

    public virtual DbSet<TablesLog> TablesLogs { get; set; }

    public virtual DbSet<TablesQueue> TablesQueues { get; set; }

    public virtual DbSet<TablesState> TablesStates { get; set; }

    public virtual DbSet<TablesTableToQueue> TablesTableToQueues { get; set; }

    public virtual DbSet<Vuz> Vuzs { get; set; }

    public virtual DbSet<VuzFaclt> VuzFaclts { get; set; }

    public virtual DbSet<VuzSpec> VuzSpecs { get; set; }

    public virtual DbSet<VuzSpecEkz> VuzSpecEkzs { get; set; }

    public virtual DbSet<VuzSpecialization> VuzSpecializations { get; set; }

    public virtual DbSet<VuzSrok> VuzSroks { get; set; }

    public virtual DbSet<VuzSsuzSpec> VuzSsuzSpecs { get; set; }

    //public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    //public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    //public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }

    //public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    //public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    //public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    //public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }

    //public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }

    //public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

    public virtual DbSet<VwEntrantsOfInnerExam> VwEntrantsOfInnerExams { get; set; }

    public virtual DbSet<VwGroupsOfSpeciality> VwGroupsOfSpecialities { get; set; }

    public virtual DbSet<VwSpeciality> VwSpecialities { get; set; }

    public virtual DbSet<VwSpecialization> VwSpecializations { get; set; }

    public virtual DbSet<VwTmp> VwTmps { get; set; }

    #endregion

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder
//            .UseSqlServer("Server=.\\SQLEXPRESS;Database=Test_ASPZIZ_PK;Integrated Security=True;Trust Server Certificate=True;")
//            .ConfigureWarnings(w => w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Abitur>(entity =>
        {
            entity.HasKey(e => e.AbiturId).HasName("PK_Abitur_1");

            entity.Property(e => e.AbiturId).HasDefaultValueSql("(newid())", "DF_Abitur_abiturId");
            entity.Property(e => e.BirthPlaceNasPunktTip).HasDefaultValueSql("(NULL)", "DF__Abitur__birthPla__3AA1AEB8");
            entity.Property(e => e.FamLatin).HasDefaultValueSql("(NULL)", "DF__Abitur__famLatin__38B96646");
            entity.Property(e => e.ImLatin).HasDefaultValueSql("(NULL)", "DF__Abitur__imLatin__37C5420D");
            entity.Property(e => e.IsExamInRussian).HasDefaultValue(true, "DF__Abitur__isExamIn__02133CD2");
            entity.Property(e => e.PasValidity).HasDefaultValueSql("(NULL)", "DF__Abitur__pasValid__39AD8A7F");
            entity.Property(e => e.PlaceId).HasDefaultValue((byte)0, "DF__Abitur__placeId__2DF1BF10");

            entity.HasOne(d => d.AcceptSpeciality).WithMany(p => p.Abiturs).HasConstraintName("FK_Abitur_Vuz_Spec");

            entity.HasOne(d => d.BezEkz).WithMany(p => p.Abiturs).HasConstraintName("FK_Abitur_Lgoti_BezEkz");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Abiturs).HasConstraintName("FK_Abitur_AspNetUsers");

            entity.HasOne(d => d.ObrDokType).WithMany(p => p.Abiturs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Obr_DokType");

            entity.HasOne(d => d.ObrUch).WithMany(p => p.Abiturs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Obr_Uchregd");

            entity.HasOne(d => d.ObrUrov).WithMany(p => p.Abiturs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Obr_Uroven");

            entity.HasOne(d => d.PasType).WithMany(p => p.AbiturPasTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Doc");

            entity.HasOne(d => d.Place).WithMany(p => p.Abiturs).HasConstraintName("FK_Abitur_Place");

            entity.HasOne(d => d.PredPasType).WithMany(p => p.AbiturPredPasTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_PassportType");

            entity.HasOne(d => d.SpetializationClass).WithMany(p => p.Abiturs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Spetialization_grade");

            entity.HasOne(d => d.VneKonk).WithMany(p => p.Abiturs).HasConstraintName("FK_Abitur_Lgoti_VneKonk");
        });

        modelBuilder.Entity<AbiturOcenki>(entity =>
        {
            entity.HasOne(d => d.Abitur).WithMany(p => p.AbiturOcenkis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Ocenki_Abitur");

            entity.HasOne(d => d.Ekz).WithMany(p => p.AbiturOcenkis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Ocenki_Ekzamen");

            entity.HasOne(d => d.ExamType).WithMany(p => p.AbiturOcenkis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Ocenki_ExamType");
        });

        modelBuilder.Entity<AbiturPolupr>(entity =>
        {
            entity.HasOne(d => d.Abitur).WithMany(p => p.AbiturPoluprs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Polupr_Abitur");

            entity.HasOne(d => d.Polupr).WithMany(p => p.AbiturPoluprs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Polupr_Lgoty_Polupr");
        });

        modelBuilder.Entity<AbiturRegStepChangeLog>(entity =>
        {
            entity.HasOne(d => d.Abitur).WithMany(p => p.AbiturRegStepChangeLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_RegStep_ChangeLog_Abitur");

            entity.HasOne(d => d.User).WithMany(p => p.AbiturRegStepChangeLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbiturRegStepChangeLog_AspNetUsers");
        });

        modelBuilder.Entity<AbiturZayvl>(entity =>
        {
            entity.HasKey(e => e.ZayvlId).HasName("PK_Zayvl");

            entity.Property(e => e.ApplicationNumber).HasDefaultValue((byte)1, "DF_Abitur_Zayvl_applicationNumber");

            entity.HasOne(d => d.Abitur).WithMany(p => p.AbiturZayvls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Zayvl_Abitur");

            entity.HasOne(d => d.VuzSpec).WithMany(p => p.AbiturZayvls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Abitur_Zayvl_Vuz_Spec");
        });

        modelBuilder.Entity<Accept>(entity =>
        {
            entity.Property(e => e.AcceptInGroupResult).HasDefaultValue(false, "DF_Accept_acceptInGroup_Result");
            entity.Property(e => e.AcceptInSpecialityResult).HasDefaultValue(false, "DF_Accept_acceptInSpeciality_Result");
            entity.Property(e => e.IsPreview).HasDefaultValue(true, "DF_Accept_isPreview");

            entity.HasOne(d => d.Abitur).WithMany(p => p.Accepts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accept_Abitur");

            entity.HasOne(d => d.AcceptInGroupUser).WithMany(p => p.AcceptInGroupUsers).HasConstraintName("FK_Accept_AspNetUsers_GroupUser");

            entity.HasOne(d => d.AcceptInSpecialityUser).WithMany(p => p.AcceptInSpecialityUsers).HasConstraintName("FK_Accept_AspNetUsers_SpecialityUser");

            entity.HasOne(d => d.Group).WithMany(p => p.Accepts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accept_SpecGroup");
        });

        

        modelBuilder.Entity<ConsentForPdp>(entity =>
        {
            entity.Property(e => e.ConsentAbiturId).HasDefaultValueSql("(newid())", "DF_ConsentForPDP_consentAbiturId");

            entity.HasOne(d => d.Abitur).WithMany(p => p.ConsentForPdps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsentForPDP_abiturId");

            entity.HasOne(d => d.Consent).WithMany(p => p.ConsentForPdps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsentForPDP_ConsentId");
        });

        modelBuilder.Entity<ConsentPdp>(entity =>
        {
            entity.Property(e => e.ConsentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CtCertificaty>(entity =>
        {
            entity.Property(e => e.CtId).ValueGeneratedNever();

            entity.HasOne(d => d.CtUch).WithMany(p => p.CtCertificaties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_Certificaty_CT_Uchastniki");

            entity.HasOne(d => d.Predm).WithMany(p => p.CtCertificaties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_Certificaty_Ekzamen");
        });

        modelBuilder.Entity<CtUchastniki>(entity =>
        {
            entity.Property(e => e.CtUchId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.EkzId).HasName("PK_CT_Discipl");

            entity.HasOne(d => d.ExamType).WithMany(p => p.Exams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ekzamen_ExamType");
        });

        modelBuilder.Entity<ExamType100Ballov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ekzamen_100_ballov");

            entity.HasOne(d => d.Ekz).WithMany(p => p.ExamType100Ballovs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ekzamen_100_ballov_Ekzamen");
        });

        modelBuilder.Entity<GroupOfSpeciality>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_SpecGroup");

            entity.Property(e => e.AcceptStatus).HasDefaultValue((byte)1, "DF_SpecGroup_acceptStatus");
        });

        modelBuilder.Entity<GroupsOfSpecialitiesRelationship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GroupsOfSpecialities_Rel");
        });

        modelBuilder.Entity<LgotiVneKonk>(entity =>
        {
            entity.HasKey(e => e.VkId).HasName("PK_Lgoti_VneKonkursa");
        });

        modelBuilder.Entity<ObrDokType>(entity =>
        {
            entity.HasKey(e => e.ObrDokTypeId).HasName("PK_PK_ObrazovanieDokumenti");

            entity.HasOne(d => d.ObrUrov).WithMany(p => p.ObrDokTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Obr_Dok_Obr_Uroven");
        });

        modelBuilder.Entity<ObrUchregd>(entity =>
        {
            entity.HasKey(e => e.ObrUchId).HasName("PK_Obrazovanie_Uchregdeniya");

            entity.HasOne(d => d.ObrUrov).WithMany(p => p.ObrUchregds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Obr_Uchregd_Obr_Uroven");
        });

        modelBuilder.Entity<ObrUroven>(entity =>
        {
            entity.HasKey(e => e.ObrUrovId).HasName("PK_ObrUroven");
        });

        modelBuilder.Entity<ObrVid>(entity =>
        {
            entity.HasOne(d => d.ObrForma).WithMany(p => p.ObrVids)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Obr_Vid_Obr_Froma");
        });

        modelBuilder.Entity<OkskSpec>(entity =>
        {
            entity.Property(e => e.SpecId).ValueGeneratedNever();
        });

        modelBuilder.Entity<OkskSpecSpecialization>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Spec).WithMany(p => p.OkskSpecSpecializations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OKSK_Spec_Specialization_OKSK_Spec");

            entity.HasOne(d => d.Specialization).WithMany(p => p.OkskSpecSpecializations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OKSK_Spec_Specialization_OKSK_Specialization");
        });

        modelBuilder.Entity<OkskSpecialization>(entity =>
        {
            entity.Property(e => e.SpecializationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PassportType>(entity =>
        {
            entity.HasKey(e => e.PasTypeId).HasName("PK_Doc");
        });

        modelBuilder.Entity<PermissionUser>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.PermissionUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PermissionUser_AspNetUsers");
        });

        modelBuilder.Entity<PlaceAfterAccept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Palce_AfterAccept");

            entity.HasOne(d => d.Place).WithMany(p => p.PlaceAfterAccepts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Palce_AfterAccept_Place");

            entity.HasOne(d => d.Speciality).WithMany(p => p.PlaceAfterAccepts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Palce_AfterAccept_Vuz_Spec");
        });

        modelBuilder.Entity<PlaceUser>(entity =>
        {
            entity.HasOne(d => d.Place).WithMany(p => p.PlaceUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Place_User_Place_User");

            entity.HasOne(d => d.User).WithMany(p => p.PlaceUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlaceUser_AspNetUsers");
        });

        modelBuilder.Entity<Prikaz>(entity =>
        {
            entity.ToView("Prikaz");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.RegisterId).HasName("primaryRegisterIdKey");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.Registers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Register_AspNetUsers_CreatedBy");

            entity.HasOne(d => d.Group).WithMany(p => p.Registers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("foreignRegisterToGroupOfSpecialities");
        });

        modelBuilder.Entity<SsuzSpec>(entity =>
        {
            entity.Property(e => e.SpecId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StatSpecGroup>(entity =>
        {
            entity.Property(e => e.StatGroupId).ValueGeneratedNever();
            entity.Property(e => e.SiteIsLocked).HasDefaultValue(false);
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.TableId).HasName("PK_Tables_1");

            entity.Property(e => e.TableId).ValueGeneratedNever();

            entity.HasOne(d => d.Duty).WithMany(p => p.TableAsDuty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_AspNetUsers_Duty");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Tables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_Tables_states1");

            entity.HasOne(d => d.TableNavigation).WithOne(p => p.TableAsTableNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_AspNetUsers_TableId");
        });

        modelBuilder.Entity<TablesAbitur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tables_ques");

            entity.HasOne(d => d.Queue).WithMany(p => p.TablesAbiturs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_ques_Tables_queues");
        });

        modelBuilder.Entity<TablesLog>(entity =>
        {
            entity.HasOne(d => d.Changer).WithMany(p => p.TablesLogAsChanger)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TablesLog_AspNetUsers_Changer");

            entity.HasOne(d => d.NewStateNavigation).WithMany(p => p.TablesLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_logs_Tables_states");

            entity.HasOne(d => d.Table).WithMany(p => p.TablesLogAsTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TablesLog_AspNetUsers_TableId");
        });

        modelBuilder.Entity<TablesState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tables_states_1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TablesTableToQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tables_t__3213E83FA4DD4C81");

            entity.HasOne(d => d.Queue).WithMany(p => p.TablesTableToQueues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_tableToQueue_Queue_Id");

            entity.HasOne(d => d.Table).WithMany(p => p.TablesTableToQueues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tables_tableToQueue_Table_Id");
        });

        modelBuilder.Entity<VuzFaclt>(entity =>
        {
            entity.Property(e => e.FacltId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VuzSpec>(entity =>
        {
            entity.Property(e => e.VuzSpecId).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.VuzSpecs).HasConstraintName("FK_Vuz_Spec_Customers");

            entity.HasOne(d => d.Faclt).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_Vuz_Faclt");

            entity.HasOne(d => d.ObrVid).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_Obr_Vid");

            entity.HasOne(d => d.SpecGroup).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_SpecGroup");

            entity.HasOne(d => d.Spec).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_OKSK_Spec");

            entity.HasOne(d => d.StatSpecGroup).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_StatSpecGroup");

            entity.HasOne(d => d.Vuz).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_Vuz");

            entity.HasOne(d => d.VuzSrok).WithMany(p => p.VuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_Vuz_Srok");
        });

        modelBuilder.Entity<VuzSpecEkz>(entity =>
        {
            entity.HasOne(d => d.Ekz).WithMany(p => p.VuzSpecEkzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Spec_Ekz_Ekzamen");
        });

        modelBuilder.Entity<VuzSpecialization>(entity =>
        {
            entity.Property(e => e.VuzSpecializationId).ValueGeneratedNever();

            entity.HasOne(d => d.SpecSpecialization).WithMany(p => p.VuzSpecializations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Specialization_OKSK_Spec_Specialization");

            entity.HasOne(d => d.VuzSpec).WithMany(p => p.VuzSpecializations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_Specialization_Vuz_Spec");
        });

        modelBuilder.Entity<VuzSsuzSpec>(entity =>
        {
            entity.HasOne(d => d.SsuzSpec).WithMany(p => p.VuzSsuzSpecs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vuz_SSUZ_Spec_SSUZ_Spec");
        });

        //modelBuilder.Entity<VwAspnetApplication>(entity =>
        //{
        //    entity.ToView("vw_aspnet_Applications");
        //});

        //modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
        //{
        //    entity.ToView("vw_aspnet_MembershipUsers");
        //});

        //modelBuilder.Entity<VwAspnetProfile>(entity =>
        //{
        //    entity.ToView("vw_aspnet_Profiles");
        //});

        //modelBuilder.Entity<VwAspnetRole>(entity =>
        //{
        //    entity.ToView("vw_aspnet_Roles");
        //});

        //modelBuilder.Entity<VwAspnetUser>(entity =>
        //{
        //    entity.ToView("vw_aspnet_Users");
        //});

        //modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
        //{
        //    entity.ToView("vw_aspnet_UsersInRoles");
        //});

        //modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
        //{
        //    entity.ToView("vw_aspnet_WebPartState_Paths");
        //});

        //modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
        //{
        //    entity.ToView("vw_aspnet_WebPartState_Shared");
        //});

        //modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
        //{
        //    entity.ToView("vw_aspnet_WebPartState_User");
        //});

        modelBuilder.Entity<VwEntrantsOfInnerExam>(entity =>
        {
            entity.ToView("vw_EntrantsOfInnerExams");
        });

        modelBuilder.Entity<VwGroupsOfSpeciality>(entity =>
        {
            entity.ToView("vw_GroupsOfSpecialities");
        });

        modelBuilder.Entity<VwSpeciality>(entity =>
        {
            entity.ToView("vw_Specialities");
        });

        modelBuilder.Entity<VwSpecialization>(entity =>
        {
            entity.ToView("vw_Specializations");
        });

        modelBuilder.Entity<VwTmp>(entity =>
        {
            entity.ToView("vw_TMP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
