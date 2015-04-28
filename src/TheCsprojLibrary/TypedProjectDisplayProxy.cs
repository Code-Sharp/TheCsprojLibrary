using TheCsprojLibrary.ItemTypes;

namespace TheCsprojLibrary
{
    public class TypedProjectDisplayProxy
    {
        public TypedProjectDisplayProxy(TypedProject original)
        {
            References = original.References;
            Compiles = original.Compiles;
            Nones = original.Nones;
            ProjectReferences = original.ProjectReferences;
            Contents = original.Contents;
            _OutputPathItems = original._OutputPathItems;
            _UnmanagedRegistrationCaches = original._UnmanagedRegistrationCaches;
            _ResolveComReferenceCaches = original._ResolveComReferenceCaches;
            AppConfigFileDestinations = original.AppConfigFileDestinations;
            IntermediateAssemblies = original.IntermediateAssemblies;
            _DebugSymbolsIntermediatePaths = original._DebugSymbolsIntermediatePaths;
            _DebugSymbolsOutputPaths = original._DebugSymbolsOutputPaths;
            _DeploymentManifestEntryPoints = original._DeploymentManifestEntryPoints;
            ApplicationManifests = original.ApplicationManifests;
            _ApplicationManifestFinals = original._ApplicationManifestFinals;
            DeployManifests = original.DeployManifests;
            BuiltProjectOutputGroupKeyOutputs = original.BuiltProjectOutputGroupKeyOutputs;
            DebugSymbolsProjectOutputGroupOutputs = original.DebugSymbolsProjectOutputGroupOutputs;
            AvailableItemNames = original.AvailableItemNames;
            Cleans = original.Cleans;
            XamlBuildTaskTypeGenerationExtensionNames = original.XamlBuildTaskTypeGenerationExtensionNames;
            _ExplicitReferences = original._ExplicitReferences;
            WCFMetadatas = original.WCFMetadatas;
            ServiceReferenceMetadataStorages = original.ServiceReferenceMetadataStorages;
            _WPPSupportsCollection = original._WPPSupportsCollection;
            _IISApplicationPools = original._IISApplicationPools;
            _MSDeployPackageFiles = original._MSDeployPackageFiles;
            _MSDeployArchiveDirs = original._MSDeployArchiveDirs;
            _MSDeployPackageLocations = original._MSDeployPackageLocations;
            WebPublishExtnsionsToExcludeItems = original.WebPublishExtnsionsToExcludeItems;
            Folders = original.Folders;
            EmbeddedResources = original.EmbeddedResources;
            Services = original.Services;
            FxCopRuleAssemblies = original.FxCopRuleAssemblies;
            ApplicationDefinitions = original.ApplicationDefinitions;
            TypeScriptCompiles = original.TypeScriptCompiles;
            ProjectCapabilities = original.ProjectCapabilities;
            BootstrapperPackages = original.BootstrapperPackages;
            DocFileItems = original.DocFileItems;
            FinalDocFiles = original.FinalDocFiles;
            DocumentationProjectOutputGroupOutputs = original.DocumentationProjectOutputGroupOutputs;
            Pages = original.Pages;
            Resources = original.Resources;
            _IntermediateOutputPathItems = original._IntermediateOutputPathItems;
            PackageSourcesCollection = original.PackageSourcesCollection;
            AppDesigners = original.AppDesigners;
            AppxHashUris = original.AppxHashUris;
            AppxSystemBinaries = original.AppxSystemBinaries;
            AppxReservedFileNames = original.AppxReservedFileNames;
            AppxManifestFileNameQueries = original.AppxManifestFileNameQueries;
            AppxManifestImageFileNameQueries = original.AppxManifestImageFileNameQueries;
            AppxManifestMetadatas = original.AppxManifestMetadatas;
            AppxManifestMetaDatas = original.AppxManifestMetaDatas;
            PlatformVersionDescriptions = original.PlatformVersionDescriptions;
            XamlIntermediateAssemblies = original.XamlIntermediateAssemblies;
            SDKReferences = original.SDKReferences;
            AppxManifests = original.AppxManifests;
            UpToDateCheckOutputs = original.UpToDateCheckOutputs;
            BundleResources = original.BundleResources;
            EntityDeploys = original.EntityDeploys;
            _DeploymentManifestIconFiles = original._DeploymentManifestIconFiles;
            TargetPlatforms = original.TargetPlatforms;
            PropertyPageSchemas = original.PropertyPageSchemas;
            PackageFiles = original.PackageFiles;
            WCFMetadataStorages = original.WCFMetadataStorages;
            MSBuildToolsVersion = original.MSBuildToolsVersion;
            MSBuildToolsPath = original.MSBuildToolsPath;
            MSBuildBinPath = original.MSBuildBinPath;
            MSBuildStartupDirectory = original.MSBuildStartupDirectory;
            MSBuildNodeCount = original.MSBuildNodeCount;
            MSBuildProgramFiles32 = original.MSBuildProgramFiles32;
            MSBuildProjectFile = original.MSBuildProjectFile;
            MSBuildProjectName = original.MSBuildProjectName;
            MSBuildProjectExtension = original.MSBuildProjectExtension;
            MSBuildProjectFullPath = original.MSBuildProjectFullPath;
            MSBuildProjectDirectory = original.MSBuildProjectDirectory;
            MSBuildProjectDirectoryNoRoot = original.MSBuildProjectDirectoryNoRoot;
            MSBuildExtensionsPath32 = original.MSBuildExtensionsPath32;
            MSBuildExtensionsPath64 = original.MSBuildExtensionsPath64;
            MSBuildExtensionsPath = original.MSBuildExtensionsPath;
            LOCALAPPDATA = original.LOCALAPPDATA;
            MSBuildUserExtensionsPath = original.MSBuildUserExtensionsPath;
            ALLUSERSPROFILE = original.ALLUSERSPROFILE;
            APPDATA = original.APPDATA;
            CommonProgramFiles = original.CommonProgramFiles;
            CommonProgramW6432 = original.CommonProgramW6432;
            COMPUTERNAME = original.COMPUTERNAME;
            ComSpec = original.ComSpec;
            configsetroot = original.configsetroot;
            FP_NO_HOST_CHECK = original.FP_NO_HOST_CHECK;
            HOMEDRIVE = original.HOMEDRIVE;
            HOMEPATH = original.HOMEPATH;
            JAVA_HOME = original.JAVA_HOME;
            LOGONSERVER = original.LOGONSERVER;
            MSBuildLoadMicrosoftTargetsReadOnly = original.MSBuildLoadMicrosoftTargetsReadOnly;
            NUMBER_OF_PROCESSORS = original.NUMBER_OF_PROCESSORS;
            OS = original.OS;
            Path = original.Path;
            PATHEXT = original.PATHEXT;
            PkgDefApplicationConfigFile = original.PkgDefApplicationConfigFile;
            PROCESSOR_ARCHITECTURE = original.PROCESSOR_ARCHITECTURE;
            PROCESSOR_ARCHITEW6432 = original.PROCESSOR_ARCHITEW6432;
            PROCESSOR_IDENTIFIER = original.PROCESSOR_IDENTIFIER;
            PROCESSOR_LEVEL = original.PROCESSOR_LEVEL;
            PROCESSOR_REVISION = original.PROCESSOR_REVISION;
            ProgramData = original.ProgramData;
            ProgramFiles = original.ProgramFiles;
            ProgramW6432 = original.ProgramW6432;
            PSModulePath = original.PSModulePath;
            PUBLIC = original.PUBLIC;
            SystemDrive = original.SystemDrive;
            SystemRoot = original.SystemRoot;
            TEMP = original.TEMP;
            TMP = original.TMP;
            UOIPME_REG_PATH = original.UOIPME_REG_PATH;
            USERDOMAIN = original.USERDOMAIN;
            USERDOMAIN_ROAMINGPROFILE = original.USERDOMAIN_ROAMINGPROFILE;
            USERNAME = original.USERNAME;
            USERPROFILE = original.USERPROFILE;
            VisualStudioDir = original.VisualStudioDir;
            VisualStudioEdition = original.VisualStudioEdition;
            VisualStudioVersion = original.VisualStudioVersion;
            VS110COMNTOOLS = original.VS110COMNTOOLS;
            VS120COMNTOOLS = original.VS120COMNTOOLS;
            VS140COMNTOOLS = original.VS140COMNTOOLS;
            VSLANG = original.VSLANG;
            windir = original.windir;
            SDK35ToolsPath = original.SDK35ToolsPath;
            MSBuildToolsPath32 = original.MSBuildToolsPath32;
            MSBuildToolsRoot = original.MSBuildToolsRoot;
            FrameworkSDKRoot = original.FrameworkSDKRoot;
            MSBuildRuntimeVersion = original.MSBuildRuntimeVersion;
            SDK40ToolsPath = original.SDK40ToolsPath;
            Configuration = original.Configuration;
            MSBuildProjectDefaultTargets = original.MSBuildProjectDefaultTargets;
            Platform = original.Platform;
            ProjectGuid = original.ProjectGuid;
            OutputType = original.OutputType;
            AppDesignerFolder = original.AppDesignerFolder;
            RootNamespace = original.RootNamespace;
            AssemblyName = original.AssemblyName;
            TargetFrameworkVersion = original.TargetFrameworkVersion;
            FileAlignment = original.FileAlignment;
            SolutionDir = original.SolutionDir;
            RestorePackages = original.RestorePackages;
            PlatformTarget = original.PlatformTarget;
            DebugSymbols = original.DebugSymbols;
            DebugType = original.DebugType;
            Optimize = original.Optimize;
            OutputPath = original.OutputPath;
            DefineConstants = original.DefineConstants;
            ErrorReport = original.ErrorReport;
            WarningLevel = original.WarningLevel;
            ImportByWildcardBeforeMicrosoftCSharpTargets = original.ImportByWildcardBeforeMicrosoftCSharpTargets;
            ImportByWildcardAfterMicrosoftCSharpTargets = original.ImportByWildcardAfterMicrosoftCSharpTargets;
            ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets = original.ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets;
            ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets = original.ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets;
            CustomBeforeMicrosoftCSharpTargets = original.CustomBeforeMicrosoftCSharpTargets;
            CustomAfterMicrosoftCSharpTargets = original.CustomAfterMicrosoftCSharpTargets;
            MSBuildAllProjects = original.MSBuildAllProjects;
            DefaultLanguageSourceExtension = original.DefaultLanguageSourceExtension;
            Language = original.Language;
            TargetRuntime = original.TargetRuntime;
            CreateManifestResourceNamesDependsOn = original.CreateManifestResourceNamesDependsOn;
            UseHostCompilerIfAvailable = original.UseHostCompilerIfAvailable;
            CoreCompileDependsOn = original.CoreCompileDependsOn;
            ImportByWildcardBeforeMicrosoftCommonTargets = original.ImportByWildcardBeforeMicrosoftCommonTargets;
            ImportByWildcardAfterMicrosoftCommonTargets = original.ImportByWildcardAfterMicrosoftCommonTargets;
            ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets = original.ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets;
            ImportUserLocationsByWildcardAfterMicrosoftCommonTargets = original.ImportUserLocationsByWildcardAfterMicrosoftCommonTargets;
            CustomBeforeMicrosoftCommonTargets = original.CustomBeforeMicrosoftCommonTargets;
            CustomAfterMicrosoftCommonTargets = original.CustomAfterMicrosoftCommonTargets;
            ReportingServicesTargets = original.ReportingServicesTargets;
            TargetFrameworkIdentifier = original.TargetFrameworkIdentifier;
            AvailablePlatforms = original.AvailablePlatforms;
            ImportByWildcardBeforeMicrosoftNetFrameworkProps = original.ImportByWildcardBeforeMicrosoftNetFrameworkProps;
            ImportByWildcardAfterMicrosoftNetFrameworkProps = original.ImportByWildcardAfterMicrosoftNetFrameworkProps;
            ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps = original.ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps;
            ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps = original.ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps;
            UpgradeSubsetToProfile = original.UpgradeSubsetToProfile;
            AddAdditionalExplicitAssemblyReferences = original.AddAdditionalExplicitAssemblyReferences;
            AdditionalExplicitAssemblyReferences = original.AdditionalExplicitAssemblyReferences;
            TargetFrameworkSDKToolsDirectory = original.TargetFrameworkSDKToolsDirectory;
            TargetedRuntimeVersion = original.TargetedRuntimeVersion;
            Prefer32Bit = original.Prefer32Bit;
            HighEntropyVA = original.HighEntropyVA;
            SubsystemVersion = original.SubsystemVersion;
            ImplicitlyExpandDesignTimeFacades = original.ImplicitlyExpandDesignTimeFacades;
            YieldDuringToolExecution = original.YieldDuringToolExecution;
            TargetFrameworkMoniker = original.TargetFrameworkMoniker;
            FrameworkPathOverride = original.FrameworkPathOverride;
            TargetPlatformIdentifier = original.TargetPlatformIdentifier;
            TargetPlatformVersion = original.TargetPlatformVersion;
            TargetPlatformSdkPath = original.TargetPlatformSdkPath;
            TargetPlatformMoniker = original.TargetPlatformMoniker;
            _OriginalConfiguration = original._OriginalConfiguration;
            _OriginalPlatform = original._OriginalPlatform;
            ConfigurationName = original.ConfigurationName;
            _DebugSymbolsProduced = original._DebugSymbolsProduced;
            _DocumentationFileProduced = original._DocumentationFileProduced;
            TargetExt = original.TargetExt;
            OutDir = original.OutDir;
            ProjectName = original.ProjectName;
            TargetName = original.TargetName;
            ProjectFileName = original.ProjectFileName;
            ProjectExt = original.ProjectExt;
            TargetFileName = original.TargetFileName;
            _DeploymentPublishableProjectDefault = original._DeploymentPublishableProjectDefault;
            PublishableProject = original.PublishableProject;
            _DeploymentTargetApplicationManifestFileName = original._DeploymentTargetApplicationManifestFileName;
            TargetDeployManifestFileName = original.TargetDeployManifestFileName;
            GenerateClickOnceManifests = original.GenerateClickOnceManifests;
            _DeploymentApplicationManifestIdentity = original._DeploymentApplicationManifestIdentity;
            _DeploymentDeployManifestIdentity = original._DeploymentDeployManifestIdentity;
            _DeploymentFileMappingExtension = original._DeploymentFileMappingExtension;
            _DeploymentBuiltUpdateInterval = original._DeploymentBuiltUpdateInterval;
            _DeploymentBuiltUpdateIntervalUnits = original._DeploymentBuiltUpdateIntervalUnits;
            MaxTargetPath = original.MaxTargetPath;
            TargetCulture = original.TargetCulture;
            TargetDir = original.TargetDir;
            TargetPath = original.TargetPath;
            ProjectDir = original.ProjectDir;
            ProjectPath = original.ProjectPath;
            PlatformName = original.PlatformName;
            DevEnvDir = original.DevEnvDir;
            SolutionName = original.SolutionName;
            SolutionFileName = original.SolutionFileName;
            SolutionPath = original.SolutionPath;
            SolutionExt = original.SolutionExt;
            AutoUnifyAssemblyReferences = original.AutoUnifyAssemblyReferences;
            BaseIntermediateOutputPath = original.BaseIntermediateOutputPath;
            CleanFile = original.CleanFile;
            BuildProjectReferences = original.BuildProjectReferences;
            BuildInParallel = original.BuildInParallel;
            _ResolveReferenceDependencies = original._ResolveReferenceDependencies;
            _GetChildProjectCopyToOutputDirectoryItems = original._GetChildProjectCopyToOutputDirectoryItems;
            OverwriteReadOnlyFiles = original.OverwriteReadOnlyFiles;
            ComReferenceNoClassMembers = original.ComReferenceNoClassMembers;
            IntermediateOutputPath = original.IntermediateOutputPath;
            _DeploymentUrl = original._DeploymentUrl;
            PublishDir = original.PublishDir;
            ProcessorArchitecture = original.ProcessorArchitecture;
            ConsiderPlatformAsProcessorArchitecture = original.ConsiderPlatformAsProcessorArchitecture;
            TargetFrameworkAsMSBuildRuntime = original.TargetFrameworkAsMSBuildRuntime;
            PlatformTargetAsMSBuildArchitectureExplicitlySet = original.PlatformTargetAsMSBuildArchitectureExplicitlySet;
            PlatformTargetAsMSBuildArchitecture = original.PlatformTargetAsMSBuildArchitecture;
            ProjectFlavor = original.ProjectFlavor;
            DelaySign = original.DelaySign;
            WebReference_EnableProperties = original.WebReference_EnableProperties;
            WebReference_EnableSQLTypes = original.WebReference_EnableSQLTypes;
            WebReference_EnableLegacyEventingModel = original.WebReference_EnableLegacyEventingModel;
            AssemblyFoldersSuffix = original.AssemblyFoldersSuffix;
            FrameworkRegistryBase = original.FrameworkRegistryBase;
            TargetPlatformRegistryBase = original.TargetPlatformRegistryBase;
            AssemblySearchPaths = original.AssemblySearchPaths;
            AllowedReferenceAssemblyFileExtensions = original.AllowedReferenceAssemblyFileExtensions;
            AllowedReferenceRelatedFileExtensions = original.AllowedReferenceRelatedFileExtensions;
            FullReferenceAssemblyNames = original.FullReferenceAssemblyNames;
            ContinueOnError = original.ContinueOnError;
            BuildDependsOn = original.BuildDependsOn;
            CoreBuildDependsOn = original.CoreBuildDependsOn;
            _ProjectDefaultTargets = original._ProjectDefaultTargets;
            RebuildDependsOn = original.RebuildDependsOn;
            BuildGenerateSourcesAction = original.BuildGenerateSourcesAction;
            BuildCompileAction = original.BuildCompileAction;
            BuildLinkAction = original.BuildLinkAction;
            RunDependsOn = original.RunDependsOn;
            BuildingProject = original.BuildingProject;
            PrepareForBuildDependsOn = original.PrepareForBuildDependsOn;
            Framework40Dir = original.Framework40Dir;
            Framework35Dir = original.Framework35Dir;
            Framework30Dir = original.Framework30Dir;
            Framework20Dir = original.Framework20Dir;
            FrameworkDir = original.FrameworkDir;
            TargetedFrameworkDir = original.TargetedFrameworkDir;
            FrameworkSDKDir = original.FrameworkSDKDir;
            GetFrameworkPathsDependsOn = original.GetFrameworkPathsDependsOn;
            PreBuildEventDependsOn = original.PreBuildEventDependsOn;
            UnmanagedUnregistrationDependsOn = original.UnmanagedUnregistrationDependsOn;
            ResolveReferencesDependsOn = original.ResolveReferencesDependsOn;
            GetTargetPathDependsOn = original.GetTargetPathDependsOn;
            ResolveAssemblyReferencesDependsOn = original.ResolveAssemblyReferencesDependsOn;
            SDKReferenceRegistryRoot = original.SDKReferenceRegistryRoot;
            SDKReferenceDirectoryRoot = original.SDKReferenceDirectoryRoot;
            ResolveSDKReferencesDependsOn = original.ResolveSDKReferencesDependsOn;
            TargetedSDKConfiguration = original.TargetedSDKConfiguration;
            TargetedSDKArchitecture = original.TargetedSDKArchitecture;
            ExpandSDKReferencesDependsOn = original.ExpandSDKReferencesDependsOn;
            ExpandSDKAllowedReferenceExtensions = original.ExpandSDKAllowedReferenceExtensions;
            ProjectDesignTimeAssemblyResolutionSearchPaths = original.ProjectDesignTimeAssemblyResolutionSearchPaths;
            DesignTimeResolveAssemblyReferencesDependsOn = original.DesignTimeResolveAssemblyReferencesDependsOn;
            ComReferenceExecuteAsTool = original.ComReferenceExecuteAsTool;
            PrepareResourcesDependsOn = original.PrepareResourcesDependsOn;
            PrepareResourceNamesDependsOn = original.PrepareResourceNamesDependsOn;
            AssignTargetPathsDependsOn = original.AssignTargetPathsDependsOn;
            CreateCustomManifestResourceNamesDependsOn = original.CreateCustomManifestResourceNamesDependsOn;
            ResGenDependsOn = original.ResGenDependsOn;
            CoreResGenDependsOn = original.CoreResGenDependsOn;
            UseSourcePath = original.UseSourcePath;
            ResGenExecuteAsTool = original.ResGenExecuteAsTool;
            CompileLicxFilesDependsOn = original.CompileLicxFilesDependsOn;
            CompileDependsOn = original.CompileDependsOn;
            TargetFrameworkMonikerAssemblyAttributesPath = original.TargetFrameworkMonikerAssemblyAttributesPath;
            GenerateTargetFrameworkAttribute = original.GenerateTargetFrameworkAttribute;
            _SGenDllName = original._SGenDllName;
            _SGenDllCreated = original._SGenDllCreated;
            _SGenGenerateSerializationAssembliesConfig = original._SGenGenerateSerializationAssembliesConfig;
            SGenUseProxyTypes = original.SGenUseProxyTypes;
            SGenShouldGenerateSerializer = original.SGenShouldGenerateSerializer;
            CreateSatelliteAssembliesDependsOn = original.CreateSatelliteAssembliesDependsOn;
            ComputeIntermediateSatelliteAssembliesDependsOn = original.ComputeIntermediateSatelliteAssembliesDependsOn;
            EmbeddedWin32Manifest = original.EmbeddedWin32Manifest;
            GenerateManifestsDependsOn = original.GenerateManifestsDependsOn;
            SkipCopyUnchangedFiles = original.SkipCopyUnchangedFiles;
            UseCommonOutputDirectory = original.UseCommonOutputDirectory;
            PrepareForRunDependsOn = original.PrepareForRunDependsOn;
            CreateHardLinksForCopyAdditionalFilesIfPossible = original.CreateHardLinksForCopyAdditionalFilesIfPossible;
            GetCopyToOutputDirectoryItemsDependsOn = original.GetCopyToOutputDirectoryItemsDependsOn;
            UnmanagedRegistrationDependsOn = original.UnmanagedRegistrationDependsOn;
            CleanDependsOn = original.CleanDependsOn;
            CoreCleanDependsOn = original.CoreCleanDependsOn;
            PostBuildEventDependsOn = original.PostBuildEventDependsOn;
            PublishDependsOn = original.PublishDependsOn;
            PublishOnlyDependsOn = original.PublishOnlyDependsOn;
            PublishBuildDependsOn = original.PublishBuildDependsOn;
            BuiltProjectOutputGroupDependsOn = original.BuiltProjectOutputGroupDependsOn;
            AddAppConfigToBuildOutputs = original.AddAppConfigToBuildOutputs;
            DebugSymbolsProjectOutputGroupDependsOn = original.DebugSymbolsProjectOutputGroupDependsOn;
            DocumentationProjectOutputGroupDependsOn = original.DocumentationProjectOutputGroupDependsOn;
            SatelliteDllsProjectOutputGroupDependsOn = original.SatelliteDllsProjectOutputGroupDependsOn;
            SourceFilesProjectOutputGroupDependsOn = original.SourceFilesProjectOutputGroupDependsOn;
            ContentFilesProjectOutputGroupDependsOn = original.ContentFilesProjectOutputGroupDependsOn;
            SGenFilesOutputGroupDependsOn = original.SGenFilesOutputGroupDependsOn;
            SDKRedistOutputGroupDependsOn = original.SDKRedistOutputGroupDependsOn;
            CodeAnalysisTargets = original.CodeAnalysisTargets;
            CodeAnalysisStaticAnalysisDirectory = original.CodeAnalysisStaticAnalysisDirectory;
            CodeAnalysisRuleSetDirectories = original.CodeAnalysisRuleSetDirectories;
            CodeAnalysisPath = original.CodeAnalysisPath;
            CodeAnalysisApplyLogFileXsl = original.CodeAnalysisApplyLogFileXsl;
            CodeAnalysisFailOnMissingRules = original.CodeAnalysisFailOnMissingRules;
            CodeAnalysisForceOutput = original.CodeAnalysisForceOutput;
            CodeAnalysisGenerateSuccessFile = original.CodeAnalysisGenerateSuccessFile;
            CodeAnalysisIgnoreGeneratedCode = original.CodeAnalysisIgnoreGeneratedCode;
            CodeAnalysisIgnoreInvalidTargets = original.CodeAnalysisIgnoreInvalidTargets;
            CodeAnalysisIgnoreMissingIndirectReferences = original.CodeAnalysisIgnoreMissingIndirectReferences;
            CodeAnalysisInputAssembly = original.CodeAnalysisInputAssembly;
            CodeAnalysisLogFile = original.CodeAnalysisLogFile;
            CodeAnalysisModuleSuppressionsFile = original.CodeAnalysisModuleSuppressionsFile;
            CodeAnalysisOverrideRuleVisibilities = original.CodeAnalysisOverrideRuleVisibilities;
            CodeAnalysisOutputToConsole = original.CodeAnalysisOutputToConsole;
            CodeAnalysisQuiet = original.CodeAnalysisQuiet;
            CodeAnalysisRuleDirectories = original.CodeAnalysisRuleDirectories;
            CodeAnalysisSaveMessagesToReport = original.CodeAnalysisSaveMessagesToReport;
            CodeAnalysisSearchGlobalAssemblyCache = original.CodeAnalysisSearchGlobalAssemblyCache;
            CodeAnalysisSucceededFile = original.CodeAnalysisSucceededFile;
            CodeAnalysisSummary = original.CodeAnalysisSummary;
            CodeAnalysisTimeout = original.CodeAnalysisTimeout;
            CodeAnalysisTreatWarningsAsErrors = original.CodeAnalysisTreatWarningsAsErrors;
            CodeAnalysisUpdateProject = original.CodeAnalysisUpdateProject;
            CodeAnalysisUseTypeNameInSuppression = original.CodeAnalysisUseTypeNameInSuppression;
            CodeAnalysisVerbose = original.CodeAnalysisVerbose;
            CodeAnalysisRuleSet = original.CodeAnalysisRuleSet;
            RunCodeAnalysisDependsOn = original.RunCodeAnalysisDependsOn;
            RunCodeAnalysisInputs = original.RunCodeAnalysisInputs;
            RunNativeCodeAnalysisInputs = original.RunNativeCodeAnalysisInputs;
            MergedOutputCodeAnalysisFile = original.MergedOutputCodeAnalysisFile;
            CompileRdlFilesDependsOn = original.CompileRdlFilesDependsOn;
            ImportByWildcardBeforeMicrosoftNetFrameworkTargets = original.ImportByWildcardBeforeMicrosoftNetFrameworkTargets;
            ImportByWildcardAfterMicrosoftNetFrameworkTargets = original.ImportByWildcardAfterMicrosoftNetFrameworkTargets;
            ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets = original.ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets;
            ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets = original.ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets;
            ImplicitlyExpandDesignTimeFacadesDependsOn = original.ImplicitlyExpandDesignTimeFacadesDependsOn;
            BuildSystem = original.BuildSystem;
            TaskVersion = original.TaskVersion;
            TaskKeyToken = original.TaskKeyToken;
            BuildTaskAssembly = original.BuildTaskAssembly;
            AlwaysCompileMarkupFilesInSeparateDomain = original.AlwaysCompileMarkupFilesInSeparateDomain;
            LocalizationDirectivesToLocFile = original.LocalizationDirectivesToLocFile;
            GetReferenceAssemblyPathsDependsOn = original.GetReferenceAssemblyPathsDependsOn;
            XamlDebuggingInformation = original.XamlDebuggingInformation;
            HostInBrowser = original.HostInBrowser;
            Version = original.Version;
            DeploymentType = original.DeploymentType;
            RunAfterInstall = original.RunAfterInstall;
            GeneratedFileExtension = original.GeneratedFileExtension;
            OSVersion = original.OSVersion;
            _RequireMCPass2ForSatelliteAssemblyOnly = original._RequireMCPass2ForSatelliteAssemblyOnly;
            _RequireMCPass2ForMainAssembly = original._RequireMCPass2ForMainAssembly;
            IsApplication = original.IsApplication;
            _AfterCompileWinFXInternalDependsOn = original._AfterCompileWinFXInternalDependsOn;
            MarkupCompilePass2ForMainAssemblyDependsOn = original.MarkupCompilePass2ForMainAssemblyDependsOn;
            _CompileTargetNameForLocalType = original._CompileTargetNameForLocalType;
            _ResourceNameInMainAssembly = original._ResourceNameInMainAssembly;
            EntityDeployIntermediateResourcePath = original.EntityDeployIntermediateResourcePath;
            EntityDeployDependsOn = original.EntityDeployDependsOn;
            LoadTimeSensitiveTargets = original.LoadTimeSensitiveTargets;
            LoadTimeSensitiveProperties = original.LoadTimeSensitiveProperties;
            XamlBuildTaskAssemblyName = original.XamlBuildTaskAssemblyName;
            XamlRequiresCompilationPass2 = original.XamlRequiresCompilationPass2;
            XamlTemporaryAssemblyName = original.XamlTemporaryAssemblyName;
            CompileTargetNameForTemporaryAssembly = original.CompileTargetNameForTemporaryAssembly;
            XamlBuildTaskLocation = original.XamlBuildTaskLocation;
            XamlGenCodeFileNames = original.XamlGenCodeFileNames;
            XamlGenMarkupFileNames = original.XamlGenMarkupFileNames;
            XamlPass2FlagFile = original.XamlPass2FlagFile;
            DesignTimeIntermediateOutputPath = original.DesignTimeIntermediateOutputPath;
            WorkflowBuildExtensionVersion = original.WorkflowBuildExtensionVersion;
            WorkflowBuildExtensionKeyToken = original.WorkflowBuildExtensionKeyToken;
            WorkflowBuildExtensionAssemblyName = original.WorkflowBuildExtensionAssemblyName;
            GenerateCompiledExpressionsTempFilePathForEditing = original.GenerateCompiledExpressionsTempFilePathForEditing;
            GenerateCompiledExpressionsTempFilePathForValidation = original.GenerateCompiledExpressionsTempFilePathForValidation;
            GenerateCompiledExpressionsTempFilePathForTypeInfer = original.GenerateCompiledExpressionsTempFilePathForTypeInfer;
            DeferredValidationErrorsFileName = original.DeferredValidationErrorsFileName;
            MsTestToolsTargets = original.MsTestToolsTargets;
            MsAppxPackageTargets = original.MsAppxPackageTargets;
            Utf8Output = original.Utf8Output;
            NoCompilerStandardLib = original.NoCompilerStandardLib;
            BuildPackage = original.BuildPackage;
            RequireRestoreConsent = original.RequireRestoreConsent;
            DownloadNuGetExe = original.DownloadNuGetExe;
            NuGetToolsPath = original.NuGetToolsPath;
            PackagesConfig = original.PackagesConfig;
            NuGetExePath = original.NuGetExePath;
            PackageSources = original.PackageSources;
            NuGetCommand = original.NuGetCommand;
            PackageOutputDir = original.PackageOutputDir;
            RequireConsentSwitch = original.RequireConsentSwitch;
            RestoreCommand = original.RestoreCommand;
            BuildCommand = original.BuildCommand;
            ProcessorArchitectureAsPlatform = original.ProcessorArchitectureAsPlatform;
            IsLibrary = original.IsLibrary;
            ProductVersion = original.ProductVersion;
            SchemaVersion = original.SchemaVersion;
            ProjectTypeGuids = original.ProjectTypeGuids;
            UseIISExpress = original.UseIISExpress;
            IISExpressSSLPort = original.IISExpressSSLPort;
            IISExpressAnonymousAuthentication = original.IISExpressAnonymousAuthentication;
            IISExpressWindowsAuthentication = original.IISExpressWindowsAuthentication;
            IISExpressUseClassicPipelineMode = original.IISExpressUseClassicPipelineMode;
            VSToolsPath = original.VSToolsPath;
            WebProjectOutputDirInsideProjectDefault = original.WebProjectOutputDirInsideProjectDefault;
            WebProjectOutputDirInsideProject = original.WebProjectOutputDirInsideProject;
            DisableLinkInCopyWebApplicaton = original.DisableLinkInCopyWebApplicaton;
            Disable_CopyWebApplication = original.Disable_CopyWebApplication;
            UseWPP_CopyWebApplication = original.UseWPP_CopyWebApplication;
            CleanWebProjectOutputDir = original.CleanWebProjectOutputDir;
            WebProjectOutputDir = original.WebProjectOutputDir;
            CleanWebProjectOutputDirDependsOn = original.CleanWebProjectOutputDirDependsOn;
            OnBefore_CopyWebApplicationDefault = original.OnBefore_CopyWebApplicationDefault;
            OnBefore_CopyWebApplication = original.OnBefore_CopyWebApplication;
            OnAfter_CopyWebApplication = original.OnAfter_CopyWebApplication;
            _CopyWebApplicationDependsOn = original._CopyWebApplicationDependsOn;
            ImportByWildcardBeforeMicrosoftWebPublishingTargets = original.ImportByWildcardBeforeMicrosoftWebPublishingTargets;
            _WPPVersion = original._WPPVersion;
            _WPPSupports = original._WPPSupports;
            _WPPWebPublishMethodSupports = original._WPPWebPublishMethodSupports;
            WebPublishPipelineProjectDirectory = original.WebPublishPipelineProjectDirectory;
            WebPublishPipelineSourceRootDirectory = original.WebPublishPipelineSourceRootDirectory;
            WebPublishPipelineTransformRootDirectory = original.WebPublishPipelineTransformRootDirectory;
            WebPublishPipelineProjectName = original.WebPublishPipelineProjectName;
            WebPublishPipelineProjectFile = original.WebPublishPipelineProjectFile;
            WebPublishPipeLineProjectFullPath = original.WebPublishPipeLineProjectFullPath;
            WebPublishPipelineWAPProjectSettings = original.WebPublishPipelineWAPProjectSettings;
            VerifyDatabaseSettingWithImport = original.VerifyDatabaseSettingWithImport;
            _LocalDBVersionToUseForSqlExpress = original._LocalDBVersionToUseForSqlExpress;
            _PublishProfileSet = original._PublishProfileSet;
            EnableWebPublishProfileFile = original.EnableWebPublishProfileFile;
            _WPPDefaultIntermediateOutputPath = original._WPPDefaultIntermediateOutputPath;
            _WPPDefaultIntermediateOutputFullPath = original._WPPDefaultIntermediateOutputFullPath;
            PublishProfileRootFolder = original.PublishProfileRootFolder;
            PublishProfileName = original.PublishProfileName;
            _WebPublishProfileFileWillBeImported = original._WebPublishProfileFileWillBeImported;
            WebPublishPipelineCustomizeTargetFile = original.WebPublishPipelineCustomizeTargetFile;
            WebPublishPipelineSolutionTargetFile = original.WebPublishPipelineSolutionTargetFile;
            _WPPCleanTargets = original._WPPCleanTargets;
            FilesToIncludeForPublish = original.FilesToIncludeForPublish;
            AlternativeProjectDirectory = original.AlternativeProjectDirectory;
            ExcludeGeneratedDebugSymbol = original.ExcludeGeneratedDebugSymbol;
            ExcludeXmlAssemblyFiles = original.ExcludeXmlAssemblyFiles;
            ExcludeApp_Data = original.ExcludeApp_Data;
            SkipApp_DataFolder = original.SkipApp_DataFolder;
            UseMsdeployExe = original.UseMsdeployExe;
            EnableCollectLinkFilesInProject = original.EnableCollectLinkFilesInProject;
            ExcludeLinkFilesInProject = original.ExcludeLinkFilesInProject;
            CleanWPPAllFilesInSingleFolder = original.CleanWPPAllFilesInSingleFolder;
            IncludeIisSettings = original.IncludeIisSettings;
            ExcludeFilesFromPackage = original.ExcludeFilesFromPackage;
            ImportParametersFiles = original.ImportParametersFiles;
            ImportParametersFile_DisableEscapeMSBuildVariable = original.ImportParametersFile_DisableEscapeMSBuildVariable;
            ImportProjectParametersFiles = original.ImportProjectParametersFiles;
            ImportProfileParametersFiles = original.ImportProfileParametersFiles;
            ImportPublishingParameterValues = original.ImportPublishingParameterValues;
            EnableOptimisticParameterDefaultValue = original.EnableOptimisticParameterDefaultValue;
            ParameterApplicationPool = original.ParameterApplicationPool;
            IIS6ParameterApplicationPool = original.IIS6ParameterApplicationPool;
            DisableAllVSGeneratedMSDeployParameter = original.DisableAllVSGeneratedMSDeployParameter;
            AutoParameterizationWebConfigConnectionStrings = original.AutoParameterizationWebConfigConnectionStrings;
            AutoParameterizationWebConfigCSNoDefaultValue = original.AutoParameterizationWebConfigCSNoDefaultValue;
            AutoParameterizationWebConfigConnectionStringsIntermediateOutput = original.AutoParameterizationWebConfigConnectionStringsIntermediateOutput;
            AutoParameterizationWebConfigConnectionStringsLocation = original.AutoParameterizationWebConfigConnectionStringsLocation;
            _WPPLastBuildInfoIntermediateOutput = original._WPPLastBuildInfoIntermediateOutput;
            _WPPLastBuildInfoLocation = original._WPPLastBuildInfoLocation;
            InsertAdditionalWebCofigConnectionStrings = original.InsertAdditionalWebCofigConnectionStrings;
            InsertAdditionalWebCofigConnectionStringsIntermediateOutput = original.InsertAdditionalWebCofigConnectionStringsIntermediateOutput;
            InsertAdditionalWebCofigConnectionStringsLocation = original.InsertAdditionalWebCofigConnectionStringsLocation;
            InsertAdditionalWebConfigConnectionStringProviderName = original.InsertAdditionalWebConfigConnectionStringProviderName;
            InsertAdditionalWebConfigConnectionStringOnlyInRoot = original.InsertAdditionalWebConfigConnectionStringOnlyInRoot;
            SqlScriptSourceTransacted = original.SqlScriptSourceTransacted;
            AutoSqlScriptSourceTransacted = original.AutoSqlScriptSourceTransacted;
            DatabaseDeployIntermediateRelativePath = original.DatabaseDeployIntermediateRelativePath;
            DatabaseDeployIntermediateOutputPath = original.DatabaseDeployIntermediateOutputPath;
            _WebConfigsToAutoParmeterizeCsTransformOutputParametersFile = original._WebConfigsToAutoParmeterizeCsTransformOutputParametersFile;
            DeployDefaultTarget = original.DeployDefaultTarget;
            DeployTarget = original.DeployTarget;
            RetryAttemptsForDeployment = original.RetryAttemptsForDeployment;
            DeployOnBuildDefault = original.DeployOnBuildDefault;
            DeployOnBuild = original.DeployOnBuild;
            EnableMSDeployBackup = original.EnableMSDeployBackup;
            EnableMSDeployAppOffline = original.EnableMSDeployAppOffline;
            MSDeployUseChecksum = original.MSDeployUseChecksum;
            MSDeployEnableWebConfigEncryptRule = original.MSDeployEnableWebConfigEncryptRule;
            MSDeployWebConfigEncryptProvider = original.MSDeployWebConfigEncryptProvider;
            _MSDeployUserAgentSource = original._MSDeployUserAgentSource;
            _MSDeployUserAgent = original._MSDeployUserAgent;
            PipelineDependsOnBuild = original.PipelineDependsOnBuild;
            _DeployOnBuild = original._DeployOnBuild;
            WPPCopyWebApplicaitonPipelineCircularDependencyError = original.WPPCopyWebApplicaitonPipelineCircularDependencyError;
            PipelineDependsOn = original.PipelineDependsOn;
            ProjectConfigFileName = original.ProjectConfigFileName;
            _ProjectConfigFileExtension = original._ProjectConfigFileExtension;
            _ProjectConfigFilePrefix = original._ProjectConfigFilePrefix;
            ProjectConfigTransformFileName = original.ProjectConfigTransformFileName;
            TransformWebConfigEnabled = original.TransformWebConfigEnabled;
            TransformWebConfigStackTraceEnabled = original.TransformWebConfigStackTraceEnabled;
            UseParameterizeToTransformWebConfig = original.UseParameterizeToTransformWebConfig;
            TransformWebConfigIntermediateOutput = original.TransformWebConfigIntermediateOutput;
            TransformWebConfigIntermediateLocation = original.TransformWebConfigIntermediateLocation;
            _WebConfigTransformOutputParametersFile = original._WebConfigTransformOutputParametersFile;
            ProfileTransformWebConfigEnabled = original.ProfileTransformWebConfigEnabled;
            ProfileTransformWebConfigStackTraceEnabled = original.ProfileTransformWebConfigStackTraceEnabled;
            UseParameterizeToProfileTransformWebConfig = original.UseParameterizeToProfileTransformWebConfig;
            ProfileTransformWebConfigIntermediateOutput = original.ProfileTransformWebConfigIntermediateOutput;
            ProfileTransformWebConfigIntermediateLocation = original.ProfileTransformWebConfigIntermediateLocation;
            _ProfileWebConfigTransformOutputParametersFile = original._ProfileWebConfigTransformOutputParametersFile;
            ParameterizeTransformXmlUseXPath = original.ParameterizeTransformXmlUseXPath;
            DefaultPackageOutputDir = original.DefaultPackageOutputDir;
            DefaultPackageFileName = original.DefaultPackageFileName;
            DefaultMSDeployDestinationSite = original.DefaultMSDeployDestinationSite;
            DefaultMsDeployAltSuffix = original.DefaultMsDeployAltSuffix;
            DefaultMSDeployDestinationApplicationName = original.DefaultMSDeployDestinationApplicationName;
            DefaultDeployIisAppPath = original.DefaultDeployIisAppPath;
            DefaultDeployIisRootAppPath = original.DefaultDeployIisRootAppPath;
            PackageAsSingleFile = original.PackageAsSingleFile;
            PackageLocation = original.PackageLocation;
            PackageFileName = original.PackageFileName;
            PackageArchiveRootDir = original.PackageArchiveRootDir;
            PackageTempRootDir = original.PackageTempRootDir;
            DeployAsIisApp = original.DeployAsIisApp;
            IncludeSetAclProviderOnDestination = original.IncludeSetAclProviderOnDestination;
            MarkApp_DataWritableOnDestination = original.MarkApp_DataWritableOnDestination;
            IgnoreDeployManagedRuntimeVersion = original.IgnoreDeployManagedRuntimeVersion;
            DeployDefaultTargetFrameworkVersion = original.DeployDefaultTargetFrameworkVersion;
            DeployManagedRuntimeVersion = original.DeployManagedRuntimeVersion;
            DeployEnable32bitAppOnWin64 = original.DeployEnable32bitAppOnWin64;
            DeployManagedPipelineMode = original.DeployManagedPipelineMode;
            GenerateSampleDeployScript = original.GenerateSampleDeployScript;
            PackageLogDir = original.PackageLogDir;
            EnablePackageProcessLoggingAndAssert = original.EnablePackageProcessLoggingAndAssert;
            PackageTraceLevel = original.PackageTraceLevel;
            _CreatePackage = original._CreatePackage;
            _UseDefaultLinkExtensionValue = original._UseDefaultLinkExtensionValue;
            PackageEnableLinks = original.PackageEnableLinks;
            PackageDisableLinks = original.PackageDisableLinks;
            ProjectParametersXMLFile = original.ProjectParametersXMLFile;
            EnableProjectDeployParameterPrefix = original.EnableProjectDeployParameterPrefix;
            DeployParameterIISAppName = original.DeployParameterIISAppName;
            DeployParameterIISAppPoolName = original.DeployParameterIISAppPoolName;
            DeployParameterApp_DataWritePermission = original.DeployParameterApp_DataWritePermission;
            DeployParameterIISAppPhysicalPath = original.DeployParameterIISAppPhysicalPath;
            DeployParameterAutoDescriptionbyTags = original.DeployParameterAutoDescriptionbyTags;
            DeployParameterIISAppNameDescription = original.DeployParameterIISAppNameDescription;
            DeployParameterIISAppPoolNameDescription = original.DeployParameterIISAppPoolNameDescription;
            DeployParameterIISAppPhysicalPathDescription = original.DeployParameterIISAppPhysicalPathDescription;
            DeployParameterIISAppConnectionStringDescription = original.DeployParameterIISAppConnectionStringDescription;
            DeployParameterSqlScriptVariablesDescription = original.DeployParameterSqlScriptVariablesDescription;
            MsDeployDatabaseTag = original.MsDeployDatabaseTag;
            MsDeploySqlCommandVariableKind = original.MsDeploySqlCommandVariableKind;
            MsdeploySqlUnsupportedCommand = original.MsdeploySqlUnsupportedCommand;
            CheckSqlScriptForUnsupportedCommands = original.CheckSqlScriptForUnsupportedCommands;
            UpdateFromConnectionStringAttributes = original.UpdateFromConnectionStringAttributes;
            TreadSqlScriptUnsupportedCommandsAsWarning = original.TreadSqlScriptUnsupportedCommandsAsWarning;
            _PackageTempDir = original._PackageTempDir;
            WPPAllFilesInSingleFolder = original.WPPAllFilesInSingleFolder;
            IsWPPAllFilesInSingleFolder = original.IsWPPAllFilesInSingleFolder;
            EnableSqlScriptVariableParameterize = original.EnableSqlScriptVariableParameterize;
            SqlScriptPreProcessBatchDelimiter = original.SqlScriptPreProcessBatchDelimiter;
            SqlScriptPreProcessResolveIncludes = original.SqlScriptPreProcessResolveIncludes;
            DeployIisAppPath = original.DeployIisAppPath;
            RemoteSitePhysicalPath = original.RemoteSitePhysicalPath;
            DefaultDeployIisAppPhysicalPath = original.DefaultDeployIisAppPhysicalPath;
            DeployIisAppPhysicalPath = original.DeployIisAppPhysicalPath;
            _DestinationIisAppPhysicalPath = original._DestinationIisAppPhysicalPath;
            DestinationIisVersion = original.DestinationIisVersion;
            DestinationUseIis = original.DestinationUseIis;
            PublishEnableLinks = original.PublishEnableLinks;
            PublishDisableLinks = original.PublishDisableLinks;
            DeployEncryptKey = original.DeployEncryptKey;
            SkipExtraFilesOnServer = original.SkipExtraFilesOnServer;
            MsDeployServiceUrl = original.MsDeployServiceUrl;
            VsIisAppParametersPriority = original.VsIisAppParametersPriority;
            VsContentPathParametersPriority = original.VsContentPathParametersPriority;
            VsDestinationVDirParametersPriority = original.VsDestinationVDirParametersPriority;
            VsSetAclPriority = original.VsSetAclPriority;
            UserProfileParametersFileParametersPriority = original.UserProfileParametersFileParametersPriority;
            UserParametersFileParametersPriority = original.UserParametersFileParametersPriority;
            UserWebConfigParametersPriority = original.UserWebConfigParametersPriority;
            VsSQLDatabaseScriptParametersPriority = original.VsSQLDatabaseScriptParametersPriority;
            VsWebConfigAutoCsParametersPriority = original.VsWebConfigAutoCsParametersPriority;
            GenerateSampleDeployScriptLocation = original.GenerateSampleDeployScriptLocation;
            PackageSourceManifest = original.PackageSourceManifest;
            UseDeclareParametersXMLInMsDeploy = original.UseDeclareParametersXMLInMsDeploy;
            PackageParametersFile = original.PackageParametersFile;
            PublishParametersFile = original.PublishParametersFile;
            GenerateSampleDeployScriptReadMeFileName = original.GenerateSampleDeployScriptReadMeFileName;
            GenerateSampleDeployScriptReadMeLocation = original.GenerateSampleDeployScriptReadMeLocation;
            GenerateSampleParametersValueLocationDefault = original.GenerateSampleParametersValueLocationDefault;
            GenerateSampleParametersValueLocation = original.GenerateSampleParametersValueLocation;
            GenerateSampleParametersValueFileName = original.GenerateSampleParametersValueFileName;
            FilesToIncludeTargetFile = original.FilesToIncludeTargetFile;
            ImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets = original.ImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets;
            PublishPipelineCollectFilesCore = original.PublishPipelineCollectFilesCore;
            ExcludeTransformAssistFilesFromPublish = original.ExcludeTransformAssistFilesFromPublish;
            CollectFilesFromIntermediateAssemblyDependsOn = original.CollectFilesFromIntermediateAssemblyDependsOn;
            CollectFilesFromContentDependsOn = original.CollectFilesFromContentDependsOn;
            CollectFilesFromAddModulesDependsOn = original.CollectFilesFromAddModulesDependsOn;
            CollectFilesFrom_SGenDllCreatedDependsOn = original.CollectFilesFrom_SGenDllCreatedDependsOn;
            CollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn = original.CollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn;
            CollectFilesFromReferenceDependsOn = original.CollectFilesFromReferenceDependsOn;
            CollectFilesFromAllExtraReferenceFilesDependsOn = original.CollectFilesFromAllExtraReferenceFilesDependsOn;
            CollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn = original.CollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn;
            CollectFilesFromDocFileItemDependsOn = original.CollectFilesFromDocFileItemDependsOn;
            CollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn = original.CollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn;
            CollectFilesFrom_binDeployableAssembliesDependsOn = original.CollectFilesFrom_binDeployableAssembliesDependsOn;
            ImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets = original.ImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets;
            AspNetCompileMerge = original.AspNetCompileMerge;
            Web_Publishing_AspNetCompileMerge_targets = original.Web_Publishing_AspNetCompileMerge_targets;
            Microsoft_Web_Publishing_MSDeploy_Common_targets = original.Microsoft_Web_Publishing_MSDeploy_Common_targets;
            ImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets = original.ImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets;
            Microsoft_Web_Publishing_MSDeploy_Common_targets_Imported = original.Microsoft_Web_Publishing_MSDeploy_Common_targets_Imported;
            InsertEFCodeFirstDeployWebCofig = original.InsertEFCodeFirstDeployWebCofig;
            InsertEFCodeFirstDeployWebCofigIntermediateOutput = original.InsertEFCodeFirstDeployWebCofigIntermediateOutput;
            InsertEFCodeFirstDeployWebCofigLocation = original.InsertEFCodeFirstDeployWebCofigLocation;
            PublishDatabases = original.PublishDatabases;
            ProcessPublishDatabaseSettingsDependsOn = original.ProcessPublishDatabaseSettingsDependsOn;
            ParseSQLScriptForMSDeployParametersDependsOn = original.ParseSQLScriptForMSDeployParametersDependsOn;
            HandleEFCodeFirstDataMigrationDependsOn = original.HandleEFCodeFirstDataMigrationDependsOn;
            PreInsertEFCodeFirstDeployWebCofigDependsOn = original.PreInsertEFCodeFirstDeployWebCofigDependsOn;
            PreInsertEFCodeFirstDeployWebCofigBeforeTarget = original.PreInsertEFCodeFirstDeployWebCofigBeforeTarget;
            InsertEFCodeFirstDeployWebCofigCoreDependsOn = original.InsertEFCodeFirstDeployWebCofigCoreDependsOn;
            PostInsertEFCodeFirstDeployWebCofigDependsOn = original.PostInsertEFCodeFirstDeployWebCofigDependsOn;
            InsertEFCodeFirstDeployWebCofigDependsOn = original.InsertEFCodeFirstDeployWebCofigDependsOn;
            InsertEFCodeFirstDeployWebCofigBeforeTargets = original.InsertEFCodeFirstDeployWebCofigBeforeTargets;
            CollectDatabasesToPublishDependsOn = original.CollectDatabasesToPublishDependsOn;
            BeforeAddDeclareParametersItemsForDatabaseScript = original.BeforeAddDeclareParametersItemsForDatabaseScript;
            AfterAddDeclareParametersItemsForDatabaseScript = original.AfterAddDeclareParametersItemsForDatabaseScript;
            AddDeclareParametersItemsForDatabaseScriptDependsOn = original.AddDeclareParametersItemsForDatabaseScriptDependsOn;
            WriteItemsToSourceManifestDependsOn = original.WriteItemsToSourceManifestDependsOn;
            BeforeAddDatabasesToSourceManifest = original.BeforeAddDatabasesToSourceManifest;
            AfterAddDatabasesToSourceManifest = original.AfterAddDatabasesToSourceManifest;
            AddDatabasesToSourceManifestDependsOn = original.AddDatabasesToSourceManifestDependsOn;
            AddDatabasesToSourceManifestAfterTargets = original.AddDatabasesToSourceManifestAfterTargets;
            GenerateSampleDeployScriptDependsOn = original.GenerateSampleDeployScriptDependsOn;
            GenerateSampleDeployScriptAfterTargets = original.GenerateSampleDeployScriptAfterTargets;
            ImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets = original.ImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets;
            ExcludeApp_DataDependsOn = original.ExcludeApp_DataDependsOn;
            ExcludeGeneratedDebugSymbolDependsOn = original.ExcludeGeneratedDebugSymbolDependsOn;
            ExcludeXmlAssemblyFilesDependsOn = original.ExcludeXmlAssemblyFilesDependsOn;
            _EnableCleanOnBuildForMvcViews = original._EnableCleanOnBuildForMvcViews;
            EnableExcludeFilesByExtension = original.EnableExcludeFilesByExtension;
            ExcludeFilesByExtensionDependsOn = original.ExcludeFilesByExtensionDependsOn;
            WebPublishExtensionsToExclude = original.WebPublishExtensionsToExclude;
            ExcludeFilesFromPackageDependsOn = original.ExcludeFilesFromPackageDependsOn;
            ValidateGlobalSettingsDependsOn = original.ValidateGlobalSettingsDependsOn;
            ValidateGlobalPackageSettingDependsOn = original.ValidateGlobalPackageSettingDependsOn;
            _CleanWPPIfNeedToDependsOn = original._CleanWPPIfNeedToDependsOn;
            OnBeforePipelineCollectFilesPhase = original.OnBeforePipelineCollectFilesPhase;
            OnAfterPipelineCollectFilesPhase = original.OnAfterPipelineCollectFilesPhase;
            PipelineCollectFilesPhaseDependsOn = original.PipelineCollectFilesPhaseDependsOn;
            TransformWebConfigBeforeTargets = original.TransformWebConfigBeforeTargets;
            TransformWebConfigDependsOn = original.TransformWebConfigDependsOn;
            CollectWebConfigsToTransformDependsOn = original.CollectWebConfigsToTransformDependsOn;
            PreTransformWebConfigDependsOn = original.PreTransformWebConfigDependsOn;
            TransformWebConfigCoreDependsOn = original.TransformWebConfigCoreDependsOn;
            ParameterizeTransformWebConfigCoreDependsOn = original.ParameterizeTransformWebConfigCoreDependsOn;
            PostTransformWebConfigDependsOn = original.PostTransformWebConfigDependsOn;
            MarkWebConfigAssistFilesAsExcludeDependsOn = original.MarkWebConfigAssistFilesAsExcludeDependsOn;
            ProfileTransformWebConfigBeforeTargets = original.ProfileTransformWebConfigBeforeTargets;
            ProfileTransformWebConfigAfterTargets = original.ProfileTransformWebConfigAfterTargets;
            ProfileTransformWebConfigDependsOn = original.ProfileTransformWebConfigDependsOn;
            CollectFilesForProfileTransformWebConfigsDependsOn = original.CollectFilesForProfileTransformWebConfigsDependsOn;
            PreProfileTransformWebConfigDependsOn = original.PreProfileTransformWebConfigDependsOn;
            ProfileTransformWebConfigCoreDependsOn = original.ProfileTransformWebConfigCoreDependsOn;
            ParameterizeProfileTransformWebConfigCoreDependsOn = original.ParameterizeProfileTransformWebConfigCoreDependsOn;
            PostProfileTransformWebConfigDependsOn = original.PostProfileTransformWebConfigDependsOn;
            PreInsertAdditionalWebCofigConnectionStringsDependsOn = original.PreInsertAdditionalWebCofigConnectionStringsDependsOn;
            InsertAdditionalWebCofigConnectionStringsCoreDependsOn = original.InsertAdditionalWebCofigConnectionStringsCoreDependsOn;
            PostInsertAdditionalWebCofigConnectionStringsDependsOn = original.PostInsertAdditionalWebCofigConnectionStringsDependsOn;
            InsertAdditionalWebCofigConnectionStringsDependsOn = original.InsertAdditionalWebCofigConnectionStringsDependsOn;
            InsertAdditionalWebCofigConnectionStringsBeforeTargets = original.InsertAdditionalWebCofigConnectionStringsBeforeTargets;
            PreAutoParameterizationWebConfigConnectionStringsDependsOn = original.PreAutoParameterizationWebConfigConnectionStringsDependsOn;
            AutoParameterizationWebConfigConnectionStringsCoreDependsOn = original.AutoParameterizationWebConfigConnectionStringsCoreDependsOn;
            PostAutoParameterizationWebConfigConnectionStringsDependsOn = original.PostAutoParameterizationWebConfigConnectionStringsDependsOn;
            AutoParameterizationWebConfigConnectionStringsDependsOn = original.AutoParameterizationWebConfigConnectionStringsDependsOn;
            PipelineTransformPhaseDependsOn = original.PipelineTransformPhaseDependsOn;
            PipelineMsdeploySpecificTransformPhaseBeforeTargets = original.PipelineMsdeploySpecificTransformPhaseBeforeTargets;
            PipelineMsdeploySpecificTransformPhaseDependsOn = original.PipelineMsdeploySpecificTransformPhaseDependsOn;
            _WPPCopyWebApplicationDependsOn = original._WPPCopyWebApplicationDependsOn;
            PipelinePreDeployCopyAllFilesToOneFolderDependsOn = original.PipelinePreDeployCopyAllFilesToOneFolderDependsOn;
            CopyAllFilesToSingleFolderForMsdeployDependsOn = original.CopyAllFilesToSingleFolderForMsdeployDependsOn;
            PipelineCopyAllFilesToOneFolderForMsdeployDependsOn = original.PipelineCopyAllFilesToOneFolderForMsdeployDependsOn;
            GetProjectWebPropertiesDependsOn = original.GetProjectWebPropertiesDependsOn;
            GetMSDeployInstalledVersionPathDependsOn = original.GetMSDeployInstalledVersionPathDependsOn;
            PackageDependsOn = original.PackageDependsOn;
            CopyAllFilesToSingleFolderForPackageDependsOn = original.CopyAllFilesToSingleFolderForPackageDependsOn;
            BeforeAddIis7ToSourceManifest = original.BeforeAddIis7ToSourceManifest;
            AfterAddIis7ToSourceManifest = original.AfterAddIis7ToSourceManifest;
            AddIis7ToSourceManifestDependsOn = original.AddIis7ToSourceManifestDependsOn;
            BeforeAddDeclareParametersItemsForIis7 = original.BeforeAddDeclareParametersItemsForIis7;
            AfterAddDeclareParametersItemsForIis7 = original.AfterAddDeclareParametersItemsForIis7;
            AddDeclareParametersItemsForIis7DependsOn = original.AddDeclareParametersItemsForIis7DependsOn;
            BeforeAddIis6ToSourceManifest = original.BeforeAddIis6ToSourceManifest;
            AfterAddIis6ToSourceManifest = original.AfterAddIis6ToSourceManifest;
            AddIis6ToSourceManifestDependsOn = original.AddIis6ToSourceManifestDependsOn;
            BeforeAddDeclareParametersItemsForIis6 = original.BeforeAddDeclareParametersItemsForIis6;
            AfterAddDeclareParametersItemsForIis6 = original.AfterAddDeclareParametersItemsForIis6;
            AddDeclareParametersItemsForIis6DependsOn = original.AddDeclareParametersItemsForIis6DependsOn;
            BeforeAddIisSettingAndFileContentsToSourceManifest = original.BeforeAddIisSettingAndFileContentsToSourceManifest;
            AfterAddIisSettingAndFileContentsToSourceManifest = original.AfterAddIisSettingAndFileContentsToSourceManifest;
            AddIisSettingAndFileContentsToSourceManifestDependsOn = original.AddIisSettingAndFileContentsToSourceManifestDependsOn;
            BeforeAddContentPathToSourceManifest = original.BeforeAddContentPathToSourceManifest;
            AfterAddContentPathToSourceManifest = original.AfterAddContentPathToSourceManifest;
            AddContentPathToSourceManifestDependsOn = original.AddContentPathToSourceManifestDependsOn;
            BeforeAddIisAndContentDeclareParametersItems = original.BeforeAddIisAndContentDeclareParametersItems;
            AfterAddIisAndContentDeclareParametersItems = original.AfterAddIisAndContentDeclareParametersItems;
            AddIisAndContentDeclareParametersItemsDependsOn = original.AddIisAndContentDeclareParametersItemsDependsOn;
            BeforeAddDeclareParametersItemsForContentPath = original.BeforeAddDeclareParametersItemsForContentPath;
            AfterAddDeclareParametersItemsForContentPath = original.AfterAddDeclareParametersItemsForContentPath;
            AddDeclareParametersItemsForContentPathDependsOn = original.AddDeclareParametersItemsForContentPathDependsOn;
            BeforeWriteItemsToSourceManifest = original.BeforeWriteItemsToSourceManifest;
            AfterWriteItemsToSourceManifest = original.AfterWriteItemsToSourceManifest;
            BeforeAddDeclareParametersItems = original.BeforeAddDeclareParametersItems;
            AfterAddDeclareParametersItems = original.AfterAddDeclareParametersItems;
            AddDeclareParametersItemsDependsOn = original.AddDeclareParametersItemsDependsOn;
            _GatherParamsDependsOn = original._GatherParamsDependsOn;
            GenerateMsDeployManifestSettingsDependsOn = original.GenerateMsDeployManifestSettingsDependsOn;
            CleanWebsitesPackageCoreDependsOn = original.CleanWebsitesPackageCoreDependsOn;
            CleanWebsitesPackageDependsOn = original.CleanWebsitesPackageDependsOn;
            CleanWebsitesWPPAllFilesInSingleFolderDependsOn = original.CleanWebsitesWPPAllFilesInSingleFolderDependsOn;
            CleanWebPublishPipelineIntermediateOutputDependsOn = original.CleanWebPublishPipelineIntermediateOutputDependsOn;
            CheckAndCleanMSDeployPackageIfNeededDependsOn = original.CheckAndCleanMSDeployPackageIfNeededDependsOn;
            OnAfterGenerateMsdeployManifestFiles = original.OnAfterGenerateMsdeployManifestFiles;
            GenerateMsdeployManifestFilesDependsOn = original.GenerateMsdeployManifestFilesDependsOn;
            PackageUsingManifestDependsOn = original.PackageUsingManifestDependsOn;
            TestDeployPackageToLocalDependsOn = original.TestDeployPackageToLocalDependsOn;
            NormalizePublishSettings = original.NormalizePublishSettings;
            AuthType = original.AuthType;
            MSDeployPublishMethod = original.MSDeployPublishMethod;
            GenerateGlobalPublishSettingDependsOn = original.GenerateGlobalPublishSettingDependsOn;
            CreatePackageOnPublish = original.CreatePackageOnPublish;
            MSDeployPublishDependsOn = original.MSDeployPublishDependsOn;
            ValidatePublishProfileSettingsDependsOn = original.ValidatePublishProfileSettingsDependsOn;
            WebMSDeployPublishDependsOn = original.WebMSDeployPublishDependsOn;
            WebPackagePublishDependsOn = original.WebPackagePublishDependsOn;
            WebPublishDependsOn = original.WebPublishDependsOn;
            PipelineDeployPhaseDependsOn = original.PipelineDeployPhaseDependsOn;
            PipelineDeployPhaseAfterTargets = original.PipelineDeployPhaseAfterTargets;
            DbDacFxPreviewDependsOn = original.DbDacFxPreviewDependsOn;
            DbFullSqlPreviewDependsOn = original.DbFullSqlPreviewDependsOn;
            ValidateDbDacFxPreviewSettingsDependsOn = original.ValidateDbDacFxPreviewSettingsDependsOn;
            LocalDbDacFxPreviewDependsOn = original.LocalDbDacFxPreviewDependsOn;
            RemoteDbDacFxPreviewDependsOn = original.RemoteDbDacFxPreviewDependsOn;
            ImportByWildcardAfterMicrosoftWebPublishingTargets = original.ImportByWildcardAfterMicrosoftWebPublishingTargets;
            _TransformWebConfigForAzureAuthenticationDependsOn = original._TransformWebConfigForAzureAuthenticationDependsOn;
            MSBuildFrameworkToolsPath = original.MSBuildFrameworkToolsPath;
            MSBuildFrameworkToolsPath32 = original.MSBuildFrameworkToolsPath32;
            MSBuildFrameworkToolsRoot = original.MSBuildFrameworkToolsRoot;
            VCTargetsPath = original.VCTargetsPath;
            VCTargetsPath10 = original.VCTargetsPath10;
            VCTargetsPath11 = original.VCTargetsPath11;
            VCTargetsPath12 = original.VCTargetsPath12;
            WindowsSDK80Path = original.WindowsSDK80Path;
            CustomBeforeMicrosoftCommonProps = original.CustomBeforeMicrosoftCommonProps;
            CustomAfterMicrosoftCommonProps = original.CustomAfterMicrosoftCommonProps;
            MicrosoftCommonPropsHasBeenImported = original.MicrosoftCommonPropsHasBeenImported;
            WMSJSProject = original.WMSJSProject;
            WMSJSProjectDirectory = original.WMSJSProjectDirectory;
            TargetFrameworkProfile = original.TargetFrameworkProfile;
            UseVSHostingProcess = original.UseVSHostingProcess;
            SignAssembly = original.SignAssembly;
            AssemblyOriginatorKeyFile = original.AssemblyOriginatorKeyFile;
            CSharpTargetsPath = original.CSharpTargetsPath;
            CscToolPath = original.CscToolPath;
            ImportByWildcardBefore40MicrosoftCommonTargets = original.ImportByWildcardBefore40MicrosoftCommonTargets;
            ImportByWildcardAfter40MicrosoftCommonTargets = original.ImportByWildcardAfter40MicrosoftCommonTargets;
            ImportUserLocationsByWildcardBefore40MicrosoftCommonTargets = original.ImportUserLocationsByWildcardBefore40MicrosoftCommonTargets;
            ImportUserLocationsByWildcardAfter40MicrosoftCommonTargets = original.ImportUserLocationsByWildcardAfter40MicrosoftCommonTargets;
            ImportByWildcardBefore40MicrosoftCSharpTargets = original.ImportByWildcardBefore40MicrosoftCSharpTargets;
            ImportByWildcardAfter40MicrosoftCSharpTargets = original.ImportByWildcardAfter40MicrosoftCSharpTargets;
            ImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets = original.ImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets;
            ImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets = original.ImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets;
            ImportByWildcardBefore40MicrosoftNetFrameworkProps = original.ImportByWildcardBefore40MicrosoftNetFrameworkProps;
            ImportByWildcardAfter40MicrosoftNetFrameworkProps = original.ImportByWildcardAfter40MicrosoftNetFrameworkProps;
            ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps = original.ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps;
            ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps = original.ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps;
            NetFrameworkTargetsPath = original.NetFrameworkTargetsPath;
            ImportByWildcardBefore40MicrosoftNetFrameworkTargets = original.ImportByWildcardBefore40MicrosoftNetFrameworkTargets;
            ImportByWildcardAfter40MicrosoftNetFrameworkTargets = original.ImportByWildcardAfter40MicrosoftNetFrameworkTargets;
            ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets = original.ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets;
            ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets = original.ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets;
            XamlBuildTaskPath = original.XamlBuildTaskPath;
            AllowUnsafeBlocks = original.AllowUnsafeBlocks;
            MinimumVisualStudioVersion = original.MinimumVisualStudioVersion;
            DefaultLanguage = original.DefaultLanguage;
            TargetFrameworkMonikerDisplayName = original.TargetFrameworkMonikerDisplayName;
            ImplicitlyExpandTargetFramework = original.ImplicitlyExpandTargetFramework;
            ImplicitlyExpandTargetFrameworkDependsOn = original.ImplicitlyExpandTargetFrameworkDependsOn;
            ReferencePath = original.ReferencePath;
            IsCodedUITest = original.IsCodedUITest;
            TestProjectType = original.TestProjectType;
            RootPath = original.RootPath;
            _InvalidConfigurationError = original._InvalidConfigurationError;
            SilverlightBuild = original.SilverlightBuild;
            BuildName = original.BuildName;
            Project_Major = original.Project_Major;
            Project_Minor = original.Project_Minor;
            Project_Build = original.Project_Build;
            AssemblyVersion_Build = original.AssemblyVersion_Build;
            BuildScriptsPath = original.BuildScriptsPath;
            BuildConfigDescription = original.BuildConfigDescription;
            BuildPath = original.BuildPath;
            ToolsPath = original.ToolsPath;
            TestResultsPath = original.TestResultsPath;
            AssemblyInfoFile = original.AssemblyInfoFile;
            AssemblyTitle = original.AssemblyTitle;
            AssemblyProduct = original.AssemblyProduct;
            ComVisible = original.ComVisible;
            CLSCompliant = original.CLSCompliant;
            AllowPartiallyTrustedCallers = original.AllowPartiallyTrustedCallers;
            AssemblyVersion_Major = original.AssemblyVersion_Major;
            AssemblyVersion_Minor = original.AssemblyVersion_Minor;
            Build_Number = original.Build_Number;
            Build_Revision = original.Build_Revision;
            TestDetectionExpression = original.TestDetectionExpression;
            TestRunner_Enabled = original.TestRunner_Enabled;
            TestRunner_Timeout = original.TestRunner_Timeout;
            TestRunner_ContinueOnError = original.TestRunner_ContinueOnError;
            NUnitExecutable = original.NUnitExecutable;
            NUnitPath = original.NUnitPath;
            MSBuildCommunityTasksPath = original.MSBuildCommunityTasksPath;
            MSBuildCommunityTasksLib = original.MSBuildCommunityTasksLib;
            FileUpgradeFlags = original.FileUpgradeFlags;
            UpgradeBackupLocation = original.UpgradeBackupLocation;
            SilverlightApplication = original.SilverlightApplication;
            SupportedCultures = original.SupportedCultures;
            XapOutputs = original.XapOutputs;
            GenerateSilverlightManifest = original.GenerateSilverlightManifest;
            XapFilename = original.XapFilename;
            SilverlightManifestTemplate = original.SilverlightManifestTemplate;
            SilverlightAppEntry = original.SilverlightAppEntry;
            CreateTestPage = original.CreateTestPage;
            ValidateXaml = original.ValidateXaml;
            EnableOutOfBrowser = original.EnableOutOfBrowser;
            OutOfBrowserSettingsFile = original.OutOfBrowserSettingsFile;
            UsePlatformExtensions = original.UsePlatformExtensions;
            ThrowErrorsInValidation = original.ThrowErrorsInValidation;
            LinkedServerProject = original.LinkedServerProject;
            OldToolsVersion = original.OldToolsVersion;
            ProjectType = original.ProjectType;
            ApplicationIcon = original.ApplicationIcon;
            AssemblyKeyContainerName = original.AssemblyKeyContainerName;
            DefaultClientScript = original.DefaultClientScript;
            DefaultHTMLPageLayout = original.DefaultHTMLPageLayout;
            DefaultTargetSchema = original.DefaultTargetSchema;
            RunPostBuildEvent = original.RunPostBuildEvent;
            StartupObject = original.StartupObject;
            PreBuildEvent = original.PreBuildEvent;
            PostBuildEvent = original.PostBuildEvent;
            BuildToolsVersion = original.BuildToolsVersion;
            SourceDir = original.SourceDir;
            BinDir = original.BinDir;
            ObjDir = original.ObjDir;
            TestWorkingDir = original.TestWorkingDir;
            PackagesOutDir = original.PackagesOutDir;
            PackagesDir = original.PackagesDir;
            ToolsDir = original.ToolsDir;
            NuGetToolPath = original.NuGetToolPath;
            NuGetConfigFile = original.NuGetConfigFile;
            NuGetConfigCommandLine = original.NuGetConfigCommandLine;
            NugetRestoreCommand = original.NugetRestoreCommand;
            ConfigurationGroup = original.ConfigurationGroup;
            OSGroup = original.OSGroup;
            NoStdLib = original.NoStdLib;
            NoExplicitReferenceToStdLib = original.NoExplicitReferenceToStdLib;
            CommonPath = original.CommonPath;
            CommonTestPath = original.CommonTestPath;
            OSPlatformConfig = original.OSPlatformConfig;
            BaseOutputPath = original.BaseOutputPath;
            TestPath = original.TestPath;
            PackagesBasePath = original.PackagesBasePath;
            TargetsWindows = original.TargetsWindows;
            _WindowsKitBinPath = original._WindowsKitBinPath;
            _WindowsPhoneKitBinPath = original._WindowsPhoneKitBinPath;
            MakePriExeFullPath = original.MakePriExeFullPath;
            MakeAppxExeFullPath = original.MakeAppxExeFullPath;
            SignAppxPackageExeFullPath = original.SignAppxPackageExeFullPath;
            MakePriExtensionPath = original.MakePriExtensionPath;
            MakePriExtensionPath_x64 = original.MakePriExtensionPath_x64;
            ErrorIfBuildToolsRestoredFromIndividualProject = original.ErrorIfBuildToolsRestoredFromIndividualProject;
            AssemblyVersion = original.AssemblyVersion;
            TestCategories = original.TestCategories;
            DocumentationFile = original.DocumentationFile;
            GenerateAppxPackageOnBuild = original.GenerateAppxPackageOnBuild;
            NuGetPackageImportStamp = original.NuGetPackageImportStamp;
            DebugEngines = original.DebugEngines;
            GenerateAssemblyInfo = original.GenerateAssemblyInfo;
            NoWarn = original.NoWarn;
            RuntimeSerializationSources = original.RuntimeSerializationSources;
            JsonSources = original.JsonSources;
            XmlSources = original.XmlSources;
            TextSources = original.TextSources;
            CheckForOverflowUnderflow = original.CheckForOverflowUnderflow;
            ExternallyShipping = original.ExternallyShipping;
            RunTestsForProject = original.RunTestsForProject;
            CommonPathXPath = original.CommonPathXPath;
            TypeScriptTarget = original.TypeScriptTarget;
            TypeScriptCompileOnSaveEnabled = original.TypeScriptCompileOnSaveEnabled;
            TypeScriptNoImplicitAny = original.TypeScriptNoImplicitAny;
            TypeScriptModuleKind = original.TypeScriptModuleKind;
            TypeScriptRemoveComments = original.TypeScriptRemoveComments;
            TypeScriptOutFile = original.TypeScriptOutFile;
            TypeScriptOutDir = original.TypeScriptOutDir;
            TypeScriptGeneratesDeclarations = original.TypeScriptGeneratesDeclarations;
            TypeScriptSourceMap = original.TypeScriptSourceMap;
            TypeScriptMapRoot = original.TypeScriptMapRoot;
            TypeScriptSourceRoot = original.TypeScriptSourceRoot;
            TypeScriptNoEmitOnError = original.TypeScriptNoEmitOnError;
            TypeScriptToolsVersion = original.TypeScriptToolsVersion;
            VsToolsPath = original.VsToolsPath;
            CfgPropertyPagesGuidsAddCSharp = original.CfgPropertyPagesGuidsAddCSharp;
            CfgPropertyPagesGuidsAddVB = original.CfgPropertyPagesGuidsAddVB;
            CfgPropertyPagesGuidsAddTypeScript = original.CfgPropertyPagesGuidsAddTypeScript;
            TypeScriptEnabled = original.TypeScriptEnabled;
            TypeScriptBuildConfigurations = original.TypeScriptBuildConfigurations;
            TscToolPath = original.TscToolPath;
            TscToolExe = original.TscToolExe;
            TscYieldDuringToolExecution = original.TscYieldDuringToolExecution;
            ConsolePause = original.ConsolePause;
            PublishUrl = original.PublishUrl;
            Install = original.Install;
            InstallFrom = original.InstallFrom;
            UpdateEnabled = original.UpdateEnabled;
            UpdateMode = original.UpdateMode;
            UpdateInterval = original.UpdateInterval;
            UpdateIntervalUnits = original.UpdateIntervalUnits;
            UpdatePeriodically = original.UpdatePeriodically;
            UpdateRequired = original.UpdateRequired;
            MapFileExtensions = original.MapFileExtensions;
            ApplicationRevision = original.ApplicationRevision;
            ApplicationVersion = original.ApplicationVersion;
            IsWebBootstrapper = original.IsWebBootstrapper;
            UseApplicationTrust = original.UseApplicationTrust;
            BootstrapperEnabled = original.BootstrapperEnabled;
            _FullFrameworkReferenceAssemblyPaths = original._FullFrameworkReferenceAssemblyPaths;
            _TargetFrameworkDirectories = original._TargetFrameworkDirectories;
            TreatWarningsAsErrors = original.TreatWarningsAsErrors;
            RegisterForComInterop = original.RegisterForComInterop;
            GenerateSerializationAssemblies = original.GenerateSerializationAssemblies;
            BaseAddress = original.BaseAddress;
            PublishUrlHistory = original.PublishUrlHistory;
            InstallUrlHistory = original.InstallUrlHistory;
            SupportUrlHistory = original.SupportUrlHistory;
            UpdateUrlHistory = original.UpdateUrlHistory;
            BootstrapperUrlHistory = original.BootstrapperUrlHistory;
            ErrorReportUrlHistory = original.ErrorReportUrlHistory;
            FallbackCulture = original.FallbackCulture;
            VerifyUploadedFiles = original.VerifyUploadedFiles;
            SccProjectName = original.SccProjectName;
            SccLocalPath = original.SccLocalPath;
            SccAuxPath = original.SccAuxPath;
            SccProvider = original.SccProvider;
            SilverlightVersion = original.SilverlightVersion;
            NoConfig = original.NoConfig;
            VCInstallDir_110 = original.VCInstallDir_110;
            WP80ToolSetPath = original.WP80ToolSetPath;
            WindowsPhoneSdkRegkeyRoot = original.WindowsPhoneSdkRegkeyRoot;
            WindowsPhoneRegistryBase = original.WindowsPhoneRegistryBase;
            WindowsPhoneRegistryBaseVersion = original.WindowsPhoneRegistryBaseVersion;
            RuntimePathRegistryKey = original.RuntimePathRegistryKey;
            ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch = original.ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch;
            WindowsPhoneSdkVersion = original.WindowsPhoneSdkVersion;
            WindowsPhoneSdkInstallPath = original.WindowsPhoneSdkInstallPath;
            WindowsPhone71RegistryBase = original.WindowsPhone71RegistryBase;
            WindowsPhone71RegistryBaseVersion = original.WindowsPhone71RegistryBaseVersion;
            WindowsPhone7RegistryBase = original.WindowsPhone7RegistryBase;
            WindowsPhone7RegistryBaseVersion = original.WindowsPhone7RegistryBaseVersion;
            WindowsPhoneFxReferencesDisplayName = original.WindowsPhoneFxReferencesDisplayName;
            PathOfWMAppManifestRelativeToProject = original.PathOfWMAppManifestRelativeToProject;
            ImportByWildcardBeforeWindowsPhoneCommonTargets = original.ImportByWildcardBeforeWindowsPhoneCommonTargets;
            ImportByWildcardAfterWindowsPhoneCommonTargets = original.ImportByWildcardAfterWindowsPhoneCommonTargets;
            IncludeBuiltProjectOutputGroup = original.IncludeBuiltProjectOutputGroup;
            IncludeDebugSymbolsProjectOutputGroup = original.IncludeDebugSymbolsProjectOutputGroup;
            IncludeDocumentationProjectOutputGroup = original.IncludeDocumentationProjectOutputGroup;
            IncludeSatelliteDllsProjectOutputGroup = original.IncludeSatelliteDllsProjectOutputGroup;
            IncludeSourceFilesProjectOutputGroup = original.IncludeSourceFilesProjectOutputGroup;
            IncludeContentFilesProjectOutputGroup = original.IncludeContentFilesProjectOutputGroup;
            IncludeSGenFilesOutputGroup = original.IncludeSGenFilesOutputGroup;
            IncludeCopyLocalFilesOutputGroup = original.IncludeCopyLocalFilesOutputGroup;
            IncludeComFilesOutputGroup = original.IncludeComFilesOutputGroup;
            IncludeCustomOutputGroupForPackaging = original.IncludeCustomOutputGroupForPackaging;
            IncludeCopyWinmdArtifactsOutputGroup = original.IncludeCopyWinmdArtifactsOutputGroup;
            IncludeSDKRedistOutputGroup = original.IncludeSDKRedistOutputGroup;
            IncludeGetResolvedSDKReferences = original.IncludeGetResolvedSDKReferences;
            ValidateXapFilenames = original.ValidateXapFilenames;
            AllOutputGroupsDependsOn = original.AllOutputGroupsDependsOn;
            CopyLocalFilesOutputGroupDependsOn = original.CopyLocalFilesOutputGroupDependsOn;
            GetPackagingOutputsDependsOn = original.GetPackagingOutputsDependsOn;
            FilterPackagingOutPutsDependsOn = original.FilterPackagingOutPutsDependsOn;
            _GetPackagePropertiesDependsOn = original._GetPackagePropertiesDependsOn;
            SignToolPath = original.SignToolPath;
            ValidateXapFilenamesDependsOn = original.ValidateXapFilenamesDependsOn;
            ComputeWinMDsDependsOn = original.ComputeWinMDsDependsOn;
            WMAppManifestWinMDRegistrationDependsOn = original.WMAppManifestWinMDRegistrationDependsOn;
            ExtMapFileValidationAsError = original.ExtMapFileValidationAsError;
            OutOfBrowserPlusAppCachingIsSupported = original.OutOfBrowserPlusAppCachingIsSupported;
            FrameworkRegistryBaseWithVersion = original.FrameworkRegistryBaseWithVersion;
            RuntimeVersionRegistryKey = original.RuntimeVersionRegistryKey;
            ReferencesValidationRequiredForWindowsPhone = original.ReferencesValidationRequiredForWindowsPhone;
            CompileXamlDependsOn = original.CompileXamlDependsOn;
            ValidateXamlDependsOn = original.ValidateXamlDependsOn;
            XapPackagerDependsOn = original.XapPackagerDependsOn;
            FilesToXapDependsOn = original.FilesToXapDependsOn;
            CreateSilverlightAppManifestDependsOn = original.CreateSilverlightAppManifestDependsOn;
            CategorizeSilverlightReferencesDependsOn = original.CategorizeSilverlightReferencesDependsOn;
            PackagePlatformExtensionsDependsOn = original.PackagePlatformExtensionsDependsOn;
            ImplicitlyExpandTargetPlatform = original.ImplicitlyExpandTargetPlatform;
            WindowsPhoneSDK_MetadataPath = original.WindowsPhoneSDK_MetadataPath;
            CopyWinmdArtifactsOutputGroupDependsOn = original.CopyWinmdArtifactsOutputGroupDependsOn;
            PackagesProjectConfig = original.PackagesProjectConfig;
            NonInteractiveSwitch = original.NonInteractiveSwitch;
            PaddedSolutionDir = original.PaddedSolutionDir;
            ConfigurationOverrideFile = original.ConfigurationOverrideFile;
            RemoveIntegerChecks = original.RemoveIntegerChecks;
            _DisabledWarnings = original._DisabledWarnings;
            LoadTimeSensitiveItems = original.LoadTimeSensitiveItems;
            LoadTimeCheckItemLocation = original.LoadTimeCheckItemLocation;
            GetRedistListsDependsOn = original.GetRedistListsDependsOn;
            UnloadProjectsOnCompletion = original.UnloadProjectsOnCompletion;
            WinFXNativePath = original.WinFXNativePath;
            WinFXWowPath = original.WinFXWowPath;
            TargetingClr2Framework = original.TargetingClr2Framework;
            MSBuildManagedCompilerPath = original.MSBuildManagedCompilerPath;
            RiaClientCodeGenDependsOn = original.RiaClientCodeGenDependsOn;
            CoreRiaClientCodeGenDependsOn = original.CoreRiaClientCodeGenDependsOn;
            RiaClientCleanDependsOn = original.RiaClientCleanDependsOn;
            _RiaClientCodeGenOutputPath = original._RiaClientCodeGenOutputPath;
            _RiaClientCodeGenHistoryFile = original._RiaClientCodeGenHistoryFile;
            DefaultClientReferences = original.DefaultClientReferences;
            PrepareForRiaClientCodeGenDependsOn = original.PrepareForRiaClientCodeGenDependsOn;
            WindowsAppContainer = original.WindowsAppContainer;
            SuppressWarningsInPass1 = original.SuppressWarningsInPass1;
            TargetPlatformSdkMetadataLocation = original.TargetPlatformSdkMetadataLocation;
            TargetPlatformWinMDLocation = original.TargetPlatformWinMDLocation;
            AppxMSBuildToolsPath = original.AppxMSBuildToolsPath;
            AppxMSBuildTaskAssembly = original.AppxMSBuildTaskAssembly;
            AppxPackage = original.AppxPackage;
            AppxUseHardlinksIfPossible = original.AppxUseHardlinksIfPossible;
            AppxSkipUnchangedFiles = original.AppxSkipUnchangedFiles;
            AppxGeneratePriEnabled = original.AppxGeneratePriEnabled;
            AppxGetPackagePropertiesEnabled = original.AppxGetPackagePropertiesEnabled;
            AppxPackageIncludePrivateSymbols = original.AppxPackageIncludePrivateSymbols;
            AppxSymbolPackageEnabled = original.AppxSymbolPackageEnabled;
            AppxTestLayoutEnabled = original.AppxTestLayoutEnabled;
            AppxPackageValidationEnabled = original.AppxPackageValidationEnabled;
            AppxHarvestWinmdRegistration = original.AppxHarvestWinmdRegistration;
            AutoIncrementPackageRevision = original.AutoIncrementPackageRevision;
            AppxPrependPriInitialPath = original.AppxPrependPriInitialPath;
            EnableSigningChecks = original.EnableSigningChecks;
            AppxStrictManifestValidationEnabled = original.AppxStrictManifestValidationEnabled;
            AppxFilterOutUnusedLanguagesResourceFileMaps = original.AppxFilterOutUnusedLanguagesResourceFileMaps;
            AppxGeneratePrisForPortableLibrariesEnabled = original.AppxGeneratePrisForPortableLibrariesEnabled;
            AppxGeneratePackageRecipeEnabled = original.AppxGeneratePackageRecipeEnabled;
            _TargetPlatformIsWindowsPhone = original._TargetPlatformIsWindowsPhone;
            AppxPackageSigningEnabled = original.AppxPackageSigningEnabled;
            AppxOSMinVersion = original.AppxOSMinVersion;
            AppxOSMaxVersionTested = original.AppxOSMaxVersionTested;
            AppxPackageDirName = original.AppxPackageDirName;
            AppxPackageDirInProjectDir = original.AppxPackageDirInProjectDir;
            PlatformSpecificBundleArtifactsListDirName = original.PlatformSpecificBundleArtifactsListDirName;
            PlatformSpecificBundleArtifactsListDirInProjectDir = original.PlatformSpecificBundleArtifactsListDirInProjectDir;
            AppxPackageDir = original.AppxPackageDir;
            AppxPackageArtifactsDir = original.AppxPackageArtifactsDir;
            FinalAppxManifestName = original.FinalAppxManifestName;
            AppxValidateAppxManifest = original.AppxValidateAppxManifest;
            StoreManifestName = original.StoreManifestName;
            ResgenToolPath = original.ResgenToolPath;
            PdbCopyExeFullPath = original.PdbCopyExeFullPath;
            AppxSymbolStrippedDir = original.AppxSymbolStrippedDir;
            AppxPriInitialPath = original.AppxPriInitialPath;
            ProjectPriFileName = original.ProjectPriFileName;
            ProjectPriFullPath = original.ProjectPriFullPath;
            AppxPackageRecipe = original.AppxPackageRecipe;
            FinalAppxPackageRecipe = original.FinalAppxPackageRecipe;
            AllowLocalNetworkLoopback = original.AllowLocalNetworkLoopback;
            AppxDefaultHashAlgorithmId = original.AppxDefaultHashAlgorithmId;
            AppxPackageFileMap = original.AppxPackageFileMap;
            LayoutDir = original.LayoutDir;
            ManagedWinmdInprocImplementation = original.ManagedWinmdInprocImplementation;
            UseIncrementalAppxRegistration = original.UseIncrementalAppxRegistration;
            AppxPackagingInfoFile = original.AppxPackagingInfoFile;
            AppxOSMinVersionReplaceManifestVersion = original.AppxOSMinVersionReplaceManifestVersion;
            AppxOSMaxVersionTestedReplaceManifestVersion = original.AppxOSMaxVersionTestedReplaceManifestVersion;
            PackagingFileWritesLogPath = original.PackagingFileWritesLogPath;
            PackagingDirectoryWritesLogPath = original.PackagingDirectoryWritesLogPath;
            AppxCopyLocalFilesOutputGroupIncludeXmlFiles = original.AppxCopyLocalFilesOutputGroupIncludeXmlFiles;
            AppxPriConfigXmlPackagingSnippetPath = original.AppxPriConfigXmlPackagingSnippetPath;
            AppxPriConfigXmlDefaultSnippetPath = original.AppxPriConfigXmlDefaultSnippetPath;
            TargetPlatformSdkRootOverride = original.TargetPlatformSdkRootOverride;
            TargetPlatformResourceVersion = original.TargetPlatformResourceVersion;
            AppxPackageExtension = original.AppxPackageExtension;
            AppxSymbolPackageExtension = original.AppxSymbolPackageExtension;
            AppxBundleExtension = original.AppxBundleExtension;
            AppxStoreContainerExtension = original.AppxStoreContainerExtension;
            AppxIntermediateExtension = original.AppxIntermediateExtension;
            AppxBundle = original.AppxBundle;
            AppxBundlePlatforms = original.AppxBundlePlatforms;
            AppxBundleProducingPlatform = original.AppxBundleProducingPlatform;
            AppxBundleResourcePacksProducingPlatform = original.AppxBundleResourcePacksProducingPlatform;
            AppxLayoutFolderName = original.AppxLayoutFolderName;
            AppxLayoutDir = original.AppxLayoutDir;
            AppxBundlePriConfigXmlForSplittingFileName = original.AppxBundlePriConfigXmlForSplittingFileName;
            AppxBundleAutoResourcePackageQualifiers = original.AppxBundleAutoResourcePackageQualifiers;
            AppxBundleSplitResourcesPriPrefix = original.AppxBundleSplitResourcesPriPrefix;
            AppxBundleSplitResourcesPriPath = original.AppxBundleSplitResourcesPriPath;
            AppxBundleSplitResourcesGeneratedFilesListPath = original.AppxBundleSplitResourcesGeneratedFilesListPath;
            AppxBundleSplitResourcesQualifiersPath = original.AppxBundleSplitResourcesQualifiersPath;
            AppxBundlePriConfigXmlForMainPackageFileMapFileName = original.AppxBundlePriConfigXmlForMainPackageFileMapFileName;
            AppxBundleMainPackageFileMapIntermediatePrefix = original.AppxBundleMainPackageFileMapIntermediatePrefix;
            AppxBundleMainPackageFileMapSuffix = original.AppxBundleMainPackageFileMapSuffix;
            AppxBundleMainPackageFileMapIntermediatePath = original.AppxBundleMainPackageFileMapIntermediatePath;
            AppxBundleMainPackageFileMapIntermediatePriPath = original.AppxBundleMainPackageFileMapIntermediatePriPath;
            AppxBundleMainPackageFileMapGeneratedFilesListPath = original.AppxBundleMainPackageFileMapGeneratedFilesListPath;
            AppxBundleMainPackageFileMapPrefix = original.AppxBundleMainPackageFileMapPrefix;
            AppxBundleMainPackageFileMapPath = original.AppxBundleMainPackageFileMapPath;
            AppxBundleFolderSuffix = original.AppxBundleFolderSuffix;
            PlatformSpecificBundleArtifactsListDir = original.PlatformSpecificBundleArtifactsListDir;
            AppxDefaultResourceQualifiers_Windows_80 = original.AppxDefaultResourceQualifiers_Windows_80;
            AppxDefaultResourceQualifiers_Windows_81 = original.AppxDefaultResourceQualifiers_Windows_81;
            AppxDefaultResourceQualifiers_Windows_Phone = original.AppxDefaultResourceQualifiers_Windows_Phone;
            AppxDefaultResourceQualifiers = original.AppxDefaultResourceQualifiers;
            AppxPackageAllowDebugFrameworkReferencesInManifest = original.AppxPackageAllowDebugFrameworkReferencesInManifest;
            InsertReverseMap = original.InsertReverseMap;
            _ProjectPriFullPathOriginal = original._ProjectPriFullPathOriginal;
            IncludePriFilesOutputGroup = original.IncludePriFilesOutputGroup;
            IncludeProjectPriFile = original.IncludeProjectPriFile;
            ValidatePresenceOfAppxManifestItemsDependsOn = original.ValidatePresenceOfAppxManifestItemsDependsOn;
            _GenerateProjectPriFileDependsOn = original._GenerateProjectPriFileDependsOn;
            _PriConfigXmlPath = original._PriConfigXmlPath;
            _LayoutResfilesPath = original._LayoutResfilesPath;
            _ResourcesResfilesPath = original._ResourcesResfilesPath;
            _PriResfilesPath = original._PriResfilesPath;
            _QualifiersPath = original._QualifiersPath;
            _MultipleQualifiersPerDimensionFoundPath = original._MultipleQualifiersPerDimensionFoundPath;
            _ProjectArchitecturesFilePath = original._ProjectArchitecturesFilePath;
            _GenerateAppxManifestDependsOn = original._GenerateAppxManifestDependsOn;
            _GenerateAppxPackageRecipeDependsOn = original._GenerateAppxPackageRecipeDependsOn;
            _GenerateAppxPackageBaseDependsOn = original._GenerateAppxPackageBaseDependsOn;
            _GenerateAppxPackageDependsOn = original._GenerateAppxPackageDependsOn;
            _CreateAppxPackageDependsOn = original._CreateAppxPackageDependsOn;
            _CreateAppxBundlePlatformSpecificArtifactsDependsOn = original._CreateAppxBundlePlatformSpecificArtifactsDependsOn;
            _CreateAppxBundleFilesDependsOn = original._CreateAppxBundleFilesDependsOn;
            ComFilesOutputGroupDependsOn = original.ComFilesOutputGroupDependsOn;
            PrepareLayoutDependsOn = original.PrepareLayoutDependsOn;
            RegisterAppxLayoutDependsOn = original.RegisterAppxLayoutDependsOn;
            UnRegisterAppxLayoutDependsOn = original.UnRegisterAppxLayoutDependsOn;
            VCInstallDir = original.VCInstallDir;
            XAMLFingerprint = original.XAMLFingerprint;
            XAMLFingerprintIgnorePaths = original.XAMLFingerprintIgnorePaths;
            PriIndexName = original.PriIndexName;
            OnXamlPreCompileErrorTarget = original.OnXamlPreCompileErrorTarget;
            XamlShareAppDomains = original.XamlShareAppDomains;
            XamlGeneratedOutputPath = original.XamlGeneratedOutputPath;
            PrepareLibraryLayoutDependsOn = original.PrepareLibraryLayoutDependsOn;
            FindInvalidProjectReferences = original.FindInvalidProjectReferences;
            IPhoneResourcePrefix = original.IPhoneResourcePrefix;
            TargetPlatformMonikerDisplayName = original.TargetPlatformMonikerDisplayName;
            PortableSDKRoot = original.PortableSDKRoot;
            XamlTargetPlatformVersion = original.XamlTargetPlatformVersion;
            WindowsUIXamlCommonTargets = original.WindowsUIXamlCommonTargets;
            ImplicitlyExpandTargetPlatformDependsOn = original.ImplicitlyExpandTargetPlatformDependsOn;
            DeterminePortablePlatformSdkPathDependsOn = original.DeterminePortablePlatformSdkPathDependsOn;
            DeterminePortableBuildCapabilitiesDependsOn = original.DeterminePortableBuildCapabilitiesDependsOn;
            TargetPlatformRootPath = original.TargetPlatformRootPath;
            PackageCertificateKeyFile = original.PackageCertificateKeyFile;
            AppXPackage = original.AppXPackage;
            CleanPackageAction = original.CleanPackageAction;
            PackageAction = original.PackageAction;
            RebuildPackageAction = original.RebuildPackageAction;
            MtouchLink = original.MtouchLink;
            CodesignEntitlements = original.CodesignEntitlements;
            MtouchDebug = original.MtouchDebug;
            MtouchI18n = original.MtouchI18n;
            MtouchArch = original.MtouchArch;
            CodeAnalysisIgnoreBuiltInRuleSets = original.CodeAnalysisIgnoreBuiltInRuleSets;
            CodeAnalysisIgnoreBuiltInRules = original.CodeAnalysisIgnoreBuiltInRules;
            RunCodeAnalysis = original.RunCodeAnalysis;
            RunCodeAnalysisOnThisProject = original.RunCodeAnalysisOnThisProject;
            CodeAnalysisRules = original.CodeAnalysisRules;
            _DeploymentSignClickOnceManifests = original._DeploymentSignClickOnceManifests;
            PackageCertificateThumbprint = original.PackageCertificateThumbprint;
            AppxAutoIncrementPackageRevision = original.AppxAutoIncrementPackageRevision;
            TestPageFileName = original.TestPageFileName;
            ProjectView = original.ProjectView;
            Externalconsole = original.Externalconsole;
            NuGetFrameworkVersion = original.NuGetFrameworkVersion;
            ExcludeFromPackage = original.ExcludeFromPackage;
            NameOfLastUsedPublishProfile = original.NameOfLastUsedPublishProfile;
            ImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets = original.ImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets;
            _CollectFiles_IncludeIgnorableFile = original._CollectFiles_IncludeIgnorableFile;
            CollectFilesFromProjectFolder_ExcludeSccFiles = original.CollectFilesFromProjectFolder_ExcludeSccFiles;
            SetExcludeFromProjectFolderDependsOn = original.SetExcludeFromProjectFolderDependsOn;
            CollectFilesFromProjectFolder_ExcludeSccFilesDependsOn = original.CollectFilesFromProjectFolder_ExcludeSccFilesDependsOn;
            CollectFilesFromProjectFolderDependsOn = original.CollectFilesFromProjectFolderDependsOn;
            ImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets = original.ImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets;
            NoWin32Manifest = original.NoWin32Manifest;
            InBrowserSettingsFile = original.InBrowserSettingsFile;
            RequireInBrowserElevation = original.RequireInBrowserElevation;
            RoleType = original.RoleType;
            PortableEnableXamlTargets = original.PortableEnableXamlTargets;
            SynthesizeLinkMetadata = original.SynthesizeLinkMetadata;
            HasSharedItems = original.HasSharedItems;
            SharedGUID = original.SharedGUID;
            Import_RootNamespace = original.Import_RootNamespace;
            DisableXbfGeneration = original.DisableXbfGeneration;
            XamlSavedStateFileName = original.XamlSavedStateFileName;
            XamlSavedStateFilePath = original.XamlSavedStateFilePath;
            XamlRootsLog = original.XamlRootsLog;
            MarkupCompilePass1DependsOn = original.MarkupCompilePass1DependsOn;
            MarkupCompilePass2DependsOn = original.MarkupCompilePass2DependsOn;
            Prep_ComputeProcessXamlFilesDependsOn = original.Prep_ComputeProcessXamlFilesDependsOn;
            SDKReferenceWarnOnMissingMaxPlatformVersion = original.SDKReferenceWarnOnMissingMaxPlatformVersion;
            StartArguments = original.StartArguments;
            EnableSQLServerDebugging = original.EnableSQLServerDebugging;
            WPTestProject = original.WPTestProject;
            _DeploymentApplicationUrl = original._DeploymentApplicationUrl;
            StartAction = original.StartAction;
        }


