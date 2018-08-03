// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.personType&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.personType&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PersonTypeObject", DefaultParameterSetName = @"#microsoft.graph.personType")]
    [ODataType("microsoft.graph.personType")]
    public class New_PersonTypeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;class&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.personType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.personType", HelpMessage = @"The &quot;class&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Class { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subclass&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.personType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.personType", HelpMessage = @"The &quot;subclass&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Subclass { get; set; }
    }
}