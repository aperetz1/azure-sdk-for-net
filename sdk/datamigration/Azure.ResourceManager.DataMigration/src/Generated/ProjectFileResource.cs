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
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A Class representing a ProjectFile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ProjectFileResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetProjectFileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProjectResource" /> using the GetProjectFile method.
    /// </summary>
    public partial class ProjectFileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProjectFileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="groupName"> The groupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="fileName"> The fileName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string groupName, string serviceName, string projectName, string fileName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _projectFileFilesClientDiagnostics;
        private readonly FilesRestOperations _projectFileFilesRestClient;
        private readonly ProjectFileData _data;

        /// <summary> Initializes a new instance of the <see cref="ProjectFileResource"/> class for mocking. </summary>
        protected ProjectFileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProjectFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProjectFileResource(ArmClient client, ProjectFileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProjectFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProjectFileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _projectFileFilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string projectFileFilesApiVersion);
            _projectFileFilesRestClient = new FilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, projectFileFilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly Core.ResourceType ResourceType = "Microsoft.DataMigration/services/projects/files";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProjectFileData Data
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
        /// The files resource is a nested, proxy-only resource representing a file stored under the project resource. This method retrieves information about a file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProjectFileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Get");
            scope.Start();
            try
            {
                var response = await _projectFileFilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The files resource is a nested, proxy-only resource representing a file stored under the project resource. This method retrieves information about a file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProjectFileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Get");
            scope.Start();
            try
            {
                var response = _projectFileFilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method deletes a file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Delete");
            scope.Start();
            try
            {
                var response = await _projectFileFilesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation(response);
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
        /// This method deletes a file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Delete");
            scope.Start();
            try
            {
                var response = _projectFileFilesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataMigrationArmOperation(response);
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
        /// This method updates an existing file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Information about the file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<ProjectFileResource>> UpdateAsync(ProjectFileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Update");
            scope.Start();
            try
            {
                var response = await _projectFileFilesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ProjectFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method updates an existing file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Information about the file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<ProjectFileResource> Update(ProjectFileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Update");
            scope.Start();
            try
            {
                var response = _projectFileFilesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new ProjectFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method is used for requesting storage information using which contents of the file can be downloaded.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}/read</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Read</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileStorageInfo>> ReadAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Read");
            scope.Start();
            try
            {
                var response = await _projectFileFilesRestClient.ReadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method is used for requesting storage information using which contents of the file can be downloaded.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}/read</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Read</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileStorageInfo> Read(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.Read");
            scope.Start();
            try
            {
                var response = _projectFileFilesRestClient.Read(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method is used for requesting information for reading and writing the file content.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}/readwrite</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_ReadWrite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileStorageInfo>> ReadWriteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.ReadWrite");
            scope.Start();
            try
            {
                var response = await _projectFileFilesRestClient.ReadWriteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method is used for requesting information for reading and writing the file content.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/files/{fileName}/readwrite</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_ReadWrite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileStorageInfo> ReadWrite(CancellationToken cancellationToken = default)
        {
            using var scope = _projectFileFilesClientDiagnostics.CreateScope("ProjectFileResource.ReadWrite");
            scope.Start();
            try
            {
                var response = _projectFileFilesRestClient.ReadWrite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
