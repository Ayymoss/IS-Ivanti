using ISIvanti.Server.Models.IvantiModels;
using Microsoft.EntityFrameworkCore;
using Task = ISIvanti.Server.Models.IvantiModels.Task;

namespace ISIvanti.Server.Context;

public partial class IvantiDataContext : DbContext
{
    public IvantiDataContext()
    {
    }

    public IvantiDataContext(DbContextOptions<IvantiDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acconfiguration> Acconfigurations { get; set; }
    public virtual DbSet<AcconfigurationVersion> AcconfigurationVersions { get; set; }
    public virtual DbSet<Acevent> Acevents { get; set; }
    public virtual DbSet<AceventFile> AceventFiles { get; set; }
    public virtual DbSet<Agent> Agents { get; set; }
    public virtual DbSet<Agent1> Agents1 { get; set; }
    public virtual DbSet<Agent2> Agents2 { get; set; }
    public virtual DbSet<AgentAttachment> AgentAttachments { get; set; }
    public virtual DbSet<AgentPushInstall> AgentPushInstalls { get; set; }
    public virtual DbSet<AgentRegistrationLog> AgentRegistrationLogs { get; set; }
    public virtual DbSet<ApprovedPatchPart> ApprovedPatchParts { get; set; }
    public virtual DbSet<ApprovedServicePackPart> ApprovedServicePackParts { get; set; }
    public virtual DbSet<Architecture> Architectures { get; set; }
    public virtual DbSet<Architecture1> Architectures1 { get; set; }
    public virtual DbSet<AssessedMachineState> AssessedMachineStates { get; set; }
    public virtual DbSet<AssessedMachineState1> AssessedMachineStates1 { get; set; }
    public virtual DbSet<AssetDefinition> AssetDefinitions { get; set; }
    public virtual DbSet<AssetScanTemplate> AssetScanTemplates { get; set; }
    public virtual DbSet<AssetScanTemplateCategory> AssetScanTemplateCategories { get; set; }
    public virtual DbSet<AssetValue> AssetValues { get; set; }
    public virtual DbSet<AssetValueCommon> AssetValueCommons { get; set; }
    public virtual DbSet<AssetValueList> AssetValueLists { get; set; }
    public virtual DbSet<Attachment> Attachments { get; set; }
    public virtual DbSet<Bulletin> Bulletins { get; set; }
    public virtual DbSet<BulletinDeployment> BulletinDeployments { get; set; }
    public virtual DbSet<Bundle> Bundles { get; set; }
    public virtual DbSet<ConsoleConfiguration> ConsoleConfigurations { get; set; }
    public virtual DbSet<ConsoleIdentity> ConsoleIdentities { get; set; }
    public virtual DbSet<Credential> Credentials { get; set; }
    public virtual DbSet<CredentialAccess> CredentialAccesses { get; set; }
    public virtual DbSet<CredentialUsage> CredentialUsages { get; set; }
    public virtual DbSet<CustomAction> CustomActions { get; set; }
    public virtual DbSet<Cve> Cves { get; set; }
    public virtual DbSet<Cve1> Cves1 { get; set; }
    public virtual DbSet<Cve2> Cves2 { get; set; }
    public virtual DbSet<DeployState> DeployStates { get; set; }
    public virtual DbSet<DeployState1> DeployStates1 { get; set; }
    public virtual DbSet<DeployState2> DeployStates2 { get; set; }
    public virtual DbSet<DeployTemplate> DeployTemplates { get; set; }
    public virtual DbSet<DeploymentSeat> DeploymentSeats { get; set; }
    public virtual DbSet<DetectedBulletin> DetectedBulletins { get; set; }
    public virtual DbSet<DetectedBundle> DetectedBundles { get; set; }
    public virtual DbSet<DetectedPatch> DetectedPatches { get; set; }
    public virtual DbSet<DetectedPatchState> DetectedPatchStates { get; set; }
    public virtual DbSet<DetectedPatchState1> DetectedPatchStates1 { get; set; }
    public virtual DbSet<DetectedSoftwareAsset> DetectedSoftwareAssets { get; set; }
    public virtual DbSet<DirectoryServer> DirectoryServers { get; set; }
    public virtual DbSet<DiscoveryFilter> DiscoveryFilters { get; set; }
    public virtual DbSet<Distribution> Distributions { get; set; }
    public virtual DbSet<DownloadFileLocation> DownloadFileLocations { get; set; }
    public virtual DbSet<EmailGroup> EmailGroups { get; set; }
    public virtual DbSet<EmailRecipient> EmailRecipients { get; set; }
    public virtual DbSet<EventSubscription> EventSubscriptions { get; set; }
    public virtual DbSet<EventViewerView> EventViewerViews { get; set; }
    public virtual DbSet<Favorite> Favorites { get; set; }
    public virtual DbSet<HostedVirtualSystem> HostedVirtualSystems { get; set; }
    public virtual DbSet<Hypervisor> Hypervisors { get; set; }
    public virtual DbSet<HypervisorResult> HypervisorResults { get; set; }
    public virtual DbSet<InstallState> InstallStates { get; set; }
    public virtual DbSet<InstallState1> InstallStates1 { get; set; }
    public virtual DbSet<InstallState2> InstallStates2 { get; set; }
    public virtual DbSet<LinkDeploymentScanItem> LinkDeploymentScanItems { get; set; }
    public virtual DbSet<LinkEmailRecDeploymentTemplate> LinkEmailRecDeploymentTemplates { get; set; }
    public virtual DbSet<LinkEmailRecMachineAnnotation> LinkEmailRecMachineAnnotations { get; set; }
    public virtual DbSet<LinkEmailRecManagedGroup> LinkEmailRecManagedGroups { get; set; }
    public virtual DbSet<LinkEmailRecManagedMachine> LinkEmailRecManagedMachines { get; set; }
    public virtual DbSet<LinkEmailRecScanTemplate> LinkEmailRecScanTemplates { get; set; }
    public virtual DbSet<LinkFavoriteGroup> LinkFavoriteGroups { get; set; }
    public virtual DbSet<LinkPatchProduct> LinkPatchProducts { get; set; }
    public virtual DbSet<LinkSpproduct> LinkSpproducts { get; set; }
    public virtual DbSet<LinkTemplatePatchGroup> LinkTemplatePatchGroups { get; set; }
    public virtual DbSet<LinuxCompletionCode> LinuxCompletionCodes { get; set; }
    public virtual DbSet<LinuxCompletionCode1> LinuxCompletionCodes1 { get; set; }
    public virtual DbSet<LinuxDetectedPatchState> LinuxDetectedPatchStates { get; set; }
    public virtual DbSet<LinuxDistribution> LinuxDistributions { get; set; }
    public virtual DbSet<LinuxErrorStep> LinuxErrorSteps { get; set; }
    public virtual DbSet<LinuxErrorStep1> LinuxErrorSteps1 { get; set; }
    public virtual DbSet<LinuxInstallState> LinuxInstallStates { get; set; }
    public virtual DbSet<LinuxInstallState1> LinuxInstallStates1 { get; set; }
    public virtual DbSet<LinuxNotification> LinuxNotifications { get; set; }
    public virtual DbSet<LinuxPatch> LinuxPatches { get; set; }
    public virtual DbSet<LinuxPatchAppliesTo> LinuxPatchAppliesTos { get; set; }
    public virtual DbSet<LinuxPatchDeployment> LinuxPatchDeployments { get; set; }
    public virtual DbSet<LinuxPatchType> LinuxPatchTypes { get; set; }
    public virtual DbSet<LinuxPatchType1> LinuxPatchTypes1 { get; set; }
    public virtual DbSet<LinuxPlatform> LinuxPlatforms { get; set; }
    public virtual DbSet<Machine> Machines { get; set; }
    public virtual DbSet<Machine1> Machines1 { get; set; }
    public virtual DbSet<MachineDeployment> MachineDeployments { get; set; }
    public virtual DbSet<MachineDeploymentStatus> MachineDeploymentStatuses { get; set; }
    public virtual DbSet<MachineMeasure> MachineMeasures { get; set; }
    public virtual DbSet<ManagedGroup> ManagedGroups { get; set; }
    public virtual DbSet<ManagedMachine> ManagedMachines { get; set; }
    public virtual DbSet<NetworkInterface> NetworkInterfaces { get; set; }
    public virtual DbSet<Notification> Notifications { get; set; }
    public virtual DbSet<OperatingSystemFamily> OperatingSystemFamilies { get; set; }
    public virtual DbSet<OperatingSystemFamily1> OperatingSystemFamilies1 { get; set; }
    public virtual DbSet<OperationLog> OperationLogs { get; set; }
    public virtual DbSet<OperationLogStep> OperationLogSteps { get; set; }
    public virtual DbSet<Osdistribution> Osdistributions { get; set; }
    public virtual DbSet<Patch> Patches { get; set; }
    public virtual DbSet<Patch1> Patches1 { get; set; }
    public virtual DbSet<Patch2> Patches2 { get; set; }
    public virtual DbSet<Patch3> Patches3 { get; set; }
    public virtual DbSet<PatchAppliesTo> PatchAppliesTos { get; set; }
    public virtual DbSet<PatchAppliesTo1> PatchAppliesTos1 { get; set; }
    public virtual DbSet<PatchCountsByScanMachine> PatchCountsByScanMachines { get; set; }
    public virtual DbSet<PatchCountsByScanMachine1> PatchCountsByScanMachines1 { get; set; }
    public virtual DbSet<PatchCve> PatchCves { get; set; }
    public virtual DbSet<PatchDeployAudit> PatchDeployAudits { get; set; }
    public virtual DbSet<PatchDeployment> PatchDeployments { get; set; }
    public virtual DbSet<PatchDeployment1> PatchDeployments1 { get; set; }
    public virtual DbSet<PatchDeployment2> PatchDeployments2 { get; set; }
    public virtual DbSet<PatchDeployment3> PatchDeployments3 { get; set; }
    public virtual DbSet<PatchDeploymentConfiguration> PatchDeploymentConfigurations { get; set; }
    public virtual DbSet<PatchDeploymentDetectedPatch> PatchDeploymentDetectedPatches { get; set; }
    public virtual DbSet<PatchDeploymentDetectedPatchAction> PatchDeploymentDetectedPatchActions { get; set; }
    public virtual DbSet<PatchGroup> PatchGroups { get; set; }
    public virtual DbSet<PatchGroup1> PatchGroups1 { get; set; }
    public virtual DbSet<PatchGroupItem> PatchGroupItems { get; set; }
    public virtual DbSet<PatchNotification> PatchNotifications { get; set; }
    public virtual DbSet<PatchPlatform> PatchPlatforms { get; set; }
    public virtual DbSet<PatchProductFilter> PatchProductFilters { get; set; }
    public virtual DbSet<PatchScan> PatchScans { get; set; }
    public virtual DbSet<PatchScan1> PatchScans1 { get; set; }
    public virtual DbSet<PatchScanConfiguration> PatchScanConfigurations { get; set; }
    public virtual DbSet<PatchTrace> PatchTraces { get; set; }
    public virtual DbSet<PatchTrace1> PatchTraces1 { get; set; }
    public virtual DbSet<PatchType> PatchTypes { get; set; }
    public virtual DbSet<PatchType1> PatchTypes1 { get; set; }
    public virtual DbSet<PatchType2> PatchTypes2 { get; set; }
    public virtual DbSet<Platform> Platforms { get; set; }
    public virtual DbSet<Platform1> Platforms1 { get; set; }
    public virtual DbSet<Policy> Policies { get; set; }
    public virtual DbSet<PowerShellModule> PowerShellModules { get; set; }
    public virtual DbSet<PowerShellResult> PowerShellResults { get; set; }
    public virtual DbSet<PowerShellRun> PowerShellRuns { get; set; }
    public virtual DbSet<PowerShellScript> PowerShellScripts { get; set; }
    public virtual DbSet<PowerShellTemplate> PowerShellTemplates { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Product1> Products1 { get; set; }
    public virtual DbSet<Product2> Products2 { get; set; }
    public virtual DbSet<PropertyCollection> PropertyCollections { get; set; }
    public virtual DbSet<RebootOptionsPart> RebootOptionsParts { get; set; }
    public virtual DbSet<RelayIprange> RelayIpranges { get; set; }
    public virtual DbSet<RelayServer> RelayServers { get; set; }
    public virtual DbSet<ResolutionResult> ResolutionResults { get; set; }
    public virtual DbSet<ResultImportExport> ResultImportExports { get; set; }
    public virtual DbSet<RoleUser> RoleUsers { get; set; }
    public virtual DbSet<Scan> Scans { get; set; }
    public virtual DbSet<ScanItem> ScanItems { get; set; }
    public virtual DbSet<ScanMachine> ScanMachines { get; set; }
    public virtual DbSet<ScanTemplate> ScanTemplates { get; set; }
    public virtual DbSet<ScanType> ScanTypes { get; set; }
    public virtual DbSet<ScanType1> ScanTypes1 { get; set; }
    public virtual DbSet<ServicePack> ServicePacks { get; set; }
    public virtual DbSet<ServicePackGroup> ServicePackGroups { get; set; }
    public virtual DbSet<ServicePackGroupProduct> ServicePackGroupProducts { get; set; }
    public virtual DbSet<SmartFilterGroup> SmartFilterGroups { get; set; }
    public virtual DbSet<SmartFilterRule> SmartFilterRules { get; set; }
    public virtual DbSet<SoftwareTitle> SoftwareTitles { get; set; }
    public virtual DbSet<SourceType> SourceTypes { get; set; }
    public virtual DbSet<SourceType1> SourceTypes1 { get; set; }
    public virtual DbSet<SourceType2> SourceTypes2 { get; set; }
    public virtual DbSet<Task> Tasks { get; set; }
    public virtual DbSet<TaskParameter> TaskParameters { get; set; }
    public virtual DbSet<TaskPolicyPart> TaskPolicyParts { get; set; }
    public virtual DbSet<Top10VulnerableMachine> Top10VulnerableMachines { get; set; }
    public virtual DbSet<UserCredential> UserCredentials { get; set; }
    public virtual DbSet<UserCredentialUsage> UserCredentialUsages { get; set; }
    public virtual DbSet<VcenterServer> VcenterServers { get; set; }
    public virtual DbSet<VendorSeverity> VendorSeverities { get; set; }
    public virtual DbSet<VendorSeverity1> VendorSeverities1 { get; set; }
    public virtual DbSet<VendorSeverity2> VendorSeverities2 { get; set; }
    public virtual DbSet<VirtualImage> VirtualImages { get; set; }
    public virtual DbSet<VirtualMachine> VirtualMachines { get; set; }
    public virtual DbSet<VirtualOwnership> VirtualOwnerships { get; set; }
    public virtual DbSet<VirtualServer> VirtualServers { get; set; }
    public virtual DbSet<XtrCumulativePatch> XtrCumulativePatches { get; set; }
    public virtual DbSet<XtrCurrentPatchCount> XtrCurrentPatchCounts { get; set; }
    public virtual DbSet<XtrCurrentPatchStatus> XtrCurrentPatchStatuses { get; set; }
    public virtual DbSet<XtrDistinctAssessed> XtrDistinctAssesseds { get; set; }
    public virtual DbSet<XtrDistinctDeployed> XtrDistinctDeployeds { get; set; }
    public virtual DbSet<XtrDistinctPatched> XtrDistinctPatcheds { get; set; }
    public virtual DbSet<XtrEntityProcessErrorLog> XtrEntityProcessErrorLogs { get; set; }
    public virtual DbSet<XtrEntityProcessLog> XtrEntityProcessLogs { get; set; }
    public virtual DbSet<XtrLinuxCumulativePatch> XtrLinuxCumulativePatches { get; set; }
    public virtual DbSet<XtrLinuxCurrentPatchCount> XtrLinuxCurrentPatchCounts { get; set; }
    public virtual DbSet<XtrLinuxCurrentPatchStatus> XtrLinuxCurrentPatchStatuses { get; set; }
    public virtual DbSet<XtrLinuxDistinctDeployed> XtrLinuxDistinctDeployeds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(
            "Server=.;Database=SecurityControls;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ignore
        modelBuilder.Ignore<EventSubscription>();
        modelBuilder.Ignore<CredentialUsage>();
        modelBuilder.Ignore<UserCredentialUsage>();

        // Mappings
        modelBuilder.Entity<Acconfiguration>(entity =>
        {
            entity.HasKey(e => e.Uid).IsClustered(false);

            entity.ToTable("ACConfiguration", "ApplicationControl");

            entity.HasIndex(e => e.Id, "UK_ACConfiguration_Id")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.Name, "UK_ACConfiguration_Name").IsUnique();

            entity.Property(e => e.Uid).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<AcconfigurationVersion>(entity =>
        {
            entity.ToTable("ACConfigurationVersion", "ApplicationControl");

            entity.Property(e => e.AcconfigurationId).HasColumnName("ACConfigurationId");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastModifiedUser).HasMaxLength(256);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.SchemaVersion).HasMaxLength(43);

            entity.HasOne(d => d.Acconfiguration).WithMany(p => p.AcconfigurationVersions)
                .HasForeignKey(d => d.AcconfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACConfigurationVersion_AConfiguration");
        });

        modelBuilder.Entity<Acevent>(entity =>
        {
            entity.ToTable("ACEvent", "ApplicationControl");

            entity.HasIndex(e => e.FileId, "IX_ACEvent_File");

            entity.HasIndex(e => new {e.RaisedOn, e.EventId}, "IX_ACEvent_RaisedOnEvendId");

            entity.Property(e => e.MachineName).HasMaxLength(64);
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.File).WithMany(p => p.Acevents)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("FK_ACEvent_ACEventFile");

            entity.HasOne(d => d.Machine).WithMany(p => p.Acevents)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_ACEvent_ManagedMachines");
        });

        modelBuilder.Entity<AceventFile>(entity =>
        {
            entity.ToTable("ACEventFile", "ApplicationControl");

            entity.HasIndex(e => e.FileHash, "UK_ACEventFile_Hash").IsUnique();

            entity.Property(e => e.FileHash).HasMaxLength(32);
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.ToTable("Agent");

            entity.HasIndex(e => e.AgentId, "IX_Agent_agentId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("agentId");
            entity.Property(e => e.AssignedPolicyId).HasColumnName("assignedPolicyId");
            entity.Property(e => e.Certificate).HasColumnName("certificate");
            entity.Property(e => e.ConsoleUid).HasColumnName("consoleUid");
            entity.Property(e => e.DeletedOn)
                .HasColumnType("datetime")
                .HasColumnName("deletedOn");
            entity.Property(e => e.FrameworkVersion)
                .HasMaxLength(23)
                .HasColumnName("frameworkVersion");
            entity.Property(e => e.LastCheckIn)
                .HasColumnType("datetime")
                .HasColumnName("lastCheckIn");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.Listening).HasColumnName("listening");
            entity.Property(e => e.ListeningPort).HasColumnName("listeningPort");
            entity.Property(e => e.MachineId).HasColumnName("machineId");
            entity.Property(e => e.OsName)
                .HasMaxLength(255)
                .HasColumnName("osName");
            entity.Property(e => e.OsServicePack)
                .HasMaxLength(50)
                .HasColumnName("osServicePack");
            entity.Property(e => e.PatchDefinitionDate)
                .HasColumnType("datetime")
                .HasColumnName("patchDefinitionDate");
            entity.Property(e => e.PatchDefinitionVersion)
                .HasMaxLength(23)
                .HasColumnName("patchDefinitionVersion");
            entity.Property(e => e.PolicyAssignmentSerialNumber).HasColumnName("policyAssignmentSerialNumber");
            entity.Property(e => e.ReportedPolicyId).HasColumnName("reportedPolicyId");
            entity.Property(e => e.ReportedPolicyName)
                .HasMaxLength(255)
                .HasColumnName("reportedPolicyName");
            entity.Property(e => e.ReportedPolicyVersion).HasColumnName("reportedPolicyVersion");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.AssignedPolicy).WithMany(p => p.AgentAssignedPolicies)
                .HasForeignKey(d => d.AssignedPolicyId)
                .HasConstraintName("FK_Agent_AssignedPolicy");

            entity.HasOne(d => d.ConsoleU).WithMany(p => p.Agents)
                .HasPrincipalKey(p => p.ConsoleUid)
                .HasForeignKey(d => d.ConsoleUid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agent_ConsoleIdentity");

            entity.HasOne(d => d.Machine).WithMany(p => p.Agents)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_Agent_Machine");

            entity.HasOne(d => d.ReportedPolicy).WithMany(p => p.AgentReportedPolicies)
                .HasForeignKey(d => d.ReportedPolicyId)
                .HasConstraintName("FK_Agent_ReportedPolicy");
        });

        modelBuilder.Entity<Agent1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Agent", "Reporting");

            entity.Property(e => e.AssignedPolicyName).HasMaxLength(256);
            entity.Property(e => e.LastCheckIn).HasColumnType("datetime");
            entity.Property(e => e.PatchDataVersion).HasMaxLength(23);
        });

