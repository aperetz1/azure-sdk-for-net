// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The LiveEvent list result. </summary>
    internal partial class LiveEventListResult
    {
        /// <summary> Initializes a new instance of LiveEventListResult. </summary>
        internal LiveEventListResult()
        {
            Value = new ChangeTrackingList<MediaLiveEventData>();
        }

        /// <summary> Initializes a new instance of LiveEventListResult. </summary>
        /// <param name="value"> The result of the List Live Event operation. </param>
        /// <param name="odataCount"> The number of result. </param>
        /// <param name="odataNextLink"> The link to the next set of results. Not empty if value contains incomplete list of live outputs. </param>
        internal LiveEventListResult(IReadOnlyList<MediaLiveEventData> value, int? odataCount, string odataNextLink)
        {
            Value = value;
            OdataCount = odataCount;
            OdataNextLink = odataNextLink;
        }

        /// <summary> The result of the List Live Event operation. </summary>
        public IReadOnlyList<MediaLiveEventData> Value { get; }
        /// <summary> The number of result. </summary>
        public int? OdataCount { get; }
        /// <summary> The link to the next set of results. Not empty if value contains incomplete list of live outputs. </summary>
        public string OdataNextLink { get; }
    }
}
