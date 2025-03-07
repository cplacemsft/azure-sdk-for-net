// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Environment version details. </summary>
    public partial class MachineLearningEnvironmentVersionProperties : MachineLearningAssetBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningEnvironmentVersionProperties"/>. </summary>
        public MachineLearningEnvironmentVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEnvironmentVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="environmentType">
        /// Environment type is either user managed or curated by the Azure ML service
        /// &lt;see href="https://docs.microsoft.com/en-us/azure/machine-learning/resource-curated-environments" /&gt;
        /// </param>
        /// <param name="image">
        /// Name of the image that will be used for the environment.
        /// &lt;seealso href="https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-custom-docker-image#use-a-custom-base-image" /&gt;
        /// </param>
        /// <param name="condaFile">
        /// Standard configuration file used by Conda that lets you install any kind of package, including Python, R, and C/C++ packages.
        /// &lt;see href="https://repo2docker.readthedocs.io/en/latest/config_files.html#environment-yml-install-a-conda-environment" /&gt;
        /// </param>
        /// <param name="build"> Configuration settings for Docker build context. </param>
        /// <param name="osType"> The OS type of the environment. </param>
        /// <param name="inferenceConfig"> Defines configuration specific to inference. </param>
        /// <param name="autoRebuild"> Defines if image needs to be rebuilt based on base image changes. </param>
        /// <param name="provisioningState"> Provisioning state for the environment version. </param>
        /// <param name="stage"> Stage in the environment lifecycle assigned to this environment. </param>
        internal MachineLearningEnvironmentVersionProperties(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, bool? isAnonymous, MachineLearningEnvironmentType? environmentType, string image, string condaFile, MachineLearningBuildContext build, MachineLearningOperatingSystemType? osType, MachineLearningInferenceContainerProperties inferenceConfig, AutoRebuildSetting? autoRebuild, RegistryAssetProvisioningState? provisioningState, string stage) : base(description, tags, properties, serializedAdditionalRawData, isArchived, isAnonymous)
        {
            EnvironmentType = environmentType;
            Image = image;
            CondaFile = condaFile;
            Build = build;
            OSType = osType;
            InferenceConfig = inferenceConfig;
            AutoRebuild = autoRebuild;
            ProvisioningState = provisioningState;
            Stage = stage;
        }

        /// <summary>
        /// Environment type is either user managed or curated by the Azure ML service
        /// &lt;see href="https://docs.microsoft.com/en-us/azure/machine-learning/resource-curated-environments" /&gt;
        /// </summary>
        [WirePath("environmentType")]
        public MachineLearningEnvironmentType? EnvironmentType { get; }
        /// <summary>
        /// Name of the image that will be used for the environment.
        /// &lt;seealso href="https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-custom-docker-image#use-a-custom-base-image" /&gt;
        /// </summary>
        [WirePath("image")]
        public string Image { get; set; }
        /// <summary>
        /// Standard configuration file used by Conda that lets you install any kind of package, including Python, R, and C/C++ packages.
        /// &lt;see href="https://repo2docker.readthedocs.io/en/latest/config_files.html#environment-yml-install-a-conda-environment" /&gt;
        /// </summary>
        [WirePath("condaFile")]
        public string CondaFile { get; set; }
        /// <summary> Configuration settings for Docker build context. </summary>
        [WirePath("build")]
        public MachineLearningBuildContext Build { get; set; }
        /// <summary> The OS type of the environment. </summary>
        [WirePath("osType")]
        public MachineLearningOperatingSystemType? OSType { get; set; }
        /// <summary> Defines configuration specific to inference. </summary>
        [WirePath("inferenceConfig")]
        public MachineLearningInferenceContainerProperties InferenceConfig { get; set; }
        /// <summary> Defines if image needs to be rebuilt based on base image changes. </summary>
        [WirePath("autoRebuild")]
        public AutoRebuildSetting? AutoRebuild { get; set; }
        /// <summary> Provisioning state for the environment version. </summary>
        [WirePath("provisioningState")]
        public RegistryAssetProvisioningState? ProvisioningState { get; }
        /// <summary> Stage in the environment lifecycle assigned to this environment. </summary>
        [WirePath("stage")]
        public string Stage { get; set; }
    }
}