        modelBuilder.Entity<Agent2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Agent", "Reporting2");

            entity.Property(e => e.AssignedPolicyName).HasMaxLength(256);
            entity.Property(e => e.LastCheckIn).HasColumnType("datetime");
            entity.Property(e => e.PatchDataVersion).HasMaxLength(23);
        });

        modelBuilder.Entity<AgentAttachment>(entity =>
        {
            entity.ToTable("AgentAttachment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acknowledged).HasColumnName("acknowledged");
            entity.Property(e => e.AgentId).HasColumnName("agentId");
            entity.Property(e => e.AttachmentUid).HasColumnName("attachmentUid");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentAttachments)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentAttachment_Agent");

            entity.HasOne(d => d.AttachmentU).WithMany(p => p.AgentAttachments)
                .HasForeignKey(d => d.AttachmentUid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentAttachment_Attachment");
        });

        modelBuilder.Entity<AgentPushInstall>(entity =>
        {
            entity.ToTable("AgentPushInstall");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalProperties).HasColumnName("additionalProperties");
            entity.Property(e => e.AssignedPolicyId).HasColumnName("assignedPolicyId");
            entity.Property(e => e.Cookie).HasColumnName("cookie");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("expirationDate");
            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("lastModified");
            entity.Property(e => e.MachineId).HasColumnName("machineId");
            entity.Property(e => e.MachineName)
                .HasMaxLength(255)
                .HasColumnName("machineName");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.AssignedPolicy).WithMany(p => p.AgentPushInstalls)
                .HasForeignKey(d => d.AssignedPolicyId)
                .HasConstraintName("FK_AgentPushInstall_AssignedPolicy");

            entity.HasOne(d => d.Machine).WithMany(p => p.AgentPushInstalls)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_AgentPushInstall_Machine");
        });

        modelBuilder.Entity<AgentRegistrationLog>(entity =>
        {
            entity.ToTable("AgentRegistrationLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("agentId");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("dateTime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ipAddress");
            entity.Property(e => e.SelectedPolicyId).HasColumnName("selectedPolicyId");
            entity.Property(e => e.SelectedPolicyName)
                .HasMaxLength(255)
                .HasColumnName("selectedPolicyName");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<ApprovedPatchPart>(entity =>
        {
            entity.HasKey(e => e.PartId);

            entity.ToTable("ApprovedPatchPart");

            entity.Property(e => e.PartId)
                .ValueGeneratedNever()
                .HasColumnName("partId");
            entity.Property(e => e.DownloadWindowMinutes).HasColumnName("downloadWindowMinutes");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.PatchGroupId).HasColumnName("patchGroupId");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.PatchGroup).WithMany(p => p.ApprovedPatchParts)
                .HasForeignKey(d => d.PatchGroupId)
                .HasConstraintName("FK_ApprovedPatchPart_PatchGroup");
        });

        modelBuilder.Entity<ApprovedServicePackPart>(entity =>
        {
            entity.HasKey(e => e.PartId);

            entity.ToTable("ApprovedServicePackPart");

            entity.Property(e => e.PartId)
                .ValueGeneratedNever()
                .HasColumnName("partId");
            entity.Property(e => e.DownloadWindowMinutes).HasColumnName("downloadWindowMinutes");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.MaxServicePacksPerDay).HasColumnName("maxServicePacksPerDay");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.ServicePackGroupId).HasColumnName("servicePackGroupId");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.ServicePackGroup).WithMany(p => p.ApprovedServicePackParts)
                .HasForeignKey(d => d.ServicePackGroupId)
                .HasConstraintName("FK_ApprovedServicePackPart_ServicePackGroup");
        });

        modelBuilder.Entity<Architecture>(entity =>
        {
            entity.ToTable("Architecture");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<Architecture1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Architecture", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<AssessedMachineState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AssessedMachineState", "Reporting");

            entity.Property(e => e.AssessedOn).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(45)
                .HasColumnName("IPAddress");
        });

        modelBuilder.Entity<AssessedMachineState1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AssessedMachineState", "Reporting2");

            entity.Property(e => e.AssessedOn).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(45)
                .HasColumnName("IPAddress");
        });

        modelBuilder.Entity<AssetDefinition>(entity =>
        {
            entity.ToTable("AssetDefinition");

            entity.HasIndex(e => new {e.Class, e.Name, e.Type}, "UK_AssetDefinition_classNameType").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(100)
                .HasColumnName("class");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OrderIndex).HasColumnName("orderIndex");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<AssetScanTemplate>(entity =>
        {
            entity.HasIndex(e => e.Name, "UK_AssetScanTemplates_name").IsUnique();

            entity.HasIndex(e => e.PartId, "UK_AssetScanTemplates_partId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatorName)
                .HasMaxLength(256)
                .HasColumnName("creatorName");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.HardwareScan).HasColumnName("hardwareScan");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.ScanAllHardware).HasColumnName("scanAllHardware");
            entity.Property(e => e.SoftwareScan).HasColumnName("softwareScan");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<AssetScanTemplateCategory>(entity =>
        {
            entity.ToTable("AssetScanTemplateCategory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetCategoryId).HasColumnName("assetCategoryId");
            entity.Property(e => e.AssetScanTemplateId).HasColumnName("assetScanTemplateId");

            entity.HasOne(d => d.AssetScanTemplate).WithMany(p => p.AssetScanTemplateCategories)
                .HasForeignKey(d => d.AssetScanTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetScanTemplateCategory_AssetScanTemplates");
        });

        modelBuilder.Entity<AssetValue>(entity =>
        {
            entity.ToTable("AssetValue");

            entity.HasIndex(e => e.AssetValueCommonId, "IX_AssetValue_assetValueCommonId");

            entity.HasIndex(e => e.ScanMachineId, "IX_AssetValue_scanMachineId");

            entity.HasIndex(e => new {e.ScanMachineId, e.AssetDefinitionId, e.Instance},
                "UK_AssetValue_scanMachineIdAssetDefinitionIdInstance").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetDefinitionId).HasColumnName("assetDefinitionId");
            entity.Property(e => e.AssetValueCommonId).HasColumnName("assetValueCommonId");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.ScanMachineId).HasColumnName("scanMachineId");
            entity.Property(e => e.Value)
                .HasColumnType("sql_variant")
                .HasColumnName("value");

            entity.HasOne(d => d.AssetDefinition).WithMany(p => p.AssetValues)
                .HasForeignKey(d => d.AssetDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetValue_AssetDefinition");

            entity.HasOne(d => d.AssetValueCommon).WithMany(p => p.AssetValues)
                .HasForeignKey(d => d.AssetValueCommonId)
                .HasConstraintName("FK_AssetValue_AssetValueCommon");

            entity.HasOne(d => d.ScanMachine).WithMany(p => p.AssetValues)
                .HasForeignKey(d => d.ScanMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetValue_ScanMachines");
        });

        modelBuilder.Entity<AssetValueCommon>(entity =>
        {
            entity.ToTable("AssetValueCommon");

            entity.HasIndex(e => e.ValueHash, "IX_AssetValueCommon_valueHash");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.ValueHash)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("valueHash");
        });

        modelBuilder.Entity<AssetValueList>(entity =>
        {
            entity.HasKey(e => new {e.AssetValueId, e.Ordinal});

            entity.ToTable("AssetValueList");

            entity.Property(e => e.AssetValueId).HasColumnName("assetValueId");
            entity.Property(e => e.Ordinal).HasColumnName("ordinal");
            entity.Property(e => e.Value)
                .HasColumnType("sql_variant")
                .HasColumnName("value");

            entity.HasOne(d => d.AssetValue).WithMany(p => p.AssetValueLists)
                .HasForeignKey(d => d.AssetValueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetValueList_AssetValue");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Uid).IsClustered(false);

            entity.ToTable("Attachment");

            entity.HasIndex(e => e.Id, "UK_Attachment_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.AttachmentBlob).HasColumnName("attachmentBlob");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Bulletin>(entity =>
        {
            entity.ToTable("Bulletin", "Virtual");

            entity.HasIndex(e => e.BulletinId, "UK_Bulletin_BulletinId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BulletinId)
                .HasMaxLength(255)
                .HasColumnName("bulletinId");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.KbUrl)
                .HasMaxLength(4000)
                .HasColumnName("kbUrl");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("datetime")
                .HasColumnName("releaseDate");
            entity.Property(e => e.ReleaseType).HasColumnName("releaseType");
            entity.Property(e => e.ReplacedBy)
                .HasMaxLength(255)
                .HasColumnName("replacedBy");
            entity.Property(e => e.Severity).HasColumnName("severity");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Urgency).HasColumnName("urgency");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<BulletinDeployment>(entity =>
        {
            entity.HasKey(e => new {e.HypervisorId, e.BulletinId});

            entity.ToTable("BulletinDeployment", "Virtual");

            entity.Property(e => e.HypervisorId).HasColumnName("hypervisorId");
            entity.Property(e => e.BulletinId).HasColumnName("bulletinId");
            entity.Property(e => e.InstallDate)
                .HasColumnType("datetime")
                .HasColumnName("installDate");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");

            entity.HasOne(d => d.Bulletin).WithMany(p => p.BulletinDeployments)
                .HasForeignKey(d => d.BulletinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BulletinDeployment_Bulletin");

            entity.HasOne(d => d.Hypervisor).WithMany(p => p.BulletinDeployments)
                .HasForeignKey(d => d.HypervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BulletinDeployment_Hypervisor");
        });

        modelBuilder.Entity<Bundle>(entity =>
        {
            entity.ToTable("Bundle", "Virtual");

            entity.HasIndex(e => e.BundleId, "UK_Bundle_BundleId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BundleId)
                .HasMaxLength(255)
                .HasColumnName("bundleId");
            entity.Property(e => e.BundleVersion)
                .HasMaxLength(50)
                .HasColumnName("bundleVersion");
            entity.Property(e => e.HostDaemonRestart).HasColumnName("hostDaemonRestart");
            entity.Property(e => e.MaintenanceMode).HasColumnName("maintenanceMode");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Platform)
                .HasMaxLength(255)
                .HasColumnName("platform");
            entity.Property(e => e.RebootRequired).HasColumnName("rebootRequired");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Url)
                .HasMaxLength(4000)
                .HasColumnName("url");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<ConsoleConfiguration>(entity =>
        {
            entity.ToTable("ConsoleConfiguration");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CentOsxmlVersion)
                .HasMaxLength(23)
                .HasColumnName("centOSXmlVersion");
            entity.Property(e => e.CreateAdminShare).HasColumnName("createAdminShare");
            entity.Property(e => e.DbVersion)
                .HasMaxLength(23)
                .HasColumnName("dbVersion");
            entity.Property(e => e.DeploymentValidationKey)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("deploymentValidationKey");
            entity.Property(e => e.LicenseThumbprint)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("licenseThumbprint");
            entity.Property(e => e.RedHatXmlVersion)
                .HasMaxLength(23)
                .HasColumnName("redHatXmlVersion");
            entity.Property(e => e.SchedulerLifetime).HasColumnName("schedulerLifetime");
            entity.Property(e => e.SchedulerPort).HasColumnName("schedulerPort");
            entity.Property(e => e.SchedulerType).HasColumnName("schedulerType");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
            entity.Property(e => e.XmlVersion)
                .HasMaxLength(23)
                .HasColumnName("xmlVersion");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ConsoleConfiguration)
                .HasPrincipalKey<ConsoleIdentity>(p => p.ConsoleUid)
                .HasForeignKey<ConsoleConfiguration>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsoleConfiguration_ConsoleIdentity");
        });

        modelBuilder.Entity<ConsoleIdentity>(entity =>
        {
            entity.HasKey(e => e.ConsoleId);

            entity.ToTable("ConsoleIdentity");

            entity.HasIndex(e => e.ConsoleUid, "UK_ConsoleIdentity_consoleUID").IsUnique();

            entity.Property(e => e.ConsoleId).HasColumnName("consoleID");
            entity.Property(e => e.ConsoleDesc)
                .HasMaxLength(4000)
                .HasColumnName("consoleDesc");
            entity.Property(e => e.ConsoleName)
                .HasMaxLength(100)
                .HasColumnName("consoleName");
            entity.Property(e => e.ConsoleUid).HasColumnName("consoleUID");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<Credential>(entity =>
        {
            entity.HasKey(e => e.Uid).IsClustered(false);

            entity.ToTable("Credential");

            entity.HasIndex(e => e.Id, "UK_Credential_Id")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new {e.Name, e.OwnerMachineSid}, "UK_Credential_NameOwnerMachineSid").IsUnique();

            entity.Property(e => e.Uid).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OwnerMachineSid).HasMaxLength(68);
            entity.Property(e => e.OwnerSid).HasMaxLength(68);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<CredentialAccess>(entity =>
        {
            entity.HasKey(e => new {e.CredentialId, e.SubjectKeyIdentifier});

            entity.ToTable("CredentialAccess");

            entity.Property(e => e.SubjectKeyIdentifier)
                .HasMaxLength(20)
                .IsFixedLength();

            entity.HasOne(d => d.Credential).WithMany(p => p.CredentialAccesses)
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(d => d.CredentialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CredentialAccess_Credential");
        });

        modelBuilder.Entity<CustomAction>(entity =>
        {
            entity.HasKey(e => e.CaActionId);

            entity.ToTable("CustomAction");

            entity.HasIndex(e => e.CaDeployTemplateId, "IX_CustomAction_caDeployTemplateID");

            entity.Property(e => e.CaActionId).HasColumnName("caActionID");
            entity.Property(e => e.CaActionType).HasColumnName("caActionType");
            entity.Property(e => e.CaCommand)
                .HasMaxLength(255)
                .HasColumnName("caCommand");
            entity.Property(e => e.CaDeployTemplateId).HasColumnName("caDeployTemplateID");
            entity.Property(e => e.CaSfn)
                .HasMaxLength(255)
                .HasColumnName("caSFN");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasOne(d => d.CaDeployTemplate).WithMany(p => p.CustomActions)
                .HasForeignKey(d => d.CaDeployTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomAction_DeployTemplates");
        });

        modelBuilder.Entity<Cve>(entity =>
        {
            entity.ToTable("Cve");

            entity.HasIndex(e => e.CveId, "UK_Cve_cveId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CveId)
                .HasMaxLength(20)
                .HasColumnName("cveId");
            entity.Property(e => e.CvssV2)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("cvssV2");
            entity.Property(e => e.CvssV3)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("cvssV3");
            entity.Property(e => e.ExploitabilityIndexId).HasColumnName("exploitabilityIndexId");
            entity.Property(e => e.LastRevisedOn)
                .HasColumnType("datetime")
                .HasColumnName("lastRevisedOn");
        });

        modelBuilder.Entity<Cve1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cve", "Reporting");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<Cve2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cve", "Reporting2");

            entity.Property(e => e.Cvssv2)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("CVSSv2");
            entity.Property(e => e.Cvssv3)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("CVSSv3");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<DeployState>(entity =>
        {
            entity.ToTable("DeployState");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<DeployState1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DeployState", "Reporting");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<DeployState2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DeployState", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<DeployTemplate>(entity =>
        {
            entity.HasKey(e => e.DeploytId);

            entity.HasIndex(e => e.DeploytDefaultRelayId, "IX_DeployTemplates_deploytDefaultRelayID");

            entity.HasIndex(e => e.DeploytName, "UK_DeployTemplates_deploytName").IsUnique();

            entity.Property(e => e.DeploytId).HasColumnName("deploytID");
            entity.Property(e => e.DeploytCreatorName)
                .HasMaxLength(256)
                .HasColumnName("deploytCreatorName");
            entity.Property(e => e.DeploytDefaultRelayId).HasColumnName("deploytDefaultRelayID");
            entity.Property(e => e.DeploytDescription)
                .HasMaxLength(255)
                .HasColumnName("deploytDescription");
            entity.Property(e => e.DeploytDialogDescription)
                .HasMaxLength(100)
                .HasColumnName("deploytDialogDescription");
            entity.Property(e => e.DeploytDialogTitle)
                .HasMaxLength(20)
                .HasColumnName("deploytDialogTitle");
            entity.Property(e => e.DeploytName)
                .HasMaxLength(255)
                .HasColumnName("deploytName");
            entity.Property(e => e.DeploytPptmessages).HasColumnName("deploytPPTMessages");
            entity.Property(e => e.DeploytRebootAfterDlgSeconds).HasColumnName("deploytRebootAfterDlgSeconds");
            entity.Property(e => e.DeploytRebootAfterEarliestTime)
                .HasColumnType("datetime")
                .HasColumnName("deploytRebootAfterEarliestTime");
            entity.Property(e => e.DeploytRebootAfterExtendMinutes).HasColumnName("deploytRebootAfterExtendMinutes");
            entity.Property(e => e.DeploytRebootAfterInitialMinutes).HasColumnName("deploytRebootAfterInitialMinutes");
            entity.Property(e => e.DeploytRebootAfterLatestTime)
                .HasColumnType("datetime")
                .HasColumnName("deploytRebootAfterLatestTime");
            entity.Property(e => e.DeploytRebootAfterMaxMinutes).HasColumnName("deploytRebootAfterMaxMinutes");
            entity.Property(e => e.DeploytRebootAfterSafeOptions).HasColumnName("deploytRebootAfterSafeOptions");
            entity.Property(e => e.DeploytRebootAfterWhen).HasColumnName("deploytRebootAfterWhen");
            entity.Property(e => e.DeploytRebootBeforeDlgSeconds).HasColumnName("deploytRebootBeforeDlgSeconds");
            entity.Property(e => e.DeploytRebootBeforeExtendMinutes).HasColumnName("deploytRebootBeforeExtendMinutes");
            entity.Property(e => e.DeploytRebootBeforeInitialMinutes).HasColumnName("deploytRebootBeforeInitialMinutes");
            entity.Property(e => e.DeploytRebootBeforeLatestTime)
                .HasColumnType("datetime")
                .HasColumnName("deploytRebootBeforeLatestTime");
            entity.Property(e => e.DeploytRebootBeforeMaxMinutes).HasColumnName("deploytRebootBeforeMaxMinutes");
            entity.Property(e => e.DeploytRebootBeforeSafeOptions).HasColumnName("deploytRebootBeforeSafeOptions");
            entity.Property(e => e.DeploytRebootBeforeWhen).HasColumnName("deploytRebootBeforeWhen");
            entity.Property(e => e.DeploytRelayErrorRetry).HasColumnName("deploytRelayErrorRetry");
            entity.Property(e => e.DeploytRemoveTempFiles).HasColumnName("deploytRemoveTempFiles");
            entity.Property(e => e.DeploytRssstartupMinutes).HasColumnName("deploytRSSStartupMinutes");
            entity.Property(e => e.DeploytRsstaggerStarts).HasColumnName("deploytRSStaggerStarts");
            entity.Property(e => e.DeploytShowDialog).HasColumnName("deploytShowDialog");
            entity.Property(e => e.DeploytShutdownExchange).HasColumnName("deploytShutdownExchange");
            entity.Property(e => e.DeploytShutdownIis).HasColumnName("deploytShutdownIIS");
            entity.Property(e => e.DeploytShutdownSql).HasColumnName("deploytShutdownSQL");
            entity.Property(e => e.DeploytSystem).HasColumnName("deploytSystem");
            entity.Property(e => e.DeploytTimeTillEmailNotify).HasColumnName("deploytTimeTillEmailNotify");
            entity.Property(e => e.DeploytUseDefaultRs).HasColumnName("deploytUseDefaultRS");
            entity.Property(e => e.DeploytUseRelayServers).HasColumnName("deploytUseRelayServers");
            entity.Property(e => e.DeploytUseVendorSite).HasColumnName("deploytUseVendorSite");
            entity.Property(e => e.MaxSnapshotCount).HasColumnName("maxSnapshotCount");
            entity.Property(e => e.OldestSnapshotInDays).HasColumnName("oldestSnapshotInDays");
            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .HasColumnName("path");
            entity.Property(e => e.TakePostDeploymentSnapshot).HasColumnName("takePostDeploymentSnapshot");
            entity.Property(e => e.TakePreDeploymentSnapshot).HasColumnName("takePreDeploymentSnapshot");
            entity.Property(e => e.TargetPowerState).HasColumnName("targetPowerState");
            entity.Property(e => e.UseDistributionServerByIprange).HasColumnName("useDistributionServerByIPRange");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasOne(d => d.DeploytDefaultRelay).WithMany(p => p.DeployTemplates)
                .HasForeignKey(d => d.DeploytDefaultRelayId)
                .HasConstraintName("FK_DeployTemplates_RelayServer");
        });

        modelBuilder.Entity<DeploymentSeat>(entity =>
        {
            entity.ToTable("DeploymentSeat");

            entity.HasIndex(e => new {e.Name, e.Type, e.LicenseThumbprint}, "UK_DeploymentSeat_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LicenseThumbprint)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("licenseThumbprint");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.ValidationKey)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("validationKey");
        });

        modelBuilder.Entity<DetectedBulletin>(entity =>
        {
            entity.ToTable("DetectedBulletin", "Virtual");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BulletinId).HasColumnName("bulletinId");
            entity.Property(e => e.HypervisorResultId).HasColumnName("hypervisorResultId");
            entity.Property(e => e.IsInstalled).HasColumnName("isInstalled");
            entity.Property(e => e.IsReplaced).HasColumnName("isReplaced");

            entity.HasOne(d => d.Bulletin).WithMany(p => p.DetectedBulletins)
                .HasForeignKey(d => d.BulletinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedBulletin_BulletinId");

            entity.HasOne(d => d.HypervisorResult).WithMany(p => p.DetectedBulletins)
                .HasForeignKey(d => d.HypervisorResultId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedBulletin_HypervisorResultId");
        });

        modelBuilder.Entity<DetectedBundle>(entity =>
        {
            entity.ToTable("DetectedBundle", "Virtual");

            entity.HasIndex(e => new {e.Name, e.DetectedBulletinId}, "UK_DetectedBundle_NameDetectedBulletinId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DetectedBulletinId).HasColumnName("detectedBulletinId");
            entity.Property(e => e.InstalledBundleId).HasColumnName("installedBundleId");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NewestBundleId).HasColumnName("newestBundleId");
            entity.Property(e => e.RequiredBundleId).HasColumnName("requiredBundleId");
            entity.Property(e => e.RequiredBundleState).HasColumnName("requiredBundleState");

            entity.HasOne(d => d.DetectedBulletin).WithMany(p => p.DetectedBundles)
                .HasForeignKey(d => d.DetectedBulletinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedBundle_DetectedBulletinId");

            entity.HasOne(d => d.InstalledBundle).WithMany(p => p.DetectedBundleInstalledBundles)
                .HasForeignKey(d => d.InstalledBundleId)
                .HasConstraintName("FK_DetectedBundle_InstalledBundleId");

            entity.HasOne(d => d.NewestBundle).WithMany(p => p.DetectedBundleNewestBundles)
                .HasForeignKey(d => d.NewestBundleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedBundle_NewestBundleId");

            entity.HasOne(d => d.RequiredBundle).WithMany(p => p.DetectedBundleRequiredBundles)
                .HasForeignKey(d => d.RequiredBundleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedBundle_RequiredBundleId");
        });

        modelBuilder.Entity<DetectedPatch>(entity =>
        {
            entity.ToTable("DetectedPatch", "Nix");

            entity.HasIndex(e => new {e.ScanMachineId, e.PatchId}, "IX_DetectedPatch_ScanMachineIdPatchId");

            entity.HasOne(d => d.ScanMachine).WithMany(p => p.DetectedPatches)
                .HasForeignKey(d => d.ScanMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedPatch_ScanMachines");
        });

        modelBuilder.Entity<DetectedPatchState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DetectedPatchState", "Reporting");

            entity.Property(e => e.InstalledOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DetectedPatchState1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DetectedPatchState", "Reporting2");

            entity.Property(e => e.InstalledOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DetectedSoftwareAsset>(entity =>
        {
            entity.ToTable("DetectedSoftwareAsset");

            entity.HasIndex(e => e.ScanMachineId, "IX_DetectedSoftwareAsset_scanMachineId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstimatedSize).HasColumnName("estimatedSize");
            entity.Property(e => e.InstallDate)
                .HasColumnType("datetime")
                .HasColumnName("installDate");
            entity.Property(e => e.LanguageId).HasColumnName("languageId");
            entity.Property(e => e.ScanMachineId).HasColumnName("scanMachineId");
            entity.Property(e => e.SoftwareTitleId).HasColumnName("softwareTitleId");

            entity.HasOne(d => d.ScanMachine).WithMany(p => p.DetectedSoftwareAssets)
                .HasForeignKey(d => d.ScanMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedSoftwareAsset_ScanMachines");

            entity.HasOne(d => d.SoftwareTitle).WithMany(p => p.DetectedSoftwareAssets)
                .HasForeignKey(d => d.SoftwareTitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetectedSoftwareAsset_SoftwareTitle");
        });

        modelBuilder.Entity<DirectoryServer>(entity =>
        {
            entity.ToTable("DirectoryServer");

            entity.HasIndex(e => e.Name, "UK_DirectoryServer_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DiscoveryFilter>(entity =>
        {
            entity.ToTable("DiscoveryFilter");

            entity.HasIndex(e => e.DiscoveryGroupId, "IX_DiscoveryFilter_DiscoveryGroupId");

            entity.HasIndex(e => new {e.Name, e.Type, e.DiscoveryGroupId, e.ChildDiscoveryGroupId},
                "UK_DiscoveryFilter_NameTypeDiscoveryGroupIdChildDiscoveryGroupId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildDiscoveryGroupId).HasColumnName("childDiscoveryGroupId");
            entity.Property(e => e.DiscoveryGroupId).HasColumnName("discoveryGroupId");
            entity.Property(e => e.IncludeChildOu).HasColumnName("includeChildOU");
            entity.Property(e => e.IsExcluded).HasColumnName("isExcluded");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .HasColumnName("note");
            entity.Property(e => e.SshAuthenticationMethod).HasColumnName("sshAuthenticationMethod");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
            entity.Property(e => e.WebServicesPort).HasColumnName("webServicesPort");

            entity.HasOne(d => d.ChildDiscoveryGroup).WithMany(p => p.DiscoveryFilterChildDiscoveryGroups)
                .HasForeignKey(d => d.ChildDiscoveryGroupId)
                .HasConstraintName("FK_DiscoveryFilter_ChildManagedGroups");

            entity.HasOne(d => d.DiscoveryGroup).WithMany(p => p.DiscoveryFilterDiscoveryGroups)
                .HasForeignKey(d => d.DiscoveryGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscoveryFilter_ManagedGroups");
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.ToTable("Distribution", "Nix");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<DownloadFileLocation>(entity =>
        {
            entity.HasKey(e => e.DflId);

            entity.ToTable("DownloadFileLocation");

            entity.Property(e => e.DflId).HasColumnName("dflID");
            entity.Property(e => e.DflCustomLocation)
                .HasMaxLength(4000)
                .HasColumnName("dflCustomLocation");
            entity.Property(e => e.DflDistServerId).HasColumnName("dflDistServerID");
            entity.Property(e => e.DflFileType).HasColumnName("dflFileType");
            entity.Property(e => e.DflLocationEnum).HasColumnName("dflLocationEnum");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<EmailGroup>(entity =>
        {
            entity.HasKey(e => e.EmailgrpId);

            entity.ToTable("EmailGroup");

            entity.HasIndex(e => new {e.EmailgrpEmailrecGrpId, e.EmailgrpEmailrecId},
                "UK_EmailGroup_EmailgrpEmailrecGrpIDEmailgrpEmailrecID").IsUnique();

            entity.Property(e => e.EmailgrpId).HasColumnName("emailgrpID");
            entity.Property(e => e.EmailgrpEmailrecGrpId).HasColumnName("emailgrpEmailrecGrpID");
            entity.Property(e => e.EmailgrpEmailrecId).HasColumnName("emailgrpEmailrecID");

            entity.HasOne(d => d.EmailgrpEmailrecGrp).WithMany(p => p.EmailGroupEmailgrpEmailrecGrps)
                .HasForeignKey(d => d.EmailgrpEmailrecGrpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailGroup_EmailRecipientGroup");

            entity.HasOne(d => d.EmailgrpEmailrec).WithMany(p => p.EmailGroupEmailgrpEmailrecs)
                .HasForeignKey(d => d.EmailgrpEmailrecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailGroup_EmailRecipient");
        });

        modelBuilder.Entity<EmailRecipient>(entity =>
        {
            entity.HasKey(e => e.EmailrecId);

            entity.ToTable("EmailRecipient");

            entity.HasIndex(e => e.EmailrecName, "UK_EmailRecipient_emailrecName").IsUnique();

            entity.Property(e => e.EmailrecId).HasColumnName("emailrecID");
            entity.Property(e => e.EmailrecAddress)
                .HasMaxLength(255)
                .HasColumnName("emailrecAddress");
            entity.Property(e => e.EmailrecIsGroup).HasColumnName("emailrecIsGroup");
            entity.Property(e => e.EmailrecIsHfadmin).HasColumnName("emailrecIsHFAdmin");
            entity.Property(e => e.EmailrecName)
                .HasMaxLength(100)
                .HasColumnName("emailrecName");
            entity.Property(e => e.EmailrecReserved).HasColumnName("emailrecReserved");
        });

        modelBuilder.Entity<EventViewerView>(entity =>
        {
            entity.ToTable("EventViewerView", "ApplicationControl");

            entity.HasIndex(e => e.Name, "UK_EventViewerView_Name").IsUnique();

            entity.Property(e => e.MachineName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(255);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.FavKey);

            entity.HasIndex(e => e.FavName, "UK_Favorites_favName").IsUnique();

            entity.Property(e => e.FavKey).HasColumnName("favKey");
            entity.Property(e => e.FavCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("favCreateDate");
            entity.Property(e => e.FavCreatorName)
                .HasMaxLength(256)
                .HasColumnName("favCreatorName");
            entity.Property(e => e.FavDescription)
                .HasMaxLength(4000)
                .HasColumnName("favDescription");
            entity.Property(e => e.FavName)
                .HasMaxLength(255)
                .HasColumnName("favName");
            entity.Property(e => e.FavTemp).HasColumnName("favTemp");
            entity.Property(e => e.FavType).HasColumnName("favType");
            entity.Property(e => e.FavUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("favUpdateDate");
            entity.Property(e => e.TemplateId).HasColumnName("templateId");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<HostedVirtualSystem>(entity =>
        {
            entity.ToTable("HostedVirtualSystem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InventoryPath)
                .HasMaxLength(1024)
                .HasColumnName("inventoryPath");
            entity.Property(e => e.IsTemplate).HasColumnName("isTemplate");
            entity.Property(e => e.ManagedListId).HasColumnName("managedListId");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .HasColumnName("note");
            entity.Property(e => e.ServerName)
                .HasMaxLength(1024)
                .HasColumnName("serverName");
            entity.Property(e => e.Uuid)
                .HasMaxLength(64)
                .HasColumnName("uuid");
            entity.Property(e => e.VmxPath).HasColumnName("vmxPath");

            entity.HasOne(d => d.ManagedList).WithMany(p => p.HostedVirtualSystems)
                .HasForeignKey(d => d.ManagedListId)
                .HasConstraintName("FK_HostedVirtualSystem_DiscoveryFilter");
        });

        modelBuilder.Entity<Hypervisor>(entity =>
        {
            entity.ToTable("Hypervisor", "Virtual");

            entity.HasIndex(e => new {e.Name, e.VCenterServerId}, "UK_Hypervisor_nameVCenterServerId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertificateThumbprint)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("certificateThumbprint");
            entity.Property(e => e.CpuCount).HasColumnName("cpuCount");
            entity.Property(e => e.HostSystemName)
                .HasMaxLength(256)
                .HasColumnName("hostSystemName");
            entity.Property(e => e.HypervisorVersion)
                .HasMaxLength(50)
                .HasColumnName("hypervisorVersion");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ipAddress");
            entity.Property(e => e.IsInMaintenanceMode).HasColumnName("isInMaintenanceMode");
            entity.Property(e => e.MemoryMb).HasColumnName("memoryMB");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.ProcessorSpeed).HasColumnName("processorSpeed");
            entity.Property(e => e.TotalDiskSpace).HasColumnName("totalDiskSpace");
            entity.Property(e => e.VCenterServerId).HasColumnName("vCenterServerId");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasOne(d => d.VCenterServer).WithMany(p => p.Hypervisors)
                .HasForeignKey(d => d.VCenterServerId)
                .HasConstraintName("FK_Hypervisor_vCenterServerId");
        });

        modelBuilder.Entity<HypervisorResult>(entity =>
        {
            entity.ToTable("HypervisorResult", "Virtual");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ErrorMessage).HasColumnName("errorMessage");
            entity.Property(e => e.HypervisorId).HasColumnName("hypervisorId");
            entity.Property(e => e.MetadataDate)
                .HasColumnType("datetime")
                .HasColumnName("metadataDate");
            entity.Property(e => e.ResultStatus).HasColumnName("resultStatus");
            entity.Property(e => e.ScanDate)
                .HasColumnType("datetime")
                .HasColumnName("scanDate");

            entity.HasOne(d => d.Hypervisor).WithMany(p => p.HypervisorResults)
                .HasForeignKey(d => d.HypervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HypervisorResult_HypervisorId");
        });

        modelBuilder.Entity<InstallState>(entity =>
        {
            entity.ToTable("InstallState");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<InstallState1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InstallState", "Reporting");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<InstallState2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InstallState", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinkDeploymentScanItem>(entity =>
        {
            entity.HasKey(e => e.DsilId);

            entity.HasIndex(e => e.DsilStatusTime, "IX_LinkDeploymentScanItems_dsilStatusTime");

            entity.HasIndex(e => e.DsilitemId, "IX_LinkDeploymentScanItems_dsilitemID");

            entity.HasIndex(e => e.DsilpdId, "IX_LinkDeploymentScanItems_dsilpdID");

            entity.Property(e => e.DsilId).HasColumnName("dsilID");
            entity.Property(e => e.DsilDeployStatus).HasColumnName("dsilDeployStatus");
            entity.Property(e => e.DsilScheduledTime)
                .HasColumnType("datetime")
                .HasColumnName("dsilScheduledTime");
            entity.Property(e => e.DsilSpdeployed).HasColumnName("dsilSPDeployed");
            entity.Property(e => e.DsilStatusTime)
                .HasColumnType("datetime")
                .HasColumnName("dsilStatusTime");
            entity.Property(e => e.DsilTargetPath)
                .HasMaxLength(4000)
                .HasColumnName("dsilTargetPath");
            entity.Property(e => e.DsilitemId).HasColumnName("dsilitemID");
            entity.Property(e => e.DsilpdId).HasColumnName("dsilpdID");
            entity.Property(e => e.InstallEnd)
                .HasColumnType("datetime")
                .HasColumnName("installEnd");
            entity.Property(e => e.InstallStart)
                .HasColumnType("datetime")
                .HasColumnName("installStart");
            entity.Property(e => e.NativeCode).HasColumnName("nativeCode");
            entity.Property(e => e.OverallState).HasColumnName("overallState");
            entity.Property(e => e.Sequence).HasColumnName("sequence");

            entity.HasOne(d => d.DsilSpdeployedNavigation).WithMany(p => p.LinkDeploymentScanItems)
                .HasForeignKey(d => d.DsilSpdeployed)
                .HasConstraintName("FK_LinkDeploymentScanItems_LinkPatchProduct");

            entity.HasOne(d => d.Dsilitem).WithMany(p => p.LinkDeploymentScanItems)
                .HasForeignKey(d => d.DsilitemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkDeploymentScanItems_ScanItems");

            entity.HasOne(d => d.Dsilpd).WithMany(p => p.LinkDeploymentScanItems)
                .HasForeignKey(d => d.DsilpdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkDeploymentScanItems_PatchDeployments");
        });

        modelBuilder.Entity<LinkEmailRecDeploymentTemplate>(entity =>
        {
            entity.HasKey(e => e.ErecDtId);

            entity.HasIndex(e => e.ErecDtDeploytId, "IX_LinkEmailRecDeploymentTemplates_erecDtDeploytID");

            entity.Property(e => e.ErecDtId).HasColumnName("erecDtID");
            entity.Property(e => e.ErecDtDeploytId).HasColumnName("erecDtDeploytID");
            entity.Property(e => e.ErecDtReport).HasColumnName("erecDtReport");
            entity.Property(e => e.ErecDtemailrecId).HasColumnName("erecDtemailrecID");

            entity.HasOne(d => d.ErecDtDeployt).WithMany(p => p.LinkEmailRecDeploymentTemplates)
                .HasForeignKey(d => d.ErecDtDeploytId)
                .HasConstraintName("FK_LinkEmailRecDeploymentTemplates_DeployTemplates");

            entity.HasOne(d => d.ErecDtemailrec).WithMany(p => p.LinkEmailRecDeploymentTemplates)
                .HasForeignKey(d => d.ErecDtemailrecId)
                .HasConstraintName("FK_LinkEmailRecDeploymentTemplates_EmailRecipient");
        });

        modelBuilder.Entity<LinkEmailRecMachineAnnotation>(entity =>
        {
            entity.HasKey(e => e.ErecMaid);

            entity.HasIndex(e => e.ErecMaemailrecId, "IX_LinkEmailRecMachineAnnotations_erecMAemailrecID");

            entity.HasIndex(e => e.ErecMammachId, "IX_LinkEmailRecMachineAnnotations_erecMAmmachID");

            entity.Property(e => e.ErecMaid).HasColumnName("erecMAID");
            entity.Property(e => e.EmoMaadministrator).HasColumnName("emoMAadministrator");
            entity.Property(e => e.EmoMaowner).HasColumnName("emoMAowner");
            entity.Property(e => e.ErecMaemailrecId).HasColumnName("erecMAemailrecID");
            entity.Property(e => e.ErecMammachId).HasColumnName("erecMAmmachID");

            entity.HasOne(d => d.ErecMaemailrec).WithMany(p => p.LinkEmailRecMachineAnnotations)
                .HasForeignKey(d => d.ErecMaemailrecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkEmailRecMachineAnnotations_EmailRecipient");

            entity.HasOne(d => d.ErecMammach).WithMany(p => p.LinkEmailRecMachineAnnotations)
                .HasForeignKey(d => d.ErecMammachId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkEmailRecMachineAnnotations_ManagedMachines");
        });

        modelBuilder.Entity<LinkEmailRecManagedGroup>(entity =>
        {
            entity.HasKey(e => e.ErecMgid);

            entity.HasIndex(e => e.ErecMgemailrecId, "IX_LinkEmailRecManagedGroups_erecMGemailrecID");

            entity.HasIndex(e => e.ErecMgmgId, "IX_LinkEmailRecManagedGroups_erecMGmgID");

            entity.Property(e => e.ErecMgid).HasColumnName("erecMGID");
            entity.Property(e => e.ErecMgemailrecId).HasColumnName("erecMGemailrecID");
            entity.Property(e => e.ErecMgmgId).HasColumnName("erecMGmgID");
            entity.Property(e => e.ErecMgreport).HasColumnName("erecMGReport");

            entity.HasOne(d => d.ErecMgemailrec).WithMany(p => p.LinkEmailRecManagedGroups)
                .HasForeignKey(d => d.ErecMgemailrecId)
                .HasConstraintName("FK_LinkEmailRecManagedGroups_EmailRecipient");

            entity.HasOne(d => d.ErecMgmg).WithMany(p => p.LinkEmailRecManagedGroups)
                .HasForeignKey(d => d.ErecMgmgId)
                .HasConstraintName("FK_LinkEmailRecManagedGroups_ManagedGroups");
        });

        modelBuilder.Entity<LinkEmailRecManagedMachine>(entity =>
        {
            entity.HasKey(e => e.ErecmmId);

            entity.HasIndex(e => e.ErecmmMmachId, "IX_LinkEmailRecManagedMachines_erecmmMMachID");

            entity.HasIndex(e => e.ErecmmemailrecId, "IX_LinkEmailRecManagedMachines_erecmmemailrecID");

            entity.Property(e => e.ErecmmId).HasColumnName("erecmmID");
            entity.Property(e => e.ErecmmMmachId).HasColumnName("erecmmMMachID");
            entity.Property(e => e.ErecmmReport).HasColumnName("erecmmReport");
            entity.Property(e => e.ErecmmemailrecId).HasColumnName("erecmmemailrecID");

            entity.HasOne(d => d.ErecmmMmach).WithMany(p => p.LinkEmailRecManagedMachines)
                .HasForeignKey(d => d.ErecmmMmachId)
                .HasConstraintName("FK_LinkEmailRecManagedMachines_ManagedMachines");

            entity.HasOne(d => d.Erecmmemailrec).WithMany(p => p.LinkEmailRecManagedMachines)
                .HasForeignKey(d => d.ErecmmemailrecId)
                .HasConstraintName("FK_LinkEmailRecManagedMachines_EmailRecipient");
        });

        modelBuilder.Entity<LinkEmailRecScanTemplate>(entity =>
        {
            entity.HasKey(e => e.ErecStId);

            entity.ToTable("LinkEmailRecScanTemplate");

            entity.HasIndex(e => e.ErecStId, "IX_LinkEmailRecScanTemplate_erecStID");

            entity.HasIndex(e => e.ErecStemailrecId, "IX_LinkEmailRecScanTemplate_erecStemailrecID");

            entity.Property(e => e.ErecStId).HasColumnName("erecStID");
            entity.Property(e => e.ErecStReport).HasColumnName("erecStReport");
            entity.Property(e => e.ErecStemailrecId).HasColumnName("erecStemailrecID");
            entity.Property(e => e.ErecStscantId).HasColumnName("erecStscantID");

            entity.HasOne(d => d.ErecStemailrec).WithMany(p => p.LinkEmailRecScanTemplates)
                .HasForeignKey(d => d.ErecStemailrecId)
                .HasConstraintName("FK_LinkEmailRecScanTemplate_EmailRecipient");

            entity.HasOne(d => d.ErecStscant).WithMany(p => p.LinkEmailRecScanTemplates)
                .HasForeignKey(d => d.ErecStscantId)
                .HasConstraintName("FK_LinkEmailRecScanTemplate_ScanTemplates");
        });

        modelBuilder.Entity<LinkFavoriteGroup>(entity =>
        {
            entity.HasKey(e => e.LfgId);

            entity.HasIndex(e => e.LfgfavKey, "IX_LinkFavoriteGroups_lfgfavKey");

            entity.HasIndex(e => e.LfggrpKey, "IX_LinkFavoriteGroups_lfggrpKey");

            entity.Property(e => e.LfgId).HasColumnName("lfgID");
            entity.Property(e => e.LfgfavKey).HasColumnName("lfgfavKey");
            entity.Property(e => e.LfggrpKey).HasColumnName("lfggrpKey");

            entity.HasOne(d => d.LfgfavKeyNavigation).WithMany(p => p.LinkFavoriteGroups)
                .HasForeignKey(d => d.LfgfavKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkFavoriteGroups_Favorites");

            entity.HasOne(d => d.LfggrpKeyNavigation).WithMany(p => p.LinkFavoriteGroups)
                .HasForeignKey(d => d.LfggrpKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkFavoriteGroups_ManagedGroups");
        });

        modelBuilder.Entity<LinkPatchProduct>(entity =>
        {
            entity.HasKey(e => e.PspplId);

            entity.ToTable("LinkPatchProduct");

            entity.HasIndex(e => e.PatchUid, "IX_LinkPatchProduct_patchUid");

            entity.HasIndex(e => e.PspplpatchId, "IX_LinkPatchProduct_pspplpatchID");

            entity.HasIndex(e => new {e.PspplspplId, e.PspplpatchId, e.CatalogPatchId, e.PatchUid},
                "UK_LinkPatchProduct_productLevelIdPatchIdCatalogPatchIdPatchUid").IsUnique();

            entity.Property(e => e.PspplId).HasColumnName("pspplID");
            entity.Property(e => e.CatalogPatchId)
                .HasMaxLength(200)
                .HasColumnName("catalogPatchId");
            entity.Property(e => e.LastRevisedOn)
                .HasColumnType("datetime")
                .HasColumnName("lastRevisedOn");
            entity.Property(e => e.PatchUid).HasColumnName("patchUid");
            entity.Property(e => e.PspplAnnotation)
                .HasMaxLength(4000)
                .HasColumnName("pspplAnnotation");
            entity.Property(e => e.PspplMsseverity).HasColumnName("pspplMSSeverity");
            entity.Property(e => e.PspplShavlikComment)
                .HasMaxLength(4000)
                .HasColumnName("pspplShavlikComment");
            entity.Property(e => e.PspplpatchId).HasColumnName("pspplpatchID");
            entity.Property(e => e.PspplspplId).HasColumnName("pspplspplID");

            entity.HasOne(d => d.Pspplpatch).WithMany(p => p.LinkPatchProducts)
                .HasForeignKey(d => d.PspplpatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkPatchProduct_Patches");

            entity.HasOne(d => d.Pspplsppl).WithMany(p => p.LinkPatchProducts)
                .HasForeignKey(d => d.PspplspplId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkPatchProduct_LinkSPProduct");
        });

        modelBuilder.Entity<LinkSpproduct>(entity =>
        {
            entity.HasKey(e => e.SpplId);

            entity.ToTable("LinkSPProduct");

            entity.HasIndex(e => e.Uid, "IX_LinkSPProduct_uid");

            entity.HasIndex(e => new {e.SpplprodId, e.SpplspId}, "UK_LinkSPProduct_spplprodIDSpplspID").IsUnique();

            entity.Property(e => e.SpplId).HasColumnName("spplID");
            entity.Property(e => e.EndOfLife)
                .HasColumnType("datetime")
                .HasColumnName("endOfLife");
            entity.Property(e => e.LastRevisedOn)
                .HasColumnType("datetime")
                .HasColumnName("lastRevisedOn");
            entity.Property(e => e.SpplOrdinal).HasColumnName("spplOrdinal");
            entity.Property(e => e.SpplprodId).HasColumnName("spplprodID");
            entity.Property(e => e.SpplspId).HasColumnName("spplspID");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.Spplprod).WithMany(p => p.LinkSpproducts)
                .HasForeignKey(d => d.SpplprodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkSPProduct_Products");

            entity.HasOne(d => d.Spplsp).WithMany(p => p.LinkSpproducts)
                .HasForeignKey(d => d.SpplspId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkSPProduct_ServicePacks");
        });

        modelBuilder.Entity<LinkTemplatePatchGroup>(entity =>
        {
            entity.HasKey(e => e.TpId);

            entity.HasIndex(e => new {e.TppgrpId, e.TpscantId}, "UK_LinkTemplatePatchGroups_group").IsUnique();

            entity.Property(e => e.TpId).HasColumnName("tpID");
            entity.Property(e => e.TppgrpId).HasColumnName("tppgrpID");
            entity.Property(e => e.TpscantId).HasColumnName("tpscantID");

            entity.HasOne(d => d.Tppgrp).WithMany(p => p.LinkTemplatePatchGroups)
                .HasForeignKey(d => d.TppgrpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkTemplatePatchGroups_PatchGroup");

            entity.HasOne(d => d.Tpscant).WithMany(p => p.LinkTemplatePatchGroups)
                .HasForeignKey(d => d.TpscantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkTemplatePatchGroups_ScanTemplates");
        });

        modelBuilder.Entity<LinuxCompletionCode>(entity =>
        {
            entity.ToTable("LinuxCompletionCode", "Nix");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxCompletionCode1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxCompletionCode", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxDetectedPatchState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxDetectedPatchState", "Reporting2");
        });

        modelBuilder.Entity<LinuxDistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxDistribution", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxErrorStep>(entity =>
        {
            entity.ToTable("LinuxErrorStep", "Nix");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxErrorStep1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxErrorStep", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxInstallState>(entity =>
        {
            entity.ToTable("LinuxInstallState", "Nix");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxInstallState1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxInstallState", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxNotification", "Reporting2");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<LinuxPatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxPatch", "Reporting2");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<LinuxPatchAppliesTo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxPatchAppliesTo", "Reporting2");
        });

        modelBuilder.Entity<LinuxPatchDeployment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxPatchDeployment", "Reporting2");
        });

        modelBuilder.Entity<LinuxPatchType>(entity =>
        {
            entity.ToTable("LinuxPatchType", "Nix");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxPatchType1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxPatchType", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<LinuxPlatform>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LinuxPlatform", "Reporting2");

            entity.Property(e => e.Edition).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Machine", "Reporting");

            entity.Property(e => e.DnsName).HasMaxLength(255);
            entity.Property(e => e.Domain).HasMaxLength(255);
            entity.Property(e => e.LastKnownIp)
                .HasMaxLength(45)
                .HasColumnName("LastKnownIP");
            entity.Property(e => e.LastPatchAssessedOn).HasColumnType("datetime");
            entity.Property(e => e.LastPatchMachineGroupName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Machine1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Machine", "Reporting2");

            entity.Property(e => e.AssignedGroup).HasMaxLength(255);
            entity.Property(e => e.Distribution).HasMaxLength(100);
            entity.Property(e => e.DnsName).HasMaxLength(255);
            entity.Property(e => e.Domain).HasMaxLength(255);
            entity.Property(e => e.LastKnownIp)
                .HasMaxLength(45)
                .HasColumnName("LastKnownIP");
            entity.Property(e => e.LastPatchAssessedOn).HasColumnType("datetime");
            entity.Property(e => e.LastPatchMachineGroupName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.VirtualInventoryPath).HasMaxLength(260);
            entity.Property(e => e.VirtualServerName).HasMaxLength(256);
        });

        modelBuilder.Entity<MachineDeployment>(entity =>
        {
            entity.ToTable("MachineDeployment");

            entity.HasIndex(e => new {e.DeploymentId, e.MachineId}, "UK_MachineDeployment_deploymentIdmachineId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminPassword).HasColumnName("adminPassword");
            entity.Property(e => e.AdminUsername)
                .HasMaxLength(256)
                .HasColumnName("adminUsername");
            entity.Property(e => e.DeploymentId).HasColumnName("deploymentId");
            entity.Property(e => e.MachineId).HasColumnName("machineId");
            entity.Property(e => e.ViPassword).HasColumnName("viPassword");
            entity.Property(e => e.ViUsername)
                .HasMaxLength(256)
                .HasColumnName("viUsername");

            entity.HasOne(d => d.Deployment).WithMany(p => p.MachineDeployments)
                .HasForeignKey(d => d.DeploymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineDeployment_Deployment");

            entity.HasOne(d => d.Machine).WithMany(p => p.MachineDeployments)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineDeployment_ScanMachines");
        });

        modelBuilder.Entity<MachineDeploymentStatus>(entity =>
        {
            entity.ToTable("MachineDeploymentStatus");

            entity.HasIndex(e => new {e.MachineDeploymentId, e.Sequence}, "IX_MachineDeploymentStatus_machineDeploymentId_sequence");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MachineDeploymentId).HasColumnName("machineDeploymentId");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.NativeCode).HasColumnName("nativeCode");
            entity.Property(e => e.OverallState).HasColumnName("overallState");
            entity.Property(e => e.Sequence).HasColumnName("sequence");

            entity.HasOne(d => d.MachineDeployment).WithMany(p => p.MachineDeploymentStatuses)
                .HasForeignKey(d => d.MachineDeploymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineDeploymentStatus_MachineDeployment");
        });

        modelBuilder.Entity<MachineMeasure>(entity =>
        {
            entity.HasKey(e => e.MachineId);

            entity.Property(e => e.MachineId)
                .ValueGeneratedNever()
                .HasColumnName("machineId");
            entity.Property(e => e.AcEventsLastUploaded).HasColumnName("acEventsLastUploaded");
            entity.Property(e => e.EndOfLifeProducts).HasColumnName("endOfLifeProducts");
            entity.Property(e => e.InstalledPatches).HasColumnName("installedPatches");
            entity.Property(e => e.LastMachineGroupName)
                .HasMaxLength(255)
                .HasColumnName("lastMachineGroupName");
            entity.Property(e => e.MissingPatches).HasColumnName("missingPatches");
            entity.Property(e => e.MissingServicePacks).HasColumnName("missingServicePacks");

            entity.HasOne(d => d.Machine).WithOne(p => p.MachineMeasure)
                .HasForeignKey<MachineMeasure>(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineMeasures_ManagedMachine");
        });

        modelBuilder.Entity<ManagedGroup>(entity =>
        {
            entity.HasKey(e => e.GrpId);

            entity.HasIndex(e => e.GrpName, "UK_ManagedGroups_grpName").IsUnique();

            entity.Property(e => e.GrpId).HasColumnName("grpID");
            entity.Property(e => e.ConnectionMethod).HasColumnName("connectionMethod");
            entity.Property(e => e.GrpCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("grpCreateDate");
            entity.Property(e => e.GrpCreatorName)
                .HasMaxLength(256)
                .HasColumnName("grpCreatorName");
            entity.Property(e => e.GrpDescription)
                .HasMaxLength(255)
                .HasColumnName("grpDescription");
            entity.Property(e => e.GrpName)
                .HasMaxLength(255)
                .HasColumnName("grpName");
            entity.Property(e => e.GrpServerFilter).HasColumnName("grpServerFilter");
            entity.Property(e => e.GrpSystem).HasColumnName("grpSystem");
            entity.Property(e => e.GrpSystemGrpOrder).HasColumnName("grpSystemGrpOrder");
            entity.Property(e => e.GrpTemp).HasColumnName("grpTemp");
            entity.Property(e => e.GrpUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("grpUpdateDate");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .HasColumnName("path");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<ManagedMachine>(entity =>
        {
            entity.HasKey(e => e.MmKey);

            entity.HasIndex(e => e.LastUpdated, "IX_ManagedMachines_lastUpdated");

            entity.HasIndex(e => e.MmOsid, "IX_ManagedMachines_mmOSID");

            entity.HasIndex(e => new {e.Name, e.Domain, e.VirtualMachineId}, "UK_ManagedMachines_NameDomainVirtualMachineId").IsUnique();

            entity.Property(e => e.MmKey).HasColumnName("mmKey");
            entity.Property(e => e.AssignedGroup)
                .HasMaxLength(255)
                .HasColumnName("assignedGroup");
            entity.Property(e => e.ConnectionMethod).HasColumnName("connectionMethod");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DnsName)
                .HasMaxLength(255)
                .HasColumnName("dnsName");
            entity.Property(e => e.Domain)
                .HasMaxLength(255)
                .HasColumnName("domain");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.LastAssetInventoryScanId).HasColumnName("lastAssetInventoryScanId");
            entity.Property(e => e.LastKnownIpaddress)
                .HasMaxLength(16)
                .HasColumnName("lastKnownIPAddress");
            entity.Property(e => e.LastPatchScanId).HasColumnName("lastPatchScanId");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.MmAssetTags)
                .HasMaxLength(50)
                .HasColumnName("mmAssetTags");
            entity.Property(e => e.MmCriticality).HasColumnName("mmCriticality");
            entity.Property(e => e.MmCustom1)
                .HasMaxLength(255)
                .HasColumnName("mmCustom1");
            entity.Property(e => e.MmCustom2)
                .HasMaxLength(255)
                .HasColumnName("mmCustom2");
            entity.Property(e => e.MmCustom3)
                .HasMaxLength(255)
                .HasColumnName("mmCustom3");
            entity.Property(e => e.MmCustomer)
                .HasMaxLength(255)
                .HasColumnName("mmCustomer");
            entity.Property(e => e.MmDeploymentDrive)
                .HasMaxLength(4000)
                .HasColumnName("mmDeploymentDrive");
            entity.Property(e => e.MmDescription).HasColumnName("mmDescription");
            entity.Property(e => e.MmLocation)
                .HasMaxLength(255)
                .HasColumnName("mmLocation");
            entity.Property(e => e.MmName)
                .HasMaxLength(4000)
                .HasColumnName("mmName");
            entity.Property(e => e.MmOsid).HasColumnName("mmOSID");
            entity.Property(e => e.MmSchedulerPort).HasColumnName("mmSchedulerPort");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NixOsid).HasColumnName("nixOSId");
            entity.Property(e => e.PlatformId).HasColumnName("platformId");
            entity.Property(e => e.RdpPort).HasColumnName("rdpPort");
            entity.Property(e => e.SshAuthenticationMethod).HasColumnName("sshAuthenticationMethod");
            entity.Property(e => e.VirtualMachineId).HasColumnName("virtualMachineId");

            entity.HasOne(d => d.LastAssetInventoryScan).WithMany(p => p.ManagedMachineLastAssetInventoryScans)
                .HasForeignKey(d => d.LastAssetInventoryScanId)
                .HasConstraintName("FK_ManagedMachines_AssetScans");

            entity.HasOne(d => d.LastPatchScan).WithMany(p => p.ManagedMachineLastPatchScans)
                .HasForeignKey(d => d.LastPatchScanId)
                .HasConstraintName("FK_ManagedMachines_PatchScans");

            entity.HasOne(d => d.MmOs).WithMany(p => p.ManagedMachines)
                .HasForeignKey(d => d.MmOsid)
                .HasConstraintName("FK_ManagedMachines_LinkSPProduct");

            entity.HasOne(d => d.Platform).WithMany(p => p.ManagedMachines)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagedMachines_Platform");

            entity.HasOne(d => d.VirtualMachine).WithMany(p => p.ManagedMachines)
                .HasForeignKey(d => d.VirtualMachineId)
                .HasConstraintName("FK_ManagedMachines_VirtualMachine");
        });

        modelBuilder.Entity<NetworkInterface>(entity =>
        {
            entity.HasKey(e => new {e.ManagedMachineId, e.Id});

            entity.ToTable("NetworkInterface");

            entity.Property(e => e.ManagedMachineId).HasColumnName("managedMachineId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ipv4Address).HasColumnName("ipv4Address");
            entity.Property(e => e.Ipv4SubnetMask).HasColumnName("ipv4SubnetMask");
            entity.Property(e => e.Ipv6Address)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("ipv6Address");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("macAddress");

            entity.HasOne(d => d.ManagedMachine).WithMany(p => p.NetworkInterfaces)
                .HasForeignKey(d => d.ManagedMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NetworkInterface_ManagedMachine");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification", "Nix");

            entity.HasIndex(e => e.NotificationId, "UK_Notification_NotificationId").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<OperatingSystemFamily>(entity =>
        {
            entity.ToTable("OperatingSystemFamily");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<OperatingSystemFamily1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OperatingSystemFamily", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<OperationLog>(entity =>
        {
            entity.ToTable("OperationLog", "Services");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acknowledged).HasColumnName("acknowledged");
            entity.Property(e => e.Ended)
                .HasColumnType("datetime")
                .HasColumnName("ended");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OwnerSid)
                .HasMaxLength(68)
                .HasColumnName("ownerSid");
            entity.Property(e => e.Started)
                .HasColumnType("datetime")
                .HasColumnName("started");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<OperationLogStep>(entity =>
        {
            entity.ToTable("OperationLogStep", "Services");

            entity.HasIndex(e => e.OperationLogId, "IX_OperationLogStep_OperationLogId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ended)
                .HasColumnType("datetime")
                .HasColumnName("ended");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OperationLogId).HasColumnName("operationLogId");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Started)
                .HasColumnType("datetime")
                .HasColumnName("started");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Summary).HasColumnName("summary");

            entity.HasOne(d => d.OperationLog).WithMany(p => p.OperationLogSteps)
                .HasForeignKey(d => d.OperationLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OperationLogStep_OperationLog");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_OperationLogStep_OperationLogStep");
        });

        modelBuilder.Entity<Osdistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OSDistribution");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ProductLevel).HasMaxLength(50);
        });

        modelBuilder.Entity<Patch>(entity =>
        {
            entity.HasIndex(e => new {e.PatchQnumbers, e.PatchBulletinId, e.PatchLevel}, "UK_Patches_patchQNumbers").IsUnique();

            entity.Property(e => e.PatchId).HasColumnName("patchID");
            entity.Property(e => e.IavaId)
                .HasMaxLength(50)
                .HasColumnName("iavaId");
            entity.Property(e => e.PatchBulletinDate)
                .HasColumnType("datetime")
                .HasColumnName("patchBulletinDate");
            entity.Property(e => e.PatchBulletinId)
                .HasMaxLength(255)
                .HasColumnName("patchBulletinID");
            entity.Property(e => e.PatchBulletinTitle)
                .HasMaxLength(255)
                .HasColumnName("patchBulletinTitle");
            entity.Property(e => e.PatchBulletinUrl)
                .HasMaxLength(4000)
                .HasColumnName("patchBulletinURL");
            entity.Property(e => e.PatchDescription).HasColumnName("patchDescription");
            entity.Property(e => e.PatchIsCustom).HasColumnName("patchIsCustom");
            entity.Property(e => e.PatchLevel).HasColumnName("patchLevel");
            entity.Property(e => e.PatchQnumbers)
                .HasMaxLength(255)
                .HasColumnName("patchQNumbers");
            entity.Property(e => e.PatchType).HasColumnName("patchType");
        });

        modelBuilder.Entity<Patch1>(entity =>
        {
            entity.HasKey(e => e.PatchId).IsClustered(false);

            entity.ToTable("Patch", "Nix");

            entity.HasIndex(e => e.Id, "UK_Patch_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PatchId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Patch2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Patch", "Reporting");

            entity.Property(e => e.Bulletin).HasMaxLength(255);
            entity.Property(e => e.BulletinTitle).HasMaxLength(255);
            entity.Property(e => e.IavaId).HasMaxLength(50);
            entity.Property(e => e.Qnumber)
                .HasMaxLength(255)
                .HasColumnName("QNumber");
            entity.Property(e => e.ReleasedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Patch3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Patch", "Reporting2");

            entity.Property(e => e.Bulletin).HasMaxLength(255);
            entity.Property(e => e.BulletinTitle).HasMaxLength(255);
            entity.Property(e => e.IavaId).HasMaxLength(50);
            entity.Property(e => e.Qnumber)
                .HasMaxLength(255)
                .HasColumnName("QNumber");
            entity.Property(e => e.ReleasedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PatchAppliesTo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchAppliesTo", "Reporting");
        });

        modelBuilder.Entity<PatchAppliesTo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchAppliesTo", "Reporting2");
        });

        modelBuilder.Entity<PatchCountsByScanMachine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchCountsByScanMachine", "Reporting");
        });

        modelBuilder.Entity<PatchCountsByScanMachine1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchCountsByScanMachine", "Reporting2");
        });

        modelBuilder.Entity<PatchCve>(entity =>
        {
            entity.ToTable("PatchCve");

            entity.HasIndex(e => e.CveId, "IX_PatchCve_CveId");

            entity.HasIndex(e => new {e.PatchUid, e.CveId}, "UK_PatchCve_PatchUidCveId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CveId).HasColumnName("cveId");
            entity.Property(e => e.PatchUid).HasColumnName("patchUid");

            entity.HasOne(d => d.Cve).WithMany(p => p.PatchCves)
                .HasForeignKey(d => d.CveId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchCve_Cve");
        });

        modelBuilder.Entity<PatchDeployAudit>(entity =>
        {
            entity.HasKey(e => new {e.PatchId, e.MachineId})
                .HasName("PK_PatchInstallAudit")
                .IsClustered(false);

            entity.ToTable("PatchDeployAudit", "Nix");

            entity.HasIndex(e => e.Id, "UK_PatchInstallAudit_id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Machine).WithMany(p => p.PatchDeployAudits)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchInstallAudit_Machine");
        });

        modelBuilder.Entity<PatchDeployment>(entity =>
        {
            entity.HasKey(e => e.PdId);

            entity.HasIndex(e => e.PdConsoleId, "IX_PatchDeployments_pdConsoleID");

            entity.HasIndex(e => e.Id, "UK_PatchDeployments_Id").IsUnique();

            entity.Property(e => e.PdId).HasColumnName("pdID");
            entity.Property(e => e.DeployTemplateName)
                .HasMaxLength(255)
                .HasColumnName("deployTemplateName");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsUninstall).HasColumnName("isUninstall");
            entity.Property(e => e.PdConsoleId).HasColumnName("pdConsoleID");
            entity.Property(e => e.PdDateTime)
                .HasColumnType("datetime")
                .HasColumnName("pdDateTime");
            entity.Property(e => e.PdDeployTemplateId).HasColumnName("pdDeployTemplateID");
            entity.Property(e => e.PdDialogDescription)
                .HasMaxLength(100)
                .HasColumnName("pdDialogDescription");
            entity.Property(e => e.PdDialogTitle)
                .HasMaxLength(20)
                .HasColumnName("pdDialogTitle");
            entity.Property(e => e.PdInstallDate)
                .HasColumnType("datetime")
                .HasColumnName("pdInstallDate");
            entity.Property(e => e.PdInstallType).HasColumnName("pdInstallType");
            entity.Property(e => e.PdName)
                .HasMaxLength(255)
                .HasColumnName("pdName");
            entity.Property(e => e.PdPptmessages).HasColumnName("pdPPTMessages");
            entity.Property(e => e.PdRebootAfterDlgSeconds).HasColumnName("pdRebootAfterDlgSeconds");
            entity.Property(e => e.PdRebootAfterEarliestTime)
                .HasColumnType("datetime")
                .HasColumnName("pdRebootAfterEarliestTime");
            entity.Property(e => e.PdRebootAfterExtendMinutes).HasColumnName("pdRebootAfterExtendMinutes");
            entity.Property(e => e.PdRebootAfterInitialMinutes).HasColumnName("pdRebootAfterInitialMinutes");
            entity.Property(e => e.PdRebootAfterLatestTime)
                .HasColumnType("datetime")
                .HasColumnName("pdRebootAfterLatestTime");
            entity.Property(e => e.PdRebootAfterMaxMinutes).HasColumnName("pdRebootAfterMaxMinutes");
            entity.Property(e => e.PdRebootAfterSafeOptions).HasColumnName("pdRebootAfterSafeOptions");
            entity.Property(e => e.PdRebootAfterWhen).HasColumnName("pdRebootAfterWhen");
            entity.Property(e => e.PdRebootBeforeDlgSeconds).HasColumnName("pdRebootBeforeDlgSeconds");
            entity.Property(e => e.PdRebootBeforeExtendMinutes).HasColumnName("pdRebootBeforeExtendMinutes");
            entity.Property(e => e.PdRebootBeforeInitialMinutes).HasColumnName("pdRebootBeforeInitialMinutes");
            entity.Property(e => e.PdRebootBeforeLatestTime)
                .HasColumnType("datetime")
                .HasColumnName("pdRebootBeforeLatestTime");
            entity.Property(e => e.PdRebootBeforeMaxMinutes).HasColumnName("pdRebootBeforeMaxMinutes");
            entity.Property(e => e.PdRebootBeforeSafeOptions).HasColumnName("pdRebootBeforeSafeOptions");
            entity.Property(e => e.PdRebootBeforeWhen).HasColumnName("pdRebootBeforeWhen");
            entity.Property(e => e.PdRemoveTempFiles).HasColumnName("pdRemoveTempFiles");
            entity.Property(e => e.PdReportsEmailed).HasColumnName("pdReportsEmailed");
            entity.Property(e => e.PdShowDialog).HasColumnName("pdShowDialog");
            entity.Property(e => e.PdShutdownExchange).HasColumnName("pdShutdownExchange");
            entity.Property(e => e.PdShutdownIis).HasColumnName("pdShutdownIIS");
            entity.Property(e => e.PdShutdownSql).HasColumnName("pdShutdownSQL");
            entity.Property(e => e.PdStatus).HasColumnName("pdStatus");
            entity.Property(e => e.PdUserName)
                .HasMaxLength(255)
                .HasColumnName("pdUserName");
            entity.Property(e => e.SourceType).HasColumnName("sourceType");
            entity.Property(e => e.StageDate)
                .HasColumnType("datetime")
                .HasColumnName("stageDate");
            entity.Property(e => e.StageType).HasColumnName("stageType");

            entity.HasOne(d => d.PdConsole).WithMany(p => p.PatchDeployments)
                .HasForeignKey(d => d.PdConsoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchDeployments_ConsoleIdentity");

            entity.HasOne(d => d.PdDeployTemplate).WithMany(p => p.PatchDeployments)
                .HasForeignKey(d => d.PdDeployTemplateId)
                .HasConstraintName("FK_PatchDeployments_DeployTemplates");
        });

        modelBuilder.Entity<PatchDeployment1>(entity =>
        {
            entity.ToTable("PatchDeployment", "Nix");

            entity.HasIndex(e => e.Uid, "UK_PatchDeployment_Uid").IsUnique();

            entity.Property(e => e.UserName).HasMaxLength(255);

            entity.HasOne(d => d.Console).WithMany(p => p.PatchDeployment1s)
                .HasForeignKey(d => d.ConsoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchDeployment_ConsoleIdentity");
        });

        modelBuilder.Entity<PatchDeployment2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchDeployment", "Reporting");

            entity.Property(e => e.DeployEndOn).HasColumnType("datetime");
            entity.Property(e => e.DeployScheduledOn).HasColumnType("datetime");
            entity.Property(e => e.DeployStartedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PatchDeployment3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchDeployment", "Reporting2");

            entity.Property(e => e.DeployEndOn).HasColumnType("datetime");
            entity.Property(e => e.DeployScheduledOn).HasColumnType("datetime");
            entity.Property(e => e.DeployStartedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PatchDeploymentConfiguration>(entity =>
        {
            entity.ToTable("PatchDeploymentConfiguration", "Nix");

            entity.HasIndex(e => e.Name, "UK_PatchDeploymentConfiguration_Name").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<PatchDeploymentDetectedPatch>(entity =>
        {
            entity.ToTable("PatchDeploymentDetectedPatch", "Nix");

            entity.HasIndex(e => e.DetectedPatchId, "IX_PatchDeploymentDetectedPatch_DetectedPatchid");

            entity.HasOne(d => d.DetectedPatch).WithMany(p => p.PatchDeploymentDetectedPatches)
                .HasForeignKey(d => d.DetectedPatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchDeploymentDetectedPatch_DetectedPatch");

            entity.HasOne(d => d.PatchDeployment).WithMany(p => p.PatchDeploymentDetectedPatches)
                .HasForeignKey(d => d.PatchDeploymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchDeploymentDetectedPatch_PatchDeployment");
        });

        modelBuilder.Entity<PatchDeploymentDetectedPatchAction>(entity =>
        {
            entity.ToTable("PatchDeploymentDetectedPatchAction", "Nix");

            entity.Property(e => e.CurrentRelease).HasMaxLength(100);
            entity.Property(e => e.CurrentVersion).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.PreviousRelease).HasMaxLength(100);
            entity.Property(e => e.PreviousVersion).HasMaxLength(100);

            entity.HasOne(d => d.PatchDeploymentDetectedPatch).WithMany(p => p.PatchDeploymentDetectedPatchActions)
                .HasForeignKey(d => d.PatchDeploymentDetectedPatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchDeploymentDetectedPatchAction_PatchDeploymentDetectedPatch");
        });

        modelBuilder.Entity<PatchGroup>(entity =>
        {
            entity.HasKey(e => e.PgrpKey);

            entity.ToTable("PatchGroup");

            entity.HasIndex(e => e.PgrpName, "UK_PatchGroup_pgrpName").IsUnique();

            entity.Property(e => e.PgrpKey).HasColumnName("pgrpKey");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .HasColumnName("path");
            entity.Property(e => e.PgrpCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("pgrpCreateDate");
            entity.Property(e => e.PgrpCreatorName)
                .HasMaxLength(256)
                .HasColumnName("pgrpCreatorName");
            entity.Property(e => e.PgrpName)
                .HasMaxLength(255)
                .HasColumnName("pgrpName");
            entity.Property(e => e.PgrpUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("pgrpUpdateDate");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasMany(d => d.Patches).WithMany(p => p.PatchGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "PatchGroupPatch",
                    r => r.HasOne<Patch>().WithMany()
                        .HasForeignKey("PatchId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchGroupPatch_Patches"),
                    l => l.HasOne<PatchGroup>().WithMany()
                        .HasForeignKey("PatchGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchGroupPatch_PatchGroup"),
                    j =>
                    {
                        j.HasKey("PatchGroupId", "PatchId");
                        j.ToTable("PatchGroupPatch");
                        j.IndexerProperty<int>("PatchGroupId").HasColumnName("patchGroupId");
                        j.IndexerProperty<int>("PatchId").HasColumnName("patchId");
                    });
        });

        modelBuilder.Entity<PatchGroup1>(entity =>
        {
            entity.ToTable("PatchGroup", "Nix");

            entity.HasIndex(e => e.Name, "UK_PatchGroup_Name").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasMany(d => d.PatchDeploymentConfigurations).WithMany(p => p.PatchGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "PatchDeploymentConfigurationPatchGroup",
                    r => r.HasOne<PatchDeploymentConfiguration>().WithMany()
                        .HasForeignKey("PatchDeploymentConfigurationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchDeploymentConfigurationPatchGroup_PatchGroup"),
                    l => l.HasOne<PatchGroup1>().WithMany()
                        .HasForeignKey("PatchGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchDeploymentConfigurationPatchGroup_PatchDeploymentConfiguration"),
                    j =>
                    {
                        j.HasKey("PatchGroupId", "PatchDeploymentConfigurationId");
                        j.ToTable("PatchDeploymentConfigurationPatchGroup", "Nix");
                    });

            entity.HasMany(d => d.PatchScanConfigurations).WithMany(p => p.PatchGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "PatchScanConfigurationPatchGroup",
                    r => r.HasOne<PatchScanConfiguration>().WithMany()
                        .HasForeignKey("PatchScanConfigurationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchScanConfigurationPatchGroup_PatchGroup"),
                    l => l.HasOne<PatchGroup1>().WithMany()
                        .HasForeignKey("PatchGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PatchScanConfigurationPatchGroup_PatchScanConfiguration"),
                    j =>
                    {
                        j.HasKey("PatchGroupId", "PatchScanConfigurationId");
                        j.ToTable("PatchScanConfigurationPatchGroup", "Nix");
                    });
        });

        modelBuilder.Entity<PatchGroupItem>(entity =>
        {
            entity.ToTable("PatchGroupItem", "Nix");

            entity.HasIndex(e => new {e.PatchGroupId, e.PatchId}, "UK_PatchGroupItem_PatchGroupIdPatchId").IsUnique();

            entity.HasOne(d => d.PatchGroup).WithMany(p => p.PatchGroupItems)
                .HasForeignKey(d => d.PatchGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchGroupItem_PatchGroup");
        });

        modelBuilder.Entity<PatchNotification>(entity =>
        {
            entity.HasKey(e => new {e.PatchId, e.NotificationId}).IsClustered(false);

            entity.ToTable("PatchNotification", "Nix");

            entity.HasIndex(e => e.Id, "UK_PatchNotification_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Notification).WithMany(p => p.PatchNotifications)
                .HasPrincipalKey(p => p.NotificationId)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchNotification_Notification");

            entity.HasOne(d => d.Patch).WithMany(p => p.PatchNotifications)
                .HasForeignKey(d => d.PatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchNotification_Patch");
        });

        modelBuilder.Entity<PatchPlatform>(entity =>
        {
            entity.HasKey(e => new {e.PatchId, e.PlatformId}).IsClustered(false);

            entity.ToTable("PatchPlatform", "Nix");

            entity.HasIndex(e => e.Id, "UK_PatchPlatform_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Patch).WithMany(p => p.PatchPlatforms)
                .HasForeignKey(d => d.PatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchPlatform_Patch");

            entity.HasOne(d => d.Platform).WithMany(p => p.PatchPlatforms)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchPlatform_Platform");
        });

        modelBuilder.Entity<PatchProductFilter>(entity =>
        {
            entity.ToTable("PatchProductFilter");

            entity.HasIndex(e => new {e.ScanTemplateId, e.CatalogId, e.Type, e.IsIncluded},
                "UK_PatchProductFilter_ScanTemplateIdCatalogIdTypeIsIncluded").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatalogId).HasColumnName("catalogId");
            entity.Property(e => e.IsIncluded).HasColumnName("isIncluded");
            entity.Property(e => e.ScanTemplateId).HasColumnName("scanTemplateId");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.ScanTemplate).WithMany(p => p.PatchProductFilters)
                .HasForeignKey(d => d.ScanTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchProductFilter_ScanTemplates");
        });

        modelBuilder.Entity<PatchScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchScan", "Reporting");

            entity.Property(e => e.ConsoleName).HasMaxLength(100);
            entity.Property(e => e.DefinitionDate).HasColumnType("datetime");
            entity.Property(e => e.DefinitionVersion).HasMaxLength(23);
            entity.Property(e => e.EndedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ScanTemplateName).HasMaxLength(255);
            entity.Property(e => e.StartedOn).HasColumnType("datetime");
            entity.Property(e => e.User).HasMaxLength(256);
        });

        modelBuilder.Entity<PatchScan1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchScan", "Reporting2");

            entity.Property(e => e.ConsoleName).HasMaxLength(100);
            entity.Property(e => e.DefinitionDate).HasColumnType("datetime");
            entity.Property(e => e.DefinitionVersion).HasMaxLength(23);
            entity.Property(e => e.EndedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ScanTemplateName).HasMaxLength(255);
            entity.Property(e => e.StartedOn).HasColumnType("datetime");
            entity.Property(e => e.User).HasMaxLength(256);
        });

        modelBuilder.Entity<PatchScanConfiguration>(entity =>
        {
            entity.ToTable("PatchScanConfiguration", "Nix");

            entity.HasIndex(e => e.Name, "UK_PatchScanConfiguration_Name").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<PatchTrace>(entity =>
        {
            entity.ToTable("PatchTrace");

            entity.HasIndex(e => new {e.Path, e.Name, e.IsFile}, "UK_PatchTrace_PathNameIsFile").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsFile).HasColumnName("isFile");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(260)
                .HasColumnName("path");
        });

        modelBuilder.Entity<PatchTrace1>(entity =>
        {
            entity.ToTable("PatchTrace", "Nix");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ReleaseExpected).HasMaxLength(100);
            entity.Property(e => e.ReleaseFound).HasMaxLength(100);
            entity.Property(e => e.VersionExpected).HasMaxLength(100);
            entity.Property(e => e.VersionFound).HasMaxLength(100);

            entity.HasOne(d => d.DetectedPatch).WithMany(p => p.PatchTrace1s)
                .HasForeignKey(d => d.DetectedPatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatchTrace_DetectedPatch");
        });

        modelBuilder.Entity<PatchType>(entity =>
        {
            entity.ToTable("PatchType");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<PatchType1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchType", "Reporting");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<PatchType2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PatchType", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity.ToTable("Platform");

            entity.HasIndex(e => new {e.Ostype, e.Architecture, e.Distribution, e.PlatformVersion},
                "UK_Platform_OSTypeArchitectureDistributionPlatformVersion").IsUnique();

            entity.Property(e => e.Distribution).HasMaxLength(100);
            entity.Property(e => e.Ostype).HasColumnName("OSType");
            entity.Property(e => e.PlatformVersion).HasMaxLength(100);
        });

        modelBuilder.Entity<Platform1>(entity =>
        {
            entity.HasKey(e => e.PlatformId).IsClustered(false);

            entity.ToTable("Platform", "Nix");

            entity.HasIndex(e => e.Id, "UK_Platform_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PlatformId).ValueGeneratedNever();
            entity.Property(e => e.Edition).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.ToTable("Policy");

            entity.HasIndex(e => e.Name, "UK_Policy_name").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AcConfigurationId).HasColumnName("acConfigurationId");
            entity.Property(e => e.AcConfigurationVersionId).HasColumnName("acConfigurationVersionId");
            entity.Property(e => e.AllowManualScanning).HasColumnName("allowManualScanning");
            entity.Property(e => e.AllowManualStop).HasColumnName("allowManualStop");
            entity.Property(e => e.CheckinChoice).HasColumnName("checkinChoice");
            entity.Property(e => e.CheckinDays).HasColumnName("checkinDays");
            entity.Property(e => e.CheckinMinutes).HasColumnName("checkinMinutes");
            entity.Property(e => e.CheckinRandomMinutes).HasColumnName("checkinRandomMinutes");
            entity.Property(e => e.CheckinTime)
                .HasColumnType("datetime")
                .HasColumnName("checkinTime");
            entity.Property(e => e.CredentialSerialNumber).HasColumnName("credentialSerialNumber");
            entity.Property(e => e.EngineDistributionServerId).HasColumnName("engineDistributionServerId");
            entity.Property(e => e.EngineDownloadChoice).HasColumnName("engineDownloadChoice");
            entity.Property(e => e.IsAgentUienabled).HasColumnName("isAgentUIEnabled");
            entity.Property(e => e.ListeningPort).HasColumnName("listeningPort");
            entity.Property(e => e.LoggingLevel).HasColumnName("loggingLevel");
            entity.Property(e => e.MaxLogSize).HasColumnName("maxLogSize");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.PreviousAcconfigurationVersionId).HasColumnName("previousACConfigurationVersionId");
            entity.Property(e => e.ServerAgentRebootOptionsId).HasColumnName("serverAgentRebootOptionsId");
            entity.Property(e => e.UseDelegatePolicyUri).HasColumnName("useDelegatePolicyUri");
            entity.Property(e => e.UseVendorAsBackup).HasColumnName("useVendorAsBackup");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
            entity.Property(e => e.WorkstationAgentRebootOptionsId).HasColumnName("workstationAgentRebootOptionsId");

            entity.HasOne(d => d.EngineDistributionServer).WithMany(p => p.Policies)
                .HasForeignKey(d => d.EngineDistributionServerId)
                .HasConstraintName("FK_Policy_RelayServer");

            entity.HasOne(d => d.ServerAgentRebootOptions).WithMany(p => p.PolicyServerAgentRebootOptions)
                .HasForeignKey(d => d.ServerAgentRebootOptionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Policy_ServerAgentRebootOptions_RebootOptionsPart");

            entity.HasOne(d => d.WorkstationAgentRebootOptions).WithMany(p => p.PolicyWorkstationAgentRebootOptions)
                .HasForeignKey(d => d.WorkstationAgentRebootOptionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Policy_WorkstationAgentRebootOptions_RebootOptionsPart");
        });

        modelBuilder.Entity<PowerShellModule>(entity =>
        {
            entity.ToTable("PowerShellModule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DownloadUrl)
                .HasMaxLength(1000)
                .HasColumnName("downloadUrl");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
            entity.Property(e => e.Version)
                .HasMaxLength(43)
                .HasColumnName("version");
        });

        modelBuilder.Entity<PowerShellResult>(entity =>
        {
            entity.ToTable("PowerShellResult");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayResult)
                .HasMaxLength(100)
                .HasColumnName("displayResult");
            entity.Property(e => e.Ended)
                .HasColumnType("datetime")
                .HasColumnName("ended");
            entity.Property(e => e.MachineGroupName)
                .HasMaxLength(100)
                .HasColumnName("machineGroupName");
            entity.Property(e => e.MachineId).HasColumnName("machineId");
            entity.Property(e => e.PowerShellRunId).HasColumnName("powerShellRunId");
            entity.Property(e => e.ResultFolder)
                .HasMaxLength(260)
                .HasColumnName("resultFolder");

            entity.HasOne(d => d.Machine).WithMany(p => p.PowerShellResults)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PowerShellResult_ManagedMachines");

            entity.HasOne(d => d.PowerShellRun).WithMany(p => p.PowerShellResults)
                .HasForeignKey(d => d.PowerShellRunId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PowerShellResult_PowerShellRun");
        });

        modelBuilder.Entity<PowerShellRun>(entity =>
        {
            entity.ToTable("PowerShellRun");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Concurrency).HasColumnName("concurrency");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DisplayResult)
                .HasMaxLength(100)
                .HasColumnName("displayResult");
            entity.Property(e => e.Ended)
                .HasColumnType("datetime")
                .HasColumnName("ended");
            entity.Property(e => e.ExecutionType).HasColumnName("executionType");
            entity.Property(e => e.Parameters).HasColumnName("parameters");
            entity.Property(e => e.ResultFolder)
                .HasMaxLength(260)
                .HasColumnName("resultFolder");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(100)
                .HasColumnName("scriptName");
            entity.Property(e => e.ScriptUid).HasColumnName("scriptUid");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .HasColumnName("templateName");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PowerShellRun)
                .HasForeignKey<PowerShellRun>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PowerShellRun_Scans");
        });

        modelBuilder.Entity<PowerShellScript>(entity =>
        {
            entity.ToTable("PowerShellScript");

            entity.HasIndex(e => new {e.Name, e.Author, e.IsUserScript}, "UK_PowerShellScript_NameAuthorIsUserScript").IsUnique();

            entity.HasIndex(e => e.Uid, "UK_PowerShellScript_Uid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(256)
                .HasColumnName("author");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorSid)
                .HasMaxLength(68)
                .HasColumnName("creatorSid");
            entity.Property(e => e.DisplayVersion)
                .HasMaxLength(43)
                .HasColumnName("displayVersion");
            entity.Property(e => e.ExecutionType).HasColumnName("executionType");
            entity.Property(e => e.Inputs)
                .HasMaxLength(1024)
                .HasColumnName("inputs");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsInteractive).HasColumnName("isInteractive");
            entity.Property(e => e.IsUserScript).HasColumnName("isUserScript");
            entity.Property(e => e.LicenseLevel).HasColumnName("licenseLevel");
            entity.Property(e => e.MinEngineVersion)
                .HasMaxLength(43)
                .HasColumnName("minEngineVersion");
            entity.Property(e => e.ModifiesTarget).HasColumnName("modifiesTarget");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Outputs)
                .HasMaxLength(1024)
                .HasColumnName("outputs");
            entity.Property(e => e.Purpose)
                .HasMaxLength(1024)
                .HasColumnName("purpose");
            entity.Property(e => e.RawScript).HasColumnName("rawScript");
            entity.Property(e => e.SchemaVersion)
                .HasMaxLength(43)
                .HasColumnName("schemaVersion");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated");
            entity.Property(e => e.UsageCount).HasColumnName("usageCount");
        });

        modelBuilder.Entity<PowerShellTemplate>(entity =>
        {
            entity.ToTable("PowerShellTemplate");

            entity.HasIndex(e => e.Name, "UK_PowerShellTemplate_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concurrency).HasColumnName("concurrency");
            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .HasColumnName("description");
            entity.Property(e => e.ExecutionType).HasColumnName("executionType");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OwnerSid)
                .HasMaxLength(68)
                .HasColumnName("ownerSid");
            entity.Property(e => e.Parameters).HasColumnName("parameters");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.ScriptId).HasColumnName("scriptId");
            entity.Property(e => e.UseSsl).HasColumnName("useSsl");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasOne(d => d.Script).WithMany(p => p.PowerShellTemplates)
                .HasForeignKey(d => d.ScriptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PowerShellTemplate_PowerShellScript");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProdId);

            entity.HasIndex(e => e.Uid, "IX_Products_uid");

            entity.HasIndex(e => e.ProdName, "UK_Products_ProdName").IsUnique();

            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.EndOfLife)
                .HasColumnType("datetime")
                .HasColumnName("endOfLife");
            entity.Property(e => e.EndOfLifeUrl)
                .HasMaxLength(4000)
                .HasColumnName("endOfLifeUrl");
            entity.Property(e => e.LastRevisedOn)
                .HasColumnType("datetime")
                .HasColumnName("lastRevisedOn");
            entity.Property(e => e.ProdIsCustom).HasColumnName("prodIsCustom");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.VendorId).HasColumnName("vendorId");
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Product", "Reporting");

            entity.Property(e => e.EndOfLifeOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ServicePackName).HasMaxLength(50);
        });

        modelBuilder.Entity<Product2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Product", "Reporting2");

            entity.Property(e => e.EndOfLifeOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ProductLevelName).HasMaxLength(50);
        });

        modelBuilder.Entity<PropertyCollection>(entity =>
        {
            entity.HasKey(e => new {e.GroupId, e.CollectionId, e.Name});

            entity.ToTable("PropertyCollection");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.CollectionId).HasColumnName("collectionId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasColumnType("sql_variant")
                .HasColumnName("value");
        });

        modelBuilder.Entity<RebootOptionsPart>(entity =>
        {
            entity.HasKey(e => e.PartId).HasName("PK_RebootPart");

            entity.ToTable("RebootOptionsPart");

            entity.Property(e => e.PartId)
                .ValueGeneratedNever()
                .HasColumnName("partId");
            entity.Property(e => e.ActionType).HasColumnName("actionType");
            entity.Property(e => e.CountDownMinutes).HasColumnName("countDownMinutes");
            entity.Property(e => e.CreatorName)
                .HasMaxLength(256)
                .HasColumnName("creatorName");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.ExtendIncrementMinutes).HasColumnName("extendIncrementMinutes");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.InteractionType).HasColumnName("interactionType");
            entity.Property(e => e.InteractiveCutoffDateTime)
                .HasColumnType("datetime")
                .HasColumnName("interactiveCutoffDateTime");
            entity.Property(e => e.IsCancelRebootAllowed).HasColumnName("isCancelRebootAllowed");
            entity.Property(e => e.IsCancelTimeoutAllowed).HasColumnName("isCancelTimeoutAllowed");
            entity.Property(e => e.IsExtendAllowed).HasColumnName("isExtendAllowed");
            entity.Property(e => e.IsSystem).HasColumnName("isSystem");
            entity.Property(e => e.IsTemp).HasColumnName("isTemp");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.ScheduleType).HasColumnName("scheduleType");
            entity.Property(e => e.ScheduledDateTime)
                .HasColumnType("datetime")
                .HasColumnName("scheduledDateTime");
            entity.Property(e => e.ShutdownDialogSeconds).HasColumnName("shutdownDialogSeconds");
            entity.Property(e => e.TargetPowerState).HasColumnName("targetPowerState");
            entity.Property(e => e.TimeoutMinutes).HasColumnName("timeoutMinutes");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<RelayIprange>(entity =>
        {
            entity.HasKey(e => e.RirId);

            entity.ToTable("RelayIPRange");

            entity.Property(e => e.RirId).HasColumnName("rirID");
            entity.Property(e => e.BackupServerId).HasColumnName("backupServerId");
            entity.Property(e => e.PrimaryServerId).HasColumnName("primaryServerId");
            entity.Property(e => e.RirIphigh)
                .HasMaxLength(15)
                .HasColumnName("rirIPHigh");
            entity.Property(e => e.RirIplow)
                .HasMaxLength(15)
                .HasColumnName("rirIPLow");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");

            entity.HasOne(d => d.BackupServer).WithMany(p => p.RelayIprangeBackupServers)
                .HasForeignKey(d => d.BackupServerId)
                .HasConstraintName("FK_RelayIPRange_RelayServer1");

            entity.HasOne(d => d.PrimaryServer).WithMany(p => p.RelayIprangePrimaryServers)
                .HasForeignKey(d => d.PrimaryServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelayIPRange_RelayServer");
        });

        modelBuilder.Entity<RelayServer>(entity =>
        {
            entity.HasKey(e => e.RelayId);

            entity.ToTable("RelayServer");

            entity.HasIndex(e => e.RelayName, "UK_RelayServer_relayName").IsUnique();

            entity.Property(e => e.RelayId).HasColumnName("relayID");
            entity.Property(e => e.AutoSync).HasColumnName("autoSync");
            entity.Property(e => e.RelayClientHttpPort).HasColumnName("relayClientHttpPort");
            entity.Property(e => e.RelayClientPath)
                .HasMaxLength(4000)
                .HasColumnName("relayClientPath");
            entity.Property(e => e.RelayClientSsl).HasColumnName("relayClientSSL");
            entity.Property(e => e.RelayClientType).HasColumnName("relayClientType");
            entity.Property(e => e.RelayConsolePath)
                .HasMaxLength(4000)
                .HasColumnName("relayConsolePath");
            entity.Property(e => e.RelayName)
                .HasMaxLength(100)
                .HasColumnName("relayName");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<ResolutionResult>(entity =>
        {
            entity.ToTable("ResolutionResult");

            entity.HasIndex(e => e.Uid, "UK_ResolutionResult_Uid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DiscoveryFilterName)
                .HasMaxLength(4000)
                .HasColumnName("discoveryFilterName");
            entity.Property(e => e.DiscoveryFilterType).HasColumnName("discoveryFilterType");
            entity.Property(e => e.MachineGroupName)
                .HasMaxLength(255)
                .HasColumnName("machineGroupName");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.NativeCode).HasColumnName("nativeCode");
            entity.Property(e => e.ScanId).HasColumnName("scanId");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.Scan).WithMany(p => p.ResolutionResults)
                .HasForeignKey(d => d.ScanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResolutionResult_Scans");
        });

        modelBuilder.Entity<ResultImportExport>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("ResultImportExport");

            entity.HasIndex(e => new {e.DocumentType, e.ExportDate, e.ImportDate},
                "IX_ResultImportExport_DocumentTypeExportDateImportDate");

            entity.HasIndex(e => new {e.EntityId1, e.DocumentType, e.EntityId2}, "UK_ResultImportExport").IsUnique();

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("documentId");
            entity.Property(e => e.DocumentType).HasColumnName("documentType");
            entity.Property(e => e.EntityId1).HasColumnName("entityId1");
            entity.Property(e => e.EntityId2).HasColumnName("entityId2");
            entity.Property(e => e.ExportDate)
                .HasColumnType("datetime")
                .HasColumnName("exportDate");
            entity.Property(e => e.ImportDate)
                .HasColumnType("datetime")
                .HasColumnName("importDate");
        });

        modelBuilder.Entity<RoleUser>(entity =>
        {
            entity.ToTable("RoleUser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Domain)
                .HasMaxLength(256)
                .HasColumnName("domain");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Username)
                .HasMaxLength(256)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Scan>(entity =>
        {
            entity.HasIndex(e => e.ScanConsoleId, "IX_Scans_ScanConsoleID");

            entity.HasIndex(e => e.ScanDate, "IX_Scans_ScanDate");

            entity.HasIndex(e => e.ScanTemplateId, "IX_Scans_ScanTemplateID");

            entity.HasIndex(e => e.ScanfavKey, "IX_Scans_ScanfavKey");

            entity.HasIndex(e => e.ScanGuid, "UK_Scans_ScanGuid").IsUnique();

            entity.Property(e => e.ScanId).HasColumnName("ScanID");
            entity.Property(e => e.ExpectedResolutionResultTotal).HasColumnName("expectedResolutionResultTotal");
            entity.Property(e => e.ExpectedResultTotal).HasColumnName("expectedResultTotal");
            entity.Property(e => e.ReceivedResolutionResultCount).HasColumnName("receivedResolutionResultCount");
            entity.Property(e => e.ReceivedResultCount).HasColumnName("receivedResultCount");
            entity.Property(e => e.ScanConsoleId).HasColumnName("ScanConsoleID");
            entity.Property(e => e.ScanDate).HasColumnType("datetime");
            entity.Property(e => e.ScanName).HasMaxLength(255);
            entity.Property(e => e.ScanScannerVersion).HasMaxLength(100);
            entity.Property(e => e.ScanTemplateId).HasColumnName("ScanTemplateID");
            entity.Property(e => e.ScanType).HasColumnName("scanType");
            entity.Property(e => e.ScanUser).HasMaxLength(256);
            entity.Property(e => e.ScanXmldate)
                .HasColumnType("datetime")
                .HasColumnName("ScanXMLDate");
            entity.Property(e => e.ScanXmlversion)
                .HasMaxLength(23)
                .HasColumnName("ScanXMLVersion");
            entity.Property(e => e.SourceType).HasColumnName("sourceType");
            entity.Property(e => e.Started)
                .HasColumnType("datetime")
                .HasColumnName("started");
            entity.Property(e => e.UserSid)
                .HasMaxLength(68)
                .HasColumnName("userSid");

            entity.HasOne(d => d.ScanConsole).WithMany(p => p.Scans)
                .HasForeignKey(d => d.ScanConsoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Scans_ConsoleIdentity");

            entity.HasOne(d => d.ScanTemplate).WithMany(p => p.Scans)
                .HasForeignKey(d => d.ScanTemplateId)
                .HasConstraintName("FK_Scans_ScanTemplates");

            entity.HasOne(d => d.ScanfavKeyNavigation).WithMany(p => p.Scans)
                .HasForeignKey(d => d.ScanfavKey)
                .HasConstraintName("FK_Scans_Favorites");
        });

        modelBuilder.Entity<ScanItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.HasIndex(e => e.ItemMachineId, "IX_ScanItems_itemMachineID");

            entity.HasIndex(e => e.ItempspplId, "IX_ScanItems_itempspplID");

            entity.HasIndex(e => e.ItemspplId, "IX_ScanItems_itemspplID");

            entity.Property(e => e.ItemId).HasColumnName("itemID");
            entity.Property(e => e.ActualTrace)
                .HasMaxLength(43)
                .HasColumnName("actualTrace");
            entity.Property(e => e.EvidenceRule).HasColumnName("evidenceRule");
            entity.Property(e => e.ExpectedTrace)
                .HasMaxLength(43)
                .HasColumnName("expectedTrace");
            entity.Property(e => e.InstallState).HasColumnName("installState");
            entity.Property(e => e.InstalledBy)
                .HasMaxLength(256)
                .HasColumnName("installedBy");
            entity.Property(e => e.InstalledOn)
                .HasColumnType("datetime")
                .HasColumnName("installedOn");
            entity.Property(e => e.ItemInstanceName)
                .HasMaxLength(255)
                .HasColumnName("itemInstanceName");
            entity.Property(e => e.ItemMachineId).HasColumnName("itemMachineID");
            entity.Property(e => e.ItemType).HasColumnName("itemType");
            entity.Property(e => e.ItempspplId).HasColumnName("itempspplID");
            entity.Property(e => e.ItemspplId).HasColumnName("itemspplID");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.PatchTraceId).HasColumnName("patchTraceId");
            entity.Property(e => e.StatusMessage).HasColumnName("statusMessage");
            entity.Property(e => e.StatusMessageId).HasColumnName("statusMessageId");

            entity.HasOne(d => d.ItemMachine).WithMany(p => p.ScanItems)
                .HasForeignKey(d => d.ItemMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScanItems_ScanMachines");

            entity.HasOne(d => d.Itempsppl).WithMany(p => p.ScanItems)
                .HasForeignKey(d => d.ItempspplId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScanItems_LinkPatchProduct");

            entity.HasOne(d => d.Itemsppl).WithMany(p => p.ScanItems)
                .HasForeignKey(d => d.ItemspplId)
                .HasConstraintName("FK_ScanItems_LinkSPProduct");

            entity.HasOne(d => d.PatchTrace).WithMany(p => p.ScanItems)
                .HasForeignKey(d => d.PatchTraceId)
                .HasConstraintName("FK_ScanItems_PatchTrace");
        });

        modelBuilder.Entity<ScanMachine>(entity =>
        {
            entity.HasKey(e => e.SmachId);

            entity.HasIndex(e => e.SmachNotFoundReasonErrorNum, "IX_ScanMachines_smachNotFoundReasonErrorNum");

            entity.HasIndex(e => e.SmachOsid, "IX_ScanMachines_smachOSID");

            entity.HasIndex(e => e.SmachScanId, "IX_ScanMachines_smachScanID");

            entity.HasIndex(e => e.SmachmmKey, "IX_ScanMachines_smachmmKey");

            entity.HasIndex(e => new {e.SmachName, e.SmachScanId, e.SmachDomainName, e.VirtualMachineId},
                "UK_ScanMachines_smachName_smachScanID_smachDomainName_virtualMachineId").IsUnique();

            entity.Property(e => e.SmachId).HasColumnName("smachID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .HasColumnName("groupName");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ipAddress");
            entity.Property(e => e.IsAgent).HasColumnName("isAgent");
            entity.Property(e => e.ManagedListId).HasColumnName("managedListId");
            entity.Property(e => e.NixOsid).HasColumnName("nixOSId");
            entity.Property(e => e.PlatformId).HasColumnName("platformId");
            entity.Property(e => e.PowerState).HasColumnName("powerState");
            entity.Property(e => e.SmachDomainName)
                .HasMaxLength(255)
                .HasColumnName("smachDomainName");
            entity.Property(e => e.SmachMachineType).HasColumnName("smachMachineType");
            entity.Property(e => e.SmachName)
                .HasMaxLength(255)
                .HasColumnName("smachName");
            entity.Property(e => e.SmachNotFoundReason).HasColumnName("smachNotFoundReason");
            entity.Property(e => e.SmachNotFoundReasonErrorNum).HasColumnName("smachNotFoundReasonErrorNum");
            entity.Property(e => e.SmachOsid).HasColumnName("smachOSID");
            entity.Property(e => e.SmachScanDate)
                .HasColumnType("datetime")
                .HasColumnName("smachScanDate");
            entity.Property(e => e.SmachScanId).HasColumnName("smachScanID");
            entity.Property(e => e.SmachServerType).HasColumnName("smachServerType");
            entity.Property(e => e.SmachmmKey).HasColumnName("smachmmKey");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
            entity.Property(e => e.VirtualMachineId).HasColumnName("virtualMachineId");

            entity.HasOne(d => d.Platform).WithMany(p => p.ScanMachines)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScanMachines_Platform");

            entity.HasOne(d => d.SmachOs).WithMany(p => p.ScanMachines)
                .HasForeignKey(d => d.SmachOsid)
                .HasConstraintName("FK_ScanMachines_LinkSPProduct");

            entity.HasOne(d => d.SmachScan).WithMany(p => p.ScanMachines)
                .HasForeignKey(d => d.SmachScanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScanMachines_Scans");

            entity.HasOne(d => d.SmachmmKeyNavigation).WithMany(p => p.ScanMachines)
                .HasForeignKey(d => d.SmachmmKey)
                .HasConstraintName("FK_ScanMachines_ManagedMachines");

            entity.HasOne(d => d.VirtualMachine).WithMany(p => p.ScanMachines)
                .HasForeignKey(d => d.VirtualMachineId)
                .HasConstraintName("FK_ScanMachines_VirtualMachine");
        });

        modelBuilder.Entity<ScanTemplate>(entity =>
        {
            entity.HasKey(e => e.ScantId);

            entity.HasIndex(e => e.ScantName, "UK_ScanTemplates_scantName").IsUnique();

            entity.Property(e => e.ScantId).HasColumnName("scantID");
            entity.Property(e => e.MaxThreadCount).HasColumnName("maxThreadCount");
            entity.Property(e => e.NonSecurityPatchesMask).HasColumnName("nonSecurityPatchesMask");
            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .HasColumnName("path");
            entity.Property(e => e.ScantCreatorName)
                .HasMaxLength(256)
                .HasColumnName("scantCreatorName");
            entity.Property(e => e.ScantDescription)
                .HasMaxLength(255)
                .HasColumnName("scantDescription");
            entity.Property(e => e.ScantFqfile)
                .HasMaxLength(4000)
                .HasColumnName("scantFQFile");
            entity.Property(e => e.ScantHistoryType).HasColumnName("scantHistoryType");
            entity.Property(e => e.ScantName)
                .HasMaxLength(255)
                .HasColumnName("scantName");
            entity.Property(e => e.ScantPatchTypes).HasColumnName("scantPatchTypes");
            entity.Property(e => e.ScantPatchTypesFilter).HasColumnName("scantPatchTypesFilter");
            entity.Property(e => e.ScantPatchesFilter).HasColumnName("scantPatchesFilter");
            entity.Property(e => e.ScantSystem).HasColumnName("scantSystem");
            entity.Property(e => e.ScantSystemCode)
                .HasMaxLength(10)
                .HasColumnName("scantSystemCode");
            entity.Property(e => e.ScantTemp).HasColumnName("scantTemp");
            entity.Property(e => e.SecurityPatchesMask).HasColumnName("securityPatchesMask");
            entity.Property(e => e.SoftwareDistribution).HasColumnName("softwareDistribution");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<ScanType>(entity =>
        {
            entity.ToTable("ScanType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<ScanType1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ScanType", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<ServicePack>(entity =>
        {
            entity.HasKey(e => e.SpId);

            entity.HasIndex(e => e.SpName, "UK_ServicePacks_spName").IsUnique();

            entity.Property(e => e.SpId).HasColumnName("spID");
            entity.Property(e => e.SpName)
                .HasMaxLength(50)
                .HasColumnName("spName");
        });

        modelBuilder.Entity<ServicePackGroup>(entity =>
        {
            entity.ToTable("ServicePackGroup");

            entity.HasIndex(e => e.Name, "UK_ServicePackGroup_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasMaxLength(195)
                .HasColumnName("owner");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<ServicePackGroupProduct>(entity =>
        {
            entity.ToTable("ServicePackGroupProduct");

            entity.HasIndex(e => new {e.ServicePackGroupId, e.CatalogProductUid},
                "UK_ServicePackGroupProduct_servicePackGroupIdCatalogProductUid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatalogProductUid).HasColumnName("catalogProductUid");
            entity.Property(e => e.SelectedServicePackName)
                .HasMaxLength(50)
                .HasColumnName("selectedServicePackName");
            entity.Property(e => e.SelectedServicePackOrdinal).HasColumnName("selectedServicePackOrdinal");
            entity.Property(e => e.ServicePackGroupId).HasColumnName("servicePackGroupId");
            entity.Property(e => e.UseLatest).HasColumnName("useLatest");

            entity.HasOne(d => d.ServicePackGroup).WithMany(p => p.ServicePackGroupProducts)
                .HasForeignKey(d => d.ServicePackGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicePackGroupProduct_ServicePackGroup");
        });

        modelBuilder.Entity<SmartFilterGroup>(entity =>
        {
            entity.ToTable("SmartFilterGroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FilterGroupType).HasColumnName("filterGroupType");
            entity.Property(e => e.MatchType).HasColumnName("matchType");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .HasColumnName("name");
            entity.Property(e => e.ReadOnly).HasColumnName("readOnly");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<SmartFilterRule>(entity =>
        {
            entity.ToTable("SmartFilterRule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Field)
                .HasMaxLength(50)
                .HasColumnName("field");
            entity.Property(e => e.SearchOperator).HasColumnName("searchOperator");
            entity.Property(e => e.SearchText)
                .HasMaxLength(100)
                .HasColumnName("searchText");
            entity.Property(e => e.SmartFilterId).HasColumnName("smartFilterId");

            entity.HasOne(d => d.SmartFilter).WithMany(p => p.SmartFilterRules)
                .HasForeignKey(d => d.SmartFilterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SmartFilterRule_SmartFilterGroup");
        });

        modelBuilder.Entity<SoftwareTitle>(entity =>
        {
            entity.ToTable("SoftwareTitle");

            entity.HasIndex(e => new {e.Name, e.DisplayVersion, e.Publisher}, "UK_SoftwareTitle_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayVersion)
                .HasMaxLength(64)
                .HasColumnName("displayVersion");
            entity.Property(e => e.MsiVersionNumber).HasColumnName("msiVersionNumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(255)
                .HasColumnName("productCode");
            entity.Property(e => e.Publisher)
                .HasMaxLength(128)
                .HasColumnName("publisher");
        });

        modelBuilder.Entity<SourceType>(entity =>
        {
            entity.ToTable("SourceType");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<SourceType1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SourceType", "Reporting");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<SourceType2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SourceType", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.ToTable("Task");

            entity.HasIndex(e => new {e.PolicyId, e.Name, e.Type}, "UK_Task_name").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AtStartUp).HasColumnName("atStartUp");
            entity.Property(e => e.InitialStartTime).HasColumnName("initialStartTime");
            entity.Property(e => e.Interval).HasColumnName("interval");
            entity.Property(e => e.IntervalType).HasColumnName("intervalType");
            entity.Property(e => e.MonthDay).HasColumnName("monthDay");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PolicyId).HasColumnName("policyId");
            entity.Property(e => e.RandomizeOffsetMinutes).HasColumnName("randomizeOffsetMinutes");
            entity.Property(e => e.RelativeDayAdditionalDays).HasColumnName("relativeDayAdditionalDays");
            entity.Property(e => e.RelativeDayOffset).HasColumnName("relativeDayOffset");
            entity.Property(e => e.StartupOffsetMinutes).HasColumnName("startupOffsetMinutes");
            entity.Property(e => e.TimeOfDay).HasColumnName("timeOfDay");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.WeekdayMask).HasColumnName("weekdayMask");

            entity.HasOne(d => d.Policy).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Task_Policy");
        });

        modelBuilder.Entity<TaskParameter>(entity =>
        {
            entity.ToTable("TaskParameter");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.TaskId).HasColumnName("taskId");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(4000)
                .HasColumnName("value");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskParameters)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskParameter_Task");
        });

        modelBuilder.Entity<TaskPolicyPart>(entity =>
        {
            entity.HasKey(e => new {e.PartId, e.TaskId});

            entity.ToTable("TaskPolicyPart");

            entity.Property(e => e.PartId).HasColumnName("partId");
            entity.Property(e => e.TaskId).HasColumnName("taskId");
            entity.Property(e => e.PolicyPartType).HasColumnName("policyPartType");
            entity.Property(e => e.StepType).HasColumnName("stepType");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskPolicyParts)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskPolicyPart_Task");
        });

        modelBuilder.Entity<Top10VulnerableMachine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Top10VulnerableMachines");

            entity.Property(e => e.MachineName).HasMaxLength(255);
        });

        modelBuilder.Entity<UserCredential>(entity =>
        {
            entity.ToTable("UserCredential");

            entity.HasIndex(e => new {e.Name, e.OwnerSid, e.OwnerMachineSid}, "UK_NameOwnerSidOwnerMachineSid").IsUnique();

            entity.HasIndex(e => e.Uid, "UK_UserCredential_Uid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OwnerMachineSid)
                .HasMaxLength(68)
                .HasColumnName("ownerMachineSid");
            entity.Property(e => e.OwnerSid)
                .HasMaxLength(68)
                .HasColumnName("ownerSid");
            entity.Property(e => e.ParentUid).HasColumnName("parentUid");
            entity.Property(e => e.Password)
                .HasMaxLength(1024)
                .HasColumnName("password");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.UserName)
                .HasMaxLength(512)
                .HasColumnName("userName");

            entity.HasOne(d => d.ParentU).WithMany(p => p.InverseParentU)
                .HasPrincipalKey(p => p.Uid)
                .HasForeignKey(d => d.ParentUid)
                .HasConstraintName("FK_UserCredential_UserCredential");
        });

        modelBuilder.Entity<VcenterServer>(entity =>
        {
            entity.ToTable("VCenterServer", "Virtual");

            entity.HasIndex(e => e.Name, "UK_VCenterServer_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertificateThumbprint)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("certificateThumbprint");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<VendorSeverity>(entity =>
        {
            entity.ToTable("VendorSeverity");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<VendorSeverity1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VendorSeverity", "Reporting");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<VendorSeverity2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VendorSeverity", "Reporting2");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<VirtualImage>(entity =>
        {
            entity.ToTable("VirtualImage", "Virtual");

            entity.HasIndex(e => new {e.InventoryPath, e.HypervisorId}, "UK_VirtualImage_inventoryPathHypervisorId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hostname)
                .HasMaxLength(256)
                .HasColumnName("hostname");
            entity.Property(e => e.HypervisorId).HasColumnName("hypervisorId");
            entity.Property(e => e.InventoryPath)
                .HasMaxLength(1024)
                .HasColumnName("inventoryPath");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(16)
                .HasColumnName("ipAddress");
            entity.Property(e => e.IsTemplate).HasColumnName("isTemplate");
            entity.Property(e => e.LastKnownPowerState).HasColumnName("lastKnownPowerState");
            entity.Property(e => e.MemoryMb).HasColumnName("memoryMB");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.NumberOfCpus).HasColumnName("numberOfCPUs");
            entity.Property(e => e.OsName)
                .HasMaxLength(128)
                .HasColumnName("osName");
            entity.Property(e => e.ToolsStatus).HasColumnName("toolsStatus");
            entity.Property(e => e.ToolsVersion).HasColumnName("toolsVersion");
            entity.Property(e => e.ToolsVersionStatus).HasColumnName("toolsVersionStatus");
            entity.Property(e => e.TotalDiskSpace).HasColumnName("totalDiskSpace");
            entity.Property(e => e.Uuid)
                .HasMaxLength(64)
                .HasColumnName("uuid");
            entity.Property(e => e.VmxPath).HasColumnName("vmxPath");

            entity.HasOne(d => d.Hypervisor).WithMany(p => p.VirtualImages)
                .HasForeignKey(d => d.HypervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VirtualImage_Hypervisor");
        });

        modelBuilder.Entity<VirtualMachine>(entity =>
        {
            entity.ToTable("VirtualMachine");

            entity.HasIndex(e => new {e.Path, e.VirtualServerId}, "UK_VirtualMachine_path_virtualServerId").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Path)
                .HasMaxLength(260)
                .HasColumnName("path");
            entity.Property(e => e.VirtualServerId).HasColumnName("virtualServerId");

            entity.HasOne(d => d.VirtualServer).WithMany(p => p.VirtualMachines)
                .HasForeignKey(d => d.VirtualServerId)
                .HasConstraintName("FK_VirtualMachine_VirtualServer");
        });

        modelBuilder.Entity<VirtualOwnership>(entity =>
        {
            entity.HasKey(e => new {e.EntityId, e.UsageType, e.OwnerSid});

            entity.ToTable("VirtualOwnership", "Virtual");

            entity.Property(e => e.EntityId).HasColumnName("entityId");
            entity.Property(e => e.UsageType).HasColumnName("usageType");
            entity.Property(e => e.OwnerSid)
                .HasMaxLength(68)
                .HasColumnName("ownerSid");
        });

        modelBuilder.Entity<VirtualServer>(entity =>
        {
            entity.ToTable("VirtualServer");

            entity.HasIndex(e => e.Name, "UK_VirtualServer_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Port).HasColumnName("port");
        });

        modelBuilder.Entity<XtrCumulativePatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrCumulativePatches");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Patchcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATCHCODE");
        });

        modelBuilder.Entity<XtrCurrentPatchCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrCurrentPatchCount");

            entity.Property(e => e.Informationalcnt).HasColumnName("INFORMATIONALCNT");
            entity.Property(e => e.Installedcnt).HasColumnName("INSTALLEDCNT");
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Missingspcnt).HasColumnName("MISSINGSPCNT");
            entity.Property(e => e.Notinstalledcnt).HasColumnName("NOTINSTALLEDCNT");
            entity.Property(e => e.Patchgroup)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("PATCHGROUP");
            entity.Property(e => e.Severity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEVERITY");
        });

        modelBuilder.Entity<XtrCurrentPatchStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrCurrentPatchStatus");

            entity.HasIndex(e => e.Assessedmachinestateid, "IDX_ASSESSEDMACHINESTATEID");

            entity.HasIndex(e => e.Bulletin, "IDX_BULLETIN");

            entity.HasIndex(e => e.Deployid, "IDX_DEPLOYID");

            entity.HasIndex(e => e.Detectedpatchstateid, "IDX_DETECTEDPATCHSTATEID");

            entity.HasIndex(e => e.Installstateid, "IDX_INSTALLSTATEID");

            entity.HasIndex(e => e.Machineid, "IDX_MACHINEID");

            entity.HasIndex(e => e.Osid, "IDX_OSID");

            entity.HasIndex(e => e.Patchid, "IDX_PATCHID");

            entity.HasIndex(e => e.Productid, "IDX_PRODUCTID");

            entity.HasIndex(e => e.Scandate, "IDX_SCANDATE");

            entity.Property(e => e.Assessedmachinestateid).HasColumnName("ASSESSEDMACHINESTATEID");
            entity.Property(e => e.Bulletin)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("BULLETIN");
            entity.Property(e => e.Deployid).HasColumnName("DEPLOYID");
            entity.Property(e => e.Detectedpatchstateid).HasColumnName("DETECTEDPATCHSTATEID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Installstateid).HasColumnName("INSTALLSTATEID");
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Osid).HasColumnName("OSID");
            entity.Property(e => e.Patchid).HasColumnName("PATCHID");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Scandate)
                .HasColumnType("datetime")
                .HasColumnName("SCANDATE");
        });

        modelBuilder.Entity<XtrDistinctAssessed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrDistinctAssessed");

            entity.Property(e => e.Assessedon)
                .HasColumnType("datetime")
                .HasColumnName("ASSESSEDON");
            entity.Property(e => e.M)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XtrDistinctDeployed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrDistinctDeployed");

            entity.Property(e => e.Deployedon)
                .HasColumnType("datetime")
                .HasColumnName("DEPLOYEDON");
            entity.Property(e => e.M)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XtrDistinctPatched>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrDistinctPatched");

            entity.Property(e => e.M)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Patchedon)
                .HasColumnType("datetime")
                .HasColumnName("PATCHEDON");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XtrEntityProcessErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrEntityProcessErrorLog");

            entity.Property(e => e.Batchid).HasColumnName("BATCHID");
            entity.Property(e => e.Entityname)
                .HasMaxLength(100)
                .HasColumnName("ENTITYNAME");
            entity.Property(e => e.Entityprocesserrorlogid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ENTITYPROCESSERRORLOGID");
            entity.Property(e => e.Errorline).HasColumnName("ERRORLINE");
            entity.Property(e => e.Errormessage)
                .HasMaxLength(4000)
                .HasColumnName("ERRORMESSAGE");
            entity.Property(e => e.Errornumber).HasColumnName("ERRORNUMBER");
            entity.Property(e => e.Errorprocedure)
                .HasMaxLength(128)
                .HasColumnName("ERRORPROCEDURE");
            entity.Property(e => e.Errorseverity).HasColumnName("ERRORSEVERITY");
            entity.Property(e => e.Errorstate).HasColumnName("ERRORSTATE");
            entity.Property(e => e.Logdate)
                .HasColumnType("datetime")
                .HasColumnName("LOGDATE");
        });

        modelBuilder.Entity<XtrEntityProcessLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrEntityProcessLog");

            entity.Property(e => e.Batchid).HasColumnName("BATCHID");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Entityprocesslogid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ENTITYPROCESSLOGID");
            entity.Property(e => e.Logdate)
                .HasColumnType("datetime")
                .HasColumnName("LOGDATE");
            entity.Property(e => e.Procedurename)
                .HasMaxLength(100)
                .HasColumnName("PROCEDURENAME");
        });

        modelBuilder.Entity<XtrLinuxCumulativePatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrLinuxCumulativePatches");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Patchcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATCHCODE");
        });

        modelBuilder.Entity<XtrLinuxCurrentPatchCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrLinuxCurrentPatchCount");

            entity.Property(e => e.Informationalcnt).HasColumnName("INFORMATIONALCNT");
            entity.Property(e => e.Installedcnt).HasColumnName("INSTALLEDCNT");
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Missingspcnt).HasColumnName("MISSINGSPCNT");
            entity.Property(e => e.Notinstalledcnt).HasColumnName("NOTINSTALLEDCNT");
            entity.Property(e => e.Severity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEVERITY");
        });

        modelBuilder.Entity<XtrLinuxCurrentPatchStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrLinuxCurrentPatchStatus");

            entity.HasIndex(e => e.Assessedmachinestateid, "IDX_LINUXASSESSEDMACHINESTATEID");

            entity.HasIndex(e => e.Installstateid, "IDX_LINUXINSTALLSTATEID");

            entity.HasIndex(e => e.Machineid, "IDX_LINUXMACHINEID");

            entity.HasIndex(e => e.Patch, "IDX_LINUXPATCH");

            entity.HasIndex(e => e.Patchid, "IDX_LINUXPATCHID");

            entity.Property(e => e.Assessedmachinestateid).HasColumnName("ASSESSEDMACHINESTATEID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Installstateid).HasColumnName("INSTALLSTATEID");
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Osid).HasColumnName("OSID");
            entity.Property(e => e.Patch)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("PATCH");
            entity.Property(e => e.Patchid).HasColumnName("PATCHID");
            entity.Property(e => e.Scandate)
                .HasColumnType("datetime")
                .HasColumnName("SCANDATE");
        });

        modelBuilder.Entity<XtrLinuxDistinctDeployed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xtrLinuxDistinctDeployed");

            entity.Property(e => e.Deployedon)
                .HasColumnType("datetime")
                .HasColumnName("DEPLOYEDON");
            entity.Property(e => e.M)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Machineid).HasColumnName("MACHINEID");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
