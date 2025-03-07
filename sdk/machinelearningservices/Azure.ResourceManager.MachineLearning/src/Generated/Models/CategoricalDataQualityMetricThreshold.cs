// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CategoricalDataQualityMetricThreshold. </summary>
    public partial class CategoricalDataQualityMetricThreshold : DataQualityMetricThresholdBase
    {
        /// <summary> Initializes a new instance of <see cref="CategoricalDataQualityMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The categorical data quality metric to calculate. </param>
        public CategoricalDataQualityMetricThreshold(CategoricalDataQualityMetric metric)
        {
            Metric = metric;
            DataType = MonitoringFeatureDataType.Categorical;
        }

        /// <summary> Initializes a new instance of <see cref="CategoricalDataQualityMetricThreshold"/>. </summary>
        /// <param name="dataType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="metric"> [Required] The categorical data quality metric to calculate. </param>
        internal CategoricalDataQualityMetricThreshold(MonitoringFeatureDataType dataType, MonitoringThreshold threshold, IDictionary<string, BinaryData> serializedAdditionalRawData, CategoricalDataQualityMetric metric) : base(dataType, threshold, serializedAdditionalRawData)
        {
            Metric = metric;
            DataType = dataType;
        }

        /// <summary> Initializes a new instance of <see cref="CategoricalDataQualityMetricThreshold"/> for deserialization. </summary>
        internal CategoricalDataQualityMetricThreshold()
        {
        }

        /// <summary> [Required] The categorical data quality metric to calculate. </summary>
        [WirePath("metric")]
        public CategoricalDataQualityMetric Metric { get; set; }
    }
}
