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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiTagDescriptionResource" /> and their operations.
    /// Each <see cref="ApiTagDescriptionResource" /> in the collection will belong to the same instance of <see cref="ApiResource" />.
    /// To get an <see cref="ApiTagDescriptionCollection" /> instance call the GetApiTagDescriptions method from an instance of <see cref="ApiResource" />.
    /// </summary>
    public partial class ApiTagDescriptionCollection : ArmCollection, IEnumerable<ApiTagDescriptionResource>, IAsyncEnumerable<ApiTagDescriptionResource>
    {
        private readonly ClientDiagnostics _apiTagDescriptionClientDiagnostics;
        private readonly ApiTagDescriptionRestOperations _apiTagDescriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiTagDescriptionCollection"/> class for mocking. </summary>
        protected ApiTagDescriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiTagDescriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiTagDescriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiTagDescriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiTagDescriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiTagDescriptionResource.ResourceType, out string apiTagDescriptionApiVersion);
            _apiTagDescriptionRestClient = new ApiTagDescriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiTagDescriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create/Update tag description in scope of the Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiTagDescriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagDescriptionId, ApiTagDescriptionCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiTagDescriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiTagDescriptionResource>(Response.FromValue(new ApiTagDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Create/Update tag description in scope of the Api.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiTagDescriptionResource> CreateOrUpdate(WaitUntil waitUntil, string tagDescriptionId, ApiTagDescriptionCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiTagDescriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiTagDescriptionResource>(Response.FromValue(new ApiTagDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Get Tag description in scope of API
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual async Task<Response<ApiTagDescriptionResource>> GetAsync(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiTagDescriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiTagDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Tag description in scope of API
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual Response<ApiTagDescriptionResource> Get(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _apiTagDescriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiTagDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to swagger - tagDescription is defined on API level but tag may be assigned to the Operations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiTagDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiTagDescriptionResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiTagDescriptionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiTagDescriptionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiTagDescriptionResource(Client, ApiTagDescriptionData.DeserializeApiTagDescriptionData(e)), _apiTagDescriptionClientDiagnostics, Pipeline, "ApiTagDescriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to swagger - tagDescription is defined on API level but tag may be assigned to the Operations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiTagDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiTagDescriptionResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiTagDescriptionRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiTagDescriptionRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiTagDescriptionResource(Client, ApiTagDescriptionData.DeserializeApiTagDescriptionData(e)), _apiTagDescriptionClientDiagnostics, Pipeline, "ApiTagDescriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiTagDescriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiTagDescription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _apiTagDescriptionClientDiagnostics.CreateScope("ApiTagDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiTagDescriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiTagDescriptionResource> IEnumerable<ApiTagDescriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiTagDescriptionResource> IAsyncEnumerable<ApiTagDescriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
