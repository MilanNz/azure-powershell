// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ResourceNavigationLink resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResourceNavigationLink : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ResourceNavigationLink class.
        /// </summary>
        public ResourceNavigationLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceNavigationLink class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="linkedResourceType">Resource type of the linked
        /// resource.</param>
        /// <param name="link">Link to the external resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource navigation link resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Resource type.</param>
        public ResourceNavigationLink(string id = default(string), string linkedResourceType = default(string), string link = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            LinkedResourceType = linkedResourceType;
            Link = link;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource type of the linked resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedResourceType")]
        public string LinkedResourceType { get; set; }

        /// <summary>
        /// Gets or sets link to the external resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource navigation link
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
