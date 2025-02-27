// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A Class representing a SuppressionListAddressResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SuppressionListAddressResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSuppressionListAddressResource method.
    /// Otherwise you can get one from its parent resource <see cref="SuppressionListResource" /> using the GetSuppressionListAddressResource method.
    /// </summary>
    public partial class SuppressionListAddressResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SuppressionListAddressResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="emailServiceName"> The emailServiceName. </param>
        /// <param name="domainName"> The domainName. </param>
        /// <param name="suppressionListName"> The suppressionListName. </param>
        /// <param name="addressId"> The addressId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics;
        private readonly SuppressionListAddressesRestOperations _suppressionListAddressResourceSuppressionListAddressesRestClient;
        private readonly SuppressionListAddressResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SuppressionListAddressResource"/> class for mocking. </summary>
        protected SuppressionListAddressResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SuppressionListAddressResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SuppressionListAddressResource(ArmClient client, SuppressionListAddressResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SuppressionListAddressResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SuppressionListAddressResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string suppressionListAddressResourceSuppressionListAddressesApiVersion);
            _suppressionListAddressResourceSuppressionListAddressesRestClient = new SuppressionListAddressesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, suppressionListAddressResourceSuppressionListAddressesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Communication/emailServices/domains/suppressionLists/suppressionListAddresses";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SuppressionListAddressResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SuppressionListAddressResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Get");
            scope.Start();
            try
            {
                var response = await _suppressionListAddressResourceSuppressionListAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionListAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SuppressionListAddressResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Get");
            scope.Start();
            try
            {
                var response = _suppressionListAddressResourceSuppressionListAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionListAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete a single address from a suppression list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Delete");
            scope.Start();
            try
            {
                var response = await _suppressionListAddressResourceSuppressionListAddressesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete a single address from a suppression list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Delete");
            scope.Start();
            try
            {
                var response = _suppressionListAddressResourceSuppressionListAddressesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CommunicationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SuppressionListAddressResource>> UpdateAsync(WaitUntil waitUntil, SuppressionListAddressResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Update");
            scope.Start();
            try
            {
                var response = await _suppressionListAddressResourceSuppressionListAddressesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<SuppressionListAddressResource>(Response.FromValue(new SuppressionListAddressResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SuppressionListAddressResource> Update(WaitUntil waitUntil, SuppressionListAddressResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionListAddressResourceSuppressionListAddressesClientDiagnostics.CreateScope("SuppressionListAddressResource.Update");
            scope.Start();
            try
            {
                var response = _suppressionListAddressResourceSuppressionListAddressesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CommunicationArmOperation<SuppressionListAddressResource>(Response.FromValue(new SuppressionListAddressResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
