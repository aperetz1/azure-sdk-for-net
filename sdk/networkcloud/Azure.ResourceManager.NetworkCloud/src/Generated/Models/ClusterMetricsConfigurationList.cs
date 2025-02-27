// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterMetricsConfigurationList represents a list of metrics configuration of the cluster. </summary>
    internal partial class ClusterMetricsConfigurationList
    {
        /// <summary> Initializes a new instance of ClusterMetricsConfigurationList. </summary>
        internal ClusterMetricsConfigurationList()
        {
            Value = new ChangeTrackingList<NetworkCloudClusterMetricsConfigurationData>();
        }

        /// <summary> Initializes a new instance of ClusterMetricsConfigurationList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of metrics configurations. </param>
        internal ClusterMetricsConfigurationList(string nextLink, IReadOnlyList<NetworkCloudClusterMetricsConfigurationData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of metrics configurations. </summary>
        public IReadOnlyList<NetworkCloudClusterMetricsConfigurationData> Value { get; }
    }
}
