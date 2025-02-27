// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DnsResolver;

namespace Azure.ResourceManager.DnsResolver.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDnsResolverArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDnsResolverArmClient"/> class for mocking. </summary>
        protected MockableDnsResolverArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDnsResolverArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDnsResolverArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDnsResolverArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsResolverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsResolverResource.CreateResourceIdentifier" /> to create a <see cref="DnsResolverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsResolverResource" /> object. </returns>
        public virtual DnsResolverResource GetDnsResolverResource(ResourceIdentifier id)
        {
            DnsResolverResource.ValidateResourceId(id);
            return new DnsResolverResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsResolverInboundEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsResolverInboundEndpointResource.CreateResourceIdentifier" /> to create a <see cref="DnsResolverInboundEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsResolverInboundEndpointResource" /> object. </returns>
        public virtual DnsResolverInboundEndpointResource GetDnsResolverInboundEndpointResource(ResourceIdentifier id)
        {
            DnsResolverInboundEndpointResource.ValidateResourceId(id);
            return new DnsResolverInboundEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsResolverOutboundEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsResolverOutboundEndpointResource.CreateResourceIdentifier" /> to create a <see cref="DnsResolverOutboundEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsResolverOutboundEndpointResource" /> object. </returns>
        public virtual DnsResolverOutboundEndpointResource GetDnsResolverOutboundEndpointResource(ResourceIdentifier id)
        {
            DnsResolverOutboundEndpointResource.ValidateResourceId(id);
            return new DnsResolverOutboundEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsForwardingRulesetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsForwardingRulesetResource.CreateResourceIdentifier" /> to create a <see cref="DnsForwardingRulesetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsForwardingRulesetResource" /> object. </returns>
        public virtual DnsForwardingRulesetResource GetDnsForwardingRulesetResource(ResourceIdentifier id)
        {
            DnsForwardingRulesetResource.ValidateResourceId(id);
            return new DnsForwardingRulesetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsForwardingRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsForwardingRuleResource.CreateResourceIdentifier" /> to create a <see cref="DnsForwardingRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsForwardingRuleResource" /> object. </returns>
        public virtual DnsForwardingRuleResource GetDnsForwardingRuleResource(ResourceIdentifier id)
        {
            DnsForwardingRuleResource.ValidateResourceId(id);
            return new DnsForwardingRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsForwardingRulesetVirtualNetworkLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsForwardingRulesetVirtualNetworkLinkResource.CreateResourceIdentifier" /> to create a <see cref="DnsForwardingRulesetVirtualNetworkLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsForwardingRulesetVirtualNetworkLinkResource" /> object. </returns>
        public virtual DnsForwardingRulesetVirtualNetworkLinkResource GetDnsForwardingRulesetVirtualNetworkLinkResource(ResourceIdentifier id)
        {
            DnsForwardingRulesetVirtualNetworkLinkResource.ValidateResourceId(id);
            return new DnsForwardingRulesetVirtualNetworkLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualNetworkDnsResolverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualNetworkDnsResolverResource.CreateResourceIdentifier" /> to create a <see cref="VirtualNetworkDnsResolverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkDnsResolverResource" /> object. </returns>
        public virtual VirtualNetworkDnsResolverResource GetVirtualNetworkDnsResolverResource(ResourceIdentifier id)
        {
            VirtualNetworkDnsResolverResource.ValidateResourceId(id);
            return new VirtualNetworkDnsResolverResource(Client, id);
        }
    }
}
