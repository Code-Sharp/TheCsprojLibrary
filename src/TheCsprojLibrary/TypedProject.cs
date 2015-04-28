using System.Diagnostics;
using Microsoft.Build.Evaluation;
using TheCsprojLibrary.ItemTypes;

namespace TheCsprojLibrary
{
    [DebuggerTypeProxy(typeof(TypedProjectDisplayProxy))]
    public class TypedProject
    {
        private readonly Project mProject;
        private readonly ItemCollection<Reference> mReferences;
        private readonly ItemCollection<Compile> mCompiles;
        private readonly ItemCollection<None> mNones;
        private readonly ItemCollection<ProjectReference> mProjectReferences;
        private readonly ItemCollection<Content> mContents;
        private readonly ItemCollection<_OutputPathItem> m_OutputPathItems;
        private readonly ItemCollection<_UnmanagedRegistrationCache> m_UnmanagedRegistrationCaches;
        private readonly ItemCollection<_ResolveComReferenceCache> m_ResolveComReferenceCaches;
        private readonly ItemCollection<AppConfigFileDestination> mAppConfigFileDestinations;
        private readonly ItemCollection<IntermediateAssembly> mIntermediateAssemblies;
        private readonly ItemCollection<_DebugSymbolsIntermediatePath> m_DebugSymbolsIntermediatePaths;
        private readonly ItemCollection<_DebugSymbolsOutputPath> m_DebugSymbolsOutputPaths;
        private readonly ItemCollection<_DeploymentManifestEntryPoint> m_DeploymentManifestEntryPoints;
        private readonly ItemCollection<ApplicationManifest> mApplicationManifests;
        private readonly ItemCollection<_ApplicationManifestFinal> m_ApplicationManifestFinals;
        private readonly ItemCollection<DeployManifest> mDeployManifests;
        private readonly ItemCollection<BuiltProjectOutputGroupKeyOutput> mBuiltProjectOutputGroupKeyOutputs;
        private readonly ItemCollection<DebugSymbolsProjectOutputGroupOutput> mDebugSymbolsProjectOutputGroupOutputs;
        private readonly ItemCollection<AvailableItemName> mAvailableItemNames;
        private readonly ItemCollection<Clean> mCleans;
        private readonly ItemCollection<XamlBuildTaskTypeGenerationExtensionName> mXamlBuildTaskTypeGenerationExtensionNames;
        private readonly ItemCollection<_ExplicitReference> m_ExplicitReferences;
        private readonly ItemCollection<WCFMetadata> mWCFMetadatas;
        private readonly ItemCollection<ServiceReferenceMetadataStorage> mServiceReferenceMetadataStorages;
        private readonly ItemCollection<_WPPSupports> m_WPPSupportsCollection;
        private readonly ItemCollection<_IISApplicationPool> m_IISApplicationPools;
        private readonly ItemCollection<_MSDeployPackageFile> m_MSDeployPackageFiles;
        private readonly ItemCollection<_MSDeployArchiveDir> m_MSDeployArchiveDirs;
        private readonly ItemCollection<_MSDeployPackageLocation> m_MSDeployPackageLocations;
        private readonly ItemCollection<WebPublishExtnsionsToExcludeItem> mWebPublishExtnsionsToExcludeItems;
        private readonly ItemCollection<Folder> mFolders;
        private readonly ItemCollection<EmbeddedResource> mEmbeddedResources;
        private readonly ItemCollection<Service> mServices;
        private readonly ItemCollection<FxCopRuleAssemblies> mFxCopRuleAssemblies;
        private readonly ItemCollection<ApplicationDefinition> mApplicationDefinitions;
        private readonly ItemCollection<TypeScriptCompile> mTypeScriptCompiles;
        private readonly ItemCollection<ProjectCapability> mProjectCapabilities;
        private readonly ItemCollection<BootstrapperPackage> mBootstrapperPackages;
        private readonly ItemCollection<DocFileItem> mDocFileItems;
        private readonly ItemCollection<FinalDocFile> mFinalDocFiles;
        private readonly ItemCollection<DocumentationProjectOutputGroupOutput> mDocumentationProjectOutputGroupOutputs;
        private readonly ItemCollection<Page> mPages;
        private readonly ItemCollection<Resource> mResources;
        private readonly ItemCollection<_IntermediateOutputPathItem> m_IntermediateOutputPathItems;
        private readonly ItemCollection<PackageSource> mPackageSourcesCollection;
        private readonly ItemCollection<AppDesigner> mAppDesigners;
        private readonly ItemCollection<AppxHashUri> mAppxHashUris;
        private readonly ItemCollection<AppxSystemBinary> mAppxSystemBinaries;
        private readonly ItemCollection<AppxReservedFileName> mAppxReservedFileNames;
        private readonly ItemCollection<AppxManifestFileNameQuery> mAppxManifestFileNameQueries;
        private readonly ItemCollection<AppxManifestImageFileNameQuery> mAppxManifestImageFileNameQueries;
        private readonly ItemCollection<AppxManifestMetadata> mAppxManifestMetadatas;
        private readonly ItemCollection<AppxManifestMetaData> mAppxManifestMetaDatas;
        private readonly ItemCollection<PlatformVersionDescription> mPlatformVersionDescriptions;
        private readonly ItemCollection<XamlIntermediateAssembly> mXamlIntermediateAssemblies;
        private readonly ItemCollection<SDKReference> mSDKReferences;
        private readonly ItemCollection<AppxManifest> mAppxManifests;
        private readonly ItemCollection<UpToDateCheckOutput> mUpToDateCheckOutputs;
        private readonly ItemCollection<BundleResource> mBundleResources;
        private readonly ItemCollection<EntityDeploy> mEntityDeploys;
        private readonly ItemCollection<_DeploymentManifestIconFile> m_DeploymentManifestIconFiles;
        private readonly ItemCollection<TargetPlatform> mTargetPlatforms;
        private readonly ItemCollection<PropertyPageSchema> mPropertyPageSchemas;
        private readonly ItemCollection<PackageFiles> mPackageFiles;
        private readonly ItemCollection<WCFMetadataStorage> mWCFMetadataStorages;
        private readonly PropertyAccessor<string> mMSBuildToolsVersion;
        private readonly PropertyAccessor<string> mMSBuildToolsPath;
        private readonly PropertyAccessor<string> mMSBuildBinPath;
        private readonly PropertyAccessor<string> mMSBuildStartupDirectory;
        private readonly PropertyAccessor<int?> mMSBuildNodeCount;
        private readonly PropertyAccessor<string> mMSBuildProgramFiles32;
        private readonly PropertyAccessor<string> mMSBuildProjectFile;
        private readonly PropertyAccessor<string> mMSBuildProjectName;
        private readonly PropertyAccessor<string> mMSBuildProjectExtension;
        private readonly PropertyAccessor<string> mMSBuildProjectFullPath;
        private readonly PropertyAccessor<string> mMSBuildProjectDirectory;
        private readonly PropertyAccessor<string> mMSBuildProjectDirectoryNoRoot;
        private readonly PropertyAccessor<string> mMSBuildExtensionsPath32;
        private readonly PropertyAccessor<string> mMSBuildExtensionsPath64;
        private readonly PropertyAccessor<string> mMSBuildExtensionsPath;
        private readonly PropertyAccessor<string> mLOCALAPPDATA;
        private readonly PropertyAccessor<string> mMSBuildUserExtensionsPath;
        private readonly PropertyAccessor<string> mALLUSERSPROFILE;
        private readonly PropertyAccessor<string> mAPPDATA;
        private readonly PropertyAccessor<string> mCommonProgramFiles;
        private readonly PropertyAccessor<string> mCommonProgramW6432;
        private readonly PropertyAccessor<string> mCOMPUTERNAME;
        private readonly PropertyAccessor<string> mComSpec;
        private readonly PropertyAccessor<string> mconfigsetroot;
        private readonly PropertyAccessor<string> mFP_NO_HOST_CHECK;
        private readonly PropertyAccessor<string> mHOMEDRIVE;
        private readonly PropertyAccessor<string> mHOMEPATH;
        private readonly PropertyAccessor<string> mJAVA_HOME;
        private readonly PropertyAccessor<string> mLOGONSERVER;
        private readonly PropertyAccessor<bool?> mMSBuildLoadMicrosoftTargetsReadOnly;
        private readonly PropertyAccessor<int?> mNUMBER_OF_PROCESSORS;
        private readonly PropertyAccessor<string> mOS;
        private readonly PropertyAccessor<string> mPath;
        private readonly PropertyAccessor<string> mPATHEXT;
        private readonly PropertyAccessor<string> mPkgDefApplicationConfigFile;
        private readonly PropertyAccessor<string> mPROCESSOR_ARCHITECTURE;
        private readonly PropertyAccessor<string> mPROCESSOR_ARCHITEW6432;
        private readonly PropertyAccessor<string> mPROCESSOR_IDENTIFIER;
        private readonly PropertyAccessor<int?> mPROCESSOR_LEVEL;
        private readonly PropertyAccessor<int?> mPROCESSOR_REVISION;
        private readonly PropertyAccessor<string> mProgramData;
        private readonly PropertyAccessor<string> mProgramFiles;
        private readonly PropertyAccessor<string> mProgramW6432;
        private readonly PropertyAccessor<string> mPSModulePath;
        private readonly PropertyAccessor<string> mPUBLIC;
        private readonly PropertyAccessor<string> mSystemDrive;
        private readonly PropertyAccessor<string> mSystemRoot;
        private readonly PropertyAccessor<string> mTEMP;
        private readonly PropertyAccessor<string> mTMP;
        private readonly PropertyAccessor<string> mUOIPME_REG_PATH;
        private readonly PropertyAccessor<string> mUSERDOMAIN;
        private readonly PropertyAccessor<string> mUSERDOMAIN_ROAMINGPROFILE;
        private readonly PropertyAccessor<string> mUSERNAME;
        private readonly PropertyAccessor<string> mUSERPROFILE;
        private readonly PropertyAccessor<string> mVisualStudioDir;
        private readonly PropertyAccessor<string> mVisualStudioEdition;
        private readonly PropertyAccessor<string> mVisualStudioVersion;
        private readonly PropertyAccessor<string> mVS110COMNTOOLS;
        private readonly PropertyAccessor<string> mVS120COMNTOOLS;
        private readonly PropertyAccessor<string> mVS140COMNTOOLS;
        private readonly PropertyAccessor<int?> mVSLANG;
        private readonly PropertyAccessor<string> mwindir;
        private readonly PropertyAccessor<string> mSDK35ToolsPath;
        private readonly PropertyAccessor<string> mMSBuildToolsPath32;
        private readonly PropertyAccessor<string> mMSBuildToolsRoot;
        private readonly PropertyAccessor<string> mFrameworkSDKRoot;
        private readonly PropertyAccessor<string> mMSBuildRuntimeVersion;
        private readonly PropertyAccessor<string> mSDK40ToolsPath;
        private readonly PropertyAccessor<string> mConfiguration;
        private readonly PropertyAccessor<string> mMSBuildProjectDefaultTargets;
        private readonly PropertyAccessor<string> mPlatform;
        private readonly PropertyAccessor<string> mProjectGuid;
        private readonly PropertyAccessor<string> mOutputType;
        private readonly PropertyAccessor<string> mAppDesignerFolder;
        private readonly PropertyAccessor<string> mRootNamespace;
        private readonly PropertyAccessor<string> mAssemblyName;
        private readonly PropertyAccessor<string> mTargetFrameworkVersion;
        private readonly PropertyAccessor<int?> mFileAlignment;
        private readonly PropertyAccessor<string> mSolutionDir;
        private readonly PropertyAccessor<bool?> mRestorePackages;
        private readonly PropertyAccessor<string> mPlatformTarget;
        private readonly PropertyAccessor<bool?> mDebugSymbols;
        private readonly PropertyAccessor<string> mDebugType;
        private readonly PropertyAccessor<bool?> mOptimize;
        private readonly PropertyAccessor<string> mOutputPath;
        private readonly PropertyAccessor<string> mDefineConstants;
        private readonly PropertyAccessor<string> mErrorReport;
        private readonly PropertyAccessor<int?> mWarningLevel;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfterMicrosoftCSharpTargets;
        private readonly PropertyAccessor<string> mCustomBeforeMicrosoftCSharpTargets;
        private readonly PropertyAccessor<string> mCustomAfterMicrosoftCSharpTargets;
        private readonly PropertyAccessor<string> mMSBuildAllProjects;
        private readonly PropertyAccessor<string> mDefaultLanguageSourceExtension;
        private readonly PropertyAccessor<string> mLanguage;
        private readonly PropertyAccessor<string> mTargetRuntime;
        private readonly PropertyAccessor<string> mCreateManifestResourceNamesDependsOn;
        private readonly PropertyAccessor<bool?> mUseHostCompilerIfAvailable;
        private readonly PropertyAccessor<string> mCoreCompileDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBeforeMicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfterMicrosoftCommonTargets;
        private readonly PropertyAccessor<string> mCustomBeforeMicrosoftCommonTargets;
        private readonly PropertyAccessor<string> mCustomAfterMicrosoftCommonTargets;
        private readonly PropertyAccessor<string> mReportingServicesTargets;
        private readonly PropertyAccessor<string> mTargetFrameworkIdentifier;
        private readonly PropertyAccessor<string> mAvailablePlatforms;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mUpgradeSubsetToProfile;
        private readonly PropertyAccessor<bool?> mAddAdditionalExplicitAssemblyReferences;
        private readonly PropertyAccessor<string> mAdditionalExplicitAssemblyReferences;
        private readonly PropertyAccessor<string> mTargetFrameworkSDKToolsDirectory;
        private readonly PropertyAccessor<string> mTargetedRuntimeVersion;
        private readonly PropertyAccessor<bool?> mPrefer32Bit;
        private readonly PropertyAccessor<bool?> mHighEntropyVA;
        private readonly PropertyAccessor<string> mSubsystemVersion;
        private readonly PropertyAccessor<bool?> mImplicitlyExpandDesignTimeFacades;
        private readonly PropertyAccessor<bool?> mYieldDuringToolExecution;
        private readonly PropertyAccessor<string> mTargetFrameworkMoniker;
        private readonly PropertyAccessor<string> mFrameworkPathOverride;
        private readonly PropertyAccessor<string> mTargetPlatformIdentifier;
        private readonly PropertyAccessor<string> mTargetPlatformVersion;
        private readonly PropertyAccessor<string> mTargetPlatformSdkPath;
        private readonly PropertyAccessor<string> mTargetPlatformMoniker;
        private readonly PropertyAccessor<string> m_OriginalConfiguration;
        private readonly PropertyAccessor<string> m_OriginalPlatform;
        private readonly PropertyAccessor<string> mConfigurationName;
        private readonly PropertyAccessor<bool?> m_DebugSymbolsProduced;
        private readonly PropertyAccessor<bool?> m_DocumentationFileProduced;
        private readonly PropertyAccessor<string> mTargetExt;
        private readonly PropertyAccessor<string> mOutDir;
        private readonly PropertyAccessor<string> mProjectName;
        private readonly PropertyAccessor<string> mTargetName;
        private readonly PropertyAccessor<string> mProjectFileName;
        private readonly PropertyAccessor<string> mProjectExt;
        private readonly PropertyAccessor<string> mTargetFileName;
        private readonly PropertyAccessor<bool?> m_DeploymentPublishableProjectDefault;
        private readonly PropertyAccessor<string> mPublishableProject;
        private readonly PropertyAccessor<string> m_DeploymentTargetApplicationManifestFileName;
        private readonly PropertyAccessor<string> mTargetDeployManifestFileName;
        private readonly PropertyAccessor<string> mGenerateClickOnceManifests;
        private readonly PropertyAccessor<string> m_DeploymentApplicationManifestIdentity;
        private readonly PropertyAccessor<string> m_DeploymentDeployManifestIdentity;
        private readonly PropertyAccessor<string> m_DeploymentFileMappingExtension;
        private readonly PropertyAccessor<int?> m_DeploymentBuiltUpdateInterval;
        private readonly PropertyAccessor<string> m_DeploymentBuiltUpdateIntervalUnits;
        private readonly PropertyAccessor<int?> mMaxTargetPath;
        private readonly PropertyAccessor<string> mTargetCulture;
        private readonly PropertyAccessor<string> mTargetDir;
        private readonly PropertyAccessor<string> mTargetPath;
        private readonly PropertyAccessor<string> mProjectDir;
        private readonly PropertyAccessor<string> mProjectPath;
        private readonly PropertyAccessor<string> mPlatformName;
        private readonly PropertyAccessor<string> mDevEnvDir;
        private readonly PropertyAccessor<string> mSolutionName;
        private readonly PropertyAccessor<string> mSolutionFileName;
        private readonly PropertyAccessor<string> mSolutionPath;
        private readonly PropertyAccessor<string> mSolutionExt;
        private readonly PropertyAccessor<bool?> mAutoUnifyAssemblyReferences;
        private readonly PropertyAccessor<string> mBaseIntermediateOutputPath;
        private readonly PropertyAccessor<string> mCleanFile;
        private readonly PropertyAccessor<bool?> mBuildProjectReferences;
        private readonly PropertyAccessor<bool?> mBuildInParallel;
        private readonly PropertyAccessor<bool?> m_ResolveReferenceDependencies;
        private readonly PropertyAccessor<bool?> m_GetChildProjectCopyToOutputDirectoryItems;
        private readonly PropertyAccessor<bool?> mOverwriteReadOnlyFiles;
        private readonly PropertyAccessor<bool?> mComReferenceNoClassMembers;
        private readonly PropertyAccessor<string> mIntermediateOutputPath;
        private readonly PropertyAccessor<string> m_DeploymentUrl;
        private readonly PropertyAccessor<string> mPublishDir;
        private readonly PropertyAccessor<string> mProcessorArchitecture;
        private readonly PropertyAccessor<bool?> mConsiderPlatformAsProcessorArchitecture;
        private readonly PropertyAccessor<string> mTargetFrameworkAsMSBuildRuntime;
        private readonly PropertyAccessor<bool?> mPlatformTargetAsMSBuildArchitectureExplicitlySet;
        private readonly PropertyAccessor<string> mPlatformTargetAsMSBuildArchitecture;
        private readonly PropertyAccessor<string> mProjectFlavor;
        private readonly PropertyAccessor<string> mDelaySign;
        private readonly PropertyAccessor<bool?> mWebReference_EnableProperties;
        private readonly PropertyAccessor<bool?> mWebReference_EnableSQLTypes;
        private readonly PropertyAccessor<bool?> mWebReference_EnableLegacyEventingModel;
        private readonly PropertyAccessor<string> mAssemblyFoldersSuffix;
        private readonly PropertyAccessor<string> mFrameworkRegistryBase;
        private readonly PropertyAccessor<string> mTargetPlatformRegistryBase;
        private readonly PropertyAccessor<string> mAssemblySearchPaths;
        private readonly PropertyAccessor<string> mAllowedReferenceAssemblyFileExtensions;
        private readonly PropertyAccessor<string> mAllowedReferenceRelatedFileExtensions;
        private readonly PropertyAccessor<string> mFullReferenceAssemblyNames;
        private readonly PropertyAccessor<bool?> mContinueOnError;
        private readonly PropertyAccessor<string> mBuildDependsOn;
        private readonly PropertyAccessor<string> mCoreBuildDependsOn;
        private readonly PropertyAccessor<string> m_ProjectDefaultTargets;
        private readonly PropertyAccessor<string> mRebuildDependsOn;
        private readonly PropertyAccessor<string> mBuildGenerateSourcesAction;
        private readonly PropertyAccessor<string> mBuildCompileAction;
        private readonly PropertyAccessor<string> mBuildLinkAction;
        private readonly PropertyAccessor<string> mRunDependsOn;
        private readonly PropertyAccessor<bool?> mBuildingProject;
        private readonly PropertyAccessor<string> mPrepareForBuildDependsOn;
        private readonly PropertyAccessor<string> mFramework40Dir;
        private readonly PropertyAccessor<string> mFramework35Dir;
        private readonly PropertyAccessor<string> mFramework30Dir;
        private readonly PropertyAccessor<string> mFramework20Dir;
        private readonly PropertyAccessor<string> mFrameworkDir;
        private readonly PropertyAccessor<string> mTargetedFrameworkDir;
        private readonly PropertyAccessor<string> mFrameworkSDKDir;
        private readonly PropertyAccessor<string> mGetFrameworkPathsDependsOn;
        private readonly PropertyAccessor<string> mPreBuildEventDependsOn;
        private readonly PropertyAccessor<string> mUnmanagedUnregistrationDependsOn;
        private readonly PropertyAccessor<string> mResolveReferencesDependsOn;
        private readonly PropertyAccessor<string> mGetTargetPathDependsOn;
        private readonly PropertyAccessor<string> mResolveAssemblyReferencesDependsOn;
        private readonly PropertyAccessor<string> mSDKReferenceRegistryRoot;
        private readonly PropertyAccessor<string> mSDKReferenceDirectoryRoot;
        private readonly PropertyAccessor<string> mResolveSDKReferencesDependsOn;
        private readonly PropertyAccessor<string> mTargetedSDKConfiguration;
        private readonly PropertyAccessor<string> mTargetedSDKArchitecture;
        private readonly PropertyAccessor<string> mExpandSDKReferencesDependsOn;
        private readonly PropertyAccessor<string> mExpandSDKAllowedReferenceExtensions;
        private readonly PropertyAccessor<string> mProjectDesignTimeAssemblyResolutionSearchPaths;
        private readonly PropertyAccessor<string> mDesignTimeResolveAssemblyReferencesDependsOn;
        private readonly PropertyAccessor<bool?> mComReferenceExecuteAsTool;
        private readonly PropertyAccessor<string> mPrepareResourcesDependsOn;
        private readonly PropertyAccessor<string> mPrepareResourceNamesDependsOn;
        private readonly PropertyAccessor<string> mAssignTargetPathsDependsOn;
        private readonly PropertyAccessor<string> mCreateCustomManifestResourceNamesDependsOn;
        private readonly PropertyAccessor<string> mResGenDependsOn;
        private readonly PropertyAccessor<string> mCoreResGenDependsOn;
        private readonly PropertyAccessor<bool?> mUseSourcePath;
        private readonly PropertyAccessor<bool?> mResGenExecuteAsTool;
        private readonly PropertyAccessor<string> mCompileLicxFilesDependsOn;
        private readonly PropertyAccessor<string> mCompileDependsOn;
        private readonly PropertyAccessor<string> mTargetFrameworkMonikerAssemblyAttributesPath;
        private readonly PropertyAccessor<bool?> mGenerateTargetFrameworkAttribute;
        private readonly PropertyAccessor<string> m_SGenDllName;
        private readonly PropertyAccessor<bool?> m_SGenDllCreated;
        private readonly PropertyAccessor<string> m_SGenGenerateSerializationAssembliesConfig;
        private readonly PropertyAccessor<bool?> mSGenUseProxyTypes;
        private readonly PropertyAccessor<bool?> mSGenShouldGenerateSerializer;
        private readonly PropertyAccessor<string> mCreateSatelliteAssembliesDependsOn;
        private readonly PropertyAccessor<string> mComputeIntermediateSatelliteAssembliesDependsOn;
        private readonly PropertyAccessor<string> mEmbeddedWin32Manifest;
        private readonly PropertyAccessor<string> mGenerateManifestsDependsOn;
        private readonly PropertyAccessor<bool?> mSkipCopyUnchangedFiles;
        private readonly PropertyAccessor<bool?> mUseCommonOutputDirectory;
        private readonly PropertyAccessor<string> mPrepareForRunDependsOn;
        private readonly PropertyAccessor<bool?> mCreateHardLinksForCopyAdditionalFilesIfPossible;
        private readonly PropertyAccessor<string> mGetCopyToOutputDirectoryItemsDependsOn;
        private readonly PropertyAccessor<string> mUnmanagedRegistrationDependsOn;
        private readonly PropertyAccessor<string> mCleanDependsOn;
        private readonly PropertyAccessor<string> mCoreCleanDependsOn;
        private readonly PropertyAccessor<string> mPostBuildEventDependsOn;
        private readonly PropertyAccessor<string> mPublishDependsOn;
        private readonly PropertyAccessor<string> mPublishOnlyDependsOn;
        private readonly PropertyAccessor<string> mPublishBuildDependsOn;
        private readonly PropertyAccessor<string> mBuiltProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<bool?> mAddAppConfigToBuildOutputs;
        private readonly PropertyAccessor<string> mDebugSymbolsProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mDocumentationProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mSatelliteDllsProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mSourceFilesProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mContentFilesProjectOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mSGenFilesOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mSDKRedistOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mCodeAnalysisTargets;
        private readonly PropertyAccessor<string> mCodeAnalysisStaticAnalysisDirectory;
        private readonly PropertyAccessor<string> mCodeAnalysisRuleSetDirectories;
        private readonly PropertyAccessor<string> mCodeAnalysisPath;
        private readonly PropertyAccessor<bool?> mCodeAnalysisApplyLogFileXsl;
        private readonly PropertyAccessor<bool?> mCodeAnalysisFailOnMissingRules;
        private readonly PropertyAccessor<bool?> mCodeAnalysisForceOutput;
        private readonly PropertyAccessor<bool?> mCodeAnalysisGenerateSuccessFile;
        private readonly PropertyAccessor<bool?> mCodeAnalysisIgnoreGeneratedCode;
        private readonly PropertyAccessor<bool?> mCodeAnalysisIgnoreInvalidTargets;
        private readonly PropertyAccessor<bool?> mCodeAnalysisIgnoreMissingIndirectReferences;
        private readonly PropertyAccessor<string> mCodeAnalysisInputAssembly;
        private readonly PropertyAccessor<string> mCodeAnalysisLogFile;
        private readonly PropertyAccessor<string> mCodeAnalysisModuleSuppressionsFile;
        private readonly PropertyAccessor<bool?> mCodeAnalysisOverrideRuleVisibilities;
        private readonly PropertyAccessor<bool?> mCodeAnalysisOutputToConsole;
        private readonly PropertyAccessor<bool?> mCodeAnalysisQuiet;
        private readonly PropertyAccessor<string> mCodeAnalysisRuleDirectories;
        private readonly PropertyAccessor<string> mCodeAnalysisSaveMessagesToReport;
        private readonly PropertyAccessor<bool?> mCodeAnalysisSearchGlobalAssemblyCache;
        private readonly PropertyAccessor<string> mCodeAnalysisSucceededFile;
        private readonly PropertyAccessor<bool?> mCodeAnalysisSummary;
        private readonly PropertyAccessor<int?> mCodeAnalysisTimeout;
        private readonly PropertyAccessor<bool?> mCodeAnalysisTreatWarningsAsErrors;
        private readonly PropertyAccessor<bool?> mCodeAnalysisUpdateProject;
        private readonly PropertyAccessor<bool?> mCodeAnalysisUseTypeNameInSuppression;
        private readonly PropertyAccessor<bool?> mCodeAnalysisVerbose;
        private readonly PropertyAccessor<string> mCodeAnalysisRuleSet;
        private readonly PropertyAccessor<string> mRunCodeAnalysisDependsOn;
        private readonly PropertyAccessor<string> mRunCodeAnalysisInputs;
        private readonly PropertyAccessor<string> mRunNativeCodeAnalysisInputs;
        private readonly PropertyAccessor<string> mMergedOutputCodeAnalysisFile;
        private readonly PropertyAccessor<string> mCompileRdlFilesDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<string> mImplicitlyExpandDesignTimeFacadesDependsOn;
        private readonly PropertyAccessor<string> mBuildSystem;
        private readonly PropertyAccessor<string> mTaskVersion;
        private readonly PropertyAccessor<string> mTaskKeyToken;
        private readonly PropertyAccessor<string> mBuildTaskAssembly;
        private readonly PropertyAccessor<bool?> mAlwaysCompileMarkupFilesInSeparateDomain;
        private readonly PropertyAccessor<string> mLocalizationDirectivesToLocFile;
        private readonly PropertyAccessor<string> mGetReferenceAssemblyPathsDependsOn;
        private readonly PropertyAccessor<bool?> mXamlDebuggingInformation;
        private readonly PropertyAccessor<bool?> mHostInBrowser;
        private readonly PropertyAccessor<string> mVersion;
        private readonly PropertyAccessor<string> mDeploymentType;
        private readonly PropertyAccessor<bool?> mRunAfterInstall;
        private readonly PropertyAccessor<string> mGeneratedFileExtension;
        private readonly PropertyAccessor<string> mOSVersion;
        private readonly PropertyAccessor<bool?> m_RequireMCPass2ForSatelliteAssemblyOnly;
        private readonly PropertyAccessor<bool?> m_RequireMCPass2ForMainAssembly;
        private readonly PropertyAccessor<bool?> mIsApplication;
        private readonly PropertyAccessor<string> m_AfterCompileWinFXInternalDependsOn;
        private readonly PropertyAccessor<string> mMarkupCompilePass2ForMainAssemblyDependsOn;
        private readonly PropertyAccessor<string> m_CompileTargetNameForLocalType;
        private readonly PropertyAccessor<string> m_ResourceNameInMainAssembly;
        private readonly PropertyAccessor<string> mEntityDeployIntermediateResourcePath;
        private readonly PropertyAccessor<string> mEntityDeployDependsOn;
        private readonly PropertyAccessor<string> mLoadTimeSensitiveTargets;
        private readonly PropertyAccessor<string> mLoadTimeSensitiveProperties;
        private readonly PropertyAccessor<string> mXamlBuildTaskAssemblyName;
        private readonly PropertyAccessor<bool?> mXamlRequiresCompilationPass2;
        private readonly PropertyAccessor<string> mXamlTemporaryAssemblyName;
        private readonly PropertyAccessor<string> mCompileTargetNameForTemporaryAssembly;
        private readonly PropertyAccessor<string> mXamlBuildTaskLocation;
        private readonly PropertyAccessor<string> mXamlGenCodeFileNames;
        private readonly PropertyAccessor<string> mXamlGenMarkupFileNames;
        private readonly PropertyAccessor<string> mXamlPass2FlagFile;
        private readonly PropertyAccessor<string> mDesignTimeIntermediateOutputPath;
        private readonly PropertyAccessor<string> mWorkflowBuildExtensionVersion;
        private readonly PropertyAccessor<string> mWorkflowBuildExtensionKeyToken;
        private readonly PropertyAccessor<string> mWorkflowBuildExtensionAssemblyName;
        private readonly PropertyAccessor<string> mGenerateCompiledExpressionsTempFilePathForEditing;
        private readonly PropertyAccessor<string> mGenerateCompiledExpressionsTempFilePathForValidation;
        private readonly PropertyAccessor<string> mGenerateCompiledExpressionsTempFilePathForTypeInfer;
        private readonly PropertyAccessor<string> mDeferredValidationErrorsFileName;
        private readonly PropertyAccessor<string> mMsTestToolsTargets;
        private readonly PropertyAccessor<string> mMsAppxPackageTargets;
        private readonly PropertyAccessor<bool?> mUtf8Output;
        private readonly PropertyAccessor<bool?> mNoCompilerStandardLib;
        private readonly PropertyAccessor<bool?> mBuildPackage;
        private readonly PropertyAccessor<bool?> mRequireRestoreConsent;
        private readonly PropertyAccessor<bool?> mDownloadNuGetExe;
        private readonly PropertyAccessor<string> mNuGetToolsPath;
        private readonly PropertyAccessor<string> mPackagesConfig;
        private readonly PropertyAccessor<string> mNuGetExePath;
        private readonly PropertyAccessor<string> mPackageSources;
        private readonly PropertyAccessor<string> mNuGetCommand;
        private readonly PropertyAccessor<string> mPackageOutputDir;
        private readonly PropertyAccessor<string> mRequireConsentSwitch;
        private readonly PropertyAccessor<string> mRestoreCommand;
        private readonly PropertyAccessor<string> mBuildCommand;
        private readonly PropertyAccessor<string> mProcessorArchitectureAsPlatform;
        private readonly PropertyAccessor<bool?> mIsLibrary;
        private readonly PropertyAccessor<string> mProductVersion;
        private readonly PropertyAccessor<string> mSchemaVersion;
        private readonly PropertyAccessor<string> mProjectTypeGuids;
        private readonly PropertyAccessor<bool?> mUseIISExpress;
        private readonly PropertyAccessor<string> mIISExpressSSLPort;
        private readonly PropertyAccessor<string> mIISExpressAnonymousAuthentication;
        private readonly PropertyAccessor<string> mIISExpressWindowsAuthentication;
        private readonly PropertyAccessor<string> mIISExpressUseClassicPipelineMode;
        private readonly PropertyAccessor<string> mVSToolsPath;
        private readonly PropertyAccessor<bool?> mWebProjectOutputDirInsideProjectDefault;
        private readonly PropertyAccessor<string> mWebProjectOutputDirInsideProject;
        private readonly PropertyAccessor<bool?> mDisableLinkInCopyWebApplicaton;
        private readonly PropertyAccessor<bool?> mDisable_CopyWebApplication;
        private readonly PropertyAccessor<bool?> mUseWPP_CopyWebApplication;
        private readonly PropertyAccessor<bool?> mCleanWebProjectOutputDir;
        private readonly PropertyAccessor<string> mWebProjectOutputDir;
        private readonly PropertyAccessor<string> mCleanWebProjectOutputDirDependsOn;
        private readonly PropertyAccessor<string> mOnBefore_CopyWebApplicationDefault;
        private readonly PropertyAccessor<string> mOnBefore_CopyWebApplication;
        private readonly PropertyAccessor<string> mOnAfter_CopyWebApplication;
        private readonly PropertyAccessor<string> m_CopyWebApplicationDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftWebPublishingTargets;
        private readonly PropertyAccessor<string> m_WPPVersion;
        private readonly PropertyAccessor<string> m_WPPSupports;
        private readonly PropertyAccessor<string> m_WPPWebPublishMethodSupports;
        private readonly PropertyAccessor<string> mWebPublishPipelineProjectDirectory;
        private readonly PropertyAccessor<string> mWebPublishPipelineSourceRootDirectory;
        private readonly PropertyAccessor<string> mWebPublishPipelineTransformRootDirectory;
        private readonly PropertyAccessor<string> mWebPublishPipelineProjectName;
        private readonly PropertyAccessor<string> mWebPublishPipelineProjectFile;
        private readonly PropertyAccessor<string> mWebPublishPipeLineProjectFullPath;
        private readonly PropertyAccessor<string> mWebPublishPipelineWAPProjectSettings;
        private readonly PropertyAccessor<bool?> mVerifyDatabaseSettingWithImport;
        private readonly PropertyAccessor<string> m_LocalDBVersionToUseForSqlExpress;
        private readonly PropertyAccessor<bool?> m_PublishProfileSet;
        private readonly PropertyAccessor<bool?> mEnableWebPublishProfileFile;
        private readonly PropertyAccessor<string> m_WPPDefaultIntermediateOutputPath;
        private readonly PropertyAccessor<string> m_WPPDefaultIntermediateOutputFullPath;
        private readonly PropertyAccessor<string> mPublishProfileRootFolder;
        private readonly PropertyAccessor<string> mPublishProfileName;
        private readonly PropertyAccessor<bool?> m_WebPublishProfileFileWillBeImported;
        private readonly PropertyAccessor<string> mWebPublishPipelineCustomizeTargetFile;
        private readonly PropertyAccessor<string> mWebPublishPipelineSolutionTargetFile;
        private readonly PropertyAccessor<string> m_WPPCleanTargets;
        private readonly PropertyAccessor<string> mFilesToIncludeForPublish;
        private readonly PropertyAccessor<string> mAlternativeProjectDirectory;
        private readonly PropertyAccessor<bool?> mExcludeGeneratedDebugSymbol;
        private readonly PropertyAccessor<bool?> mExcludeXmlAssemblyFiles;
        private readonly PropertyAccessor<bool?> mExcludeApp_Data;
        private readonly PropertyAccessor<string> mSkipApp_DataFolder;
        private readonly PropertyAccessor<bool?> mUseMsdeployExe;
        private readonly PropertyAccessor<bool?> mEnableCollectLinkFilesInProject;
        private readonly PropertyAccessor<bool?> mExcludeLinkFilesInProject;
        private readonly PropertyAccessor<bool?> mCleanWPPAllFilesInSingleFolder;
        private readonly PropertyAccessor<bool?> mIncludeIisSettings;
        private readonly PropertyAccessor<bool?> mExcludeFilesFromPackage;
        private readonly PropertyAccessor<bool?> mImportParametersFiles;
        private readonly PropertyAccessor<bool?> mImportParametersFile_DisableEscapeMSBuildVariable;
        private readonly PropertyAccessor<bool?> mImportProjectParametersFiles;
        private readonly PropertyAccessor<bool?> mImportProfileParametersFiles;
        private readonly PropertyAccessor<bool?> mImportPublishingParameterValues;
        private readonly PropertyAccessor<bool?> mEnableOptimisticParameterDefaultValue;
        private readonly PropertyAccessor<bool?> mParameterApplicationPool;
        private readonly PropertyAccessor<bool?> mIIS6ParameterApplicationPool;
        private readonly PropertyAccessor<bool?> mDisableAllVSGeneratedMSDeployParameter;
        private readonly PropertyAccessor<bool?> mAutoParameterizationWebConfigConnectionStrings;
        private readonly PropertyAccessor<bool?> mAutoParameterizationWebConfigCSNoDefaultValue;
        private readonly PropertyAccessor<string> mAutoParameterizationWebConfigConnectionStringsIntermediateOutput;
        private readonly PropertyAccessor<string> mAutoParameterizationWebConfigConnectionStringsLocation;
        private readonly PropertyAccessor<string> m_WPPLastBuildInfoIntermediateOutput;
        private readonly PropertyAccessor<string> m_WPPLastBuildInfoLocation;
        private readonly PropertyAccessor<bool?> mInsertAdditionalWebCofigConnectionStrings;
        private readonly PropertyAccessor<string> mInsertAdditionalWebCofigConnectionStringsIntermediateOutput;
        private readonly PropertyAccessor<string> mInsertAdditionalWebCofigConnectionStringsLocation;
        private readonly PropertyAccessor<string> mInsertAdditionalWebConfigConnectionStringProviderName;
        private readonly PropertyAccessor<bool?> mInsertAdditionalWebConfigConnectionStringOnlyInRoot;
        private readonly PropertyAccessor<string> mSqlScriptSourceTransacted;
        private readonly PropertyAccessor<string> mAutoSqlScriptSourceTransacted;
        private readonly PropertyAccessor<string> mDatabaseDeployIntermediateRelativePath;
        private readonly PropertyAccessor<string> mDatabaseDeployIntermediateOutputPath;
        private readonly PropertyAccessor<string> m_WebConfigsToAutoParmeterizeCsTransformOutputParametersFile;
        private readonly PropertyAccessor<string> mDeployDefaultTarget;
        private readonly PropertyAccessor<string> mDeployTarget;
        private readonly PropertyAccessor<int?> mRetryAttemptsForDeployment;
        private readonly PropertyAccessor<bool?> mDeployOnBuildDefault;
        private readonly PropertyAccessor<string> mDeployOnBuild;
        private readonly PropertyAccessor<bool?> mEnableMSDeployBackup;
        private readonly PropertyAccessor<bool?> mEnableMSDeployAppOffline;
        private readonly PropertyAccessor<bool?> mMSDeployUseChecksum;
        private readonly PropertyAccessor<bool?> mMSDeployEnableWebConfigEncryptRule;
        private readonly PropertyAccessor<string> mMSDeployWebConfigEncryptProvider;
        private readonly PropertyAccessor<string> m_MSDeployUserAgentSource;
        private readonly PropertyAccessor<string> m_MSDeployUserAgent;
        private readonly PropertyAccessor<bool?> mPipelineDependsOnBuild;
        private readonly PropertyAccessor<string> m_DeployOnBuild;
        private readonly PropertyAccessor<bool?> mWPPCopyWebApplicaitonPipelineCircularDependencyError;
        private readonly PropertyAccessor<string> mPipelineDependsOn;
        private readonly PropertyAccessor<string> mProjectConfigFileName;
        private readonly PropertyAccessor<string> m_ProjectConfigFileExtension;
        private readonly PropertyAccessor<string> m_ProjectConfigFilePrefix;
        private readonly PropertyAccessor<string> mProjectConfigTransformFileName;
        private readonly PropertyAccessor<bool?> mTransformWebConfigEnabled;
        private readonly PropertyAccessor<bool?> mTransformWebConfigStackTraceEnabled;
        private readonly PropertyAccessor<bool?> mUseParameterizeToTransformWebConfig;
        private readonly PropertyAccessor<string> mTransformWebConfigIntermediateOutput;
        private readonly PropertyAccessor<string> mTransformWebConfigIntermediateLocation;
        private readonly PropertyAccessor<string> m_WebConfigTransformOutputParametersFile;
        private readonly PropertyAccessor<bool?> mProfileTransformWebConfigEnabled;
        private readonly PropertyAccessor<bool?> mProfileTransformWebConfigStackTraceEnabled;
        private readonly PropertyAccessor<bool?> mUseParameterizeToProfileTransformWebConfig;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigIntermediateOutput;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigIntermediateLocation;
        private readonly PropertyAccessor<string> m_ProfileWebConfigTransformOutputParametersFile;
        private readonly PropertyAccessor<bool?> mParameterizeTransformXmlUseXPath;
        private readonly PropertyAccessor<string> mDefaultPackageOutputDir;
        private readonly PropertyAccessor<string> mDefaultPackageFileName;
        private readonly PropertyAccessor<string> mDefaultMSDeployDestinationSite;
        private readonly PropertyAccessor<string> mDefaultMsDeployAltSuffix;
        private readonly PropertyAccessor<string> mDefaultMSDeployDestinationApplicationName;
        private readonly PropertyAccessor<string> mDefaultDeployIisAppPath;
        private readonly PropertyAccessor<string> mDefaultDeployIisRootAppPath;
        private readonly PropertyAccessor<bool?> mPackageAsSingleFile;
        private readonly PropertyAccessor<string> mPackageLocation;
        private readonly PropertyAccessor<string> mPackageFileName;
        private readonly PropertyAccessor<string> mPackageArchiveRootDir;
        private readonly PropertyAccessor<string> mPackageTempRootDir;
        private readonly PropertyAccessor<bool?> mDeployAsIisApp;
        private readonly PropertyAccessor<bool?> mIncludeSetAclProviderOnDestination;
        private readonly PropertyAccessor<bool?> mMarkApp_DataWritableOnDestination;
        private readonly PropertyAccessor<bool?> mIgnoreDeployManagedRuntimeVersion;
        private readonly PropertyAccessor<string> mDeployDefaultTargetFrameworkVersion;
        private readonly PropertyAccessor<string> mDeployManagedRuntimeVersion;
        private readonly PropertyAccessor<string> mDeployEnable32bitAppOnWin64;
        private readonly PropertyAccessor<string> mDeployManagedPipelineMode;
        private readonly PropertyAccessor<bool?> mGenerateSampleDeployScript;
        private readonly PropertyAccessor<string> mPackageLogDir;
        private readonly PropertyAccessor<bool?> mEnablePackageProcessLoggingAndAssert;
        private readonly PropertyAccessor<string> mPackageTraceLevel;
        private readonly PropertyAccessor<bool?> m_CreatePackage;
        private readonly PropertyAccessor<bool?> m_UseDefaultLinkExtensionValue;
        private readonly PropertyAccessor<string> mPackageEnableLinks;
        private readonly PropertyAccessor<string> mPackageDisableLinks;
        private readonly PropertyAccessor<string> mProjectParametersXMLFile;
        private readonly PropertyAccessor<bool?> mEnableProjectDeployParameterPrefix;
        private readonly PropertyAccessor<string> mDeployParameterIISAppName;
        private readonly PropertyAccessor<string> mDeployParameterIISAppPoolName;
        private readonly PropertyAccessor<string> mDeployParameterApp_DataWritePermission;
        private readonly PropertyAccessor<string> mDeployParameterIISAppPhysicalPath;
        private readonly PropertyAccessor<bool?> mDeployParameterAutoDescriptionbyTags;
        private readonly PropertyAccessor<string> mDeployParameterIISAppNameDescription;
        private readonly PropertyAccessor<string> mDeployParameterIISAppPoolNameDescription;
        private readonly PropertyAccessor<string> mDeployParameterIISAppPhysicalPathDescription;
        private readonly PropertyAccessor<string> mDeployParameterIISAppConnectionStringDescription;
        private readonly PropertyAccessor<string> mDeployParameterSqlScriptVariablesDescription;
        private readonly PropertyAccessor<string> mMsDeployDatabaseTag;
        private readonly PropertyAccessor<string> mMsDeploySqlCommandVariableKind;
        private readonly PropertyAccessor<string> mMsdeploySqlUnsupportedCommand;
        private readonly PropertyAccessor<bool?> mCheckSqlScriptForUnsupportedCommands;
        private readonly PropertyAccessor<string> mUpdateFromConnectionStringAttributes;
        private readonly PropertyAccessor<bool?> mTreadSqlScriptUnsupportedCommandsAsWarning;
        private readonly PropertyAccessor<string> m_PackageTempDir;
        private readonly PropertyAccessor<string> mWPPAllFilesInSingleFolder;
        private readonly PropertyAccessor<bool?> mIsWPPAllFilesInSingleFolder;
        private readonly PropertyAccessor<bool?> mEnableSqlScriptVariableParameterize;
        private readonly PropertyAccessor<string> mSqlScriptPreProcessBatchDelimiter;
        private readonly PropertyAccessor<bool?> mSqlScriptPreProcessResolveIncludes;
        private readonly PropertyAccessor<string> mDeployIisAppPath;
        private readonly PropertyAccessor<string> mRemoteSitePhysicalPath;
        private readonly PropertyAccessor<string> mDefaultDeployIisAppPhysicalPath;
        private readonly PropertyAccessor<string> mDeployIisAppPhysicalPath;
        private readonly PropertyAccessor<string> m_DestinationIisAppPhysicalPath;
        private readonly PropertyAccessor<string> mDestinationIisVersion;
        private readonly PropertyAccessor<string> mDestinationUseIis;
        private readonly PropertyAccessor<string> mPublishEnableLinks;
        private readonly PropertyAccessor<string> mPublishDisableLinks;
        private readonly PropertyAccessor<string> mDeployEncryptKey;
        private readonly PropertyAccessor<bool?> mSkipExtraFilesOnServer;
        private readonly PropertyAccessor<string> mMsDeployServiceUrl;
        private readonly PropertyAccessor<int?> mVsIisAppParametersPriority;
        private readonly PropertyAccessor<int?> mVsContentPathParametersPriority;
        private readonly PropertyAccessor<int?> mVsDestinationVDirParametersPriority;
        private readonly PropertyAccessor<int?> mVsSetAclPriority;
        private readonly PropertyAccessor<int?> mUserProfileParametersFileParametersPriority;
        private readonly PropertyAccessor<int?> mUserParametersFileParametersPriority;
        private readonly PropertyAccessor<int?> mUserWebConfigParametersPriority;
        private readonly PropertyAccessor<int?> mVsSQLDatabaseScriptParametersPriority;
        private readonly PropertyAccessor<int?> mVsWebConfigAutoCsParametersPriority;
        private readonly PropertyAccessor<string> mGenerateSampleDeployScriptLocation;
        private readonly PropertyAccessor<string> mPackageSourceManifest;
        private readonly PropertyAccessor<string> mUseDeclareParametersXMLInMsDeploy;
        private readonly PropertyAccessor<string> mPackageParametersFile;
        private readonly PropertyAccessor<string> mPublishParametersFile;
        private readonly PropertyAccessor<string> mGenerateSampleDeployScriptReadMeFileName;
        private readonly PropertyAccessor<string> mGenerateSampleDeployScriptReadMeLocation;
        private readonly PropertyAccessor<string> mGenerateSampleParametersValueLocationDefault;
        private readonly PropertyAccessor<string> mGenerateSampleParametersValueLocation;
        private readonly PropertyAccessor<string> mGenerateSampleParametersValueFileName;
        private readonly PropertyAccessor<string> mFilesToIncludeTargetFile;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets;
        private readonly PropertyAccessor<string> mPublishPipelineCollectFilesCore;
        private readonly PropertyAccessor<bool?> mExcludeTransformAssistFilesFromPublish;
        private readonly PropertyAccessor<string> mCollectFilesFromIntermediateAssemblyDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromContentDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromAddModulesDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFrom_SGenDllCreatedDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromReferenceDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromAllExtraReferenceFilesDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromDocFileItemDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFrom_binDeployableAssembliesDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets;
        private readonly PropertyAccessor<bool?> mAspNetCompileMerge;
        private readonly PropertyAccessor<string> mWeb_Publishing_AspNetCompileMerge_targets;
        private readonly PropertyAccessor<string> mMicrosoft_Web_Publishing_MSDeploy_Common_targets;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets;
        private readonly PropertyAccessor<bool?> mMicrosoft_Web_Publishing_MSDeploy_Common_targets_Imported;
        private readonly PropertyAccessor<bool?> mInsertEFCodeFirstDeployWebCofig;
        private readonly PropertyAccessor<string> mInsertEFCodeFirstDeployWebCofigIntermediateOutput;
        private readonly PropertyAccessor<string> mInsertEFCodeFirstDeployWebCofigLocation;
        private readonly PropertyAccessor<bool?> mPublishDatabases;
        private readonly PropertyAccessor<string> mProcessPublishDatabaseSettingsDependsOn;
        private readonly PropertyAccessor<string> mParseSQLScriptForMSDeployParametersDependsOn;
        private readonly PropertyAccessor<string> mHandleEFCodeFirstDataMigrationDependsOn;
        private readonly PropertyAccessor<string> mPreInsertEFCodeFirstDeployWebCofigDependsOn;
        private readonly PropertyAccessor<string> mPreInsertEFCodeFirstDeployWebCofigBeforeTarget;
        private readonly PropertyAccessor<string> mInsertEFCodeFirstDeployWebCofigCoreDependsOn;
        private readonly PropertyAccessor<string> mPostInsertEFCodeFirstDeployWebCofigDependsOn;
        private readonly PropertyAccessor<string> mInsertEFCodeFirstDeployWebCofigDependsOn;
        private readonly PropertyAccessor<string> mInsertEFCodeFirstDeployWebCofigBeforeTargets;
        private readonly PropertyAccessor<string> mCollectDatabasesToPublishDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddDeclareParametersItemsForDatabaseScript;
        private readonly PropertyAccessor<string> mAfterAddDeclareParametersItemsForDatabaseScript;
        private readonly PropertyAccessor<string> mAddDeclareParametersItemsForDatabaseScriptDependsOn;
        private readonly PropertyAccessor<string> mWriteItemsToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddDatabasesToSourceManifest;
        private readonly PropertyAccessor<string> mAfterAddDatabasesToSourceManifest;
        private readonly PropertyAccessor<string> mAddDatabasesToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mAddDatabasesToSourceManifestAfterTargets;
        private readonly PropertyAccessor<string> mGenerateSampleDeployScriptDependsOn;
        private readonly PropertyAccessor<string> mGenerateSampleDeployScriptAfterTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets;
        private readonly PropertyAccessor<string> mExcludeApp_DataDependsOn;
        private readonly PropertyAccessor<string> mExcludeGeneratedDebugSymbolDependsOn;
        private readonly PropertyAccessor<string> mExcludeXmlAssemblyFilesDependsOn;
        private readonly PropertyAccessor<bool?> m_EnableCleanOnBuildForMvcViews;
        private readonly PropertyAccessor<bool?> mEnableExcludeFilesByExtension;
        private readonly PropertyAccessor<string> mExcludeFilesByExtensionDependsOn;
        private readonly PropertyAccessor<string> mWebPublishExtensionsToExclude;
        private readonly PropertyAccessor<string> mExcludeFilesFromPackageDependsOn;
        private readonly PropertyAccessor<string> mValidateGlobalSettingsDependsOn;
        private readonly PropertyAccessor<string> mValidateGlobalPackageSettingDependsOn;
        private readonly PropertyAccessor<string> m_CleanWPPIfNeedToDependsOn;
        private readonly PropertyAccessor<string> mOnBeforePipelineCollectFilesPhase;
        private readonly PropertyAccessor<string> mOnAfterPipelineCollectFilesPhase;
        private readonly PropertyAccessor<string> mPipelineCollectFilesPhaseDependsOn;
        private readonly PropertyAccessor<string> mTransformWebConfigBeforeTargets;
        private readonly PropertyAccessor<string> mTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mCollectWebConfigsToTransformDependsOn;
        private readonly PropertyAccessor<string> mPreTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mTransformWebConfigCoreDependsOn;
        private readonly PropertyAccessor<string> mParameterizeTransformWebConfigCoreDependsOn;
        private readonly PropertyAccessor<string> mPostTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mMarkWebConfigAssistFilesAsExcludeDependsOn;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigBeforeTargets;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigAfterTargets;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesForProfileTransformWebConfigsDependsOn;
        private readonly PropertyAccessor<string> mPreProfileTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mProfileTransformWebConfigCoreDependsOn;
        private readonly PropertyAccessor<string> mParameterizeProfileTransformWebConfigCoreDependsOn;
        private readonly PropertyAccessor<string> mPostProfileTransformWebConfigDependsOn;
        private readonly PropertyAccessor<string> mPreInsertAdditionalWebCofigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mInsertAdditionalWebCofigConnectionStringsCoreDependsOn;
        private readonly PropertyAccessor<string> mPostInsertAdditionalWebCofigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mInsertAdditionalWebCofigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mInsertAdditionalWebCofigConnectionStringsBeforeTargets;
        private readonly PropertyAccessor<string> mPreAutoParameterizationWebConfigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mAutoParameterizationWebConfigConnectionStringsCoreDependsOn;
        private readonly PropertyAccessor<string> mPostAutoParameterizationWebConfigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mAutoParameterizationWebConfigConnectionStringsDependsOn;
        private readonly PropertyAccessor<string> mPipelineTransformPhaseDependsOn;
        private readonly PropertyAccessor<string> mPipelineMsdeploySpecificTransformPhaseBeforeTargets;
        private readonly PropertyAccessor<string> mPipelineMsdeploySpecificTransformPhaseDependsOn;
        private readonly PropertyAccessor<string> m_WPPCopyWebApplicationDependsOn;
        private readonly PropertyAccessor<string> mPipelinePreDeployCopyAllFilesToOneFolderDependsOn;
        private readonly PropertyAccessor<string> mCopyAllFilesToSingleFolderForMsdeployDependsOn;
        private readonly PropertyAccessor<string> mPipelineCopyAllFilesToOneFolderForMsdeployDependsOn;
        private readonly PropertyAccessor<string> mGetProjectWebPropertiesDependsOn;
        private readonly PropertyAccessor<string> mGetMSDeployInstalledVersionPathDependsOn;
        private readonly PropertyAccessor<string> mPackageDependsOn;
        private readonly PropertyAccessor<string> mCopyAllFilesToSingleFolderForPackageDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddIis7ToSourceManifest;
        private readonly PropertyAccessor<string> mAfterAddIis7ToSourceManifest;
        private readonly PropertyAccessor<string> mAddIis7ToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddDeclareParametersItemsForIis7;
        private readonly PropertyAccessor<string> mAfterAddDeclareParametersItemsForIis7;
        private readonly PropertyAccessor<string> mAddDeclareParametersItemsForIis7DependsOn;
        private readonly PropertyAccessor<string> mBeforeAddIis6ToSourceManifest;
        private readonly PropertyAccessor<string> mAfterAddIis6ToSourceManifest;
        private readonly PropertyAccessor<string> mAddIis6ToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddDeclareParametersItemsForIis6;
        private readonly PropertyAccessor<string> mAfterAddDeclareParametersItemsForIis6;
        private readonly PropertyAccessor<string> mAddDeclareParametersItemsForIis6DependsOn;
        private readonly PropertyAccessor<string> mBeforeAddIisSettingAndFileContentsToSourceManifest;
        private readonly PropertyAccessor<string> mAfterAddIisSettingAndFileContentsToSourceManifest;
        private readonly PropertyAccessor<string> mAddIisSettingAndFileContentsToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddContentPathToSourceManifest;
        private readonly PropertyAccessor<string> mAfterAddContentPathToSourceManifest;
        private readonly PropertyAccessor<string> mAddContentPathToSourceManifestDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddIisAndContentDeclareParametersItems;
        private readonly PropertyAccessor<string> mAfterAddIisAndContentDeclareParametersItems;
        private readonly PropertyAccessor<string> mAddIisAndContentDeclareParametersItemsDependsOn;
        private readonly PropertyAccessor<string> mBeforeAddDeclareParametersItemsForContentPath;
        private readonly PropertyAccessor<string> mAfterAddDeclareParametersItemsForContentPath;
        private readonly PropertyAccessor<string> mAddDeclareParametersItemsForContentPathDependsOn;
        private readonly PropertyAccessor<string> mBeforeWriteItemsToSourceManifest;
        private readonly PropertyAccessor<string> mAfterWriteItemsToSourceManifest;
        private readonly PropertyAccessor<string> mBeforeAddDeclareParametersItems;
        private readonly PropertyAccessor<string> mAfterAddDeclareParametersItems;
        private readonly PropertyAccessor<string> mAddDeclareParametersItemsDependsOn;
        private readonly PropertyAccessor<string> m_GatherParamsDependsOn;
        private readonly PropertyAccessor<string> mGenerateMsDeployManifestSettingsDependsOn;
        private readonly PropertyAccessor<string> mCleanWebsitesPackageCoreDependsOn;
        private readonly PropertyAccessor<string> mCleanWebsitesPackageDependsOn;
        private readonly PropertyAccessor<string> mCleanWebsitesWPPAllFilesInSingleFolderDependsOn;
        private readonly PropertyAccessor<string> mCleanWebPublishPipelineIntermediateOutputDependsOn;
        private readonly PropertyAccessor<string> mCheckAndCleanMSDeployPackageIfNeededDependsOn;
        private readonly PropertyAccessor<string> mOnAfterGenerateMsdeployManifestFiles;
        private readonly PropertyAccessor<string> mGenerateMsdeployManifestFilesDependsOn;
        private readonly PropertyAccessor<string> mPackageUsingManifestDependsOn;
        private readonly PropertyAccessor<string> mTestDeployPackageToLocalDependsOn;
        private readonly PropertyAccessor<bool?> mNormalizePublishSettings;
        private readonly PropertyAccessor<string> mAuthType;
        private readonly PropertyAccessor<string> mMSDeployPublishMethod;
        private readonly PropertyAccessor<string> mGenerateGlobalPublishSettingDependsOn;
        private readonly PropertyAccessor<bool?> mCreatePackageOnPublish;
        private readonly PropertyAccessor<string> mMSDeployPublishDependsOn;
        private readonly PropertyAccessor<string> mValidatePublishProfileSettingsDependsOn;
        private readonly PropertyAccessor<string> mWebMSDeployPublishDependsOn;
        private readonly PropertyAccessor<string> mWebPackagePublishDependsOn;
        private readonly PropertyAccessor<string> mWebPublishDependsOn;
        private readonly PropertyAccessor<string> mPipelineDeployPhaseDependsOn;
        private readonly PropertyAccessor<string> mPipelineDeployPhaseAfterTargets;
        private readonly PropertyAccessor<string> mDbDacFxPreviewDependsOn;
        private readonly PropertyAccessor<string> mDbFullSqlPreviewDependsOn;
        private readonly PropertyAccessor<string> mValidateDbDacFxPreviewSettingsDependsOn;
        private readonly PropertyAccessor<string> mLocalDbDacFxPreviewDependsOn;
        private readonly PropertyAccessor<string> mRemoteDbDacFxPreviewDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftWebPublishingTargets;
        private readonly PropertyAccessor<string> m_TransformWebConfigForAzureAuthenticationDependsOn;
        private readonly PropertyAccessor<string> mMSBuildFrameworkToolsPath;
        private readonly PropertyAccessor<string> mMSBuildFrameworkToolsPath32;
        private readonly PropertyAccessor<string> mMSBuildFrameworkToolsRoot;
        private readonly PropertyAccessor<string> mVCTargetsPath;
        private readonly PropertyAccessor<string> mVCTargetsPath10;
        private readonly PropertyAccessor<string> mVCTargetsPath11;
        private readonly PropertyAccessor<string> mVCTargetsPath12;
        private readonly PropertyAccessor<string> mWindowsSDK80Path;
        private readonly PropertyAccessor<string> mCustomBeforeMicrosoftCommonProps;
        private readonly PropertyAccessor<string> mCustomAfterMicrosoftCommonProps;
        private readonly PropertyAccessor<bool?> mMicrosoftCommonPropsHasBeenImported;
        private readonly PropertyAccessor<string> mWMSJSProject;
        private readonly PropertyAccessor<string> mWMSJSProjectDirectory;
        private readonly PropertyAccessor<string> mTargetFrameworkProfile;
        private readonly PropertyAccessor<bool?> mUseVSHostingProcess;
        private readonly PropertyAccessor<bool?> mSignAssembly;
        private readonly PropertyAccessor<string> mAssemblyOriginatorKeyFile;
        private readonly PropertyAccessor<string> mCSharpTargetsPath;
        private readonly PropertyAccessor<string> mCscToolPath;
        private readonly PropertyAccessor<bool?> mImportByWildcardBefore40MicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfter40MicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBefore40MicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfter40MicrosoftCommonTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardBefore40MicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfter40MicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardBefore40MicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfter40MicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps;
        private readonly PropertyAccessor<string> mNetFrameworkTargetsPath;
        private readonly PropertyAccessor<bool?> mImportByWildcardBefore40MicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfter40MicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<bool?> mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets;
        private readonly PropertyAccessor<string> mXamlBuildTaskPath;
        private readonly PropertyAccessor<bool?> mAllowUnsafeBlocks;
        private readonly PropertyAccessor<string> mMinimumVisualStudioVersion;
        private readonly PropertyAccessor<string> mDefaultLanguage;
        private readonly PropertyAccessor<string> mTargetFrameworkMonikerDisplayName;
        private readonly PropertyAccessor<bool?> mImplicitlyExpandTargetFramework;
        private readonly PropertyAccessor<string> mImplicitlyExpandTargetFrameworkDependsOn;
        private readonly PropertyAccessor<string> mReferencePath;
        private readonly PropertyAccessor<bool?> mIsCodedUITest;
        private readonly PropertyAccessor<string> mTestProjectType;
        private readonly PropertyAccessor<string> mRootPath;
        private readonly PropertyAccessor<bool?> m_InvalidConfigurationError;
        private readonly PropertyAccessor<bool?> mSilverlightBuild;
        private readonly PropertyAccessor<string> mBuildName;
        private readonly PropertyAccessor<int?> mProject_Major;
        private readonly PropertyAccessor<int?> mProject_Minor;
        private readonly PropertyAccessor<int?> mProject_Build;
        private readonly PropertyAccessor<int?> mAssemblyVersion_Build;
        private readonly PropertyAccessor<string> mBuildScriptsPath;
        private readonly PropertyAccessor<string> mBuildConfigDescription;
        private readonly PropertyAccessor<string> mBuildPath;
        private readonly PropertyAccessor<string> mToolsPath;
        private readonly PropertyAccessor<string> mTestResultsPath;
        private readonly PropertyAccessor<string> mAssemblyInfoFile;
        private readonly PropertyAccessor<string> mAssemblyTitle;
        private readonly PropertyAccessor<string> mAssemblyProduct;
        private readonly PropertyAccessor<bool?> mComVisible;
        private readonly PropertyAccessor<bool?> mCLSCompliant;
        private readonly PropertyAccessor<bool?> mAllowPartiallyTrustedCallers;
        private readonly PropertyAccessor<string> mAssemblyVersion_Major;
        private readonly PropertyAccessor<string> mAssemblyVersion_Minor;
        private readonly PropertyAccessor<int?> mBuild_Number;
        private readonly PropertyAccessor<string> mBuild_Revision;
        private readonly PropertyAccessor<string> mTestDetectionExpression;
        private readonly PropertyAccessor<bool?> mTestRunner_Enabled;
        private readonly PropertyAccessor<int?> mTestRunner_Timeout;
        private readonly PropertyAccessor<bool?> mTestRunner_ContinueOnError;
        private readonly PropertyAccessor<string> mNUnitExecutable;
        private readonly PropertyAccessor<string> mNUnitPath;
        private readonly PropertyAccessor<string> mMSBuildCommunityTasksPath;
        private readonly PropertyAccessor<string> mMSBuildCommunityTasksLib;
        private readonly PropertyAccessor<string> mFileUpgradeFlags;
        private readonly PropertyAccessor<string> mUpgradeBackupLocation;
        private readonly PropertyAccessor<bool?> mSilverlightApplication;
        private readonly PropertyAccessor<string> mSupportedCultures;
        private readonly PropertyAccessor<bool?> mXapOutputs;
        private readonly PropertyAccessor<bool?> mGenerateSilverlightManifest;
        private readonly PropertyAccessor<string> mXapFilename;
        private readonly PropertyAccessor<string> mSilverlightManifestTemplate;
        private readonly PropertyAccessor<string> mSilverlightAppEntry;
        private readonly PropertyAccessor<bool?> mCreateTestPage;
        private readonly PropertyAccessor<bool?> mValidateXaml;
        private readonly PropertyAccessor<bool?> mEnableOutOfBrowser;
        private readonly PropertyAccessor<string> mOutOfBrowserSettingsFile;
        private readonly PropertyAccessor<bool?> mUsePlatformExtensions;
        private readonly PropertyAccessor<bool?> mThrowErrorsInValidation;
        private readonly PropertyAccessor<string> mLinkedServerProject;
        private readonly PropertyAccessor<string> mOldToolsVersion;
        private readonly PropertyAccessor<string> mProjectType;
        private readonly PropertyAccessor<string> mApplicationIcon;
        private readonly PropertyAccessor<string> mAssemblyKeyContainerName;
        private readonly PropertyAccessor<string> mDefaultClientScript;
        private readonly PropertyAccessor<string> mDefaultHTMLPageLayout;
        private readonly PropertyAccessor<string> mDefaultTargetSchema;
        private readonly PropertyAccessor<string> mRunPostBuildEvent;
        private readonly PropertyAccessor<string> mStartupObject;
        private readonly PropertyAccessor<string> mPreBuildEvent;
        private readonly PropertyAccessor<string> mPostBuildEvent;
        private readonly PropertyAccessor<string> mBuildToolsVersion;
        private readonly PropertyAccessor<string> mSourceDir;
        private readonly PropertyAccessor<string> mBinDir;
        private readonly PropertyAccessor<string> mObjDir;
        private readonly PropertyAccessor<string> mTestWorkingDir;
        private readonly PropertyAccessor<string> mPackagesOutDir;
        private readonly PropertyAccessor<string> mPackagesDir;
        private readonly PropertyAccessor<string> mToolsDir;
        private readonly PropertyAccessor<string> mNuGetToolPath;
        private readonly PropertyAccessor<string> mNuGetConfigFile;
        private readonly PropertyAccessor<string> mNuGetConfigCommandLine;
        private readonly PropertyAccessor<string> mNugetRestoreCommand;
        private readonly PropertyAccessor<string> mConfigurationGroup;
        private readonly PropertyAccessor<string> mOSGroup;
        private readonly PropertyAccessor<bool?> mNoStdLib;
        private readonly PropertyAccessor<bool?> mNoExplicitReferenceToStdLib;
        private readonly PropertyAccessor<string> mCommonPath;
        private readonly PropertyAccessor<string> mCommonTestPath;
        private readonly PropertyAccessor<string> mOSPlatformConfig;
        private readonly PropertyAccessor<string> mBaseOutputPath;
        private readonly PropertyAccessor<string> mTestPath;
        private readonly PropertyAccessor<string> mPackagesBasePath;
        private readonly PropertyAccessor<bool?> mTargetsWindows;
        private readonly PropertyAccessor<string> m_WindowsKitBinPath;
        private readonly PropertyAccessor<string> m_WindowsPhoneKitBinPath;
        private readonly PropertyAccessor<string> mMakePriExeFullPath;
        private readonly PropertyAccessor<string> mMakeAppxExeFullPath;
        private readonly PropertyAccessor<string> mSignAppxPackageExeFullPath;
        private readonly PropertyAccessor<string> mMakePriExtensionPath;
        private readonly PropertyAccessor<string> mMakePriExtensionPath_x64;
        private readonly PropertyAccessor<bool?> mErrorIfBuildToolsRestoredFromIndividualProject;
        private readonly PropertyAccessor<string> mAssemblyVersion;
        private readonly PropertyAccessor<string> mTestCategories;
        private readonly PropertyAccessor<string> mDocumentationFile;
        private readonly PropertyAccessor<bool?> mGenerateAppxPackageOnBuild;
        private readonly PropertyAccessor<string> mNuGetPackageImportStamp;
        private readonly PropertyAccessor<string> mDebugEngines;
        private readonly PropertyAccessor<bool?> mGenerateAssemblyInfo;
        private readonly PropertyAccessor<string> mNoWarn;
        private readonly PropertyAccessor<string> mRuntimeSerializationSources;
        private readonly PropertyAccessor<string> mJsonSources;
        private readonly PropertyAccessor<string> mXmlSources;
        private readonly PropertyAccessor<string> mTextSources;
        private readonly PropertyAccessor<bool?> mCheckForOverflowUnderflow;
        private readonly PropertyAccessor<bool?> mExternallyShipping;
        private readonly PropertyAccessor<bool?> mRunTestsForProject;
        private readonly PropertyAccessor<string> mCommonPathXPath;
        private readonly PropertyAccessor<string> mTypeScriptTarget;
        private readonly PropertyAccessor<bool?> mTypeScriptCompileOnSaveEnabled;
        private readonly PropertyAccessor<bool?> mTypeScriptNoImplicitAny;
        private readonly PropertyAccessor<string> mTypeScriptModuleKind;
        private readonly PropertyAccessor<bool?> mTypeScriptRemoveComments;
        private readonly PropertyAccessor<string> mTypeScriptOutFile;
        private readonly PropertyAccessor<string> mTypeScriptOutDir;
        private readonly PropertyAccessor<bool?> mTypeScriptGeneratesDeclarations;
        private readonly PropertyAccessor<bool?> mTypeScriptSourceMap;
        private readonly PropertyAccessor<string> mTypeScriptMapRoot;
        private readonly PropertyAccessor<string> mTypeScriptSourceRoot;
        private readonly PropertyAccessor<bool?> mTypeScriptNoEmitOnError;
        private readonly PropertyAccessor<string> mTypeScriptToolsVersion;
        private readonly PropertyAccessor<string> mVsToolsPath;
        private readonly PropertyAccessor<string> mCfgPropertyPagesGuidsAddCSharp;
        private readonly PropertyAccessor<string> mCfgPropertyPagesGuidsAddVB;
        private readonly PropertyAccessor<string> mCfgPropertyPagesGuidsAddTypeScript;
        private readonly PropertyAccessor<bool?> mTypeScriptEnabled;
        private readonly PropertyAccessor<string> mTypeScriptBuildConfigurations;
        private readonly PropertyAccessor<string> mTscToolPath;
        private readonly PropertyAccessor<string> mTscToolExe;
        private readonly PropertyAccessor<bool?> mTscYieldDuringToolExecution;
        private readonly PropertyAccessor<bool?> mConsolePause;
        private readonly PropertyAccessor<string> mPublishUrl;
        private readonly PropertyAccessor<bool?> mInstall;
        private readonly PropertyAccessor<string> mInstallFrom;
        private readonly PropertyAccessor<bool?> mUpdateEnabled;
        private readonly PropertyAccessor<string> mUpdateMode;
        private readonly PropertyAccessor<int?> mUpdateInterval;
        private readonly PropertyAccessor<string> mUpdateIntervalUnits;
        private readonly PropertyAccessor<bool?> mUpdatePeriodically;
        private readonly PropertyAccessor<bool?> mUpdateRequired;
        private readonly PropertyAccessor<bool?> mMapFileExtensions;
        private readonly PropertyAccessor<int?> mApplicationRevision;
        private readonly PropertyAccessor<string> mApplicationVersion;
        private readonly PropertyAccessor<bool?> mIsWebBootstrapper;
        private readonly PropertyAccessor<bool?> mUseApplicationTrust;
        private readonly PropertyAccessor<bool?> mBootstrapperEnabled;
        private readonly PropertyAccessor<string> m_FullFrameworkReferenceAssemblyPaths;
        private readonly PropertyAccessor<string> m_TargetFrameworkDirectories;
        private readonly PropertyAccessor<bool?> mTreatWarningsAsErrors;
        private readonly PropertyAccessor<bool?> mRegisterForComInterop;
        private readonly PropertyAccessor<string> mGenerateSerializationAssemblies;
        private readonly PropertyAccessor<int?> mBaseAddress;
        private readonly PropertyAccessor<string> mPublishUrlHistory;
        private readonly PropertyAccessor<string> mInstallUrlHistory;
        private readonly PropertyAccessor<string> mSupportUrlHistory;
        private readonly PropertyAccessor<string> mUpdateUrlHistory;
        private readonly PropertyAccessor<string> mBootstrapperUrlHistory;
        private readonly PropertyAccessor<string> mErrorReportUrlHistory;
        private readonly PropertyAccessor<string> mFallbackCulture;
        private readonly PropertyAccessor<bool?> mVerifyUploadedFiles;
        private readonly PropertyAccessor<string> mSccProjectName;
        private readonly PropertyAccessor<string> mSccLocalPath;
        private readonly PropertyAccessor<string> mSccAuxPath;
        private readonly PropertyAccessor<string> mSccProvider;
        private readonly PropertyAccessor<string> mSilverlightVersion;
        private readonly PropertyAccessor<bool?> mNoConfig;
        private readonly PropertyAccessor<string> mVCInstallDir_110;
        private readonly PropertyAccessor<string> mWP80ToolSetPath;
        private readonly PropertyAccessor<string> mWindowsPhoneSdkRegkeyRoot;
        private readonly PropertyAccessor<string> mWindowsPhoneRegistryBase;
        private readonly PropertyAccessor<string> mWindowsPhoneRegistryBaseVersion;
        private readonly PropertyAccessor<string> mRuntimePathRegistryKey;
        private readonly PropertyAccessor<string> mResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch;
        private readonly PropertyAccessor<string> mWindowsPhoneSdkVersion;
        private readonly PropertyAccessor<string> mWindowsPhoneSdkInstallPath;
        private readonly PropertyAccessor<string> mWindowsPhone71RegistryBase;
        private readonly PropertyAccessor<string> mWindowsPhone71RegistryBaseVersion;
        private readonly PropertyAccessor<string> mWindowsPhone7RegistryBase;
        private readonly PropertyAccessor<string> mWindowsPhone7RegistryBaseVersion;
        private readonly PropertyAccessor<string> mWindowsPhoneFxReferencesDisplayName;
        private readonly PropertyAccessor<string> mPathOfWMAppManifestRelativeToProject;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeWindowsPhoneCommonTargets;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterWindowsPhoneCommonTargets;
        private readonly PropertyAccessor<bool?> mIncludeBuiltProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeDebugSymbolsProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeDocumentationProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeSatelliteDllsProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeSourceFilesProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeContentFilesProjectOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeSGenFilesOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeCopyLocalFilesOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeComFilesOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeCustomOutputGroupForPackaging;
        private readonly PropertyAccessor<bool?> mIncludeCopyWinmdArtifactsOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeSDKRedistOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeGetResolvedSDKReferences;
        private readonly PropertyAccessor<bool?> mValidateXapFilenames;
        private readonly PropertyAccessor<string> mAllOutputGroupsDependsOn;
        private readonly PropertyAccessor<string> mCopyLocalFilesOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mGetPackagingOutputsDependsOn;
        private readonly PropertyAccessor<string> mFilterPackagingOutPutsDependsOn;
        private readonly PropertyAccessor<string> m_GetPackagePropertiesDependsOn;
        private readonly PropertyAccessor<string> mSignToolPath;
        private readonly PropertyAccessor<string> mValidateXapFilenamesDependsOn;
        private readonly PropertyAccessor<string> mComputeWinMDsDependsOn;
        private readonly PropertyAccessor<string> mWMAppManifestWinMDRegistrationDependsOn;
        private readonly PropertyAccessor<bool?> mExtMapFileValidationAsError;
        private readonly PropertyAccessor<bool?> mOutOfBrowserPlusAppCachingIsSupported;
        private readonly PropertyAccessor<string> mFrameworkRegistryBaseWithVersion;
        private readonly PropertyAccessor<string> mRuntimeVersionRegistryKey;
        private readonly PropertyAccessor<bool?> mReferencesValidationRequiredForWindowsPhone;
        private readonly PropertyAccessor<string> mCompileXamlDependsOn;
        private readonly PropertyAccessor<string> mValidateXamlDependsOn;
        private readonly PropertyAccessor<string> mXapPackagerDependsOn;
        private readonly PropertyAccessor<string> mFilesToXapDependsOn;
        private readonly PropertyAccessor<string> mCreateSilverlightAppManifestDependsOn;
        private readonly PropertyAccessor<string> mCategorizeSilverlightReferencesDependsOn;
        private readonly PropertyAccessor<string> mPackagePlatformExtensionsDependsOn;
        private readonly PropertyAccessor<bool?> mImplicitlyExpandTargetPlatform;
        private readonly PropertyAccessor<string> mWindowsPhoneSDK_MetadataPath;
        private readonly PropertyAccessor<string> mCopyWinmdArtifactsOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mPackagesProjectConfig;
        private readonly PropertyAccessor<string> mNonInteractiveSwitch;
        private readonly PropertyAccessor<string> mPaddedSolutionDir;
        private readonly PropertyAccessor<string> mConfigurationOverrideFile;
        private readonly PropertyAccessor<bool?> mRemoveIntegerChecks;
        private readonly PropertyAccessor<string> m_DisabledWarnings;
        private readonly PropertyAccessor<string> mLoadTimeSensitiveItems;
        private readonly PropertyAccessor<string> mLoadTimeCheckItemLocation;
        private readonly PropertyAccessor<string> mGetRedistListsDependsOn;
        private readonly PropertyAccessor<bool?> mUnloadProjectsOnCompletion;
        private readonly PropertyAccessor<string> mWinFXNativePath;
        private readonly PropertyAccessor<string> mWinFXWowPath;
        private readonly PropertyAccessor<bool?> mTargetingClr2Framework;
        private readonly PropertyAccessor<string> mMSBuildManagedCompilerPath;
        private readonly PropertyAccessor<string> mRiaClientCodeGenDependsOn;
        private readonly PropertyAccessor<string> mCoreRiaClientCodeGenDependsOn;
        private readonly PropertyAccessor<string> mRiaClientCleanDependsOn;
        private readonly PropertyAccessor<string> m_RiaClientCodeGenOutputPath;
        private readonly PropertyAccessor<string> m_RiaClientCodeGenHistoryFile;
        private readonly PropertyAccessor<string> mDefaultClientReferences;
        private readonly PropertyAccessor<string> mPrepareForRiaClientCodeGenDependsOn;
        private readonly PropertyAccessor<bool?> mWindowsAppContainer;
        private readonly PropertyAccessor<bool?> mSuppressWarningsInPass1;
        private readonly PropertyAccessor<string> mTargetPlatformSdkMetadataLocation;
        private readonly PropertyAccessor<string> mTargetPlatformWinMDLocation;
        private readonly PropertyAccessor<string> mAppxMSBuildToolsPath;
        private readonly PropertyAccessor<string> mAppxMSBuildTaskAssembly;
        private readonly PropertyAccessor<bool?> mAppxPackage;
        private readonly PropertyAccessor<bool?> mAppxUseHardlinksIfPossible;
        private readonly PropertyAccessor<bool?> mAppxSkipUnchangedFiles;
        private readonly PropertyAccessor<bool?> mAppxGeneratePriEnabled;
        private readonly PropertyAccessor<bool?> mAppxGetPackagePropertiesEnabled;
        private readonly PropertyAccessor<bool?> mAppxPackageIncludePrivateSymbols;
        private readonly PropertyAccessor<bool?> mAppxSymbolPackageEnabled;
        private readonly PropertyAccessor<bool?> mAppxTestLayoutEnabled;
        private readonly PropertyAccessor<bool?> mAppxPackageValidationEnabled;
        private readonly PropertyAccessor<bool?> mAppxHarvestWinmdRegistration;
        private readonly PropertyAccessor<bool?> mAutoIncrementPackageRevision;
        private readonly PropertyAccessor<bool?> mAppxPrependPriInitialPath;
        private readonly PropertyAccessor<bool?> mEnableSigningChecks;
        private readonly PropertyAccessor<bool?> mAppxStrictManifestValidationEnabled;
        private readonly PropertyAccessor<bool?> mAppxFilterOutUnusedLanguagesResourceFileMaps;
        private readonly PropertyAccessor<bool?> mAppxGeneratePrisForPortableLibrariesEnabled;
        private readonly PropertyAccessor<bool?> mAppxGeneratePackageRecipeEnabled;
        private readonly PropertyAccessor<bool?> m_TargetPlatformIsWindowsPhone;
        private readonly PropertyAccessor<bool?> mAppxPackageSigningEnabled;
        private readonly PropertyAccessor<string> mAppxOSMinVersion;
        private readonly PropertyAccessor<string> mAppxOSMaxVersionTested;
        private readonly PropertyAccessor<string> mAppxPackageDirName;
        private readonly PropertyAccessor<string> mAppxPackageDirInProjectDir;
        private readonly PropertyAccessor<string> mPlatformSpecificBundleArtifactsListDirName;
        private readonly PropertyAccessor<string> mPlatformSpecificBundleArtifactsListDirInProjectDir;
        private readonly PropertyAccessor<string> mAppxPackageDir;
        private readonly PropertyAccessor<string> mAppxPackageArtifactsDir;
        private readonly PropertyAccessor<string> mFinalAppxManifestName;
        private readonly PropertyAccessor<bool?> mAppxValidateAppxManifest;
        private readonly PropertyAccessor<string> mStoreManifestName;
        private readonly PropertyAccessor<string> mResgenToolPath;
        private readonly PropertyAccessor<string> mPdbCopyExeFullPath;
        private readonly PropertyAccessor<string> mAppxSymbolStrippedDir;
        private readonly PropertyAccessor<string> mAppxPriInitialPath;
        private readonly PropertyAccessor<string> mProjectPriFileName;
        private readonly PropertyAccessor<string> mProjectPriFullPath;
        private readonly PropertyAccessor<string> mAppxPackageRecipe;
        private readonly PropertyAccessor<string> mFinalAppxPackageRecipe;
        private readonly PropertyAccessor<bool?> mAllowLocalNetworkLoopback;
        private readonly PropertyAccessor<string> mAppxDefaultHashAlgorithmId;
        private readonly PropertyAccessor<string> mAppxPackageFileMap;
        private readonly PropertyAccessor<string> mLayoutDir;
        private readonly PropertyAccessor<string> mManagedWinmdInprocImplementation;
        private readonly PropertyAccessor<bool?> mUseIncrementalAppxRegistration;
        private readonly PropertyAccessor<string> mAppxPackagingInfoFile;
        private readonly PropertyAccessor<bool?> mAppxOSMinVersionReplaceManifestVersion;
        private readonly PropertyAccessor<bool?> mAppxOSMaxVersionTestedReplaceManifestVersion;
        private readonly PropertyAccessor<string> mPackagingFileWritesLogPath;
        private readonly PropertyAccessor<string> mPackagingDirectoryWritesLogPath;
        private readonly PropertyAccessor<bool?> mAppxCopyLocalFilesOutputGroupIncludeXmlFiles;
        private readonly PropertyAccessor<string> mAppxPriConfigXmlPackagingSnippetPath;
        private readonly PropertyAccessor<string> mAppxPriConfigXmlDefaultSnippetPath;
        private readonly PropertyAccessor<string> mTargetPlatformSdkRootOverride;
        private readonly PropertyAccessor<string> mTargetPlatformResourceVersion;
        private readonly PropertyAccessor<string> mAppxPackageExtension;
        private readonly PropertyAccessor<string> mAppxSymbolPackageExtension;
        private readonly PropertyAccessor<string> mAppxBundleExtension;
        private readonly PropertyAccessor<string> mAppxStoreContainerExtension;
        private readonly PropertyAccessor<string> mAppxIntermediateExtension;
        private readonly PropertyAccessor<string> mAppxBundle;
        private readonly PropertyAccessor<string> mAppxBundlePlatforms;
        private readonly PropertyAccessor<string> mAppxBundleProducingPlatform;
        private readonly PropertyAccessor<string> mAppxBundleResourcePacksProducingPlatform;
        private readonly PropertyAccessor<string> mAppxLayoutFolderName;
        private readonly PropertyAccessor<string> mAppxLayoutDir;
        private readonly PropertyAccessor<string> mAppxBundlePriConfigXmlForSplittingFileName;
        private readonly PropertyAccessor<string> mAppxBundleAutoResourcePackageQualifiers;
        private readonly PropertyAccessor<string> mAppxBundleSplitResourcesPriPrefix;
        private readonly PropertyAccessor<string> mAppxBundleSplitResourcesPriPath;
        private readonly PropertyAccessor<string> mAppxBundleSplitResourcesGeneratedFilesListPath;
        private readonly PropertyAccessor<string> mAppxBundleSplitResourcesQualifiersPath;
        private readonly PropertyAccessor<string> mAppxBundlePriConfigXmlForMainPackageFileMapFileName;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapIntermediatePrefix;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapSuffix;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapIntermediatePath;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapIntermediatePriPath;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapGeneratedFilesListPath;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapPrefix;
        private readonly PropertyAccessor<string> mAppxBundleMainPackageFileMapPath;
        private readonly PropertyAccessor<string> mAppxBundleFolderSuffix;
        private readonly PropertyAccessor<string> mPlatformSpecificBundleArtifactsListDir;
        private readonly PropertyAccessor<string> mAppxDefaultResourceQualifiers_Windows_80;
        private readonly PropertyAccessor<string> mAppxDefaultResourceQualifiers_Windows_81;
        private readonly PropertyAccessor<string> mAppxDefaultResourceQualifiers_Windows_Phone;
        private readonly PropertyAccessor<string> mAppxDefaultResourceQualifiers;
        private readonly PropertyAccessor<bool?> mAppxPackageAllowDebugFrameworkReferencesInManifest;
        private readonly PropertyAccessor<bool?> mInsertReverseMap;
        private readonly PropertyAccessor<string> m_ProjectPriFullPathOriginal;
        private readonly PropertyAccessor<bool?> mIncludePriFilesOutputGroup;
        private readonly PropertyAccessor<bool?> mIncludeProjectPriFile;
        private readonly PropertyAccessor<string> mValidatePresenceOfAppxManifestItemsDependsOn;
        private readonly PropertyAccessor<string> m_GenerateProjectPriFileDependsOn;
        private readonly PropertyAccessor<string> m_PriConfigXmlPath;
        private readonly PropertyAccessor<string> m_LayoutResfilesPath;
        private readonly PropertyAccessor<string> m_ResourcesResfilesPath;
        private readonly PropertyAccessor<string> m_PriResfilesPath;
        private readonly PropertyAccessor<string> m_QualifiersPath;
        private readonly PropertyAccessor<string> m_MultipleQualifiersPerDimensionFoundPath;
        private readonly PropertyAccessor<string> m_ProjectArchitecturesFilePath;
        private readonly PropertyAccessor<string> m_GenerateAppxManifestDependsOn;
        private readonly PropertyAccessor<string> m_GenerateAppxPackageRecipeDependsOn;
        private readonly PropertyAccessor<string> m_GenerateAppxPackageBaseDependsOn;
        private readonly PropertyAccessor<string> m_GenerateAppxPackageDependsOn;
        private readonly PropertyAccessor<string> m_CreateAppxPackageDependsOn;
        private readonly PropertyAccessor<string> m_CreateAppxBundlePlatformSpecificArtifactsDependsOn;
        private readonly PropertyAccessor<string> m_CreateAppxBundleFilesDependsOn;
        private readonly PropertyAccessor<string> mComFilesOutputGroupDependsOn;
        private readonly PropertyAccessor<string> mPrepareLayoutDependsOn;
        private readonly PropertyAccessor<string> mRegisterAppxLayoutDependsOn;
        private readonly PropertyAccessor<string> mUnRegisterAppxLayoutDependsOn;
        private readonly PropertyAccessor<string> mVCInstallDir;
        private readonly PropertyAccessor<bool?> mXAMLFingerprint;
        private readonly PropertyAccessor<string> mXAMLFingerprintIgnorePaths;
        private readonly PropertyAccessor<string> mPriIndexName;
        private readonly PropertyAccessor<string> mOnXamlPreCompileErrorTarget;
        private readonly PropertyAccessor<bool?> mXamlShareAppDomains;
        private readonly PropertyAccessor<string> mXamlGeneratedOutputPath;
        private readonly PropertyAccessor<string> mPrepareLibraryLayoutDependsOn;
        private readonly PropertyAccessor<bool?> mFindInvalidProjectReferences;
        private readonly PropertyAccessor<string> mIPhoneResourcePrefix;
        private readonly PropertyAccessor<string> mTargetPlatformMonikerDisplayName;
        private readonly PropertyAccessor<string> mPortableSDKRoot;
        private readonly PropertyAccessor<string> mXamlTargetPlatformVersion;
        private readonly PropertyAccessor<string> mWindowsUIXamlCommonTargets;
        private readonly PropertyAccessor<string> mImplicitlyExpandTargetPlatformDependsOn;
        private readonly PropertyAccessor<string> mDeterminePortablePlatformSdkPathDependsOn;
        private readonly PropertyAccessor<string> mDeterminePortableBuildCapabilitiesDependsOn;
        private readonly PropertyAccessor<string> mTargetPlatformRootPath;
        private readonly PropertyAccessor<string> mPackageCertificateKeyFile;
        private readonly PropertyAccessor<bool?> mAppXPackage;
        private readonly PropertyAccessor<string> mCleanPackageAction;
        private readonly PropertyAccessor<string> mPackageAction;
        private readonly PropertyAccessor<string> mRebuildPackageAction;
        private readonly PropertyAccessor<string> mMtouchLink;
        private readonly PropertyAccessor<string> mCodesignEntitlements;
        private readonly PropertyAccessor<bool?> mMtouchDebug;
        private readonly PropertyAccessor<string> mMtouchI18n;
        private readonly PropertyAccessor<string> mMtouchArch;
        private readonly PropertyAccessor<bool?> mCodeAnalysisIgnoreBuiltInRuleSets;
        private readonly PropertyAccessor<bool?> mCodeAnalysisIgnoreBuiltInRules;
        private readonly PropertyAccessor<bool?> mRunCodeAnalysis;
        private readonly PropertyAccessor<bool?> mRunCodeAnalysisOnThisProject;
        private readonly PropertyAccessor<string> mCodeAnalysisRules;
        private readonly PropertyAccessor<bool?> m_DeploymentSignClickOnceManifests;
        private readonly PropertyAccessor<string> mPackageCertificateThumbprint;
        private readonly PropertyAccessor<bool?> mAppxAutoIncrementPackageRevision;
        private readonly PropertyAccessor<string> mTestPageFileName;
        private readonly PropertyAccessor<string> mProjectView;
        private readonly PropertyAccessor<bool?> mExternalconsole;
        private readonly PropertyAccessor<string> mNuGetFrameworkVersion;
        private readonly PropertyAccessor<string> mExcludeFromPackage;
        private readonly PropertyAccessor<string> mNameOfLastUsedPublishProfile;
        private readonly PropertyAccessor<bool?> mImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets;
        private readonly PropertyAccessor<bool?> m_CollectFiles_IncludeIgnorableFile;
        private readonly PropertyAccessor<bool?> mCollectFilesFromProjectFolder_ExcludeSccFiles;
        private readonly PropertyAccessor<string> mSetExcludeFromProjectFolderDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromProjectFolder_ExcludeSccFilesDependsOn;
        private readonly PropertyAccessor<string> mCollectFilesFromProjectFolderDependsOn;
        private readonly PropertyAccessor<bool?> mImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets;
        private readonly PropertyAccessor<bool?> mNoWin32Manifest;
        private readonly PropertyAccessor<string> mInBrowserSettingsFile;
        private readonly PropertyAccessor<bool?> mRequireInBrowserElevation;
        private readonly PropertyAccessor<string> mRoleType;
        private readonly PropertyAccessor<bool?> mPortableEnableXamlTargets;
        private readonly PropertyAccessor<bool?> mSynthesizeLinkMetadata;
        private readonly PropertyAccessor<bool?> mHasSharedItems;
        private readonly PropertyAccessor<string> mSharedGUID;
        private readonly PropertyAccessor<string> mImport_RootNamespace;
        private readonly PropertyAccessor<bool?> mDisableXbfGeneration;
        private readonly PropertyAccessor<string> mXamlSavedStateFileName;
        private readonly PropertyAccessor<string> mXamlSavedStateFilePath;
        private readonly PropertyAccessor<string> mXamlRootsLog;
        private readonly PropertyAccessor<string> mMarkupCompilePass1DependsOn;
        private readonly PropertyAccessor<string> mMarkupCompilePass2DependsOn;
        private readonly PropertyAccessor<string> mPrep_ComputeProcessXamlFilesDependsOn;
        private readonly PropertyAccessor<bool?> mSDKReferenceWarnOnMissingMaxPlatformVersion;
        private readonly PropertyAccessor<string> mStartArguments;
        private readonly PropertyAccessor<bool?> mEnableSQLServerDebugging;
        private readonly PropertyAccessor<bool?> mWPTestProject;
        private readonly PropertyAccessor<string> m_DeploymentApplicationUrl;
        private readonly PropertyAccessor<string> mStartAction;

        public TypedProject(Project project)
        {
            mProject = project;

            mReferences = new ItemCollection<Reference>(project);
            mCompiles = new ItemCollection<Compile>(project);
            mNones = new ItemCollection<None>(project);
            mProjectReferences = new ItemCollection<ProjectReference>(project);
            mContents = new ItemCollection<Content>(project);
            m_OutputPathItems = new ItemCollection<_OutputPathItem>(project);
            m_UnmanagedRegistrationCaches = new ItemCollection<_UnmanagedRegistrationCache>(project);
            m_ResolveComReferenceCaches = new ItemCollection<_ResolveComReferenceCache>(project);
            mAppConfigFileDestinations = new ItemCollection<AppConfigFileDestination>(project);
            mIntermediateAssemblies = new ItemCollection<IntermediateAssembly>(project);
            m_DebugSymbolsIntermediatePaths = new ItemCollection<_DebugSymbolsIntermediatePath>(project);
            m_DebugSymbolsOutputPaths = new ItemCollection<_DebugSymbolsOutputPath>(project);
            m_DeploymentManifestEntryPoints = new ItemCollection<_DeploymentManifestEntryPoint>(project);
            mApplicationManifests = new ItemCollection<ApplicationManifest>(project);
            m_ApplicationManifestFinals = new ItemCollection<_ApplicationManifestFinal>(project);
            mDeployManifests = new ItemCollection<DeployManifest>(project);
            mBuiltProjectOutputGroupKeyOutputs = new ItemCollection<BuiltProjectOutputGroupKeyOutput>(project);
            mDebugSymbolsProjectOutputGroupOutputs = new ItemCollection<DebugSymbolsProjectOutputGroupOutput>(project);
            mAvailableItemNames = new ItemCollection<AvailableItemName>(project);
            mCleans = new ItemCollection<Clean>(project);
            mXamlBuildTaskTypeGenerationExtensionNames = new ItemCollection<XamlBuildTaskTypeGenerationExtensionName>(project);
            m_ExplicitReferences = new ItemCollection<_ExplicitReference>(project);
            mWCFMetadatas = new ItemCollection<WCFMetadata>(project);
            mServiceReferenceMetadataStorages = new ItemCollection<ServiceReferenceMetadataStorage>(project);
            m_WPPSupportsCollection = new ItemCollection<_WPPSupports>(project);
            m_IISApplicationPools = new ItemCollection<_IISApplicationPool>(project);
            m_MSDeployPackageFiles = new ItemCollection<_MSDeployPackageFile>(project);
            m_MSDeployArchiveDirs = new ItemCollection<_MSDeployArchiveDir>(project);
            m_MSDeployPackageLocations = new ItemCollection<_MSDeployPackageLocation>(project);
            mWebPublishExtnsionsToExcludeItems = new ItemCollection<WebPublishExtnsionsToExcludeItem>(project);
            mFolders = new ItemCollection<Folder>(project);
            mEmbeddedResources = new ItemCollection<EmbeddedResource>(project);
            mServices = new ItemCollection<Service>(project);
            mFxCopRuleAssemblies = new ItemCollection<FxCopRuleAssemblies>(project);
            mApplicationDefinitions = new ItemCollection<ApplicationDefinition>(project);
            mTypeScriptCompiles = new ItemCollection<TypeScriptCompile>(project);
            mProjectCapabilities = new ItemCollection<ProjectCapability>(project);
            mBootstrapperPackages = new ItemCollection<BootstrapperPackage>(project);
            mDocFileItems = new ItemCollection<DocFileItem>(project);
            mFinalDocFiles = new ItemCollection<FinalDocFile>(project);
            mDocumentationProjectOutputGroupOutputs = new ItemCollection<DocumentationProjectOutputGroupOutput>(project);
            mPages = new ItemCollection<Page>(project);
            mResources = new ItemCollection<Resource>(project);
            m_IntermediateOutputPathItems = new ItemCollection<_IntermediateOutputPathItem>(project);
            mPackageSourcesCollection = new ItemCollection<PackageSource>(project);
            mAppDesigners = new ItemCollection<AppDesigner>(project);
            mAppxHashUris = new ItemCollection<AppxHashUri>(project);
            mAppxSystemBinaries = new ItemCollection<AppxSystemBinary>(project);
            mAppxReservedFileNames = new ItemCollection<AppxReservedFileName>(project);
            mAppxManifestFileNameQueries = new ItemCollection<AppxManifestFileNameQuery>(project);
            mAppxManifestImageFileNameQueries = new ItemCollection<AppxManifestImageFileNameQuery>(project);
            mAppxManifestMetadatas = new ItemCollection<AppxManifestMetadata>(project);
            mAppxManifestMetaDatas = new ItemCollection<AppxManifestMetaData>(project);
            mPlatformVersionDescriptions = new ItemCollection<PlatformVersionDescription>(project);
            mXamlIntermediateAssemblies = new ItemCollection<XamlIntermediateAssembly>(project);
            mSDKReferences = new ItemCollection<SDKReference>(project);
            mAppxManifests = new ItemCollection<AppxManifest>(project);
            mUpToDateCheckOutputs = new ItemCollection<UpToDateCheckOutput>(project);
            mBundleResources = new ItemCollection<BundleResource>(project);
            mEntityDeploys = new ItemCollection<EntityDeploy>(project);
            m_DeploymentManifestIconFiles = new ItemCollection<_DeploymentManifestIconFile>(project);
            mTargetPlatforms = new ItemCollection<TargetPlatform>(project);
            mPropertyPageSchemas = new ItemCollection<PropertyPageSchema>(project);
            mPackageFiles = new ItemCollection<PackageFiles>(project);
            mWCFMetadataStorages = new ItemCollection<WCFMetadataStorage>(project);
            mMSBuildToolsVersion = new PropertyAccessor<string>(project, "MSBuildToolsVersion");
            mMSBuildToolsPath = new PropertyAccessor<string>(project, "MSBuildToolsPath");
            mMSBuildBinPath = new PropertyAccessor<string>(project, "MSBuildBinPath");
            mMSBuildStartupDirectory = new PropertyAccessor<string>(project, "MSBuildStartupDirectory");
            mMSBuildNodeCount = new PropertyAccessor<int?>(project, "MSBuildNodeCount");
            mMSBuildProgramFiles32 = new PropertyAccessor<string>(project, "MSBuildProgramFiles32");
            mMSBuildProjectFile = new PropertyAccessor<string>(project, "MSBuildProjectFile");
            mMSBuildProjectName = new PropertyAccessor<string>(project, "MSBuildProjectName");
            mMSBuildProjectExtension = new PropertyAccessor<string>(project, "MSBuildProjectExtension");
            mMSBuildProjectFullPath = new PropertyAccessor<string>(project, "MSBuildProjectFullPath");
            mMSBuildProjectDirectory = new PropertyAccessor<string>(project, "MSBuildProjectDirectory");
            mMSBuildProjectDirectoryNoRoot = new PropertyAccessor<string>(project, "MSBuildProjectDirectoryNoRoot");
            mMSBuildExtensionsPath32 = new PropertyAccessor<string>(project, "MSBuildExtensionsPath32");
            mMSBuildExtensionsPath64 = new PropertyAccessor<string>(project, "MSBuildExtensionsPath64");
            mMSBuildExtensionsPath = new PropertyAccessor<string>(project, "MSBuildExtensionsPath");
            mLOCALAPPDATA = new PropertyAccessor<string>(project, "LOCALAPPDATA");
            mMSBuildUserExtensionsPath = new PropertyAccessor<string>(project, "MSBuildUserExtensionsPath");
            mALLUSERSPROFILE = new PropertyAccessor<string>(project, "ALLUSERSPROFILE");
            mAPPDATA = new PropertyAccessor<string>(project, "APPDATA");
            mCommonProgramFiles = new PropertyAccessor<string>(project, "CommonProgramFiles");
            mCommonProgramW6432 = new PropertyAccessor<string>(project, "CommonProgramW6432");
            mCOMPUTERNAME = new PropertyAccessor<string>(project, "COMPUTERNAME");
            mComSpec = new PropertyAccessor<string>(project, "ComSpec");
            mconfigsetroot = new PropertyAccessor<string>(project, "configsetroot");
            mFP_NO_HOST_CHECK = new PropertyAccessor<string>(project, "FP_NO_HOST_CHECK");
            mHOMEDRIVE = new PropertyAccessor<string>(project, "HOMEDRIVE");
            mHOMEPATH = new PropertyAccessor<string>(project, "HOMEPATH");
            mJAVA_HOME = new PropertyAccessor<string>(project, "JAVA_HOME");
            mLOGONSERVER = new PropertyAccessor<string>(project, "LOGONSERVER");
            mMSBuildLoadMicrosoftTargetsReadOnly = new PropertyAccessor<bool?>(project, "MSBuildLoadMicrosoftTargetsReadOnly");
            mNUMBER_OF_PROCESSORS = new PropertyAccessor<int?>(project, "NUMBER_OF_PROCESSORS");
            mOS = new PropertyAccessor<string>(project, "OS");
            mPath = new PropertyAccessor<string>(project, "Path");
            mPATHEXT = new PropertyAccessor<string>(project, "PATHEXT");
            mPkgDefApplicationConfigFile = new PropertyAccessor<string>(project, "PkgDefApplicationConfigFile");
            mPROCESSOR_ARCHITECTURE = new PropertyAccessor<string>(project, "PROCESSOR_ARCHITECTURE");
            mPROCESSOR_ARCHITEW6432 = new PropertyAccessor<string>(project, "PROCESSOR_ARCHITEW6432");
            mPROCESSOR_IDENTIFIER = new PropertyAccessor<string>(project, "PROCESSOR_IDENTIFIER");
            mPROCESSOR_LEVEL = new PropertyAccessor<int?>(project, "PROCESSOR_LEVEL");
            mPROCESSOR_REVISION = new PropertyAccessor<int?>(project, "PROCESSOR_REVISION");
            mProgramData = new PropertyAccessor<string>(project, "ProgramData");
            mProgramFiles = new PropertyAccessor<string>(project, "ProgramFiles");
            mProgramW6432 = new PropertyAccessor<string>(project, "ProgramW6432");
            mPSModulePath = new PropertyAccessor<string>(project, "PSModulePath");
            mPUBLIC = new PropertyAccessor<string>(project, "PUBLIC");
            mSystemDrive = new PropertyAccessor<string>(project, "SystemDrive");
            mSystemRoot = new PropertyAccessor<string>(project, "SystemRoot");
            mTEMP = new PropertyAccessor<string>(project, "TEMP");
            mTMP = new PropertyAccessor<string>(project, "TMP");
            mUOIPME_REG_PATH = new PropertyAccessor<string>(project, "UOIPME_REG_PATH");
            mUSERDOMAIN = new PropertyAccessor<string>(project, "USERDOMAIN");
            mUSERDOMAIN_ROAMINGPROFILE = new PropertyAccessor<string>(project, "USERDOMAIN_ROAMINGPROFILE");
            mUSERNAME = new PropertyAccessor<string>(project, "USERNAME");
            mUSERPROFILE = new PropertyAccessor<string>(project, "USERPROFILE");
            mVisualStudioDir = new PropertyAccessor<string>(project, "VisualStudioDir");
            mVisualStudioEdition = new PropertyAccessor<string>(project, "VisualStudioEdition");
            mVisualStudioVersion = new PropertyAccessor<string>(project, "VisualStudioVersion");
            mVS110COMNTOOLS = new PropertyAccessor<string>(project, "VS110COMNTOOLS");
            mVS120COMNTOOLS = new PropertyAccessor<string>(project, "VS120COMNTOOLS");
            mVS140COMNTOOLS = new PropertyAccessor<string>(project, "VS140COMNTOOLS");
            mVSLANG = new PropertyAccessor<int?>(project, "VSLANG");
            mwindir = new PropertyAccessor<string>(project, "windir");
            mSDK35ToolsPath = new PropertyAccessor<string>(project, "SDK35ToolsPath");
            mMSBuildToolsPath32 = new PropertyAccessor<string>(project, "MSBuildToolsPath32");
            mMSBuildToolsRoot = new PropertyAccessor<string>(project, "MSBuildToolsRoot");
            mFrameworkSDKRoot = new PropertyAccessor<string>(project, "FrameworkSDKRoot");
            mMSBuildRuntimeVersion = new PropertyAccessor<string>(project, "MSBuildRuntimeVersion");
            mSDK40ToolsPath = new PropertyAccessor<string>(project, "SDK40ToolsPath");
            mConfiguration = new PropertyAccessor<string>(project, "Configuration");
            mMSBuildProjectDefaultTargets = new PropertyAccessor<string>(project, "MSBuildProjectDefaultTargets");
            mPlatform = new PropertyAccessor<string>(project, "Platform");
            mProjectGuid = new PropertyAccessor<string>(project, "ProjectGuid");
            mOutputType = new PropertyAccessor<string>(project, "OutputType");
            mAppDesignerFolder = new PropertyAccessor<string>(project, "AppDesignerFolder");
            mRootNamespace = new PropertyAccessor<string>(project, "RootNamespace");
            mAssemblyName = new PropertyAccessor<string>(project, "AssemblyName");
            mTargetFrameworkVersion = new PropertyAccessor<string>(project, "TargetFrameworkVersion");
            mFileAlignment = new PropertyAccessor<int?>(project, "FileAlignment");
            mSolutionDir = new PropertyAccessor<string>(project, "SolutionDir");
            mRestorePackages = new PropertyAccessor<bool?>(project, "RestorePackages");
            mPlatformTarget = new PropertyAccessor<string>(project, "PlatformTarget");
            mDebugSymbols = new PropertyAccessor<bool?>(project, "DebugSymbols");
            mDebugType = new PropertyAccessor<string>(project, "DebugType");
            mOptimize = new PropertyAccessor<bool?>(project, "Optimize");
            mOutputPath = new PropertyAccessor<string>(project, "OutputPath");
            mDefineConstants = new PropertyAccessor<string>(project, "DefineConstants");
            mErrorReport = new PropertyAccessor<string>(project, "ErrorReport");
            mWarningLevel = new PropertyAccessor<int?>(project, "WarningLevel");
            mImportByWildcardBeforeMicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftCSharpTargets");
            mImportByWildcardAfterMicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftCSharpTargets");
            mImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets");
            mImportUserLocationsByWildcardAfterMicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets");
            mCustomBeforeMicrosoftCSharpTargets = new PropertyAccessor<string>(project, "CustomBeforeMicrosoftCSharpTargets");
            mCustomAfterMicrosoftCSharpTargets = new PropertyAccessor<string>(project, "CustomAfterMicrosoftCSharpTargets");
            mMSBuildAllProjects = new PropertyAccessor<string>(project, "MSBuildAllProjects");
            mDefaultLanguageSourceExtension = new PropertyAccessor<string>(project, "DefaultLanguageSourceExtension");
            mLanguage = new PropertyAccessor<string>(project, "Language");
            mTargetRuntime = new PropertyAccessor<string>(project, "TargetRuntime");
            mCreateManifestResourceNamesDependsOn = new PropertyAccessor<string>(project, "CreateManifestResourceNamesDependsOn");
            mUseHostCompilerIfAvailable = new PropertyAccessor<bool?>(project, "UseHostCompilerIfAvailable");
            mCoreCompileDependsOn = new PropertyAccessor<string>(project, "CoreCompileDependsOn");
            mImportByWildcardBeforeMicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftCommonTargets");
            mImportByWildcardAfterMicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftCommonTargets");
            mImportUserLocationsByWildcardBeforeMicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets");
            mImportUserLocationsByWildcardAfterMicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfterMicrosoftCommonTargets");
            mCustomBeforeMicrosoftCommonTargets = new PropertyAccessor<string>(project, "CustomBeforeMicrosoftCommonTargets");
            mCustomAfterMicrosoftCommonTargets = new PropertyAccessor<string>(project, "CustomAfterMicrosoftCommonTargets");
            mReportingServicesTargets = new PropertyAccessor<string>(project, "ReportingServicesTargets");
            mTargetFrameworkIdentifier = new PropertyAccessor<string>(project, "TargetFrameworkIdentifier");
            mAvailablePlatforms = new PropertyAccessor<string>(project, "AvailablePlatforms");
            mImportByWildcardBeforeMicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftNetFrameworkProps");
            mImportByWildcardAfterMicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftNetFrameworkProps");
            mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps");
            mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps");
            mUpgradeSubsetToProfile = new PropertyAccessor<bool?>(project, "UpgradeSubsetToProfile");
            mAddAdditionalExplicitAssemblyReferences = new PropertyAccessor<bool?>(project, "AddAdditionalExplicitAssemblyReferences");
            mAdditionalExplicitAssemblyReferences = new PropertyAccessor<string>(project, "AdditionalExplicitAssemblyReferences");
            mTargetFrameworkSDKToolsDirectory = new PropertyAccessor<string>(project, "TargetFrameworkSDKToolsDirectory");
            mTargetedRuntimeVersion = new PropertyAccessor<string>(project, "TargetedRuntimeVersion");
            mPrefer32Bit = new PropertyAccessor<bool?>(project, "Prefer32Bit");
            mHighEntropyVA = new PropertyAccessor<bool?>(project, "HighEntropyVA");
            mSubsystemVersion = new PropertyAccessor<string>(project, "SubsystemVersion");
            mImplicitlyExpandDesignTimeFacades = new PropertyAccessor<bool?>(project, "ImplicitlyExpandDesignTimeFacades");
            mYieldDuringToolExecution = new PropertyAccessor<bool?>(project, "YieldDuringToolExecution");
            mTargetFrameworkMoniker = new PropertyAccessor<string>(project, "TargetFrameworkMoniker");
            mFrameworkPathOverride = new PropertyAccessor<string>(project, "FrameworkPathOverride");
            mTargetPlatformIdentifier = new PropertyAccessor<string>(project, "TargetPlatformIdentifier");
            mTargetPlatformVersion = new PropertyAccessor<string>(project, "TargetPlatformVersion");
            mTargetPlatformSdkPath = new PropertyAccessor<string>(project, "TargetPlatformSdkPath");
            mTargetPlatformMoniker = new PropertyAccessor<string>(project, "TargetPlatformMoniker");
            m_OriginalConfiguration = new PropertyAccessor<string>(project, "_OriginalConfiguration");
            m_OriginalPlatform = new PropertyAccessor<string>(project, "_OriginalPlatform");
            mConfigurationName = new PropertyAccessor<string>(project, "ConfigurationName");
            m_DebugSymbolsProduced = new PropertyAccessor<bool?>(project, "_DebugSymbolsProduced");
            m_DocumentationFileProduced = new PropertyAccessor<bool?>(project, "_DocumentationFileProduced");
            mTargetExt = new PropertyAccessor<string>(project, "TargetExt");
            mOutDir = new PropertyAccessor<string>(project, "OutDir");
            mProjectName = new PropertyAccessor<string>(project, "ProjectName");
            mTargetName = new PropertyAccessor<string>(project, "TargetName");
            mProjectFileName = new PropertyAccessor<string>(project, "ProjectFileName");
            mProjectExt = new PropertyAccessor<string>(project, "ProjectExt");
            mTargetFileName = new PropertyAccessor<string>(project, "TargetFileName");
            m_DeploymentPublishableProjectDefault = new PropertyAccessor<bool?>(project, "_DeploymentPublishableProjectDefault");
            mPublishableProject = new PropertyAccessor<string>(project, "PublishableProject");
            m_DeploymentTargetApplicationManifestFileName = new PropertyAccessor<string>(project, "_DeploymentTargetApplicationManifestFileName");
            mTargetDeployManifestFileName = new PropertyAccessor<string>(project, "TargetDeployManifestFileName");
            mGenerateClickOnceManifests = new PropertyAccessor<string>(project, "GenerateClickOnceManifests");
            m_DeploymentApplicationManifestIdentity = new PropertyAccessor<string>(project, "_DeploymentApplicationManifestIdentity");
            m_DeploymentDeployManifestIdentity = new PropertyAccessor<string>(project, "_DeploymentDeployManifestIdentity");
            m_DeploymentFileMappingExtension = new PropertyAccessor<string>(project, "_DeploymentFileMappingExtension");
            m_DeploymentBuiltUpdateInterval = new PropertyAccessor<int?>(project, "_DeploymentBuiltUpdateInterval");
            m_DeploymentBuiltUpdateIntervalUnits = new PropertyAccessor<string>(project, "_DeploymentBuiltUpdateIntervalUnits");
            mMaxTargetPath = new PropertyAccessor<int?>(project, "MaxTargetPath");
            mTargetCulture = new PropertyAccessor<string>(project, "TargetCulture");
            mTargetDir = new PropertyAccessor<string>(project, "TargetDir");
            mTargetPath = new PropertyAccessor<string>(project, "TargetPath");
            mProjectDir = new PropertyAccessor<string>(project, "ProjectDir");
            mProjectPath = new PropertyAccessor<string>(project, "ProjectPath");
            mPlatformName = new PropertyAccessor<string>(project, "PlatformName");
            mDevEnvDir = new PropertyAccessor<string>(project, "DevEnvDir");
            mSolutionName = new PropertyAccessor<string>(project, "SolutionName");
            mSolutionFileName = new PropertyAccessor<string>(project, "SolutionFileName");
            mSolutionPath = new PropertyAccessor<string>(project, "SolutionPath");
            mSolutionExt = new PropertyAccessor<string>(project, "SolutionExt");
            mAutoUnifyAssemblyReferences = new PropertyAccessor<bool?>(project, "AutoUnifyAssemblyReferences");
            mBaseIntermediateOutputPath = new PropertyAccessor<string>(project, "BaseIntermediateOutputPath");
            mCleanFile = new PropertyAccessor<string>(project, "CleanFile");
            mBuildProjectReferences = new PropertyAccessor<bool?>(project, "BuildProjectReferences");
            mBuildInParallel = new PropertyAccessor<bool?>(project, "BuildInParallel");
            m_ResolveReferenceDependencies = new PropertyAccessor<bool?>(project, "_ResolveReferenceDependencies");
            m_GetChildProjectCopyToOutputDirectoryItems = new PropertyAccessor<bool?>(project, "_GetChildProjectCopyToOutputDirectoryItems");
            mOverwriteReadOnlyFiles = new PropertyAccessor<bool?>(project, "OverwriteReadOnlyFiles");
            mComReferenceNoClassMembers = new PropertyAccessor<bool?>(project, "ComReferenceNoClassMembers");
            mIntermediateOutputPath = new PropertyAccessor<string>(project, "IntermediateOutputPath");
            m_DeploymentUrl = new PropertyAccessor<string>(project, "_DeploymentUrl");
            mPublishDir = new PropertyAccessor<string>(project, "PublishDir");
            mProcessorArchitecture = new PropertyAccessor<string>(project, "ProcessorArchitecture");
            mConsiderPlatformAsProcessorArchitecture = new PropertyAccessor<bool?>(project, "ConsiderPlatformAsProcessorArchitecture");
            mTargetFrameworkAsMSBuildRuntime = new PropertyAccessor<string>(project, "TargetFrameworkAsMSBuildRuntime");
            mPlatformTargetAsMSBuildArchitectureExplicitlySet = new PropertyAccessor<bool?>(project, "PlatformTargetAsMSBuildArchitectureExplicitlySet");
            mPlatformTargetAsMSBuildArchitecture = new PropertyAccessor<string>(project, "PlatformTargetAsMSBuildArchitecture");
            mProjectFlavor = new PropertyAccessor<string>(project, "ProjectFlavor");
            mDelaySign = new PropertyAccessor<string>(project, "DelaySign");
            mWebReference_EnableProperties = new PropertyAccessor<bool?>(project, "WebReference_EnableProperties");
            mWebReference_EnableSQLTypes = new PropertyAccessor<bool?>(project, "WebReference_EnableSQLTypes");
            mWebReference_EnableLegacyEventingModel = new PropertyAccessor<bool?>(project, "WebReference_EnableLegacyEventingModel");
            mAssemblyFoldersSuffix = new PropertyAccessor<string>(project, "AssemblyFoldersSuffix");
            mFrameworkRegistryBase = new PropertyAccessor<string>(project, "FrameworkRegistryBase");
            mTargetPlatformRegistryBase = new PropertyAccessor<string>(project, "TargetPlatformRegistryBase");
            mAssemblySearchPaths = new PropertyAccessor<string>(project, "AssemblySearchPaths");
            mAllowedReferenceAssemblyFileExtensions = new PropertyAccessor<string>(project, "AllowedReferenceAssemblyFileExtensions");
            mAllowedReferenceRelatedFileExtensions = new PropertyAccessor<string>(project, "AllowedReferenceRelatedFileExtensions");
            mFullReferenceAssemblyNames = new PropertyAccessor<string>(project, "FullReferenceAssemblyNames");
            mContinueOnError = new PropertyAccessor<bool?>(project, "ContinueOnError");
            mBuildDependsOn = new PropertyAccessor<string>(project, "BuildDependsOn");
            mCoreBuildDependsOn = new PropertyAccessor<string>(project, "CoreBuildDependsOn");
            m_ProjectDefaultTargets = new PropertyAccessor<string>(project, "_ProjectDefaultTargets");
            mRebuildDependsOn = new PropertyAccessor<string>(project, "RebuildDependsOn");
            mBuildGenerateSourcesAction = new PropertyAccessor<string>(project, "BuildGenerateSourcesAction");
            mBuildCompileAction = new PropertyAccessor<string>(project, "BuildCompileAction");
            mBuildLinkAction = new PropertyAccessor<string>(project, "BuildLinkAction");
            mRunDependsOn = new PropertyAccessor<string>(project, "RunDependsOn");
            mBuildingProject = new PropertyAccessor<bool?>(project, "BuildingProject");
            mPrepareForBuildDependsOn = new PropertyAccessor<string>(project, "PrepareForBuildDependsOn");
            mFramework40Dir = new PropertyAccessor<string>(project, "Framework40Dir");
            mFramework35Dir = new PropertyAccessor<string>(project, "Framework35Dir");
            mFramework30Dir = new PropertyAccessor<string>(project, "Framework30Dir");
            mFramework20Dir = new PropertyAccessor<string>(project, "Framework20Dir");
            mFrameworkDir = new PropertyAccessor<string>(project, "FrameworkDir");
            mTargetedFrameworkDir = new PropertyAccessor<string>(project, "TargetedFrameworkDir");
            mFrameworkSDKDir = new PropertyAccessor<string>(project, "FrameworkSDKDir");
            mGetFrameworkPathsDependsOn = new PropertyAccessor<string>(project, "GetFrameworkPathsDependsOn");
            mPreBuildEventDependsOn = new PropertyAccessor<string>(project, "PreBuildEventDependsOn");
            mUnmanagedUnregistrationDependsOn = new PropertyAccessor<string>(project, "UnmanagedUnregistrationDependsOn");
            mResolveReferencesDependsOn = new PropertyAccessor<string>(project, "ResolveReferencesDependsOn");
            mGetTargetPathDependsOn = new PropertyAccessor<string>(project, "GetTargetPathDependsOn");
            mResolveAssemblyReferencesDependsOn = new PropertyAccessor<string>(project, "ResolveAssemblyReferencesDependsOn");
            mSDKReferenceRegistryRoot = new PropertyAccessor<string>(project, "SDKReferenceRegistryRoot");
            mSDKReferenceDirectoryRoot = new PropertyAccessor<string>(project, "SDKReferenceDirectoryRoot");
            mResolveSDKReferencesDependsOn = new PropertyAccessor<string>(project, "ResolveSDKReferencesDependsOn");
            mTargetedSDKConfiguration = new PropertyAccessor<string>(project, "TargetedSDKConfiguration");
            mTargetedSDKArchitecture = new PropertyAccessor<string>(project, "TargetedSDKArchitecture");
            mExpandSDKReferencesDependsOn = new PropertyAccessor<string>(project, "ExpandSDKReferencesDependsOn");
            mExpandSDKAllowedReferenceExtensions = new PropertyAccessor<string>(project, "ExpandSDKAllowedReferenceExtensions");
            mProjectDesignTimeAssemblyResolutionSearchPaths = new PropertyAccessor<string>(project, "ProjectDesignTimeAssemblyResolutionSearchPaths");
            mDesignTimeResolveAssemblyReferencesDependsOn = new PropertyAccessor<string>(project, "DesignTimeResolveAssemblyReferencesDependsOn");
            mComReferenceExecuteAsTool = new PropertyAccessor<bool?>(project, "ComReferenceExecuteAsTool");
            mPrepareResourcesDependsOn = new PropertyAccessor<string>(project, "PrepareResourcesDependsOn");
            mPrepareResourceNamesDependsOn = new PropertyAccessor<string>(project, "PrepareResourceNamesDependsOn");
            mAssignTargetPathsDependsOn = new PropertyAccessor<string>(project, "AssignTargetPathsDependsOn");
            mCreateCustomManifestResourceNamesDependsOn = new PropertyAccessor<string>(project, "CreateCustomManifestResourceNamesDependsOn");
            mResGenDependsOn = new PropertyAccessor<string>(project, "ResGenDependsOn");
            mCoreResGenDependsOn = new PropertyAccessor<string>(project, "CoreResGenDependsOn");
            mUseSourcePath = new PropertyAccessor<bool?>(project, "UseSourcePath");
            mResGenExecuteAsTool = new PropertyAccessor<bool?>(project, "ResGenExecuteAsTool");
            mCompileLicxFilesDependsOn = new PropertyAccessor<string>(project, "CompileLicxFilesDependsOn");
            mCompileDependsOn = new PropertyAccessor<string>(project, "CompileDependsOn");
            mTargetFrameworkMonikerAssemblyAttributesPath = new PropertyAccessor<string>(project, "TargetFrameworkMonikerAssemblyAttributesPath");
            mGenerateTargetFrameworkAttribute = new PropertyAccessor<bool?>(project, "GenerateTargetFrameworkAttribute");
            m_SGenDllName = new PropertyAccessor<string>(project, "_SGenDllName");
            m_SGenDllCreated = new PropertyAccessor<bool?>(project, "_SGenDllCreated");
            m_SGenGenerateSerializationAssembliesConfig = new PropertyAccessor<string>(project, "_SGenGenerateSerializationAssembliesConfig");
            mSGenUseProxyTypes = new PropertyAccessor<bool?>(project, "SGenUseProxyTypes");
            mSGenShouldGenerateSerializer = new PropertyAccessor<bool?>(project, "SGenShouldGenerateSerializer");
            mCreateSatelliteAssembliesDependsOn = new PropertyAccessor<string>(project, "CreateSatelliteAssembliesDependsOn");
            mComputeIntermediateSatelliteAssembliesDependsOn = new PropertyAccessor<string>(project, "ComputeIntermediateSatelliteAssembliesDependsOn");
            mEmbeddedWin32Manifest = new PropertyAccessor<string>(project, "EmbeddedWin32Manifest");
            mGenerateManifestsDependsOn = new PropertyAccessor<string>(project, "GenerateManifestsDependsOn");
            mSkipCopyUnchangedFiles = new PropertyAccessor<bool?>(project, "SkipCopyUnchangedFiles");
            mUseCommonOutputDirectory = new PropertyAccessor<bool?>(project, "UseCommonOutputDirectory");
            mPrepareForRunDependsOn = new PropertyAccessor<string>(project, "PrepareForRunDependsOn");
            mCreateHardLinksForCopyAdditionalFilesIfPossible = new PropertyAccessor<bool?>(project, "CreateHardLinksForCopyAdditionalFilesIfPossible");
            mGetCopyToOutputDirectoryItemsDependsOn = new PropertyAccessor<string>(project, "GetCopyToOutputDirectoryItemsDependsOn");
            mUnmanagedRegistrationDependsOn = new PropertyAccessor<string>(project, "UnmanagedRegistrationDependsOn");
            mCleanDependsOn = new PropertyAccessor<string>(project, "CleanDependsOn");
            mCoreCleanDependsOn = new PropertyAccessor<string>(project, "CoreCleanDependsOn");
            mPostBuildEventDependsOn = new PropertyAccessor<string>(project, "PostBuildEventDependsOn");
            mPublishDependsOn = new PropertyAccessor<string>(project, "PublishDependsOn");
            mPublishOnlyDependsOn = new PropertyAccessor<string>(project, "PublishOnlyDependsOn");
            mPublishBuildDependsOn = new PropertyAccessor<string>(project, "PublishBuildDependsOn");
            mBuiltProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "BuiltProjectOutputGroupDependsOn");
            mAddAppConfigToBuildOutputs = new PropertyAccessor<bool?>(project, "AddAppConfigToBuildOutputs");
            mDebugSymbolsProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "DebugSymbolsProjectOutputGroupDependsOn");
            mDocumentationProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "DocumentationProjectOutputGroupDependsOn");
            mSatelliteDllsProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "SatelliteDllsProjectOutputGroupDependsOn");
            mSourceFilesProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "SourceFilesProjectOutputGroupDependsOn");
            mContentFilesProjectOutputGroupDependsOn = new PropertyAccessor<string>(project, "ContentFilesProjectOutputGroupDependsOn");
            mSGenFilesOutputGroupDependsOn = new PropertyAccessor<string>(project, "SGenFilesOutputGroupDependsOn");
            mSDKRedistOutputGroupDependsOn = new PropertyAccessor<string>(project, "SDKRedistOutputGroupDependsOn");
            mCodeAnalysisTargets = new PropertyAccessor<string>(project, "CodeAnalysisTargets");
            mCodeAnalysisStaticAnalysisDirectory = new PropertyAccessor<string>(project, "CodeAnalysisStaticAnalysisDirectory");
            mCodeAnalysisRuleSetDirectories = new PropertyAccessor<string>(project, "CodeAnalysisRuleSetDirectories");
            mCodeAnalysisPath = new PropertyAccessor<string>(project, "CodeAnalysisPath");
            mCodeAnalysisApplyLogFileXsl = new PropertyAccessor<bool?>(project, "CodeAnalysisApplyLogFileXsl");
            mCodeAnalysisFailOnMissingRules = new PropertyAccessor<bool?>(project, "CodeAnalysisFailOnMissingRules");
            mCodeAnalysisForceOutput = new PropertyAccessor<bool?>(project, "CodeAnalysisForceOutput");
            mCodeAnalysisGenerateSuccessFile = new PropertyAccessor<bool?>(project, "CodeAnalysisGenerateSuccessFile");
            mCodeAnalysisIgnoreGeneratedCode = new PropertyAccessor<bool?>(project, "CodeAnalysisIgnoreGeneratedCode");
            mCodeAnalysisIgnoreInvalidTargets = new PropertyAccessor<bool?>(project, "CodeAnalysisIgnoreInvalidTargets");
            mCodeAnalysisIgnoreMissingIndirectReferences = new PropertyAccessor<bool?>(project, "CodeAnalysisIgnoreMissingIndirectReferences");
            mCodeAnalysisInputAssembly = new PropertyAccessor<string>(project, "CodeAnalysisInputAssembly");
            mCodeAnalysisLogFile = new PropertyAccessor<string>(project, "CodeAnalysisLogFile");
            mCodeAnalysisModuleSuppressionsFile = new PropertyAccessor<string>(project, "CodeAnalysisModuleSuppressionsFile");
            mCodeAnalysisOverrideRuleVisibilities = new PropertyAccessor<bool?>(project, "CodeAnalysisOverrideRuleVisibilities");
            mCodeAnalysisOutputToConsole = new PropertyAccessor<bool?>(project, "CodeAnalysisOutputToConsole");
            mCodeAnalysisQuiet = new PropertyAccessor<bool?>(project, "CodeAnalysisQuiet");
            mCodeAnalysisRuleDirectories = new PropertyAccessor<string>(project, "CodeAnalysisRuleDirectories");
            mCodeAnalysisSaveMessagesToReport = new PropertyAccessor<string>(project, "CodeAnalysisSaveMessagesToReport");
            mCodeAnalysisSearchGlobalAssemblyCache = new PropertyAccessor<bool?>(project, "CodeAnalysisSearchGlobalAssemblyCache");
            mCodeAnalysisSucceededFile = new PropertyAccessor<string>(project, "CodeAnalysisSucceededFile");
            mCodeAnalysisSummary = new PropertyAccessor<bool?>(project, "CodeAnalysisSummary");
            mCodeAnalysisTimeout = new PropertyAccessor<int?>(project, "CodeAnalysisTimeout");
            mCodeAnalysisTreatWarningsAsErrors = new PropertyAccessor<bool?>(project, "CodeAnalysisTreatWarningsAsErrors");
            mCodeAnalysisUpdateProject = new PropertyAccessor<bool?>(project, "CodeAnalysisUpdateProject");
            mCodeAnalysisUseTypeNameInSuppression = new PropertyAccessor<bool?>(project, "CodeAnalysisUseTypeNameInSuppression");
            mCodeAnalysisVerbose = new PropertyAccessor<bool?>(project, "CodeAnalysisVerbose");
            mCodeAnalysisRuleSet = new PropertyAccessor<string>(project, "CodeAnalysisRuleSet");
            mRunCodeAnalysisDependsOn = new PropertyAccessor<string>(project, "RunCodeAnalysisDependsOn");
            mRunCodeAnalysisInputs = new PropertyAccessor<string>(project, "RunCodeAnalysisInputs");
            mRunNativeCodeAnalysisInputs = new PropertyAccessor<string>(project, "RunNativeCodeAnalysisInputs");
            mMergedOutputCodeAnalysisFile = new PropertyAccessor<string>(project, "MergedOutputCodeAnalysisFile");
            mCompileRdlFilesDependsOn = new PropertyAccessor<string>(project, "CompileRdlFilesDependsOn");
            mImportByWildcardBeforeMicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftNetFrameworkTargets");
            mImportByWildcardAfterMicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftNetFrameworkTargets");
            mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets");
            mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets");
            mImplicitlyExpandDesignTimeFacadesDependsOn = new PropertyAccessor<string>(project, "ImplicitlyExpandDesignTimeFacadesDependsOn");
            mBuildSystem = new PropertyAccessor<string>(project, "BuildSystem");
            mTaskVersion = new PropertyAccessor<string>(project, "TaskVersion");
            mTaskKeyToken = new PropertyAccessor<string>(project, "TaskKeyToken");
            mBuildTaskAssembly = new PropertyAccessor<string>(project, "BuildTaskAssembly");
            mAlwaysCompileMarkupFilesInSeparateDomain = new PropertyAccessor<bool?>(project, "AlwaysCompileMarkupFilesInSeparateDomain");
            mLocalizationDirectivesToLocFile = new PropertyAccessor<string>(project, "LocalizationDirectivesToLocFile");
            mGetReferenceAssemblyPathsDependsOn = new PropertyAccessor<string>(project, "GetReferenceAssemblyPathsDependsOn");
            mXamlDebuggingInformation = new PropertyAccessor<bool?>(project, "XamlDebuggingInformation");
            mHostInBrowser = new PropertyAccessor<bool?>(project, "HostInBrowser");
            mVersion = new PropertyAccessor<string>(project, "Version");
            mDeploymentType = new PropertyAccessor<string>(project, "DeploymentType");
            mRunAfterInstall = new PropertyAccessor<bool?>(project, "RunAfterInstall");
            mGeneratedFileExtension = new PropertyAccessor<string>(project, "GeneratedFileExtension");
            mOSVersion = new PropertyAccessor<string>(project, "OSVersion");
            m_RequireMCPass2ForSatelliteAssemblyOnly = new PropertyAccessor<bool?>(project, "_RequireMCPass2ForSatelliteAssemblyOnly");
            m_RequireMCPass2ForMainAssembly = new PropertyAccessor<bool?>(project, "_RequireMCPass2ForMainAssembly");
            mIsApplication = new PropertyAccessor<bool?>(project, "IsApplication");
            m_AfterCompileWinFXInternalDependsOn = new PropertyAccessor<string>(project, "_AfterCompileWinFXInternalDependsOn");
            mMarkupCompilePass2ForMainAssemblyDependsOn = new PropertyAccessor<string>(project, "MarkupCompilePass2ForMainAssemblyDependsOn");
            m_CompileTargetNameForLocalType = new PropertyAccessor<string>(project, "_CompileTargetNameForLocalType");
            m_ResourceNameInMainAssembly = new PropertyAccessor<string>(project, "_ResourceNameInMainAssembly");
            mEntityDeployIntermediateResourcePath = new PropertyAccessor<string>(project, "EntityDeployIntermediateResourcePath");
            mEntityDeployDependsOn = new PropertyAccessor<string>(project, "EntityDeployDependsOn");
            mLoadTimeSensitiveTargets = new PropertyAccessor<string>(project, "LoadTimeSensitiveTargets");
            mLoadTimeSensitiveProperties = new PropertyAccessor<string>(project, "LoadTimeSensitiveProperties");
            mXamlBuildTaskAssemblyName = new PropertyAccessor<string>(project, "XamlBuildTaskAssemblyName");
            mXamlRequiresCompilationPass2 = new PropertyAccessor<bool?>(project, "XamlRequiresCompilationPass2");
            mXamlTemporaryAssemblyName = new PropertyAccessor<string>(project, "XamlTemporaryAssemblyName");
            mCompileTargetNameForTemporaryAssembly = new PropertyAccessor<string>(project, "CompileTargetNameForTemporaryAssembly");
            mXamlBuildTaskLocation = new PropertyAccessor<string>(project, "XamlBuildTaskLocation");
            mXamlGenCodeFileNames = new PropertyAccessor<string>(project, "XamlGenCodeFileNames");
            mXamlGenMarkupFileNames = new PropertyAccessor<string>(project, "XamlGenMarkupFileNames");
            mXamlPass2FlagFile = new PropertyAccessor<string>(project, "XamlPass2FlagFile");
            mDesignTimeIntermediateOutputPath = new PropertyAccessor<string>(project, "DesignTimeIntermediateOutputPath");
            mWorkflowBuildExtensionVersion = new PropertyAccessor<string>(project, "WorkflowBuildExtensionVersion");
            mWorkflowBuildExtensionKeyToken = new PropertyAccessor<string>(project, "WorkflowBuildExtensionKeyToken");
            mWorkflowBuildExtensionAssemblyName = new PropertyAccessor<string>(project, "WorkflowBuildExtensionAssemblyName");
            mGenerateCompiledExpressionsTempFilePathForEditing = new PropertyAccessor<string>(project, "GenerateCompiledExpressionsTempFilePathForEditing");
            mGenerateCompiledExpressionsTempFilePathForValidation = new PropertyAccessor<string>(project, "GenerateCompiledExpressionsTempFilePathForValidation");
            mGenerateCompiledExpressionsTempFilePathForTypeInfer = new PropertyAccessor<string>(project, "GenerateCompiledExpressionsTempFilePathForTypeInfer");
            mDeferredValidationErrorsFileName = new PropertyAccessor<string>(project, "DeferredValidationErrorsFileName");
            mMsTestToolsTargets = new PropertyAccessor<string>(project, "MsTestToolsTargets");
            mMsAppxPackageTargets = new PropertyAccessor<string>(project, "MsAppxPackageTargets");
            mUtf8Output = new PropertyAccessor<bool?>(project, "Utf8Output");
            mNoCompilerStandardLib = new PropertyAccessor<bool?>(project, "NoCompilerStandardLib");
            mBuildPackage = new PropertyAccessor<bool?>(project, "BuildPackage");
            mRequireRestoreConsent = new PropertyAccessor<bool?>(project, "RequireRestoreConsent");
            mDownloadNuGetExe = new PropertyAccessor<bool?>(project, "DownloadNuGetExe");
            mNuGetToolsPath = new PropertyAccessor<string>(project, "NuGetToolsPath");
            mPackagesConfig = new PropertyAccessor<string>(project, "PackagesConfig");
            mNuGetExePath = new PropertyAccessor<string>(project, "NuGetExePath");
            mPackageSources = new PropertyAccessor<string>(project, "PackageSources");
            mNuGetCommand = new PropertyAccessor<string>(project, "NuGetCommand");
            mPackageOutputDir = new PropertyAccessor<string>(project, "PackageOutputDir");
            mRequireConsentSwitch = new PropertyAccessor<string>(project, "RequireConsentSwitch");
            mRestoreCommand = new PropertyAccessor<string>(project, "RestoreCommand");
            mBuildCommand = new PropertyAccessor<string>(project, "BuildCommand");
            mProcessorArchitectureAsPlatform = new PropertyAccessor<string>(project, "ProcessorArchitectureAsPlatform");
            mIsLibrary = new PropertyAccessor<bool?>(project, "IsLibrary");
            mProductVersion = new PropertyAccessor<string>(project, "ProductVersion");
            mSchemaVersion = new PropertyAccessor<string>(project, "SchemaVersion");
            mProjectTypeGuids = new PropertyAccessor<string>(project, "ProjectTypeGuids");
            mUseIISExpress = new PropertyAccessor<bool?>(project, "UseIISExpress");
            mIISExpressSSLPort = new PropertyAccessor<string>(project, "IISExpressSSLPort");
            mIISExpressAnonymousAuthentication = new PropertyAccessor<string>(project, "IISExpressAnonymousAuthentication");
            mIISExpressWindowsAuthentication = new PropertyAccessor<string>(project, "IISExpressWindowsAuthentication");
            mIISExpressUseClassicPipelineMode = new PropertyAccessor<string>(project, "IISExpressUseClassicPipelineMode");
            mVSToolsPath = new PropertyAccessor<string>(project, "VSToolsPath");
            mWebProjectOutputDirInsideProjectDefault = new PropertyAccessor<bool?>(project, "WebProjectOutputDirInsideProjectDefault");
            mWebProjectOutputDirInsideProject = new PropertyAccessor<string>(project, "WebProjectOutputDirInsideProject");
            mDisableLinkInCopyWebApplicaton = new PropertyAccessor<bool?>(project, "DisableLinkInCopyWebApplicaton");
            mDisable_CopyWebApplication = new PropertyAccessor<bool?>(project, "Disable_CopyWebApplication");
            mUseWPP_CopyWebApplication = new PropertyAccessor<bool?>(project, "UseWPP_CopyWebApplication");
            mCleanWebProjectOutputDir = new PropertyAccessor<bool?>(project, "CleanWebProjectOutputDir");
            mWebProjectOutputDir = new PropertyAccessor<string>(project, "WebProjectOutputDir");
            mCleanWebProjectOutputDirDependsOn = new PropertyAccessor<string>(project, "CleanWebProjectOutputDirDependsOn");
            mOnBefore_CopyWebApplicationDefault = new PropertyAccessor<string>(project, "OnBefore_CopyWebApplicationDefault");
            mOnBefore_CopyWebApplication = new PropertyAccessor<string>(project, "OnBefore_CopyWebApplication");
            mOnAfter_CopyWebApplication = new PropertyAccessor<string>(project, "OnAfter_CopyWebApplication");
            m_CopyWebApplicationDependsOn = new PropertyAccessor<string>(project, "_CopyWebApplicationDependsOn");
            mImportByWildcardBeforeMicrosoftWebPublishingTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftWebPublishingTargets");
            m_WPPVersion = new PropertyAccessor<string>(project, "_WPPVersion");
            m_WPPSupports = new PropertyAccessor<string>(project, "_WPPSupports");
            m_WPPWebPublishMethodSupports = new PropertyAccessor<string>(project, "_WPPWebPublishMethodSupports");
            mWebPublishPipelineProjectDirectory = new PropertyAccessor<string>(project, "WebPublishPipelineProjectDirectory");
            mWebPublishPipelineSourceRootDirectory = new PropertyAccessor<string>(project, "WebPublishPipelineSourceRootDirectory");
            mWebPublishPipelineTransformRootDirectory = new PropertyAccessor<string>(project, "WebPublishPipelineTransformRootDirectory");
            mWebPublishPipelineProjectName = new PropertyAccessor<string>(project, "WebPublishPipelineProjectName");
            mWebPublishPipelineProjectFile = new PropertyAccessor<string>(project, "WebPublishPipelineProjectFile");
            mWebPublishPipeLineProjectFullPath = new PropertyAccessor<string>(project, "WebPublishPipeLineProjectFullPath");
            mWebPublishPipelineWAPProjectSettings = new PropertyAccessor<string>(project, "WebPublishPipelineWAPProjectSettings");
            mVerifyDatabaseSettingWithImport = new PropertyAccessor<bool?>(project, "VerifyDatabaseSettingWithImport");
            m_LocalDBVersionToUseForSqlExpress = new PropertyAccessor<string>(project, "_LocalDBVersionToUseForSqlExpress");
            m_PublishProfileSet = new PropertyAccessor<bool?>(project, "_PublishProfileSet");
            mEnableWebPublishProfileFile = new PropertyAccessor<bool?>(project, "EnableWebPublishProfileFile");
            m_WPPDefaultIntermediateOutputPath = new PropertyAccessor<string>(project, "_WPPDefaultIntermediateOutputPath");
            m_WPPDefaultIntermediateOutputFullPath = new PropertyAccessor<string>(project, "_WPPDefaultIntermediateOutputFullPath");
            mPublishProfileRootFolder = new PropertyAccessor<string>(project, "PublishProfileRootFolder");
            mPublishProfileName = new PropertyAccessor<string>(project, "PublishProfileName");
            m_WebPublishProfileFileWillBeImported = new PropertyAccessor<bool?>(project, "_WebPublishProfileFileWillBeImported");
            mWebPublishPipelineCustomizeTargetFile = new PropertyAccessor<string>(project, "WebPublishPipelineCustomizeTargetFile");
            mWebPublishPipelineSolutionTargetFile = new PropertyAccessor<string>(project, "WebPublishPipelineSolutionTargetFile");
            m_WPPCleanTargets = new PropertyAccessor<string>(project, "_WPPCleanTargets");
            mFilesToIncludeForPublish = new PropertyAccessor<string>(project, "FilesToIncludeForPublish");
            mAlternativeProjectDirectory = new PropertyAccessor<string>(project, "AlternativeProjectDirectory");
            mExcludeGeneratedDebugSymbol = new PropertyAccessor<bool?>(project, "ExcludeGeneratedDebugSymbol");
            mExcludeXmlAssemblyFiles = new PropertyAccessor<bool?>(project, "ExcludeXmlAssemblyFiles");
            mExcludeApp_Data = new PropertyAccessor<bool?>(project, "ExcludeApp_Data");
            mSkipApp_DataFolder = new PropertyAccessor<string>(project, "SkipApp_DataFolder");
            mUseMsdeployExe = new PropertyAccessor<bool?>(project, "UseMsdeployExe");
            mEnableCollectLinkFilesInProject = new PropertyAccessor<bool?>(project, "EnableCollectLinkFilesInProject");
            mExcludeLinkFilesInProject = new PropertyAccessor<bool?>(project, "ExcludeLinkFilesInProject");
            mCleanWPPAllFilesInSingleFolder = new PropertyAccessor<bool?>(project, "CleanWPPAllFilesInSingleFolder");
            mIncludeIisSettings = new PropertyAccessor<bool?>(project, "IncludeIisSettings");
            mExcludeFilesFromPackage = new PropertyAccessor<bool?>(project, "ExcludeFilesFromPackage");
            mImportParametersFiles = new PropertyAccessor<bool?>(project, "ImportParametersFiles");
            mImportParametersFile_DisableEscapeMSBuildVariable = new PropertyAccessor<bool?>(project, "ImportParametersFile_DisableEscapeMSBuildVariable");
            mImportProjectParametersFiles = new PropertyAccessor<bool?>(project, "ImportProjectParametersFiles");
            mImportProfileParametersFiles = new PropertyAccessor<bool?>(project, "ImportProfileParametersFiles");
            mImportPublishingParameterValues = new PropertyAccessor<bool?>(project, "ImportPublishingParameterValues");
            mEnableOptimisticParameterDefaultValue = new PropertyAccessor<bool?>(project, "EnableOptimisticParameterDefaultValue");
            mParameterApplicationPool = new PropertyAccessor<bool?>(project, "ParameterApplicationPool");
            mIIS6ParameterApplicationPool = new PropertyAccessor<bool?>(project, "IIS6ParameterApplicationPool");
            mDisableAllVSGeneratedMSDeployParameter = new PropertyAccessor<bool?>(project, "DisableAllVSGeneratedMSDeployParameter");
            mAutoParameterizationWebConfigConnectionStrings = new PropertyAccessor<bool?>(project, "AutoParameterizationWebConfigConnectionStrings");
            mAutoParameterizationWebConfigCSNoDefaultValue = new PropertyAccessor<bool?>(project, "AutoParameterizationWebConfigCSNoDefaultValue");
            mAutoParameterizationWebConfigConnectionStringsIntermediateOutput = new PropertyAccessor<string>(project, "AutoParameterizationWebConfigConnectionStringsIntermediateOutput");
            mAutoParameterizationWebConfigConnectionStringsLocation = new PropertyAccessor<string>(project, "AutoParameterizationWebConfigConnectionStringsLocation");
            m_WPPLastBuildInfoIntermediateOutput = new PropertyAccessor<string>(project, "_WPPLastBuildInfoIntermediateOutput");
            m_WPPLastBuildInfoLocation = new PropertyAccessor<string>(project, "_WPPLastBuildInfoLocation");
            mInsertAdditionalWebCofigConnectionStrings = new PropertyAccessor<bool?>(project, "InsertAdditionalWebCofigConnectionStrings");
            mInsertAdditionalWebCofigConnectionStringsIntermediateOutput = new PropertyAccessor<string>(project, "InsertAdditionalWebCofigConnectionStringsIntermediateOutput");
            mInsertAdditionalWebCofigConnectionStringsLocation = new PropertyAccessor<string>(project, "InsertAdditionalWebCofigConnectionStringsLocation");
            mInsertAdditionalWebConfigConnectionStringProviderName = new PropertyAccessor<string>(project, "InsertAdditionalWebConfigConnectionStringProviderName");
            mInsertAdditionalWebConfigConnectionStringOnlyInRoot = new PropertyAccessor<bool?>(project, "InsertAdditionalWebConfigConnectionStringOnlyInRoot");
            mSqlScriptSourceTransacted = new PropertyAccessor<string>(project, "SqlScriptSourceTransacted");
            mAutoSqlScriptSourceTransacted = new PropertyAccessor<string>(project, "AutoSqlScriptSourceTransacted");
            mDatabaseDeployIntermediateRelativePath = new PropertyAccessor<string>(project, "DatabaseDeployIntermediateRelativePath");
            mDatabaseDeployIntermediateOutputPath = new PropertyAccessor<string>(project, "DatabaseDeployIntermediateOutputPath");
            m_WebConfigsToAutoParmeterizeCsTransformOutputParametersFile = new PropertyAccessor<string>(project, "_WebConfigsToAutoParmeterizeCsTransformOutputParametersFile");
            mDeployDefaultTarget = new PropertyAccessor<string>(project, "DeployDefaultTarget");
            mDeployTarget = new PropertyAccessor<string>(project, "DeployTarget");
            mRetryAttemptsForDeployment = new PropertyAccessor<int?>(project, "RetryAttemptsForDeployment");
            mDeployOnBuildDefault = new PropertyAccessor<bool?>(project, "DeployOnBuildDefault");
            mDeployOnBuild = new PropertyAccessor<string>(project, "DeployOnBuild");
            mEnableMSDeployBackup = new PropertyAccessor<bool?>(project, "EnableMSDeployBackup");
            mEnableMSDeployAppOffline = new PropertyAccessor<bool?>(project, "EnableMSDeployAppOffline");
            mMSDeployUseChecksum = new PropertyAccessor<bool?>(project, "MSDeployUseChecksum");
            mMSDeployEnableWebConfigEncryptRule = new PropertyAccessor<bool?>(project, "MSDeployEnableWebConfigEncryptRule");
            mMSDeployWebConfigEncryptProvider = new PropertyAccessor<string>(project, "MSDeployWebConfigEncryptProvider");
            m_MSDeployUserAgentSource = new PropertyAccessor<string>(project, "_MSDeployUserAgentSource");
            m_MSDeployUserAgent = new PropertyAccessor<string>(project, "_MSDeployUserAgent");
            mPipelineDependsOnBuild = new PropertyAccessor<bool?>(project, "PipelineDependsOnBuild");
            m_DeployOnBuild = new PropertyAccessor<string>(project, "_DeployOnBuild");
            mWPPCopyWebApplicaitonPipelineCircularDependencyError = new PropertyAccessor<bool?>(project, "WPPCopyWebApplicaitonPipelineCircularDependencyError");
            mPipelineDependsOn = new PropertyAccessor<string>(project, "PipelineDependsOn");
            mProjectConfigFileName = new PropertyAccessor<string>(project, "ProjectConfigFileName");
            m_ProjectConfigFileExtension = new PropertyAccessor<string>(project, "_ProjectConfigFileExtension");
            m_ProjectConfigFilePrefix = new PropertyAccessor<string>(project, "_ProjectConfigFilePrefix");
            mProjectConfigTransformFileName = new PropertyAccessor<string>(project, "ProjectConfigTransformFileName");
            mTransformWebConfigEnabled = new PropertyAccessor<bool?>(project, "TransformWebConfigEnabled");
            mTransformWebConfigStackTraceEnabled = new PropertyAccessor<bool?>(project, "TransformWebConfigStackTraceEnabled");
            mUseParameterizeToTransformWebConfig = new PropertyAccessor<bool?>(project, "UseParameterizeToTransformWebConfig");
            mTransformWebConfigIntermediateOutput = new PropertyAccessor<string>(project, "TransformWebConfigIntermediateOutput");
            mTransformWebConfigIntermediateLocation = new PropertyAccessor<string>(project, "TransformWebConfigIntermediateLocation");
            m_WebConfigTransformOutputParametersFile = new PropertyAccessor<string>(project, "_WebConfigTransformOutputParametersFile");
            mProfileTransformWebConfigEnabled = new PropertyAccessor<bool?>(project, "ProfileTransformWebConfigEnabled");
            mProfileTransformWebConfigStackTraceEnabled = new PropertyAccessor<bool?>(project, "ProfileTransformWebConfigStackTraceEnabled");
            mUseParameterizeToProfileTransformWebConfig = new PropertyAccessor<bool?>(project, "UseParameterizeToProfileTransformWebConfig");
            mProfileTransformWebConfigIntermediateOutput = new PropertyAccessor<string>(project, "ProfileTransformWebConfigIntermediateOutput");
            mProfileTransformWebConfigIntermediateLocation = new PropertyAccessor<string>(project, "ProfileTransformWebConfigIntermediateLocation");
            m_ProfileWebConfigTransformOutputParametersFile = new PropertyAccessor<string>(project, "_ProfileWebConfigTransformOutputParametersFile");
            mParameterizeTransformXmlUseXPath = new PropertyAccessor<bool?>(project, "ParameterizeTransformXmlUseXPath");
            mDefaultPackageOutputDir = new PropertyAccessor<string>(project, "DefaultPackageOutputDir");
            mDefaultPackageFileName = new PropertyAccessor<string>(project, "DefaultPackageFileName");
            mDefaultMSDeployDestinationSite = new PropertyAccessor<string>(project, "DefaultMSDeployDestinationSite");
            mDefaultMsDeployAltSuffix = new PropertyAccessor<string>(project, "DefaultMsDeployAltSuffix");
            mDefaultMSDeployDestinationApplicationName = new PropertyAccessor<string>(project, "DefaultMSDeployDestinationApplicationName");
            mDefaultDeployIisAppPath = new PropertyAccessor<string>(project, "DefaultDeployIisAppPath");
            mDefaultDeployIisRootAppPath = new PropertyAccessor<string>(project, "DefaultDeployIisRootAppPath");
            mPackageAsSingleFile = new PropertyAccessor<bool?>(project, "PackageAsSingleFile");
            mPackageLocation = new PropertyAccessor<string>(project, "PackageLocation");
            mPackageFileName = new PropertyAccessor<string>(project, "PackageFileName");
            mPackageArchiveRootDir = new PropertyAccessor<string>(project, "PackageArchiveRootDir");
            mPackageTempRootDir = new PropertyAccessor<string>(project, "PackageTempRootDir");
            mDeployAsIisApp = new PropertyAccessor<bool?>(project, "DeployAsIisApp");
            mIncludeSetAclProviderOnDestination = new PropertyAccessor<bool?>(project, "IncludeSetAclProviderOnDestination");
            mMarkApp_DataWritableOnDestination = new PropertyAccessor<bool?>(project, "MarkApp_DataWritableOnDestination");
            mIgnoreDeployManagedRuntimeVersion = new PropertyAccessor<bool?>(project, "IgnoreDeployManagedRuntimeVersion");
            mDeployDefaultTargetFrameworkVersion = new PropertyAccessor<string>(project, "DeployDefaultTargetFrameworkVersion");
            mDeployManagedRuntimeVersion = new PropertyAccessor<string>(project, "DeployManagedRuntimeVersion");
            mDeployEnable32bitAppOnWin64 = new PropertyAccessor<string>(project, "DeployEnable32bitAppOnWin64");
            mDeployManagedPipelineMode = new PropertyAccessor<string>(project, "DeployManagedPipelineMode");
            mGenerateSampleDeployScript = new PropertyAccessor<bool?>(project, "GenerateSampleDeployScript");
            mPackageLogDir = new PropertyAccessor<string>(project, "PackageLogDir");
            mEnablePackageProcessLoggingAndAssert = new PropertyAccessor<bool?>(project, "EnablePackageProcessLoggingAndAssert");
            mPackageTraceLevel = new PropertyAccessor<string>(project, "PackageTraceLevel");
            m_CreatePackage = new PropertyAccessor<bool?>(project, "_CreatePackage");
            m_UseDefaultLinkExtensionValue = new PropertyAccessor<bool?>(project, "_UseDefaultLinkExtensionValue");
            mPackageEnableLinks = new PropertyAccessor<string>(project, "PackageEnableLinks");
            mPackageDisableLinks = new PropertyAccessor<string>(project, "PackageDisableLinks");
            mProjectParametersXMLFile = new PropertyAccessor<string>(project, "ProjectParametersXMLFile");
            mEnableProjectDeployParameterPrefix = new PropertyAccessor<bool?>(project, "EnableProjectDeployParameterPrefix");
            mDeployParameterIISAppName = new PropertyAccessor<string>(project, "DeployParameterIISAppName");
            mDeployParameterIISAppPoolName = new PropertyAccessor<string>(project, "DeployParameterIISAppPoolName");
            mDeployParameterApp_DataWritePermission = new PropertyAccessor<string>(project, "DeployParameterApp_DataWritePermission");
            mDeployParameterIISAppPhysicalPath = new PropertyAccessor<string>(project, "DeployParameterIISAppPhysicalPath");
            mDeployParameterAutoDescriptionbyTags = new PropertyAccessor<bool?>(project, "DeployParameterAutoDescriptionbyTags");
            mDeployParameterIISAppNameDescription = new PropertyAccessor<string>(project, "DeployParameterIISAppNameDescription");
            mDeployParameterIISAppPoolNameDescription = new PropertyAccessor<string>(project, "DeployParameterIISAppPoolNameDescription");
            mDeployParameterIISAppPhysicalPathDescription = new PropertyAccessor<string>(project, "DeployParameterIISAppPhysicalPathDescription");
            mDeployParameterIISAppConnectionStringDescription = new PropertyAccessor<string>(project, "DeployParameterIISAppConnectionStringDescription");
            mDeployParameterSqlScriptVariablesDescription = new PropertyAccessor<string>(project, "DeployParameterSqlScriptVariablesDescription");
            mMsDeployDatabaseTag = new PropertyAccessor<string>(project, "MsDeployDatabaseTag");
            mMsDeploySqlCommandVariableKind = new PropertyAccessor<string>(project, "MsDeploySqlCommandVariableKind");
            mMsdeploySqlUnsupportedCommand = new PropertyAccessor<string>(project, "MsdeploySqlUnsupportedCommand");
            mCheckSqlScriptForUnsupportedCommands = new PropertyAccessor<bool?>(project, "CheckSqlScriptForUnsupportedCommands");
            mUpdateFromConnectionStringAttributes = new PropertyAccessor<string>(project, "UpdateFromConnectionStringAttributes");
            mTreadSqlScriptUnsupportedCommandsAsWarning = new PropertyAccessor<bool?>(project, "TreadSqlScriptUnsupportedCommandsAsWarning");
            m_PackageTempDir = new PropertyAccessor<string>(project, "_PackageTempDir");
            mWPPAllFilesInSingleFolder = new PropertyAccessor<string>(project, "WPPAllFilesInSingleFolder");
            mIsWPPAllFilesInSingleFolder = new PropertyAccessor<bool?>(project, "IsWPPAllFilesInSingleFolder");
            mEnableSqlScriptVariableParameterize = new PropertyAccessor<bool?>(project, "EnableSqlScriptVariableParameterize");
            mSqlScriptPreProcessBatchDelimiter = new PropertyAccessor<string>(project, "SqlScriptPreProcessBatchDelimiter");
            mSqlScriptPreProcessResolveIncludes = new PropertyAccessor<bool?>(project, "SqlScriptPreProcessResolveIncludes");
            mDeployIisAppPath = new PropertyAccessor<string>(project, "DeployIisAppPath");
            mRemoteSitePhysicalPath = new PropertyAccessor<string>(project, "RemoteSitePhysicalPath");
            mDefaultDeployIisAppPhysicalPath = new PropertyAccessor<string>(project, "DefaultDeployIisAppPhysicalPath");
            mDeployIisAppPhysicalPath = new PropertyAccessor<string>(project, "DeployIisAppPhysicalPath");
            m_DestinationIisAppPhysicalPath = new PropertyAccessor<string>(project, "_DestinationIisAppPhysicalPath");
            mDestinationIisVersion = new PropertyAccessor<string>(project, "DestinationIisVersion");
            mDestinationUseIis = new PropertyAccessor<string>(project, "DestinationUseIis");
            mPublishEnableLinks = new PropertyAccessor<string>(project, "PublishEnableLinks");
            mPublishDisableLinks = new PropertyAccessor<string>(project, "PublishDisableLinks");
            mDeployEncryptKey = new PropertyAccessor<string>(project, "DeployEncryptKey");
            mSkipExtraFilesOnServer = new PropertyAccessor<bool?>(project, "SkipExtraFilesOnServer");
            mMsDeployServiceUrl = new PropertyAccessor<string>(project, "MsDeployServiceUrl");
            mVsIisAppParametersPriority = new PropertyAccessor<int?>(project, "VsIisAppParametersPriority");
            mVsContentPathParametersPriority = new PropertyAccessor<int?>(project, "VsContentPathParametersPriority");
            mVsDestinationVDirParametersPriority = new PropertyAccessor<int?>(project, "VsDestinationVDirParametersPriority");
            mVsSetAclPriority = new PropertyAccessor<int?>(project, "VsSetAclPriority");
            mUserProfileParametersFileParametersPriority = new PropertyAccessor<int?>(project, "UserProfileParametersFileParametersPriority");
            mUserParametersFileParametersPriority = new PropertyAccessor<int?>(project, "UserParametersFileParametersPriority");
            mUserWebConfigParametersPriority = new PropertyAccessor<int?>(project, "UserWebConfigParametersPriority");
            mVsSQLDatabaseScriptParametersPriority = new PropertyAccessor<int?>(project, "VsSQLDatabaseScriptParametersPriority");
            mVsWebConfigAutoCsParametersPriority = new PropertyAccessor<int?>(project, "VsWebConfigAutoCsParametersPriority");
            mGenerateSampleDeployScriptLocation = new PropertyAccessor<string>(project, "GenerateSampleDeployScriptLocation");
            mPackageSourceManifest = new PropertyAccessor<string>(project, "PackageSourceManifest");
            mUseDeclareParametersXMLInMsDeploy = new PropertyAccessor<string>(project, "UseDeclareParametersXMLInMsDeploy");
            mPackageParametersFile = new PropertyAccessor<string>(project, "PackageParametersFile");
            mPublishParametersFile = new PropertyAccessor<string>(project, "PublishParametersFile");
            mGenerateSampleDeployScriptReadMeFileName = new PropertyAccessor<string>(project, "GenerateSampleDeployScriptReadMeFileName");
            mGenerateSampleDeployScriptReadMeLocation = new PropertyAccessor<string>(project, "GenerateSampleDeployScriptReadMeLocation");
            mGenerateSampleParametersValueLocationDefault = new PropertyAccessor<string>(project, "GenerateSampleParametersValueLocationDefault");
            mGenerateSampleParametersValueLocation = new PropertyAccessor<string>(project, "GenerateSampleParametersValueLocation");
            mGenerateSampleParametersValueFileName = new PropertyAccessor<string>(project, "GenerateSampleParametersValueFileName");
            mFilesToIncludeTargetFile = new PropertyAccessor<string>(project, "FilesToIncludeTargetFile");
            mImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets");
            mPublishPipelineCollectFilesCore = new PropertyAccessor<string>(project, "PublishPipelineCollectFilesCore");
            mExcludeTransformAssistFilesFromPublish = new PropertyAccessor<bool?>(project, "ExcludeTransformAssistFilesFromPublish");
            mCollectFilesFromIntermediateAssemblyDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromIntermediateAssemblyDependsOn");
            mCollectFilesFromContentDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromContentDependsOn");
            mCollectFilesFromAddModulesDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromAddModulesDependsOn");
            mCollectFilesFrom_SGenDllCreatedDependsOn = new PropertyAccessor<string>(project, "CollectFilesFrom_SGenDllCreatedDependsOn");
            mCollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn");
            mCollectFilesFromReferenceDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromReferenceDependsOn");
            mCollectFilesFromAllExtraReferenceFilesDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromAllExtraReferenceFilesDependsOn");
            mCollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn = new PropertyAccessor<string>(project, "CollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn");
            mCollectFilesFromDocFileItemDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromDocFileItemDependsOn");
            mCollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn = new PropertyAccessor<string>(project, "CollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn");
            mCollectFilesFrom_binDeployableAssembliesDependsOn = new PropertyAccessor<string>(project, "CollectFilesFrom_binDeployableAssembliesDependsOn");
            mImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets");
            mAspNetCompileMerge = new PropertyAccessor<bool?>(project, "AspNetCompileMerge");
            mWeb_Publishing_AspNetCompileMerge_targets = new PropertyAccessor<string>(project, "Web_Publishing_AspNetCompileMerge_targets");
            mMicrosoft_Web_Publishing_MSDeploy_Common_targets = new PropertyAccessor<string>(project, "Microsoft_Web_Publishing_MSDeploy_Common_targets");
            mImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets");
            mMicrosoft_Web_Publishing_MSDeploy_Common_targets_Imported = new PropertyAccessor<bool?>(project, "Microsoft_Web_Publishing_MSDeploy_Common_targets_Imported");
            mInsertEFCodeFirstDeployWebCofig = new PropertyAccessor<bool?>(project, "InsertEFCodeFirstDeployWebCofig");
            mInsertEFCodeFirstDeployWebCofigIntermediateOutput = new PropertyAccessor<string>(project, "InsertEFCodeFirstDeployWebCofigIntermediateOutput");
            mInsertEFCodeFirstDeployWebCofigLocation = new PropertyAccessor<string>(project, "InsertEFCodeFirstDeployWebCofigLocation");
            mPublishDatabases = new PropertyAccessor<bool?>(project, "PublishDatabases");
            mProcessPublishDatabaseSettingsDependsOn = new PropertyAccessor<string>(project, "ProcessPublishDatabaseSettingsDependsOn");
            mParseSQLScriptForMSDeployParametersDependsOn = new PropertyAccessor<string>(project, "ParseSQLScriptForMSDeployParametersDependsOn");
            mHandleEFCodeFirstDataMigrationDependsOn = new PropertyAccessor<string>(project, "HandleEFCodeFirstDataMigrationDependsOn");
            mPreInsertEFCodeFirstDeployWebCofigDependsOn = new PropertyAccessor<string>(project, "PreInsertEFCodeFirstDeployWebCofigDependsOn");
            mPreInsertEFCodeFirstDeployWebCofigBeforeTarget = new PropertyAccessor<string>(project, "PreInsertEFCodeFirstDeployWebCofigBeforeTarget");
            mInsertEFCodeFirstDeployWebCofigCoreDependsOn = new PropertyAccessor<string>(project, "InsertEFCodeFirstDeployWebCofigCoreDependsOn");
            mPostInsertEFCodeFirstDeployWebCofigDependsOn = new PropertyAccessor<string>(project, "PostInsertEFCodeFirstDeployWebCofigDependsOn");
            mInsertEFCodeFirstDeployWebCofigDependsOn = new PropertyAccessor<string>(project, "InsertEFCodeFirstDeployWebCofigDependsOn");
            mInsertEFCodeFirstDeployWebCofigBeforeTargets = new PropertyAccessor<string>(project, "InsertEFCodeFirstDeployWebCofigBeforeTargets");
            mCollectDatabasesToPublishDependsOn = new PropertyAccessor<string>(project, "CollectDatabasesToPublishDependsOn");
            mBeforeAddDeclareParametersItemsForDatabaseScript = new PropertyAccessor<string>(project, "BeforeAddDeclareParametersItemsForDatabaseScript");
            mAfterAddDeclareParametersItemsForDatabaseScript = new PropertyAccessor<string>(project, "AfterAddDeclareParametersItemsForDatabaseScript");
            mAddDeclareParametersItemsForDatabaseScriptDependsOn = new PropertyAccessor<string>(project, "AddDeclareParametersItemsForDatabaseScriptDependsOn");
            mWriteItemsToSourceManifestDependsOn = new PropertyAccessor<string>(project, "WriteItemsToSourceManifestDependsOn");
            mBeforeAddDatabasesToSourceManifest = new PropertyAccessor<string>(project, "BeforeAddDatabasesToSourceManifest");
            mAfterAddDatabasesToSourceManifest = new PropertyAccessor<string>(project, "AfterAddDatabasesToSourceManifest");
            mAddDatabasesToSourceManifestDependsOn = new PropertyAccessor<string>(project, "AddDatabasesToSourceManifestDependsOn");
            mAddDatabasesToSourceManifestAfterTargets = new PropertyAccessor<string>(project, "AddDatabasesToSourceManifestAfterTargets");
            mGenerateSampleDeployScriptDependsOn = new PropertyAccessor<string>(project, "GenerateSampleDeployScriptDependsOn");
            mGenerateSampleDeployScriptAfterTargets = new PropertyAccessor<string>(project, "GenerateSampleDeployScriptAfterTargets");
            mImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets");
            mExcludeApp_DataDependsOn = new PropertyAccessor<string>(project, "ExcludeApp_DataDependsOn");
            mExcludeGeneratedDebugSymbolDependsOn = new PropertyAccessor<string>(project, "ExcludeGeneratedDebugSymbolDependsOn");
            mExcludeXmlAssemblyFilesDependsOn = new PropertyAccessor<string>(project, "ExcludeXmlAssemblyFilesDependsOn");
            m_EnableCleanOnBuildForMvcViews = new PropertyAccessor<bool?>(project, "_EnableCleanOnBuildForMvcViews");
            mEnableExcludeFilesByExtension = new PropertyAccessor<bool?>(project, "EnableExcludeFilesByExtension");
            mExcludeFilesByExtensionDependsOn = new PropertyAccessor<string>(project, "ExcludeFilesByExtensionDependsOn");
            mWebPublishExtensionsToExclude = new PropertyAccessor<string>(project, "WebPublishExtensionsToExclude");
            mExcludeFilesFromPackageDependsOn = new PropertyAccessor<string>(project, "ExcludeFilesFromPackageDependsOn");
            mValidateGlobalSettingsDependsOn = new PropertyAccessor<string>(project, "ValidateGlobalSettingsDependsOn");
            mValidateGlobalPackageSettingDependsOn = new PropertyAccessor<string>(project, "ValidateGlobalPackageSettingDependsOn");
            m_CleanWPPIfNeedToDependsOn = new PropertyAccessor<string>(project, "_CleanWPPIfNeedToDependsOn");
            mOnBeforePipelineCollectFilesPhase = new PropertyAccessor<string>(project, "OnBeforePipelineCollectFilesPhase");
            mOnAfterPipelineCollectFilesPhase = new PropertyAccessor<string>(project, "OnAfterPipelineCollectFilesPhase");
            mPipelineCollectFilesPhaseDependsOn = new PropertyAccessor<string>(project, "PipelineCollectFilesPhaseDependsOn");
            mTransformWebConfigBeforeTargets = new PropertyAccessor<string>(project, "TransformWebConfigBeforeTargets");
            mTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "TransformWebConfigDependsOn");
            mCollectWebConfigsToTransformDependsOn = new PropertyAccessor<string>(project, "CollectWebConfigsToTransformDependsOn");
            mPreTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "PreTransformWebConfigDependsOn");
            mTransformWebConfigCoreDependsOn = new PropertyAccessor<string>(project, "TransformWebConfigCoreDependsOn");
            mParameterizeTransformWebConfigCoreDependsOn = new PropertyAccessor<string>(project, "ParameterizeTransformWebConfigCoreDependsOn");
            mPostTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "PostTransformWebConfigDependsOn");
            mMarkWebConfigAssistFilesAsExcludeDependsOn = new PropertyAccessor<string>(project, "MarkWebConfigAssistFilesAsExcludeDependsOn");
            mProfileTransformWebConfigBeforeTargets = new PropertyAccessor<string>(project, "ProfileTransformWebConfigBeforeTargets");
            mProfileTransformWebConfigAfterTargets = new PropertyAccessor<string>(project, "ProfileTransformWebConfigAfterTargets");
            mProfileTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "ProfileTransformWebConfigDependsOn");
            mCollectFilesForProfileTransformWebConfigsDependsOn = new PropertyAccessor<string>(project, "CollectFilesForProfileTransformWebConfigsDependsOn");
            mPreProfileTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "PreProfileTransformWebConfigDependsOn");
            mProfileTransformWebConfigCoreDependsOn = new PropertyAccessor<string>(project, "ProfileTransformWebConfigCoreDependsOn");
            mParameterizeProfileTransformWebConfigCoreDependsOn = new PropertyAccessor<string>(project, "ParameterizeProfileTransformWebConfigCoreDependsOn");
            mPostProfileTransformWebConfigDependsOn = new PropertyAccessor<string>(project, "PostProfileTransformWebConfigDependsOn");
            mPreInsertAdditionalWebCofigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "PreInsertAdditionalWebCofigConnectionStringsDependsOn");
            mInsertAdditionalWebCofigConnectionStringsCoreDependsOn = new PropertyAccessor<string>(project, "InsertAdditionalWebCofigConnectionStringsCoreDependsOn");
            mPostInsertAdditionalWebCofigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "PostInsertAdditionalWebCofigConnectionStringsDependsOn");
            mInsertAdditionalWebCofigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "InsertAdditionalWebCofigConnectionStringsDependsOn");
            mInsertAdditionalWebCofigConnectionStringsBeforeTargets = new PropertyAccessor<string>(project, "InsertAdditionalWebCofigConnectionStringsBeforeTargets");
            mPreAutoParameterizationWebConfigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "PreAutoParameterizationWebConfigConnectionStringsDependsOn");
            mAutoParameterizationWebConfigConnectionStringsCoreDependsOn = new PropertyAccessor<string>(project, "AutoParameterizationWebConfigConnectionStringsCoreDependsOn");
            mPostAutoParameterizationWebConfigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "PostAutoParameterizationWebConfigConnectionStringsDependsOn");
            mAutoParameterizationWebConfigConnectionStringsDependsOn = new PropertyAccessor<string>(project, "AutoParameterizationWebConfigConnectionStringsDependsOn");
            mPipelineTransformPhaseDependsOn = new PropertyAccessor<string>(project, "PipelineTransformPhaseDependsOn");
            mPipelineMsdeploySpecificTransformPhaseBeforeTargets = new PropertyAccessor<string>(project, "PipelineMsdeploySpecificTransformPhaseBeforeTargets");
            mPipelineMsdeploySpecificTransformPhaseDependsOn = new PropertyAccessor<string>(project, "PipelineMsdeploySpecificTransformPhaseDependsOn");
            m_WPPCopyWebApplicationDependsOn = new PropertyAccessor<string>(project, "_WPPCopyWebApplicationDependsOn");
            mPipelinePreDeployCopyAllFilesToOneFolderDependsOn = new PropertyAccessor<string>(project, "PipelinePreDeployCopyAllFilesToOneFolderDependsOn");
            mCopyAllFilesToSingleFolderForMsdeployDependsOn = new PropertyAccessor<string>(project, "CopyAllFilesToSingleFolderForMsdeployDependsOn");
            mPipelineCopyAllFilesToOneFolderForMsdeployDependsOn = new PropertyAccessor<string>(project, "PipelineCopyAllFilesToOneFolderForMsdeployDependsOn");
            mGetProjectWebPropertiesDependsOn = new PropertyAccessor<string>(project, "GetProjectWebPropertiesDependsOn");
            mGetMSDeployInstalledVersionPathDependsOn = new PropertyAccessor<string>(project, "GetMSDeployInstalledVersionPathDependsOn");
            mPackageDependsOn = new PropertyAccessor<string>(project, "PackageDependsOn");
            mCopyAllFilesToSingleFolderForPackageDependsOn = new PropertyAccessor<string>(project, "CopyAllFilesToSingleFolderForPackageDependsOn");
            mBeforeAddIis7ToSourceManifest = new PropertyAccessor<string>(project, "BeforeAddIis7ToSourceManifest");
            mAfterAddIis7ToSourceManifest = new PropertyAccessor<string>(project, "AfterAddIis7ToSourceManifest");
            mAddIis7ToSourceManifestDependsOn = new PropertyAccessor<string>(project, "AddIis7ToSourceManifestDependsOn");
            mBeforeAddDeclareParametersItemsForIis7 = new PropertyAccessor<string>(project, "BeforeAddDeclareParametersItemsForIis7");
            mAfterAddDeclareParametersItemsForIis7 = new PropertyAccessor<string>(project, "AfterAddDeclareParametersItemsForIis7");
            mAddDeclareParametersItemsForIis7DependsOn = new PropertyAccessor<string>(project, "AddDeclareParametersItemsForIis7DependsOn");
            mBeforeAddIis6ToSourceManifest = new PropertyAccessor<string>(project, "BeforeAddIis6ToSourceManifest");
            mAfterAddIis6ToSourceManifest = new PropertyAccessor<string>(project, "AfterAddIis6ToSourceManifest");
            mAddIis6ToSourceManifestDependsOn = new PropertyAccessor<string>(project, "AddIis6ToSourceManifestDependsOn");
            mBeforeAddDeclareParametersItemsForIis6 = new PropertyAccessor<string>(project, "BeforeAddDeclareParametersItemsForIis6");
            mAfterAddDeclareParametersItemsForIis6 = new PropertyAccessor<string>(project, "AfterAddDeclareParametersItemsForIis6");
            mAddDeclareParametersItemsForIis6DependsOn = new PropertyAccessor<string>(project, "AddDeclareParametersItemsForIis6DependsOn");
            mBeforeAddIisSettingAndFileContentsToSourceManifest = new PropertyAccessor<string>(project, "BeforeAddIisSettingAndFileContentsToSourceManifest");
            mAfterAddIisSettingAndFileContentsToSourceManifest = new PropertyAccessor<string>(project, "AfterAddIisSettingAndFileContentsToSourceManifest");
            mAddIisSettingAndFileContentsToSourceManifestDependsOn = new PropertyAccessor<string>(project, "AddIisSettingAndFileContentsToSourceManifestDependsOn");
            mBeforeAddContentPathToSourceManifest = new PropertyAccessor<string>(project, "BeforeAddContentPathToSourceManifest");
            mAfterAddContentPathToSourceManifest = new PropertyAccessor<string>(project, "AfterAddContentPathToSourceManifest");
            mAddContentPathToSourceManifestDependsOn = new PropertyAccessor<string>(project, "AddContentPathToSourceManifestDependsOn");
            mBeforeAddIisAndContentDeclareParametersItems = new PropertyAccessor<string>(project, "BeforeAddIisAndContentDeclareParametersItems");
            mAfterAddIisAndContentDeclareParametersItems = new PropertyAccessor<string>(project, "AfterAddIisAndContentDeclareParametersItems");
            mAddIisAndContentDeclareParametersItemsDependsOn = new PropertyAccessor<string>(project, "AddIisAndContentDeclareParametersItemsDependsOn");
            mBeforeAddDeclareParametersItemsForContentPath = new PropertyAccessor<string>(project, "BeforeAddDeclareParametersItemsForContentPath");
            mAfterAddDeclareParametersItemsForContentPath = new PropertyAccessor<string>(project, "AfterAddDeclareParametersItemsForContentPath");
            mAddDeclareParametersItemsForContentPathDependsOn = new PropertyAccessor<string>(project, "AddDeclareParametersItemsForContentPathDependsOn");
            mBeforeWriteItemsToSourceManifest = new PropertyAccessor<string>(project, "BeforeWriteItemsToSourceManifest");
            mAfterWriteItemsToSourceManifest = new PropertyAccessor<string>(project, "AfterWriteItemsToSourceManifest");
            mBeforeAddDeclareParametersItems = new PropertyAccessor<string>(project, "BeforeAddDeclareParametersItems");
            mAfterAddDeclareParametersItems = new PropertyAccessor<string>(project, "AfterAddDeclareParametersItems");
            mAddDeclareParametersItemsDependsOn = new PropertyAccessor<string>(project, "AddDeclareParametersItemsDependsOn");
            m_GatherParamsDependsOn = new PropertyAccessor<string>(project, "_GatherParamsDependsOn");
            mGenerateMsDeployManifestSettingsDependsOn = new PropertyAccessor<string>(project, "GenerateMsDeployManifestSettingsDependsOn");
            mCleanWebsitesPackageCoreDependsOn = new PropertyAccessor<string>(project, "CleanWebsitesPackageCoreDependsOn");
            mCleanWebsitesPackageDependsOn = new PropertyAccessor<string>(project, "CleanWebsitesPackageDependsOn");
            mCleanWebsitesWPPAllFilesInSingleFolderDependsOn = new PropertyAccessor<string>(project, "CleanWebsitesWPPAllFilesInSingleFolderDependsOn");
            mCleanWebPublishPipelineIntermediateOutputDependsOn = new PropertyAccessor<string>(project, "CleanWebPublishPipelineIntermediateOutputDependsOn");
            mCheckAndCleanMSDeployPackageIfNeededDependsOn = new PropertyAccessor<string>(project, "CheckAndCleanMSDeployPackageIfNeededDependsOn");
            mOnAfterGenerateMsdeployManifestFiles = new PropertyAccessor<string>(project, "OnAfterGenerateMsdeployManifestFiles");
            mGenerateMsdeployManifestFilesDependsOn = new PropertyAccessor<string>(project, "GenerateMsdeployManifestFilesDependsOn");
            mPackageUsingManifestDependsOn = new PropertyAccessor<string>(project, "PackageUsingManifestDependsOn");
            mTestDeployPackageToLocalDependsOn = new PropertyAccessor<string>(project, "TestDeployPackageToLocalDependsOn");
            mNormalizePublishSettings = new PropertyAccessor<bool?>(project, "NormalizePublishSettings");
            mAuthType = new PropertyAccessor<string>(project, "AuthType");
            mMSDeployPublishMethod = new PropertyAccessor<string>(project, "MSDeployPublishMethod");
            mGenerateGlobalPublishSettingDependsOn = new PropertyAccessor<string>(project, "GenerateGlobalPublishSettingDependsOn");
            mCreatePackageOnPublish = new PropertyAccessor<bool?>(project, "CreatePackageOnPublish");
            mMSDeployPublishDependsOn = new PropertyAccessor<string>(project, "MSDeployPublishDependsOn");
            mValidatePublishProfileSettingsDependsOn = new PropertyAccessor<string>(project, "ValidatePublishProfileSettingsDependsOn");
            mWebMSDeployPublishDependsOn = new PropertyAccessor<string>(project, "WebMSDeployPublishDependsOn");
            mWebPackagePublishDependsOn = new PropertyAccessor<string>(project, "WebPackagePublishDependsOn");
            mWebPublishDependsOn = new PropertyAccessor<string>(project, "WebPublishDependsOn");
            mPipelineDeployPhaseDependsOn = new PropertyAccessor<string>(project, "PipelineDeployPhaseDependsOn");
            mPipelineDeployPhaseAfterTargets = new PropertyAccessor<string>(project, "PipelineDeployPhaseAfterTargets");
            mDbDacFxPreviewDependsOn = new PropertyAccessor<string>(project, "DbDacFxPreviewDependsOn");
            mDbFullSqlPreviewDependsOn = new PropertyAccessor<string>(project, "DbFullSqlPreviewDependsOn");
            mValidateDbDacFxPreviewSettingsDependsOn = new PropertyAccessor<string>(project, "ValidateDbDacFxPreviewSettingsDependsOn");
            mLocalDbDacFxPreviewDependsOn = new PropertyAccessor<string>(project, "LocalDbDacFxPreviewDependsOn");
            mRemoteDbDacFxPreviewDependsOn = new PropertyAccessor<string>(project, "RemoteDbDacFxPreviewDependsOn");
            mImportByWildcardAfterMicrosoftWebPublishingTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftWebPublishingTargets");
            m_TransformWebConfigForAzureAuthenticationDependsOn = new PropertyAccessor<string>(project, "_TransformWebConfigForAzureAuthenticationDependsOn");
            mMSBuildFrameworkToolsPath = new PropertyAccessor<string>(project, "MSBuildFrameworkToolsPath");
            mMSBuildFrameworkToolsPath32 = new PropertyAccessor<string>(project, "MSBuildFrameworkToolsPath32");
            mMSBuildFrameworkToolsRoot = new PropertyAccessor<string>(project, "MSBuildFrameworkToolsRoot");
            mVCTargetsPath = new PropertyAccessor<string>(project, "VCTargetsPath");
            mVCTargetsPath10 = new PropertyAccessor<string>(project, "VCTargetsPath10");
            mVCTargetsPath11 = new PropertyAccessor<string>(project, "VCTargetsPath11");
            mVCTargetsPath12 = new PropertyAccessor<string>(project, "VCTargetsPath12");
            mWindowsSDK80Path = new PropertyAccessor<string>(project, "WindowsSDK80Path");
            mCustomBeforeMicrosoftCommonProps = new PropertyAccessor<string>(project, "CustomBeforeMicrosoftCommonProps");
            mCustomAfterMicrosoftCommonProps = new PropertyAccessor<string>(project, "CustomAfterMicrosoftCommonProps");
            mMicrosoftCommonPropsHasBeenImported = new PropertyAccessor<bool?>(project, "MicrosoftCommonPropsHasBeenImported");
            mWMSJSProject = new PropertyAccessor<string>(project, "WMSJSProject");
            mWMSJSProjectDirectory = new PropertyAccessor<string>(project, "WMSJSProjectDirectory");
            mTargetFrameworkProfile = new PropertyAccessor<string>(project, "TargetFrameworkProfile");
            mUseVSHostingProcess = new PropertyAccessor<bool?>(project, "UseVSHostingProcess");
            mSignAssembly = new PropertyAccessor<bool?>(project, "SignAssembly");
            mAssemblyOriginatorKeyFile = new PropertyAccessor<string>(project, "AssemblyOriginatorKeyFile");
            mCSharpTargetsPath = new PropertyAccessor<string>(project, "CSharpTargetsPath");
            mCscToolPath = new PropertyAccessor<string>(project, "CscToolPath");
            mImportByWildcardBefore40MicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBefore40MicrosoftCommonTargets");
            mImportByWildcardAfter40MicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfter40MicrosoftCommonTargets");
            mImportUserLocationsByWildcardBefore40MicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBefore40MicrosoftCommonTargets");
            mImportUserLocationsByWildcardAfter40MicrosoftCommonTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfter40MicrosoftCommonTargets");
            mImportByWildcardBefore40MicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBefore40MicrosoftCSharpTargets");
            mImportByWildcardAfter40MicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfter40MicrosoftCSharpTargets");
            mImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets");
            mImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets");
            mImportByWildcardBefore40MicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportByWildcardBefore40MicrosoftNetFrameworkProps");
            mImportByWildcardAfter40MicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportByWildcardAfter40MicrosoftNetFrameworkProps");
            mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps");
            mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps");
            mNetFrameworkTargetsPath = new PropertyAccessor<string>(project, "NetFrameworkTargetsPath");
            mImportByWildcardBefore40MicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBefore40MicrosoftNetFrameworkTargets");
            mImportByWildcardAfter40MicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfter40MicrosoftNetFrameworkTargets");
            mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets");
            mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets = new PropertyAccessor<bool?>(project, "ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets");
            mXamlBuildTaskPath = new PropertyAccessor<string>(project, "XamlBuildTaskPath");
            mAllowUnsafeBlocks = new PropertyAccessor<bool?>(project, "AllowUnsafeBlocks");
            mMinimumVisualStudioVersion = new PropertyAccessor<string>(project, "MinimumVisualStudioVersion");
            mDefaultLanguage = new PropertyAccessor<string>(project, "DefaultLanguage");
            mTargetFrameworkMonikerDisplayName = new PropertyAccessor<string>(project, "TargetFrameworkMonikerDisplayName");
            mImplicitlyExpandTargetFramework = new PropertyAccessor<bool?>(project, "ImplicitlyExpandTargetFramework");
            mImplicitlyExpandTargetFrameworkDependsOn = new PropertyAccessor<string>(project, "ImplicitlyExpandTargetFrameworkDependsOn");
            mReferencePath = new PropertyAccessor<string>(project, "ReferencePath");
            mIsCodedUITest = new PropertyAccessor<bool?>(project, "IsCodedUITest");
            mTestProjectType = new PropertyAccessor<string>(project, "TestProjectType");
            mRootPath = new PropertyAccessor<string>(project, "RootPath");
            m_InvalidConfigurationError = new PropertyAccessor<bool?>(project, "_InvalidConfigurationError");
            mSilverlightBuild = new PropertyAccessor<bool?>(project, "SilverlightBuild");
            mBuildName = new PropertyAccessor<string>(project, "BuildName");
            mProject_Major = new PropertyAccessor<int?>(project, "Project_Major");
            mProject_Minor = new PropertyAccessor<int?>(project, "Project_Minor");
            mProject_Build = new PropertyAccessor<int?>(project, "Project_Build");
            mAssemblyVersion_Build = new PropertyAccessor<int?>(project, "AssemblyVersion_Build");
            mBuildScriptsPath = new PropertyAccessor<string>(project, "BuildScriptsPath");
            mBuildConfigDescription = new PropertyAccessor<string>(project, "BuildConfigDescription");
            mBuildPath = new PropertyAccessor<string>(project, "BuildPath");
            mToolsPath = new PropertyAccessor<string>(project, "ToolsPath");
            mTestResultsPath = new PropertyAccessor<string>(project, "TestResultsPath");
            mAssemblyInfoFile = new PropertyAccessor<string>(project, "AssemblyInfoFile");
            mAssemblyTitle = new PropertyAccessor<string>(project, "AssemblyTitle");
            mAssemblyProduct = new PropertyAccessor<string>(project, "AssemblyProduct");
            mComVisible = new PropertyAccessor<bool?>(project, "ComVisible");
            mCLSCompliant = new PropertyAccessor<bool?>(project, "CLSCompliant");
            mAllowPartiallyTrustedCallers = new PropertyAccessor<bool?>(project, "AllowPartiallyTrustedCallers");
            mAssemblyVersion_Major = new PropertyAccessor<string>(project, "AssemblyVersion_Major");
            mAssemblyVersion_Minor = new PropertyAccessor<string>(project, "AssemblyVersion_Minor");
            mBuild_Number = new PropertyAccessor<int?>(project, "Build_Number");
            mBuild_Revision = new PropertyAccessor<string>(project, "Build_Revision");
            mTestDetectionExpression = new PropertyAccessor<string>(project, "TestDetectionExpression");
            mTestRunner_Enabled = new PropertyAccessor<bool?>(project, "TestRunner_Enabled");
            mTestRunner_Timeout = new PropertyAccessor<int?>(project, "TestRunner_Timeout");
            mTestRunner_ContinueOnError = new PropertyAccessor<bool?>(project, "TestRunner_ContinueOnError");
            mNUnitExecutable = new PropertyAccessor<string>(project, "NUnitExecutable");
            mNUnitPath = new PropertyAccessor<string>(project, "NUnitPath");
            mMSBuildCommunityTasksPath = new PropertyAccessor<string>(project, "MSBuildCommunityTasksPath");
            mMSBuildCommunityTasksLib = new PropertyAccessor<string>(project, "MSBuildCommunityTasksLib");
            mFileUpgradeFlags = new PropertyAccessor<string>(project, "FileUpgradeFlags");
            mUpgradeBackupLocation = new PropertyAccessor<string>(project, "UpgradeBackupLocation");
            mSilverlightApplication = new PropertyAccessor<bool?>(project, "SilverlightApplication");
            mSupportedCultures = new PropertyAccessor<string>(project, "SupportedCultures");
            mXapOutputs = new PropertyAccessor<bool?>(project, "XapOutputs");
            mGenerateSilverlightManifest = new PropertyAccessor<bool?>(project, "GenerateSilverlightManifest");
            mXapFilename = new PropertyAccessor<string>(project, "XapFilename");
            mSilverlightManifestTemplate = new PropertyAccessor<string>(project, "SilverlightManifestTemplate");
            mSilverlightAppEntry = new PropertyAccessor<string>(project, "SilverlightAppEntry");
            mCreateTestPage = new PropertyAccessor<bool?>(project, "CreateTestPage");
            mValidateXaml = new PropertyAccessor<bool?>(project, "ValidateXaml");
            mEnableOutOfBrowser = new PropertyAccessor<bool?>(project, "EnableOutOfBrowser");
            mOutOfBrowserSettingsFile = new PropertyAccessor<string>(project, "OutOfBrowserSettingsFile");
            mUsePlatformExtensions = new PropertyAccessor<bool?>(project, "UsePlatformExtensions");
            mThrowErrorsInValidation = new PropertyAccessor<bool?>(project, "ThrowErrorsInValidation");
            mLinkedServerProject = new PropertyAccessor<string>(project, "LinkedServerProject");
            mOldToolsVersion = new PropertyAccessor<string>(project, "OldToolsVersion");
            mProjectType = new PropertyAccessor<string>(project, "ProjectType");
            mApplicationIcon = new PropertyAccessor<string>(project, "ApplicationIcon");
            mAssemblyKeyContainerName = new PropertyAccessor<string>(project, "AssemblyKeyContainerName");
            mDefaultClientScript = new PropertyAccessor<string>(project, "DefaultClientScript");
            mDefaultHTMLPageLayout = new PropertyAccessor<string>(project, "DefaultHTMLPageLayout");
            mDefaultTargetSchema = new PropertyAccessor<string>(project, "DefaultTargetSchema");
            mRunPostBuildEvent = new PropertyAccessor<string>(project, "RunPostBuildEvent");
            mStartupObject = new PropertyAccessor<string>(project, "StartupObject");
            mPreBuildEvent = new PropertyAccessor<string>(project, "PreBuildEvent");
            mPostBuildEvent = new PropertyAccessor<string>(project, "PostBuildEvent");
            mBuildToolsVersion = new PropertyAccessor<string>(project, "BuildToolsVersion");
            mSourceDir = new PropertyAccessor<string>(project, "SourceDir");
            mBinDir = new PropertyAccessor<string>(project, "BinDir");
            mObjDir = new PropertyAccessor<string>(project, "ObjDir");
            mTestWorkingDir = new PropertyAccessor<string>(project, "TestWorkingDir");
            mPackagesOutDir = new PropertyAccessor<string>(project, "PackagesOutDir");
            mPackagesDir = new PropertyAccessor<string>(project, "PackagesDir");
            mToolsDir = new PropertyAccessor<string>(project, "ToolsDir");
            mNuGetToolPath = new PropertyAccessor<string>(project, "NuGetToolPath");
            mNuGetConfigFile = new PropertyAccessor<string>(project, "NuGetConfigFile");
            mNuGetConfigCommandLine = new PropertyAccessor<string>(project, "NuGetConfigCommandLine");
            mNugetRestoreCommand = new PropertyAccessor<string>(project, "NugetRestoreCommand");
            mConfigurationGroup = new PropertyAccessor<string>(project, "ConfigurationGroup");
            mOSGroup = new PropertyAccessor<string>(project, "OSGroup");
            mNoStdLib = new PropertyAccessor<bool?>(project, "NoStdLib");
            mNoExplicitReferenceToStdLib = new PropertyAccessor<bool?>(project, "NoExplicitReferenceToStdLib");
            mCommonPath = new PropertyAccessor<string>(project, "CommonPath");
            mCommonTestPath = new PropertyAccessor<string>(project, "CommonTestPath");
            mOSPlatformConfig = new PropertyAccessor<string>(project, "OSPlatformConfig");
            mBaseOutputPath = new PropertyAccessor<string>(project, "BaseOutputPath");
            mTestPath = new PropertyAccessor<string>(project, "TestPath");
            mPackagesBasePath = new PropertyAccessor<string>(project, "PackagesBasePath");
            mTargetsWindows = new PropertyAccessor<bool?>(project, "TargetsWindows");
            m_WindowsKitBinPath = new PropertyAccessor<string>(project, "_WindowsKitBinPath");
            m_WindowsPhoneKitBinPath = new PropertyAccessor<string>(project, "_WindowsPhoneKitBinPath");
            mMakePriExeFullPath = new PropertyAccessor<string>(project, "MakePriExeFullPath");
            mMakeAppxExeFullPath = new PropertyAccessor<string>(project, "MakeAppxExeFullPath");
            mSignAppxPackageExeFullPath = new PropertyAccessor<string>(project, "SignAppxPackageExeFullPath");
            mMakePriExtensionPath = new PropertyAccessor<string>(project, "MakePriExtensionPath");
            mMakePriExtensionPath_x64 = new PropertyAccessor<string>(project, "MakePriExtensionPath_x64");
            mErrorIfBuildToolsRestoredFromIndividualProject = new PropertyAccessor<bool?>(project, "ErrorIfBuildToolsRestoredFromIndividualProject");
            mAssemblyVersion = new PropertyAccessor<string>(project, "AssemblyVersion");
            mTestCategories = new PropertyAccessor<string>(project, "TestCategories");
            mDocumentationFile = new PropertyAccessor<string>(project, "DocumentationFile");
            mGenerateAppxPackageOnBuild = new PropertyAccessor<bool?>(project, "GenerateAppxPackageOnBuild");
            mNuGetPackageImportStamp = new PropertyAccessor<string>(project, "NuGetPackageImportStamp");
            mDebugEngines = new PropertyAccessor<string>(project, "DebugEngines");
            mGenerateAssemblyInfo = new PropertyAccessor<bool?>(project, "GenerateAssemblyInfo");
            mNoWarn = new PropertyAccessor<string>(project, "NoWarn");
            mRuntimeSerializationSources = new PropertyAccessor<string>(project, "RuntimeSerializationSources");
            mJsonSources = new PropertyAccessor<string>(project, "JsonSources");
            mXmlSources = new PropertyAccessor<string>(project, "XmlSources");
            mTextSources = new PropertyAccessor<string>(project, "TextSources");
            mCheckForOverflowUnderflow = new PropertyAccessor<bool?>(project, "CheckForOverflowUnderflow");
            mExternallyShipping = new PropertyAccessor<bool?>(project, "ExternallyShipping");
            mRunTestsForProject = new PropertyAccessor<bool?>(project, "RunTestsForProject");
            mCommonPathXPath = new PropertyAccessor<string>(project, "CommonPathXPath");
            mTypeScriptTarget = new PropertyAccessor<string>(project, "TypeScriptTarget");
            mTypeScriptCompileOnSaveEnabled = new PropertyAccessor<bool?>(project, "TypeScriptCompileOnSaveEnabled");
            mTypeScriptNoImplicitAny = new PropertyAccessor<bool?>(project, "TypeScriptNoImplicitAny");
            mTypeScriptModuleKind = new PropertyAccessor<string>(project, "TypeScriptModuleKind");
            mTypeScriptRemoveComments = new PropertyAccessor<bool?>(project, "TypeScriptRemoveComments");
            mTypeScriptOutFile = new PropertyAccessor<string>(project, "TypeScriptOutFile");
            mTypeScriptOutDir = new PropertyAccessor<string>(project, "TypeScriptOutDir");
            mTypeScriptGeneratesDeclarations = new PropertyAccessor<bool?>(project, "TypeScriptGeneratesDeclarations");
            mTypeScriptSourceMap = new PropertyAccessor<bool?>(project, "TypeScriptSourceMap");
            mTypeScriptMapRoot = new PropertyAccessor<string>(project, "TypeScriptMapRoot");
            mTypeScriptSourceRoot = new PropertyAccessor<string>(project, "TypeScriptSourceRoot");
            mTypeScriptNoEmitOnError = new PropertyAccessor<bool?>(project, "TypeScriptNoEmitOnError");
            mTypeScriptToolsVersion = new PropertyAccessor<string>(project, "TypeScriptToolsVersion");
            mVsToolsPath = new PropertyAccessor<string>(project, "VsToolsPath");
            mCfgPropertyPagesGuidsAddCSharp = new PropertyAccessor<string>(project, "CfgPropertyPagesGuidsAddCSharp");
            mCfgPropertyPagesGuidsAddVB = new PropertyAccessor<string>(project, "CfgPropertyPagesGuidsAddVB");
            mCfgPropertyPagesGuidsAddTypeScript = new PropertyAccessor<string>(project, "CfgPropertyPagesGuidsAddTypeScript");
            mTypeScriptEnabled = new PropertyAccessor<bool?>(project, "TypeScriptEnabled");
            mTypeScriptBuildConfigurations = new PropertyAccessor<string>(project, "TypeScriptBuildConfigurations");
            mTscToolPath = new PropertyAccessor<string>(project, "TscToolPath");
            mTscToolExe = new PropertyAccessor<string>(project, "TscToolExe");
            mTscYieldDuringToolExecution = new PropertyAccessor<bool?>(project, "TscYieldDuringToolExecution");
            mConsolePause = new PropertyAccessor<bool?>(project, "ConsolePause");
            mPublishUrl = new PropertyAccessor<string>(project, "PublishUrl");
            mInstall = new PropertyAccessor<bool?>(project, "Install");
            mInstallFrom = new PropertyAccessor<string>(project, "InstallFrom");
            mUpdateEnabled = new PropertyAccessor<bool?>(project, "UpdateEnabled");
            mUpdateMode = new PropertyAccessor<string>(project, "UpdateMode");
            mUpdateInterval = new PropertyAccessor<int?>(project, "UpdateInterval");
            mUpdateIntervalUnits = new PropertyAccessor<string>(project, "UpdateIntervalUnits");
            mUpdatePeriodically = new PropertyAccessor<bool?>(project, "UpdatePeriodically");
            mUpdateRequired = new PropertyAccessor<bool?>(project, "UpdateRequired");
            mMapFileExtensions = new PropertyAccessor<bool?>(project, "MapFileExtensions");
            mApplicationRevision = new PropertyAccessor<int?>(project, "ApplicationRevision");
            mApplicationVersion = new PropertyAccessor<string>(project, "ApplicationVersion");
            mIsWebBootstrapper = new PropertyAccessor<bool?>(project, "IsWebBootstrapper");
            mUseApplicationTrust = new PropertyAccessor<bool?>(project, "UseApplicationTrust");
            mBootstrapperEnabled = new PropertyAccessor<bool?>(project, "BootstrapperEnabled");
            m_FullFrameworkReferenceAssemblyPaths = new PropertyAccessor<string>(project, "_FullFrameworkReferenceAssemblyPaths");
            m_TargetFrameworkDirectories = new PropertyAccessor<string>(project, "_TargetFrameworkDirectories");
            mTreatWarningsAsErrors = new PropertyAccessor<bool?>(project, "TreatWarningsAsErrors");
            mRegisterForComInterop = new PropertyAccessor<bool?>(project, "RegisterForComInterop");
            mGenerateSerializationAssemblies = new PropertyAccessor<string>(project, "GenerateSerializationAssemblies");
            mBaseAddress = new PropertyAccessor<int?>(project, "BaseAddress");
            mPublishUrlHistory = new PropertyAccessor<string>(project, "PublishUrlHistory");
            mInstallUrlHistory = new PropertyAccessor<string>(project, "InstallUrlHistory");
            mSupportUrlHistory = new PropertyAccessor<string>(project, "SupportUrlHistory");
            mUpdateUrlHistory = new PropertyAccessor<string>(project, "UpdateUrlHistory");
            mBootstrapperUrlHistory = new PropertyAccessor<string>(project, "BootstrapperUrlHistory");
            mErrorReportUrlHistory = new PropertyAccessor<string>(project, "ErrorReportUrlHistory");
            mFallbackCulture = new PropertyAccessor<string>(project, "FallbackCulture");
            mVerifyUploadedFiles = new PropertyAccessor<bool?>(project, "VerifyUploadedFiles");
            mSccProjectName = new PropertyAccessor<string>(project, "SccProjectName");
            mSccLocalPath = new PropertyAccessor<string>(project, "SccLocalPath");
            mSccAuxPath = new PropertyAccessor<string>(project, "SccAuxPath");
            mSccProvider = new PropertyAccessor<string>(project, "SccProvider");
            mSilverlightVersion = new PropertyAccessor<string>(project, "SilverlightVersion");
            mNoConfig = new PropertyAccessor<bool?>(project, "NoConfig");
            mVCInstallDir_110 = new PropertyAccessor<string>(project, "VCInstallDir_110");
            mWP80ToolSetPath = new PropertyAccessor<string>(project, "WP80ToolSetPath");
            mWindowsPhoneSdkRegkeyRoot = new PropertyAccessor<string>(project, "WindowsPhoneSdkRegkeyRoot");
            mWindowsPhoneRegistryBase = new PropertyAccessor<string>(project, "WindowsPhoneRegistryBase");
            mWindowsPhoneRegistryBaseVersion = new PropertyAccessor<string>(project, "WindowsPhoneRegistryBaseVersion");
            mRuntimePathRegistryKey = new PropertyAccessor<string>(project, "RuntimePathRegistryKey");
            mResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch = new PropertyAccessor<string>(project, "ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch");
            mWindowsPhoneSdkVersion = new PropertyAccessor<string>(project, "WindowsPhoneSdkVersion");
            mWindowsPhoneSdkInstallPath = new PropertyAccessor<string>(project, "WindowsPhoneSdkInstallPath");
            mWindowsPhone71RegistryBase = new PropertyAccessor<string>(project, "WindowsPhone71RegistryBase");
            mWindowsPhone71RegistryBaseVersion = new PropertyAccessor<string>(project, "WindowsPhone71RegistryBaseVersion");
            mWindowsPhone7RegistryBase = new PropertyAccessor<string>(project, "WindowsPhone7RegistryBase");
            mWindowsPhone7RegistryBaseVersion = new PropertyAccessor<string>(project, "WindowsPhone7RegistryBaseVersion");
            mWindowsPhoneFxReferencesDisplayName = new PropertyAccessor<string>(project, "WindowsPhoneFxReferencesDisplayName");
            mPathOfWMAppManifestRelativeToProject = new PropertyAccessor<string>(project, "PathOfWMAppManifestRelativeToProject");
            mImportByWildcardBeforeWindowsPhoneCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeWindowsPhoneCommonTargets");
            mImportByWildcardAfterWindowsPhoneCommonTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterWindowsPhoneCommonTargets");
            mIncludeBuiltProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeBuiltProjectOutputGroup");
            mIncludeDebugSymbolsProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeDebugSymbolsProjectOutputGroup");
            mIncludeDocumentationProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeDocumentationProjectOutputGroup");
            mIncludeSatelliteDllsProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeSatelliteDllsProjectOutputGroup");
            mIncludeSourceFilesProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeSourceFilesProjectOutputGroup");
            mIncludeContentFilesProjectOutputGroup = new PropertyAccessor<bool?>(project, "IncludeContentFilesProjectOutputGroup");
            mIncludeSGenFilesOutputGroup = new PropertyAccessor<bool?>(project, "IncludeSGenFilesOutputGroup");
            mIncludeCopyLocalFilesOutputGroup = new PropertyAccessor<bool?>(project, "IncludeCopyLocalFilesOutputGroup");
            mIncludeComFilesOutputGroup = new PropertyAccessor<bool?>(project, "IncludeComFilesOutputGroup");
            mIncludeCustomOutputGroupForPackaging = new PropertyAccessor<bool?>(project, "IncludeCustomOutputGroupForPackaging");
            mIncludeCopyWinmdArtifactsOutputGroup = new PropertyAccessor<bool?>(project, "IncludeCopyWinmdArtifactsOutputGroup");
            mIncludeSDKRedistOutputGroup = new PropertyAccessor<bool?>(project, "IncludeSDKRedistOutputGroup");
            mIncludeGetResolvedSDKReferences = new PropertyAccessor<bool?>(project, "IncludeGetResolvedSDKReferences");
            mValidateXapFilenames = new PropertyAccessor<bool?>(project, "ValidateXapFilenames");
            mAllOutputGroupsDependsOn = new PropertyAccessor<string>(project, "AllOutputGroupsDependsOn");
            mCopyLocalFilesOutputGroupDependsOn = new PropertyAccessor<string>(project, "CopyLocalFilesOutputGroupDependsOn");
            mGetPackagingOutputsDependsOn = new PropertyAccessor<string>(project, "GetPackagingOutputsDependsOn");
            mFilterPackagingOutPutsDependsOn = new PropertyAccessor<string>(project, "FilterPackagingOutPutsDependsOn");
            m_GetPackagePropertiesDependsOn = new PropertyAccessor<string>(project, "_GetPackagePropertiesDependsOn");
            mSignToolPath = new PropertyAccessor<string>(project, "SignToolPath");
            mValidateXapFilenamesDependsOn = new PropertyAccessor<string>(project, "ValidateXapFilenamesDependsOn");
            mComputeWinMDsDependsOn = new PropertyAccessor<string>(project, "ComputeWinMDsDependsOn");
            mWMAppManifestWinMDRegistrationDependsOn = new PropertyAccessor<string>(project, "WMAppManifestWinMDRegistrationDependsOn");
            mExtMapFileValidationAsError = new PropertyAccessor<bool?>(project, "ExtMapFileValidationAsError");
            mOutOfBrowserPlusAppCachingIsSupported = new PropertyAccessor<bool?>(project, "OutOfBrowserPlusAppCachingIsSupported");
            mFrameworkRegistryBaseWithVersion = new PropertyAccessor<string>(project, "FrameworkRegistryBaseWithVersion");
            mRuntimeVersionRegistryKey = new PropertyAccessor<string>(project, "RuntimeVersionRegistryKey");
            mReferencesValidationRequiredForWindowsPhone = new PropertyAccessor<bool?>(project, "ReferencesValidationRequiredForWindowsPhone");
            mCompileXamlDependsOn = new PropertyAccessor<string>(project, "CompileXamlDependsOn");
            mValidateXamlDependsOn = new PropertyAccessor<string>(project, "ValidateXamlDependsOn");
            mXapPackagerDependsOn = new PropertyAccessor<string>(project, "XapPackagerDependsOn");
            mFilesToXapDependsOn = new PropertyAccessor<string>(project, "FilesToXapDependsOn");
            mCreateSilverlightAppManifestDependsOn = new PropertyAccessor<string>(project, "CreateSilverlightAppManifestDependsOn");
            mCategorizeSilverlightReferencesDependsOn = new PropertyAccessor<string>(project, "CategorizeSilverlightReferencesDependsOn");
            mPackagePlatformExtensionsDependsOn = new PropertyAccessor<string>(project, "PackagePlatformExtensionsDependsOn");
            mImplicitlyExpandTargetPlatform = new PropertyAccessor<bool?>(project, "ImplicitlyExpandTargetPlatform");
            mWindowsPhoneSDK_MetadataPath = new PropertyAccessor<string>(project, "WindowsPhoneSDK_MetadataPath");
            mCopyWinmdArtifactsOutputGroupDependsOn = new PropertyAccessor<string>(project, "CopyWinmdArtifactsOutputGroupDependsOn");
            mPackagesProjectConfig = new PropertyAccessor<string>(project, "PackagesProjectConfig");
            mNonInteractiveSwitch = new PropertyAccessor<string>(project, "NonInteractiveSwitch");
            mPaddedSolutionDir = new PropertyAccessor<string>(project, "PaddedSolutionDir");
            mConfigurationOverrideFile = new PropertyAccessor<string>(project, "ConfigurationOverrideFile");
            mRemoveIntegerChecks = new PropertyAccessor<bool?>(project, "RemoveIntegerChecks");
            m_DisabledWarnings = new PropertyAccessor<string>(project, "_DisabledWarnings");
            mLoadTimeSensitiveItems = new PropertyAccessor<string>(project, "LoadTimeSensitiveItems");
            mLoadTimeCheckItemLocation = new PropertyAccessor<string>(project, "LoadTimeCheckItemLocation");
            mGetRedistListsDependsOn = new PropertyAccessor<string>(project, "GetRedistListsDependsOn");
            mUnloadProjectsOnCompletion = new PropertyAccessor<bool?>(project, "UnloadProjectsOnCompletion");
            mWinFXNativePath = new PropertyAccessor<string>(project, "WinFXNativePath");
            mWinFXWowPath = new PropertyAccessor<string>(project, "WinFXWowPath");
            mTargetingClr2Framework = new PropertyAccessor<bool?>(project, "TargetingClr2Framework");
            mMSBuildManagedCompilerPath = new PropertyAccessor<string>(project, "MSBuildManagedCompilerPath");
            mRiaClientCodeGenDependsOn = new PropertyAccessor<string>(project, "RiaClientCodeGenDependsOn");
            mCoreRiaClientCodeGenDependsOn = new PropertyAccessor<string>(project, "CoreRiaClientCodeGenDependsOn");
            mRiaClientCleanDependsOn = new PropertyAccessor<string>(project, "RiaClientCleanDependsOn");
            m_RiaClientCodeGenOutputPath = new PropertyAccessor<string>(project, "_RiaClientCodeGenOutputPath");
            m_RiaClientCodeGenHistoryFile = new PropertyAccessor<string>(project, "_RiaClientCodeGenHistoryFile");
            mDefaultClientReferences = new PropertyAccessor<string>(project, "DefaultClientReferences");
            mPrepareForRiaClientCodeGenDependsOn = new PropertyAccessor<string>(project, "PrepareForRiaClientCodeGenDependsOn");
            mWindowsAppContainer = new PropertyAccessor<bool?>(project, "WindowsAppContainer");
            mSuppressWarningsInPass1 = new PropertyAccessor<bool?>(project, "SuppressWarningsInPass1");
            mTargetPlatformSdkMetadataLocation = new PropertyAccessor<string>(project, "TargetPlatformSdkMetadataLocation");
            mTargetPlatformWinMDLocation = new PropertyAccessor<string>(project, "TargetPlatformWinMDLocation");
            mAppxMSBuildToolsPath = new PropertyAccessor<string>(project, "AppxMSBuildToolsPath");
            mAppxMSBuildTaskAssembly = new PropertyAccessor<string>(project, "AppxMSBuildTaskAssembly");
            mAppxPackage = new PropertyAccessor<bool?>(project, "AppxPackage");
            mAppxUseHardlinksIfPossible = new PropertyAccessor<bool?>(project, "AppxUseHardlinksIfPossible");
            mAppxSkipUnchangedFiles = new PropertyAccessor<bool?>(project, "AppxSkipUnchangedFiles");
            mAppxGeneratePriEnabled = new PropertyAccessor<bool?>(project, "AppxGeneratePriEnabled");
            mAppxGetPackagePropertiesEnabled = new PropertyAccessor<bool?>(project, "AppxGetPackagePropertiesEnabled");
            mAppxPackageIncludePrivateSymbols = new PropertyAccessor<bool?>(project, "AppxPackageIncludePrivateSymbols");
            mAppxSymbolPackageEnabled = new PropertyAccessor<bool?>(project, "AppxSymbolPackageEnabled");
            mAppxTestLayoutEnabled = new PropertyAccessor<bool?>(project, "AppxTestLayoutEnabled");
            mAppxPackageValidationEnabled = new PropertyAccessor<bool?>(project, "AppxPackageValidationEnabled");
            mAppxHarvestWinmdRegistration = new PropertyAccessor<bool?>(project, "AppxHarvestWinmdRegistration");
            mAutoIncrementPackageRevision = new PropertyAccessor<bool?>(project, "AutoIncrementPackageRevision");
            mAppxPrependPriInitialPath = new PropertyAccessor<bool?>(project, "AppxPrependPriInitialPath");
            mEnableSigningChecks = new PropertyAccessor<bool?>(project, "EnableSigningChecks");
            mAppxStrictManifestValidationEnabled = new PropertyAccessor<bool?>(project, "AppxStrictManifestValidationEnabled");
            mAppxFilterOutUnusedLanguagesResourceFileMaps = new PropertyAccessor<bool?>(project, "AppxFilterOutUnusedLanguagesResourceFileMaps");
            mAppxGeneratePrisForPortableLibrariesEnabled = new PropertyAccessor<bool?>(project, "AppxGeneratePrisForPortableLibrariesEnabled");
            mAppxGeneratePackageRecipeEnabled = new PropertyAccessor<bool?>(project, "AppxGeneratePackageRecipeEnabled");
            m_TargetPlatformIsWindowsPhone = new PropertyAccessor<bool?>(project, "_TargetPlatformIsWindowsPhone");
            mAppxPackageSigningEnabled = new PropertyAccessor<bool?>(project, "AppxPackageSigningEnabled");
            mAppxOSMinVersion = new PropertyAccessor<string>(project, "AppxOSMinVersion");
            mAppxOSMaxVersionTested = new PropertyAccessor<string>(project, "AppxOSMaxVersionTested");
            mAppxPackageDirName = new PropertyAccessor<string>(project, "AppxPackageDirName");
            mAppxPackageDirInProjectDir = new PropertyAccessor<string>(project, "AppxPackageDirInProjectDir");
            mPlatformSpecificBundleArtifactsListDirName = new PropertyAccessor<string>(project, "PlatformSpecificBundleArtifactsListDirName");
            mPlatformSpecificBundleArtifactsListDirInProjectDir = new PropertyAccessor<string>(project, "PlatformSpecificBundleArtifactsListDirInProjectDir");
            mAppxPackageDir = new PropertyAccessor<string>(project, "AppxPackageDir");
            mAppxPackageArtifactsDir = new PropertyAccessor<string>(project, "AppxPackageArtifactsDir");
            mFinalAppxManifestName = new PropertyAccessor<string>(project, "FinalAppxManifestName");
            mAppxValidateAppxManifest = new PropertyAccessor<bool?>(project, "AppxValidateAppxManifest");
            mStoreManifestName = new PropertyAccessor<string>(project, "StoreManifestName");
            mResgenToolPath = new PropertyAccessor<string>(project, "ResgenToolPath");
            mPdbCopyExeFullPath = new PropertyAccessor<string>(project, "PdbCopyExeFullPath");
            mAppxSymbolStrippedDir = new PropertyAccessor<string>(project, "AppxSymbolStrippedDir");
            mAppxPriInitialPath = new PropertyAccessor<string>(project, "AppxPriInitialPath");
            mProjectPriFileName = new PropertyAccessor<string>(project, "ProjectPriFileName");
            mProjectPriFullPath = new PropertyAccessor<string>(project, "ProjectPriFullPath");
            mAppxPackageRecipe = new PropertyAccessor<string>(project, "AppxPackageRecipe");
            mFinalAppxPackageRecipe = new PropertyAccessor<string>(project, "FinalAppxPackageRecipe");
            mAllowLocalNetworkLoopback = new PropertyAccessor<bool?>(project, "AllowLocalNetworkLoopback");
            mAppxDefaultHashAlgorithmId = new PropertyAccessor<string>(project, "AppxDefaultHashAlgorithmId");
            mAppxPackageFileMap = new PropertyAccessor<string>(project, "AppxPackageFileMap");
            mLayoutDir = new PropertyAccessor<string>(project, "LayoutDir");
            mManagedWinmdInprocImplementation = new PropertyAccessor<string>(project, "ManagedWinmdInprocImplementation");
            mUseIncrementalAppxRegistration = new PropertyAccessor<bool?>(project, "UseIncrementalAppxRegistration");
            mAppxPackagingInfoFile = new PropertyAccessor<string>(project, "AppxPackagingInfoFile");
            mAppxOSMinVersionReplaceManifestVersion = new PropertyAccessor<bool?>(project, "AppxOSMinVersionReplaceManifestVersion");
            mAppxOSMaxVersionTestedReplaceManifestVersion = new PropertyAccessor<bool?>(project, "AppxOSMaxVersionTestedReplaceManifestVersion");
            mPackagingFileWritesLogPath = new PropertyAccessor<string>(project, "PackagingFileWritesLogPath");
            mPackagingDirectoryWritesLogPath = new PropertyAccessor<string>(project, "PackagingDirectoryWritesLogPath");
            mAppxCopyLocalFilesOutputGroupIncludeXmlFiles = new PropertyAccessor<bool?>(project, "AppxCopyLocalFilesOutputGroupIncludeXmlFiles");
            mAppxPriConfigXmlPackagingSnippetPath = new PropertyAccessor<string>(project, "AppxPriConfigXmlPackagingSnippetPath");
            mAppxPriConfigXmlDefaultSnippetPath = new PropertyAccessor<string>(project, "AppxPriConfigXmlDefaultSnippetPath");
            mTargetPlatformSdkRootOverride = new PropertyAccessor<string>(project, "TargetPlatformSdkRootOverride");
            mTargetPlatformResourceVersion = new PropertyAccessor<string>(project, "TargetPlatformResourceVersion");
            mAppxPackageExtension = new PropertyAccessor<string>(project, "AppxPackageExtension");
            mAppxSymbolPackageExtension = new PropertyAccessor<string>(project, "AppxSymbolPackageExtension");
            mAppxBundleExtension = new PropertyAccessor<string>(project, "AppxBundleExtension");
            mAppxStoreContainerExtension = new PropertyAccessor<string>(project, "AppxStoreContainerExtension");
            mAppxIntermediateExtension = new PropertyAccessor<string>(project, "AppxIntermediateExtension");
            mAppxBundle = new PropertyAccessor<string>(project, "AppxBundle");
            mAppxBundlePlatforms = new PropertyAccessor<string>(project, "AppxBundlePlatforms");
            mAppxBundleProducingPlatform = new PropertyAccessor<string>(project, "AppxBundleProducingPlatform");
            mAppxBundleResourcePacksProducingPlatform = new PropertyAccessor<string>(project, "AppxBundleResourcePacksProducingPlatform");
            mAppxLayoutFolderName = new PropertyAccessor<string>(project, "AppxLayoutFolderName");
            mAppxLayoutDir = new PropertyAccessor<string>(project, "AppxLayoutDir");
            mAppxBundlePriConfigXmlForSplittingFileName = new PropertyAccessor<string>(project, "AppxBundlePriConfigXmlForSplittingFileName");
            mAppxBundleAutoResourcePackageQualifiers = new PropertyAccessor<string>(project, "AppxBundleAutoResourcePackageQualifiers");
            mAppxBundleSplitResourcesPriPrefix = new PropertyAccessor<string>(project, "AppxBundleSplitResourcesPriPrefix");
            mAppxBundleSplitResourcesPriPath = new PropertyAccessor<string>(project, "AppxBundleSplitResourcesPriPath");
            mAppxBundleSplitResourcesGeneratedFilesListPath = new PropertyAccessor<string>(project, "AppxBundleSplitResourcesGeneratedFilesListPath");
            mAppxBundleSplitResourcesQualifiersPath = new PropertyAccessor<string>(project, "AppxBundleSplitResourcesQualifiersPath");
            mAppxBundlePriConfigXmlForMainPackageFileMapFileName = new PropertyAccessor<string>(project, "AppxBundlePriConfigXmlForMainPackageFileMapFileName");
            mAppxBundleMainPackageFileMapIntermediatePrefix = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapIntermediatePrefix");
            mAppxBundleMainPackageFileMapSuffix = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapSuffix");
            mAppxBundleMainPackageFileMapIntermediatePath = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapIntermediatePath");
            mAppxBundleMainPackageFileMapIntermediatePriPath = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapIntermediatePriPath");
            mAppxBundleMainPackageFileMapGeneratedFilesListPath = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapGeneratedFilesListPath");
            mAppxBundleMainPackageFileMapPrefix = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapPrefix");
            mAppxBundleMainPackageFileMapPath = new PropertyAccessor<string>(project, "AppxBundleMainPackageFileMapPath");
            mAppxBundleFolderSuffix = new PropertyAccessor<string>(project, "AppxBundleFolderSuffix");
            mPlatformSpecificBundleArtifactsListDir = new PropertyAccessor<string>(project, "PlatformSpecificBundleArtifactsListDir");
            mAppxDefaultResourceQualifiers_Windows_80 = new PropertyAccessor<string>(project, "AppxDefaultResourceQualifiers_Windows_80");
            mAppxDefaultResourceQualifiers_Windows_81 = new PropertyAccessor<string>(project, "AppxDefaultResourceQualifiers_Windows_81");
            mAppxDefaultResourceQualifiers_Windows_Phone = new PropertyAccessor<string>(project, "AppxDefaultResourceQualifiers_Windows_Phone");
            mAppxDefaultResourceQualifiers = new PropertyAccessor<string>(project, "AppxDefaultResourceQualifiers");
            mAppxPackageAllowDebugFrameworkReferencesInManifest = new PropertyAccessor<bool?>(project, "AppxPackageAllowDebugFrameworkReferencesInManifest");
            mInsertReverseMap = new PropertyAccessor<bool?>(project, "InsertReverseMap");
            m_ProjectPriFullPathOriginal = new PropertyAccessor<string>(project, "_ProjectPriFullPathOriginal");
            mIncludePriFilesOutputGroup = new PropertyAccessor<bool?>(project, "IncludePriFilesOutputGroup");
            mIncludeProjectPriFile = new PropertyAccessor<bool?>(project, "IncludeProjectPriFile");
            mValidatePresenceOfAppxManifestItemsDependsOn = new PropertyAccessor<string>(project, "ValidatePresenceOfAppxManifestItemsDependsOn");
            m_GenerateProjectPriFileDependsOn = new PropertyAccessor<string>(project, "_GenerateProjectPriFileDependsOn");
            m_PriConfigXmlPath = new PropertyAccessor<string>(project, "_PriConfigXmlPath");
            m_LayoutResfilesPath = new PropertyAccessor<string>(project, "_LayoutResfilesPath");
            m_ResourcesResfilesPath = new PropertyAccessor<string>(project, "_ResourcesResfilesPath");
            m_PriResfilesPath = new PropertyAccessor<string>(project, "_PriResfilesPath");
            m_QualifiersPath = new PropertyAccessor<string>(project, "_QualifiersPath");
            m_MultipleQualifiersPerDimensionFoundPath = new PropertyAccessor<string>(project, "_MultipleQualifiersPerDimensionFoundPath");
            m_ProjectArchitecturesFilePath = new PropertyAccessor<string>(project, "_ProjectArchitecturesFilePath");
            m_GenerateAppxManifestDependsOn = new PropertyAccessor<string>(project, "_GenerateAppxManifestDependsOn");
            m_GenerateAppxPackageRecipeDependsOn = new PropertyAccessor<string>(project, "_GenerateAppxPackageRecipeDependsOn");
            m_GenerateAppxPackageBaseDependsOn = new PropertyAccessor<string>(project, "_GenerateAppxPackageBaseDependsOn");
            m_GenerateAppxPackageDependsOn = new PropertyAccessor<string>(project, "_GenerateAppxPackageDependsOn");
            m_CreateAppxPackageDependsOn = new PropertyAccessor<string>(project, "_CreateAppxPackageDependsOn");
            m_CreateAppxBundlePlatformSpecificArtifactsDependsOn = new PropertyAccessor<string>(project, "_CreateAppxBundlePlatformSpecificArtifactsDependsOn");
            m_CreateAppxBundleFilesDependsOn = new PropertyAccessor<string>(project, "_CreateAppxBundleFilesDependsOn");
            mComFilesOutputGroupDependsOn = new PropertyAccessor<string>(project, "ComFilesOutputGroupDependsOn");
            mPrepareLayoutDependsOn = new PropertyAccessor<string>(project, "PrepareLayoutDependsOn");
            mRegisterAppxLayoutDependsOn = new PropertyAccessor<string>(project, "RegisterAppxLayoutDependsOn");
            mUnRegisterAppxLayoutDependsOn = new PropertyAccessor<string>(project, "UnRegisterAppxLayoutDependsOn");
            mVCInstallDir = new PropertyAccessor<string>(project, "VCInstallDir");
            mXAMLFingerprint = new PropertyAccessor<bool?>(project, "XAMLFingerprint");
            mXAMLFingerprintIgnorePaths = new PropertyAccessor<string>(project, "XAMLFingerprintIgnorePaths");
            mPriIndexName = new PropertyAccessor<string>(project, "PriIndexName");
            mOnXamlPreCompileErrorTarget = new PropertyAccessor<string>(project, "OnXamlPreCompileErrorTarget");
            mXamlShareAppDomains = new PropertyAccessor<bool?>(project, "XamlShareAppDomains");
            mXamlGeneratedOutputPath = new PropertyAccessor<string>(project, "XamlGeneratedOutputPath");
            mPrepareLibraryLayoutDependsOn = new PropertyAccessor<string>(project, "PrepareLibraryLayoutDependsOn");
            mFindInvalidProjectReferences = new PropertyAccessor<bool?>(project, "FindInvalidProjectReferences");
            mIPhoneResourcePrefix = new PropertyAccessor<string>(project, "IPhoneResourcePrefix");
            mTargetPlatformMonikerDisplayName = new PropertyAccessor<string>(project, "TargetPlatformMonikerDisplayName");
            mPortableSDKRoot = new PropertyAccessor<string>(project, "PortableSDKRoot");
            mXamlTargetPlatformVersion = new PropertyAccessor<string>(project, "XamlTargetPlatformVersion");
            mWindowsUIXamlCommonTargets = new PropertyAccessor<string>(project, "WindowsUIXamlCommonTargets");
            mImplicitlyExpandTargetPlatformDependsOn = new PropertyAccessor<string>(project, "ImplicitlyExpandTargetPlatformDependsOn");
            mDeterminePortablePlatformSdkPathDependsOn = new PropertyAccessor<string>(project, "DeterminePortablePlatformSdkPathDependsOn");
            mDeterminePortableBuildCapabilitiesDependsOn = new PropertyAccessor<string>(project, "DeterminePortableBuildCapabilitiesDependsOn");
            mTargetPlatformRootPath = new PropertyAccessor<string>(project, "TargetPlatformRootPath");
            mPackageCertificateKeyFile = new PropertyAccessor<string>(project, "PackageCertificateKeyFile");
            mAppXPackage = new PropertyAccessor<bool?>(project, "AppXPackage");
            mCleanPackageAction = new PropertyAccessor<string>(project, "CleanPackageAction");
            mPackageAction = new PropertyAccessor<string>(project, "PackageAction");
            mRebuildPackageAction = new PropertyAccessor<string>(project, "RebuildPackageAction");
            mMtouchLink = new PropertyAccessor<string>(project, "MtouchLink");
            mCodesignEntitlements = new PropertyAccessor<string>(project, "CodesignEntitlements");
            mMtouchDebug = new PropertyAccessor<bool?>(project, "MtouchDebug");
            mMtouchI18n = new PropertyAccessor<string>(project, "MtouchI18n");
            mMtouchArch = new PropertyAccessor<string>(project, "MtouchArch");
            mCodeAnalysisIgnoreBuiltInRuleSets = new PropertyAccessor<bool?>(project, "CodeAnalysisIgnoreBuiltInRuleSets");
            mCodeAnalysisIgnoreBuiltInRules = new PropertyAccessor<bool?>(project, "CodeAnalysisIgnoreBuiltInRules");
            mRunCodeAnalysis = new PropertyAccessor<bool?>(project, "RunCodeAnalysis");
            mRunCodeAnalysisOnThisProject = new PropertyAccessor<bool?>(project, "RunCodeAnalysisOnThisProject");
            mCodeAnalysisRules = new PropertyAccessor<string>(project, "CodeAnalysisRules");
            m_DeploymentSignClickOnceManifests = new PropertyAccessor<bool?>(project, "_DeploymentSignClickOnceManifests");
            mPackageCertificateThumbprint = new PropertyAccessor<string>(project, "PackageCertificateThumbprint");
            mAppxAutoIncrementPackageRevision = new PropertyAccessor<bool?>(project, "AppxAutoIncrementPackageRevision");
            mTestPageFileName = new PropertyAccessor<string>(project, "TestPageFileName");
            mProjectView = new PropertyAccessor<string>(project, "ProjectView");
            mExternalconsole = new PropertyAccessor<bool?>(project, "Externalconsole");
            mNuGetFrameworkVersion = new PropertyAccessor<string>(project, "NuGetFrameworkVersion");
            mExcludeFromPackage = new PropertyAccessor<string>(project, "ExcludeFromPackage");
            mNameOfLastUsedPublishProfile = new PropertyAccessor<string>(project, "NameOfLastUsedPublishProfile");
            mImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets");
            m_CollectFiles_IncludeIgnorableFile = new PropertyAccessor<bool?>(project, "_CollectFiles_IncludeIgnorableFile");
            mCollectFilesFromProjectFolder_ExcludeSccFiles = new PropertyAccessor<bool?>(project, "CollectFilesFromProjectFolder_ExcludeSccFiles");
            mSetExcludeFromProjectFolderDependsOn = new PropertyAccessor<string>(project, "SetExcludeFromProjectFolderDependsOn");
            mCollectFilesFromProjectFolder_ExcludeSccFilesDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromProjectFolder_ExcludeSccFilesDependsOn");
            mCollectFilesFromProjectFolderDependsOn = new PropertyAccessor<string>(project, "CollectFilesFromProjectFolderDependsOn");
            mImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets = new PropertyAccessor<bool?>(project, "ImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets");
            mNoWin32Manifest = new PropertyAccessor<bool?>(project, "NoWin32Manifest");
            mInBrowserSettingsFile = new PropertyAccessor<string>(project, "InBrowserSettingsFile");
            mRequireInBrowserElevation = new PropertyAccessor<bool?>(project, "RequireInBrowserElevation");
            mRoleType = new PropertyAccessor<string>(project, "RoleType");
            mPortableEnableXamlTargets = new PropertyAccessor<bool?>(project, "PortableEnableXamlTargets");
            mSynthesizeLinkMetadata = new PropertyAccessor<bool?>(project, "SynthesizeLinkMetadata");
            mHasSharedItems = new PropertyAccessor<bool?>(project, "HasSharedItems");
            mSharedGUID = new PropertyAccessor<string>(project, "SharedGUID");
            mImport_RootNamespace = new PropertyAccessor<string>(project, "Import_RootNamespace");
            mDisableXbfGeneration = new PropertyAccessor<bool?>(project, "DisableXbfGeneration");
            mXamlSavedStateFileName = new PropertyAccessor<string>(project, "XamlSavedStateFileName");
            mXamlSavedStateFilePath = new PropertyAccessor<string>(project, "XamlSavedStateFilePath");
            mXamlRootsLog = new PropertyAccessor<string>(project, "XamlRootsLog");
            mMarkupCompilePass1DependsOn = new PropertyAccessor<string>(project, "MarkupCompilePass1DependsOn");
            mMarkupCompilePass2DependsOn = new PropertyAccessor<string>(project, "MarkupCompilePass2DependsOn");
            mPrep_ComputeProcessXamlFilesDependsOn = new PropertyAccessor<string>(project, "Prep_ComputeProcessXamlFilesDependsOn");
            mSDKReferenceWarnOnMissingMaxPlatformVersion = new PropertyAccessor<bool?>(project, "SDKReferenceWarnOnMissingMaxPlatformVersion");
            mStartArguments = new PropertyAccessor<string>(project, "StartArguments");
            mEnableSQLServerDebugging = new PropertyAccessor<bool?>(project, "EnableSQLServerDebugging");
            mWPTestProject = new PropertyAccessor<bool?>(project, "WPTestProject");
            m_DeploymentApplicationUrl = new PropertyAccessor<string>(project, "_DeploymentApplicationUrl");
            mStartAction = new PropertyAccessor<string>(project, "StartAction");
        }


        public ItemCollection<Reference> References
        {
            get { return mReferences; }
        }

        public ItemCollection<Compile> Compiles
        {
            get { return mCompiles; }
        }

        public ItemCollection<None> Nones
        {
            get { return mNones; }
        }

        public ItemCollection<ProjectReference> ProjectReferences
        {
            get { return mProjectReferences; }
        }

        public ItemCollection<Content> Contents
        {
            get { return mContents; }
        }

        public ItemCollection<_OutputPathItem> _OutputPathItems
        {
            get { return m_OutputPathItems; }
        }

        public ItemCollection<_UnmanagedRegistrationCache> _UnmanagedRegistrationCaches
        {
            get { return m_UnmanagedRegistrationCaches; }
        }

        public ItemCollection<_ResolveComReferenceCache> _ResolveComReferenceCaches
        {
            get { return m_ResolveComReferenceCaches; }
        }

        public ItemCollection<AppConfigFileDestination> AppConfigFileDestinations
        {
            get { return mAppConfigFileDestinations; }
        }

        public ItemCollection<IntermediateAssembly> IntermediateAssemblies
        {
            get { return mIntermediateAssemblies; }
        }

        public ItemCollection<_DebugSymbolsIntermediatePath> _DebugSymbolsIntermediatePaths
        {
            get { return m_DebugSymbolsIntermediatePaths; }
        }

        public ItemCollection<_DebugSymbolsOutputPath> _DebugSymbolsOutputPaths
        {
            get { return m_DebugSymbolsOutputPaths; }
        }

        public ItemCollection<_DeploymentManifestEntryPoint> _DeploymentManifestEntryPoints
        {
            get { return m_DeploymentManifestEntryPoints; }
        }

        public ItemCollection<ApplicationManifest> ApplicationManifests
        {
            get { return mApplicationManifests; }
        }

        public ItemCollection<_ApplicationManifestFinal> _ApplicationManifestFinals
        {
            get { return m_ApplicationManifestFinals; }
        }

        public ItemCollection<DeployManifest> DeployManifests
        {
            get { return mDeployManifests; }
        }

        public ItemCollection<BuiltProjectOutputGroupKeyOutput> BuiltProjectOutputGroupKeyOutputs
        {
            get { return mBuiltProjectOutputGroupKeyOutputs; }
        }

        public ItemCollection<DebugSymbolsProjectOutputGroupOutput> DebugSymbolsProjectOutputGroupOutputs
        {
            get { return mDebugSymbolsProjectOutputGroupOutputs; }
        }

        public ItemCollection<AvailableItemName> AvailableItemNames
        {
            get { return mAvailableItemNames; }
        }

        public ItemCollection<Clean> Cleans
        {
            get { return mCleans; }
        }

        public ItemCollection<XamlBuildTaskTypeGenerationExtensionName> XamlBuildTaskTypeGenerationExtensionNames
        {
            get { return mXamlBuildTaskTypeGenerationExtensionNames; }
        }

        public ItemCollection<_ExplicitReference> _ExplicitReferences
        {
            get { return m_ExplicitReferences; }
        }

        public ItemCollection<WCFMetadata> WCFMetadatas
        {
            get { return mWCFMetadatas; }
        }

        public ItemCollection<ServiceReferenceMetadataStorage> ServiceReferenceMetadataStorages
        {
            get { return mServiceReferenceMetadataStorages; }
        }

        public ItemCollection<_WPPSupports> _WPPSupportsCollection
        {
            get { return m_WPPSupportsCollection; }
        }

        public ItemCollection<_IISApplicationPool> _IISApplicationPools
        {
            get { return m_IISApplicationPools; }
        }

        public ItemCollection<_MSDeployPackageFile> _MSDeployPackageFiles
        {
            get { return m_MSDeployPackageFiles; }
        }

        public ItemCollection<_MSDeployArchiveDir> _MSDeployArchiveDirs
        {
            get { return m_MSDeployArchiveDirs; }
        }

        public ItemCollection<_MSDeployPackageLocation> _MSDeployPackageLocations
        {
            get { return m_MSDeployPackageLocations; }
        }

        public ItemCollection<WebPublishExtnsionsToExcludeItem> WebPublishExtnsionsToExcludeItems
        {
            get { return mWebPublishExtnsionsToExcludeItems; }
        }

        public ItemCollection<Folder> Folders
        {
            get { return mFolders; }
        }

        public ItemCollection<EmbeddedResource> EmbeddedResources
        {
            get { return mEmbeddedResources; }
        }

        public ItemCollection<Service> Services
        {
            get { return mServices; }
        }

        public ItemCollection<FxCopRuleAssemblies> FxCopRuleAssemblies
        {
            get { return mFxCopRuleAssemblies; }
        }

        public ItemCollection<ApplicationDefinition> ApplicationDefinitions
        {
            get { return mApplicationDefinitions; }
        }

        public ItemCollection<TypeScriptCompile> TypeScriptCompiles
        {
            get { return mTypeScriptCompiles; }
        }

        public ItemCollection<ProjectCapability> ProjectCapabilities
        {
            get { return mProjectCapabilities; }
        }

        public ItemCollection<BootstrapperPackage> BootstrapperPackages
        {
            get { return mBootstrapperPackages; }
        }

        public ItemCollection<DocFileItem> DocFileItems
        {
            get { return mDocFileItems; }
        }

        public ItemCollection<FinalDocFile> FinalDocFiles
        {
            get { return mFinalDocFiles; }
        }

        public ItemCollection<DocumentationProjectOutputGroupOutput> DocumentationProjectOutputGroupOutputs
        {
            get { return mDocumentationProjectOutputGroupOutputs; }
        }

        public ItemCollection<Page> Pages
        {
            get { return mPages; }
        }

        public ItemCollection<Resource> Resources
        {
            get { return mResources; }
        }

        public ItemCollection<_IntermediateOutputPathItem> _IntermediateOutputPathItems
        {
            get { return m_IntermediateOutputPathItems; }
        }

        public ItemCollection<PackageSource> PackageSourcesCollection
        {
            get { return mPackageSourcesCollection; }
        }

        public ItemCollection<AppDesigner> AppDesigners
        {
            get { return mAppDesigners; }
        }

        public ItemCollection<AppxHashUri> AppxHashUris
        {
            get { return mAppxHashUris; }
        }

        public ItemCollection<AppxSystemBinary> AppxSystemBinaries
        {
            get { return mAppxSystemBinaries; }
        }

        public ItemCollection<AppxReservedFileName> AppxReservedFileNames
        {
            get { return mAppxReservedFileNames; }
        }

        public ItemCollection<AppxManifestFileNameQuery> AppxManifestFileNameQueries
        {
            get { return mAppxManifestFileNameQueries; }
        }

        public ItemCollection<AppxManifestImageFileNameQuery> AppxManifestImageFileNameQueries
        {
            get { return mAppxManifestImageFileNameQueries; }
        }

        public ItemCollection<AppxManifestMetadata> AppxManifestMetadatas
        {
            get { return mAppxManifestMetadatas; }
        }

        public ItemCollection<AppxManifestMetaData> AppxManifestMetaDatas
        {
            get { return mAppxManifestMetaDatas; }
        }

        public ItemCollection<PlatformVersionDescription> PlatformVersionDescriptions
        {
            get { return mPlatformVersionDescriptions; }
        }

        public ItemCollection<XamlIntermediateAssembly> XamlIntermediateAssemblies
        {
            get { return mXamlIntermediateAssemblies; }
        }

        public ItemCollection<SDKReference> SDKReferences
        {
            get { return mSDKReferences; }
        }

        public ItemCollection<AppxManifest> AppxManifests
        {
            get { return mAppxManifests; }
        }

        public ItemCollection<UpToDateCheckOutput> UpToDateCheckOutputs
        {
            get { return mUpToDateCheckOutputs; }
        }

        public ItemCollection<BundleResource> BundleResources
        {
            get { return mBundleResources; }
        }

        public ItemCollection<EntityDeploy> EntityDeploys
        {
            get { return mEntityDeploys; }
        }

        public ItemCollection<_DeploymentManifestIconFile> _DeploymentManifestIconFiles
        {
            get { return m_DeploymentManifestIconFiles; }
        }

        public ItemCollection<TargetPlatform> TargetPlatforms
        {
            get { return mTargetPlatforms; }
        }

        public ItemCollection<PropertyPageSchema> PropertyPageSchemas
        {
            get { return mPropertyPageSchemas; }
        }

        public ItemCollection<PackageFiles> PackageFiles
        {
            get { return mPackageFiles; }
        }

        public ItemCollection<WCFMetadataStorage> WCFMetadataStorages
        {
            get { return mWCFMetadataStorages; }
        }

        public string MSBuildToolsVersion
        {
            get { return mMSBuildToolsVersion.Value; }
            set { mMSBuildToolsVersion.Value = value; }
        }

        public string MSBuildToolsPath
        {
            get { return mMSBuildToolsPath.Value; }
            set { mMSBuildToolsPath.Value = value; }
        }

        public string MSBuildBinPath
        {
            get { return mMSBuildBinPath.Value; }
            set { mMSBuildBinPath.Value = value; }
        }

        public string MSBuildStartupDirectory
        {
            get { return mMSBuildStartupDirectory.Value; }
            set { mMSBuildStartupDirectory.Value = value; }
        }

        public int? MSBuildNodeCount
        {
            get { return mMSBuildNodeCount.Value; }
            set { mMSBuildNodeCount.Value = value; }
        }

        public string MSBuildProgramFiles32
        {
            get { return mMSBuildProgramFiles32.Value; }
            set { mMSBuildProgramFiles32.Value = value; }
        }

        public string MSBuildProjectFile
        {
            get { return mMSBuildProjectFile.Value; }
            set { mMSBuildProjectFile.Value = value; }
        }

        public string MSBuildProjectName
        {
            get { return mMSBuildProjectName.Value; }
            set { mMSBuildProjectName.Value = value; }
        }

        public string MSBuildProjectExtension
        {
            get { return mMSBuildProjectExtension.Value; }
            set { mMSBuildProjectExtension.Value = value; }
        }

        public string MSBuildProjectFullPath
        {
            get { return mMSBuildProjectFullPath.Value; }
            set { mMSBuildProjectFullPath.Value = value; }
        }

        public string MSBuildProjectDirectory
        {
            get { return mMSBuildProjectDirectory.Value; }
            set { mMSBuildProjectDirectory.Value = value; }
        }

        public string MSBuildProjectDirectoryNoRoot
        {
            get { return mMSBuildProjectDirectoryNoRoot.Value; }
            set { mMSBuildProjectDirectoryNoRoot.Value = value; }
        }

        public string MSBuildExtensionsPath32
        {
            get { return mMSBuildExtensionsPath32.Value; }
            set { mMSBuildExtensionsPath32.Value = value; }
        }

        public string MSBuildExtensionsPath64
        {
            get { return mMSBuildExtensionsPath64.Value; }
            set { mMSBuildExtensionsPath64.Value = value; }
        }

        public string MSBuildExtensionsPath
        {
            get { return mMSBuildExtensionsPath.Value; }
            set { mMSBuildExtensionsPath.Value = value; }
        }

        public string LOCALAPPDATA
        {
            get { return mLOCALAPPDATA.Value; }
            set { mLOCALAPPDATA.Value = value; }
        }

        public string MSBuildUserExtensionsPath
        {
            get { return mMSBuildUserExtensionsPath.Value; }
            set { mMSBuildUserExtensionsPath.Value = value; }
        }

        public string ALLUSERSPROFILE
        {
            get { return mALLUSERSPROFILE.Value; }
            set { mALLUSERSPROFILE.Value = value; }
        }

        public string APPDATA
        {
            get { return mAPPDATA.Value; }
            set { mAPPDATA.Value = value; }
        }

        public string CommonProgramFiles
        {
            get { return mCommonProgramFiles.Value; }
            set { mCommonProgramFiles.Value = value; }
        }

        public string CommonProgramW6432
        {
            get { return mCommonProgramW6432.Value; }
            set { mCommonProgramW6432.Value = value; }
        }

        public string COMPUTERNAME
        {
            get { return mCOMPUTERNAME.Value; }
            set { mCOMPUTERNAME.Value = value; }
        }

        public string ComSpec
        {
            get { return mComSpec.Value; }
            set { mComSpec.Value = value; }
        }

        public string configsetroot
        {
            get { return mconfigsetroot.Value; }
            set { mconfigsetroot.Value = value; }
        }

        public string FP_NO_HOST_CHECK
        {
            get { return mFP_NO_HOST_CHECK.Value; }
            set { mFP_NO_HOST_CHECK.Value = value; }
        }

        public string HOMEDRIVE
        {
            get { return mHOMEDRIVE.Value; }
            set { mHOMEDRIVE.Value = value; }
        }

        public string HOMEPATH
        {
            get { return mHOMEPATH.Value; }
            set { mHOMEPATH.Value = value; }
        }

        public string JAVA_HOME
        {
            get { return mJAVA_HOME.Value; }
            set { mJAVA_HOME.Value = value; }
        }

        public string LOGONSERVER
        {
            get { return mLOGONSERVER.Value; }
            set { mLOGONSERVER.Value = value; }
        }

        public bool? MSBuildLoadMicrosoftTargetsReadOnly
        {
            get { return mMSBuildLoadMicrosoftTargetsReadOnly.Value; }
            set { mMSBuildLoadMicrosoftTargetsReadOnly.Value = value; }
        }

        public int? NUMBER_OF_PROCESSORS
        {
            get { return mNUMBER_OF_PROCESSORS.Value; }
            set { mNUMBER_OF_PROCESSORS.Value = value; }
        }

        public string OS
        {
            get { return mOS.Value; }
            set { mOS.Value = value; }
        }

        public string Path
        {
            get { return mPath.Value; }
            set { mPath.Value = value; }
        }

        public string PATHEXT
        {
            get { return mPATHEXT.Value; }
            set { mPATHEXT.Value = value; }
        }

        public string PkgDefApplicationConfigFile
        {
            get { return mPkgDefApplicationConfigFile.Value; }
            set { mPkgDefApplicationConfigFile.Value = value; }
        }

        public string PROCESSOR_ARCHITECTURE
        {
            get { return mPROCESSOR_ARCHITECTURE.Value; }
            set { mPROCESSOR_ARCHITECTURE.Value = value; }
        }

        public string PROCESSOR_ARCHITEW6432
        {
            get { return mPROCESSOR_ARCHITEW6432.Value; }
            set { mPROCESSOR_ARCHITEW6432.Value = value; }
        }

        public string PROCESSOR_IDENTIFIER
        {
            get { return mPROCESSOR_IDENTIFIER.Value; }
            set { mPROCESSOR_IDENTIFIER.Value = value; }
        }

        public int? PROCESSOR_LEVEL
        {
            get { return mPROCESSOR_LEVEL.Value; }
            set { mPROCESSOR_LEVEL.Value = value; }
        }

        public int? PROCESSOR_REVISION
        {
            get { return mPROCESSOR_REVISION.Value; }
            set { mPROCESSOR_REVISION.Value = value; }
        }

        public string ProgramData
        {
            get { return mProgramData.Value; }
            set { mProgramData.Value = value; }
        }

        public string ProgramFiles
        {
            get { return mProgramFiles.Value; }
            set { mProgramFiles.Value = value; }
        }

        public string ProgramW6432
        {
            get { return mProgramW6432.Value; }
            set { mProgramW6432.Value = value; }
        }

        public string PSModulePath
        {
            get { return mPSModulePath.Value; }
            set { mPSModulePath.Value = value; }
        }

        public string PUBLIC
        {
            get { return mPUBLIC.Value; }
            set { mPUBLIC.Value = value; }
        }

        public string SystemDrive
        {
            get { return mSystemDrive.Value; }
            set { mSystemDrive.Value = value; }
        }

        public string SystemRoot
        {
            get { return mSystemRoot.Value; }
            set { mSystemRoot.Value = value; }
        }

        public string TEMP
        {
            get { return mTEMP.Value; }
            set { mTEMP.Value = value; }
        }

        public string TMP
        {
            get { return mTMP.Value; }
            set { mTMP.Value = value; }
        }

        public string UOIPME_REG_PATH
        {
            get { return mUOIPME_REG_PATH.Value; }
            set { mUOIPME_REG_PATH.Value = value; }
        }

        public string USERDOMAIN
        {
            get { return mUSERDOMAIN.Value; }
            set { mUSERDOMAIN.Value = value; }
        }

        public string USERDOMAIN_ROAMINGPROFILE
        {
            get { return mUSERDOMAIN_ROAMINGPROFILE.Value; }
            set { mUSERDOMAIN_ROAMINGPROFILE.Value = value; }
        }

        public string USERNAME
        {
            get { return mUSERNAME.Value; }
            set { mUSERNAME.Value = value; }
        }

        public string USERPROFILE
        {
            get { return mUSERPROFILE.Value; }
            set { mUSERPROFILE.Value = value; }
        }

        public string VisualStudioDir
        {
            get { return mVisualStudioDir.Value; }
            set { mVisualStudioDir.Value = value; }
        }

        public string VisualStudioEdition
        {
            get { return mVisualStudioEdition.Value; }
            set { mVisualStudioEdition.Value = value; }
        }

        public string VisualStudioVersion
        {
            get { return mVisualStudioVersion.Value; }
            set { mVisualStudioVersion.Value = value; }
        }

        public string VS110COMNTOOLS
        {
            get { return mVS110COMNTOOLS.Value; }
            set { mVS110COMNTOOLS.Value = value; }
        }

        public string VS120COMNTOOLS
        {
            get { return mVS120COMNTOOLS.Value; }
            set { mVS120COMNTOOLS.Value = value; }
        }

        public string VS140COMNTOOLS
        {
            get { return mVS140COMNTOOLS.Value; }
            set { mVS140COMNTOOLS.Value = value; }
        }

        public int? VSLANG
        {
            get { return mVSLANG.Value; }
            set { mVSLANG.Value = value; }
        }

        public string windir
        {
            get { return mwindir.Value; }
            set { mwindir.Value = value; }
        }

        public string SDK35ToolsPath
        {
            get { return mSDK35ToolsPath.Value; }
            set { mSDK35ToolsPath.Value = value; }
        }

        public string MSBuildToolsPath32
        {
            get { return mMSBuildToolsPath32.Value; }
            set { mMSBuildToolsPath32.Value = value; }
        }

        public string MSBuildToolsRoot
        {
            get { return mMSBuildToolsRoot.Value; }
            set { mMSBuildToolsRoot.Value = value; }
        }

        public string FrameworkSDKRoot
        {
            get { return mFrameworkSDKRoot.Value; }
            set { mFrameworkSDKRoot.Value = value; }
        }

        public string MSBuildRuntimeVersion
        {
            get { return mMSBuildRuntimeVersion.Value; }
            set { mMSBuildRuntimeVersion.Value = value; }
        }

        public string SDK40ToolsPath
        {
            get { return mSDK40ToolsPath.Value; }
            set { mSDK40ToolsPath.Value = value; }
        }

        public string Configuration
        {
            get { return mConfiguration.Value; }
            set { mConfiguration.Value = value; }
        }

        public string MSBuildProjectDefaultTargets
        {
            get { return mMSBuildProjectDefaultTargets.Value; }
            set { mMSBuildProjectDefaultTargets.Value = value; }
        }

        public string Platform
        {
            get { return mPlatform.Value; }
            set { mPlatform.Value = value; }
        }

        public string ProjectGuid
        {
            get { return mProjectGuid.Value; }
            set { mProjectGuid.Value = value; }
        }

        public string OutputType
        {
            get { return mOutputType.Value; }
            set { mOutputType.Value = value; }
        }

        public string AppDesignerFolder
        {
            get { return mAppDesignerFolder.Value; }
            set { mAppDesignerFolder.Value = value; }
        }

        public string RootNamespace
        {
            get { return mRootNamespace.Value; }
            set { mRootNamespace.Value = value; }
        }

        public string AssemblyName
        {
            get { return mAssemblyName.Value; }
            set { mAssemblyName.Value = value; }
        }

        public string TargetFrameworkVersion
        {
            get { return mTargetFrameworkVersion.Value; }
            set { mTargetFrameworkVersion.Value = value; }
        }

        public int? FileAlignment
        {
            get { return mFileAlignment.Value; }
            set { mFileAlignment.Value = value; }
        }

        public string SolutionDir
        {
            get { return mSolutionDir.Value; }
            set { mSolutionDir.Value = value; }
        }

        public bool? RestorePackages
        {
            get { return mRestorePackages.Value; }
            set { mRestorePackages.Value = value; }
        }

        public string PlatformTarget
        {
            get { return mPlatformTarget.Value; }
            set { mPlatformTarget.Value = value; }
        }

        public bool? DebugSymbols
        {
            get { return mDebugSymbols.Value; }
            set { mDebugSymbols.Value = value; }
        }

        public string DebugType
        {
            get { return mDebugType.Value; }
            set { mDebugType.Value = value; }
        }

        public bool? Optimize
        {
            get { return mOptimize.Value; }
            set { mOptimize.Value = value; }
        }

        public string OutputPath
        {
            get { return mOutputPath.Value; }
            set { mOutputPath.Value = value; }
        }

        public string DefineConstants
        {
            get { return mDefineConstants.Value; }
            set { mDefineConstants.Value = value; }
        }

        public string ErrorReport
        {
            get { return mErrorReport.Value; }
            set { mErrorReport.Value = value; }
        }

        public int? WarningLevel
        {
            get { return mWarningLevel.Value; }
            set { mWarningLevel.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftCSharpTargets
        {
            get { return mImportByWildcardBeforeMicrosoftCSharpTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftCSharpTargets
        {
            get { return mImportByWildcardAfterMicrosoftCSharpTargets.Value; }
            set { mImportByWildcardAfterMicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets
        {
            get { return mImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets.Value; }
            set { mImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets
        {
            get { return mImportUserLocationsByWildcardAfterMicrosoftCSharpTargets.Value; }
            set { mImportUserLocationsByWildcardAfterMicrosoftCSharpTargets.Value = value; }
        }

        public string CustomBeforeMicrosoftCSharpTargets
        {
            get { return mCustomBeforeMicrosoftCSharpTargets.Value; }
            set { mCustomBeforeMicrosoftCSharpTargets.Value = value; }
        }

        public string CustomAfterMicrosoftCSharpTargets
        {
            get { return mCustomAfterMicrosoftCSharpTargets.Value; }
            set { mCustomAfterMicrosoftCSharpTargets.Value = value; }
        }

        public string MSBuildAllProjects
        {
            get { return mMSBuildAllProjects.Value; }
            set { mMSBuildAllProjects.Value = value; }
        }

        public string DefaultLanguageSourceExtension
        {
            get { return mDefaultLanguageSourceExtension.Value; }
            set { mDefaultLanguageSourceExtension.Value = value; }
        }

        public string Language
        {
            get { return mLanguage.Value; }
            set { mLanguage.Value = value; }
        }

        public string TargetRuntime
        {
            get { return mTargetRuntime.Value; }
            set { mTargetRuntime.Value = value; }
        }

        public string CreateManifestResourceNamesDependsOn
        {
            get { return mCreateManifestResourceNamesDependsOn.Value; }
            set { mCreateManifestResourceNamesDependsOn.Value = value; }
        }

        public bool? UseHostCompilerIfAvailable
        {
            get { return mUseHostCompilerIfAvailable.Value; }
            set { mUseHostCompilerIfAvailable.Value = value; }
        }

        public string CoreCompileDependsOn
        {
            get { return mCoreCompileDependsOn.Value; }
            set { mCoreCompileDependsOn.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftCommonTargets
        {
            get { return mImportByWildcardBeforeMicrosoftCommonTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftCommonTargets
        {
            get { return mImportByWildcardAfterMicrosoftCommonTargets.Value; }
            set { mImportByWildcardAfterMicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets
        {
            get { return mImportUserLocationsByWildcardBeforeMicrosoftCommonTargets.Value; }
            set { mImportUserLocationsByWildcardBeforeMicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftCommonTargets
        {
            get { return mImportUserLocationsByWildcardAfterMicrosoftCommonTargets.Value; }
            set { mImportUserLocationsByWildcardAfterMicrosoftCommonTargets.Value = value; }
        }

        public string CustomBeforeMicrosoftCommonTargets
        {
            get { return mCustomBeforeMicrosoftCommonTargets.Value; }
            set { mCustomBeforeMicrosoftCommonTargets.Value = value; }
        }

        public string CustomAfterMicrosoftCommonTargets
        {
            get { return mCustomAfterMicrosoftCommonTargets.Value; }
            set { mCustomAfterMicrosoftCommonTargets.Value = value; }
        }

        public string ReportingServicesTargets
        {
            get { return mReportingServicesTargets.Value; }
            set { mReportingServicesTargets.Value = value; }
        }

        public string TargetFrameworkIdentifier
        {
            get { return mTargetFrameworkIdentifier.Value; }
            set { mTargetFrameworkIdentifier.Value = value; }
        }

        public string AvailablePlatforms
        {
            get { return mAvailablePlatforms.Value; }
            set { mAvailablePlatforms.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftNetFrameworkProps
        {
            get { return mImportByWildcardBeforeMicrosoftNetFrameworkProps.Value; }
            set { mImportByWildcardBeforeMicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftNetFrameworkProps
        {
            get { return mImportByWildcardAfterMicrosoftNetFrameworkProps.Value; }
            set { mImportByWildcardAfterMicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps
        {
            get { return mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps.Value; }
            set { mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps
        {
            get { return mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps.Value; }
            set { mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? UpgradeSubsetToProfile
        {
            get { return mUpgradeSubsetToProfile.Value; }
            set { mUpgradeSubsetToProfile.Value = value; }
        }

        public bool? AddAdditionalExplicitAssemblyReferences
        {
            get { return mAddAdditionalExplicitAssemblyReferences.Value; }
            set { mAddAdditionalExplicitAssemblyReferences.Value = value; }
        }

        public string AdditionalExplicitAssemblyReferences
        {
            get { return mAdditionalExplicitAssemblyReferences.Value; }
            set { mAdditionalExplicitAssemblyReferences.Value = value; }
        }

        public string TargetFrameworkSDKToolsDirectory
        {
            get { return mTargetFrameworkSDKToolsDirectory.Value; }
            set { mTargetFrameworkSDKToolsDirectory.Value = value; }
        }

        public string TargetedRuntimeVersion
        {
            get { return mTargetedRuntimeVersion.Value; }
            set { mTargetedRuntimeVersion.Value = value; }
        }

        public bool? Prefer32Bit
        {
            get { return mPrefer32Bit.Value; }
            set { mPrefer32Bit.Value = value; }
        }

        public bool? HighEntropyVA
        {
            get { return mHighEntropyVA.Value; }
            set { mHighEntropyVA.Value = value; }
        }

        public string SubsystemVersion
        {
            get { return mSubsystemVersion.Value; }
            set { mSubsystemVersion.Value = value; }
        }

        public bool? ImplicitlyExpandDesignTimeFacades
        {
            get { return mImplicitlyExpandDesignTimeFacades.Value; }
            set { mImplicitlyExpandDesignTimeFacades.Value = value; }
        }

        public bool? YieldDuringToolExecution
        {
            get { return mYieldDuringToolExecution.Value; }
            set { mYieldDuringToolExecution.Value = value; }
        }

        public string TargetFrameworkMoniker
        {
            get { return mTargetFrameworkMoniker.Value; }
            set { mTargetFrameworkMoniker.Value = value; }
        }

        public string FrameworkPathOverride
        {
            get { return mFrameworkPathOverride.Value; }
            set { mFrameworkPathOverride.Value = value; }
        }

        public string TargetPlatformIdentifier
        {
            get { return mTargetPlatformIdentifier.Value; }
            set { mTargetPlatformIdentifier.Value = value; }
        }

        public string TargetPlatformVersion
        {
            get { return mTargetPlatformVersion.Value; }
            set { mTargetPlatformVersion.Value = value; }
        }

        public string TargetPlatformSdkPath
        {
            get { return mTargetPlatformSdkPath.Value; }
            set { mTargetPlatformSdkPath.Value = value; }
        }

        public string TargetPlatformMoniker
        {
            get { return mTargetPlatformMoniker.Value; }
            set { mTargetPlatformMoniker.Value = value; }
        }

        public string _OriginalConfiguration
        {
            get { return m_OriginalConfiguration.Value; }
            set { m_OriginalConfiguration.Value = value; }
        }

        public string _OriginalPlatform
        {
            get { return m_OriginalPlatform.Value; }
            set { m_OriginalPlatform.Value = value; }
        }

        public string ConfigurationName
        {
            get { return mConfigurationName.Value; }
            set { mConfigurationName.Value = value; }
        }

        public bool? _DebugSymbolsProduced
        {
            get { return m_DebugSymbolsProduced.Value; }
            set { m_DebugSymbolsProduced.Value = value; }
        }

        public bool? _DocumentationFileProduced
        {
            get { return m_DocumentationFileProduced.Value; }
            set { m_DocumentationFileProduced.Value = value; }
        }

        public string TargetExt
        {
            get { return mTargetExt.Value; }
            set { mTargetExt.Value = value; }
        }

        public string OutDir
        {
            get { return mOutDir.Value; }
            set { mOutDir.Value = value; }
        }

        public string ProjectName
        {
            get { return mProjectName.Value; }
            set { mProjectName.Value = value; }
        }

        public string TargetName
        {
            get { return mTargetName.Value; }
            set { mTargetName.Value = value; }
        }

        public string ProjectFileName
        {
            get { return mProjectFileName.Value; }
            set { mProjectFileName.Value = value; }
        }

        public string ProjectExt
        {
            get { return mProjectExt.Value; }
            set { mProjectExt.Value = value; }
        }

        public string TargetFileName
        {
            get { return mTargetFileName.Value; }
            set { mTargetFileName.Value = value; }
        }

        public bool? _DeploymentPublishableProjectDefault
        {
            get { return m_DeploymentPublishableProjectDefault.Value; }
            set { m_DeploymentPublishableProjectDefault.Value = value; }
        }

        public string PublishableProject
        {
            get { return mPublishableProject.Value; }
            set { mPublishableProject.Value = value; }
        }

        public string _DeploymentTargetApplicationManifestFileName
        {
            get { return m_DeploymentTargetApplicationManifestFileName.Value; }
            set { m_DeploymentTargetApplicationManifestFileName.Value = value; }
        }

        public string TargetDeployManifestFileName
        {
            get { return mTargetDeployManifestFileName.Value; }
            set { mTargetDeployManifestFileName.Value = value; }
        }

        public string GenerateClickOnceManifests
        {
            get { return mGenerateClickOnceManifests.Value; }
            set { mGenerateClickOnceManifests.Value = value; }
        }

        public string _DeploymentApplicationManifestIdentity
        {
            get { return m_DeploymentApplicationManifestIdentity.Value; }
            set { m_DeploymentApplicationManifestIdentity.Value = value; }
        }

        public string _DeploymentDeployManifestIdentity
        {
            get { return m_DeploymentDeployManifestIdentity.Value; }
            set { m_DeploymentDeployManifestIdentity.Value = value; }
        }

        public string _DeploymentFileMappingExtension
        {
            get { return m_DeploymentFileMappingExtension.Value; }
            set { m_DeploymentFileMappingExtension.Value = value; }
        }

        public int? _DeploymentBuiltUpdateInterval
        {
            get { return m_DeploymentBuiltUpdateInterval.Value; }
            set { m_DeploymentBuiltUpdateInterval.Value = value; }
        }

        public string _DeploymentBuiltUpdateIntervalUnits
        {
            get { return m_DeploymentBuiltUpdateIntervalUnits.Value; }
            set { m_DeploymentBuiltUpdateIntervalUnits.Value = value; }
        }

        public int? MaxTargetPath
        {
            get { return mMaxTargetPath.Value; }
            set { mMaxTargetPath.Value = value; }
        }

        public string TargetCulture
        {
            get { return mTargetCulture.Value; }
            set { mTargetCulture.Value = value; }
        }

        public string TargetDir
        {
            get { return mTargetDir.Value; }
            set { mTargetDir.Value = value; }
        }

        public string TargetPath
        {
            get { return mTargetPath.Value; }
            set { mTargetPath.Value = value; }
        }

        public string ProjectDir
        {
            get { return mProjectDir.Value; }
            set { mProjectDir.Value = value; }
        }

        public string ProjectPath
        {
            get { return mProjectPath.Value; }
            set { mProjectPath.Value = value; }
        }

        public string PlatformName
        {
            get { return mPlatformName.Value; }
            set { mPlatformName.Value = value; }
        }

        public string DevEnvDir
        {
            get { return mDevEnvDir.Value; }
            set { mDevEnvDir.Value = value; }
        }

        public string SolutionName
        {
            get { return mSolutionName.Value; }
            set { mSolutionName.Value = value; }
        }

        public string SolutionFileName
        {
            get { return mSolutionFileName.Value; }
            set { mSolutionFileName.Value = value; }
        }

        public string SolutionPath
        {
            get { return mSolutionPath.Value; }
            set { mSolutionPath.Value = value; }
        }

        public string SolutionExt
        {
            get { return mSolutionExt.Value; }
            set { mSolutionExt.Value = value; }
        }

        public bool? AutoUnifyAssemblyReferences
        {
            get { return mAutoUnifyAssemblyReferences.Value; }
            set { mAutoUnifyAssemblyReferences.Value = value; }
        }

        public string BaseIntermediateOutputPath
        {
            get { return mBaseIntermediateOutputPath.Value; }
            set { mBaseIntermediateOutputPath.Value = value; }
        }

        public string CleanFile
        {
            get { return mCleanFile.Value; }
            set { mCleanFile.Value = value; }
        }

        public bool? BuildProjectReferences
        {
            get { return mBuildProjectReferences.Value; }
            set { mBuildProjectReferences.Value = value; }
        }

        public bool? BuildInParallel
        {
            get { return mBuildInParallel.Value; }
            set { mBuildInParallel.Value = value; }
        }

        public bool? _ResolveReferenceDependencies
        {
            get { return m_ResolveReferenceDependencies.Value; }
            set { m_ResolveReferenceDependencies.Value = value; }
        }

        public bool? _GetChildProjectCopyToOutputDirectoryItems
        {
            get { return m_GetChildProjectCopyToOutputDirectoryItems.Value; }
            set { m_GetChildProjectCopyToOutputDirectoryItems.Value = value; }
        }

        public bool? OverwriteReadOnlyFiles
        {
            get { return mOverwriteReadOnlyFiles.Value; }
            set { mOverwriteReadOnlyFiles.Value = value; }
        }

        public bool? ComReferenceNoClassMembers
        {
            get { return mComReferenceNoClassMembers.Value; }
            set { mComReferenceNoClassMembers.Value = value; }
        }

        public string IntermediateOutputPath
        {
            get { return mIntermediateOutputPath.Value; }
            set { mIntermediateOutputPath.Value = value; }
        }

        public string _DeploymentUrl
        {
            get { return m_DeploymentUrl.Value; }
            set { m_DeploymentUrl.Value = value; }
        }

        public string PublishDir
        {
            get { return mPublishDir.Value; }
            set { mPublishDir.Value = value; }
        }

        public string ProcessorArchitecture
        {
            get { return mProcessorArchitecture.Value; }
            set { mProcessorArchitecture.Value = value; }
        }

        public bool? ConsiderPlatformAsProcessorArchitecture
        {
            get { return mConsiderPlatformAsProcessorArchitecture.Value; }
            set { mConsiderPlatformAsProcessorArchitecture.Value = value; }
        }

        public string TargetFrameworkAsMSBuildRuntime
        {
            get { return mTargetFrameworkAsMSBuildRuntime.Value; }
            set { mTargetFrameworkAsMSBuildRuntime.Value = value; }
        }

        public bool? PlatformTargetAsMSBuildArchitectureExplicitlySet
        {
            get { return mPlatformTargetAsMSBuildArchitectureExplicitlySet.Value; }
            set { mPlatformTargetAsMSBuildArchitectureExplicitlySet.Value = value; }
        }

        public string PlatformTargetAsMSBuildArchitecture
        {
            get { return mPlatformTargetAsMSBuildArchitecture.Value; }
            set { mPlatformTargetAsMSBuildArchitecture.Value = value; }
        }

        public string ProjectFlavor
        {
            get { return mProjectFlavor.Value; }
            set { mProjectFlavor.Value = value; }
        }

        public string DelaySign
        {
            get { return mDelaySign.Value; }
            set { mDelaySign.Value = value; }
        }

        public bool? WebReference_EnableProperties
        {
            get { return mWebReference_EnableProperties.Value; }
            set { mWebReference_EnableProperties.Value = value; }
        }

        public bool? WebReference_EnableSQLTypes
        {
            get { return mWebReference_EnableSQLTypes.Value; }
            set { mWebReference_EnableSQLTypes.Value = value; }
        }

        public bool? WebReference_EnableLegacyEventingModel
        {
            get { return mWebReference_EnableLegacyEventingModel.Value; }
            set { mWebReference_EnableLegacyEventingModel.Value = value; }
        }

        public string AssemblyFoldersSuffix
        {
            get { return mAssemblyFoldersSuffix.Value; }
            set { mAssemblyFoldersSuffix.Value = value; }
        }

        public string FrameworkRegistryBase
        {
            get { return mFrameworkRegistryBase.Value; }
            set { mFrameworkRegistryBase.Value = value; }
        }

        public string TargetPlatformRegistryBase
        {
            get { return mTargetPlatformRegistryBase.Value; }
            set { mTargetPlatformRegistryBase.Value = value; }
        }

        public string AssemblySearchPaths
        {
            get { return mAssemblySearchPaths.Value; }
            set { mAssemblySearchPaths.Value = value; }
        }

        public string AllowedReferenceAssemblyFileExtensions
        {
            get { return mAllowedReferenceAssemblyFileExtensions.Value; }
            set { mAllowedReferenceAssemblyFileExtensions.Value = value; }
        }

        public string AllowedReferenceRelatedFileExtensions
        {
            get { return mAllowedReferenceRelatedFileExtensions.Value; }
            set { mAllowedReferenceRelatedFileExtensions.Value = value; }
        }

        public string FullReferenceAssemblyNames
        {
            get { return mFullReferenceAssemblyNames.Value; }
            set { mFullReferenceAssemblyNames.Value = value; }
        }

        public bool? ContinueOnError
        {
            get { return mContinueOnError.Value; }
            set { mContinueOnError.Value = value; }
        }

        public string BuildDependsOn
        {
            get { return mBuildDependsOn.Value; }
            set { mBuildDependsOn.Value = value; }
        }

        public string CoreBuildDependsOn
        {
            get { return mCoreBuildDependsOn.Value; }
            set { mCoreBuildDependsOn.Value = value; }
        }

        public string _ProjectDefaultTargets
        {
            get { return m_ProjectDefaultTargets.Value; }
            set { m_ProjectDefaultTargets.Value = value; }
        }

        public string RebuildDependsOn
        {
            get { return mRebuildDependsOn.Value; }
            set { mRebuildDependsOn.Value = value; }
        }

        public string BuildGenerateSourcesAction
        {
            get { return mBuildGenerateSourcesAction.Value; }
            set { mBuildGenerateSourcesAction.Value = value; }
        }

        public string BuildCompileAction
        {
            get { return mBuildCompileAction.Value; }
            set { mBuildCompileAction.Value = value; }
        }

        public string BuildLinkAction
        {
            get { return mBuildLinkAction.Value; }
            set { mBuildLinkAction.Value = value; }
        }

        public string RunDependsOn
        {
            get { return mRunDependsOn.Value; }
            set { mRunDependsOn.Value = value; }
        }

        public bool? BuildingProject
        {
            get { return mBuildingProject.Value; }
            set { mBuildingProject.Value = value; }
        }

        public string PrepareForBuildDependsOn
        {
            get { return mPrepareForBuildDependsOn.Value; }
            set { mPrepareForBuildDependsOn.Value = value; }
        }

        public string Framework40Dir
        {
            get { return mFramework40Dir.Value; }
            set { mFramework40Dir.Value = value; }
        }

        public string Framework35Dir
        {
            get { return mFramework35Dir.Value; }
            set { mFramework35Dir.Value = value; }
        }

        public string Framework30Dir
        {
            get { return mFramework30Dir.Value; }
            set { mFramework30Dir.Value = value; }
        }

        public string Framework20Dir
        {
            get { return mFramework20Dir.Value; }
            set { mFramework20Dir.Value = value; }
        }

        public string FrameworkDir
        {
            get { return mFrameworkDir.Value; }
            set { mFrameworkDir.Value = value; }
        }

        public string TargetedFrameworkDir
        {
            get { return mTargetedFrameworkDir.Value; }
            set { mTargetedFrameworkDir.Value = value; }
        }

        public string FrameworkSDKDir
        {
            get { return mFrameworkSDKDir.Value; }
            set { mFrameworkSDKDir.Value = value; }
        }

        public string GetFrameworkPathsDependsOn
        {
            get { return mGetFrameworkPathsDependsOn.Value; }
            set { mGetFrameworkPathsDependsOn.Value = value; }
        }

        public string PreBuildEventDependsOn
        {
            get { return mPreBuildEventDependsOn.Value; }
            set { mPreBuildEventDependsOn.Value = value; }
        }

        public string UnmanagedUnregistrationDependsOn
        {
            get { return mUnmanagedUnregistrationDependsOn.Value; }
            set { mUnmanagedUnregistrationDependsOn.Value = value; }
        }

        public string ResolveReferencesDependsOn
        {
            get { return mResolveReferencesDependsOn.Value; }
            set { mResolveReferencesDependsOn.Value = value; }
        }

        public string GetTargetPathDependsOn
        {
            get { return mGetTargetPathDependsOn.Value; }
            set { mGetTargetPathDependsOn.Value = value; }
        }

        public string ResolveAssemblyReferencesDependsOn
        {
            get { return mResolveAssemblyReferencesDependsOn.Value; }
            set { mResolveAssemblyReferencesDependsOn.Value = value; }
        }

        public string SDKReferenceRegistryRoot
        {
            get { return mSDKReferenceRegistryRoot.Value; }
            set { mSDKReferenceRegistryRoot.Value = value; }
        }

        public string SDKReferenceDirectoryRoot
        {
            get { return mSDKReferenceDirectoryRoot.Value; }
            set { mSDKReferenceDirectoryRoot.Value = value; }
        }

        public string ResolveSDKReferencesDependsOn
        {
            get { return mResolveSDKReferencesDependsOn.Value; }
            set { mResolveSDKReferencesDependsOn.Value = value; }
        }

        public string TargetedSDKConfiguration
        {
            get { return mTargetedSDKConfiguration.Value; }
            set { mTargetedSDKConfiguration.Value = value; }
        }

        public string TargetedSDKArchitecture
        {
            get { return mTargetedSDKArchitecture.Value; }
            set { mTargetedSDKArchitecture.Value = value; }
        }

        public string ExpandSDKReferencesDependsOn
        {
            get { return mExpandSDKReferencesDependsOn.Value; }
            set { mExpandSDKReferencesDependsOn.Value = value; }
        }

        public string ExpandSDKAllowedReferenceExtensions
        {
            get { return mExpandSDKAllowedReferenceExtensions.Value; }
            set { mExpandSDKAllowedReferenceExtensions.Value = value; }
        }

        public string ProjectDesignTimeAssemblyResolutionSearchPaths
        {
            get { return mProjectDesignTimeAssemblyResolutionSearchPaths.Value; }
            set { mProjectDesignTimeAssemblyResolutionSearchPaths.Value = value; }
        }

        public string DesignTimeResolveAssemblyReferencesDependsOn
        {
            get { return mDesignTimeResolveAssemblyReferencesDependsOn.Value; }
            set { mDesignTimeResolveAssemblyReferencesDependsOn.Value = value; }
        }

        public bool? ComReferenceExecuteAsTool
        {
            get { return mComReferenceExecuteAsTool.Value; }
            set { mComReferenceExecuteAsTool.Value = value; }
        }

        public string PrepareResourcesDependsOn
        {
            get { return mPrepareResourcesDependsOn.Value; }
            set { mPrepareResourcesDependsOn.Value = value; }
        }

        public string PrepareResourceNamesDependsOn
        {
            get { return mPrepareResourceNamesDependsOn.Value; }
            set { mPrepareResourceNamesDependsOn.Value = value; }
        }

        public string AssignTargetPathsDependsOn
        {
            get { return mAssignTargetPathsDependsOn.Value; }
            set { mAssignTargetPathsDependsOn.Value = value; }
        }

        public string CreateCustomManifestResourceNamesDependsOn
        {
            get { return mCreateCustomManifestResourceNamesDependsOn.Value; }
            set { mCreateCustomManifestResourceNamesDependsOn.Value = value; }
        }

        public string ResGenDependsOn
        {
            get { return mResGenDependsOn.Value; }
            set { mResGenDependsOn.Value = value; }
        }

        public string CoreResGenDependsOn
        {
            get { return mCoreResGenDependsOn.Value; }
            set { mCoreResGenDependsOn.Value = value; }
        }

        public bool? UseSourcePath
        {
            get { return mUseSourcePath.Value; }
            set { mUseSourcePath.Value = value; }
        }

        public bool? ResGenExecuteAsTool
        {
            get { return mResGenExecuteAsTool.Value; }
            set { mResGenExecuteAsTool.Value = value; }
        }

        public string CompileLicxFilesDependsOn
        {
            get { return mCompileLicxFilesDependsOn.Value; }
            set { mCompileLicxFilesDependsOn.Value = value; }
        }

        public string CompileDependsOn
        {
            get { return mCompileDependsOn.Value; }
            set { mCompileDependsOn.Value = value; }
        }

        public string TargetFrameworkMonikerAssemblyAttributesPath
        {
            get { return mTargetFrameworkMonikerAssemblyAttributesPath.Value; }
            set { mTargetFrameworkMonikerAssemblyAttributesPath.Value = value; }
        }

        public bool? GenerateTargetFrameworkAttribute
        {
            get { return mGenerateTargetFrameworkAttribute.Value; }
            set { mGenerateTargetFrameworkAttribute.Value = value; }
        }

        public string _SGenDllName
        {
            get { return m_SGenDllName.Value; }
            set { m_SGenDllName.Value = value; }
        }

        public bool? _SGenDllCreated
        {
            get { return m_SGenDllCreated.Value; }
            set { m_SGenDllCreated.Value = value; }
        }

        public string _SGenGenerateSerializationAssembliesConfig
        {
            get { return m_SGenGenerateSerializationAssembliesConfig.Value; }
            set { m_SGenGenerateSerializationAssembliesConfig.Value = value; }
        }

        public bool? SGenUseProxyTypes
        {
            get { return mSGenUseProxyTypes.Value; }
            set { mSGenUseProxyTypes.Value = value; }
        }

        public bool? SGenShouldGenerateSerializer
        {
            get { return mSGenShouldGenerateSerializer.Value; }
            set { mSGenShouldGenerateSerializer.Value = value; }
        }

        public string CreateSatelliteAssembliesDependsOn
        {
            get { return mCreateSatelliteAssembliesDependsOn.Value; }
            set { mCreateSatelliteAssembliesDependsOn.Value = value; }
        }

        public string ComputeIntermediateSatelliteAssembliesDependsOn
        {
            get { return mComputeIntermediateSatelliteAssembliesDependsOn.Value; }
            set { mComputeIntermediateSatelliteAssembliesDependsOn.Value = value; }
        }

        public string EmbeddedWin32Manifest
        {
            get { return mEmbeddedWin32Manifest.Value; }
            set { mEmbeddedWin32Manifest.Value = value; }
        }

        public string GenerateManifestsDependsOn
        {
            get { return mGenerateManifestsDependsOn.Value; }
            set { mGenerateManifestsDependsOn.Value = value; }
        }

        public bool? SkipCopyUnchangedFiles
        {
            get { return mSkipCopyUnchangedFiles.Value; }
            set { mSkipCopyUnchangedFiles.Value = value; }
        }

        public bool? UseCommonOutputDirectory
        {
            get { return mUseCommonOutputDirectory.Value; }
            set { mUseCommonOutputDirectory.Value = value; }
        }

        public string PrepareForRunDependsOn
        {
            get { return mPrepareForRunDependsOn.Value; }
            set { mPrepareForRunDependsOn.Value = value; }
        }

        public bool? CreateHardLinksForCopyAdditionalFilesIfPossible
        {
            get { return mCreateHardLinksForCopyAdditionalFilesIfPossible.Value; }
            set { mCreateHardLinksForCopyAdditionalFilesIfPossible.Value = value; }
        }

        public string GetCopyToOutputDirectoryItemsDependsOn
        {
            get { return mGetCopyToOutputDirectoryItemsDependsOn.Value; }
            set { mGetCopyToOutputDirectoryItemsDependsOn.Value = value; }
        }

        public string UnmanagedRegistrationDependsOn
        {
            get { return mUnmanagedRegistrationDependsOn.Value; }
            set { mUnmanagedRegistrationDependsOn.Value = value; }
        }

        public string CleanDependsOn
        {
            get { return mCleanDependsOn.Value; }
            set { mCleanDependsOn.Value = value; }
        }

        public string CoreCleanDependsOn
        {
            get { return mCoreCleanDependsOn.Value; }
            set { mCoreCleanDependsOn.Value = value; }
        }

        public string PostBuildEventDependsOn
        {
            get { return mPostBuildEventDependsOn.Value; }
            set { mPostBuildEventDependsOn.Value = value; }
        }

        public string PublishDependsOn
        {
            get { return mPublishDependsOn.Value; }
            set { mPublishDependsOn.Value = value; }
        }

        public string PublishOnlyDependsOn
        {
            get { return mPublishOnlyDependsOn.Value; }
            set { mPublishOnlyDependsOn.Value = value; }
        }

        public string PublishBuildDependsOn
        {
            get { return mPublishBuildDependsOn.Value; }
            set { mPublishBuildDependsOn.Value = value; }
        }

        public string BuiltProjectOutputGroupDependsOn
        {
            get { return mBuiltProjectOutputGroupDependsOn.Value; }
            set { mBuiltProjectOutputGroupDependsOn.Value = value; }
        }

        public bool? AddAppConfigToBuildOutputs
        {
            get { return mAddAppConfigToBuildOutputs.Value; }
            set { mAddAppConfigToBuildOutputs.Value = value; }
        }

        public string DebugSymbolsProjectOutputGroupDependsOn
        {
            get { return mDebugSymbolsProjectOutputGroupDependsOn.Value; }
            set { mDebugSymbolsProjectOutputGroupDependsOn.Value = value; }
        }

        public string DocumentationProjectOutputGroupDependsOn
        {
            get { return mDocumentationProjectOutputGroupDependsOn.Value; }
            set { mDocumentationProjectOutputGroupDependsOn.Value = value; }
        }

        public string SatelliteDllsProjectOutputGroupDependsOn
        {
            get { return mSatelliteDllsProjectOutputGroupDependsOn.Value; }
            set { mSatelliteDllsProjectOutputGroupDependsOn.Value = value; }
        }

        public string SourceFilesProjectOutputGroupDependsOn
        {
            get { return mSourceFilesProjectOutputGroupDependsOn.Value; }
            set { mSourceFilesProjectOutputGroupDependsOn.Value = value; }
        }

        public string ContentFilesProjectOutputGroupDependsOn
        {
            get { return mContentFilesProjectOutputGroupDependsOn.Value; }
            set { mContentFilesProjectOutputGroupDependsOn.Value = value; }
        }

        public string SGenFilesOutputGroupDependsOn
        {
            get { return mSGenFilesOutputGroupDependsOn.Value; }
            set { mSGenFilesOutputGroupDependsOn.Value = value; }
        }

        public string SDKRedistOutputGroupDependsOn
        {
            get { return mSDKRedistOutputGroupDependsOn.Value; }
            set { mSDKRedistOutputGroupDependsOn.Value = value; }
        }

        public string CodeAnalysisTargets
        {
            get { return mCodeAnalysisTargets.Value; }
            set { mCodeAnalysisTargets.Value = value; }
        }

        public string CodeAnalysisStaticAnalysisDirectory
        {
            get { return mCodeAnalysisStaticAnalysisDirectory.Value; }
            set { mCodeAnalysisStaticAnalysisDirectory.Value = value; }
        }

        public string CodeAnalysisRuleSetDirectories
        {
            get { return mCodeAnalysisRuleSetDirectories.Value; }
            set { mCodeAnalysisRuleSetDirectories.Value = value; }
        }

        public string CodeAnalysisPath
        {
            get { return mCodeAnalysisPath.Value; }
            set { mCodeAnalysisPath.Value = value; }
        }

        public bool? CodeAnalysisApplyLogFileXsl
        {
            get { return mCodeAnalysisApplyLogFileXsl.Value; }
            set { mCodeAnalysisApplyLogFileXsl.Value = value; }
        }

        public bool? CodeAnalysisFailOnMissingRules
        {
            get { return mCodeAnalysisFailOnMissingRules.Value; }
            set { mCodeAnalysisFailOnMissingRules.Value = value; }
        }

        public bool? CodeAnalysisForceOutput
        {
            get { return mCodeAnalysisForceOutput.Value; }
            set { mCodeAnalysisForceOutput.Value = value; }
        }

        public bool? CodeAnalysisGenerateSuccessFile
        {
            get { return mCodeAnalysisGenerateSuccessFile.Value; }
            set { mCodeAnalysisGenerateSuccessFile.Value = value; }
        }

        public bool? CodeAnalysisIgnoreGeneratedCode
        {
            get { return mCodeAnalysisIgnoreGeneratedCode.Value; }
            set { mCodeAnalysisIgnoreGeneratedCode.Value = value; }
        }

        public bool? CodeAnalysisIgnoreInvalidTargets
        {
            get { return mCodeAnalysisIgnoreInvalidTargets.Value; }
            set { mCodeAnalysisIgnoreInvalidTargets.Value = value; }
        }

        public bool? CodeAnalysisIgnoreMissingIndirectReferences
        {
            get { return mCodeAnalysisIgnoreMissingIndirectReferences.Value; }
            set { mCodeAnalysisIgnoreMissingIndirectReferences.Value = value; }
        }

        public string CodeAnalysisInputAssembly
        {
            get { return mCodeAnalysisInputAssembly.Value; }
            set { mCodeAnalysisInputAssembly.Value = value; }
        }

        public string CodeAnalysisLogFile
        {
            get { return mCodeAnalysisLogFile.Value; }
            set { mCodeAnalysisLogFile.Value = value; }
        }

        public string CodeAnalysisModuleSuppressionsFile
        {
            get { return mCodeAnalysisModuleSuppressionsFile.Value; }
            set { mCodeAnalysisModuleSuppressionsFile.Value = value; }
        }

        public bool? CodeAnalysisOverrideRuleVisibilities
        {
            get { return mCodeAnalysisOverrideRuleVisibilities.Value; }
            set { mCodeAnalysisOverrideRuleVisibilities.Value = value; }
        }

        public bool? CodeAnalysisOutputToConsole
        {
            get { return mCodeAnalysisOutputToConsole.Value; }
            set { mCodeAnalysisOutputToConsole.Value = value; }
        }

        public bool? CodeAnalysisQuiet
        {
            get { return mCodeAnalysisQuiet.Value; }
            set { mCodeAnalysisQuiet.Value = value; }
        }

        public string CodeAnalysisRuleDirectories
        {
            get { return mCodeAnalysisRuleDirectories.Value; }
            set { mCodeAnalysisRuleDirectories.Value = value; }
        }

        public string CodeAnalysisSaveMessagesToReport
        {
            get { return mCodeAnalysisSaveMessagesToReport.Value; }
            set { mCodeAnalysisSaveMessagesToReport.Value = value; }
        }

        public bool? CodeAnalysisSearchGlobalAssemblyCache
        {
            get { return mCodeAnalysisSearchGlobalAssemblyCache.Value; }
            set { mCodeAnalysisSearchGlobalAssemblyCache.Value = value; }
        }

        public string CodeAnalysisSucceededFile
        {
            get { return mCodeAnalysisSucceededFile.Value; }
            set { mCodeAnalysisSucceededFile.Value = value; }
        }

        public bool? CodeAnalysisSummary
        {
            get { return mCodeAnalysisSummary.Value; }
            set { mCodeAnalysisSummary.Value = value; }
        }

        public int? CodeAnalysisTimeout
        {
            get { return mCodeAnalysisTimeout.Value; }
            set { mCodeAnalysisTimeout.Value = value; }
        }

        public bool? CodeAnalysisTreatWarningsAsErrors
        {
            get { return mCodeAnalysisTreatWarningsAsErrors.Value; }
            set { mCodeAnalysisTreatWarningsAsErrors.Value = value; }
        }

        public bool? CodeAnalysisUpdateProject
        {
            get { return mCodeAnalysisUpdateProject.Value; }
            set { mCodeAnalysisUpdateProject.Value = value; }
        }

        public bool? CodeAnalysisUseTypeNameInSuppression
        {
            get { return mCodeAnalysisUseTypeNameInSuppression.Value; }
            set { mCodeAnalysisUseTypeNameInSuppression.Value = value; }
        }

        public bool? CodeAnalysisVerbose
        {
            get { return mCodeAnalysisVerbose.Value; }
            set { mCodeAnalysisVerbose.Value = value; }
        }

        public string CodeAnalysisRuleSet
        {
            get { return mCodeAnalysisRuleSet.Value; }
            set { mCodeAnalysisRuleSet.Value = value; }
        }

        public string RunCodeAnalysisDependsOn
        {
            get { return mRunCodeAnalysisDependsOn.Value; }
            set { mRunCodeAnalysisDependsOn.Value = value; }
        }

        public string RunCodeAnalysisInputs
        {
            get { return mRunCodeAnalysisInputs.Value; }
            set { mRunCodeAnalysisInputs.Value = value; }
        }

        public string RunNativeCodeAnalysisInputs
        {
            get { return mRunNativeCodeAnalysisInputs.Value; }
            set { mRunNativeCodeAnalysisInputs.Value = value; }
        }

        public string MergedOutputCodeAnalysisFile
        {
            get { return mMergedOutputCodeAnalysisFile.Value; }
            set { mMergedOutputCodeAnalysisFile.Value = value; }
        }

        public string CompileRdlFilesDependsOn
        {
            get { return mCompileRdlFilesDependsOn.Value; }
            set { mCompileRdlFilesDependsOn.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftNetFrameworkTargets
        {
            get { return mImportByWildcardBeforeMicrosoftNetFrameworkTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftNetFrameworkTargets
        {
            get { return mImportByWildcardAfterMicrosoftNetFrameworkTargets.Value; }
            set { mImportByWildcardAfterMicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets
        {
            get { return mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets.Value; }
            set { mImportUserLocationsByWildcardBeforeMicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets
        {
            get { return mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets.Value; }
            set { mImportUserLocationsByWildcardAfterMicrosoftNetFrameworkTargets.Value = value; }
        }

        public string ImplicitlyExpandDesignTimeFacadesDependsOn
        {
            get { return mImplicitlyExpandDesignTimeFacadesDependsOn.Value; }
            set { mImplicitlyExpandDesignTimeFacadesDependsOn.Value = value; }
        }

        public string BuildSystem
        {
            get { return mBuildSystem.Value; }
            set { mBuildSystem.Value = value; }
        }

        public string TaskVersion
        {
            get { return mTaskVersion.Value; }
            set { mTaskVersion.Value = value; }
        }

        public string TaskKeyToken
        {
            get { return mTaskKeyToken.Value; }
            set { mTaskKeyToken.Value = value; }
        }

        public string BuildTaskAssembly
        {
            get { return mBuildTaskAssembly.Value; }
            set { mBuildTaskAssembly.Value = value; }
        }

        public bool? AlwaysCompileMarkupFilesInSeparateDomain
        {
            get { return mAlwaysCompileMarkupFilesInSeparateDomain.Value; }
            set { mAlwaysCompileMarkupFilesInSeparateDomain.Value = value; }
        }

        public string LocalizationDirectivesToLocFile
        {
            get { return mLocalizationDirectivesToLocFile.Value; }
            set { mLocalizationDirectivesToLocFile.Value = value; }
        }

        public string GetReferenceAssemblyPathsDependsOn
        {
            get { return mGetReferenceAssemblyPathsDependsOn.Value; }
            set { mGetReferenceAssemblyPathsDependsOn.Value = value; }
        }

        public bool? XamlDebuggingInformation
        {
            get { return mXamlDebuggingInformation.Value; }
            set { mXamlDebuggingInformation.Value = value; }
        }

        public bool? HostInBrowser
        {
            get { return mHostInBrowser.Value; }
            set { mHostInBrowser.Value = value; }
        }

        public string Version
        {
            get { return mVersion.Value; }
            set { mVersion.Value = value; }
        }

        public string DeploymentType
        {
            get { return mDeploymentType.Value; }
            set { mDeploymentType.Value = value; }
        }

        public bool? RunAfterInstall
        {
            get { return mRunAfterInstall.Value; }
            set { mRunAfterInstall.Value = value; }
        }

        public string GeneratedFileExtension
        {
            get { return mGeneratedFileExtension.Value; }
            set { mGeneratedFileExtension.Value = value; }
        }

        public string OSVersion
        {
            get { return mOSVersion.Value; }
            set { mOSVersion.Value = value; }
        }

        public bool? _RequireMCPass2ForSatelliteAssemblyOnly
        {
            get { return m_RequireMCPass2ForSatelliteAssemblyOnly.Value; }
            set { m_RequireMCPass2ForSatelliteAssemblyOnly.Value = value; }
        }

        public bool? _RequireMCPass2ForMainAssembly
        {
            get { return m_RequireMCPass2ForMainAssembly.Value; }
            set { m_RequireMCPass2ForMainAssembly.Value = value; }
        }

        public bool? IsApplication
        {
            get { return mIsApplication.Value; }
            set { mIsApplication.Value = value; }
        }

        public string _AfterCompileWinFXInternalDependsOn
        {
            get { return m_AfterCompileWinFXInternalDependsOn.Value; }
            set { m_AfterCompileWinFXInternalDependsOn.Value = value; }
        }

        public string MarkupCompilePass2ForMainAssemblyDependsOn
        {
            get { return mMarkupCompilePass2ForMainAssemblyDependsOn.Value; }
            set { mMarkupCompilePass2ForMainAssemblyDependsOn.Value = value; }
        }

        public string _CompileTargetNameForLocalType
        {
            get { return m_CompileTargetNameForLocalType.Value; }
            set { m_CompileTargetNameForLocalType.Value = value; }
        }

        public string _ResourceNameInMainAssembly
        {
            get { return m_ResourceNameInMainAssembly.Value; }
            set { m_ResourceNameInMainAssembly.Value = value; }
        }

        public string EntityDeployIntermediateResourcePath
        {
            get { return mEntityDeployIntermediateResourcePath.Value; }
            set { mEntityDeployIntermediateResourcePath.Value = value; }
        }

        public string EntityDeployDependsOn
        {
            get { return mEntityDeployDependsOn.Value; }
            set { mEntityDeployDependsOn.Value = value; }
        }

        public string LoadTimeSensitiveTargets
        {
            get { return mLoadTimeSensitiveTargets.Value; }
            set { mLoadTimeSensitiveTargets.Value = value; }
        }

        public string LoadTimeSensitiveProperties
        {
            get { return mLoadTimeSensitiveProperties.Value; }
            set { mLoadTimeSensitiveProperties.Value = value; }
        }

        public string XamlBuildTaskAssemblyName
        {
            get { return mXamlBuildTaskAssemblyName.Value; }
            set { mXamlBuildTaskAssemblyName.Value = value; }
        }

        public bool? XamlRequiresCompilationPass2
        {
            get { return mXamlRequiresCompilationPass2.Value; }
            set { mXamlRequiresCompilationPass2.Value = value; }
        }

        public string XamlTemporaryAssemblyName
        {
            get { return mXamlTemporaryAssemblyName.Value; }
            set { mXamlTemporaryAssemblyName.Value = value; }
        }

        public string CompileTargetNameForTemporaryAssembly
        {
            get { return mCompileTargetNameForTemporaryAssembly.Value; }
            set { mCompileTargetNameForTemporaryAssembly.Value = value; }
        }

        public string XamlBuildTaskLocation
        {
            get { return mXamlBuildTaskLocation.Value; }
            set { mXamlBuildTaskLocation.Value = value; }
        }

        public string XamlGenCodeFileNames
        {
            get { return mXamlGenCodeFileNames.Value; }
            set { mXamlGenCodeFileNames.Value = value; }
        }

        public string XamlGenMarkupFileNames
        {
            get { return mXamlGenMarkupFileNames.Value; }
            set { mXamlGenMarkupFileNames.Value = value; }
        }

        public string XamlPass2FlagFile
        {
            get { return mXamlPass2FlagFile.Value; }
            set { mXamlPass2FlagFile.Value = value; }
        }

        public string DesignTimeIntermediateOutputPath
        {
            get { return mDesignTimeIntermediateOutputPath.Value; }
            set { mDesignTimeIntermediateOutputPath.Value = value; }
        }

        public string WorkflowBuildExtensionVersion
        {
            get { return mWorkflowBuildExtensionVersion.Value; }
            set { mWorkflowBuildExtensionVersion.Value = value; }
        }

        public string WorkflowBuildExtensionKeyToken
        {
            get { return mWorkflowBuildExtensionKeyToken.Value; }
            set { mWorkflowBuildExtensionKeyToken.Value = value; }
        }

        public string WorkflowBuildExtensionAssemblyName
        {
            get { return mWorkflowBuildExtensionAssemblyName.Value; }
            set { mWorkflowBuildExtensionAssemblyName.Value = value; }
        }

        public string GenerateCompiledExpressionsTempFilePathForEditing
        {
            get { return mGenerateCompiledExpressionsTempFilePathForEditing.Value; }
            set { mGenerateCompiledExpressionsTempFilePathForEditing.Value = value; }
        }

        public string GenerateCompiledExpressionsTempFilePathForValidation
        {
            get { return mGenerateCompiledExpressionsTempFilePathForValidation.Value; }
            set { mGenerateCompiledExpressionsTempFilePathForValidation.Value = value; }
        }

        public string GenerateCompiledExpressionsTempFilePathForTypeInfer
        {
            get { return mGenerateCompiledExpressionsTempFilePathForTypeInfer.Value; }
            set { mGenerateCompiledExpressionsTempFilePathForTypeInfer.Value = value; }
        }

        public string DeferredValidationErrorsFileName
        {
            get { return mDeferredValidationErrorsFileName.Value; }
            set { mDeferredValidationErrorsFileName.Value = value; }
        }

        public string MsTestToolsTargets
        {
            get { return mMsTestToolsTargets.Value; }
            set { mMsTestToolsTargets.Value = value; }
        }

        public string MsAppxPackageTargets
        {
            get { return mMsAppxPackageTargets.Value; }
            set { mMsAppxPackageTargets.Value = value; }
        }

        public bool? Utf8Output
        {
            get { return mUtf8Output.Value; }
            set { mUtf8Output.Value = value; }
        }

        public bool? NoCompilerStandardLib
        {
            get { return mNoCompilerStandardLib.Value; }
            set { mNoCompilerStandardLib.Value = value; }
        }

        public bool? BuildPackage
        {
            get { return mBuildPackage.Value; }
            set { mBuildPackage.Value = value; }
        }

        public bool? RequireRestoreConsent
        {
            get { return mRequireRestoreConsent.Value; }
            set { mRequireRestoreConsent.Value = value; }
        }

        public bool? DownloadNuGetExe
        {
            get { return mDownloadNuGetExe.Value; }
            set { mDownloadNuGetExe.Value = value; }
        }

        public string NuGetToolsPath
        {
            get { return mNuGetToolsPath.Value; }
            set { mNuGetToolsPath.Value = value; }
        }

        public string PackagesConfig
        {
            get { return mPackagesConfig.Value; }
            set { mPackagesConfig.Value = value; }
        }

        public string NuGetExePath
        {
            get { return mNuGetExePath.Value; }
            set { mNuGetExePath.Value = value; }
        }

        public string PackageSources
        {
            get { return mPackageSources.Value; }
            set { mPackageSources.Value = value; }
        }

        public string NuGetCommand
        {
            get { return mNuGetCommand.Value; }
            set { mNuGetCommand.Value = value; }
        }

        public string PackageOutputDir
        {
            get { return mPackageOutputDir.Value; }
            set { mPackageOutputDir.Value = value; }
        }

        public string RequireConsentSwitch
        {
            get { return mRequireConsentSwitch.Value; }
            set { mRequireConsentSwitch.Value = value; }
        }

        public string RestoreCommand
        {
            get { return mRestoreCommand.Value; }
            set { mRestoreCommand.Value = value; }
        }

        public string BuildCommand
        {
            get { return mBuildCommand.Value; }
            set { mBuildCommand.Value = value; }
        }

        public string ProcessorArchitectureAsPlatform
        {
            get { return mProcessorArchitectureAsPlatform.Value; }
            set { mProcessorArchitectureAsPlatform.Value = value; }
        }

        public bool? IsLibrary
        {
            get { return mIsLibrary.Value; }
            set { mIsLibrary.Value = value; }
        }

        public string ProductVersion
        {
            get { return mProductVersion.Value; }
            set { mProductVersion.Value = value; }
        }

        public string SchemaVersion
        {
            get { return mSchemaVersion.Value; }
            set { mSchemaVersion.Value = value; }
        }

        public string ProjectTypeGuids
        {
            get { return mProjectTypeGuids.Value; }
            set { mProjectTypeGuids.Value = value; }
        }

        public bool? UseIISExpress
        {
            get { return mUseIISExpress.Value; }
            set { mUseIISExpress.Value = value; }
        }

        public string IISExpressSSLPort
        {
            get { return mIISExpressSSLPort.Value; }
            set { mIISExpressSSLPort.Value = value; }
        }

        public string IISExpressAnonymousAuthentication
        {
            get { return mIISExpressAnonymousAuthentication.Value; }
            set { mIISExpressAnonymousAuthentication.Value = value; }
        }

        public string IISExpressWindowsAuthentication
        {
            get { return mIISExpressWindowsAuthentication.Value; }
            set { mIISExpressWindowsAuthentication.Value = value; }
        }

        public string IISExpressUseClassicPipelineMode
        {
            get { return mIISExpressUseClassicPipelineMode.Value; }
            set { mIISExpressUseClassicPipelineMode.Value = value; }
        }

        public string VSToolsPath
        {
            get { return mVSToolsPath.Value; }
            set { mVSToolsPath.Value = value; }
        }

        public bool? WebProjectOutputDirInsideProjectDefault
        {
            get { return mWebProjectOutputDirInsideProjectDefault.Value; }
            set { mWebProjectOutputDirInsideProjectDefault.Value = value; }
        }

        public string WebProjectOutputDirInsideProject
        {
            get { return mWebProjectOutputDirInsideProject.Value; }
            set { mWebProjectOutputDirInsideProject.Value = value; }
        }

        public bool? DisableLinkInCopyWebApplicaton
        {
            get { return mDisableLinkInCopyWebApplicaton.Value; }
            set { mDisableLinkInCopyWebApplicaton.Value = value; }
        }

        public bool? Disable_CopyWebApplication
        {
            get { return mDisable_CopyWebApplication.Value; }
            set { mDisable_CopyWebApplication.Value = value; }
        }

        public bool? UseWPP_CopyWebApplication
        {
            get { return mUseWPP_CopyWebApplication.Value; }
            set { mUseWPP_CopyWebApplication.Value = value; }
        }

        public bool? CleanWebProjectOutputDir
        {
            get { return mCleanWebProjectOutputDir.Value; }
            set { mCleanWebProjectOutputDir.Value = value; }
        }

        public string WebProjectOutputDir
        {
            get { return mWebProjectOutputDir.Value; }
            set { mWebProjectOutputDir.Value = value; }
        }

        public string CleanWebProjectOutputDirDependsOn
        {
            get { return mCleanWebProjectOutputDirDependsOn.Value; }
            set { mCleanWebProjectOutputDirDependsOn.Value = value; }
        }

        public string OnBefore_CopyWebApplicationDefault
        {
            get { return mOnBefore_CopyWebApplicationDefault.Value; }
            set { mOnBefore_CopyWebApplicationDefault.Value = value; }
        }

        public string OnBefore_CopyWebApplication
        {
            get { return mOnBefore_CopyWebApplication.Value; }
            set { mOnBefore_CopyWebApplication.Value = value; }
        }

        public string OnAfter_CopyWebApplication
        {
            get { return mOnAfter_CopyWebApplication.Value; }
            set { mOnAfter_CopyWebApplication.Value = value; }
        }

        public string _CopyWebApplicationDependsOn
        {
            get { return m_CopyWebApplicationDependsOn.Value; }
            set { m_CopyWebApplicationDependsOn.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingTargets
        {
            get { return mImportByWildcardBeforeMicrosoftWebPublishingTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftWebPublishingTargets.Value = value; }
        }

        public string _WPPVersion
        {
            get { return m_WPPVersion.Value; }
            set { m_WPPVersion.Value = value; }
        }

        public string _WPPSupports
        {
            get { return m_WPPSupports.Value; }
            set { m_WPPSupports.Value = value; }
        }

        public string _WPPWebPublishMethodSupports
        {
            get { return m_WPPWebPublishMethodSupports.Value; }
            set { m_WPPWebPublishMethodSupports.Value = value; }
        }

        public string WebPublishPipelineProjectDirectory
        {
            get { return mWebPublishPipelineProjectDirectory.Value; }
            set { mWebPublishPipelineProjectDirectory.Value = value; }
        }

        public string WebPublishPipelineSourceRootDirectory
        {
            get { return mWebPublishPipelineSourceRootDirectory.Value; }
            set { mWebPublishPipelineSourceRootDirectory.Value = value; }
        }

        public string WebPublishPipelineTransformRootDirectory
        {
            get { return mWebPublishPipelineTransformRootDirectory.Value; }
            set { mWebPublishPipelineTransformRootDirectory.Value = value; }
        }

        public string WebPublishPipelineProjectName
        {
            get { return mWebPublishPipelineProjectName.Value; }
            set { mWebPublishPipelineProjectName.Value = value; }
        }

        public string WebPublishPipelineProjectFile
        {
            get { return mWebPublishPipelineProjectFile.Value; }
            set { mWebPublishPipelineProjectFile.Value = value; }
        }

        public string WebPublishPipeLineProjectFullPath
        {
            get { return mWebPublishPipeLineProjectFullPath.Value; }
            set { mWebPublishPipeLineProjectFullPath.Value = value; }
        }

        public string WebPublishPipelineWAPProjectSettings
        {
            get { return mWebPublishPipelineWAPProjectSettings.Value; }
            set { mWebPublishPipelineWAPProjectSettings.Value = value; }
        }

        public bool? VerifyDatabaseSettingWithImport
        {
            get { return mVerifyDatabaseSettingWithImport.Value; }
            set { mVerifyDatabaseSettingWithImport.Value = value; }
        }

        public string _LocalDBVersionToUseForSqlExpress
        {
            get { return m_LocalDBVersionToUseForSqlExpress.Value; }
            set { m_LocalDBVersionToUseForSqlExpress.Value = value; }
        }

        public bool? _PublishProfileSet
        {
            get { return m_PublishProfileSet.Value; }
            set { m_PublishProfileSet.Value = value; }
        }

        public bool? EnableWebPublishProfileFile
        {
            get { return mEnableWebPublishProfileFile.Value; }
            set { mEnableWebPublishProfileFile.Value = value; }
        }

        public string _WPPDefaultIntermediateOutputPath
        {
            get { return m_WPPDefaultIntermediateOutputPath.Value; }
            set { m_WPPDefaultIntermediateOutputPath.Value = value; }
        }

        public string _WPPDefaultIntermediateOutputFullPath
        {
            get { return m_WPPDefaultIntermediateOutputFullPath.Value; }
            set { m_WPPDefaultIntermediateOutputFullPath.Value = value; }
        }

        public string PublishProfileRootFolder
        {
            get { return mPublishProfileRootFolder.Value; }
            set { mPublishProfileRootFolder.Value = value; }
        }

        public string PublishProfileName
        {
            get { return mPublishProfileName.Value; }
            set { mPublishProfileName.Value = value; }
        }

        public bool? _WebPublishProfileFileWillBeImported
        {
            get { return m_WebPublishProfileFileWillBeImported.Value; }
            set { m_WebPublishProfileFileWillBeImported.Value = value; }
        }

        public string WebPublishPipelineCustomizeTargetFile
        {
            get { return mWebPublishPipelineCustomizeTargetFile.Value; }
            set { mWebPublishPipelineCustomizeTargetFile.Value = value; }
        }

        public string WebPublishPipelineSolutionTargetFile
        {
            get { return mWebPublishPipelineSolutionTargetFile.Value; }
            set { mWebPublishPipelineSolutionTargetFile.Value = value; }
        }

        public string _WPPCleanTargets
        {
            get { return m_WPPCleanTargets.Value; }
            set { m_WPPCleanTargets.Value = value; }
        }

        public string FilesToIncludeForPublish
        {
            get { return mFilesToIncludeForPublish.Value; }
            set { mFilesToIncludeForPublish.Value = value; }
        }

        public string AlternativeProjectDirectory
        {
            get { return mAlternativeProjectDirectory.Value; }
            set { mAlternativeProjectDirectory.Value = value; }
        }

        public bool? ExcludeGeneratedDebugSymbol
        {
            get { return mExcludeGeneratedDebugSymbol.Value; }
            set { mExcludeGeneratedDebugSymbol.Value = value; }
        }

        public bool? ExcludeXmlAssemblyFiles
        {
            get { return mExcludeXmlAssemblyFiles.Value; }
            set { mExcludeXmlAssemblyFiles.Value = value; }
        }

        public bool? ExcludeApp_Data
        {
            get { return mExcludeApp_Data.Value; }
            set { mExcludeApp_Data.Value = value; }
        }

        public string SkipApp_DataFolder
        {
            get { return mSkipApp_DataFolder.Value; }
            set { mSkipApp_DataFolder.Value = value; }
        }

        public bool? UseMsdeployExe
        {
            get { return mUseMsdeployExe.Value; }
            set { mUseMsdeployExe.Value = value; }
        }

        public bool? EnableCollectLinkFilesInProject
        {
            get { return mEnableCollectLinkFilesInProject.Value; }
            set { mEnableCollectLinkFilesInProject.Value = value; }
        }

        public bool? ExcludeLinkFilesInProject
        {
            get { return mExcludeLinkFilesInProject.Value; }
            set { mExcludeLinkFilesInProject.Value = value; }
        }

        public bool? CleanWPPAllFilesInSingleFolder
        {
            get { return mCleanWPPAllFilesInSingleFolder.Value; }
            set { mCleanWPPAllFilesInSingleFolder.Value = value; }
        }

        public bool? IncludeIisSettings
        {
            get { return mIncludeIisSettings.Value; }
            set { mIncludeIisSettings.Value = value; }
        }

        public bool? ExcludeFilesFromPackage
        {
            get { return mExcludeFilesFromPackage.Value; }
            set { mExcludeFilesFromPackage.Value = value; }
        }

        public bool? ImportParametersFiles
        {
            get { return mImportParametersFiles.Value; }
            set { mImportParametersFiles.Value = value; }
        }

        public bool? ImportParametersFile_DisableEscapeMSBuildVariable
        {
            get { return mImportParametersFile_DisableEscapeMSBuildVariable.Value; }
            set { mImportParametersFile_DisableEscapeMSBuildVariable.Value = value; }
        }

        public bool? ImportProjectParametersFiles
        {
            get { return mImportProjectParametersFiles.Value; }
            set { mImportProjectParametersFiles.Value = value; }
        }

        public bool? ImportProfileParametersFiles
        {
            get { return mImportProfileParametersFiles.Value; }
            set { mImportProfileParametersFiles.Value = value; }
        }

        public bool? ImportPublishingParameterValues
        {
            get { return mImportPublishingParameterValues.Value; }
            set { mImportPublishingParameterValues.Value = value; }
        }

        public bool? EnableOptimisticParameterDefaultValue
        {
            get { return mEnableOptimisticParameterDefaultValue.Value; }
            set { mEnableOptimisticParameterDefaultValue.Value = value; }
        }

        public bool? ParameterApplicationPool
        {
            get { return mParameterApplicationPool.Value; }
            set { mParameterApplicationPool.Value = value; }
        }

        public bool? IIS6ParameterApplicationPool
        {
            get { return mIIS6ParameterApplicationPool.Value; }
            set { mIIS6ParameterApplicationPool.Value = value; }
        }

        public bool? DisableAllVSGeneratedMSDeployParameter
        {
            get { return mDisableAllVSGeneratedMSDeployParameter.Value; }
            set { mDisableAllVSGeneratedMSDeployParameter.Value = value; }
        }

        public bool? AutoParameterizationWebConfigConnectionStrings
        {
            get { return mAutoParameterizationWebConfigConnectionStrings.Value; }
            set { mAutoParameterizationWebConfigConnectionStrings.Value = value; }
        }

        public bool? AutoParameterizationWebConfigCSNoDefaultValue
        {
            get { return mAutoParameterizationWebConfigCSNoDefaultValue.Value; }
            set { mAutoParameterizationWebConfigCSNoDefaultValue.Value = value; }
        }

        public string AutoParameterizationWebConfigConnectionStringsIntermediateOutput
        {
            get { return mAutoParameterizationWebConfigConnectionStringsIntermediateOutput.Value; }
            set { mAutoParameterizationWebConfigConnectionStringsIntermediateOutput.Value = value; }
        }

        public string AutoParameterizationWebConfigConnectionStringsLocation
        {
            get { return mAutoParameterizationWebConfigConnectionStringsLocation.Value; }
            set { mAutoParameterizationWebConfigConnectionStringsLocation.Value = value; }
        }

        public string _WPPLastBuildInfoIntermediateOutput
        {
            get { return m_WPPLastBuildInfoIntermediateOutput.Value; }
            set { m_WPPLastBuildInfoIntermediateOutput.Value = value; }
        }

        public string _WPPLastBuildInfoLocation
        {
            get { return m_WPPLastBuildInfoLocation.Value; }
            set { m_WPPLastBuildInfoLocation.Value = value; }
        }

        public bool? InsertAdditionalWebCofigConnectionStrings
        {
            get { return mInsertAdditionalWebCofigConnectionStrings.Value; }
            set { mInsertAdditionalWebCofigConnectionStrings.Value = value; }
        }

        public string InsertAdditionalWebCofigConnectionStringsIntermediateOutput
        {
            get { return mInsertAdditionalWebCofigConnectionStringsIntermediateOutput.Value; }
            set { mInsertAdditionalWebCofigConnectionStringsIntermediateOutput.Value = value; }
        }

        public string InsertAdditionalWebCofigConnectionStringsLocation
        {
            get { return mInsertAdditionalWebCofigConnectionStringsLocation.Value; }
            set { mInsertAdditionalWebCofigConnectionStringsLocation.Value = value; }
        }

        public string InsertAdditionalWebConfigConnectionStringProviderName
        {
            get { return mInsertAdditionalWebConfigConnectionStringProviderName.Value; }
            set { mInsertAdditionalWebConfigConnectionStringProviderName.Value = value; }
        }

        public bool? InsertAdditionalWebConfigConnectionStringOnlyInRoot
        {
            get { return mInsertAdditionalWebConfigConnectionStringOnlyInRoot.Value; }
            set { mInsertAdditionalWebConfigConnectionStringOnlyInRoot.Value = value; }
        }

        public string SqlScriptSourceTransacted
        {
            get { return mSqlScriptSourceTransacted.Value; }
            set { mSqlScriptSourceTransacted.Value = value; }
        }

        public string AutoSqlScriptSourceTransacted
        {
            get { return mAutoSqlScriptSourceTransacted.Value; }
            set { mAutoSqlScriptSourceTransacted.Value = value; }
        }

        public string DatabaseDeployIntermediateRelativePath
        {
            get { return mDatabaseDeployIntermediateRelativePath.Value; }
            set { mDatabaseDeployIntermediateRelativePath.Value = value; }
        }

        public string DatabaseDeployIntermediateOutputPath
        {
            get { return mDatabaseDeployIntermediateOutputPath.Value; }
            set { mDatabaseDeployIntermediateOutputPath.Value = value; }
        }

        public string _WebConfigsToAutoParmeterizeCsTransformOutputParametersFile
        {
            get { return m_WebConfigsToAutoParmeterizeCsTransformOutputParametersFile.Value; }
            set { m_WebConfigsToAutoParmeterizeCsTransformOutputParametersFile.Value = value; }
        }

        public string DeployDefaultTarget
        {
            get { return mDeployDefaultTarget.Value; }
            set { mDeployDefaultTarget.Value = value; }
        }

        public string DeployTarget
        {
            get { return mDeployTarget.Value; }
            set { mDeployTarget.Value = value; }
        }

        public int? RetryAttemptsForDeployment
        {
            get { return mRetryAttemptsForDeployment.Value; }
            set { mRetryAttemptsForDeployment.Value = value; }
        }

        public bool? DeployOnBuildDefault
        {
            get { return mDeployOnBuildDefault.Value; }
            set { mDeployOnBuildDefault.Value = value; }
        }

        public string DeployOnBuild
        {
            get { return mDeployOnBuild.Value; }
            set { mDeployOnBuild.Value = value; }
        }

        public bool? EnableMSDeployBackup
        {
            get { return mEnableMSDeployBackup.Value; }
            set { mEnableMSDeployBackup.Value = value; }
        }

        public bool? EnableMSDeployAppOffline
        {
            get { return mEnableMSDeployAppOffline.Value; }
            set { mEnableMSDeployAppOffline.Value = value; }
        }

        public bool? MSDeployUseChecksum
        {
            get { return mMSDeployUseChecksum.Value; }
            set { mMSDeployUseChecksum.Value = value; }
        }

        public bool? MSDeployEnableWebConfigEncryptRule
        {
            get { return mMSDeployEnableWebConfigEncryptRule.Value; }
            set { mMSDeployEnableWebConfigEncryptRule.Value = value; }
        }

        public string MSDeployWebConfigEncryptProvider
        {
            get { return mMSDeployWebConfigEncryptProvider.Value; }
            set { mMSDeployWebConfigEncryptProvider.Value = value; }
        }

        public string _MSDeployUserAgentSource
        {
            get { return m_MSDeployUserAgentSource.Value; }
            set { m_MSDeployUserAgentSource.Value = value; }
        }

        public string _MSDeployUserAgent
        {
            get { return m_MSDeployUserAgent.Value; }
            set { m_MSDeployUserAgent.Value = value; }
        }

        public bool? PipelineDependsOnBuild
        {
            get { return mPipelineDependsOnBuild.Value; }
            set { mPipelineDependsOnBuild.Value = value; }
        }

        public string _DeployOnBuild
        {
            get { return m_DeployOnBuild.Value; }
            set { m_DeployOnBuild.Value = value; }
        }

        public bool? WPPCopyWebApplicaitonPipelineCircularDependencyError
        {
            get { return mWPPCopyWebApplicaitonPipelineCircularDependencyError.Value; }
            set { mWPPCopyWebApplicaitonPipelineCircularDependencyError.Value = value; }
        }

        public string PipelineDependsOn
        {
            get { return mPipelineDependsOn.Value; }
            set { mPipelineDependsOn.Value = value; }
        }

        public string ProjectConfigFileName
        {
            get { return mProjectConfigFileName.Value; }
            set { mProjectConfigFileName.Value = value; }
        }

        public string _ProjectConfigFileExtension
        {
            get { return m_ProjectConfigFileExtension.Value; }
            set { m_ProjectConfigFileExtension.Value = value; }
        }

        public string _ProjectConfigFilePrefix
        {
            get { return m_ProjectConfigFilePrefix.Value; }
            set { m_ProjectConfigFilePrefix.Value = value; }
        }

        public string ProjectConfigTransformFileName
        {
            get { return mProjectConfigTransformFileName.Value; }
            set { mProjectConfigTransformFileName.Value = value; }
        }

        public bool? TransformWebConfigEnabled
        {
            get { return mTransformWebConfigEnabled.Value; }
            set { mTransformWebConfigEnabled.Value = value; }
        }

        public bool? TransformWebConfigStackTraceEnabled
        {
            get { return mTransformWebConfigStackTraceEnabled.Value; }
            set { mTransformWebConfigStackTraceEnabled.Value = value; }
        }

        public bool? UseParameterizeToTransformWebConfig
        {
            get { return mUseParameterizeToTransformWebConfig.Value; }
            set { mUseParameterizeToTransformWebConfig.Value = value; }
        }

        public string TransformWebConfigIntermediateOutput
        {
            get { return mTransformWebConfigIntermediateOutput.Value; }
            set { mTransformWebConfigIntermediateOutput.Value = value; }
        }

        public string TransformWebConfigIntermediateLocation
        {
            get { return mTransformWebConfigIntermediateLocation.Value; }
            set { mTransformWebConfigIntermediateLocation.Value = value; }
        }

        public string _WebConfigTransformOutputParametersFile
        {
            get { return m_WebConfigTransformOutputParametersFile.Value; }
            set { m_WebConfigTransformOutputParametersFile.Value = value; }
        }

        public bool? ProfileTransformWebConfigEnabled
        {
            get { return mProfileTransformWebConfigEnabled.Value; }
            set { mProfileTransformWebConfigEnabled.Value = value; }
        }

        public bool? ProfileTransformWebConfigStackTraceEnabled
        {
            get { return mProfileTransformWebConfigStackTraceEnabled.Value; }
            set { mProfileTransformWebConfigStackTraceEnabled.Value = value; }
        }

        public bool? UseParameterizeToProfileTransformWebConfig
        {
            get { return mUseParameterizeToProfileTransformWebConfig.Value; }
            set { mUseParameterizeToProfileTransformWebConfig.Value = value; }
        }

        public string ProfileTransformWebConfigIntermediateOutput
        {
            get { return mProfileTransformWebConfigIntermediateOutput.Value; }
            set { mProfileTransformWebConfigIntermediateOutput.Value = value; }
        }

        public string ProfileTransformWebConfigIntermediateLocation
        {
            get { return mProfileTransformWebConfigIntermediateLocation.Value; }
            set { mProfileTransformWebConfigIntermediateLocation.Value = value; }
        }

        public string _ProfileWebConfigTransformOutputParametersFile
        {
            get { return m_ProfileWebConfigTransformOutputParametersFile.Value; }
            set { m_ProfileWebConfigTransformOutputParametersFile.Value = value; }
        }

        public bool? ParameterizeTransformXmlUseXPath
        {
            get { return mParameterizeTransformXmlUseXPath.Value; }
            set { mParameterizeTransformXmlUseXPath.Value = value; }
        }

        public string DefaultPackageOutputDir
        {
            get { return mDefaultPackageOutputDir.Value; }
            set { mDefaultPackageOutputDir.Value = value; }
        }

        public string DefaultPackageFileName
        {
            get { return mDefaultPackageFileName.Value; }
            set { mDefaultPackageFileName.Value = value; }
        }

        public string DefaultMSDeployDestinationSite
        {
            get { return mDefaultMSDeployDestinationSite.Value; }
            set { mDefaultMSDeployDestinationSite.Value = value; }
        }

        public string DefaultMsDeployAltSuffix
        {
            get { return mDefaultMsDeployAltSuffix.Value; }
            set { mDefaultMsDeployAltSuffix.Value = value; }
        }

        public string DefaultMSDeployDestinationApplicationName
        {
            get { return mDefaultMSDeployDestinationApplicationName.Value; }
            set { mDefaultMSDeployDestinationApplicationName.Value = value; }
        }

        public string DefaultDeployIisAppPath
        {
            get { return mDefaultDeployIisAppPath.Value; }
            set { mDefaultDeployIisAppPath.Value = value; }
        }

        public string DefaultDeployIisRootAppPath
        {
            get { return mDefaultDeployIisRootAppPath.Value; }
            set { mDefaultDeployIisRootAppPath.Value = value; }
        }

        public bool? PackageAsSingleFile
        {
            get { return mPackageAsSingleFile.Value; }
            set { mPackageAsSingleFile.Value = value; }
        }

        public string PackageLocation
        {
            get { return mPackageLocation.Value; }
            set { mPackageLocation.Value = value; }
        }

        public string PackageFileName
        {
            get { return mPackageFileName.Value; }
            set { mPackageFileName.Value = value; }
        }

        public string PackageArchiveRootDir
        {
            get { return mPackageArchiveRootDir.Value; }
            set { mPackageArchiveRootDir.Value = value; }
        }

        public string PackageTempRootDir
        {
            get { return mPackageTempRootDir.Value; }
            set { mPackageTempRootDir.Value = value; }
        }

        public bool? DeployAsIisApp
        {
            get { return mDeployAsIisApp.Value; }
            set { mDeployAsIisApp.Value = value; }
        }

        public bool? IncludeSetAclProviderOnDestination
        {
            get { return mIncludeSetAclProviderOnDestination.Value; }
            set { mIncludeSetAclProviderOnDestination.Value = value; }
        }

        public bool? MarkApp_DataWritableOnDestination
        {
            get { return mMarkApp_DataWritableOnDestination.Value; }
            set { mMarkApp_DataWritableOnDestination.Value = value; }
        }

        public bool? IgnoreDeployManagedRuntimeVersion
        {
            get { return mIgnoreDeployManagedRuntimeVersion.Value; }
            set { mIgnoreDeployManagedRuntimeVersion.Value = value; }
        }

        public string DeployDefaultTargetFrameworkVersion
        {
            get { return mDeployDefaultTargetFrameworkVersion.Value; }
            set { mDeployDefaultTargetFrameworkVersion.Value = value; }
        }

        public string DeployManagedRuntimeVersion
        {
            get { return mDeployManagedRuntimeVersion.Value; }
            set { mDeployManagedRuntimeVersion.Value = value; }
        }

        public string DeployEnable32bitAppOnWin64
        {
            get { return mDeployEnable32bitAppOnWin64.Value; }
            set { mDeployEnable32bitAppOnWin64.Value = value; }
        }

        public string DeployManagedPipelineMode
        {
            get { return mDeployManagedPipelineMode.Value; }
            set { mDeployManagedPipelineMode.Value = value; }
        }

        public bool? GenerateSampleDeployScript
        {
            get { return mGenerateSampleDeployScript.Value; }
            set { mGenerateSampleDeployScript.Value = value; }
        }

        public string PackageLogDir
        {
            get { return mPackageLogDir.Value; }
            set { mPackageLogDir.Value = value; }
        }

        public bool? EnablePackageProcessLoggingAndAssert
        {
            get { return mEnablePackageProcessLoggingAndAssert.Value; }
            set { mEnablePackageProcessLoggingAndAssert.Value = value; }
        }

        public string PackageTraceLevel
        {
            get { return mPackageTraceLevel.Value; }
            set { mPackageTraceLevel.Value = value; }
        }

        public bool? _CreatePackage
        {
            get { return m_CreatePackage.Value; }
            set { m_CreatePackage.Value = value; }
        }

        public bool? _UseDefaultLinkExtensionValue
        {
            get { return m_UseDefaultLinkExtensionValue.Value; }
            set { m_UseDefaultLinkExtensionValue.Value = value; }
        }

        public string PackageEnableLinks
        {
            get { return mPackageEnableLinks.Value; }
            set { mPackageEnableLinks.Value = value; }
        }

        public string PackageDisableLinks
        {
            get { return mPackageDisableLinks.Value; }
            set { mPackageDisableLinks.Value = value; }
        }

        public string ProjectParametersXMLFile
        {
            get { return mProjectParametersXMLFile.Value; }
            set { mProjectParametersXMLFile.Value = value; }
        }

        public bool? EnableProjectDeployParameterPrefix
        {
            get { return mEnableProjectDeployParameterPrefix.Value; }
            set { mEnableProjectDeployParameterPrefix.Value = value; }
        }

        public string DeployParameterIISAppName
        {
            get { return mDeployParameterIISAppName.Value; }
            set { mDeployParameterIISAppName.Value = value; }
        }

        public string DeployParameterIISAppPoolName
        {
            get { return mDeployParameterIISAppPoolName.Value; }
            set { mDeployParameterIISAppPoolName.Value = value; }
        }

        public string DeployParameterApp_DataWritePermission
        {
            get { return mDeployParameterApp_DataWritePermission.Value; }
            set { mDeployParameterApp_DataWritePermission.Value = value; }
        }

        public string DeployParameterIISAppPhysicalPath
        {
            get { return mDeployParameterIISAppPhysicalPath.Value; }
            set { mDeployParameterIISAppPhysicalPath.Value = value; }
        }

        public bool? DeployParameterAutoDescriptionbyTags
        {
            get { return mDeployParameterAutoDescriptionbyTags.Value; }
            set { mDeployParameterAutoDescriptionbyTags.Value = value; }
        }

        public string DeployParameterIISAppNameDescription
        {
            get { return mDeployParameterIISAppNameDescription.Value; }
            set { mDeployParameterIISAppNameDescription.Value = value; }
        }

        public string DeployParameterIISAppPoolNameDescription
        {
            get { return mDeployParameterIISAppPoolNameDescription.Value; }
            set { mDeployParameterIISAppPoolNameDescription.Value = value; }
        }

        public string DeployParameterIISAppPhysicalPathDescription
        {
            get { return mDeployParameterIISAppPhysicalPathDescription.Value; }
            set { mDeployParameterIISAppPhysicalPathDescription.Value = value; }
        }

        public string DeployParameterIISAppConnectionStringDescription
        {
            get { return mDeployParameterIISAppConnectionStringDescription.Value; }
            set { mDeployParameterIISAppConnectionStringDescription.Value = value; }
        }

        public string DeployParameterSqlScriptVariablesDescription
        {
            get { return mDeployParameterSqlScriptVariablesDescription.Value; }
            set { mDeployParameterSqlScriptVariablesDescription.Value = value; }
        }

        public string MsDeployDatabaseTag
        {
            get { return mMsDeployDatabaseTag.Value; }
            set { mMsDeployDatabaseTag.Value = value; }
        }

        public string MsDeploySqlCommandVariableKind
        {
            get { return mMsDeploySqlCommandVariableKind.Value; }
            set { mMsDeploySqlCommandVariableKind.Value = value; }
        }

        public string MsdeploySqlUnsupportedCommand
        {
            get { return mMsdeploySqlUnsupportedCommand.Value; }
            set { mMsdeploySqlUnsupportedCommand.Value = value; }
        }

        public bool? CheckSqlScriptForUnsupportedCommands
        {
            get { return mCheckSqlScriptForUnsupportedCommands.Value; }
            set { mCheckSqlScriptForUnsupportedCommands.Value = value; }
        }

        public string UpdateFromConnectionStringAttributes
        {
            get { return mUpdateFromConnectionStringAttributes.Value; }
            set { mUpdateFromConnectionStringAttributes.Value = value; }
        }

        public bool? TreadSqlScriptUnsupportedCommandsAsWarning
        {
            get { return mTreadSqlScriptUnsupportedCommandsAsWarning.Value; }
            set { mTreadSqlScriptUnsupportedCommandsAsWarning.Value = value; }
        }

        public string _PackageTempDir
        {
            get { return m_PackageTempDir.Value; }
            set { m_PackageTempDir.Value = value; }
        }

        public string WPPAllFilesInSingleFolder
        {
            get { return mWPPAllFilesInSingleFolder.Value; }
            set { mWPPAllFilesInSingleFolder.Value = value; }
        }

        public bool? IsWPPAllFilesInSingleFolder
        {
            get { return mIsWPPAllFilesInSingleFolder.Value; }
            set { mIsWPPAllFilesInSingleFolder.Value = value; }
        }

        public bool? EnableSqlScriptVariableParameterize
        {
            get { return mEnableSqlScriptVariableParameterize.Value; }
            set { mEnableSqlScriptVariableParameterize.Value = value; }
        }

        public string SqlScriptPreProcessBatchDelimiter
        {
            get { return mSqlScriptPreProcessBatchDelimiter.Value; }
            set { mSqlScriptPreProcessBatchDelimiter.Value = value; }
        }

        public bool? SqlScriptPreProcessResolveIncludes
        {
            get { return mSqlScriptPreProcessResolveIncludes.Value; }
            set { mSqlScriptPreProcessResolveIncludes.Value = value; }
        }

        public string DeployIisAppPath
        {
            get { return mDeployIisAppPath.Value; }
            set { mDeployIisAppPath.Value = value; }
        }

        public string RemoteSitePhysicalPath
        {
            get { return mRemoteSitePhysicalPath.Value; }
            set { mRemoteSitePhysicalPath.Value = value; }
        }

        public string DefaultDeployIisAppPhysicalPath
        {
            get { return mDefaultDeployIisAppPhysicalPath.Value; }
            set { mDefaultDeployIisAppPhysicalPath.Value = value; }
        }

        public string DeployIisAppPhysicalPath
        {
            get { return mDeployIisAppPhysicalPath.Value; }
            set { mDeployIisAppPhysicalPath.Value = value; }
        }

        public string _DestinationIisAppPhysicalPath
        {
            get { return m_DestinationIisAppPhysicalPath.Value; }
            set { m_DestinationIisAppPhysicalPath.Value = value; }
        }

        public string DestinationIisVersion
        {
            get { return mDestinationIisVersion.Value; }
            set { mDestinationIisVersion.Value = value; }
        }

        public string DestinationUseIis
        {
            get { return mDestinationUseIis.Value; }
            set { mDestinationUseIis.Value = value; }
        }

        public string PublishEnableLinks
        {
            get { return mPublishEnableLinks.Value; }
            set { mPublishEnableLinks.Value = value; }
        }

        public string PublishDisableLinks
        {
            get { return mPublishDisableLinks.Value; }
            set { mPublishDisableLinks.Value = value; }
        }

        public string DeployEncryptKey
        {
            get { return mDeployEncryptKey.Value; }
            set { mDeployEncryptKey.Value = value; }
        }

        public bool? SkipExtraFilesOnServer
        {
            get { return mSkipExtraFilesOnServer.Value; }
            set { mSkipExtraFilesOnServer.Value = value; }
        }

        public string MsDeployServiceUrl
        {
            get { return mMsDeployServiceUrl.Value; }
            set { mMsDeployServiceUrl.Value = value; }
        }

        public int? VsIisAppParametersPriority
        {
            get { return mVsIisAppParametersPriority.Value; }
            set { mVsIisAppParametersPriority.Value = value; }
        }

        public int? VsContentPathParametersPriority
        {
            get { return mVsContentPathParametersPriority.Value; }
            set { mVsContentPathParametersPriority.Value = value; }
        }

        public int? VsDestinationVDirParametersPriority
        {
            get { return mVsDestinationVDirParametersPriority.Value; }
            set { mVsDestinationVDirParametersPriority.Value = value; }
        }

        public int? VsSetAclPriority
        {
            get { return mVsSetAclPriority.Value; }
            set { mVsSetAclPriority.Value = value; }
        }

        public int? UserProfileParametersFileParametersPriority
        {
            get { return mUserProfileParametersFileParametersPriority.Value; }
            set { mUserProfileParametersFileParametersPriority.Value = value; }
        }

        public int? UserParametersFileParametersPriority
        {
            get { return mUserParametersFileParametersPriority.Value; }
            set { mUserParametersFileParametersPriority.Value = value; }
        }

        public int? UserWebConfigParametersPriority
        {
            get { return mUserWebConfigParametersPriority.Value; }
            set { mUserWebConfigParametersPriority.Value = value; }
        }

        public int? VsSQLDatabaseScriptParametersPriority
        {
            get { return mVsSQLDatabaseScriptParametersPriority.Value; }
            set { mVsSQLDatabaseScriptParametersPriority.Value = value; }
        }

        public int? VsWebConfigAutoCsParametersPriority
        {
            get { return mVsWebConfigAutoCsParametersPriority.Value; }
            set { mVsWebConfigAutoCsParametersPriority.Value = value; }
        }

        public string GenerateSampleDeployScriptLocation
        {
            get { return mGenerateSampleDeployScriptLocation.Value; }
            set { mGenerateSampleDeployScriptLocation.Value = value; }
        }

        public string PackageSourceManifest
        {
            get { return mPackageSourceManifest.Value; }
            set { mPackageSourceManifest.Value = value; }
        }

        public string UseDeclareParametersXMLInMsDeploy
        {
            get { return mUseDeclareParametersXMLInMsDeploy.Value; }
            set { mUseDeclareParametersXMLInMsDeploy.Value = value; }
        }

        public string PackageParametersFile
        {
            get { return mPackageParametersFile.Value; }
            set { mPackageParametersFile.Value = value; }
        }

        public string PublishParametersFile
        {
            get { return mPublishParametersFile.Value; }
            set { mPublishParametersFile.Value = value; }
        }

        public string GenerateSampleDeployScriptReadMeFileName
        {
            get { return mGenerateSampleDeployScriptReadMeFileName.Value; }
            set { mGenerateSampleDeployScriptReadMeFileName.Value = value; }
        }

        public string GenerateSampleDeployScriptReadMeLocation
        {
            get { return mGenerateSampleDeployScriptReadMeLocation.Value; }
            set { mGenerateSampleDeployScriptReadMeLocation.Value = value; }
        }

        public string GenerateSampleParametersValueLocationDefault
        {
            get { return mGenerateSampleParametersValueLocationDefault.Value; }
            set { mGenerateSampleParametersValueLocationDefault.Value = value; }
        }

        public string GenerateSampleParametersValueLocation
        {
            get { return mGenerateSampleParametersValueLocation.Value; }
            set { mGenerateSampleParametersValueLocation.Value = value; }
        }

        public string GenerateSampleParametersValueFileName
        {
            get { return mGenerateSampleParametersValueFileName.Value; }
            set { mGenerateSampleParametersValueFileName.Value = value; }
        }

        public string FilesToIncludeTargetFile
        {
            get { return mFilesToIncludeTargetFile.Value; }
            set { mFilesToIncludeTargetFile.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets
        {
            get { return mImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftWebPublishingOnlyFilesToRunTheAppTargets.Value = value; }
        }

        public string PublishPipelineCollectFilesCore
        {
            get { return mPublishPipelineCollectFilesCore.Value; }
            set { mPublishPipelineCollectFilesCore.Value = value; }
        }

        public bool? ExcludeTransformAssistFilesFromPublish
        {
            get { return mExcludeTransformAssistFilesFromPublish.Value; }
            set { mExcludeTransformAssistFilesFromPublish.Value = value; }
        }

        public string CollectFilesFromIntermediateAssemblyDependsOn
        {
            get { return mCollectFilesFromIntermediateAssemblyDependsOn.Value; }
            set { mCollectFilesFromIntermediateAssemblyDependsOn.Value = value; }
        }

        public string CollectFilesFromContentDependsOn
        {
            get { return mCollectFilesFromContentDependsOn.Value; }
            set { mCollectFilesFromContentDependsOn.Value = value; }
        }

        public string CollectFilesFromAddModulesDependsOn
        {
            get { return mCollectFilesFromAddModulesDependsOn.Value; }
            set { mCollectFilesFromAddModulesDependsOn.Value = value; }
        }

        public string CollectFilesFrom_SGenDllCreatedDependsOn
        {
            get { return mCollectFilesFrom_SGenDllCreatedDependsOn.Value; }
            set { mCollectFilesFrom_SGenDllCreatedDependsOn.Value = value; }
        }

        public string CollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn
        {
            get { return mCollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn.Value; }
            set { mCollectFilesFromIntermediateSatelliteAssembliesWithTargetPathDependsOn.Value = value; }
        }

        public string CollectFilesFromReferenceDependsOn
        {
            get { return mCollectFilesFromReferenceDependsOn.Value; }
            set { mCollectFilesFromReferenceDependsOn.Value = value; }
        }

        public string CollectFilesFromAllExtraReferenceFilesDependsOn
        {
            get { return mCollectFilesFromAllExtraReferenceFilesDependsOn.Value; }
            set { mCollectFilesFromAllExtraReferenceFilesDependsOn.Value = value; }
        }

        public string CollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn
        {
            get { return mCollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn.Value; }
            set { mCollectFilesFrom_SourceItemsToCopyToOutputDirectoryDependsOn.Value = value; }
        }

        public string CollectFilesFromDocFileItemDependsOn
        {
            get { return mCollectFilesFromDocFileItemDependsOn.Value; }
            set { mCollectFilesFromDocFileItemDependsOn.Value = value; }
        }

        public string CollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn
        {
            get { return mCollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn.Value; }
            set { mCollectFilesFrom_WebApplicationSilverlightXapFilesDependsOn.Value = value; }
        }

        public string CollectFilesFrom_binDeployableAssembliesDependsOn
        {
            get { return mCollectFilesFrom_binDeployableAssembliesDependsOn.Value; }
            set { mCollectFilesFrom_binDeployableAssembliesDependsOn.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets
        {
            get { return mImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets.Value; }
            set { mImportByWildcardAfterMicrosoftWebPublishingOnlyFilesToRunTheAppTargets.Value = value; }
        }

        public bool? AspNetCompileMerge
        {
            get { return mAspNetCompileMerge.Value; }
            set { mAspNetCompileMerge.Value = value; }
        }

        public string Web_Publishing_AspNetCompileMerge_targets
        {
            get { return mWeb_Publishing_AspNetCompileMerge_targets.Value; }
            set { mWeb_Publishing_AspNetCompileMerge_targets.Value = value; }
        }

        public string Microsoft_Web_Publishing_MSDeploy_Common_targets
        {
            get { return mMicrosoft_Web_Publishing_MSDeploy_Common_targets.Value; }
            set { mMicrosoft_Web_Publishing_MSDeploy_Common_targets.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets
        {
            get { return mImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftWebPublishingMSDeployCommonTargets.Value = value; }
        }

        public bool? Microsoft_Web_Publishing_MSDeploy_Common_targets_Imported
        {
            get { return mMicrosoft_Web_Publishing_MSDeploy_Common_targets_Imported.Value; }
            set { mMicrosoft_Web_Publishing_MSDeploy_Common_targets_Imported.Value = value; }
        }

        public bool? InsertEFCodeFirstDeployWebCofig
        {
            get { return mInsertEFCodeFirstDeployWebCofig.Value; }
            set { mInsertEFCodeFirstDeployWebCofig.Value = value; }
        }

        public string InsertEFCodeFirstDeployWebCofigIntermediateOutput
        {
            get { return mInsertEFCodeFirstDeployWebCofigIntermediateOutput.Value; }
            set { mInsertEFCodeFirstDeployWebCofigIntermediateOutput.Value = value; }
        }

        public string InsertEFCodeFirstDeployWebCofigLocation
        {
            get { return mInsertEFCodeFirstDeployWebCofigLocation.Value; }
            set { mInsertEFCodeFirstDeployWebCofigLocation.Value = value; }
        }

        public bool? PublishDatabases
        {
            get { return mPublishDatabases.Value; }
            set { mPublishDatabases.Value = value; }
        }

        public string ProcessPublishDatabaseSettingsDependsOn
        {
            get { return mProcessPublishDatabaseSettingsDependsOn.Value; }
            set { mProcessPublishDatabaseSettingsDependsOn.Value = value; }
        }

        public string ParseSQLScriptForMSDeployParametersDependsOn
        {
            get { return mParseSQLScriptForMSDeployParametersDependsOn.Value; }
            set { mParseSQLScriptForMSDeployParametersDependsOn.Value = value; }
        }

        public string HandleEFCodeFirstDataMigrationDependsOn
        {
            get { return mHandleEFCodeFirstDataMigrationDependsOn.Value; }
            set { mHandleEFCodeFirstDataMigrationDependsOn.Value = value; }
        }

        public string PreInsertEFCodeFirstDeployWebCofigDependsOn
        {
            get { return mPreInsertEFCodeFirstDeployWebCofigDependsOn.Value; }
            set { mPreInsertEFCodeFirstDeployWebCofigDependsOn.Value = value; }
        }

        public string PreInsertEFCodeFirstDeployWebCofigBeforeTarget
        {
            get { return mPreInsertEFCodeFirstDeployWebCofigBeforeTarget.Value; }
            set { mPreInsertEFCodeFirstDeployWebCofigBeforeTarget.Value = value; }
        }

        public string InsertEFCodeFirstDeployWebCofigCoreDependsOn
        {
            get { return mInsertEFCodeFirstDeployWebCofigCoreDependsOn.Value; }
            set { mInsertEFCodeFirstDeployWebCofigCoreDependsOn.Value = value; }
        }

        public string PostInsertEFCodeFirstDeployWebCofigDependsOn
        {
            get { return mPostInsertEFCodeFirstDeployWebCofigDependsOn.Value; }
            set { mPostInsertEFCodeFirstDeployWebCofigDependsOn.Value = value; }
        }

        public string InsertEFCodeFirstDeployWebCofigDependsOn
        {
            get { return mInsertEFCodeFirstDeployWebCofigDependsOn.Value; }
            set { mInsertEFCodeFirstDeployWebCofigDependsOn.Value = value; }
        }

        public string InsertEFCodeFirstDeployWebCofigBeforeTargets
        {
            get { return mInsertEFCodeFirstDeployWebCofigBeforeTargets.Value; }
            set { mInsertEFCodeFirstDeployWebCofigBeforeTargets.Value = value; }
        }

        public string CollectDatabasesToPublishDependsOn
        {
            get { return mCollectDatabasesToPublishDependsOn.Value; }
            set { mCollectDatabasesToPublishDependsOn.Value = value; }
        }

        public string BeforeAddDeclareParametersItemsForDatabaseScript
        {
            get { return mBeforeAddDeclareParametersItemsForDatabaseScript.Value; }
            set { mBeforeAddDeclareParametersItemsForDatabaseScript.Value = value; }
        }

        public string AfterAddDeclareParametersItemsForDatabaseScript
        {
            get { return mAfterAddDeclareParametersItemsForDatabaseScript.Value; }
            set { mAfterAddDeclareParametersItemsForDatabaseScript.Value = value; }
        }

        public string AddDeclareParametersItemsForDatabaseScriptDependsOn
        {
            get { return mAddDeclareParametersItemsForDatabaseScriptDependsOn.Value; }
            set { mAddDeclareParametersItemsForDatabaseScriptDependsOn.Value = value; }
        }

        public string WriteItemsToSourceManifestDependsOn
        {
            get { return mWriteItemsToSourceManifestDependsOn.Value; }
            set { mWriteItemsToSourceManifestDependsOn.Value = value; }
        }

        public string BeforeAddDatabasesToSourceManifest
        {
            get { return mBeforeAddDatabasesToSourceManifest.Value; }
            set { mBeforeAddDatabasesToSourceManifest.Value = value; }
        }

        public string AfterAddDatabasesToSourceManifest
        {
            get { return mAfterAddDatabasesToSourceManifest.Value; }
            set { mAfterAddDatabasesToSourceManifest.Value = value; }
        }

        public string AddDatabasesToSourceManifestDependsOn
        {
            get { return mAddDatabasesToSourceManifestDependsOn.Value; }
            set { mAddDatabasesToSourceManifestDependsOn.Value = value; }
        }

        public string AddDatabasesToSourceManifestAfterTargets
        {
            get { return mAddDatabasesToSourceManifestAfterTargets.Value; }
            set { mAddDatabasesToSourceManifestAfterTargets.Value = value; }
        }

        public string GenerateSampleDeployScriptDependsOn
        {
            get { return mGenerateSampleDeployScriptDependsOn.Value; }
            set { mGenerateSampleDeployScriptDependsOn.Value = value; }
        }

        public string GenerateSampleDeployScriptAfterTargets
        {
            get { return mGenerateSampleDeployScriptAfterTargets.Value; }
            set { mGenerateSampleDeployScriptAfterTargets.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets
        {
            get { return mImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets.Value; }
            set { mImportByWildcardAfterMicrosoftWebPublishingMSDeployCommonTargets.Value = value; }
        }

        public string ExcludeApp_DataDependsOn
        {
            get { return mExcludeApp_DataDependsOn.Value; }
            set { mExcludeApp_DataDependsOn.Value = value; }
        }

        public string ExcludeGeneratedDebugSymbolDependsOn
        {
            get { return mExcludeGeneratedDebugSymbolDependsOn.Value; }
            set { mExcludeGeneratedDebugSymbolDependsOn.Value = value; }
        }

        public string ExcludeXmlAssemblyFilesDependsOn
        {
            get { return mExcludeXmlAssemblyFilesDependsOn.Value; }
            set { mExcludeXmlAssemblyFilesDependsOn.Value = value; }
        }

        public bool? _EnableCleanOnBuildForMvcViews
        {
            get { return m_EnableCleanOnBuildForMvcViews.Value; }
            set { m_EnableCleanOnBuildForMvcViews.Value = value; }
        }

        public bool? EnableExcludeFilesByExtension
        {
            get { return mEnableExcludeFilesByExtension.Value; }
            set { mEnableExcludeFilesByExtension.Value = value; }
        }

        public string ExcludeFilesByExtensionDependsOn
        {
            get { return mExcludeFilesByExtensionDependsOn.Value; }
            set { mExcludeFilesByExtensionDependsOn.Value = value; }
        }

        public string WebPublishExtensionsToExclude
        {
            get { return mWebPublishExtensionsToExclude.Value; }
            set { mWebPublishExtensionsToExclude.Value = value; }
        }

        public string ExcludeFilesFromPackageDependsOn
        {
            get { return mExcludeFilesFromPackageDependsOn.Value; }
            set { mExcludeFilesFromPackageDependsOn.Value = value; }
        }

        public string ValidateGlobalSettingsDependsOn
        {
            get { return mValidateGlobalSettingsDependsOn.Value; }
            set { mValidateGlobalSettingsDependsOn.Value = value; }
        }

        public string ValidateGlobalPackageSettingDependsOn
        {
            get { return mValidateGlobalPackageSettingDependsOn.Value; }
            set { mValidateGlobalPackageSettingDependsOn.Value = value; }
        }

        public string _CleanWPPIfNeedToDependsOn
        {
            get { return m_CleanWPPIfNeedToDependsOn.Value; }
            set { m_CleanWPPIfNeedToDependsOn.Value = value; }
        }

        public string OnBeforePipelineCollectFilesPhase
        {
            get { return mOnBeforePipelineCollectFilesPhase.Value; }
            set { mOnBeforePipelineCollectFilesPhase.Value = value; }
        }

        public string OnAfterPipelineCollectFilesPhase
        {
            get { return mOnAfterPipelineCollectFilesPhase.Value; }
            set { mOnAfterPipelineCollectFilesPhase.Value = value; }
        }

        public string PipelineCollectFilesPhaseDependsOn
        {
            get { return mPipelineCollectFilesPhaseDependsOn.Value; }
            set { mPipelineCollectFilesPhaseDependsOn.Value = value; }
        }

        public string TransformWebConfigBeforeTargets
        {
            get { return mTransformWebConfigBeforeTargets.Value; }
            set { mTransformWebConfigBeforeTargets.Value = value; }
        }

        public string TransformWebConfigDependsOn
        {
            get { return mTransformWebConfigDependsOn.Value; }
            set { mTransformWebConfigDependsOn.Value = value; }
        }

        public string CollectWebConfigsToTransformDependsOn
        {
            get { return mCollectWebConfigsToTransformDependsOn.Value; }
            set { mCollectWebConfigsToTransformDependsOn.Value = value; }
        }

        public string PreTransformWebConfigDependsOn
        {
            get { return mPreTransformWebConfigDependsOn.Value; }
            set { mPreTransformWebConfigDependsOn.Value = value; }
        }

        public string TransformWebConfigCoreDependsOn
        {
            get { return mTransformWebConfigCoreDependsOn.Value; }
            set { mTransformWebConfigCoreDependsOn.Value = value; }
        }

        public string ParameterizeTransformWebConfigCoreDependsOn
        {
            get { return mParameterizeTransformWebConfigCoreDependsOn.Value; }
            set { mParameterizeTransformWebConfigCoreDependsOn.Value = value; }
        }

        public string PostTransformWebConfigDependsOn
        {
            get { return mPostTransformWebConfigDependsOn.Value; }
            set { mPostTransformWebConfigDependsOn.Value = value; }
        }

        public string MarkWebConfigAssistFilesAsExcludeDependsOn
        {
            get { return mMarkWebConfigAssistFilesAsExcludeDependsOn.Value; }
            set { mMarkWebConfigAssistFilesAsExcludeDependsOn.Value = value; }
        }

        public string ProfileTransformWebConfigBeforeTargets
        {
            get { return mProfileTransformWebConfigBeforeTargets.Value; }
            set { mProfileTransformWebConfigBeforeTargets.Value = value; }
        }

        public string ProfileTransformWebConfigAfterTargets
        {
            get { return mProfileTransformWebConfigAfterTargets.Value; }
            set { mProfileTransformWebConfigAfterTargets.Value = value; }
        }

        public string ProfileTransformWebConfigDependsOn
        {
            get { return mProfileTransformWebConfigDependsOn.Value; }
            set { mProfileTransformWebConfigDependsOn.Value = value; }
        }

        public string CollectFilesForProfileTransformWebConfigsDependsOn
        {
            get { return mCollectFilesForProfileTransformWebConfigsDependsOn.Value; }
            set { mCollectFilesForProfileTransformWebConfigsDependsOn.Value = value; }
        }

        public string PreProfileTransformWebConfigDependsOn
        {
            get { return mPreProfileTransformWebConfigDependsOn.Value; }
            set { mPreProfileTransformWebConfigDependsOn.Value = value; }
        }

        public string ProfileTransformWebConfigCoreDependsOn
        {
            get { return mProfileTransformWebConfigCoreDependsOn.Value; }
            set { mProfileTransformWebConfigCoreDependsOn.Value = value; }
        }

        public string ParameterizeProfileTransformWebConfigCoreDependsOn
        {
            get { return mParameterizeProfileTransformWebConfigCoreDependsOn.Value; }
            set { mParameterizeProfileTransformWebConfigCoreDependsOn.Value = value; }
        }

        public string PostProfileTransformWebConfigDependsOn
        {
            get { return mPostProfileTransformWebConfigDependsOn.Value; }
            set { mPostProfileTransformWebConfigDependsOn.Value = value; }
        }

        public string PreInsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get { return mPreInsertAdditionalWebCofigConnectionStringsDependsOn.Value; }
            set { mPreInsertAdditionalWebCofigConnectionStringsDependsOn.Value = value; }
        }

        public string InsertAdditionalWebCofigConnectionStringsCoreDependsOn
        {
            get { return mInsertAdditionalWebCofigConnectionStringsCoreDependsOn.Value; }
            set { mInsertAdditionalWebCofigConnectionStringsCoreDependsOn.Value = value; }
        }

        public string PostInsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get { return mPostInsertAdditionalWebCofigConnectionStringsDependsOn.Value; }
            set { mPostInsertAdditionalWebCofigConnectionStringsDependsOn.Value = value; }
        }

        public string InsertAdditionalWebCofigConnectionStringsDependsOn
        {
            get { return mInsertAdditionalWebCofigConnectionStringsDependsOn.Value; }
            set { mInsertAdditionalWebCofigConnectionStringsDependsOn.Value = value; }
        }

        public string InsertAdditionalWebCofigConnectionStringsBeforeTargets
        {
            get { return mInsertAdditionalWebCofigConnectionStringsBeforeTargets.Value; }
            set { mInsertAdditionalWebCofigConnectionStringsBeforeTargets.Value = value; }
        }

        public string PreAutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get { return mPreAutoParameterizationWebConfigConnectionStringsDependsOn.Value; }
            set { mPreAutoParameterizationWebConfigConnectionStringsDependsOn.Value = value; }
        }

        public string AutoParameterizationWebConfigConnectionStringsCoreDependsOn
        {
            get { return mAutoParameterizationWebConfigConnectionStringsCoreDependsOn.Value; }
            set { mAutoParameterizationWebConfigConnectionStringsCoreDependsOn.Value = value; }
        }

        public string PostAutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get { return mPostAutoParameterizationWebConfigConnectionStringsDependsOn.Value; }
            set { mPostAutoParameterizationWebConfigConnectionStringsDependsOn.Value = value; }
        }

        public string AutoParameterizationWebConfigConnectionStringsDependsOn
        {
            get { return mAutoParameterizationWebConfigConnectionStringsDependsOn.Value; }
            set { mAutoParameterizationWebConfigConnectionStringsDependsOn.Value = value; }
        }

        public string PipelineTransformPhaseDependsOn
        {
            get { return mPipelineTransformPhaseDependsOn.Value; }
            set { mPipelineTransformPhaseDependsOn.Value = value; }
        }

        public string PipelineMsdeploySpecificTransformPhaseBeforeTargets
        {
            get { return mPipelineMsdeploySpecificTransformPhaseBeforeTargets.Value; }
            set { mPipelineMsdeploySpecificTransformPhaseBeforeTargets.Value = value; }
        }

        public string PipelineMsdeploySpecificTransformPhaseDependsOn
        {
            get { return mPipelineMsdeploySpecificTransformPhaseDependsOn.Value; }
            set { mPipelineMsdeploySpecificTransformPhaseDependsOn.Value = value; }
        }

        public string _WPPCopyWebApplicationDependsOn
        {
            get { return m_WPPCopyWebApplicationDependsOn.Value; }
            set { m_WPPCopyWebApplicationDependsOn.Value = value; }
        }

        public string PipelinePreDeployCopyAllFilesToOneFolderDependsOn
        {
            get { return mPipelinePreDeployCopyAllFilesToOneFolderDependsOn.Value; }
            set { mPipelinePreDeployCopyAllFilesToOneFolderDependsOn.Value = value; }
        }

        public string CopyAllFilesToSingleFolderForMsdeployDependsOn
        {
            get { return mCopyAllFilesToSingleFolderForMsdeployDependsOn.Value; }
            set { mCopyAllFilesToSingleFolderForMsdeployDependsOn.Value = value; }
        }

        public string PipelineCopyAllFilesToOneFolderForMsdeployDependsOn
        {
            get { return mPipelineCopyAllFilesToOneFolderForMsdeployDependsOn.Value; }
            set { mPipelineCopyAllFilesToOneFolderForMsdeployDependsOn.Value = value; }
        }

        public string GetProjectWebPropertiesDependsOn
        {
            get { return mGetProjectWebPropertiesDependsOn.Value; }
            set { mGetProjectWebPropertiesDependsOn.Value = value; }
        }

        public string GetMSDeployInstalledVersionPathDependsOn
        {
            get { return mGetMSDeployInstalledVersionPathDependsOn.Value; }
            set { mGetMSDeployInstalledVersionPathDependsOn.Value = value; }
        }

        public string PackageDependsOn
        {
            get { return mPackageDependsOn.Value; }
            set { mPackageDependsOn.Value = value; }
        }

        public string CopyAllFilesToSingleFolderForPackageDependsOn
        {
            get { return mCopyAllFilesToSingleFolderForPackageDependsOn.Value; }
            set { mCopyAllFilesToSingleFolderForPackageDependsOn.Value = value; }
        }

        public string BeforeAddIis7ToSourceManifest
        {
            get { return mBeforeAddIis7ToSourceManifest.Value; }
            set { mBeforeAddIis7ToSourceManifest.Value = value; }
        }

        public string AfterAddIis7ToSourceManifest
        {
            get { return mAfterAddIis7ToSourceManifest.Value; }
            set { mAfterAddIis7ToSourceManifest.Value = value; }
        }

        public string AddIis7ToSourceManifestDependsOn
        {
            get { return mAddIis7ToSourceManifestDependsOn.Value; }
            set { mAddIis7ToSourceManifestDependsOn.Value = value; }
        }

        public string BeforeAddDeclareParametersItemsForIis7
        {
            get { return mBeforeAddDeclareParametersItemsForIis7.Value; }
            set { mBeforeAddDeclareParametersItemsForIis7.Value = value; }
        }

        public string AfterAddDeclareParametersItemsForIis7
        {
            get { return mAfterAddDeclareParametersItemsForIis7.Value; }
            set { mAfterAddDeclareParametersItemsForIis7.Value = value; }
        }

        public string AddDeclareParametersItemsForIis7DependsOn
        {
            get { return mAddDeclareParametersItemsForIis7DependsOn.Value; }
            set { mAddDeclareParametersItemsForIis7DependsOn.Value = value; }
        }

        public string BeforeAddIis6ToSourceManifest
        {
            get { return mBeforeAddIis6ToSourceManifest.Value; }
            set { mBeforeAddIis6ToSourceManifest.Value = value; }
        }

        public string AfterAddIis6ToSourceManifest
        {
            get { return mAfterAddIis6ToSourceManifest.Value; }
            set { mAfterAddIis6ToSourceManifest.Value = value; }
        }

        public string AddIis6ToSourceManifestDependsOn
        {
            get { return mAddIis6ToSourceManifestDependsOn.Value; }
            set { mAddIis6ToSourceManifestDependsOn.Value = value; }
        }

        public string BeforeAddDeclareParametersItemsForIis6
        {
            get { return mBeforeAddDeclareParametersItemsForIis6.Value; }
            set { mBeforeAddDeclareParametersItemsForIis6.Value = value; }
        }

        public string AfterAddDeclareParametersItemsForIis6
        {
            get { return mAfterAddDeclareParametersItemsForIis6.Value; }
            set { mAfterAddDeclareParametersItemsForIis6.Value = value; }
        }

        public string AddDeclareParametersItemsForIis6DependsOn
        {
            get { return mAddDeclareParametersItemsForIis6DependsOn.Value; }
            set { mAddDeclareParametersItemsForIis6DependsOn.Value = value; }
        }

        public string BeforeAddIisSettingAndFileContentsToSourceManifest
        {
            get { return mBeforeAddIisSettingAndFileContentsToSourceManifest.Value; }
            set { mBeforeAddIisSettingAndFileContentsToSourceManifest.Value = value; }
        }

        public string AfterAddIisSettingAndFileContentsToSourceManifest
        {
            get { return mAfterAddIisSettingAndFileContentsToSourceManifest.Value; }
            set { mAfterAddIisSettingAndFileContentsToSourceManifest.Value = value; }
        }

        public string AddIisSettingAndFileContentsToSourceManifestDependsOn
        {
            get { return mAddIisSettingAndFileContentsToSourceManifestDependsOn.Value; }
            set { mAddIisSettingAndFileContentsToSourceManifestDependsOn.Value = value; }
        }

        public string BeforeAddContentPathToSourceManifest
        {
            get { return mBeforeAddContentPathToSourceManifest.Value; }
            set { mBeforeAddContentPathToSourceManifest.Value = value; }
        }

        public string AfterAddContentPathToSourceManifest
        {
            get { return mAfterAddContentPathToSourceManifest.Value; }
            set { mAfterAddContentPathToSourceManifest.Value = value; }
        }

        public string AddContentPathToSourceManifestDependsOn
        {
            get { return mAddContentPathToSourceManifestDependsOn.Value; }
            set { mAddContentPathToSourceManifestDependsOn.Value = value; }
        }

        public string BeforeAddIisAndContentDeclareParametersItems
        {
            get { return mBeforeAddIisAndContentDeclareParametersItems.Value; }
            set { mBeforeAddIisAndContentDeclareParametersItems.Value = value; }
        }

        public string AfterAddIisAndContentDeclareParametersItems
        {
            get { return mAfterAddIisAndContentDeclareParametersItems.Value; }
            set { mAfterAddIisAndContentDeclareParametersItems.Value = value; }
        }

        public string AddIisAndContentDeclareParametersItemsDependsOn
        {
            get { return mAddIisAndContentDeclareParametersItemsDependsOn.Value; }
            set { mAddIisAndContentDeclareParametersItemsDependsOn.Value = value; }
        }

        public string BeforeAddDeclareParametersItemsForContentPath
        {
            get { return mBeforeAddDeclareParametersItemsForContentPath.Value; }
            set { mBeforeAddDeclareParametersItemsForContentPath.Value = value; }
        }

        public string AfterAddDeclareParametersItemsForContentPath
        {
            get { return mAfterAddDeclareParametersItemsForContentPath.Value; }
            set { mAfterAddDeclareParametersItemsForContentPath.Value = value; }
        }

        public string AddDeclareParametersItemsForContentPathDependsOn
        {
            get { return mAddDeclareParametersItemsForContentPathDependsOn.Value; }
            set { mAddDeclareParametersItemsForContentPathDependsOn.Value = value; }
        }

        public string BeforeWriteItemsToSourceManifest
        {
            get { return mBeforeWriteItemsToSourceManifest.Value; }
            set { mBeforeWriteItemsToSourceManifest.Value = value; }
        }

        public string AfterWriteItemsToSourceManifest
        {
            get { return mAfterWriteItemsToSourceManifest.Value; }
            set { mAfterWriteItemsToSourceManifest.Value = value; }
        }

        public string BeforeAddDeclareParametersItems
        {
            get { return mBeforeAddDeclareParametersItems.Value; }
            set { mBeforeAddDeclareParametersItems.Value = value; }
        }

        public string AfterAddDeclareParametersItems
        {
            get { return mAfterAddDeclareParametersItems.Value; }
            set { mAfterAddDeclareParametersItems.Value = value; }
        }

        public string AddDeclareParametersItemsDependsOn
        {
            get { return mAddDeclareParametersItemsDependsOn.Value; }
            set { mAddDeclareParametersItemsDependsOn.Value = value; }
        }

        public string _GatherParamsDependsOn
        {
            get { return m_GatherParamsDependsOn.Value; }
            set { m_GatherParamsDependsOn.Value = value; }
        }

        public string GenerateMsDeployManifestSettingsDependsOn
        {
            get { return mGenerateMsDeployManifestSettingsDependsOn.Value; }
            set { mGenerateMsDeployManifestSettingsDependsOn.Value = value; }
        }

        public string CleanWebsitesPackageCoreDependsOn
        {
            get { return mCleanWebsitesPackageCoreDependsOn.Value; }
            set { mCleanWebsitesPackageCoreDependsOn.Value = value; }
        }

        public string CleanWebsitesPackageDependsOn
        {
            get { return mCleanWebsitesPackageDependsOn.Value; }
            set { mCleanWebsitesPackageDependsOn.Value = value; }
        }

        public string CleanWebsitesWPPAllFilesInSingleFolderDependsOn
        {
            get { return mCleanWebsitesWPPAllFilesInSingleFolderDependsOn.Value; }
            set { mCleanWebsitesWPPAllFilesInSingleFolderDependsOn.Value = value; }
        }

        public string CleanWebPublishPipelineIntermediateOutputDependsOn
        {
            get { return mCleanWebPublishPipelineIntermediateOutputDependsOn.Value; }
            set { mCleanWebPublishPipelineIntermediateOutputDependsOn.Value = value; }
        }

        public string CheckAndCleanMSDeployPackageIfNeededDependsOn
        {
            get { return mCheckAndCleanMSDeployPackageIfNeededDependsOn.Value; }
            set { mCheckAndCleanMSDeployPackageIfNeededDependsOn.Value = value; }
        }

        public string OnAfterGenerateMsdeployManifestFiles
        {
            get { return mOnAfterGenerateMsdeployManifestFiles.Value; }
            set { mOnAfterGenerateMsdeployManifestFiles.Value = value; }
        }

        public string GenerateMsdeployManifestFilesDependsOn
        {
            get { return mGenerateMsdeployManifestFilesDependsOn.Value; }
            set { mGenerateMsdeployManifestFilesDependsOn.Value = value; }
        }

        public string PackageUsingManifestDependsOn
        {
            get { return mPackageUsingManifestDependsOn.Value; }
            set { mPackageUsingManifestDependsOn.Value = value; }
        }

        public string TestDeployPackageToLocalDependsOn
        {
            get { return mTestDeployPackageToLocalDependsOn.Value; }
            set { mTestDeployPackageToLocalDependsOn.Value = value; }
        }

        public bool? NormalizePublishSettings
        {
            get { return mNormalizePublishSettings.Value; }
            set { mNormalizePublishSettings.Value = value; }
        }

        public string AuthType
        {
            get { return mAuthType.Value; }
            set { mAuthType.Value = value; }
        }

        public string MSDeployPublishMethod
        {
            get { return mMSDeployPublishMethod.Value; }
            set { mMSDeployPublishMethod.Value = value; }
        }

        public string GenerateGlobalPublishSettingDependsOn
        {
            get { return mGenerateGlobalPublishSettingDependsOn.Value; }
            set { mGenerateGlobalPublishSettingDependsOn.Value = value; }
        }

        public bool? CreatePackageOnPublish
        {
            get { return mCreatePackageOnPublish.Value; }
            set { mCreatePackageOnPublish.Value = value; }
        }

        public string MSDeployPublishDependsOn
        {
            get { return mMSDeployPublishDependsOn.Value; }
            set { mMSDeployPublishDependsOn.Value = value; }
        }

        public string ValidatePublishProfileSettingsDependsOn
        {
            get { return mValidatePublishProfileSettingsDependsOn.Value; }
            set { mValidatePublishProfileSettingsDependsOn.Value = value; }
        }

        public string WebMSDeployPublishDependsOn
        {
            get { return mWebMSDeployPublishDependsOn.Value; }
            set { mWebMSDeployPublishDependsOn.Value = value; }
        }

        public string WebPackagePublishDependsOn
        {
            get { return mWebPackagePublishDependsOn.Value; }
            set { mWebPackagePublishDependsOn.Value = value; }
        }

        public string WebPublishDependsOn
        {
            get { return mWebPublishDependsOn.Value; }
            set { mWebPublishDependsOn.Value = value; }
        }

        public string PipelineDeployPhaseDependsOn
        {
            get { return mPipelineDeployPhaseDependsOn.Value; }
            set { mPipelineDeployPhaseDependsOn.Value = value; }
        }

        public string PipelineDeployPhaseAfterTargets
        {
            get { return mPipelineDeployPhaseAfterTargets.Value; }
            set { mPipelineDeployPhaseAfterTargets.Value = value; }
        }

        public string DbDacFxPreviewDependsOn
        {
            get { return mDbDacFxPreviewDependsOn.Value; }
            set { mDbDacFxPreviewDependsOn.Value = value; }
        }

        public string DbFullSqlPreviewDependsOn
        {
            get { return mDbFullSqlPreviewDependsOn.Value; }
            set { mDbFullSqlPreviewDependsOn.Value = value; }
        }

        public string ValidateDbDacFxPreviewSettingsDependsOn
        {
            get { return mValidateDbDacFxPreviewSettingsDependsOn.Value; }
            set { mValidateDbDacFxPreviewSettingsDependsOn.Value = value; }
        }

        public string LocalDbDacFxPreviewDependsOn
        {
            get { return mLocalDbDacFxPreviewDependsOn.Value; }
            set { mLocalDbDacFxPreviewDependsOn.Value = value; }
        }

        public string RemoteDbDacFxPreviewDependsOn
        {
            get { return mRemoteDbDacFxPreviewDependsOn.Value; }
            set { mRemoteDbDacFxPreviewDependsOn.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingTargets
        {
            get { return mImportByWildcardAfterMicrosoftWebPublishingTargets.Value; }
            set { mImportByWildcardAfterMicrosoftWebPublishingTargets.Value = value; }
        }

        public string _TransformWebConfigForAzureAuthenticationDependsOn
        {
            get { return m_TransformWebConfigForAzureAuthenticationDependsOn.Value; }
            set { m_TransformWebConfigForAzureAuthenticationDependsOn.Value = value; }
        }

        public string MSBuildFrameworkToolsPath
        {
            get { return mMSBuildFrameworkToolsPath.Value; }
            set { mMSBuildFrameworkToolsPath.Value = value; }
        }

        public string MSBuildFrameworkToolsPath32
        {
            get { return mMSBuildFrameworkToolsPath32.Value; }
            set { mMSBuildFrameworkToolsPath32.Value = value; }
        }

        public string MSBuildFrameworkToolsRoot
        {
            get { return mMSBuildFrameworkToolsRoot.Value; }
            set { mMSBuildFrameworkToolsRoot.Value = value; }
        }

        public string VCTargetsPath
        {
            get { return mVCTargetsPath.Value; }
            set { mVCTargetsPath.Value = value; }
        }

        public string VCTargetsPath10
        {
            get { return mVCTargetsPath10.Value; }
            set { mVCTargetsPath10.Value = value; }
        }

        public string VCTargetsPath11
        {
            get { return mVCTargetsPath11.Value; }
            set { mVCTargetsPath11.Value = value; }
        }

        public string VCTargetsPath12
        {
            get { return mVCTargetsPath12.Value; }
            set { mVCTargetsPath12.Value = value; }
        }

        public string WindowsSDK80Path
        {
            get { return mWindowsSDK80Path.Value; }
            set { mWindowsSDK80Path.Value = value; }
        }

        public string CustomBeforeMicrosoftCommonProps
        {
            get { return mCustomBeforeMicrosoftCommonProps.Value; }
            set { mCustomBeforeMicrosoftCommonProps.Value = value; }
        }

        public string CustomAfterMicrosoftCommonProps
        {
            get { return mCustomAfterMicrosoftCommonProps.Value; }
            set { mCustomAfterMicrosoftCommonProps.Value = value; }
        }

        public bool? MicrosoftCommonPropsHasBeenImported
        {
            get { return mMicrosoftCommonPropsHasBeenImported.Value; }
            set { mMicrosoftCommonPropsHasBeenImported.Value = value; }
        }

        public string WMSJSProject
        {
            get { return mWMSJSProject.Value; }
            set { mWMSJSProject.Value = value; }
        }

        public string WMSJSProjectDirectory
        {
            get { return mWMSJSProjectDirectory.Value; }
            set { mWMSJSProjectDirectory.Value = value; }
        }

        public string TargetFrameworkProfile
        {
            get { return mTargetFrameworkProfile.Value; }
            set { mTargetFrameworkProfile.Value = value; }
        }

        public bool? UseVSHostingProcess
        {
            get { return mUseVSHostingProcess.Value; }
            set { mUseVSHostingProcess.Value = value; }
        }

        public bool? SignAssembly
        {
            get { return mSignAssembly.Value; }
            set { mSignAssembly.Value = value; }
        }

        public string AssemblyOriginatorKeyFile
        {
            get { return mAssemblyOriginatorKeyFile.Value; }
            set { mAssemblyOriginatorKeyFile.Value = value; }
        }

        public string CSharpTargetsPath
        {
            get { return mCSharpTargetsPath.Value; }
            set { mCSharpTargetsPath.Value = value; }
        }

        public string CscToolPath
        {
            get { return mCscToolPath.Value; }
            set { mCscToolPath.Value = value; }
        }

        public bool? ImportByWildcardBefore40MicrosoftCommonTargets
        {
            get { return mImportByWildcardBefore40MicrosoftCommonTargets.Value; }
            set { mImportByWildcardBefore40MicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportByWildcardAfter40MicrosoftCommonTargets
        {
            get { return mImportByWildcardAfter40MicrosoftCommonTargets.Value; }
            set { mImportByWildcardAfter40MicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftCommonTargets
        {
            get { return mImportUserLocationsByWildcardBefore40MicrosoftCommonTargets.Value; }
            set { mImportUserLocationsByWildcardBefore40MicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftCommonTargets
        {
            get { return mImportUserLocationsByWildcardAfter40MicrosoftCommonTargets.Value; }
            set { mImportUserLocationsByWildcardAfter40MicrosoftCommonTargets.Value = value; }
        }

        public bool? ImportByWildcardBefore40MicrosoftCSharpTargets
        {
            get { return mImportByWildcardBefore40MicrosoftCSharpTargets.Value; }
            set { mImportByWildcardBefore40MicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportByWildcardAfter40MicrosoftCSharpTargets
        {
            get { return mImportByWildcardAfter40MicrosoftCSharpTargets.Value; }
            set { mImportByWildcardAfter40MicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets
        {
            get { return mImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets.Value; }
            set { mImportUserLocationsByWildcardBefore40MicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets
        {
            get { return mImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets.Value; }
            set { mImportUserLocationsByWildcardAfter40MicrosoftCSharpTargets.Value = value; }
        }

        public bool? ImportByWildcardBefore40MicrosoftNetFrameworkProps
        {
            get { return mImportByWildcardBefore40MicrosoftNetFrameworkProps.Value; }
            set { mImportByWildcardBefore40MicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportByWildcardAfter40MicrosoftNetFrameworkProps
        {
            get { return mImportByWildcardAfter40MicrosoftNetFrameworkProps.Value; }
            set { mImportByWildcardAfter40MicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps
        {
            get { return mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps.Value; }
            set { mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkProps.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps
        {
            get { return mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps.Value; }
            set { mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkProps.Value = value; }
        }

        public string NetFrameworkTargetsPath
        {
            get { return mNetFrameworkTargetsPath.Value; }
            set { mNetFrameworkTargetsPath.Value = value; }
        }

        public bool? ImportByWildcardBefore40MicrosoftNetFrameworkTargets
        {
            get { return mImportByWildcardBefore40MicrosoftNetFrameworkTargets.Value; }
            set { mImportByWildcardBefore40MicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportByWildcardAfter40MicrosoftNetFrameworkTargets
        {
            get { return mImportByWildcardAfter40MicrosoftNetFrameworkTargets.Value; }
            set { mImportByWildcardAfter40MicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets
        {
            get { return mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets.Value; }
            set { mImportUserLocationsByWildcardBefore40MicrosoftNetFrameworkTargets.Value = value; }
        }

        public bool? ImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets
        {
            get { return mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets.Value; }
            set { mImportUserLocationsByWildcardAfter40MicrosoftNetFrameworkTargets.Value = value; }
        }

        public string XamlBuildTaskPath
        {
            get { return mXamlBuildTaskPath.Value; }
            set { mXamlBuildTaskPath.Value = value; }
        }

        public bool? AllowUnsafeBlocks
        {
            get { return mAllowUnsafeBlocks.Value; }
            set { mAllowUnsafeBlocks.Value = value; }
        }

        public string MinimumVisualStudioVersion
        {
            get { return mMinimumVisualStudioVersion.Value; }
            set { mMinimumVisualStudioVersion.Value = value; }
        }

        public string DefaultLanguage
        {
            get { return mDefaultLanguage.Value; }
            set { mDefaultLanguage.Value = value; }
        }

        public string TargetFrameworkMonikerDisplayName
        {
            get { return mTargetFrameworkMonikerDisplayName.Value; }
            set { mTargetFrameworkMonikerDisplayName.Value = value; }
        }

        public bool? ImplicitlyExpandTargetFramework
        {
            get { return mImplicitlyExpandTargetFramework.Value; }
            set { mImplicitlyExpandTargetFramework.Value = value; }
        }

        public string ImplicitlyExpandTargetFrameworkDependsOn
        {
            get { return mImplicitlyExpandTargetFrameworkDependsOn.Value; }
            set { mImplicitlyExpandTargetFrameworkDependsOn.Value = value; }
        }

        public string ReferencePath
        {
            get { return mReferencePath.Value; }
            set { mReferencePath.Value = value; }
        }

        public bool? IsCodedUITest
        {
            get { return mIsCodedUITest.Value; }
            set { mIsCodedUITest.Value = value; }
        }

        public string TestProjectType
        {
            get { return mTestProjectType.Value; }
            set { mTestProjectType.Value = value; }
        }

        public string RootPath
        {
            get { return mRootPath.Value; }
            set { mRootPath.Value = value; }
        }

        public bool? _InvalidConfigurationError
        {
            get { return m_InvalidConfigurationError.Value; }
            set { m_InvalidConfigurationError.Value = value; }
        }

        public bool? SilverlightBuild
        {
            get { return mSilverlightBuild.Value; }
            set { mSilverlightBuild.Value = value; }
        }

        public string BuildName
        {
            get { return mBuildName.Value; }
            set { mBuildName.Value = value; }
        }

        public int? Project_Major
        {
            get { return mProject_Major.Value; }
            set { mProject_Major.Value = value; }
        }

        public int? Project_Minor
        {
            get { return mProject_Minor.Value; }
            set { mProject_Minor.Value = value; }
        }

        public int? Project_Build
        {
            get { return mProject_Build.Value; }
            set { mProject_Build.Value = value; }
        }

        public int? AssemblyVersion_Build
        {
            get { return mAssemblyVersion_Build.Value; }
            set { mAssemblyVersion_Build.Value = value; }
        }

        public string BuildScriptsPath
        {
            get { return mBuildScriptsPath.Value; }
            set { mBuildScriptsPath.Value = value; }
        }

        public string BuildConfigDescription
        {
            get { return mBuildConfigDescription.Value; }
            set { mBuildConfigDescription.Value = value; }
        }

        public string BuildPath
        {
            get { return mBuildPath.Value; }
            set { mBuildPath.Value = value; }
        }

        public string ToolsPath
        {
            get { return mToolsPath.Value; }
            set { mToolsPath.Value = value; }
        }

        public string TestResultsPath
        {
            get { return mTestResultsPath.Value; }
            set { mTestResultsPath.Value = value; }
        }

        public string AssemblyInfoFile
        {
            get { return mAssemblyInfoFile.Value; }
            set { mAssemblyInfoFile.Value = value; }
        }

        public string AssemblyTitle
        {
            get { return mAssemblyTitle.Value; }
            set { mAssemblyTitle.Value = value; }
        }

        public string AssemblyProduct
        {
            get { return mAssemblyProduct.Value; }
            set { mAssemblyProduct.Value = value; }
        }

        public bool? ComVisible
        {
            get { return mComVisible.Value; }
            set { mComVisible.Value = value; }
        }

        public bool? CLSCompliant
        {
            get { return mCLSCompliant.Value; }
            set { mCLSCompliant.Value = value; }
        }

        public bool? AllowPartiallyTrustedCallers
        {
            get { return mAllowPartiallyTrustedCallers.Value; }
            set { mAllowPartiallyTrustedCallers.Value = value; }
        }

        public string AssemblyVersion_Major
        {
            get { return mAssemblyVersion_Major.Value; }
            set { mAssemblyVersion_Major.Value = value; }
        }

        public string AssemblyVersion_Minor
        {
            get { return mAssemblyVersion_Minor.Value; }
            set { mAssemblyVersion_Minor.Value = value; }
        }

        public int? Build_Number
        {
            get { return mBuild_Number.Value; }
            set { mBuild_Number.Value = value; }
        }

        public string Build_Revision
        {
            get { return mBuild_Revision.Value; }
            set { mBuild_Revision.Value = value; }
        }

        public string TestDetectionExpression
        {
            get { return mTestDetectionExpression.Value; }
            set { mTestDetectionExpression.Value = value; }
        }

        public bool? TestRunner_Enabled
        {
            get { return mTestRunner_Enabled.Value; }
            set { mTestRunner_Enabled.Value = value; }
        }

        public int? TestRunner_Timeout
        {
            get { return mTestRunner_Timeout.Value; }
            set { mTestRunner_Timeout.Value = value; }
        }

        public bool? TestRunner_ContinueOnError
        {
            get { return mTestRunner_ContinueOnError.Value; }
            set { mTestRunner_ContinueOnError.Value = value; }
        }

        public string NUnitExecutable
        {
            get { return mNUnitExecutable.Value; }
            set { mNUnitExecutable.Value = value; }
        }

        public string NUnitPath
        {
            get { return mNUnitPath.Value; }
            set { mNUnitPath.Value = value; }
        }

        public string MSBuildCommunityTasksPath
        {
            get { return mMSBuildCommunityTasksPath.Value; }
            set { mMSBuildCommunityTasksPath.Value = value; }
        }

        public string MSBuildCommunityTasksLib
        {
            get { return mMSBuildCommunityTasksLib.Value; }
            set { mMSBuildCommunityTasksLib.Value = value; }
        }

        public string FileUpgradeFlags
        {
            get { return mFileUpgradeFlags.Value; }
            set { mFileUpgradeFlags.Value = value; }
        }

        public string UpgradeBackupLocation
        {
            get { return mUpgradeBackupLocation.Value; }
            set { mUpgradeBackupLocation.Value = value; }
        }

        public bool? SilverlightApplication
        {
            get { return mSilverlightApplication.Value; }
            set { mSilverlightApplication.Value = value; }
        }

        public string SupportedCultures
        {
            get { return mSupportedCultures.Value; }
            set { mSupportedCultures.Value = value; }
        }

        public bool? XapOutputs
        {
            get { return mXapOutputs.Value; }
            set { mXapOutputs.Value = value; }
        }

        public bool? GenerateSilverlightManifest
        {
            get { return mGenerateSilverlightManifest.Value; }
            set { mGenerateSilverlightManifest.Value = value; }
        }

        public string XapFilename
        {
            get { return mXapFilename.Value; }
            set { mXapFilename.Value = value; }
        }

        public string SilverlightManifestTemplate
        {
            get { return mSilverlightManifestTemplate.Value; }
            set { mSilverlightManifestTemplate.Value = value; }
        }

        public string SilverlightAppEntry
        {
            get { return mSilverlightAppEntry.Value; }
            set { mSilverlightAppEntry.Value = value; }
        }

        public bool? CreateTestPage
        {
            get { return mCreateTestPage.Value; }
            set { mCreateTestPage.Value = value; }
        }

        public bool? ValidateXaml
        {
            get { return mValidateXaml.Value; }
            set { mValidateXaml.Value = value; }
        }

        public bool? EnableOutOfBrowser
        {
            get { return mEnableOutOfBrowser.Value; }
            set { mEnableOutOfBrowser.Value = value; }
        }

        public string OutOfBrowserSettingsFile
        {
            get { return mOutOfBrowserSettingsFile.Value; }
            set { mOutOfBrowserSettingsFile.Value = value; }
        }

        public bool? UsePlatformExtensions
        {
            get { return mUsePlatformExtensions.Value; }
            set { mUsePlatformExtensions.Value = value; }
        }

        public bool? ThrowErrorsInValidation
        {
            get { return mThrowErrorsInValidation.Value; }
            set { mThrowErrorsInValidation.Value = value; }
        }

        public string LinkedServerProject
        {
            get { return mLinkedServerProject.Value; }
            set { mLinkedServerProject.Value = value; }
        }

        public string OldToolsVersion
        {
            get { return mOldToolsVersion.Value; }
            set { mOldToolsVersion.Value = value; }
        }

        public string ProjectType
        {
            get { return mProjectType.Value; }
            set { mProjectType.Value = value; }
        }

        public string ApplicationIcon
        {
            get { return mApplicationIcon.Value; }
            set { mApplicationIcon.Value = value; }
        }

        public string AssemblyKeyContainerName
        {
            get { return mAssemblyKeyContainerName.Value; }
            set { mAssemblyKeyContainerName.Value = value; }
        }

        public string DefaultClientScript
        {
            get { return mDefaultClientScript.Value; }
            set { mDefaultClientScript.Value = value; }
        }

        public string DefaultHTMLPageLayout
        {
            get { return mDefaultHTMLPageLayout.Value; }
            set { mDefaultHTMLPageLayout.Value = value; }
        }

        public string DefaultTargetSchema
        {
            get { return mDefaultTargetSchema.Value; }
            set { mDefaultTargetSchema.Value = value; }
        }

        public string RunPostBuildEvent
        {
            get { return mRunPostBuildEvent.Value; }
            set { mRunPostBuildEvent.Value = value; }
        }

        public string StartupObject
        {
            get { return mStartupObject.Value; }
            set { mStartupObject.Value = value; }
        }

        public string PreBuildEvent
        {
            get { return mPreBuildEvent.Value; }
            set { mPreBuildEvent.Value = value; }
        }

        public string PostBuildEvent
        {
            get { return mPostBuildEvent.Value; }
            set { mPostBuildEvent.Value = value; }
        }

        public string BuildToolsVersion
        {
            get { return mBuildToolsVersion.Value; }
            set { mBuildToolsVersion.Value = value; }
        }

        public string SourceDir
        {
            get { return mSourceDir.Value; }
            set { mSourceDir.Value = value; }
        }

        public string BinDir
        {
            get { return mBinDir.Value; }
            set { mBinDir.Value = value; }
        }

        public string ObjDir
        {
            get { return mObjDir.Value; }
            set { mObjDir.Value = value; }
        }

        public string TestWorkingDir
        {
            get { return mTestWorkingDir.Value; }
            set { mTestWorkingDir.Value = value; }
        }

        public string PackagesOutDir
        {
            get { return mPackagesOutDir.Value; }
            set { mPackagesOutDir.Value = value; }
        }

        public string PackagesDir
        {
            get { return mPackagesDir.Value; }
            set { mPackagesDir.Value = value; }
        }

        public string ToolsDir
        {
            get { return mToolsDir.Value; }
            set { mToolsDir.Value = value; }
        }

        public string NuGetToolPath
        {
            get { return mNuGetToolPath.Value; }
            set { mNuGetToolPath.Value = value; }
        }

        public string NuGetConfigFile
        {
            get { return mNuGetConfigFile.Value; }
            set { mNuGetConfigFile.Value = value; }
        }

        public string NuGetConfigCommandLine
        {
            get { return mNuGetConfigCommandLine.Value; }
            set { mNuGetConfigCommandLine.Value = value; }
        }

        public string NugetRestoreCommand
        {
            get { return mNugetRestoreCommand.Value; }
            set { mNugetRestoreCommand.Value = value; }
        }

        public string ConfigurationGroup
        {
            get { return mConfigurationGroup.Value; }
            set { mConfigurationGroup.Value = value; }
        }

        public string OSGroup
        {
            get { return mOSGroup.Value; }
            set { mOSGroup.Value = value; }
        }

        public bool? NoStdLib
        {
            get { return mNoStdLib.Value; }
            set { mNoStdLib.Value = value; }
        }

        public bool? NoExplicitReferenceToStdLib
        {
            get { return mNoExplicitReferenceToStdLib.Value; }
            set { mNoExplicitReferenceToStdLib.Value = value; }
        }

        public string CommonPath
        {
            get { return mCommonPath.Value; }
            set { mCommonPath.Value = value; }
        }

        public string CommonTestPath
        {
            get { return mCommonTestPath.Value; }
            set { mCommonTestPath.Value = value; }
        }

        public string OSPlatformConfig
        {
            get { return mOSPlatformConfig.Value; }
            set { mOSPlatformConfig.Value = value; }
        }

        public string BaseOutputPath
        {
            get { return mBaseOutputPath.Value; }
            set { mBaseOutputPath.Value = value; }
        }

        public string TestPath
        {
            get { return mTestPath.Value; }
            set { mTestPath.Value = value; }
        }

        public string PackagesBasePath
        {
            get { return mPackagesBasePath.Value; }
            set { mPackagesBasePath.Value = value; }
        }

        public bool? TargetsWindows
        {
            get { return mTargetsWindows.Value; }
            set { mTargetsWindows.Value = value; }
        }

        public string _WindowsKitBinPath
        {
            get { return m_WindowsKitBinPath.Value; }
            set { m_WindowsKitBinPath.Value = value; }
        }

        public string _WindowsPhoneKitBinPath
        {
            get { return m_WindowsPhoneKitBinPath.Value; }
            set { m_WindowsPhoneKitBinPath.Value = value; }
        }

        public string MakePriExeFullPath
        {
            get { return mMakePriExeFullPath.Value; }
            set { mMakePriExeFullPath.Value = value; }
        }

        public string MakeAppxExeFullPath
        {
            get { return mMakeAppxExeFullPath.Value; }
            set { mMakeAppxExeFullPath.Value = value; }
        }

        public string SignAppxPackageExeFullPath
        {
            get { return mSignAppxPackageExeFullPath.Value; }
            set { mSignAppxPackageExeFullPath.Value = value; }
        }

        public string MakePriExtensionPath
        {
            get { return mMakePriExtensionPath.Value; }
            set { mMakePriExtensionPath.Value = value; }
        }

        public string MakePriExtensionPath_x64
        {
            get { return mMakePriExtensionPath_x64.Value; }
            set { mMakePriExtensionPath_x64.Value = value; }
        }

        public bool? ErrorIfBuildToolsRestoredFromIndividualProject
        {
            get { return mErrorIfBuildToolsRestoredFromIndividualProject.Value; }
            set { mErrorIfBuildToolsRestoredFromIndividualProject.Value = value; }
        }

        public string AssemblyVersion
        {
            get { return mAssemblyVersion.Value; }
            set { mAssemblyVersion.Value = value; }
        }

        public string TestCategories
        {
            get { return mTestCategories.Value; }
            set { mTestCategories.Value = value; }
        }

        public string DocumentationFile
        {
            get { return mDocumentationFile.Value; }
            set { mDocumentationFile.Value = value; }
        }

        public bool? GenerateAppxPackageOnBuild
        {
            get { return mGenerateAppxPackageOnBuild.Value; }
            set { mGenerateAppxPackageOnBuild.Value = value; }
        }

        public string NuGetPackageImportStamp
        {
            get { return mNuGetPackageImportStamp.Value; }
            set { mNuGetPackageImportStamp.Value = value; }
        }

        public string DebugEngines
        {
            get { return mDebugEngines.Value; }
            set { mDebugEngines.Value = value; }
        }

        public bool? GenerateAssemblyInfo
        {
            get { return mGenerateAssemblyInfo.Value; }
            set { mGenerateAssemblyInfo.Value = value; }
        }

        public string NoWarn
        {
            get { return mNoWarn.Value; }
            set { mNoWarn.Value = value; }
        }

        public string RuntimeSerializationSources
        {
            get { return mRuntimeSerializationSources.Value; }
            set { mRuntimeSerializationSources.Value = value; }
        }

        public string JsonSources
        {
            get { return mJsonSources.Value; }
            set { mJsonSources.Value = value; }
        }

        public string XmlSources
        {
            get { return mXmlSources.Value; }
            set { mXmlSources.Value = value; }
        }

        public string TextSources
        {
            get { return mTextSources.Value; }
            set { mTextSources.Value = value; }
        }

        public bool? CheckForOverflowUnderflow
        {
            get { return mCheckForOverflowUnderflow.Value; }
            set { mCheckForOverflowUnderflow.Value = value; }
        }

        public bool? ExternallyShipping
        {
            get { return mExternallyShipping.Value; }
            set { mExternallyShipping.Value = value; }
        }

        public bool? RunTestsForProject
        {
            get { return mRunTestsForProject.Value; }
            set { mRunTestsForProject.Value = value; }
        }

        public string CommonPathXPath
        {
            get { return mCommonPathXPath.Value; }
            set { mCommonPathXPath.Value = value; }
        }

        public string TypeScriptTarget
        {
            get { return mTypeScriptTarget.Value; }
            set { mTypeScriptTarget.Value = value; }
        }

        public bool? TypeScriptCompileOnSaveEnabled
        {
            get { return mTypeScriptCompileOnSaveEnabled.Value; }
            set { mTypeScriptCompileOnSaveEnabled.Value = value; }
        }

        public bool? TypeScriptNoImplicitAny
        {
            get { return mTypeScriptNoImplicitAny.Value; }
            set { mTypeScriptNoImplicitAny.Value = value; }
        }

        public string TypeScriptModuleKind
        {
            get { return mTypeScriptModuleKind.Value; }
            set { mTypeScriptModuleKind.Value = value; }
        }

        public bool? TypeScriptRemoveComments
        {
            get { return mTypeScriptRemoveComments.Value; }
            set { mTypeScriptRemoveComments.Value = value; }
        }

        public string TypeScriptOutFile
        {
            get { return mTypeScriptOutFile.Value; }
            set { mTypeScriptOutFile.Value = value; }
        }

        public string TypeScriptOutDir
        {
            get { return mTypeScriptOutDir.Value; }
            set { mTypeScriptOutDir.Value = value; }
        }

        public bool? TypeScriptGeneratesDeclarations
        {
            get { return mTypeScriptGeneratesDeclarations.Value; }
            set { mTypeScriptGeneratesDeclarations.Value = value; }
        }

        public bool? TypeScriptSourceMap
        {
            get { return mTypeScriptSourceMap.Value; }
            set { mTypeScriptSourceMap.Value = value; }
        }

        public string TypeScriptMapRoot
        {
            get { return mTypeScriptMapRoot.Value; }
            set { mTypeScriptMapRoot.Value = value; }
        }

        public string TypeScriptSourceRoot
        {
            get { return mTypeScriptSourceRoot.Value; }
            set { mTypeScriptSourceRoot.Value = value; }
        }

        public bool? TypeScriptNoEmitOnError
        {
            get { return mTypeScriptNoEmitOnError.Value; }
            set { mTypeScriptNoEmitOnError.Value = value; }
        }

        public string TypeScriptToolsVersion
        {
            get { return mTypeScriptToolsVersion.Value; }
            set { mTypeScriptToolsVersion.Value = value; }
        }

        public string VsToolsPath
        {
            get { return mVsToolsPath.Value; }
            set { mVsToolsPath.Value = value; }
        }

        public string CfgPropertyPagesGuidsAddCSharp
        {
            get { return mCfgPropertyPagesGuidsAddCSharp.Value; }
            set { mCfgPropertyPagesGuidsAddCSharp.Value = value; }
        }

        public string CfgPropertyPagesGuidsAddVB
        {
            get { return mCfgPropertyPagesGuidsAddVB.Value; }
            set { mCfgPropertyPagesGuidsAddVB.Value = value; }
        }

        public string CfgPropertyPagesGuidsAddTypeScript
        {
            get { return mCfgPropertyPagesGuidsAddTypeScript.Value; }
            set { mCfgPropertyPagesGuidsAddTypeScript.Value = value; }
        }

        public bool? TypeScriptEnabled
        {
            get { return mTypeScriptEnabled.Value; }
            set { mTypeScriptEnabled.Value = value; }
        }

        public string TypeScriptBuildConfigurations
        {
            get { return mTypeScriptBuildConfigurations.Value; }
            set { mTypeScriptBuildConfigurations.Value = value; }
        }

        public string TscToolPath
        {
            get { return mTscToolPath.Value; }
            set { mTscToolPath.Value = value; }
        }

        public string TscToolExe
        {
            get { return mTscToolExe.Value; }
            set { mTscToolExe.Value = value; }
        }

        public bool? TscYieldDuringToolExecution
        {
            get { return mTscYieldDuringToolExecution.Value; }
            set { mTscYieldDuringToolExecution.Value = value; }
        }

        public bool? ConsolePause
        {
            get { return mConsolePause.Value; }
            set { mConsolePause.Value = value; }
        }

        public string PublishUrl
        {
            get { return mPublishUrl.Value; }
            set { mPublishUrl.Value = value; }
        }

        public bool? Install
        {
            get { return mInstall.Value; }
            set { mInstall.Value = value; }
        }

        public string InstallFrom
        {
            get { return mInstallFrom.Value; }
            set { mInstallFrom.Value = value; }
        }

        public bool? UpdateEnabled
        {
            get { return mUpdateEnabled.Value; }
            set { mUpdateEnabled.Value = value; }
        }

        public string UpdateMode
        {
            get { return mUpdateMode.Value; }
            set { mUpdateMode.Value = value; }
        }

        public int? UpdateInterval
        {
            get { return mUpdateInterval.Value; }
            set { mUpdateInterval.Value = value; }
        }

        public string UpdateIntervalUnits
        {
            get { return mUpdateIntervalUnits.Value; }
            set { mUpdateIntervalUnits.Value = value; }
        }

        public bool? UpdatePeriodically
        {
            get { return mUpdatePeriodically.Value; }
            set { mUpdatePeriodically.Value = value; }
        }

        public bool? UpdateRequired
        {
            get { return mUpdateRequired.Value; }
            set { mUpdateRequired.Value = value; }
        }

        public bool? MapFileExtensions
        {
            get { return mMapFileExtensions.Value; }
            set { mMapFileExtensions.Value = value; }
        }

        public int? ApplicationRevision
        {
            get { return mApplicationRevision.Value; }
            set { mApplicationRevision.Value = value; }
        }

        public string ApplicationVersion
        {
            get { return mApplicationVersion.Value; }
            set { mApplicationVersion.Value = value; }
        }

        public bool? IsWebBootstrapper
        {
            get { return mIsWebBootstrapper.Value; }
            set { mIsWebBootstrapper.Value = value; }
        }

        public bool? UseApplicationTrust
        {
            get { return mUseApplicationTrust.Value; }
            set { mUseApplicationTrust.Value = value; }
        }

        public bool? BootstrapperEnabled
        {
            get { return mBootstrapperEnabled.Value; }
            set { mBootstrapperEnabled.Value = value; }
        }

        public string _FullFrameworkReferenceAssemblyPaths
        {
            get { return m_FullFrameworkReferenceAssemblyPaths.Value; }
            set { m_FullFrameworkReferenceAssemblyPaths.Value = value; }
        }

        public string _TargetFrameworkDirectories
        {
            get { return m_TargetFrameworkDirectories.Value; }
            set { m_TargetFrameworkDirectories.Value = value; }
        }

        public bool? TreatWarningsAsErrors
        {
            get { return mTreatWarningsAsErrors.Value; }
            set { mTreatWarningsAsErrors.Value = value; }
        }

        public bool? RegisterForComInterop
        {
            get { return mRegisterForComInterop.Value; }
            set { mRegisterForComInterop.Value = value; }
        }

        public string GenerateSerializationAssemblies
        {
            get { return mGenerateSerializationAssemblies.Value; }
            set { mGenerateSerializationAssemblies.Value = value; }
        }

        public int? BaseAddress
        {
            get { return mBaseAddress.Value; }
            set { mBaseAddress.Value = value; }
        }

        public string PublishUrlHistory
        {
            get { return mPublishUrlHistory.Value; }
            set { mPublishUrlHistory.Value = value; }
        }

        public string InstallUrlHistory
        {
            get { return mInstallUrlHistory.Value; }
            set { mInstallUrlHistory.Value = value; }
        }

        public string SupportUrlHistory
        {
            get { return mSupportUrlHistory.Value; }
            set { mSupportUrlHistory.Value = value; }
        }

        public string UpdateUrlHistory
        {
            get { return mUpdateUrlHistory.Value; }
            set { mUpdateUrlHistory.Value = value; }
        }

        public string BootstrapperUrlHistory
        {
            get { return mBootstrapperUrlHistory.Value; }
            set { mBootstrapperUrlHistory.Value = value; }
        }

        public string ErrorReportUrlHistory
        {
            get { return mErrorReportUrlHistory.Value; }
            set { mErrorReportUrlHistory.Value = value; }
        }

        public string FallbackCulture
        {
            get { return mFallbackCulture.Value; }
            set { mFallbackCulture.Value = value; }
        }

        public bool? VerifyUploadedFiles
        {
            get { return mVerifyUploadedFiles.Value; }
            set { mVerifyUploadedFiles.Value = value; }
        }

        public string SccProjectName
        {
            get { return mSccProjectName.Value; }
            set { mSccProjectName.Value = value; }
        }

        public string SccLocalPath
        {
            get { return mSccLocalPath.Value; }
            set { mSccLocalPath.Value = value; }
        }

        public string SccAuxPath
        {
            get { return mSccAuxPath.Value; }
            set { mSccAuxPath.Value = value; }
        }

        public string SccProvider
        {
            get { return mSccProvider.Value; }
            set { mSccProvider.Value = value; }
        }

        public string SilverlightVersion
        {
            get { return mSilverlightVersion.Value; }
            set { mSilverlightVersion.Value = value; }
        }

        public bool? NoConfig
        {
            get { return mNoConfig.Value; }
            set { mNoConfig.Value = value; }
        }

        public string VCInstallDir_110
        {
            get { return mVCInstallDir_110.Value; }
            set { mVCInstallDir_110.Value = value; }
        }

        public string WP80ToolSetPath
        {
            get { return mWP80ToolSetPath.Value; }
            set { mWP80ToolSetPath.Value = value; }
        }

        public string WindowsPhoneSdkRegkeyRoot
        {
            get { return mWindowsPhoneSdkRegkeyRoot.Value; }
            set { mWindowsPhoneSdkRegkeyRoot.Value = value; }
        }

        public string WindowsPhoneRegistryBase
        {
            get { return mWindowsPhoneRegistryBase.Value; }
            set { mWindowsPhoneRegistryBase.Value = value; }
        }

        public string WindowsPhoneRegistryBaseVersion
        {
            get { return mWindowsPhoneRegistryBaseVersion.Value; }
            set { mWindowsPhoneRegistryBaseVersion.Value = value; }
        }

        public string RuntimePathRegistryKey
        {
            get { return mRuntimePathRegistryKey.Value; }
            set { mRuntimePathRegistryKey.Value = value; }
        }

        public string ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch
        {
            get { return mResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch.Value; }
            set { mResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch.Value = value; }
        }

        public string WindowsPhoneSdkVersion
        {
            get { return mWindowsPhoneSdkVersion.Value; }
            set { mWindowsPhoneSdkVersion.Value = value; }
        }

        public string WindowsPhoneSdkInstallPath
        {
            get { return mWindowsPhoneSdkInstallPath.Value; }
            set { mWindowsPhoneSdkInstallPath.Value = value; }
        }

        public string WindowsPhone71RegistryBase
        {
            get { return mWindowsPhone71RegistryBase.Value; }
            set { mWindowsPhone71RegistryBase.Value = value; }
        }

        public string WindowsPhone71RegistryBaseVersion
        {
            get { return mWindowsPhone71RegistryBaseVersion.Value; }
            set { mWindowsPhone71RegistryBaseVersion.Value = value; }
        }

        public string WindowsPhone7RegistryBase
        {
            get { return mWindowsPhone7RegistryBase.Value; }
            set { mWindowsPhone7RegistryBase.Value = value; }
        }

        public string WindowsPhone7RegistryBaseVersion
        {
            get { return mWindowsPhone7RegistryBaseVersion.Value; }
            set { mWindowsPhone7RegistryBaseVersion.Value = value; }
        }

        public string WindowsPhoneFxReferencesDisplayName
        {
            get { return mWindowsPhoneFxReferencesDisplayName.Value; }
            set { mWindowsPhoneFxReferencesDisplayName.Value = value; }
        }

        public string PathOfWMAppManifestRelativeToProject
        {
            get { return mPathOfWMAppManifestRelativeToProject.Value; }
            set { mPathOfWMAppManifestRelativeToProject.Value = value; }
        }

        public bool? ImportByWildcardBeforeWindowsPhoneCommonTargets
        {
            get { return mImportByWildcardBeforeWindowsPhoneCommonTargets.Value; }
            set { mImportByWildcardBeforeWindowsPhoneCommonTargets.Value = value; }
        }

        public bool? ImportByWildcardAfterWindowsPhoneCommonTargets
        {
            get { return mImportByWildcardAfterWindowsPhoneCommonTargets.Value; }
            set { mImportByWildcardAfterWindowsPhoneCommonTargets.Value = value; }
        }

        public bool? IncludeBuiltProjectOutputGroup
        {
            get { return mIncludeBuiltProjectOutputGroup.Value; }
            set { mIncludeBuiltProjectOutputGroup.Value = value; }
        }

        public bool? IncludeDebugSymbolsProjectOutputGroup
        {
            get { return mIncludeDebugSymbolsProjectOutputGroup.Value; }
            set { mIncludeDebugSymbolsProjectOutputGroup.Value = value; }
        }

        public bool? IncludeDocumentationProjectOutputGroup
        {
            get { return mIncludeDocumentationProjectOutputGroup.Value; }
            set { mIncludeDocumentationProjectOutputGroup.Value = value; }
        }

        public bool? IncludeSatelliteDllsProjectOutputGroup
        {
            get { return mIncludeSatelliteDllsProjectOutputGroup.Value; }
            set { mIncludeSatelliteDllsProjectOutputGroup.Value = value; }
        }

        public bool? IncludeSourceFilesProjectOutputGroup
        {
            get { return mIncludeSourceFilesProjectOutputGroup.Value; }
            set { mIncludeSourceFilesProjectOutputGroup.Value = value; }
        }

        public bool? IncludeContentFilesProjectOutputGroup
        {
            get { return mIncludeContentFilesProjectOutputGroup.Value; }
            set { mIncludeContentFilesProjectOutputGroup.Value = value; }
        }

        public bool? IncludeSGenFilesOutputGroup
        {
            get { return mIncludeSGenFilesOutputGroup.Value; }
            set { mIncludeSGenFilesOutputGroup.Value = value; }
        }

        public bool? IncludeCopyLocalFilesOutputGroup
        {
            get { return mIncludeCopyLocalFilesOutputGroup.Value; }
            set { mIncludeCopyLocalFilesOutputGroup.Value = value; }
        }

        public bool? IncludeComFilesOutputGroup
        {
            get { return mIncludeComFilesOutputGroup.Value; }
            set { mIncludeComFilesOutputGroup.Value = value; }
        }

        public bool? IncludeCustomOutputGroupForPackaging
        {
            get { return mIncludeCustomOutputGroupForPackaging.Value; }
            set { mIncludeCustomOutputGroupForPackaging.Value = value; }
        }

        public bool? IncludeCopyWinmdArtifactsOutputGroup
        {
            get { return mIncludeCopyWinmdArtifactsOutputGroup.Value; }
            set { mIncludeCopyWinmdArtifactsOutputGroup.Value = value; }
        }

        public bool? IncludeSDKRedistOutputGroup
        {
            get { return mIncludeSDKRedistOutputGroup.Value; }
            set { mIncludeSDKRedistOutputGroup.Value = value; }
        }

        public bool? IncludeGetResolvedSDKReferences
        {
            get { return mIncludeGetResolvedSDKReferences.Value; }
            set { mIncludeGetResolvedSDKReferences.Value = value; }
        }

        public bool? ValidateXapFilenames
        {
            get { return mValidateXapFilenames.Value; }
            set { mValidateXapFilenames.Value = value; }
        }

        public string AllOutputGroupsDependsOn
        {
            get { return mAllOutputGroupsDependsOn.Value; }
            set { mAllOutputGroupsDependsOn.Value = value; }
        }

        public string CopyLocalFilesOutputGroupDependsOn
        {
            get { return mCopyLocalFilesOutputGroupDependsOn.Value; }
            set { mCopyLocalFilesOutputGroupDependsOn.Value = value; }
        }

        public string GetPackagingOutputsDependsOn
        {
            get { return mGetPackagingOutputsDependsOn.Value; }
            set { mGetPackagingOutputsDependsOn.Value = value; }
        }

        public string FilterPackagingOutPutsDependsOn
        {
            get { return mFilterPackagingOutPutsDependsOn.Value; }
            set { mFilterPackagingOutPutsDependsOn.Value = value; }
        }

        public string _GetPackagePropertiesDependsOn
        {
            get { return m_GetPackagePropertiesDependsOn.Value; }
            set { m_GetPackagePropertiesDependsOn.Value = value; }
        }

        public string SignToolPath
        {
            get { return mSignToolPath.Value; }
            set { mSignToolPath.Value = value; }
        }

        public string ValidateXapFilenamesDependsOn
        {
            get { return mValidateXapFilenamesDependsOn.Value; }
            set { mValidateXapFilenamesDependsOn.Value = value; }
        }

        public string ComputeWinMDsDependsOn
        {
            get { return mComputeWinMDsDependsOn.Value; }
            set { mComputeWinMDsDependsOn.Value = value; }
        }

        public string WMAppManifestWinMDRegistrationDependsOn
        {
            get { return mWMAppManifestWinMDRegistrationDependsOn.Value; }
            set { mWMAppManifestWinMDRegistrationDependsOn.Value = value; }
        }

        public bool? ExtMapFileValidationAsError
        {
            get { return mExtMapFileValidationAsError.Value; }
            set { mExtMapFileValidationAsError.Value = value; }
        }

        public bool? OutOfBrowserPlusAppCachingIsSupported
        {
            get { return mOutOfBrowserPlusAppCachingIsSupported.Value; }
            set { mOutOfBrowserPlusAppCachingIsSupported.Value = value; }
        }

        public string FrameworkRegistryBaseWithVersion
        {
            get { return mFrameworkRegistryBaseWithVersion.Value; }
            set { mFrameworkRegistryBaseWithVersion.Value = value; }
        }

        public string RuntimeVersionRegistryKey
        {
            get { return mRuntimeVersionRegistryKey.Value; }
            set { mRuntimeVersionRegistryKey.Value = value; }
        }

        public bool? ReferencesValidationRequiredForWindowsPhone
        {
            get { return mReferencesValidationRequiredForWindowsPhone.Value; }
            set { mReferencesValidationRequiredForWindowsPhone.Value = value; }
        }

        public string CompileXamlDependsOn
        {
            get { return mCompileXamlDependsOn.Value; }
            set { mCompileXamlDependsOn.Value = value; }
        }

        public string ValidateXamlDependsOn
        {
            get { return mValidateXamlDependsOn.Value; }
            set { mValidateXamlDependsOn.Value = value; }
        }

        public string XapPackagerDependsOn
        {
            get { return mXapPackagerDependsOn.Value; }
            set { mXapPackagerDependsOn.Value = value; }
        }

        public string FilesToXapDependsOn
        {
            get { return mFilesToXapDependsOn.Value; }
            set { mFilesToXapDependsOn.Value = value; }
        }

        public string CreateSilverlightAppManifestDependsOn
        {
            get { return mCreateSilverlightAppManifestDependsOn.Value; }
            set { mCreateSilverlightAppManifestDependsOn.Value = value; }
        }

        public string CategorizeSilverlightReferencesDependsOn
        {
            get { return mCategorizeSilverlightReferencesDependsOn.Value; }
            set { mCategorizeSilverlightReferencesDependsOn.Value = value; }
        }

        public string PackagePlatformExtensionsDependsOn
        {
            get { return mPackagePlatformExtensionsDependsOn.Value; }
            set { mPackagePlatformExtensionsDependsOn.Value = value; }
        }

        public bool? ImplicitlyExpandTargetPlatform
        {
            get { return mImplicitlyExpandTargetPlatform.Value; }
            set { mImplicitlyExpandTargetPlatform.Value = value; }
        }

        public string WindowsPhoneSDK_MetadataPath
        {
            get { return mWindowsPhoneSDK_MetadataPath.Value; }
            set { mWindowsPhoneSDK_MetadataPath.Value = value; }
        }

        public string CopyWinmdArtifactsOutputGroupDependsOn
        {
            get { return mCopyWinmdArtifactsOutputGroupDependsOn.Value; }
            set { mCopyWinmdArtifactsOutputGroupDependsOn.Value = value; }
        }

        public string PackagesProjectConfig
        {
            get { return mPackagesProjectConfig.Value; }
            set { mPackagesProjectConfig.Value = value; }
        }

        public string NonInteractiveSwitch
        {
            get { return mNonInteractiveSwitch.Value; }
            set { mNonInteractiveSwitch.Value = value; }
        }

        public string PaddedSolutionDir
        {
            get { return mPaddedSolutionDir.Value; }
            set { mPaddedSolutionDir.Value = value; }
        }

        public string ConfigurationOverrideFile
        {
            get { return mConfigurationOverrideFile.Value; }
            set { mConfigurationOverrideFile.Value = value; }
        }

        public bool? RemoveIntegerChecks
        {
            get { return mRemoveIntegerChecks.Value; }
            set { mRemoveIntegerChecks.Value = value; }
        }

        public string _DisabledWarnings
        {
            get { return m_DisabledWarnings.Value; }
            set { m_DisabledWarnings.Value = value; }
        }

        public string LoadTimeSensitiveItems
        {
            get { return mLoadTimeSensitiveItems.Value; }
            set { mLoadTimeSensitiveItems.Value = value; }
        }

        public string LoadTimeCheckItemLocation
        {
            get { return mLoadTimeCheckItemLocation.Value; }
            set { mLoadTimeCheckItemLocation.Value = value; }
        }

        public string GetRedistListsDependsOn
        {
            get { return mGetRedistListsDependsOn.Value; }
            set { mGetRedistListsDependsOn.Value = value; }
        }

        public bool? UnloadProjectsOnCompletion
        {
            get { return mUnloadProjectsOnCompletion.Value; }
            set { mUnloadProjectsOnCompletion.Value = value; }
        }

        public string WinFXNativePath
        {
            get { return mWinFXNativePath.Value; }
            set { mWinFXNativePath.Value = value; }
        }

        public string WinFXWowPath
        {
            get { return mWinFXWowPath.Value; }
            set { mWinFXWowPath.Value = value; }
        }

        public bool? TargetingClr2Framework
        {
            get { return mTargetingClr2Framework.Value; }
            set { mTargetingClr2Framework.Value = value; }
        }

        public string MSBuildManagedCompilerPath
        {
            get { return mMSBuildManagedCompilerPath.Value; }
            set { mMSBuildManagedCompilerPath.Value = value; }
        }

        public string RiaClientCodeGenDependsOn
        {
            get { return mRiaClientCodeGenDependsOn.Value; }
            set { mRiaClientCodeGenDependsOn.Value = value; }
        }

        public string CoreRiaClientCodeGenDependsOn
        {
            get { return mCoreRiaClientCodeGenDependsOn.Value; }
            set { mCoreRiaClientCodeGenDependsOn.Value = value; }
        }

        public string RiaClientCleanDependsOn
        {
            get { return mRiaClientCleanDependsOn.Value; }
            set { mRiaClientCleanDependsOn.Value = value; }
        }

        public string _RiaClientCodeGenOutputPath
        {
            get { return m_RiaClientCodeGenOutputPath.Value; }
            set { m_RiaClientCodeGenOutputPath.Value = value; }
        }

        public string _RiaClientCodeGenHistoryFile
        {
            get { return m_RiaClientCodeGenHistoryFile.Value; }
            set { m_RiaClientCodeGenHistoryFile.Value = value; }
        }

        public string DefaultClientReferences
        {
            get { return mDefaultClientReferences.Value; }
            set { mDefaultClientReferences.Value = value; }
        }

        public string PrepareForRiaClientCodeGenDependsOn
        {
            get { return mPrepareForRiaClientCodeGenDependsOn.Value; }
            set { mPrepareForRiaClientCodeGenDependsOn.Value = value; }
        }

        public bool? WindowsAppContainer
        {
            get { return mWindowsAppContainer.Value; }
            set { mWindowsAppContainer.Value = value; }
        }

        public bool? SuppressWarningsInPass1
        {
            get { return mSuppressWarningsInPass1.Value; }
            set { mSuppressWarningsInPass1.Value = value; }
        }

        public string TargetPlatformSdkMetadataLocation
        {
            get { return mTargetPlatformSdkMetadataLocation.Value; }
            set { mTargetPlatformSdkMetadataLocation.Value = value; }
        }

        public string TargetPlatformWinMDLocation
        {
            get { return mTargetPlatformWinMDLocation.Value; }
            set { mTargetPlatformWinMDLocation.Value = value; }
        }

        public string AppxMSBuildToolsPath
        {
            get { return mAppxMSBuildToolsPath.Value; }
            set { mAppxMSBuildToolsPath.Value = value; }
        }

        public string AppxMSBuildTaskAssembly
        {
            get { return mAppxMSBuildTaskAssembly.Value; }
            set { mAppxMSBuildTaskAssembly.Value = value; }
        }

        public bool? AppxPackage
        {
            get { return mAppxPackage.Value; }
            set { mAppxPackage.Value = value; }
        }

        public bool? AppxUseHardlinksIfPossible
        {
            get { return mAppxUseHardlinksIfPossible.Value; }
            set { mAppxUseHardlinksIfPossible.Value = value; }
        }

        public bool? AppxSkipUnchangedFiles
        {
            get { return mAppxSkipUnchangedFiles.Value; }
            set { mAppxSkipUnchangedFiles.Value = value; }
        }

        public bool? AppxGeneratePriEnabled
        {
            get { return mAppxGeneratePriEnabled.Value; }
            set { mAppxGeneratePriEnabled.Value = value; }
        }

        public bool? AppxGetPackagePropertiesEnabled
        {
            get { return mAppxGetPackagePropertiesEnabled.Value; }
            set { mAppxGetPackagePropertiesEnabled.Value = value; }
        }

        public bool? AppxPackageIncludePrivateSymbols
        {
            get { return mAppxPackageIncludePrivateSymbols.Value; }
            set { mAppxPackageIncludePrivateSymbols.Value = value; }
        }

        public bool? AppxSymbolPackageEnabled
        {
            get { return mAppxSymbolPackageEnabled.Value; }
            set { mAppxSymbolPackageEnabled.Value = value; }
        }

        public bool? AppxTestLayoutEnabled
        {
            get { return mAppxTestLayoutEnabled.Value; }
            set { mAppxTestLayoutEnabled.Value = value; }
        }

        public bool? AppxPackageValidationEnabled
        {
            get { return mAppxPackageValidationEnabled.Value; }
            set { mAppxPackageValidationEnabled.Value = value; }
        }

        public bool? AppxHarvestWinmdRegistration
        {
            get { return mAppxHarvestWinmdRegistration.Value; }
            set { mAppxHarvestWinmdRegistration.Value = value; }
        }

        public bool? AutoIncrementPackageRevision
        {
            get { return mAutoIncrementPackageRevision.Value; }
            set { mAutoIncrementPackageRevision.Value = value; }
        }

        public bool? AppxPrependPriInitialPath
        {
            get { return mAppxPrependPriInitialPath.Value; }
            set { mAppxPrependPriInitialPath.Value = value; }
        }

        public bool? EnableSigningChecks
        {
            get { return mEnableSigningChecks.Value; }
            set { mEnableSigningChecks.Value = value; }
        }

        public bool? AppxStrictManifestValidationEnabled
        {
            get { return mAppxStrictManifestValidationEnabled.Value; }
            set { mAppxStrictManifestValidationEnabled.Value = value; }
        }

        public bool? AppxFilterOutUnusedLanguagesResourceFileMaps
        {
            get { return mAppxFilterOutUnusedLanguagesResourceFileMaps.Value; }
            set { mAppxFilterOutUnusedLanguagesResourceFileMaps.Value = value; }
        }

        public bool? AppxGeneratePrisForPortableLibrariesEnabled
        {
            get { return mAppxGeneratePrisForPortableLibrariesEnabled.Value; }
            set { mAppxGeneratePrisForPortableLibrariesEnabled.Value = value; }
        }

        public bool? AppxGeneratePackageRecipeEnabled
        {
            get { return mAppxGeneratePackageRecipeEnabled.Value; }
            set { mAppxGeneratePackageRecipeEnabled.Value = value; }
        }

        public bool? _TargetPlatformIsWindowsPhone
        {
            get { return m_TargetPlatformIsWindowsPhone.Value; }
            set { m_TargetPlatformIsWindowsPhone.Value = value; }
        }

        public bool? AppxPackageSigningEnabled
        {
            get { return mAppxPackageSigningEnabled.Value; }
            set { mAppxPackageSigningEnabled.Value = value; }
        }

        public string AppxOSMinVersion
        {
            get { return mAppxOSMinVersion.Value; }
            set { mAppxOSMinVersion.Value = value; }
        }

        public string AppxOSMaxVersionTested
        {
            get { return mAppxOSMaxVersionTested.Value; }
            set { mAppxOSMaxVersionTested.Value = value; }
        }

        public string AppxPackageDirName
        {
            get { return mAppxPackageDirName.Value; }
            set { mAppxPackageDirName.Value = value; }
        }

        public string AppxPackageDirInProjectDir
        {
            get { return mAppxPackageDirInProjectDir.Value; }
            set { mAppxPackageDirInProjectDir.Value = value; }
        }

        public string PlatformSpecificBundleArtifactsListDirName
        {
            get { return mPlatformSpecificBundleArtifactsListDirName.Value; }
            set { mPlatformSpecificBundleArtifactsListDirName.Value = value; }
        }

        public string PlatformSpecificBundleArtifactsListDirInProjectDir
        {
            get { return mPlatformSpecificBundleArtifactsListDirInProjectDir.Value; }
            set { mPlatformSpecificBundleArtifactsListDirInProjectDir.Value = value; }
        }

        public string AppxPackageDir
        {
            get { return mAppxPackageDir.Value; }
            set { mAppxPackageDir.Value = value; }
        }

        public string AppxPackageArtifactsDir
        {
            get { return mAppxPackageArtifactsDir.Value; }
            set { mAppxPackageArtifactsDir.Value = value; }
        }

        public string FinalAppxManifestName
        {
            get { return mFinalAppxManifestName.Value; }
            set { mFinalAppxManifestName.Value = value; }
        }

        public bool? AppxValidateAppxManifest
        {
            get { return mAppxValidateAppxManifest.Value; }
            set { mAppxValidateAppxManifest.Value = value; }
        }

        public string StoreManifestName
        {
            get { return mStoreManifestName.Value; }
            set { mStoreManifestName.Value = value; }
        }

        public string ResgenToolPath
        {
            get { return mResgenToolPath.Value; }
            set { mResgenToolPath.Value = value; }
        }

        public string PdbCopyExeFullPath
        {
            get { return mPdbCopyExeFullPath.Value; }
            set { mPdbCopyExeFullPath.Value = value; }
        }

        public string AppxSymbolStrippedDir
        {
            get { return mAppxSymbolStrippedDir.Value; }
            set { mAppxSymbolStrippedDir.Value = value; }
        }

        public string AppxPriInitialPath
        {
            get { return mAppxPriInitialPath.Value; }
            set { mAppxPriInitialPath.Value = value; }
        }

        public string ProjectPriFileName
        {
            get { return mProjectPriFileName.Value; }
            set { mProjectPriFileName.Value = value; }
        }

        public string ProjectPriFullPath
        {
            get { return mProjectPriFullPath.Value; }
            set { mProjectPriFullPath.Value = value; }
        }

        public string AppxPackageRecipe
        {
            get { return mAppxPackageRecipe.Value; }
            set { mAppxPackageRecipe.Value = value; }
        }

        public string FinalAppxPackageRecipe
        {
            get { return mFinalAppxPackageRecipe.Value; }
            set { mFinalAppxPackageRecipe.Value = value; }
        }

        public bool? AllowLocalNetworkLoopback
        {
            get { return mAllowLocalNetworkLoopback.Value; }
            set { mAllowLocalNetworkLoopback.Value = value; }
        }

        public string AppxDefaultHashAlgorithmId
        {
            get { return mAppxDefaultHashAlgorithmId.Value; }
            set { mAppxDefaultHashAlgorithmId.Value = value; }
        }

        public string AppxPackageFileMap
        {
            get { return mAppxPackageFileMap.Value; }
            set { mAppxPackageFileMap.Value = value; }
        }

        public string LayoutDir
        {
            get { return mLayoutDir.Value; }
            set { mLayoutDir.Value = value; }
        }

        public string ManagedWinmdInprocImplementation
        {
            get { return mManagedWinmdInprocImplementation.Value; }
            set { mManagedWinmdInprocImplementation.Value = value; }
        }

        public bool? UseIncrementalAppxRegistration
        {
            get { return mUseIncrementalAppxRegistration.Value; }
            set { mUseIncrementalAppxRegistration.Value = value; }
        }

        public string AppxPackagingInfoFile
        {
            get { return mAppxPackagingInfoFile.Value; }
            set { mAppxPackagingInfoFile.Value = value; }
        }

        public bool? AppxOSMinVersionReplaceManifestVersion
        {
            get { return mAppxOSMinVersionReplaceManifestVersion.Value; }
            set { mAppxOSMinVersionReplaceManifestVersion.Value = value; }
        }

        public bool? AppxOSMaxVersionTestedReplaceManifestVersion
        {
            get { return mAppxOSMaxVersionTestedReplaceManifestVersion.Value; }
            set { mAppxOSMaxVersionTestedReplaceManifestVersion.Value = value; }
        }

        public string PackagingFileWritesLogPath
        {
            get { return mPackagingFileWritesLogPath.Value; }
            set { mPackagingFileWritesLogPath.Value = value; }
        }

        public string PackagingDirectoryWritesLogPath
        {
            get { return mPackagingDirectoryWritesLogPath.Value; }
            set { mPackagingDirectoryWritesLogPath.Value = value; }
        }

        public bool? AppxCopyLocalFilesOutputGroupIncludeXmlFiles
        {
            get { return mAppxCopyLocalFilesOutputGroupIncludeXmlFiles.Value; }
            set { mAppxCopyLocalFilesOutputGroupIncludeXmlFiles.Value = value; }
        }

        public string AppxPriConfigXmlPackagingSnippetPath
        {
            get { return mAppxPriConfigXmlPackagingSnippetPath.Value; }
            set { mAppxPriConfigXmlPackagingSnippetPath.Value = value; }
        }

        public string AppxPriConfigXmlDefaultSnippetPath
        {
            get { return mAppxPriConfigXmlDefaultSnippetPath.Value; }
            set { mAppxPriConfigXmlDefaultSnippetPath.Value = value; }
        }

        public string TargetPlatformSdkRootOverride
        {
            get { return mTargetPlatformSdkRootOverride.Value; }
            set { mTargetPlatformSdkRootOverride.Value = value; }
        }

        public string TargetPlatformResourceVersion
        {
            get { return mTargetPlatformResourceVersion.Value; }
            set { mTargetPlatformResourceVersion.Value = value; }
        }

        public string AppxPackageExtension
        {
            get { return mAppxPackageExtension.Value; }
            set { mAppxPackageExtension.Value = value; }
        }

        public string AppxSymbolPackageExtension
        {
            get { return mAppxSymbolPackageExtension.Value; }
            set { mAppxSymbolPackageExtension.Value = value; }
        }

        public string AppxBundleExtension
        {
            get { return mAppxBundleExtension.Value; }
            set { mAppxBundleExtension.Value = value; }
        }

        public string AppxStoreContainerExtension
        {
            get { return mAppxStoreContainerExtension.Value; }
            set { mAppxStoreContainerExtension.Value = value; }
        }

        public string AppxIntermediateExtension
        {
            get { return mAppxIntermediateExtension.Value; }
            set { mAppxIntermediateExtension.Value = value; }
        }

        public string AppxBundle
        {
            get { return mAppxBundle.Value; }
            set { mAppxBundle.Value = value; }
        }

        public string AppxBundlePlatforms
        {
            get { return mAppxBundlePlatforms.Value; }
            set { mAppxBundlePlatforms.Value = value; }
        }

        public string AppxBundleProducingPlatform
        {
            get { return mAppxBundleProducingPlatform.Value; }
            set { mAppxBundleProducingPlatform.Value = value; }
        }

        public string AppxBundleResourcePacksProducingPlatform
        {
            get { return mAppxBundleResourcePacksProducingPlatform.Value; }
            set { mAppxBundleResourcePacksProducingPlatform.Value = value; }
        }

        public string AppxLayoutFolderName
        {
            get { return mAppxLayoutFolderName.Value; }
            set { mAppxLayoutFolderName.Value = value; }
        }

        public string AppxLayoutDir
        {
            get { return mAppxLayoutDir.Value; }
            set { mAppxLayoutDir.Value = value; }
        }

        public string AppxBundlePriConfigXmlForSplittingFileName
        {
            get { return mAppxBundlePriConfigXmlForSplittingFileName.Value; }
            set { mAppxBundlePriConfigXmlForSplittingFileName.Value = value; }
        }

        public string AppxBundleAutoResourcePackageQualifiers
        {
            get { return mAppxBundleAutoResourcePackageQualifiers.Value; }
            set { mAppxBundleAutoResourcePackageQualifiers.Value = value; }
        }

        public string AppxBundleSplitResourcesPriPrefix
        {
            get { return mAppxBundleSplitResourcesPriPrefix.Value; }
            set { mAppxBundleSplitResourcesPriPrefix.Value = value; }
        }

        public string AppxBundleSplitResourcesPriPath
        {
            get { return mAppxBundleSplitResourcesPriPath.Value; }
            set { mAppxBundleSplitResourcesPriPath.Value = value; }
        }

        public string AppxBundleSplitResourcesGeneratedFilesListPath
        {
            get { return mAppxBundleSplitResourcesGeneratedFilesListPath.Value; }
            set { mAppxBundleSplitResourcesGeneratedFilesListPath.Value = value; }
        }

        public string AppxBundleSplitResourcesQualifiersPath
        {
            get { return mAppxBundleSplitResourcesQualifiersPath.Value; }
            set { mAppxBundleSplitResourcesQualifiersPath.Value = value; }
        }

        public string AppxBundlePriConfigXmlForMainPackageFileMapFileName
        {
            get { return mAppxBundlePriConfigXmlForMainPackageFileMapFileName.Value; }
            set { mAppxBundlePriConfigXmlForMainPackageFileMapFileName.Value = value; }
        }

        public string AppxBundleMainPackageFileMapIntermediatePrefix
        {
            get { return mAppxBundleMainPackageFileMapIntermediatePrefix.Value; }
            set { mAppxBundleMainPackageFileMapIntermediatePrefix.Value = value; }
        }

        public string AppxBundleMainPackageFileMapSuffix
        {
            get { return mAppxBundleMainPackageFileMapSuffix.Value; }
            set { mAppxBundleMainPackageFileMapSuffix.Value = value; }
        }

        public string AppxBundleMainPackageFileMapIntermediatePath
        {
            get { return mAppxBundleMainPackageFileMapIntermediatePath.Value; }
            set { mAppxBundleMainPackageFileMapIntermediatePath.Value = value; }
        }

        public string AppxBundleMainPackageFileMapIntermediatePriPath
        {
            get { return mAppxBundleMainPackageFileMapIntermediatePriPath.Value; }
            set { mAppxBundleMainPackageFileMapIntermediatePriPath.Value = value; }
        }

        public string AppxBundleMainPackageFileMapGeneratedFilesListPath
        {
            get { return mAppxBundleMainPackageFileMapGeneratedFilesListPath.Value; }
            set { mAppxBundleMainPackageFileMapGeneratedFilesListPath.Value = value; }
        }

        public string AppxBundleMainPackageFileMapPrefix
        {
            get { return mAppxBundleMainPackageFileMapPrefix.Value; }
            set { mAppxBundleMainPackageFileMapPrefix.Value = value; }
        }

        public string AppxBundleMainPackageFileMapPath
        {
            get { return mAppxBundleMainPackageFileMapPath.Value; }
            set { mAppxBundleMainPackageFileMapPath.Value = value; }
        }

        public string AppxBundleFolderSuffix
        {
            get { return mAppxBundleFolderSuffix.Value; }
            set { mAppxBundleFolderSuffix.Value = value; }
        }

        public string PlatformSpecificBundleArtifactsListDir
        {
            get { return mPlatformSpecificBundleArtifactsListDir.Value; }
            set { mPlatformSpecificBundleArtifactsListDir.Value = value; }
        }

        public string AppxDefaultResourceQualifiers_Windows_80
        {
            get { return mAppxDefaultResourceQualifiers_Windows_80.Value; }
            set { mAppxDefaultResourceQualifiers_Windows_80.Value = value; }
        }

        public string AppxDefaultResourceQualifiers_Windows_81
        {
            get { return mAppxDefaultResourceQualifiers_Windows_81.Value; }
            set { mAppxDefaultResourceQualifiers_Windows_81.Value = value; }
        }

        public string AppxDefaultResourceQualifiers_Windows_Phone
        {
            get { return mAppxDefaultResourceQualifiers_Windows_Phone.Value; }
            set { mAppxDefaultResourceQualifiers_Windows_Phone.Value = value; }
        }

        public string AppxDefaultResourceQualifiers
        {
            get { return mAppxDefaultResourceQualifiers.Value; }
            set { mAppxDefaultResourceQualifiers.Value = value; }
        }

        public bool? AppxPackageAllowDebugFrameworkReferencesInManifest
        {
            get { return mAppxPackageAllowDebugFrameworkReferencesInManifest.Value; }
            set { mAppxPackageAllowDebugFrameworkReferencesInManifest.Value = value; }
        }

        public bool? InsertReverseMap
        {
            get { return mInsertReverseMap.Value; }
            set { mInsertReverseMap.Value = value; }
        }

        public string _ProjectPriFullPathOriginal
        {
            get { return m_ProjectPriFullPathOriginal.Value; }
            set { m_ProjectPriFullPathOriginal.Value = value; }
        }

        public bool? IncludePriFilesOutputGroup
        {
            get { return mIncludePriFilesOutputGroup.Value; }
            set { mIncludePriFilesOutputGroup.Value = value; }
        }

        public bool? IncludeProjectPriFile
        {
            get { return mIncludeProjectPriFile.Value; }
            set { mIncludeProjectPriFile.Value = value; }
        }

        public string ValidatePresenceOfAppxManifestItemsDependsOn
        {
            get { return mValidatePresenceOfAppxManifestItemsDependsOn.Value; }
            set { mValidatePresenceOfAppxManifestItemsDependsOn.Value = value; }
        }

        public string _GenerateProjectPriFileDependsOn
        {
            get { return m_GenerateProjectPriFileDependsOn.Value; }
            set { m_GenerateProjectPriFileDependsOn.Value = value; }
        }

        public string _PriConfigXmlPath
        {
            get { return m_PriConfigXmlPath.Value; }
            set { m_PriConfigXmlPath.Value = value; }
        }

        public string _LayoutResfilesPath
        {
            get { return m_LayoutResfilesPath.Value; }
            set { m_LayoutResfilesPath.Value = value; }
        }

        public string _ResourcesResfilesPath
        {
            get { return m_ResourcesResfilesPath.Value; }
            set { m_ResourcesResfilesPath.Value = value; }
        }

        public string _PriResfilesPath
        {
            get { return m_PriResfilesPath.Value; }
            set { m_PriResfilesPath.Value = value; }
        }

        public string _QualifiersPath
        {
            get { return m_QualifiersPath.Value; }
            set { m_QualifiersPath.Value = value; }
        }

        public string _MultipleQualifiersPerDimensionFoundPath
        {
            get { return m_MultipleQualifiersPerDimensionFoundPath.Value; }
            set { m_MultipleQualifiersPerDimensionFoundPath.Value = value; }
        }

        public string _ProjectArchitecturesFilePath
        {
            get { return m_ProjectArchitecturesFilePath.Value; }
            set { m_ProjectArchitecturesFilePath.Value = value; }
        }

        public string _GenerateAppxManifestDependsOn
        {
            get { return m_GenerateAppxManifestDependsOn.Value; }
            set { m_GenerateAppxManifestDependsOn.Value = value; }
        }

        public string _GenerateAppxPackageRecipeDependsOn
        {
            get { return m_GenerateAppxPackageRecipeDependsOn.Value; }
            set { m_GenerateAppxPackageRecipeDependsOn.Value = value; }
        }

        public string _GenerateAppxPackageBaseDependsOn
        {
            get { return m_GenerateAppxPackageBaseDependsOn.Value; }
            set { m_GenerateAppxPackageBaseDependsOn.Value = value; }
        }

        public string _GenerateAppxPackageDependsOn
        {
            get { return m_GenerateAppxPackageDependsOn.Value; }
            set { m_GenerateAppxPackageDependsOn.Value = value; }
        }

        public string _CreateAppxPackageDependsOn
        {
            get { return m_CreateAppxPackageDependsOn.Value; }
            set { m_CreateAppxPackageDependsOn.Value = value; }
        }

        public string _CreateAppxBundlePlatformSpecificArtifactsDependsOn
        {
            get { return m_CreateAppxBundlePlatformSpecificArtifactsDependsOn.Value; }
            set { m_CreateAppxBundlePlatformSpecificArtifactsDependsOn.Value = value; }
        }

        public string _CreateAppxBundleFilesDependsOn
        {
            get { return m_CreateAppxBundleFilesDependsOn.Value; }
            set { m_CreateAppxBundleFilesDependsOn.Value = value; }
        }

        public string ComFilesOutputGroupDependsOn
        {
            get { return mComFilesOutputGroupDependsOn.Value; }
            set { mComFilesOutputGroupDependsOn.Value = value; }
        }

        public string PrepareLayoutDependsOn
        {
            get { return mPrepareLayoutDependsOn.Value; }
            set { mPrepareLayoutDependsOn.Value = value; }
        }

        public string RegisterAppxLayoutDependsOn
        {
            get { return mRegisterAppxLayoutDependsOn.Value; }
            set { mRegisterAppxLayoutDependsOn.Value = value; }
        }

        public string UnRegisterAppxLayoutDependsOn
        {
            get { return mUnRegisterAppxLayoutDependsOn.Value; }
            set { mUnRegisterAppxLayoutDependsOn.Value = value; }
        }

        public string VCInstallDir
        {
            get { return mVCInstallDir.Value; }
            set { mVCInstallDir.Value = value; }
        }

        public bool? XAMLFingerprint
        {
            get { return mXAMLFingerprint.Value; }
            set { mXAMLFingerprint.Value = value; }
        }

        public string XAMLFingerprintIgnorePaths
        {
            get { return mXAMLFingerprintIgnorePaths.Value; }
            set { mXAMLFingerprintIgnorePaths.Value = value; }
        }

        public string PriIndexName
        {
            get { return mPriIndexName.Value; }
            set { mPriIndexName.Value = value; }
        }

        public string OnXamlPreCompileErrorTarget
        {
            get { return mOnXamlPreCompileErrorTarget.Value; }
            set { mOnXamlPreCompileErrorTarget.Value = value; }
        }

        public bool? XamlShareAppDomains
        {
            get { return mXamlShareAppDomains.Value; }
            set { mXamlShareAppDomains.Value = value; }
        }

        public string XamlGeneratedOutputPath
        {
            get { return mXamlGeneratedOutputPath.Value; }
            set { mXamlGeneratedOutputPath.Value = value; }
        }

        public string PrepareLibraryLayoutDependsOn
        {
            get { return mPrepareLibraryLayoutDependsOn.Value; }
            set { mPrepareLibraryLayoutDependsOn.Value = value; }
        }

        public bool? FindInvalidProjectReferences
        {
            get { return mFindInvalidProjectReferences.Value; }
            set { mFindInvalidProjectReferences.Value = value; }
        }

        public string IPhoneResourcePrefix
        {
            get { return mIPhoneResourcePrefix.Value; }
            set { mIPhoneResourcePrefix.Value = value; }
        }

        public string TargetPlatformMonikerDisplayName
        {
            get { return mTargetPlatformMonikerDisplayName.Value; }
            set { mTargetPlatformMonikerDisplayName.Value = value; }
        }

        public string PortableSDKRoot
        {
            get { return mPortableSDKRoot.Value; }
            set { mPortableSDKRoot.Value = value; }
        }

        public string XamlTargetPlatformVersion
        {
            get { return mXamlTargetPlatformVersion.Value; }
            set { mXamlTargetPlatformVersion.Value = value; }
        }

        public string WindowsUIXamlCommonTargets
        {
            get { return mWindowsUIXamlCommonTargets.Value; }
            set { mWindowsUIXamlCommonTargets.Value = value; }
        }

        public string ImplicitlyExpandTargetPlatformDependsOn
        {
            get { return mImplicitlyExpandTargetPlatformDependsOn.Value; }
            set { mImplicitlyExpandTargetPlatformDependsOn.Value = value; }
        }

        public string DeterminePortablePlatformSdkPathDependsOn
        {
            get { return mDeterminePortablePlatformSdkPathDependsOn.Value; }
            set { mDeterminePortablePlatformSdkPathDependsOn.Value = value; }
        }

        public string DeterminePortableBuildCapabilitiesDependsOn
        {
            get { return mDeterminePortableBuildCapabilitiesDependsOn.Value; }
            set { mDeterminePortableBuildCapabilitiesDependsOn.Value = value; }
        }

        public string TargetPlatformRootPath
        {
            get { return mTargetPlatformRootPath.Value; }
            set { mTargetPlatformRootPath.Value = value; }
        }

        public string PackageCertificateKeyFile
        {
            get { return mPackageCertificateKeyFile.Value; }
            set { mPackageCertificateKeyFile.Value = value; }
        }

        public bool? AppXPackage
        {
            get { return mAppXPackage.Value; }
            set { mAppXPackage.Value = value; }
        }

        public string CleanPackageAction
        {
            get { return mCleanPackageAction.Value; }
            set { mCleanPackageAction.Value = value; }
        }

        public string PackageAction
        {
            get { return mPackageAction.Value; }
            set { mPackageAction.Value = value; }
        }

        public string RebuildPackageAction
        {
            get { return mRebuildPackageAction.Value; }
            set { mRebuildPackageAction.Value = value; }
        }

        public string MtouchLink
        {
            get { return mMtouchLink.Value; }
            set { mMtouchLink.Value = value; }
        }

        public string CodesignEntitlements
        {
            get { return mCodesignEntitlements.Value; }
            set { mCodesignEntitlements.Value = value; }
        }

        public bool? MtouchDebug
        {
            get { return mMtouchDebug.Value; }
            set { mMtouchDebug.Value = value; }
        }

        public string MtouchI18n
        {
            get { return mMtouchI18n.Value; }
            set { mMtouchI18n.Value = value; }
        }

        public string MtouchArch
        {
            get { return mMtouchArch.Value; }
            set { mMtouchArch.Value = value; }
        }

        public bool? CodeAnalysisIgnoreBuiltInRuleSets
        {
            get { return mCodeAnalysisIgnoreBuiltInRuleSets.Value; }
            set { mCodeAnalysisIgnoreBuiltInRuleSets.Value = value; }
        }

        public bool? CodeAnalysisIgnoreBuiltInRules
        {
            get { return mCodeAnalysisIgnoreBuiltInRules.Value; }
            set { mCodeAnalysisIgnoreBuiltInRules.Value = value; }
        }

        public bool? RunCodeAnalysis
        {
            get { return mRunCodeAnalysis.Value; }
            set { mRunCodeAnalysis.Value = value; }
        }

        public bool? RunCodeAnalysisOnThisProject
        {
            get { return mRunCodeAnalysisOnThisProject.Value; }
            set { mRunCodeAnalysisOnThisProject.Value = value; }
        }

        public string CodeAnalysisRules
        {
            get { return mCodeAnalysisRules.Value; }
            set { mCodeAnalysisRules.Value = value; }
        }

        public bool? _DeploymentSignClickOnceManifests
        {
            get { return m_DeploymentSignClickOnceManifests.Value; }
            set { m_DeploymentSignClickOnceManifests.Value = value; }
        }

        public string PackageCertificateThumbprint
        {
            get { return mPackageCertificateThumbprint.Value; }
            set { mPackageCertificateThumbprint.Value = value; }
        }

        public bool? AppxAutoIncrementPackageRevision
        {
            get { return mAppxAutoIncrementPackageRevision.Value; }
            set { mAppxAutoIncrementPackageRevision.Value = value; }
        }

        public string TestPageFileName
        {
            get { return mTestPageFileName.Value; }
            set { mTestPageFileName.Value = value; }
        }

        public string ProjectView
        {
            get { return mProjectView.Value; }
            set { mProjectView.Value = value; }
        }

        public bool? Externalconsole
        {
            get { return mExternalconsole.Value; }
            set { mExternalconsole.Value = value; }
        }

        public string NuGetFrameworkVersion
        {
            get { return mNuGetFrameworkVersion.Value; }
            set { mNuGetFrameworkVersion.Value = value; }
        }

        public string ExcludeFromPackage
        {
            get { return mExcludeFromPackage.Value; }
            set { mExcludeFromPackage.Value = value; }
        }

        public string NameOfLastUsedPublishProfile
        {
            get { return mNameOfLastUsedPublishProfile.Value; }
            set { mNameOfLastUsedPublishProfile.Value = value; }
        }

        public bool? ImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets
        {
            get { return mImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets.Value; }
            set { mImportByWildcardBeforeMicrosoftWebPublishingAllFilesInProjectFolderTargets.Value = value; }
        }

        public bool? _CollectFiles_IncludeIgnorableFile
        {
            get { return m_CollectFiles_IncludeIgnorableFile.Value; }
            set { m_CollectFiles_IncludeIgnorableFile.Value = value; }
        }

        public bool? CollectFilesFromProjectFolder_ExcludeSccFiles
        {
            get { return mCollectFilesFromProjectFolder_ExcludeSccFiles.Value; }
            set { mCollectFilesFromProjectFolder_ExcludeSccFiles.Value = value; }
        }

        public string SetExcludeFromProjectFolderDependsOn
        {
            get { return mSetExcludeFromProjectFolderDependsOn.Value; }
            set { mSetExcludeFromProjectFolderDependsOn.Value = value; }
        }

        public string CollectFilesFromProjectFolder_ExcludeSccFilesDependsOn
        {
            get { return mCollectFilesFromProjectFolder_ExcludeSccFilesDependsOn.Value; }
            set { mCollectFilesFromProjectFolder_ExcludeSccFilesDependsOn.Value = value; }
        }

        public string CollectFilesFromProjectFolderDependsOn
        {
            get { return mCollectFilesFromProjectFolderDependsOn.Value; }
            set { mCollectFilesFromProjectFolderDependsOn.Value = value; }
        }

        public bool? ImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets
        {
            get { return mImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets.Value; }
            set { mImportByWildcardAfterMicrosoftWebPublishingAllFilesInProjectFolderTargets.Value = value; }
        }

        public bool? NoWin32Manifest
        {
            get { return mNoWin32Manifest.Value; }
            set { mNoWin32Manifest.Value = value; }
        }

        public string InBrowserSettingsFile
        {
            get { return mInBrowserSettingsFile.Value; }
            set { mInBrowserSettingsFile.Value = value; }
        }

        public bool? RequireInBrowserElevation
        {
            get { return mRequireInBrowserElevation.Value; }
            set { mRequireInBrowserElevation.Value = value; }
        }

        public string RoleType
        {
            get { return mRoleType.Value; }
            set { mRoleType.Value = value; }
        }

        public bool? PortableEnableXamlTargets
        {
            get { return mPortableEnableXamlTargets.Value; }
            set { mPortableEnableXamlTargets.Value = value; }
        }

        public bool? SynthesizeLinkMetadata
        {
            get { return mSynthesizeLinkMetadata.Value; }
            set { mSynthesizeLinkMetadata.Value = value; }
        }

        public bool? HasSharedItems
        {
            get { return mHasSharedItems.Value; }
            set { mHasSharedItems.Value = value; }
        }

        public string SharedGUID
        {
            get { return mSharedGUID.Value; }
            set { mSharedGUID.Value = value; }
        }

        public string Import_RootNamespace
        {
            get { return mImport_RootNamespace.Value; }
            set { mImport_RootNamespace.Value = value; }
        }

        public bool? DisableXbfGeneration
        {
            get { return mDisableXbfGeneration.Value; }
            set { mDisableXbfGeneration.Value = value; }
        }

        public string XamlSavedStateFileName
        {
            get { return mXamlSavedStateFileName.Value; }
            set { mXamlSavedStateFileName.Value = value; }
        }

        public string XamlSavedStateFilePath
        {
            get { return mXamlSavedStateFilePath.Value; }
            set { mXamlSavedStateFilePath.Value = value; }
        }

        public string XamlRootsLog
        {
            get { return mXamlRootsLog.Value; }
            set { mXamlRootsLog.Value = value; }
        }

        public string MarkupCompilePass1DependsOn
        {
            get { return mMarkupCompilePass1DependsOn.Value; }
            set { mMarkupCompilePass1DependsOn.Value = value; }
        }

        public string MarkupCompilePass2DependsOn
        {
            get { return mMarkupCompilePass2DependsOn.Value; }
            set { mMarkupCompilePass2DependsOn.Value = value; }
        }

        public string Prep_ComputeProcessXamlFilesDependsOn
        {
            get { return mPrep_ComputeProcessXamlFilesDependsOn.Value; }
            set { mPrep_ComputeProcessXamlFilesDependsOn.Value = value; }
        }

        public bool? SDKReferenceWarnOnMissingMaxPlatformVersion
        {
            get { return mSDKReferenceWarnOnMissingMaxPlatformVersion.Value; }
            set { mSDKReferenceWarnOnMissingMaxPlatformVersion.Value = value; }
        }

        public string StartArguments
        {
            get { return mStartArguments.Value; }
            set { mStartArguments.Value = value; }
        }

        public bool? EnableSQLServerDebugging
        {
            get { return mEnableSQLServerDebugging.Value; }
            set { mEnableSQLServerDebugging.Value = value; }
        }

        public bool? WPTestProject
        {
            get { return mWPTestProject.Value; }
            set { mWPTestProject.Value = value; }
        }

        public string _DeploymentApplicationUrl
        {
            get { return m_DeploymentApplicationUrl.Value; }
            set { m_DeploymentApplicationUrl.Value = value; }
        }

        public string StartAction
        {
            get { return mStartAction.Value; }
            set { mStartAction.Value = value; }
        }
    }
}