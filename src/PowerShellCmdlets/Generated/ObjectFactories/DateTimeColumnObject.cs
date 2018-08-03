// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.dateTimeColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.dateTimeColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DateTimeColumnObject", DefaultParameterSetName = @"#microsoft.graph.dateTimeColumn")]
    [ODataType("microsoft.graph.dateTimeColumn")]
    public class New_DateTimeColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dateTimeColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.dateTimeColumn", HelpMessage = @"The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dateTimeColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.dateTimeColumn", HelpMessage = @"The &quot;format&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Format { get; set; }
    }
}