        public ItemCollection<Reference> References
        {
            get;
            set;
        }

        public ItemCollection<Compile> Compiles
        {
            get;
            set;
        }

        public ItemCollection<None> Nones
        {
            get;
            set;
        }

        public ItemCollection<ProjectReference> ProjectReferences
        {
            get;
            set;
        }

        public ItemCollection<Content> Contents
        {
            get;
            set;
        }

        public ItemCollection<_OutputPathItem> _OutputPathItems
        {
            get;
            set;
        }

        public ItemCollection<_UnmanagedRegistrationCache> _UnmanagedRegistrationCaches
        {
            get;
            set;
        }

        public ItemCollection<_ResolveComReferenceCache> _ResolveComReferenceCaches
        {
            get;
            set;
        }

        public ItemCollection<AppConfigFileDestination> AppConfigFileDestinations
        {
            get;
            set;
        }

        public ItemCollection<IntermediateAssembly> IntermediateAssemblies
        {
            get;
            set;
        }

        public ItemCollection<_DebugSymbolsIntermediatePath> _DebugSymbolsIntermediatePaths
        {
            get;
            set;
        }

        public ItemCollection<_DebugSymbolsOutputPath> _DebugSymbolsOutputPaths
        {
            get;
            set;
        }

        public ItemCollection<_DeploymentManifestEntryPoint> _DeploymentManifestEntryPoints
        {
            get;
            set;
        }

