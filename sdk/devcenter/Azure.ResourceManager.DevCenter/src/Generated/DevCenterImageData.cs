// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterImage data model.
    /// Represents an image.
    /// </summary>
    public partial class DevCenterImageData : ResourceData
    {
        /// <summary> Initializes a new instance of DevCenterImageData. </summary>
        public DevCenterImageData()
        {
        }

        /// <summary> Initializes a new instance of DevCenterImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the image. </param>
        /// <param name="publisher"> The publisher of the image. </param>
        /// <param name="offer"> The name of the image offer. </param>
        /// <param name="sku"> The SKU name for the image. </param>
        /// <param name="recommendedMachineConfiguration"> The recommended machine configuration to use with the image. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="hibernateSupport"> Indicates whether this image has hibernate enabled. Not all images are capable of supporting hibernation. To find out more see https://aka.ms/devbox/hibernate. </param>
        internal DevCenterImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string publisher, string offer, string sku, RecommendedMachineConfiguration recommendedMachineConfiguration, DevCenterProvisioningState? provisioningState, DevCenterHibernateSupport? hibernateSupport) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            RecommendedMachineConfiguration = recommendedMachineConfiguration;
            ProvisioningState = provisioningState;
            HibernateSupport = hibernateSupport;
        }

        /// <summary> The description of the image. </summary>
        public string Description { get; }
        /// <summary> The publisher of the image. </summary>
        public string Publisher { get; }
        /// <summary> The name of the image offer. </summary>
        public string Offer { get; }
        /// <summary> The SKU name for the image. </summary>
        public string Sku { get; }
        /// <summary> The recommended machine configuration to use with the image. </summary>
        public RecommendedMachineConfiguration RecommendedMachineConfiguration { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates whether this image has hibernate enabled. Not all images are capable of supporting hibernation. To find out more see https://aka.ms/devbox/hibernate. </summary>
        public DevCenterHibernateSupport? HibernateSupport { get; }
    }
}
