// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; objects in the &quot;deviceStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by device.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneDeviceConfigurationPolicyDeviceStatus", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceStatus")]
    [ResourceTypePropertyName("deviceStatusODataType")]
    [ResourceReference]
    public class Get_IntuneDeviceConfigurationPolicyDeviceStatus : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.")]
        public System.String deviceConfigurationDeviceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Device name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses/{deviceConfigurationDeviceStatusId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object to the &quot;deviceStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by device.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneDeviceConfigurationPolicyDeviceStatus", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceStatus")]
    [ResourceTypePropertyName("deviceStatusODataType")]
    [ResourceReference]
    public class New_IntuneDeviceConfigurationPolicyDeviceStatus : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceConfigurationDeviceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Device name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses/{deviceConfigurationDeviceStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by device.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneDeviceConfigurationPolicyDeviceStatus", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceStatus")]
    [ResourceTypePropertyName("deviceStatusODataType")]
    public class Update_IntuneDeviceConfigurationPolicyDeviceStatus : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.")]
        public System.String deviceConfigurationDeviceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Device name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationDeviceStatus", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses/{deviceConfigurationDeviceStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object from the &quot;deviceStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by device.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses/deviceConfigurationDeviceStatusId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneDeviceConfigurationPolicyDeviceStatus", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceConfigurationDeviceStatus")]
    [ResourceTypePropertyName("deviceStatusODataType")]
    public class Remove_IntuneDeviceConfigurationPolicyDeviceStatus : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationDeviceStatus&quot; object in the &quot;deviceStatuses&quot; collection.")]
        public System.String deviceConfigurationDeviceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/deviceStatuses/{deviceConfigurationDeviceStatusId}";
        }
    }
}