        public ItemCollection<ApplicationManifest> ApplicationManifests
        {
            get;
            set;
        }

        public ItemCollection<_ApplicationManifestFinal> _ApplicationManifestFinals
        {
            get;
            set;
        }

        public ItemCollection<DeployManifest> DeployManifests
        {
            get;
            set;
        }

        public ItemCollection<BuiltProjectOutputGroupKeyOutput> BuiltProjectOutputGroupKeyOutputs
        {
            get;
            set;
        }

        public ItemCollection<DebugSymbolsProjectOutputGroupOutput> DebugSymbolsProjectOutputGroupOutputs
        {
            get;
            set;
        }

        public ItemCollection<AvailableItemName> AvailableItemNames
        {
            get;
            set;
        }

        public ItemCollection<Clean> Cleans
        {
            get;
            set;
        }

        public ItemCollection<XamlBuildTaskTypeGenerationExtensionName> XamlBuildTaskTypeGenerationExtensionNames
        {
            get;
            set;
        }

        public ItemCollection<_ExplicitReference> _ExplicitReferences
        {
            get;
            set;
        }

        public ItemCollection<WCFMetadata> WCFMetadatas
        {
            get;
            set;
        }

        public ItemCollection<ServiceReferenceMetadataStorage> ServiceReferenceMetadataStorages
        {
            get;
            set;
        }

