// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Entity which represents a connection to Mobile threat defense partner.</para>
    /// </summary>
    [Cmdlet("New", "MobileThreatDefenseConnectorObject", DefaultParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector")]
    [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
    public class New_MobileThreatDefenseConnectorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">DateTime of last Heartbeat recieved from the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Data Sync Partner state for this account</para>
        ///     <para type="description">
        ///          Valid values: &apos;unavailable&apos;, &apos;available&apos;, &apos;enabled&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatPartnerTenantState")]
        [Selectable]
        [ValidateSet(@"unavailable", @"available", @"enabled", @"unresponsive")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.")]
        public System.String PartnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AndroidEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IosEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AndroidDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IosDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PartnerUnsupportedOsVersionBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PartnerUnresponsivenessThresholdInDays { get; set; }
    }
}