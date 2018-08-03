// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.pageLinks&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.pageLinks&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PageLinksObject", DefaultParameterSetName = @"#microsoft.graph.pageLinks")]
    [ODataType("microsoft.graph.pageLinks")]
    public class New_PageLinksObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.pageLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.pageLinks", HelpMessage = @"The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object OneNoteClientUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.pageLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.pageLinks", HelpMessage = @"The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object OneNoteWebUrl { get; set; }
    }
}