        public ItemCollection<_WPPSupports> _WPPSupportsCollection
        {
            get;
            set;
        }

        public ItemCollection<_IISApplicationPool> _IISApplicationPools
        {
            get;
            set;
        }

        public ItemCollection<_MSDeployPackageFile> _MSDeployPackageFiles
        {
            get;
            set;
        }

        public ItemCollection<_MSDeployArchiveDir> _MSDeployArchiveDirs
        {
            get;
            set;
        }

        public ItemCollection<_MSDeployPackageLocation> _MSDeployPackageLocations
        {
            get;
            set;
        }

        public ItemCollection<WebPublishExtnsionsToExcludeItem> WebPublishExtnsionsToExcludeItems
        {
            get;
            set;
        }

        public ItemCollection<Folder> Folders
        {
            get;
            set;
        }

        public ItemCollection<EmbeddedResource> EmbeddedResources
        {
            get;
            set;
        }

        public ItemCollection<Service> Services
        {
            get;
            set;
        }

        public ItemCollection<FxCopRuleAssemblies> FxCopRuleAssemblies
        {
            get;
            set;
        }

        public ItemCollection<ApplicationDefinition> ApplicationDefinitions
        {
            get;
            set;
        }

        public ItemCollection<TypeScriptCompile> TypeScriptCompiles
        {
            get;
            set;
        }

