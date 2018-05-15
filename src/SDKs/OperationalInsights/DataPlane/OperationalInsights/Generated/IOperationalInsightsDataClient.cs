// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.OperationalInsights
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Operational Insights Data Client
    /// </summary>
    public partial interface IOperationalInsightsDataClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Comma separated workspace IDs to include in cross-workspace
        /// queries.
        /// </summary>
        string Workspaces { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Execute an Analytics query
        /// </summary>
        /// <remarks>
        /// Executes an Analytics query for data.
        /// [Here](/documentation/2-Using-the-API/Query) is an example for
        /// using POST with an Analytics query.
        /// </remarks>
        /// <param name='workspaceId'>
        /// ID of the workspace. This is Workspace ID from the Properties blade
        /// in the Azure portal.
        /// </param>
        /// <param name='query'>
        /// The query to execute.
        /// </param>
        /// <param name='timespan'>
        /// Optional. The timespan over which to query data. This is an ISO8601
        /// time period value.  This timespan is applied in addition to any
        /// that are specified in the query expression.
        /// </param>
        /// <param name='workspaces'>
        /// A list of workspaces that are included in the query.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<QueryResults>> QueryWithHttpMessagesAsync(string workspaceId, string query, string timespan = default(string), IList<string> workspaces = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
