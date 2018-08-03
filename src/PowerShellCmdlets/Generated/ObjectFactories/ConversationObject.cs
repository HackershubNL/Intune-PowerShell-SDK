// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.conversation&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.conversation&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ConversationObject", DefaultParameterSetName = @"#microsoft.graph.conversation")]
    [ODataType("microsoft.graph.conversation")]
    public class New_ConversationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;topic&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;topic&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Topic { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean HasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastDeliveredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;lastDeliveredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastDeliveredDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueSenders&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;uniqueSenders&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] UniqueSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;preview&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Preview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversationThread")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.conversation", HelpMessage = @"The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.")]
        public System.Object[] Threads { get; set; }
    }
}