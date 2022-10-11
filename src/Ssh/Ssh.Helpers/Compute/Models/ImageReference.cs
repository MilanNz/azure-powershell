// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies information about the image to use. You can specify
    /// information about platform images, marketplace images, or virtual
    /// machine images. This element is required when you want to use a
    /// platform image, marketplace image, or virtual machine image, but is not
    /// used in other creation operations. NOTE: Image reference publisher and
    /// offer can only be set when you create the scale set.
    /// </summary>
    public partial class ImageReference : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="publisher">The image publisher.</param>
        /// <param name="offer">Specifies the offer of the platform image or
        /// marketplace image used to create the virtual machine.</param>
        /// <param name="sku">The image SKU.</param>
        /// <param name="version">Specifies the version of the platform image
        /// or marketplace image used to create the virtual machine. The
        /// allowed formats are Major.Minor.Build or 'latest'. Major, Minor,
        /// and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use
        /// 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available. Please do not use
        /// field 'version' for gallery image deployment, gallery image should
        /// always use 'id' field for deployment, to use 'latest' version of
        /// gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.</param>
        /// <param name="exactVersion">Specifies in decimal numbers, the
        /// version of platform image or marketplace image used to create the
        /// virtual machine. This readonly field differs from 'version', only
        /// if the value specified in 'version' field is 'latest'.</param>
        /// <param name="sharedGalleryImageId">Specified the shared gallery
        /// image unique id for vm deployment. This can be fetched from shared
        /// gallery image GET call.</param>
        /// <param name="communityGalleryImageId">Specified the community
        /// gallery image unique id for vm deployment. This can be fetched from
        /// community gallery image GET call.</param>
        public ImageReference(string id = default(string), string publisher = default(string), string offer = default(string), string sku = default(string), string version = default(string), string exactVersion = default(string), string sharedGalleryImageId = default(string), string communityGalleryImageId = default(string))
            : base(id)
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            ExactVersion = exactVersion;
            SharedGalleryImageId = sharedGalleryImageId;
            CommunityGalleryImageId = communityGalleryImageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the image publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the offer of the platform image or
        /// marketplace image used to create the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the image SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets specifies the version of the platform image or
        /// marketplace image used to create the virtual machine. The allowed
        /// formats are Major.Minor.Build or 'latest'. Major, Minor, and Build
        /// are decimal numbers. Specify 'latest' to use the latest version of
        /// an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new
        /// version becomes available. Please do not use field 'version' for
        /// gallery image deployment, gallery image should always use 'id'
        /// field for deployment, to use 'latest' version of gallery image,
        /// just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets specifies in decimal numbers, the version of platform image or
        /// marketplace image used to create the virtual machine. This readonly
        /// field differs from 'version', only if the value specified in
        /// 'version' field is 'latest'.
        /// </summary>
        [JsonProperty(PropertyName = "exactVersion")]
        public string ExactVersion { get; private set; }

        /// <summary>
        /// Gets or sets specified the shared gallery image unique id for vm
        /// deployment. This can be fetched from shared gallery image GET call.
        /// </summary>
        [JsonProperty(PropertyName = "sharedGalleryImageId")]
        public string SharedGalleryImageId { get; set; }

        /// <summary>
        /// Gets or sets specified the community gallery image unique id for vm
        /// deployment. This can be fetched from community gallery image GET
        /// call.
        /// </summary>
        [JsonProperty(PropertyName = "communityGalleryImageId")]
        public string CommunityGalleryImageId { get; set; }

    }
}
