// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecurityAggregatedAlertTopDevice. </summary>
    public partial class IotSecurityAggregatedAlertTopDevice
    {
        /// <summary> Initializes a new instance of IotSecurityAggregatedAlertTopDevice. </summary>
        internal IotSecurityAggregatedAlertTopDevice()
        {
        }

        /// <summary> Initializes a new instance of IotSecurityAggregatedAlertTopDevice. </summary>
        /// <param name="deviceId"> Name of the device. </param>
        /// <param name="alertsCount"> Number of alerts raised for this device. </param>
        /// <param name="lastOccurrence"> Most recent time this alert was raised for this device, on this day. </param>
        internal IotSecurityAggregatedAlertTopDevice(string deviceId, long? alertsCount, string lastOccurrence)
        {
            DeviceId = deviceId;
            AlertsCount = alertsCount;
            LastOccurrence = lastOccurrence;
        }

        /// <summary> Name of the device. </summary>
        public string DeviceId { get; }
        /// <summary> Number of alerts raised for this device. </summary>
        public long? AlertsCount { get; }
        /// <summary> Most recent time this alert was raised for this device, on this day. </summary>
        public string LastOccurrence { get; }
    }
}
