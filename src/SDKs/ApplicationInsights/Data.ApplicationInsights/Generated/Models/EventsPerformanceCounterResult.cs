// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A performance counter result
    /// </summary>
    [Newtonsoft.Json.JsonObject("performanceCounter")]
    public partial class EventsPerformanceCounterResult : EventsResultData
    {
        /// <summary>
        /// Initializes a new instance of the EventsPerformanceCounterResult
        /// class.
        /// </summary>
        public EventsPerformanceCounterResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsPerformanceCounterResult
        /// class.
        /// </summary>
        /// <param name="id">The unique ID for this event.</param>
        /// <param name="count">Count of the event</param>
        /// <param name="timestamp">Timestamp of the event</param>
        /// <param name="customDimensions">Custom dimensions of the
        /// event</param>
        /// <param name="customMeasurements">Custom measurements of the
        /// event</param>
        /// <param name="operation">Operation info of the event</param>
        /// <param name="session">Session info of the event</param>
        /// <param name="user">User info of the event</param>
        /// <param name="cloud">Cloud info of the event</param>
        /// <param name="ai">AI info of the event</param>
        /// <param name="application">Application info of the event</param>
        /// <param name="client">Client info of the event</param>
        public EventsPerformanceCounterResult(System.Guid? id = default(System.Guid?), long? count = default(long?), System.DateTime? timestamp = default(System.DateTime?), EventsResultDataCustomDimensions customDimensions = default(EventsResultDataCustomDimensions), EventsResultDataCustomMeasurements customMeasurements = default(EventsResultDataCustomMeasurements), EventsOperationInfo operation = default(EventsOperationInfo), EventsSessionInfo session = default(EventsSessionInfo), EventsUserInfo user = default(EventsUserInfo), EventsCloudInfo cloud = default(EventsCloudInfo), EventsAiInfo ai = default(EventsAiInfo), EventsApplicationInfo application = default(EventsApplicationInfo), EventsClientInfo client = default(EventsClientInfo), EventsPerformanceCounterInfo performanceCounter = default(EventsPerformanceCounterInfo))
            : base(id, count, timestamp, customDimensions, customMeasurements, operation, session, user, cloud, ai, application, client)
        {
            PerformanceCounter = performanceCounter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "performanceCounter")]
        public EventsPerformanceCounterInfo PerformanceCounter { get; set; }

    }
}