        public ItemCollection<ProjectCapability> ProjectCapabilities
        {
            get;
            set;
        }

        public ItemCollection<BootstrapperPackage> BootstrapperPackages
        {
            get;
            set;
        }

        public ItemCollection<DocFileItem> DocFileItems
        {
            get;
            set;
        }

        public ItemCollection<FinalDocFile> FinalDocFiles
        {
            get;
            set;
        }

        public ItemCollection<DocumentationProjectOutputGroupOutput> DocumentationProjectOutputGroupOutputs
        {
            get;
            set;
        }

        public ItemCollection<Page> Pages
        {
            get;
            set;
        }

        public ItemCollection<Resource> Resources
        {
            get;
            set;
        }

        public ItemCollection<_IntermediateOutputPathItem> _IntermediateOutputPathItems
        {
            get;
            set;
        }

        public ItemCollection<PackageSource> PackageSourcesCollection
        {
            get;
            set;
        }

        public ItemCollection<AppDesigner> AppDesigners
        {
            get;
            set;
        }

        public ItemCollection<AppxHashUri> AppxHashUris
        {
            get;
            set;
        }

        public ItemCollection<AppxSystemBinary> AppxSystemBinaries
        {
            get;
            set;
        }

        public ItemCollection<AppxReservedFileName> AppxReservedFileNames
        {
            get;
            set;
        }

        public ItemCollection<AppxManifestFileNameQuery> AppxManifestFileNameQueries
        {
            get;
            set;
        }

        public ItemCollection<AppxManifestImageFileNameQuery> AppxManifestImageFileNameQueries
        {
            get;
            set;
        }

        public ItemCollection<AppxManifestMetadata> AppxManifestMetadatas
        {
            get;
            set;
        }

        public ItemCollection<AppxManifestMetaData> AppxManifestMetaDatas
        {
            get;
            set;
        }

        public ItemCollection<PlatformVersionDescription> PlatformVersionDescriptions
        {
            get;
            set;
        }

        public ItemCollection<XamlIntermediateAssembly> XamlIntermediateAssemblies
        {
            get;
            set;
        }

        public ItemCollection<SDKReference> SDKReferences
        {
            get;
            set;
        }

        public ItemCollection<AppxManifest> AppxManifests
        {
            get;
            set;
        }

        public ItemCollection<UpToDateCheckOutput> UpToDateCheckOutputs
        {
            get;
            set;
        }

        public ItemCollection<BundleResource> BundleResources
        {
            get;
            set;
        }

        public ItemCollection<EntityDeploy> EntityDeploys
        {
            get;
            set;
        }

        public ItemCollection<_DeploymentManifestIconFile> _DeploymentManifestIconFiles
        {
            get;
            set;
        }

        public ItemCollection<TargetPlatform> TargetPlatforms
        {
            get;
            set;
        }

        public ItemCollection<PropertyPageSchema> PropertyPageSchemas
        {
            get;
            set;
        }

        public ItemCollection<PackageFiles> PackageFiles
        {
            get;
            set;
        }

        public ItemCollection<WCFMetadataStorage> WCFMetadataStorages
        {
            get;
            set;
        }

        public string MSBuildToolsVersion
        {
            get;
            set;
        }

        public string MSBuildToolsPath
        {
            get;
            set;
        }

        public string MSBuildBinPath
        {
            get;
            set;
        }

        public string MSBuildStartupDirectory
        {
            get;
            set;
        }

        public int? MSBuildNodeCount
        {
            get;
            set;
        }

        public string MSBuildProgramFiles32
        {
            get;
            set;
        }

        public string MSBuildProjectFile
        {
            get;
            set;
        }

        public string MSBuildProjectName
        {
            get;
            set;
        }

        public string MSBuildProjectExtension
        {
            get;
            set;
        }

        public string MSBuildProjectFullPath
        {
            get;
            set;
        }

        public string MSBuildProjectDirectory
        {
            get;
            set;
        }

        public string MSBuildProjectDirectoryNoRoot
        {
            get;
            set;
        }

        public string MSBuildExtensionsPath32
        {
            get;
            set;
        }

        public string MSBuildExtensionsPath64
        {
            get;
            set;
        }

        public string MSBuildExtensionsPath
        {
            get;
            set;
        }

        public string LOCALAPPDATA
        {
            get;
            set;
        }

        public string MSBuildUserExtensionsPath
        {
            get;
            set;
        }

        public string ALLUSERSPROFILE
        {
            get;
            set;
        }

        public string APPDATA
        {
            get;
            set;
        }

        public string CommonProgramFiles
        {
            get;
            set;
        }

        public string CommonProgramW6432
        {
            get;
            set;
        }

        public string COMPUTERNAME
        {
            get;
            set;
        }

        public string ComSpec
        {
            get;
            set;
        }

        public string configsetroot
        {
            get;
            set;
        }

        public string FP_NO_HOST_CHECK
        {
            get;
            set;
        }

        public string HOMEDRIVE
        {
            get;
            set;
        }

        public string HOMEPATH
        {
            get;
            set;
        }

        public string JAVA_HOME
        {
            get;
            set;
        }

        public string LOGONSERVER
        {
            get;
            set;
        }

        public bool? MSBuildLoadMicrosoftTargetsReadOnly
        {
            get;
            set;
        }

        public int? NUMBER_OF_PROCESSORS
        {
            get;
            set;
        }

        public string OS
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }

        public string PATHEXT
        {
            get;
            set;
        }

        public string PkgDefApplicationConfigFile
        {
            get;
            set;
        }

        public string PROCESSOR_ARCHITECTURE
        {
            get;
            set;
        }

        public string PROCESSOR_ARCHITEW6432
        {
            get;
            set;
        }

        public string PROCESSOR_IDENTIFIER
        {
            get;
            set;
        }

        public int? PROCESSOR_LEVEL
        {
            get;
            set;
        }

        public int? PROCESSOR_REVISION
        {
            get;
            set;
        }

        public string ProgramData
        {
            get;
            set;
        }

        public string ProgramFiles
        {
            get;
            set;
        }

        public string ProgramW6432
        {
            get;
            set;
        }

        public string PSModulePath
        {
            get;
            set;
        }

        public string PUBLIC
        {
            get;
            set;
        }

        public string SystemDrive
        {
            get;
            set;
        }

        public string SystemRoot
        {
            get;
            set;
        }

        public string TEMP
        {
            get;
            set;
        }

        public string TMP
        {
            get;
            set;
        }

        public string UOIPME_REG_PATH
        {
            get;
            set;
        }

        public string USERDOMAIN
        {
            get;
            set;
        }

        public string USERDOMAIN_ROAMINGPROFILE
        {
            get;
            set;
        }

        public string USERNAME
        {
            get;
            set;
        }

        public string USERPROFILE
        {
            get;
            set;
        }

        public string VisualStudioDir
        {
            get;
            set;
        }

        public string VisualStudioEdition
        {
            get;
            set;
        }

        public string VisualStudioVersion
        {
            get;
            set;
        }

        public string VS110COMNTOOLS
        {
            get;
            set;
        }

        public string VS120COMNTOOLS
        {
            get;
            set;
        }

        public string VS140COMNTOOLS
        {
            get;
            set;
        }

        public int? VSLANG
        {
            get;
            set;
        }

        public string windir
        {
            get;
            set;
        }

        public string SDK35ToolsPath
        {
            get;
            set;
        }

        public string MSBuildToolsPath32
        {
            get;
            set;
        }

        public string MSBuildToolsRoot
        {
            get;
            set;
        }

        public string FrameworkSDKRoot
        {
            get;
            set;
        }

        public string MSBuildRuntimeVersion
        {
            get;
            set;
        }

        public string SDK40ToolsPath
        {
            get;
            set;
        }

        public string Configuration
        {
            get;
            set;
        }

        public string MSBuildProjectDefaultTargets
        {
            get;
            set;
        }

        public string Platform
        {
            get;
            set;
        }

        public string ProjectGuid
        {
            get;
            set;
        }

        public string OutputType
        {
            get;
            set;
        }

        public string AppDesignerFolder
        {
            get;
            set;
        }

        public string RootNamespace
        {
            get;
            set;
        }

        public string AssemblyName
        {
            get;
            set;
        }

        public string TargetFrameworkVersion
        {
            get;
            set;
        }

        public int? FileAlignment
        {
            get;
            set;
        }

        public string SolutionDir
        {
            get;
            set;
        }

        public bool? RestorePackages
        {
            get;
            set;
        }

        public string PlatformTarget
        {
            get;
            set;
        }

        public bool? DebugSymbols
        {
            get;
            set;
        }

        public string DebugType
        {
            get;
            set;
        }

        public bool? Optimize
        {
            get;
            set;
        }

        public string OutputPath
        {
            get;
            set;
        }

        public string DefineConstants
        {
            get;
            set;
        }

        public string ErrorReport
        {
            get;
            set;
        }

        public int? WarningLevel
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public string CustomBeforeMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public string CustomAfterMicrosoftCSharpTargets
        {
            get;
            set;
        }

        public string MSBuildAllProjects
        {
            get;
            set;
        }

        public string DefaultLanguageSourceExtension
        {
            get;
            set;
        }

        public string Language
        {
            get;
            set;
        }

        public string TargetRuntime
        {
            get;
            set;
        }

        public string CreateManifestResourceNamesDependsOn
        {
            get;
            set;
        }

        public bool? UseHostCompilerIfAvailable
        {
            get;
            set;
        }

        public string CoreCompileDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftCommonTargets
        {
            get;
            set;
        }

        public string CustomBeforeMicrosoftCommonTargets
        {
            get;
            set;
        }

        public string CustomAfterMicrosoftCommonTargets
        {
            get;
            set;
        }

        public string ReportingServicesTargets
        {
            get;
            set;
        }

        public string TargetFrameworkIdentifier
        {
            get;
            set;
        }

        public string AvailablePlatforms
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? UpgradeSubsetToProfile
        {
            get;
            set;
        }

        public bool? AddAdditionalExplicitAssemblyReferences
        {
            get;
            set;
        }

        public string AdditionalExplicitAssemblyReferences
        {
            get;
            set;
        }

        public string TargetFrameworkSDKToolsDirectory
        {
            get;
            set;
        }

        public string TargetedRuntimeVersion
        {
            get;
            set;
        }

        public bool? Prefer32Bit
        {
            get;
            set;
        }

        public bool? HighEntropyVA
        {
            get;
            set;
        }

        public string SubsystemVersion
        {
            get;
            set;
        }

        public bool? ImplicitlyExpandDesignTimeFacades
        {
            get;
            set;
        }

        public bool? YieldDuringToolExecution
        {
            get;
            set;
        }

        public string TargetFrameworkMoniker
        {
            get;
            set;
        }

        public string FrameworkPathOverride
        {
            get;
            set;
        }

        public string TargetPlatformIdentifier
        {
            get;
            set;
        }

        public string TargetPlatformVersion
        {
            get;
            set;
        }

        public string TargetPlatformSdkPath
        {
            get;
            set;
        }

        public string TargetPlatformMoniker
        {
            get;
            set;
        }

        public string _OriginalConfiguration
        {
            get;
            set;
        }

        public string _OriginalPlatform
        {
            get;
            set;
        }

        public string ConfigurationName
        {
            get;
            set;
        }

        public bool? _DebugSymbolsProduced
        {
            get;
            set;
        }

        public bool? _DocumentationFileProduced
        {
            get;
            set;
        }

        public string TargetExt
        {
            get;
            set;
        }

        public string OutDir
        {
            get;
            set;
        }

        public string ProjectName
        {
            get;
            set;
        }

        public string TargetName
        {
            get;
            set;
        }

        public string ProjectFileName
        {
            get;
            set;
        }

        public string ProjectExt
        {
            get;
            set;
        }

        public string TargetFileName
        {
            get;
            set;
        }

        public bool? _DeploymentPublishableProjectDefault
        {
            get;
            set;
        }

        public string PublishableProject
        {
            get;
            set;
        }

        public string _DeploymentTargetApplicationManifestFileName
        {
            get;
            set;
        }

        public string TargetDeployManifestFileName
        {
            get;
            set;
        }

        public string GenerateClickOnceManifests
        {
            get;
            set;
        }

        public string _DeploymentApplicationManifestIdentity
        {
            get;
            set;
        }

        public string _DeploymentDeployManifestIdentity
        {
            get;
            set;
        }

        public string _DeploymentFileMappingExtension
        {
            get;
            set;
        }

        public int? _DeploymentBuiltUpdateInterval
        {
            get;
            set;
        }

        public string _DeploymentBuiltUpdateIntervalUnits
        {
            get;
            set;
        }

        public int? MaxTargetPath
        {
            get;
            set;
        }

        public string TargetCulture
        {
            get;
            set;
        }

        public string TargetDir
        {
            get;
            set;
        }

        public string TargetPath
        {
            get;
            set;
        }

        public string ProjectDir
        {
            get;
            set;
        }

        public string ProjectPath
        {
            get;
            set;
        }

        public string PlatformName
        {
            get;
            set;
        }

        public string DevEnvDir
        {
            get;
            set;
        }

        public string SolutionName
        {
            get;
            set;
        }

        public string SolutionFileName
        {
            get;
            set;
        }

        public string SolutionPath
        {
            get;
            set;
        }

        public string SolutionExt
        {
            get;
            set;
        }

        public bool? AutoUnifyAssemblyReferences
        {
            get;
            set;
        }

        public string BaseIntermediateOutputPath
        {
            get;
            set;
        }

        public string CleanFile
        {
            get;
            set;
        }

        public bool? BuildProjectReferences
        {
            get;
            set;
        }

        public bool? BuildInParallel
        {
            get;
            set;
        }

        public bool? _ResolveReferenceDependencies
        {
            get;
            set;
        }

        public bool? _GetChildProjectCopyToOutputDirectoryItems
        {
            get;
            set;
        }

        public bool? OverwriteReadOnlyFiles
        {
            get;
            set;
        }

        public bool? ComReferenceNoClassMembers
        {
            get;
            set;
        }

        public string IntermediateOutputPath
        {
            get;
            set;
        }

        public string _DeploymentUrl
        {
            get;
            set;
        }

        public string PublishDir
        {
            get;
            set;
        }

        public string ProcessorArchitecture
        {
            get;
            set;
        }

        public bool? ConsiderPlatformAsProcessorArchitecture
        {
            get;
            set;
        }

        public string TargetFrameworkAsMSBuildRuntime
        {
            get;
            set;
        }

        public bool? PlatformTargetAsMSBuildArchitectureExplicitlySet
        {
            get;
            set;
        }

        public string PlatformTargetAsMSBuildArchitecture
        {
            get;
            set;
        }

        public string ProjectFlavor
        {
            get;
            set;
        }

        public string DelaySign
        {
            get;
            set;
        }

        public bool? WebReference_EnableProperties
        {
            get;
            set;
        }

        public bool? WebReference_EnableSQLTypes
        {
            get;
            set;
        }

        public bool? WebReference_EnableLegacyEventingModel
        {
            get;
            set;
        }

        public string AssemblyFoldersSuffix
        {
            get;
            set;
        }

        public string FrameworkRegistryBase
        {
            get;
            set;
        }

        public string TargetPlatformRegistryBase
        {
            get;
            set;
        }

        public string AssemblySearchPaths
        {
            get;
            set;
        }

        public string AllowedReferenceAssemblyFileExtensions
        {
            get;
            set;
        }

        public string AllowedReferenceRelatedFileExtensions
        {
            get;
            set;
        }

        public string FullReferenceAssemblyNames
        {
            get;
            set;
        }

        public bool? ContinueOnError
        {
            get;
            set;
        }

        public string BuildDependsOn
        {
            get;
            set;
        }

        public string CoreBuildDependsOn
        {
            get;
            set;
        }

        public string _ProjectDefaultTargets
        {
            get;
            set;
        }

        public string RebuildDependsOn
        {
            get;
            set;
        }

        public string BuildGenerateSourcesAction
        {
            get;
            set;
        }

        public string BuildCompileAction
        {
            get;
            set;
        }

        public string BuildLinkAction
        {
            get;
            set;
        }

        public string RunDependsOn
        {
            get;
            set;
        }

        public bool? BuildingProject
        {
            get;
            set;
        }

        public string PrepareForBuildDependsOn
        {
            get;
            set;
        }

        public string Framework40Dir
        {
            get;
            set;
        }

        public string Framework35Dir
        {
            get;
            set;
        }

        public string Framework30Dir
        {
            get;
            set;
        }

