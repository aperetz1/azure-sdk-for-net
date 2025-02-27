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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformSupportedStack along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AppPlatformSupportedStackResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAppPlatformSupportedStackResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformBuildServiceResource" /> using the GetAppPlatformSupportedStack method.
    /// </summary>
    public partial class AppPlatformSupportedStackResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformSupportedStackResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="buildServiceName"> The buildServiceName. </param>
        /// <param name="stackName"> The stackName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string stackName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformSupportedStackBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformSupportedStackBuildServiceRestClient;
        private readonly AppPlatformSupportedStackData _data;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedStackResource"/> class for mocking. </summary>
        protected AppPlatformSupportedStackResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AppPlatformSupportedStackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformSupportedStackResource(ArmClient client, AppPlatformSupportedStackData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedStackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformSupportedStackResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformSupportedStackBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformSupportedStackBuildServiceApiVersion);
            _appPlatformSupportedStackBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformSupportedStackBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/buildServices/supportedStacks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformSupportedStackData Data
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
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformSupportedStackResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformSupportedStackResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformSupportedStackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedStackResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformSupportedStackBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
