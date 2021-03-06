// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationState&quot; (or one of its derived types).</para>
    ///     <para type="description">Device Configuration State for a given device.</para>
    /// </summary>
    [Cmdlet("New", "DeviceConfigurationStateObject", DefaultParameterSetName = @"microsoft.graph.deviceConfigurationState")]
    [ODataType("microsoft.graph.deviceConfigurationState")]
    public class New_DeviceConfigurationStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationSettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationSettingState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationSettingState&quot;.")]
        public System.Object[] settingStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        ///     <para type="description">The name of the policy for this policyBase</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        ///     <para type="description">The version of the policy</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        ///     <para type="description">Platform type that the policy applies to</para>
        ///     <para type="description">
        ///          Valid values: &apos;android&apos;, &apos;iOS&apos;, &apos;macOS&apos;, &apos;windowsPhone81&apos;, &apos;windows81AndLater&apos;, &apos;windows10AndLater&apos;, &apos;androidWorkProfile&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [ValidateSet(@"android", @"iOS", @"macOS", @"windowsPhone81", @"windows81AndLater", @"windows10AndLater", @"androidWorkProfile", @"all")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        ///     <para type="description">The compliance state of the policy</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationState&quot; type.</para>
        ///     <para type="description">Count of how many setting a policy holds</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationState", HelpMessage = @"The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 settingCount { get; set; }
    }
}