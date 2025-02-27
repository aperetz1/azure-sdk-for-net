// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapsePrivateEndpointConnectionForPrivateLinkHubListResult. </summary>
    internal partial class SynapsePrivateEndpointConnectionForPrivateLinkHubListResult
    {
        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionForPrivateLinkHubListResult. </summary>
        internal SynapsePrivateEndpointConnectionForPrivateLinkHubListResult()
        {
            Value = new ChangeTrackingList<SynapsePrivateEndpointConnectionForPrivateLinkHubData>();
        }

        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionForPrivateLinkHubListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal SynapsePrivateEndpointConnectionForPrivateLinkHubListResult(IReadOnlyList<SynapsePrivateEndpointConnectionForPrivateLinkHubData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SynapsePrivateEndpointConnectionForPrivateLinkHubData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