        public string Framework20Dir
        {
            get;
            set;
        }

        public string FrameworkDir
        {
            get;
            set;
        }

        public string TargetedFrameworkDir
        {
            get;
            set;
        }

        public string FrameworkSDKDir
        {
            get;
            set;
        }

        public string GetFrameworkPathsDependsOn
        {
            get;
            set;
        }

        public string PreBuildEventDependsOn
        {
            get;
            set;
        }

        public string UnmanagedUnregistrationDependsOn
        {
            get;
            set;
        }

        public string ResolveReferencesDependsOn
        {
            get;
            set;
        }

        public string GetTargetPathDependsOn
        {
            get;
            set;
        }

        public string ResolveAssemblyReferencesDependsOn
        {
            get;
            set;
        }

        public string SDKReferenceRegistryRoot
        {
            get;
            set;
        }

        public string SDKReferenceDirectoryRoot
        {
            get;
            set;
        }

        public string ResolveSDKReferencesDependsOn
        {
            get;
            set;
        }

        public string TargetedSDKConfiguration
        {
            get;
            set;
        }

        public string TargetedSDKArchitecture
        {
            get;
            set;
        }

        public string ExpandSDKReferencesDependsOn
        {
            get;
            set;
        }

        public string ExpandSDKAllowedReferenceExtensions
        {
            get;
            set;
        }

        public string ProjectDesignTimeAssemblyResolutionSearchPaths
        {
            get;
            set;
        }

        public string DesignTimeResolveAssemblyReferencesDependsOn
        {
            get;
            set;
        }

        public bool? ComReferenceExecuteAsTool
        {
            get;
            set;
        }

        public string PrepareResourcesDependsOn
        {
            get;
            set;
        }

        public string PrepareResourceNamesDependsOn
        {
            get;
            set;
        }

        public string AssignTargetPathsDependsOn
        {
            get;
            set;
        }

        public string CreateCustomManifestResourceNamesDependsOn
        {
            get;
            set;
        }

        public string ResGenDependsOn
        {
            get;
            set;
        }

        public string CoreResGenDependsOn
        {
            get;
            set;
        }

        public bool? UseSourcePath
        {
            get;
            set;
        }

        public bool? ResGenExecuteAsTool
        {
            get;
            set;
        }

        public string CompileLicxFilesDependsOn
        {
            get;
            set;
        }

        public string CompileDependsOn
        {
            get;
            set;
        }

        public string TargetFrameworkMonikerAssemblyAttributesPath
        {
            get;
            set;
        }

        public bool? GenerateTargetFrameworkAttribute
        {
            get;
            set;
        }

        public string _SGenDllName
        {
            get;
            set;
        }

        public bool? _SGenDllCreated
        {
            get;
            set;
        }

        public string _SGenGenerateSerializationAssembliesConfig
        {
            get;
            set;
        }

        public bool? SGenUseProxyTypes
        {
            get;
            set;
        }

        public bool? SGenShouldGenerateSerializer
        {
            get;
            set;
        }

        public string CreateSatelliteAssembliesDependsOn
        {
            get;
            set;
        }

        public string ComputeIntermediateSatelliteAssembliesDependsOn
        {
            get;
            set;
        }

        public string EmbeddedWin32Manifest
        {
            get;
            set;
        }

        public string GenerateManifestsDependsOn
        {
            get;
            set;
        }

        public bool? SkipCopyUnchangedFiles
        {
            get;
            set;
        }

        public bool? UseCommonOutputDirectory
        {
            get;
            set;
        }

        public string PrepareForRunDependsOn
        {
            get;
            set;
        }

        public bool? CreateHardLinksForCopyAdditionalFilesIfPossible
        {
            get;
            set;
        }

        public string GetCopyToOutputDirectoryItemsDependsOn
        {
            get;
            set;
        }

        public string UnmanagedRegistrationDependsOn
        {
            get;
            set;
        }

        public string CleanDependsOn
        {
            get;
            set;
        }

        public string CoreCleanDependsOn
        {
            get;
            set;
        }

        public string PostBuildEventDependsOn
        {
            get;
            set;
        }

        public string PublishDependsOn
        {
            get;
            set;
        }

        public string PublishOnlyDependsOn
        {
            get;
            set;
        }

        public string PublishBuildDependsOn
        {
            get;
            set;
        }

        public string BuiltProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public bool? AddAppConfigToBuildOutputs
        {
            get;
            set;
        }

        public string DebugSymbolsProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public string DocumentationProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public string SatelliteDllsProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public string SourceFilesProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public string ContentFilesProjectOutputGroupDependsOn
        {
            get;
            set;
        }

        public string SGenFilesOutputGroupDependsOn
        {
            get;
            set;
        }

        public string SDKRedistOutputGroupDependsOn
        {
            get;
            set;
        }

        public string CodeAnalysisTargets
        {
            get;
            set;
        }

        public string CodeAnalysisStaticAnalysisDirectory
        {
            get;
            set;
        }

        public string CodeAnalysisRuleSetDirectories
        {
            get;
            set;
        }

        public string CodeAnalysisPath
        {
            get;
            set;
        }

        public bool? CodeAnalysisApplyLogFileXsl
        {
            get;
            set;
        }

        public bool? CodeAnalysisFailOnMissingRules
        {
            get;
            set;
        }

        public bool? CodeAnalysisForceOutput
        {
            get;
            set;
        }

        public bool? CodeAnalysisGenerateSuccessFile
        {
            get;
            set;
        }

        public bool? CodeAnalysisIgnoreGeneratedCode
        {
            get;
            set;
        }

        public bool? CodeAnalysisIgnoreInvalidTargets
        {
            get;
            set;
        }

        public bool? CodeAnalysisIgnoreMissingIndirectReferences
        {
            get;
            set;
        }

        public string CodeAnalysisInputAssembly
        {
            get;
            set;
        }

        public string CodeAnalysisLogFile
        {
            get;
            set;
        }

        public string CodeAnalysisModuleSuppressionsFile
        {
            get;
            set;
        }

        public bool? CodeAnalysisOverrideRuleVisibilities
        {
            get;
            set;
        }

        public bool? CodeAnalysisOutputToConsole
        {
            get;
            set;
        }

        public bool? CodeAnalysisQuiet
        {
            get;
            set;
        }

        public string CodeAnalysisRuleDirectories
        {
            get;
            set;
        }

        public string CodeAnalysisSaveMessagesToReport
        {
            get;
            set;
        }

        public bool? CodeAnalysisSearchGlobalAssemblyCache
        {
            get;
            set;
        }

        public string CodeAnalysisSucceededFile
        {
            get;
            set;
        }

        public bool? CodeAnalysisSummary
        {
            get;
            set;
        }

        public int? CodeAnalysisTimeout
        {
            get;
            set;
        }

        public bool? CodeAnalysisTreatWarningsAsErrors
        {
            get;
            set;
        }

        public bool? CodeAnalysisUpdateProject
        {
            get;
            set;
        }

        public bool? CodeAnalysisUseTypeNameInSuppression
        {
            get;
            set;
        }

        public bool? CodeAnalysisVerbose
        {
            get;
            set;
        }

        public string CodeAnalysisRuleSet
        {
            get;
            set;
        }

        public string RunCodeAnalysisDependsOn
        {
            get;
            set;
        }

        public string RunCodeAnalysisInputs
        {
            get;
            set;
        }

        public string RunNativeCodeAnalysisInputs
        {
            get;
            set;
        }

        public string MergedOutputCodeAnalysisFile
        {
            get;
            set;
        }

        public string CompileRdlFilesDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public string ImplicitlyExpandDesignTimeFacadesDependsOn
        {
            get;
            set;
        }

        public string BuildSystem
        {
            get;
            set;
        }

        public string TaskVersion
        {
            get;
            set;
        }

        public string TaskKeyToken
        {
            get;
            set;
        }

        public string BuildTaskAssembly
        {
            get;
            set;
        }

        public bool? AlwaysCompileMarkupFilesInSeparateDomain
        {
            get;
            set;
        }

        public string LocalizationDirectivesToLocFile
        {
            get;
            set;
        }

        public string GetReferenceAssemblyPathsDependsOn
        {
            get;
            set;
        }

        public bool? XamlDebuggingInformation
        {
            get;
            set;
        }

        public bool? HostInBrowser
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public string DeploymentType
        {
            get;
            set;
        }

        public bool? RunAfterInstall
        {
            get;
            set;
        }

        public string GeneratedFileExtension
        {
            get;
            set;
        }

        public string OSVersion
        {
            get;
            set;
        }

        public bool? _RequireMCPass2ForSatelliteAssemblyOnly
        {
            get;
            set;
        }

        public bool? _RequireMCPass2ForMainAssembly
        {
            get;
            set;
        }

        public bool? IsApplication
        {
            get;
            set;
        }

        public string _AfterCompileWinFXInternalDependsOn
        {
            get;
            set;
        }

        public string MarkupCompilePass2ForMainAssemblyDependsOn
        {
            get;
            set;
        }

        public string _CompileTargetNameForLocalType
        {
            get;
            set;
        }

        public string _ResourceNameInMainAssembly
        {
            get;
            set;
        }

        public string EntityDeployIntermediateResourcePath
        {
            get;
            set;
        }

        public string EntityDeployDependsOn
        {
            get;
            set;
        }

        public string LoadTimeSensitiveTargets
        {
            get;
            set;
        }

        public string LoadTimeSensitiveProperties
        {
            get;
            set;
        }

        public string XamlBuildTaskAssemblyName
        {
            get;
            set;
        }

        public bool? XamlRequiresCompilationPass2
        {
            get;
            set;
        }

        public string XamlTemporaryAssemblyName
        {
            get;
            set;
        }

        public string CompileTargetNameForTemporaryAssembly
        {
            get;
            set;
        }

        public string XamlBuildTaskLocation
        {
            get;
            set;
        }

        public string XamlGenCodeFileNames
        {
            get;
            set;
        }

        public string XamlGenMarkupFileNames
        {
            get;
            set;
        }

        public string XamlPass2FlagFile
        {
            get;
            set;
        }

        public string DesignTimeIntermediateOutputPath
        {
            get;
            set;
        }

        public string WorkflowBuildExtensionVersion
        {
            get;
            set;
        }

        public string WorkflowBuildExtensionKeyToken
        {
            get;
            set;
        }

        public string WorkflowBuildExtensionAssemblyName
        {
            get;
            set;
        }

        public string GenerateCompiledExpressionsTempFilePathForEditing
        {
            get;
            set;
        }

        public string GenerateCompiledExpressionsTempFilePathForValidation
        {
            get;
            set;
        }

        public string GenerateCompiledExpressionsTempFilePathForTypeInfer
        {
            get;
            set;
        }

        public string DeferredValidationErrorsFileName
        {
            get;
            set;
        }

        public string MsTestToolsTargets
        {
            get;
            set;
        }

        public string MsAppxPackageTargets
        {
            get;
            set;
        }

        public bool? Utf8Output
        {
            get;
            set;
        }

        public bool? NoCompilerStandardLib
        {
            get;
            set;
        }

        public bool? BuildPackage
        {
            get;
            set;
        }

        public bool? RequireRestoreConsent
        {
            get;
            set;
        }

        public bool? DownloadNuGetExe
        {
            get;
            set;
        }

        public string NuGetToolsPath
        {
            get;
            set;
        }

        public string PackagesConfig
        {
            get;
            set;
        }

        public string NuGetExePath
        {
            get;
            set;
        }

        public string PackageSources
        {
            get;
            set;
        }

        public string NuGetCommand
        {
            get;
            set;
        }

        public string PackageOutputDir
        {
            get;
            set;
        }

        public string RequireConsentSwitch
        {
            get;
            set;
        }

        public string RestoreCommand
        {
            get;
            set;
        }

        public string BuildCommand
        {
            get;
            set;
        }

        public string ProcessorArchitectureAsPlatform
        {
            get;
            set;
        }

        public bool? IsLibrary
        {
            get;
            set;
        }

        public string ProductVersion
        {
            get;
            set;
        }

        public string SchemaVersion
        {
            get;
            set;
        }

        public string ProjectTypeGuids
        {
            get;
            set;
        }

        public bool? UseIISExpress
        {
            get;
            set;
        }

        public string IISExpressSSLPort
        {
            get;
            set;
        }

        public string IISExpressAnonymousAuthentication
        {
            get;
            set;
        }

        public string IISExpressWindowsAuthentication
        {
            get;
            set;
        }

        public string IISExpressUseClassicPipelineMode
        {
            get;
            set;
        }

        public string VSToolsPath
        {
            get;
            set;
        }

        public bool? WebProjectOutputDirInsideProjectDefault
        {
            get;
            set;
        }

        public string WebProjectOutputDirInsideProject
        {
            get;
            set;
        }

        public bool? DisableLinkInCopyWebApplicaton
        {
            get;
            set;
        }

        public bool? Disable_CopyWebApplication
        {
            get;
            set;
        }

        public bool? UseWPP_CopyWebApplication
        {
            get;
            set;
        }

        public bool? CleanWebProjectOutputDir
        {
            get;
            set;
        }

        public string WebProjectOutputDir
        {
            get;
            set;
        }

        public string CleanWebProjectOutputDirDependsOn
        {
            get;
            set;
        }

        public string OnBefore_CopyWebApplicationDefault
        {
            get;
            set;
        }

        public string OnBefore_CopyWebApplication
        {
            get;
            set;
        }

        public string OnAfter_CopyWebApplication
        {
            get;
            set;
        }

        public string _CopyWebApplicationDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingTargets
        {
            get;
            set;
        }

        public string _WPPVersion
        {
            get;
            set;
        }

        public string _WPPSupports
        {
            get;
            set;
        }

        public string _WPPWebPublishMethodSupports
        {
            get;
            set;
        }

        public string WebPublishPipelineProjectDirectory
        {
            get;
            set;
        }

        public string WebPublishPipelineSourceRootDirectory
        {
            get;
            set;
        }

        public string WebPublishPipelineTransformRootDirectory
        {
            get;
            set;
        }

        public string WebPublishPipelineProjectName
        {
            get;
            set;
        }

        public string WebPublishPipelineProjectFile
        {
            get;
            set;
        }

        public string WebPublishPipeLineProjectFullPath
        {
            get;
            set;
        }

        public string WebPublishPipelineWAPProjectSettings
        {
            get;
            set;
        }

        public bool? VerifyDatabaseSettingWithImport
        {
            get;
            set;
        }

        public string _LocalDBVersionToUseForSqlExpress
        {
            get;
            set;
        }

        public bool? _PublishProfileSet
        {
            get;
            set;
        }

        public bool? EnableWebPublishProfileFile
        {
            get;
            set;
        }

        public string _WPPDefaultIntermediateOutputPath
        {
            get;
            set;
        }

        public string _WPPDefaultIntermediateOutputFullPath
        {
            get;
            set;
        }

        public string PublishProfileRootFolder
        {
            get;
            set;
        }

        public string PublishProfileName
        {
            get;
            set;
        }

        public bool? _WebPublishProfileFileWillBeImported
        {
            get;
            set;
        }

        public string WebPublishPipelineCustomizeTargetFile
        {
            get;
            set;
        }

        public string WebPublishPipelineSolutionTargetFile
        {
            get;
            set;
        }

        public string _WPPCleanTargets
        {
            get;
            set;
        }

        public string FilesToIncludeForPublish
        {
            get;
            set;
        }

        public string AlternativeProjectDirectory
        {
            get;
            set;
        }

        public bool? ExcludeGeneratedDebugSymbol
        {
            get;
            set;
        }

        public bool? ExcludeXmlAssemblyFiles
        {
            get;
            set;
        }

        public bool? ExcludeApp_Data
        {
            get;
            set;
        }

        public string SkipApp_DataFolder
        {
            get;
            set;
        }

        public bool? UseMsdeployExe
        {
            get;
            set;
        }

        public bool? EnableCollectLinkFilesInProject
        {
            get;
            set;
        }

        public bool? ExcludeLinkFilesInProject
        {
            get;
            set;
        }

        public bool? CleanWPPAllFilesInSingleFolder
        {
            get;
            set;
        }

        public bool? IncludeIisSettings
        {
            get;
            set;
        }

        public bool? ExcludeFilesFromPackage
        {
            get;
            set;
        }

        public bool? ImportParametersFiles
        {
            get;
            set;
        }

        public bool? ImportParametersFile_DisableEscapeMSBuildVariable
        {
            get;
            set;
        }

        public bool? ImportProjectParametersFiles
        {
            get;
            set;
        }

        public bool? ImportProfileParametersFiles
        {
            get;
            set;
        }

        public bool? ImportPublishingParameterValues
        {
            get;
            set;
        }

        public bool? EnableOptimisticParameterDefaultValue
        {
            get;
            set;
        }

        public bool? ParameterApplicationPool
        {
            get;
            set;
        }

        public bool? IIS6ParameterApplicationPool
        {
            get;
            set;
        }

        public bool? DisableAllVSGeneratedMSDeployParameter
        {
            get;
            set;
        }

        public bool? AutoParameterizationWebConfigConnectionStrings
        {
            get;
            set;
        }

        public bool? AutoParameterizationWebConfigCSNoDefaultValue
        {
            get;
            set;
        }

        public string AutoParameterizationWebConfigConnectionStringsIntermediateOutput
        {
            get;
            set;
        }

        public string AutoParameterizationWebConfigConnectionStringsLocation
        {
            get;
            set;
        }

        public string _WPPLastBuildInfoIntermediateOutput
        {
            get;
            set;
        }

        public string _WPPLastBuildInfoLocation
        {
            get;
            set;
        }

        public bool? InsertAdditionalWebCofigConnectionStrings
        {
            get;
            set;
        }

        public string InsertAdditionalWebCofigConnectionStringsIntermediateOutput
        {
            get;
            set;
        }

        public string InsertAdditionalWebCofigConnectionStringsLocation
        {
            get;
            set;
        }

        public string InsertAdditionalWebConfigConnectionStringProviderName
        {
            get;
            set;
        }

        public bool? InsertAdditionalWebConfigConnectionStringOnlyInRoot
        {
            get;
            set;
        }

        public string SqlScriptSourceTransacted
        {
            get;
            set;
        }

        public string AutoSqlScriptSourceTransacted
        {
            get;
            set;
        }

        public string DatabaseDeployIntermediateRelativePath
        {
            get;
            set;
        }

        public string DatabaseDeployIntermediateOutputPath
        {
            get;
            set;
        }

        public string _WebConfigsToAutoParmeterizeCsTransformOutputParametersFile
        {
            get;
            set;
        }

        public string DeployDefaultTarget
        {
            get;
            set;
        }

        public string DeployTarget
        {
            get;
            set;
        }

        public int? RetryAttemptsForDeployment
        {
            get;
            set;
        }

        public bool? DeployOnBuildDefault
        {
            get;
            set;
        }

        public string DeployOnBuild
        {
            get;
            set;
        }

        public bool? EnableMSDeployBackup
        {
            get;
            set;
        }

        public bool? EnableMSDeployAppOffline
        {
            get;
            set;
        }

        public bool? MSDeployUseChecksum
        {
            get;
            set;
        }

        public bool? MSDeployEnableWebConfigEncryptRule
        {
            get;
            set;
        }

        public string MSDeployWebConfigEncryptProvider
        {
            get;
            set;
        }

        public string _MSDeployUserAgentSource
        {
            get;
            set;
        }

        public string _MSDeployUserAgent
        {
            get;
            set;
        }

        public bool? PipelineDependsOnBuild
        {
            get;
            set;
        }

        public string _DeployOnBuild
        {
            get;
            set;
        }

        public bool? WPPCopyWebApplicaitonPipelineCircularDependencyError
        {
            get;
            set;
        }

        public string PipelineDependsOn
        {
            get;
            set;
        }

        public string ProjectConfigFileName
        {
            get;
            set;
        }

        public string _ProjectConfigFileExtension
        {
            get;
            set;
        }

        public string _ProjectConfigFilePrefix
        {
            get;
            set;
        }

        public string ProjectConfigTransformFileName
        {
            get;
            set;
        }

        public bool? TransformWebConfigEnabled
        {
            get;
            set;
        }

        public bool? TransformWebConfigStackTraceEnabled
        {
            get;
            set;
        }

        public bool? UseParameterizeToTransformWebConfig
        {
            get;
            set;
        }

        public string TransformWebConfigIntermediateOutput
        {
            get;
            set;
        }

        public string TransformWebConfigIntermediateLocation
        {
            get;
            set;
        }

        public string _WebConfigTransformOutputParametersFile
        {
            get;
            set;
        }

        public bool? ProfileTransformWebConfigEnabled
        {
            get;
            set;
        }

        public bool? ProfileTransformWebConfigStackTraceEnabled
        {
            get;
            set;
        }

        public bool? UseParameterizeToProfileTransformWebConfig
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigIntermediateOutput
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigIntermediateLocation
        {
            get;
            set;
        }

        public string _ProfileWebConfigTransformOutputParametersFile
        {
            get;
            set;
        }

        public bool? ParameterizeTransformXmlUseXPath
        {
            get;
            set;
        }

        public string DefaultPackageOutputDir
        {
            get;
            set;
        }

        public string DefaultPackageFileName
        {
            get;
            set;
        }

        public string DefaultMSDeployDestinationSite
        {
            get;
            set;
        }

        public string DefaultMsDeployAltSuffix
        {
            get;
            set;
        }

        public string DefaultMSDeployDestinationApplicationName
        {
            get;
            set;
        }

        public string DefaultDeployIisAppPath
        {
            get;
            set;
        }

        public string DefaultDeployIisRootAppPath
        {
            get;
            set;
        }

        public bool? PackageAsSingleFile
        {
            get;
            set;
        }

        public string PackageLocation
        {
            get;
            set;
        }

        public string PackageFileName
        {
            get;
            set;
        }

        public string PackageArchiveRootDir
        {
            get;
            set;
        }

        public string PackageTempRootDir
        {
            get;
            set;
        }

        public bool? DeployAsIisApp
        {
            get;
            set;
        }

        public bool? IncludeSetAclProviderOnDestination
        {
            get;
            set;
        }

        public bool? MarkApp_DataWritableOnDestination
        {
            get;
            set;
        }

        public bool? IgnoreDeployManagedRuntimeVersion
        {
            get;
            set;
        }

        public string DeployDefaultTargetFrameworkVersion
        {
            get;
            set;
        }

        public string DeployManagedRuntimeVersion
        {
            get;
            set;
        }

        public string DeployEnable32bitAppOnWin64
        {
            get;
            set;
        }

        public string DeployManagedPipelineMode
        {
            get;
            set;
        }

        public bool? GenerateSampleDeployScript
        {
            get;
            set;
        }

        public string PackageLogDir
        {
            get;
            set;
        }

        public bool? EnablePackageProcessLoggingAndAssert
        {
            get;
            set;
        }

        public string PackageTraceLevel
        {
            get;
            set;
        }

        public bool? _CreatePackage
        {
            get;
            set;
        }

        public bool? _UseDefaultLinkExtensionValue
        {
            get;
            set;
        }

        public string PackageEnableLinks
        {
            get;
            set;
        }

        public string PackageDisableLinks
        {
            get;
            set;
        }

        public string ProjectParametersXMLFile
        {
            get;
            set;
        }

        public bool? EnableProjectDeployParameterPrefix
        {
            get;
            set;
        }

        public string DeployParameterIISAppName
        {
            get;
            set;
        }

        public string DeployParameterIISAppPoolName
        {
            get;
            set;
        }

        public string DeployParameterApp_DataWritePermission
        {
            get;
            set;
        }

        public string DeployParameterIISAppPhysicalPath
        {
            get;
            set;
        }

        public bool? DeployParameterAutoDescriptionbyTags
        {
            get;
            set;
        }

        public string DeployParameterIISAppNameDescription
        {
            get;
            set;
        }

        public string DeployParameterIISAppPoolNameDescription
        {
            get;
            set;
        }

        public string DeployParameterIISAppPhysicalPathDescription
        {
            get;
            set;
        }

        public string DeployParameterIISAppConnectionStringDescription
        {
            get;
            set;
        }

        public string DeployParameterSqlScriptVariablesDescription
        {
            get;
            set;
        }

        public string MsDeployDatabaseTag
        {
            get;
            set;
        }

