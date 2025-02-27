// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHDInsightContainersArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersArmClient"/> class for mocking. </summary>
        protected MockableHDInsightContainersArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHDInsightContainersArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHDInsightContainersArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHDInsightContainersArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="HDInsightClusterPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HDInsightClusterPoolResource.CreateResourceIdentifier" /> to create a <see cref="HDInsightClusterPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HDInsightClusterPoolResource" /> object. </returns>
        public virtual HDInsightClusterPoolResource GetHDInsightClusterPoolResource(ResourceIdentifier id)
        {
            HDInsightClusterPoolResource.ValidateResourceId(id);
            return new HDInsightClusterPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HDInsightClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HDInsightClusterResource.CreateResourceIdentifier" /> to create a <see cref="HDInsightClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HDInsightClusterResource" /> object. </returns>
        public virtual HDInsightClusterResource GetHDInsightClusterResource(ResourceIdentifier id)
        {
            HDInsightClusterResource.ValidateResourceId(id);
            return new HDInsightClusterResource(Client, id);
        }
    }
}
