﻿using System.Collections.Generic;

namespace Microsoft.Azure.ApplicationInsights.Models
{
    /// <summary>
    /// A segment of intervaled data.
    /// </summary>
    public class MetricsSegmentedIntervalData
    {
        /// <summary>
        /// Gets start time of the metric.
        /// </summary>
        public string Start { get; internal set; }

        /// <summary>
        /// Gets start time of the metric.
        /// </summary>
        public string End { get; internal set; }

        /// <summary>
        /// The segments of data
        /// </summary>
        public IList<MetricsBaseSegmentInfo> Segments { get; internal set; }
    }
}