        public string MsDeploySqlCommandVariableKind
        {
            get;
            set;
        }

        public string MsdeploySqlUnsupportedCommand
        {
            get;
            set;
        }

        public bool? CheckSqlScriptForUnsupportedCommands
        {
            get;
            set;
        }

        public string UpdateFromConnectionStringAttributes
        {
            get;
            set;
        }

        public bool? TreadSqlScriptUnsupportedCommandsAsWarning
        {
            get;
            set;
        }

        public string _PackageTempDir
        {
            get;
            set;
        }

        public string WPPAllFilesInSingleFolder
        {
            get;
            set;
        }

        public bool? IsWPPAllFilesInSingleFolder
        {
            get;
            set;
        }

        public bool? EnableSqlScriptVariableParameterize
        {
            get;
            set;
        }

        public string SqlScriptPreProcessBatchDelimiter
        {
            get;
            set;
        }

        public bool? SqlScriptPreProcessResolveIncludes
        {
            get;
            set;
        }

        public string DeployIisAppPath
        {
            get;
            set;
        }

        public string RemoteSitePhysicalPath
        {
            get;
            set;
        }

        public string DefaultDeployIisAppPhysicalPath
        {
            get;
            set;
        }

        public string DeployIisAppPhysicalPath
        {
            get;
            set;
        }

        public string _DestinationIisAppPhysicalPath
        {
            get;
            set;
        }

        public string DestinationIisVersion
        {
            get;
            set;
        }

        public string DestinationUseIis
        {
            get;
            set;
        }

        public string PublishEnableLinks
        {
            get;
            set;
        }

        public string PublishDisableLinks
        {
            get;
            set;
        }

        public string DeployEncryptKey
        {
            get;
            set;
        }

        public bool? SkipExtraFilesOnServer
        {
            get;
            set;
        }

        public string MsDeployServiceUrl
        {
            get;
            set;
        }

        public int? VsIisAppParametersPriority
        {
            get;
            set;
        }

        public int? VsContentPathParametersPriority
        {
            get;
            set;
        }

        public int? VsDestinationVDirParametersPriority
        {
            get;
            set;
        }

        public int? VsSetAclPriority
        {
            get;
            set;
        }

        public int? UserProfileParametersFileParametersPriority
        {
            get;
            set;
        }

        public int? UserParametersFileParametersPriority
        {
            get;
            set;
        }

        public int? UserWebConfigParametersPriority
        {
            get;
            set;
        }

        public int? VsSQLDatabaseScriptParametersPriority
        {
            get;
            set;
        }

        public int? VsWebConfigAutoCsParametersPriority
        {
            get;
            set;
        }

        public string GenerateSampleDeployScriptLocation
        {
            get;
            set;
        }

        public string PackageSourceManifest
        {
            get;
            set;
        }

        public string UseDeclareParametersXMLInMsDeploy
        {
            get;
            set;
        }

        public string PackageParametersFile
        {
            get;
            set;
        }

        public string PublishParametersFile
        {
            get;
            set;
        }

        public string GenerateSampleDeployScriptReadMeFileName
        {
            get;
            set;
        }

        public string GenerateSampleDeployScriptReadMeLocation
        {
            get;
            set;
        }

        public string GenerateSampleParametersValueLocationDefault
        {
            get;
            set;
        }

        public string GenerateSampleParametersValueLocation
        {
            get;
            set;
        }

        public string GenerateSampleParametersValueFileName
        {
            get;
            set;
        }

        public string FilesToIncludeTargetFile
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets
        {
            get;
            set;
        }

        public string PublishPipelineCollectFilesCore
        {
            get;
            set;
        }

        public bool? ExcludeTransformAssistFilesFromPublish
        {
            get;
            set;
        }

        public string CollectFilesFromIntermediateAssemblyDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromContentDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromAddModulesDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFrom_SGenDllCreatedDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromReferenceDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromAllExtraReferenceFilesDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromDocFileItemDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFrom_binDeployableAssembliesDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets
        {
            get;
            set;
        }

        public bool? AspNetCompileMerge
        {
            get;
            set;
        }

        public string Web_Publishing_AspNetCompileMerge_targets
        {
            get;
            set;
        }

        public string Microsoft_Web_Publishing_MSDeploy_Common_targets
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets
        {
            get;
            set;
        }

        public bool? Microsoft_Web_Publishing_MSDeploy_Common_targets_Imported
        {
            get;
            set;
        }

        public bool? InsertEFCodeFirstDeployWebCofig
        {
            get;
            set;
        }

        public string InsertEFCodeFirstDeployWebCofigIntermediateOutput
        {
            get;
            set;
        }

        public string InsertEFCodeFirstDeployWebCofigLocation
        {
            get;
            set;
        }

        public bool? PublishDatabases
        {
            get;
            set;
        }

        public string ProcessPublishDatabaseSettingsDependsOn
        {
            get;
            set;
        }

        public string ParseSQLScriptForMSDeployParametersDependsOn
        {
            get;
            set;
        }

        public string HandleEFCodeFirstDataMigrationDependsOn
        {
            get;
            set;
        }

        public string PreInsertEFCodeFirstDeployWebCofigDependsOn
        {
            get;
            set;
        }

        public string PreInsertEFCodeFirstDeployWebCofigBeforeTarget
        {
            get;
            set;
        }

        public string InsertEFCodeFirstDeployWebCofigCoreDependsOn
        {
            get;
            set;
        }

        public string PostInsertEFCodeFirstDeployWebCofigDependsOn
        {
            get;
            set;
        }

        public string InsertEFCodeFirstDeployWebCofigDependsOn
        {
            get;
            set;
        }

        public string InsertEFCodeFirstDeployWebCofigBeforeTargets
        {
            get;
            set;
        }

        public string CollectDatabasesToPublishDependsOn
        {
            get;
            set;
        }

        public string BeforeAddDeclareParametersItemsForDatabaseScript
        {
            get;
            set;
        }

        public string AfterAddDeclareParametersItemsForDatabaseScript
        {
            get;
            set;
        }

        public string AddDeclareParametersItemsForDatabaseScriptDependsOn
        {
            get;
            set;
        }

        public string WriteItemsToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string BeforeAddDatabasesToSourceManifest
        {
            get;
            set;
        }

        public string AfterAddDatabasesToSourceManifest
        {
            get;
            set;
        }

        public string AddDatabasesToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string AddDatabasesToSourceManifestAfterTargets
        {
            get;
            set;
        }

        public string GenerateSampleDeployScriptDependsOn
        {
            get;
            set;
        }

        public string GenerateSampleDeployScriptAfterTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets
        {
            get;
            set;
        }

        public string ExcludeApp_DataDependsOn
        {
            get;
            set;
        }

        public string ExcludeGeneratedDebugSymbolDependsOn
        {
            get;
            set;
        }

        public string ExcludeXmlAssemblyFilesDependsOn
        {
            get;
            set;
        }

        public bool? _EnableCleanOnBuildForMvcViews
        {
            get;
            set;
        }

        public bool? EnableExcludeFilesByExtension
        {
            get;
            set;
        }

        public string ExcludeFilesByExtensionDependsOn
        {
            get;
            set;
        }

        public string WebPublishExtensionsToExclude
        {
            get;
            set;
        }

        public string ExcludeFilesFromPackageDependsOn
        {
            get;
            set;
        }

        public string ValidateGlobalSettingsDependsOn
        {
            get;
            set;
        }

        public string ValidateGlobalPackageSettingDependsOn
        {
            get;
            set;
        }

        public string _CleanWPPIfNeedToDependsOn
        {
            get;
            set;
        }

        public string OnBeforePipelineCollectFilesPhase
        {
            get;
            set;
        }

        public string OnAfterPipelineCollectFilesPhase
        {
            get;
            set;
        }

        public string PipelineCollectFilesPhaseDependsOn
        {
            get;
            set;
        }

        public string TransformWebConfigBeforeTargets
        {
            get;
            set;
        }

        public string TransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string CollectWebConfigsToTransformDependsOn
        {
            get;
            set;
        }

        public string PreTransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string TransformWebConfigCoreDependsOn
        {
            get;
            set;
        }

        public string ParameterizeTransformWebConfigCoreDependsOn
        {
            get;
            set;
        }

        public string PostTransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string MarkWebConfigAssistFilesAsExcludeDependsOn
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigBeforeTargets
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigAfterTargets
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string CollectFilesForProfileTransformWebConfigsDependsOn
        {
            get;
            set;
        }

        public string PreProfileTransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string ProfileTransformWebConfigCoreDependsOn
        {
            get;
            set;
        }

        public string ParameterizeProfileTransformWebConfigCoreDependsOn
        {
            get;
            set;
        }

        public string PostProfileTransformWebConfigDependsOn
        {
            get;
            set;
        }

        public string PreInsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string InsertAdditionalWebCofigConnectionStringsCoreDependsOn
        {
            get;
            set;
        }

        public string PostInsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string InsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string InsertAdditionalWebCofigConnectionStringsBeforeTargets
        {
            get;
            set;
        }

        public string PreAutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string AutoParameterizationWebConfigConnectionStringsCoreDependsOn
        {
            get;
            set;
        }

