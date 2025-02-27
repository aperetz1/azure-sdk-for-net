// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceConnector;

namespace Azure.ResourceManager.ResourceConnector.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableResourceConnectorArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableResourceConnectorArmClient"/> class for mocking. </summary>
        protected MockableResourceConnectorArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourceConnectorArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourceConnectorArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableResourceConnectorArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceConnectorApplianceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceConnectorApplianceResource.CreateResourceIdentifier" /> to create a <see cref="ResourceConnectorApplianceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceConnectorApplianceResource" /> object. </returns>
        public virtual ResourceConnectorApplianceResource GetResourceConnectorApplianceResource(ResourceIdentifier id)
        {
            ResourceConnectorApplianceResource.ValidateResourceId(id);
            return new ResourceConnectorApplianceResource(Client, id);
        }
    }
}
