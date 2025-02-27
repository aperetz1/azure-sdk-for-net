// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListExpressRoutePortAuthorizations API service call. </summary>
    internal partial class ExpressRoutePortAuthorizationListResult
    {
        /// <summary> Initializes a new instance of ExpressRoutePortAuthorizationListResult. </summary>
        internal ExpressRoutePortAuthorizationListResult()
        {
            Value = new ChangeTrackingList<ExpressRoutePortAuthorizationData>();
        }

        /// <summary> Initializes a new instance of ExpressRoutePortAuthorizationListResult. </summary>
        /// <param name="value"> The authorizations in an ExpressRoute Port. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRoutePortAuthorizationListResult(IReadOnlyList<ExpressRoutePortAuthorizationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The authorizations in an ExpressRoute Port. </summary>
        public IReadOnlyList<ExpressRoutePortAuthorizationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
