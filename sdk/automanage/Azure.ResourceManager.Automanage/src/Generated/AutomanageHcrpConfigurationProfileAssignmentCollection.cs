// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" /> and their operations.
    /// Each <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get an <see cref="AutomanageHcrpConfigurationProfileAssignmentCollection" /> instance call the GetAutomanageHcrpConfigurationProfileAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class AutomanageHcrpConfigurationProfileAssignmentCollection : ArmCollection, IEnumerable<AutomanageHcrpConfigurationProfileAssignmentResource>, IAsyncEnumerable<AutomanageHcrpConfigurationProfileAssignmentResource>
    {
        private readonly ClientDiagnostics _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileHcrpAssignmentsRestOperations _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient;
        private readonly ClientDiagnostics _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileAssignmentsRestOperations _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageHcrpConfigurationProfileAssignmentCollection"/> class for mocking. </summary>
        protected AutomanageHcrpConfigurationProfileAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHcrpConfigurationProfileAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageHcrpConfigurationProfileAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageHcrpConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageHcrpConfigurationProfileAssignmentResource.ResourceType, out string automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsApiVersion);
            _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient = new ConfigurationProfileHcrpAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsApiVersion);
            _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageHcrpConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageHcrpConfigurationProfileAssignmentResource.ResourceType, out string automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
            _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient = new ConfigurationProfileAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.HybridCompute/machines")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.HybridCompute/machines"), nameof(id));
        }

        /// <summary>
        /// Creates an association between a ARC machine and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageHcrpConfigurationProfileAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageHcrpConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a ARC machine and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageHcrpConfigurationProfileAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageHcrpConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<AutomanageHcrpConfigurationProfileAssignmentResource>> GetAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<AutomanageHcrpConfigurationProfileAssignmentResource> Get(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByMachineName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageHcrpConfigurationProfileAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByMachineNameRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageHcrpConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageHcrpConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByMachineName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageHcrpConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageHcrpConfigurationProfileAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByMachineNameRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageHcrpConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageHcrpConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageHcrpConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomanageHcrpConfigurationProfileAssignmentResource>> GetIfExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageHcrpConfigurationProfileAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual NullableResponse<AutomanageHcrpConfigurationProfileAssignmentResource> GetIfExists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsClientDiagnostics.CreateScope("AutomanageHcrpConfigurationProfileAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automanageHcrpConfigurationProfileAssignmentConfigurationProfileHCRPAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageHcrpConfigurationProfileAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageHcrpConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageHcrpConfigurationProfileAssignmentResource> IEnumerable<AutomanageHcrpConfigurationProfileAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageHcrpConfigurationProfileAssignmentResource> IAsyncEnumerable<AutomanageHcrpConfigurationProfileAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
