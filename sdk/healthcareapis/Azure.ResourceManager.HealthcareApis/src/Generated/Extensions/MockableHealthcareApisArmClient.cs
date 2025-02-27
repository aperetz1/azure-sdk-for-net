// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHealthcareApisArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHealthcareApisArmClient"/> class for mocking. </summary>
        protected MockableHealthcareApisArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHealthcareApisArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHealthcareApisArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHealthcareApisArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServiceResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisServiceResource" /> object. </returns>
        public virtual HealthcareApisServiceResource GetHealthcareApisServiceResource(ResourceIdentifier id)
        {
            HealthcareApisServiceResource.ValidateResourceId(id);
            return new HealthcareApisServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServicePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServicePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServicePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisServicePrivateEndpointConnectionResource" /> object. </returns>
        public virtual HealthcareApisServicePrivateEndpointConnectionResource GetHealthcareApisServicePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            HealthcareApisServicePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new HealthcareApisServicePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" /> object. </returns>
        public virtual HealthcareApisWorkspacePrivateEndpointConnectionResource GetHealthcareApisWorkspacePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            HealthcareApisWorkspacePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new HealthcareApisWorkspacePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServicePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServicePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServicePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisServicePrivateLinkResource" /> object. </returns>
        public virtual HealthcareApisServicePrivateLinkResource GetHealthcareApisServicePrivateLinkResource(ResourceIdentifier id)
        {
            HealthcareApisServicePrivateLinkResource.ValidateResourceId(id);
            return new HealthcareApisServicePrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspacePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspacePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspacePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisWorkspacePrivateLinkResource" /> object. </returns>
        public virtual HealthcareApisWorkspacePrivateLinkResource GetHealthcareApisWorkspacePrivateLinkResource(ResourceIdentifier id)
        {
            HealthcareApisWorkspacePrivateLinkResource.ValidateResourceId(id);
            return new HealthcareApisWorkspacePrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisWorkspaceResource" /> object. </returns>
        public virtual HealthcareApisWorkspaceResource GetHealthcareApisWorkspaceResource(ResourceIdentifier id)
        {
            HealthcareApisWorkspaceResource.ValidateResourceId(id);
            return new HealthcareApisWorkspaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DicomServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DicomServiceResource.CreateResourceIdentifier" /> to create a <see cref="DicomServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DicomServiceResource" /> object. </returns>
        public virtual DicomServiceResource GetDicomServiceResource(ResourceIdentifier id)
        {
            DicomServiceResource.ValidateResourceId(id);
            return new DicomServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisIotConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisIotConnectorResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisIotConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisIotConnectorResource" /> object. </returns>
        public virtual HealthcareApisIotConnectorResource GetHealthcareApisIotConnectorResource(ResourceIdentifier id)
        {
            HealthcareApisIotConnectorResource.ValidateResourceId(id);
            return new HealthcareApisIotConnectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisIotFhirDestinationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisIotFhirDestinationResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisIotFhirDestinationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthcareApisIotFhirDestinationResource" /> object. </returns>
        public virtual HealthcareApisIotFhirDestinationResource GetHealthcareApisIotFhirDestinationResource(ResourceIdentifier id)
        {
            HealthcareApisIotFhirDestinationResource.ValidateResourceId(id);
            return new HealthcareApisIotFhirDestinationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FhirServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FhirServiceResource.CreateResourceIdentifier" /> to create a <see cref="FhirServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FhirServiceResource" /> object. </returns>
        public virtual FhirServiceResource GetFhirServiceResource(ResourceIdentifier id)
        {
            FhirServiceResource.ValidateResourceId(id);
            return new FhirServiceResource(Client, id);
        }
    }
}
