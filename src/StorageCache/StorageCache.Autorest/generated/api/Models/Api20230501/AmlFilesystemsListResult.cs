// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list AML file systems. It contains a list of AML file systems and a URL link to get the next
    /// set of results.
    /// </summary>
    public partial class AmlFilesystemsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystemsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystemsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of AML file system list results, if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystem[] _value;

        /// <summary>List of AML file systems.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystem[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AmlFilesystemsListResult" /> instance.</summary>
        public AmlFilesystemsListResult()
        {

        }
    }
    /// Result of the request to list AML file systems. It contains a list of AML file systems and a URL link to get the next
    /// set of results.
    public partial interface IAmlFilesystemsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of AML file system list results, if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next set of AML file system list results, if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of AML file systems.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of AML file systems.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystem[] Value { get; set; }

    }
    /// Result of the request to list AML file systems. It contains a list of AML file systems and a URL link to get the next
    /// set of results.
    internal partial interface IAmlFilesystemsListResultInternal

    {
        /// <summary>URL to get the next set of AML file system list results, if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>List of AML file systems.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IAmlFilesystem[] Value { get; set; }

    }
}