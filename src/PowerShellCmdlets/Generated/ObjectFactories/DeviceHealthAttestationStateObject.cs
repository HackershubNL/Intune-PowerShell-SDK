// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceHealthAttestationState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceHealthAttestationState&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceHealthAttestationStateObject", DefaultParameterSetName = @"#microsoft.graph.deviceHealthAttestationState")]
    [ODataType("microsoft.graph.deviceHealthAttestationState")]
    public class New_DeviceHealthAttestationStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The Timestamp of the last update.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentNamespaceUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The DHA report version. (Namespace version)</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;contentNamespaceUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContentNamespaceUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The DHA report version. (Namespace version)</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;deviceHealthAttestationStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceHealthAttestationStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The HealthAttestation state schema version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;contentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContentVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;issuedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The DateTime when device was evaluated or issued to MDM</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;issuedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset IssuedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attestationIdentityKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;attestationIdentityKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AttestationIdentityKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resetCount&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The number of times a PC device has hibernated or resumed</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;resetCount&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 ResetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;restartCount&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The number of times a PC device has rebooted</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;restartCount&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 RestartCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataExcutionPolicy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">DEP Policy defines a set of hardware and software technologies that perform additional checks on memory </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;dataExcutionPolicy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DataExcutionPolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitLockerStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">On or Off of BitLocker Drive Encryption</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bitLockerStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BitLockerStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bootManagerVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The version of the Boot Manager</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bootManagerVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BootManagerVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrityCheckVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The version of the Boot Manager</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;codeIntegrityCheckVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CodeIntegrityCheckVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureBoot&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">When Secure Boot is enabled, the core components must have the correct cryptographic signatures</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;secureBoot&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SecureBoot { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bootDebugging&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">When bootDebugging is enabled, the device is used in development and testing</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bootDebugging&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BootDebugging { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemKernelDebugging&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">When operatingSystemKernelDebugging is enabled, the device is used in development and testing</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;operatingSystemKernelDebugging&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OperatingSystemKernelDebugging { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrity&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description"> When code integrity is enabled, code execution is restricted to integrity verified code</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;codeIntegrity&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CodeIntegrity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;testSigning&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">When test signing is allowed, the device does not enforce signature validation during boot</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;testSigning&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String TestSigning { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;safeMode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">Safe mode is a troubleshooting option for Windows that starts your computer in a limited state</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;safeMode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SafeMode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsPE&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">Operating system running with limited services that is used to prepare a computer for Windows</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;windowsPE&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String WindowsPE { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;earlyLaunchAntiMalwareDriverProtection&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">ELAM provides protection for the computers in your network when they start up</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverProtection&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String EarlyLaunchAntiMalwareDriverProtection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;virtualSecureMode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">VSM is a container that protects high value assets from a compromised kernel</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;virtualSecureMode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String VirtualSecureMode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pcrHashAlgorithm&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">Informational attribute that identifies the HASH algorithm that was used by TPM</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;pcrHashAlgorithm&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PcrHashAlgorithm { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bootAppSecurityVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The security version number of the Boot Application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bootAppSecurityVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BootAppSecurityVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bootManagerSecurityVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The security version number of the Boot Application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bootManagerSecurityVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BootManagerSecurityVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tpmVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The security version number of the Boot Application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;tpmVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String TpmVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pcr0&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The measurement that is captured in PCR[0]</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;pcr0&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Pcr0 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureBootConfigurationPolicyFingerPrint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">Fingerprint of the Custom Secure Boot Configuration Policy</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;secureBootConfigurationPolicyFingerPrint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SecureBootConfigurationPolicyFingerPrint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrityPolicy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The Code Integrity policy that is controlling the security of the boot environment</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;codeIntegrityPolicy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CodeIntegrityPolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bootRevisionListInfo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The Boot Revision List that was loaded during initial boot on the attested device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;bootRevisionListInfo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BootRevisionListInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemRevListInfo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">The Operating System Revision List that was loaded during initial boot on the attested device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;operatingSystemRevListInfo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OperatingSystemRevListInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;healthStatusMismatchInfo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">This attribute appears if DHA-Service detects an integrity issue</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;healthStatusMismatchInfo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String HealthStatusMismatchInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;healthAttestationSupportedStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceHealthAttestationState&quot; type.</para>
        ///     <para type="description">This attribute indicates if DHA is supported for the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceHealthAttestationState", HelpMessage = @"The &quot;healthAttestationSupportedStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String HealthAttestationSupportedStatus { get; set; }
    }
}