        public string PostAutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string AutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get;
            set;
        }

        public string PipelineTransformPhaseDependsOn
        {
            get;
            set;
        }

        public string PipelineMsdeploySpecificTransformPhaseBeforeTargets
        {
            get;
            set;
        }

        public string PipelineMsdeploySpecificTransformPhaseDependsOn
        {
            get;
            set;
        }

        public string _WPPCopyWebApplicationDependsOn
        {
            get;
            set;
        }

        public string PipelinePreDeployCopyAllFilesToOneFolderDependsOn
        {
            get;
            set;
        }

        public string CopyAllFilesToSingleFolderForMsdeployDependsOn
        {
            get;
            set;
        }

        public string PipelineCopyAllFilesToOneFolderForMsdeployDependsOn
        {
            get;
            set;
        }

        public string GetProjectWebPropertiesDependsOn
        {
            get;
            set;
        }

        public string GetMSDeployInstalledVersionPathDependsOn
        {
            get;
            set;
        }

        public string PackageDependsOn
        {
            get;
            set;
        }

        public string CopyAllFilesToSingleFolderForPackageDependsOn
        {
            get;
            set;
        }

        public string BeforeAddIis7ToSourceManifest
        {
            get;
            set;
        }

        public string AfterAddIis7ToSourceManifest
        {
            get;
            set;
        }

        public string AddIis7ToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string BeforeAddDeclareParametersItemsForIis7
        {
            get;
            set;
        }

        public string AfterAddDeclareParametersItemsForIis7
        {
            get;
            set;
        }

        public string AddDeclareParametersItemsForIis7DependsOn
        {
            get;
            set;
        }

        public string BeforeAddIis6ToSourceManifest
        {
            get;
            set;
        }

        public string AfterAddIis6ToSourceManifest
        {
            get;
            set;
        }

        public string AddIis6ToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string BeforeAddDeclareParametersItemsForIis6
        {
            get;
            set;
        }

        public string AfterAddDeclareParametersItemsForIis6
        {
            get;
            set;
        }

        public string AddDeclareParametersItemsForIis6DependsOn
        {
            get;
            set;
        }

        public string BeforeAddIisSettingAndFileContentsToSourceManifest
        {
            get;
            set;
        }

        public string AfterAddIisSettingAndFileContentsToSourceManifest
        {
            get;
            set;
        }

        public string AddIisSettingAndFileContentsToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string BeforeAddContentPathToSourceManifest
        {
            get;
            set;
        }

        public string AfterAddContentPathToSourceManifest
        {
            get;
            set;
        }

        public string AddContentPathToSourceManifestDependsOn
        {
            get;
            set;
        }

        public string BeforeAddIisAndContentDeclareParametersItems
        {
            get;
            set;
        }

        public string AfterAddIisAndContentDeclareParametersItems
        {
            get;
            set;
        }

        public string AddIisAndContentDeclareParametersItemsDependsOn
        {
            get;
            set;
        }

        public string BeforeAddDeclareParametersItemsForContentPath
        {
            get;
            set;
        }

        public string AfterAddDeclareParametersItemsForContentPath
        {
            get;
            set;
        }

        public string AddDeclareParametersItemsForContentPathDependsOn
        {
            get;
            set;
        }

        public string BeforeWriteItemsToSourceManifest
        {
            get;
            set;
        }

        public string AfterWriteItemsToSourceManifest
        {
            get;
            set;
        }

        public string BeforeAddDeclareParametersItems
        {
            get;
            set;
        }

        public string AfterAddDeclareParametersItems
        {
            get;
            set;
        }

        public string AddDeclareParametersItemsDependsOn
        {
            get;
            set;
        }

        public string _GatherParamsDependsOn
        {
            get;
            set;
        }

        public string GenerateMsDeployManifestSettingsDependsOn
        {
            get;
            set;
        }

        public string CleanWebsitesPackageCoreDependsOn
        {
            get;
            set;
        }

        public string CleanWebsitesPackageDependsOn
        {
            get;
            set;
        }

        public string CleanWebsitesWPPAllFilesInSingleFolderDependsOn
        {
            get;
            set;
        }

        public string CleanWebPublishPipelineIntermediateOutputDependsOn
        {
            get;
            set;
        }

        public string CheckAndCleanMSDeployPackageIfNeededDependsOn
        {
            get;
            set;
        }

        public string OnAfterGenerateMsdeployManifestFiles
        {
            get;
            set;
        }

        public string GenerateMsdeployManifestFilesDependsOn
        {
            get;
            set;
        }

        public string PackageUsingManifestDependsOn
        {
            get;
            set;
        }

        public string TestDeployPackageToLocalDependsOn
        {
            get;
            set;
        }

        public bool? NormalizePublishSettings
        {
            get;
            set;
        }

        public string AuthType
        {
            get;
            set;
        }

        public string MSDeployPublishMethod
        {
            get;
            set;
        }

        public string GenerateGlobalPublishSettingDependsOn
        {
            get;
            set;
        }

        public bool? CreatePackageOnPublish
        {
            get;
            set;
        }

        public string MSDeployPublishDependsOn
        {
            get;
            set;
        }

        public string ValidatePublishProfileSettingsDependsOn
        {
            get;
            set;
        }

        public string WebMSDeployPublishDependsOn
        {
            get;
            set;
        }

        public string WebPackagePublishDependsOn
        {
            get;
            set;
        }

        public string WebPublishDependsOn
        {
            get;
            set;
        }

        public string PipelineDeployPhaseDependsOn
        {
            get;
            set;
        }

        public string PipelineDeployPhaseAfterTargets
        {
            get;
            set;
        }

        public string DbDacFxPreviewDependsOn
        {
            get;
            set;
        }

        public string DbFullSqlPreviewDependsOn
        {
            get;
            set;
        }

        public string ValidateDbDacFxPreviewSettingsDependsOn
        {
            get;
            set;
        }

        public string LocalDbDacFxPreviewDependsOn
        {
            get;
            set;
        }

        public string RemoteDbDacFxPreviewDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingTargets
        {
            get;
            set;
        }

        public string _TransformWebConfigForAzureAuthenticationDependsOn
        {
            get;
            set;
        }

        public string MSBuildFrameworkToolsPath
        {
            get;
            set;
        }

        public string MSBuildFrameworkToolsPath32
        {
            get;
            set;
        }

        public string MSBuildFrameworkToolsRoot
        {
            get;
            set;
        }

        public string VCTargetsPath
        {
            get;
            set;
        }

        public string VCTargetsPath10
        {
            get;
            set;
        }

        public string VCTargetsPath11
        {
            get;
            set;
        }

        public string VCTargetsPath12
        {
            get;
            set;
        }

        public string WindowsSDK80Path
        {
            get;
            set;
        }

        public string CustomBeforeMicrosoftCommonProps
        {
            get;
            set;
        }

        public string CustomAfterMicrosoftCommonProps
        {
            get;
            set;
        }

        public bool? MicrosoftCommonPropsHasBeenImported
        {
            get;
            set;
        }

        public string WMSJSProject
        {
            get;
            set;
        }

        public string WMSJSProjectDirectory
        {
            get;
            set;
        }

        public string TargetFrameworkProfile
        {
            get;
            set;
        }

        public bool? UseVSHostingProcess
        {
            get;
            set;
        }

        public bool? SignAssembly
        {
            get;
            set;
        }

        public string AssemblyOriginatorKeyFile
        {
            get;
            set;
        }

        public string CSharpTargetsPath
        {
            get;
            set;
        }

        public string CscToolPath
        {
            get;
            set;
        }

        public bool? ImportByWildcardBefore40MicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfter40MicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftCommonTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardBefore40MicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfter40MicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardBefore40MicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfter40MicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps
        {
            get;
            set;
        }

        public string NetFrameworkTargetsPath
        {
            get;
            set;
        }

        public bool? ImportByWildcardBefore40MicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfter40MicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets
        {
            get;
            set;
        }

        public string XamlBuildTaskPath
        {
            get;
            set;
        }

        public bool? AllowUnsafeBlocks
        {
            get;
            set;
        }

        public string MinimumVisualStudioVersion
        {
            get;
            set;
        }

        public string DefaultLanguage
        {
            get;
            set;
        }

        public string TargetFrameworkMonikerDisplayName
        {
            get;
            set;
        }

        public bool? ImplicitlyExpandTargetFramework
        {
            get;
            set;
        }

        public string ImplicitlyExpandTargetFrameworkDependsOn
        {
            get;
            set;
        }

        public string ReferencePath
        {
            get;
            set;
        }

        public bool? IsCodedUITest
        {
            get;
            set;
        }

        public string TestProjectType
        {
            get;
            set;
        }

        public string RootPath
        {
            get;
            set;
        }

        public bool? _InvalidConfigurationError
        {
            get;
            set;
        }

        public bool? SilverlightBuild
        {
            get;
            set;
        }

        public string BuildName
        {
            get;
            set;
        }

        public int? Project_Major
        {
            get;
            set;
        }

        public int? Project_Minor
        {
            get;
            set;
        }

        public int? Project_Build
        {
            get;
            set;
        }

        public int? AssemblyVersion_Build
        {
            get;
            set;
        }

        public string BuildScriptsPath
        {
            get;
            set;
        }

        public string BuildConfigDescription
        {
            get;
            set;
        }

        public string BuildPath
        {
            get;
            set;
        }

        public string ToolsPath
        {
            get;
            set;
        }

        public string TestResultsPath
        {
            get;
            set;
        }

        public string AssemblyInfoFile
        {
            get;
            set;
        }

        public string AssemblyTitle
        {
            get;
            set;
        }

        public string AssemblyProduct
        {
            get;
            set;
        }

        public bool? ComVisible
        {
            get;
            set;
        }

        public bool? CLSCompliant
        {
            get;
            set;
        }

        public bool? AllowPartiallyTrustedCallers
        {
            get;
            set;
        }

        public string AssemblyVersion_Major
        {
            get;
            set;
        }

        public string AssemblyVersion_Minor
        {
            get;
            set;
        }

        public int? Build_Number
        {
            get;
            set;
        }

        public string Build_Revision
        {
            get;
            set;
        }

        public string TestDetectionExpression
        {
            get;
            set;
        }

        public bool? TestRunner_Enabled
        {
            get;
            set;
        }

        public int? TestRunner_Timeout
        {
            get;
            set;
        }

        public bool? TestRunner_ContinueOnError
        {
            get;
            set;
        }

        public string NUnitExecutable
        {
            get;
            set;
        }

        public string NUnitPath
        {
            get;
            set;
        }

        public string MSBuildCommunityTasksPath
        {
            get;
            set;
        }

        public string MSBuildCommunityTasksLib
        {
            get;
            set;
        }

        public string FileUpgradeFlags
        {
            get;
            set;
        }

        public string UpgradeBackupLocation
        {
            get;
            set;
        }

        public bool? SilverlightApplication
        {
            get;
            set;
        }

        public string SupportedCultures
        {
            get;
            set;
        }

        public bool? XapOutputs
        {
            get;
            set;
        }

        public bool? GenerateSilverlightManifest
        {
            get;
            set;
        }

        public string XapFilename
        {
            get;
            set;
        }

        public string SilverlightManifestTemplate
        {
            get;
            set;
        }

        public string SilverlightAppEntry
        {
            get;
            set;
        }

        public bool? CreateTestPage
        {
            get;
            set;
        }

        public bool? ValidateXaml
        {
            get;
            set;
        }

        public bool? EnableOutOfBrowser
        {
            get;
            set;
        }

        public string OutOfBrowserSettingsFile
        {
            get;
            set;
        }

        public bool? UsePlatformExtensions
        {
            get;
            set;
        }

        public bool? ThrowErrorsInValidation
        {
            get;
            set;
        }

        public string LinkedServerProject
        {
            get;
            set;
        }

        public string OldToolsVersion
        {
            get;
            set;
        }

        public string ProjectType
        {
            get;
            set;
        }

        public string ApplicationIcon
        {
            get;
            set;
        }

        public string AssemblyKeyContainerName
        {
            get;
            set;
        }

        public string DefaultClientScript
        {
            get;
            set;
        }

        public string DefaultHTMLPageLayout
        {
            get;
            set;
        }

        public string DefaultTargetSchema
        {
            get;
            set;
        }

        public string RunPostBuildEvent
        {
            get;
            set;
        }

        public string StartupObject
        {
            get;
            set;
        }

        public string PreBuildEvent
        {
            get;
            set;
        }

        public string PostBuildEvent
        {
            get;
            set;
        }

        public string BuildToolsVersion
        {
            get;
            set;
        }

        public string SourceDir
        {
            get;
            set;
        }

        public string BinDir
        {
            get;
            set;
        }

        public string ObjDir
        {
            get;
            set;
        }

        public string TestWorkingDir
        {
            get;
            set;
        }

        public string PackagesOutDir
        {
            get;
            set;
        }

        public string PackagesDir
        {
            get;
            set;
        }

        public string ToolsDir
        {
            get;
            set;
        }

        public string NuGetToolPath
        {
            get;
            set;
        }

        public string NuGetConfigFile
        {
            get;
            set;
        }

        public string NuGetConfigCommandLine
        {
            get;
            set;
        }

        public string NugetRestoreCommand
        {
            get;
            set;
        }

        public string ConfigurationGroup
        {
            get;
            set;
        }

        public string OSGroup
        {
            get;
            set;
        }

        public bool? NoStdLib
        {
            get;
            set;
        }

        public bool? NoExplicitReferenceToStdLib
        {
            get;
            set;
        }

        public string CommonPath
        {
            get;
            set;
        }

        public string CommonTestPath
        {
            get;
            set;
        }

        public string OSPlatformConfig
        {
            get;
            set;
        }

        public string BaseOutputPath
        {
            get;
            set;
        }

        public string TestPath
        {
            get;
            set;
        }

        public string PackagesBasePath
        {
            get;
            set;
        }

        public bool? TargetsWindows
        {
            get;
            set;
        }

        public string _WindowsKitBinPath
        {
            get;
            set;
        }

        public string _WindowsPhoneKitBinPath
        {
            get;
            set;
        }

        public string MakePriExeFullPath
        {
            get;
            set;
        }

        public string MakeAppxExeFullPath
        {
            get;
            set;
        }

        public string SignAppxPackageExeFullPath
        {
            get;
            set;
        }

        public string MakePriExtensionPath
        {
            get;
            set;
        }

        public string MakePriExtensionPath_x64
        {
            get;
            set;
        }

        public bool? ErrorIfBuildToolsRestoredFromIndividualProject
        {
            get;
            set;
        }

        public string AssemblyVersion
        {
            get;
            set;
        }

        public string TestCategories
        {
            get;
            set;
        }

        public string DocumentationFile
        {
            get;
            set;
        }

        public bool? GenerateAppxPackageOnBuild
        {
            get;
            set;
        }

        public string NuGetPackageImportStamp
        {
            get;
            set;
        }

        public string DebugEngines
        {
            get;
            set;
        }

        public bool? GenerateAssemblyInfo
        {
            get;
            set;
        }

        public string NoWarn
        {
            get;
            set;
        }

        public string RuntimeSerializationSources
        {
            get;
            set;
        }

        public string JsonSources
        {
            get;
            set;
        }

        public string XmlSources
        {
            get;
            set;
        }

        public string TextSources
        {
            get;
            set;
        }

        public bool? CheckForOverflowUnderflow
        {
            get;
            set;
        }

        public bool? ExternallyShipping
        {
            get;
            set;
        }

        public bool? RunTestsForProject
        {
            get;
            set;
        }

        public string CommonPathXPath
        {
            get;
            set;
        }

        public string TypeScriptTarget
        {
            get;
            set;
        }

        public bool? TypeScriptCompileOnSaveEnabled
        {
            get;
            set;
        }

        public bool? TypeScriptNoImplicitAny
        {
            get;
            set;
        }

        public string TypeScriptModuleKind
        {
            get;
            set;
        }

        public bool? TypeScriptRemoveComments
        {
            get;
            set;
        }

        public string TypeScriptOutFile
        {
            get;
            set;
        }

        public string TypeScriptOutDir
        {
            get;
            set;
        }

        public bool? TypeScriptGeneratesDeclarations
        {
            get;
            set;
        }

        public bool? TypeScriptSourceMap
        {
            get;
            set;
        }

        public string TypeScriptMapRoot
        {
            get;
            set;
        }

        public string TypeScriptSourceRoot
        {
            get;
            set;
        }

        public bool? TypeScriptNoEmitOnError
        {
            get;
            set;
        }

        public string TypeScriptToolsVersion
        {
            get;
            set;
        }

        public string VsToolsPath
        {
            get;
            set;
        }

        public string CfgPropertyPagesGuidsAddCSharp
        {
            get;
            set;
        }

        public string CfgPropertyPagesGuidsAddVB
        {
            get;
            set;
        }

        public string CfgPropertyPagesGuidsAddTypeScript
        {
            get;
            set;
        }

        public bool? TypeScriptEnabled
        {
            get;
            set;
        }

        public string TypeScriptBuildConfigurations
        {
            get;
            set;
        }

        public string TscToolPath
        {
            get;
            set;
        }

        public string TscToolExe
        {
            get;
            set;
        }

        public bool? TscYieldDuringToolExecution
        {
            get;
            set;
        }

        public bool? ConsolePause
        {
            get;
            set;
        }

        public string PublishUrl
        {
            get;
            set;
        }

        public bool? Install
        {
            get;
            set;
        }

        public string InstallFrom
        {
            get;
            set;
        }

        public bool? UpdateEnabled
        {
            get;
            set;
        }

        public string UpdateMode
        {
            get;
            set;
        }

        public int? UpdateInterval
        {
            get;
            set;
        }

        public string UpdateIntervalUnits
        {
            get;
            set;
        }

        public bool? UpdatePeriodically
        {
            get;
            set;
        }

        public bool? UpdateRequired
        {
            get;
            set;
        }

        public bool? MapFileExtensions
        {
            get;
            set;
        }

        public int? ApplicationRevision
        {
            get;
            set;
        }

        public string ApplicationVersion
        {
            get;
            set;
        }

        public bool? IsWebBootstrapper
        {
            get;
            set;
        }

        public bool? UseApplicationTrust
        {
            get;
            set;
        }

        public bool? BootstrapperEnabled
        {
            get;
            set;
        }

        public string _FullFrameworkReferenceAssemblyPaths
        {
            get;
            set;
        }

        public string _TargetFrameworkDirectories
        {
            get;
            set;
        }

        public bool? TreatWarningsAsErrors
        {
            get;
            set;
        }

        public bool? RegisterForComInterop
        {
            get;
            set;
        }

        public string GenerateSerializationAssemblies
        {
            get;
            set;
        }

        public int? BaseAddress
        {
            get;
            set;
        }

        public string PublishUrlHistory
        {
            get;
            set;
        }

        public string InstallUrlHistory
        {
            get;
            set;
        }

        public string SupportUrlHistory
        {
            get;
            set;
        }

        public string UpdateUrlHistory
        {
            get;
            set;
        }

        public string BootstrapperUrlHistory
        {
            get;
            set;
        }

        public string ErrorReportUrlHistory
        {
            get;
            set;
        }

        public string FallbackCulture
        {
            get;
            set;
        }

        public bool? VerifyUploadedFiles
        {
            get;
            set;
        }

        public string SccProjectName
        {
            get;
            set;
        }

        public string SccLocalPath
        {
            get;
            set;
        }

        public string SccAuxPath
        {
            get;
            set;
        }

        public string SccProvider
        {
            get;
            set;
        }

        public string SilverlightVersion
        {
            get;
            set;
        }

        public bool? NoConfig
        {
            get;
            set;
        }

        public string VCInstallDir_110
        {
            get;
            set;
        }

        public string WP80ToolSetPath
        {
            get;
            set;
        }

        public string WindowsPhoneSdkRegkeyRoot
        {
            get;
            set;
        }

        public string WindowsPhoneRegistryBase
        {
            get;
            set;
        }

        public string WindowsPhoneRegistryBaseVersion
        {
            get;
            set;
        }

        public string RuntimePathRegistryKey
        {
            get;
            set;
        }

        public string ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch
        {
            get;
            set;
        }

        public string WindowsPhoneSdkVersion
        {
            get;
            set;
        }

        public string WindowsPhoneSdkInstallPath
        {
            get;
            set;
        }

        public string WindowsPhone71RegistryBase
        {
            get;
            set;
        }

        public string WindowsPhone71RegistryBaseVersion
        {
            get;
            set;
        }

        public string WindowsPhone7RegistryBase
        {
            get;
            set;
        }

        public string WindowsPhone7RegistryBaseVersion
        {
            get;
            set;
        }

        public string WindowsPhoneFxReferencesDisplayName
        {
            get;
            set;
        }

        public string PathOfWMAppManifestRelativeToProject
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeWindowsPhoneCommonTargets
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterWindowsPhoneCommonTargets
        {
            get;
            set;
        }

        public bool? IncludeBuiltProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeDebugSymbolsProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeDocumentationProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeSatelliteDllsProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeSourceFilesProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeContentFilesProjectOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeSGenFilesOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeCopyLocalFilesOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeComFilesOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeCustomOutputGroupForPackaging
        {
            get;
            set;
        }

        public bool? IncludeCopyWinmdArtifactsOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeSDKRedistOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeGetResolvedSDKReferences
        {
            get;
            set;
        }

        public bool? ValidateXapFilenames
        {
            get;
            set;
        }

        public string AllOutputGroupsDependsOn
        {
            get;
            set;
        }

        public string CopyLocalFilesOutputGroupDependsOn
        {
            get;
            set;
        }

        public string GetPackagingOutputsDependsOn
        {
            get;
            set;
        }

        public string FilterPackagingOutPutsDependsOn
        {
            get;
            set;
        }

        public string _GetPackagePropertiesDependsOn
        {
            get;
            set;
        }

        public string SignToolPath
        {
            get;
            set;
        }

        public string ValidateXapFilenamesDependsOn
        {
            get;
            set;
        }

        public string ComputeWinMDsDependsOn
        {
            get;
            set;
        }

        public string WMAppManifestWinMDRegistrationDependsOn
        {
            get;
            set;
        }

        public bool? ExtMapFileValidationAsError
        {
            get;
            set;
        }

        public bool? OutOfBrowserPlusAppCachingIsSupported
        {
            get;
            set;
        }

        public string FrameworkRegistryBaseWithVersion
        {
            get;
            set;
        }

        public string RuntimeVersionRegistryKey
        {
            get;
            set;
        }

        public bool? ReferencesValidationRequiredForWindowsPhone
        {
            get;
            set;
        }

        public string CompileXamlDependsOn
        {
            get;
            set;
        }

        public string ValidateXamlDependsOn
        {
            get;
            set;
        }

        public string XapPackagerDependsOn
        {
            get;
            set;
        }

        public string FilesToXapDependsOn
        {
            get;
            set;
        }

        public string CreateSilverlightAppManifestDependsOn
        {
            get;
            set;
        }

        public string CategorizeSilverlightReferencesDependsOn
        {
            get;
            set;
        }

        public string PackagePlatformExtensionsDependsOn
        {
            get;
            set;
        }

        public bool? ImplicitlyExpandTargetPlatform
        {
            get;
            set;
        }

        public string WindowsPhoneSDK_MetadataPath
        {
            get;
            set;
        }

        public string CopyWinmdArtifactsOutputGroupDependsOn
        {
            get;
            set;
        }

        public string PackagesProjectConfig
        {
            get;
            set;
        }

        public string NonInteractiveSwitch
        {
            get;
            set;
        }

        public string PaddedSolutionDir
        {
            get;
            set;
        }

        public string ConfigurationOverrideFile
        {
            get;
            set;
        }

        public bool? RemoveIntegerChecks
        {
            get;
            set;
        }

        public string _DisabledWarnings
        {
            get;
            set;
        }

        public string LoadTimeSensitiveItems
        {
            get;
            set;
        }

        public string LoadTimeCheckItemLocation
        {
            get;
            set;
        }

        public string GetRedistListsDependsOn
        {
            get;
            set;
        }

        public bool? UnloadProjectsOnCompletion
        {
            get;
            set;
        }

        public string WinFXNativePath
        {
            get;
            set;
        }

        public string WinFXWowPath
        {
            get;
            set;
        }

        public bool? TargetingClr2Framework
        {
            get;
            set;
        }

        public string MSBuildManagedCompilerPath
        {
            get;
            set;
        }

        public string RiaClientCodeGenDependsOn
        {
            get;
            set;
        }

        public string CoreRiaClientCodeGenDependsOn
        {
            get;
            set;
        }

        public string RiaClientCleanDependsOn
        {
            get;
            set;
        }

        public string _RiaClientCodeGenOutputPath
        {
            get;
            set;
        }

        public string _RiaClientCodeGenHistoryFile
        {
            get;
            set;
        }

        public string DefaultClientReferences
        {
            get;
            set;
        }

        public string PrepareForRiaClientCodeGenDependsOn
        {
            get;
            set;
        }

        public bool? WindowsAppContainer
        {
            get;
            set;
        }

        public bool? SuppressWarningsInPass1
        {
            get;
            set;
        }

        public string TargetPlatformSdkMetadataLocation
        {
            get;
            set;
        }

        public string TargetPlatformWinMDLocation
        {
            get;
            set;
        }

        public string AppxMSBuildToolsPath
        {
            get;
            set;
        }

        public string AppxMSBuildTaskAssembly
        {
            get;
            set;
        }

        public bool? AppxPackage
        {
            get;
            set;
        }

        public bool? AppxUseHardlinksIfPossible
        {
            get;
            set;
        }

        public bool? AppxSkipUnchangedFiles
        {
            get;
            set;
        }

        public bool? AppxGeneratePriEnabled
        {
            get;
            set;
        }

        public bool? AppxGetPackagePropertiesEnabled
        {
            get;
            set;
        }

        public bool? AppxPackageIncludePrivateSymbols
        {
            get;
            set;
        }

        public bool? AppxSymbolPackageEnabled
        {
            get;
            set;
        }

        public bool? AppxTestLayoutEnabled
        {
            get;
            set;
        }

        public bool? AppxPackageValidationEnabled
        {
            get;
            set;
        }

        public bool? AppxHarvestWinmdRegistration
        {
            get;
            set;
        }

        public bool? AutoIncrementPackageRevision
        {
            get;
            set;
        }

        public bool? AppxPrependPriInitialPath
        {
            get;
            set;
        }

        public bool? EnableSigningChecks
        {
            get;
            set;
        }

        public bool? AppxStrictManifestValidationEnabled
        {
            get;
            set;
        }

        public bool? AppxFilterOutUnusedLanguagesResourceFileMaps
        {
            get;
            set;
        }

        public bool? AppxGeneratePrisForPortableLibrariesEnabled
        {
            get;
            set;
        }

        public bool? AppxGeneratePackageRecipeEnabled
        {
            get;
            set;
        }

        public bool? _TargetPlatformIsWindowsPhone
        {
            get;
            set;
        }

        public bool? AppxPackageSigningEnabled
        {
            get;
            set;
        }

        public string AppxOSMinVersion
        {
            get;
            set;
        }

        public string AppxOSMaxVersionTested
        {
            get;
            set;
        }

        public string AppxPackageDirName
        {
            get;
            set;
        }

        public string AppxPackageDirInProjectDir
        {
            get;
            set;
        }

        public string PlatformSpecificBundleArtifactsListDirName
        {
            get;
            set;
        }

        public string PlatformSpecificBundleArtifactsListDirInProjectDir
        {
            get;
            set;
        }

        public string AppxPackageDir
        {
            get;
            set;
        }

        public string AppxPackageArtifactsDir
        {
            get;
            set;
        }

        public string FinalAppxManifestName
        {
            get;
            set;
        }

        public bool? AppxValidateAppxManifest
        {
            get;
            set;
        }

        public string StoreManifestName
        {
            get;
            set;
        }

        public string ResgenToolPath
        {
            get;
            set;
        }

        public string PdbCopyExeFullPath
        {
            get;
            set;
        }

        public string AppxSymbolStrippedDir
        {
            get;
            set;
        }

        public string AppxPriInitialPath
        {
            get;
            set;
        }

        public string ProjectPriFileName
        {
            get;
            set;
        }

        public string ProjectPriFullPath
        {
            get;
            set;
        }

        public string AppxPackageRecipe
        {
            get;
            set;
        }

        public string FinalAppxPackageRecipe
        {
            get;
            set;
        }

        public bool? AllowLocalNetworkLoopback
        {
            get;
            set;
        }

        public string AppxDefaultHashAlgorithmId
        {
            get;
            set;
        }

        public string AppxPackageFileMap
        {
            get;
            set;
        }

        public string LayoutDir
        {
            get;
            set;
        }

        public string ManagedWinmdInprocImplementation
        {
            get;
            set;
        }

        public bool? UseIncrementalAppxRegistration
        {
            get;
            set;
        }

        public string AppxPackagingInfoFile
        {
            get;
            set;
        }

        public bool? AppxOSMinVersionReplaceManifestVersion
        {
            get;
            set;
        }

        public bool? AppxOSMaxVersionTestedReplaceManifestVersion
        {
            get;
            set;
        }

        public string PackagingFileWritesLogPath
        {
            get;
            set;
        }

        public string PackagingDirectoryWritesLogPath
        {
            get;
            set;
        }

        public bool? AppxCopyLocalFilesOutputGroupIncludeXmlFiles
        {
            get;
            set;
        }

        public string AppxPriConfigXmlPackagingSnippetPath
        {
            get;
            set;
        }

        public string AppxPriConfigXmlDefaultSnippetPath
        {
            get;
            set;
        }

        public string TargetPlatformSdkRootOverride
        {
            get;
            set;
        }

        public string TargetPlatformResourceVersion
        {
            get;
            set;
        }

        public string AppxPackageExtension
        {
            get;
            set;
        }

        public string AppxSymbolPackageExtension
        {
            get;
            set;
        }

        public string AppxBundleExtension
        {
            get;
            set;
        }

        public string AppxStoreContainerExtension
        {
            get;
            set;
        }

        public string AppxIntermediateExtension
        {
            get;
            set;
        }

        public string AppxBundle
        {
            get;
            set;
        }

        public string AppxBundlePlatforms
        {
            get;
            set;
        }

        public string AppxBundleProducingPlatform
        {
            get;
            set;
        }

        public string AppxBundleResourcePacksProducingPlatform
        {
            get;
            set;
        }

        public string AppxLayoutFolderName
        {
            get;
            set;
        }

        public string AppxLayoutDir
        {
            get;
            set;
        }

        public string AppxBundlePriConfigXmlForSplittingFileName
        {
            get;
            set;
        }

        public string AppxBundleAutoResourcePackageQualifiers
        {
            get;
            set;
        }

        public string AppxBundleSplitResourcesPriPrefix
        {
            get;
            set;
        }

        public string AppxBundleSplitResourcesPriPath
        {
            get;
            set;
        }

        public string AppxBundleSplitResourcesGeneratedFilesListPath
        {
            get;
            set;
        }

        public string AppxBundleSplitResourcesQualifiersPath
        {
            get;
            set;
        }

        public string AppxBundlePriConfigXmlForMainPackageFileMapFileName
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapIntermediatePrefix
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapSuffix
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapIntermediatePath
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapIntermediatePriPath
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapGeneratedFilesListPath
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapPrefix
        {
            get;
            set;
        }

        public string AppxBundleMainPackageFileMapPath
        {
            get;
            set;
        }

        public string AppxBundleFolderSuffix
        {
            get;
            set;
        }

        public string PlatformSpecificBundleArtifactsListDir
        {
            get;
            set;
        }

        public string AppxDefaultResourceQualifiers_Windows_80
        {
            get;
            set;
        }

        public string AppxDefaultResourceQualifiers_Windows_81
        {
            get;
            set;
        }

        public string AppxDefaultResourceQualifiers_Windows_Phone
        {
            get;
            set;
        }

        public string AppxDefaultResourceQualifiers
        {
            get;
            set;
        }

        public bool? AppxPackageAllowDebugFrameworkReferencesInManifest
        {
            get;
            set;
        }

        public bool? InsertReverseMap
        {
            get;
            set;
        }

        public string _ProjectPriFullPathOriginal
        {
            get;
            set;
        }

        public bool? IncludePriFilesOutputGroup
        {
            get;
            set;
        }

        public bool? IncludeProjectPriFile
        {
            get;
            set;
        }

        public string ValidatePresenceOfAppxManifestItemsDependsOn
        {
            get;
            set;
        }

        public string _GenerateProjectPriFileDependsOn
        {
            get;
            set;
        }

        public string _PriConfigXmlPath
        {
            get;
            set;
        }

        public string _LayoutResfilesPath
        {
            get;
            set;
        }

        public string _ResourcesResfilesPath
        {
            get;
            set;
        }

        public string _PriResfilesPath
        {
            get;
            set;
        }

        public string _QualifiersPath
        {
            get;
            set;
        }

        public string _MultipleQualifiersPerDimensionFoundPath
        {
            get;
            set;
        }

        public string _ProjectArchitecturesFilePath
        {
            get;
            set;
        }

        public string _GenerateAppxManifestDependsOn
        {
            get;
            set;
        }

        public string _GenerateAppxPackageRecipeDependsOn
        {
            get;
            set;
        }

        public string _GenerateAppxPackageBaseDependsOn
        {
            get;
            set;
        }

        public string _GenerateAppxPackageDependsOn
        {
            get;
            set;
        }

        public string _CreateAppxPackageDependsOn
        {
            get;
            set;
        }

        public string _CreateAppxBundlePlatformSpecificArtifactsDependsOn
        {
            get;
            set;
        }

        public string _CreateAppxBundleFilesDependsOn
        {
            get;
            set;
        }

        public string ComFilesOutputGroupDependsOn
        {
            get;
            set;
        }

        public string PrepareLayoutDependsOn
        {
            get;
            set;
        }

        public string RegisterAppxLayoutDependsOn
        {
            get;
            set;
        }

        public string UnRegisterAppxLayoutDependsOn
        {
            get;
            set;
        }

        public string VCInstallDir
        {
            get;
            set;
        }

        public bool? XAMLFingerprint
        {
            get;
            set;
        }

        public string XAMLFingerprintIgnorePaths
        {
            get;
            set;
        }

        public string PriIndexName
        {
            get;
            set;
        }

        public string OnXamlPreCompileErrorTarget
        {
            get;
            set;
        }

        public bool? XamlShareAppDomains
        {
            get;
            set;
        }

        public string XamlGeneratedOutputPath
        {
            get;
            set;
        }

        public string PrepareLibraryLayoutDependsOn
        {
            get;
            set;
        }

        public bool? FindInvalidProjectReferences
        {
            get;
            set;
        }

        public string IPhoneResourcePrefix
        {
            get;
            set;
        }

        public string TargetPlatformMonikerDisplayName
        {
            get;
            set;
        }

        public string PortableSDKRoot
        {
            get;
            set;
        }

        public string XamlTargetPlatformVersion
        {
            get;
            set;
        }

        public string WindowsUIXamlCommonTargets
        {
            get;
            set;
        }

        public string ImplicitlyExpandTargetPlatformDependsOn
        {
            get;
            set;
        }

        public string DeterminePortablePlatformSdkPathDependsOn
        {
            get;
            set;
        }

        public string DeterminePortableBuildCapabilitiesDependsOn
        {
            get;
            set;
        }

        public string TargetPlatformRootPath
        {
            get;
            set;
        }

        public string PackageCertificateKeyFile
        {
            get;
            set;
        }

        public bool? AppXPackage
        {
            get;
            set;
        }

        public string CleanPackageAction
        {
            get;
            set;
        }

        public string PackageAction
        {
            get;
            set;
        }

        public string RebuildPackageAction
        {
            get;
            set;
        }

        public string MtouchLink
        {
            get;
            set;
        }

        public string CodesignEntitlements
        {
            get;
            set;
        }

        public bool? MtouchDebug
        {
            get;
            set;
        }

        public string MtouchI18n
        {
            get;
            set;
        }

        public string MtouchArch
        {
            get;
            set;
        }

        public bool? CodeAnalysisIgnoreBuiltInRuleSets
        {
            get;
            set;
        }

        public bool? CodeAnalysisIgnoreBuiltInRules
        {
            get;
            set;
        }

        public bool? RunCodeAnalysis
        {
            get;
            set;
        }

        public bool? RunCodeAnalysisOnThisProject
        {
            get;
            set;
        }

        public string CodeAnalysisRules
        {
            get;
            set;
        }

        public bool? _DeploymentSignClickOnceManifests
        {
            get;
            set;
        }

        public string PackageCertificateThumbprint
        {
            get;
            set;
        }

        public bool? AppxAutoIncrementPackageRevision
        {
            get;
            set;
        }

        public string TestPageFileName
        {
            get;
            set;
        }

        public string ProjectView
        {
            get;
            set;
        }

        public bool? Externalconsole
        {
            get;
            set;
        }

        public string NuGetFrameworkVersion
        {
            get;
            set;
        }

        public string ExcludeFromPackage
        {
            get;
            set;
        }

        public string NameOfLastUsedPublishProfile
        {
            get;
            set;
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets
        {
            get;
            set;
        }

        public bool? _CollectFiles_IncludeIgnorableFile
        {
            get;
            set;
        }

        public bool? CollectFilesFromProjectFolder_ExcludeSccFiles
        {
            get;
            set;
        }

        public string SetExcludeFromProjectFolderDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromProjectFolder_ExcludeSccFilesDependsOn
        {
            get;
            set;
        }

        public string CollectFilesFromProjectFolderDependsOn
        {
            get;
            set;
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets
        {
            get;
            set;
        }

        public bool? NoWin32Manifest
        {
            get;
            set;
        }

        public string InBrowserSettingsFile
        {
            get;
            set;
        }

        public bool? RequireInBrowserElevation
        {
            get;
            set;
        }

        public string RoleType
        {
            get;
            set;
        }

        public bool? PortableEnableXamlTargets
        {
            get;
            set;
        }

        public bool? SynthesizeLinkMetadata
        {
            get;
            set;
        }

        public bool? HasSharedItems
        {
            get;
            set;
        }

        public string SharedGUID
        {
            get;
            set;
        }

        public string Import_RootNamespace
        {
            get;
            set;
        }

        public bool? DisableXbfGeneration
        {
            get;
            set;
        }

        public string XamlSavedStateFileName
        {
            get;
            set;
        }

        public string XamlSavedStateFilePath
        {
            get;
            set;
        }

        public string XamlRootsLog
        {
            get;
            set;
        }

        public string MarkupCompilePass1DependsOn
        {
            get;
            set;
        }

        public string MarkupCompilePass2DependsOn
        {
            get;
            set;
        }

        public string Prep_ComputeProcessXamlFilesDependsOn
        {
            get;
            set;
        }

        public bool? SDKReferenceWarnOnMissingMaxPlatformVersion
        {
            get;
            set;
        }

        public string StartArguments
        {
            get;
            set;
        }

        public bool? EnableSQLServerDebugging
        {
            get;
            set;
        }

        public bool? WPTestProject
        {
            get;
            set;
        }

        public string _DeploymentApplicationUrl
        {
            get;
            set;
        }

        public string StartAction
        {
            get;
            set;
        }
    }
}