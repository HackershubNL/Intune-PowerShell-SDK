// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagement&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagement&quot; (or one of its derived types).</para>
    ///     <para type="description">Singleton entity that acts as a container for all device management functionality.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementObject", DefaultParameterSetName = @"microsoft.graph.deviceManagement")]
    [ODataType("microsoft.graph.deviceManagement")]
    public class New_DeviceManagementObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;subscriptionState&quot; property, of type &quot;microsoft.graph.deviceManagementSubscriptionState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Tenant mobile device management subscription state.</para>
        ///     <para type="description">
        ///          Valid values: &apos;pending&apos;, &apos;active&apos;, &apos;warning&apos;, &apos;disabled&apos;, &apos;deleted&apos;, &apos;blocked&apos;, &apos;lockedOut&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementSubscriptionState")]
        [Selectable]
        [ValidateSet(@"pending", @"active", @"warning", @"disabled", @"deleted", @"blocked", @"lockedOut")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;subscriptionState&quot; property, of type &quot;microsoft.graph.deviceManagementSubscriptionState&quot;.")]
        public System.String subscriptionState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.deviceManagementSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Account level settings.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.deviceManagementSettings&quot;.")]
        public System.Object settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intuneBrand&quot; property, of type &quot;microsoft.graph.intuneBrand&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</para>
        /// </summary>
        [ODataType("microsoft.graph.intuneBrand")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;intuneBrand&quot; property, of type &quot;microsoft.graph.intuneBrand&quot;.")]
        public System.Object intuneBrand { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The terms and conditions associated with device management of the company.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        public System.Object[] termsAndConditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applePushNotificationCertificate&quot; property, of type &quot;microsoft.graph.applePushNotificationCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Apple push notification certificate.</para>
        /// </summary>
        [ODataType("microsoft.graph.applePushNotificationCertificate")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;applePushNotificationCertificate&quot; property, of type &quot;microsoft.graph.applePushNotificationCertificate&quot;.")]
        public System.Object applePushNotificationCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOverview&quot; property, of type &quot;microsoft.graph.managedDeviceOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Device overview</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOverview")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;managedDeviceOverview&quot; property, of type &quot;microsoft.graph.managedDeviceOverview&quot;.")]
        public System.Object managedDeviceOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;detectedApps&quot; property, of type &quot;microsoft.graph.detectedApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of detected apps associated with a device.</para>
        /// </summary>
        [ODataType("microsoft.graph.detectedApp")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;detectedApps&quot; property, of type &quot;microsoft.graph.detectedApp&quot;.")]
        public System.Object[] detectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of managed devices.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] managedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurations&quot; property, of type &quot;microsoft.graph.deviceConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfiguration", "microsoft.graph.windows10TeamGeneralConfiguration", "microsoft.graph.windowsPhone81GeneralConfiguration", "microsoft.graph.windows81GeneralConfiguration", "microsoft.graph.windowsUpdateForBusinessConfiguration", "microsoft.graph.windowsPhone81CustomConfiguration", "microsoft.graph.windows10SecureAssessmentConfiguration", "microsoft.graph.sharedPCConfiguration", "microsoft.graph.windows10EnterpriseModernAppManagementConfiguration", "microsoft.graph.windows10CustomConfiguration", "microsoft.graph.windows10GeneralConfiguration", "microsoft.graph.windows10EndpointProtectionConfiguration", "microsoft.graph.editionUpgradeConfiguration", "microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration", "microsoft.graph.appleDeviceFeaturesConfigurationBase", "microsoft.graph.macOSDeviceFeaturesConfiguration", "microsoft.graph.iosDeviceFeaturesConfiguration", "microsoft.graph.macOSGeneralDeviceConfiguration", "microsoft.graph.macOSCustomConfiguration", "microsoft.graph.iosUpdateConfiguration", "microsoft.graph.iosGeneralDeviceConfiguration", "microsoft.graph.iosCustomConfiguration", "microsoft.graph.iosCertificateProfile", "microsoft.graph.androidWorkProfileGeneralDeviceConfiguration", "microsoft.graph.androidWorkProfileCustomConfiguration", "microsoft.graph.androidGeneralDeviceConfiguration", "microsoft.graph.androidCustomConfiguration")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceConfigurations&quot; property, of type &quot;microsoft.graph.deviceConfiguration&quot;.")]
        public System.Object[] deviceConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicies&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device compliance policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidWorkProfileCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicies&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicy&quot;.")]
        public System.Object[] deviceCompliancePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;softwareUpdateStatusSummary&quot; property, of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The software update status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;softwareUpdateStatusSummary&quot; property, of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;.")]
        public System.Object softwareUpdateStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyDeviceStateSummary&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device compliance state summary for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicyDeviceStateSummary&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;.")]
        public System.Object deviceCompliancePolicyDeviceStateSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicySettingStateSummaries&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The summary states of compliance policy settings for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicySettingStateSummaries&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot;.")]
        public System.Object[] deviceCompliancePolicySettingStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationDeviceStateSummaries&quot; property, of type &quot;microsoft.graph.deviceConfigurationDeviceStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device configuration device state summary for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationDeviceStateSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceConfigurationDeviceStateSummaries&quot; property, of type &quot;microsoft.graph.deviceConfigurationDeviceStateSummary&quot;.")]
        public System.Object deviceConfigurationDeviceStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosUpdateStatuses&quot; property, of type &quot;microsoft.graph.iosUpdateDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The IOS software update installation statuses for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosUpdateDeviceStatus")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;iosUpdateStatuses&quot; property, of type &quot;microsoft.graph.iosUpdateDeviceStatus&quot;.")]
        public System.Object[] iosUpdateStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategories&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of device categories with the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCategories&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.")]
        public System.Object[] deviceCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeConnectors&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;exchangeConnectors&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.")]
        public System.Object[] exchangeConnectors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentConfigurations&quot; property, of type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of device enrollment configurations</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceEnrollmentConfigurations&quot; property, of type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.")]
        public System.Object[] deviceEnrollmentConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditionalAccessSettings&quot; property, of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
        /// </summary>
        [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;conditionalAccessSettings&quot; property, of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;.")]
        public System.Object conditionalAccessSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileThreatDefenseConnectors&quot; property, of type &quot;microsoft.graph.mobileThreatDefenseConnector&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;mobileThreatDefenseConnectors&quot; property, of type &quot;microsoft.graph.mobileThreatDefenseConnector&quot;.")]
        public System.Object[] mobileThreatDefenseConnectors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementPartners&quot; property, of type &quot;microsoft.graph.deviceManagementPartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartner")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceManagementPartners&quot; property, of type &quot;microsoft.graph.deviceManagementPartner&quot;.")]
        public System.Object[] deviceManagementPartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationMessageTemplates&quot; property, of type &quot;microsoft.graph.notificationMessageTemplate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Notification Message Templates.</para>
        /// </summary>
        [ODataType("microsoft.graph.notificationMessageTemplate")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;notificationMessageTemplates&quot; property, of type &quot;microsoft.graph.notificationMessageTemplate&quot;.")]
        public System.Object[] notificationMessageTemplates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinitions&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Role Definitions.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition", "microsoft.graph.deviceAndAppManagementRoleDefinition")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;roleDefinitions&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        public System.Object[] roleDefinitions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Role Assignments.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot;.")]
        public System.Object[] roleAssignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceOperations&quot; property, of type &quot;microsoft.graph.resourceOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Resource Operations.</para>
        /// </summary>
        [ODataType("microsoft.graph.resourceOperation")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;resourceOperations&quot; property, of type &quot;microsoft.graph.resourceOperation&quot;.")]
        public System.Object[] resourceOperations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;telecomExpenseManagementPartners&quot; property, of type &quot;microsoft.graph.telecomExpenseManagementPartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The telecom expense management partners.</para>
        /// </summary>
        [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;telecomExpenseManagementPartners&quot; property, of type &quot;microsoft.graph.telecomExpenseManagementPartner&quot;.")]
        public System.Object[] telecomExpenseManagementPartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistancePartners&quot; property, of type &quot;microsoft.graph.remoteAssistancePartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The remote assist partners.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistancePartner")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;remoteAssistancePartners&quot; property, of type &quot;microsoft.graph.remoteAssistancePartner&quot;.")]
        public System.Object[] remoteAssistancePartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionAppLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The windows information protection app learning summaries.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;windowsInformationProtectionAppLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot;.")]
        public System.Object[] windowsInformationProtectionAppLearningSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionNetworkLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The windows information protection network learning summaries.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;windowsInformationProtectionNetworkLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.")]
        public System.Object[] windowsInformationProtectionNetworkLearningSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;troubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent", "microsoft.graph.enrollmentTroubleshootingEvent")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagement", HelpMessage = @"The &quot;troubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.")]
        public System.Object[] troubleshootingEvents { get; set; }
    }
}