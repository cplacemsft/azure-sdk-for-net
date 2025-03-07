// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated client.
    /// <summary> The FarmBeats service client. </summary>
    public partial class FarmBeatsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FarmBeatsClient for mocking. </summary>
        protected FarmBeatsClient()
        {
        }

        /// <summary> Initializes a new instance of FarmBeatsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmBeatsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new FarmBeatsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FarmBeatsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmBeatsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        private ApplicationData _cachedApplicationData;
        private Attachments _cachedAttachments;
        private Boundaries _cachedBoundaries;
        private CropProducts _cachedCropProducts;
        private Crops _cachedCrops;
        private DeviceDataModels _cachedDeviceDataModels;
        private Devices _cachedDevices;
        private FarmOperationsDataIngestion _cachedFarmOperationsDataIngestion;
        private Farms _cachedFarms;
        private Fields _cachedFields;
        private HarvestData _cachedHarvestData;
        private ImageProcessing _cachedImageProcessing;
        private InsightAttachments _cachedInsightAttachments;
        private Insights _cachedInsights;
        private ManagementZones _cachedManagementZones;
        private ModelInference _cachedModelInference;
        private NutrientAnalyses _cachedNutrientAnalyses;
        private OAuthProviders _cachedOAuthProviders;
        private FarmerOAuthTokens _cachedFarmerOAuthTokens;
        private Parties _cachedParties;
        private PlantingData _cachedPlantingData;
        private PlantTissueAnalyses _cachedPlantTissueAnalyses;
        private PrescriptionMaps _cachedPrescriptionMaps;
        private Prescriptions _cachedPrescriptions;
        private Scenes _cachedScenes;
        private SeasonalFields _cachedSeasonalFields;
        private Seasons _cachedSeasons;
        private SensorDataModels _cachedSensorDataModels;
        private SensorEvents _cachedSensorEvents;
        private SensorMappings _cachedSensorMappings;
        private SensorPartnerIntegrations _cachedSensorPartnerIntegrations;
        private Sensors _cachedSensors;
        private SolutionInference _cachedSolutionInference;
        private TillageData _cachedTillageData;
        private Weather _cachedWeather;
        private WeatherData _cachedWeatherData;
        private Zones _cachedZones;

        /// <summary> Initializes a new instance of ApplicationData. </summary>
        public virtual ApplicationData GetApplicationDataClient()
        {
            return Volatile.Read(ref _cachedApplicationData) ?? Interlocked.CompareExchange(ref _cachedApplicationData, new ApplicationData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedApplicationData;
        }

        /// <summary> Initializes a new instance of Attachments. </summary>
        public virtual Attachments GetAttachmentsClient()
        {
            return Volatile.Read(ref _cachedAttachments) ?? Interlocked.CompareExchange(ref _cachedAttachments, new Attachments(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedAttachments;
        }

        /// <summary> Initializes a new instance of Boundaries. </summary>
        public virtual Boundaries GetBoundariesClient()
        {
            return Volatile.Read(ref _cachedBoundaries) ?? Interlocked.CompareExchange(ref _cachedBoundaries, new Boundaries(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedBoundaries;
        }

        /// <summary> Initializes a new instance of CropProducts. </summary>
        public virtual CropProducts GetCropProductsClient()
        {
            return Volatile.Read(ref _cachedCropProducts) ?? Interlocked.CompareExchange(ref _cachedCropProducts, new CropProducts(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedCropProducts;
        }

        /// <summary> Initializes a new instance of Crops. </summary>
        public virtual Crops GetCropsClient()
        {
            return Volatile.Read(ref _cachedCrops) ?? Interlocked.CompareExchange(ref _cachedCrops, new Crops(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedCrops;
        }

        /// <summary> Initializes a new instance of DeviceDataModels. </summary>
        public virtual DeviceDataModels GetDeviceDataModelsClient()
        {
            return Volatile.Read(ref _cachedDeviceDataModels) ?? Interlocked.CompareExchange(ref _cachedDeviceDataModels, new DeviceDataModels(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedDeviceDataModels;
        }

        /// <summary> Initializes a new instance of Devices. </summary>
        public virtual Devices GetDevicesClient()
        {
            return Volatile.Read(ref _cachedDevices) ?? Interlocked.CompareExchange(ref _cachedDevices, new Devices(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedDevices;
        }

        /// <summary> Initializes a new instance of FarmOperationsDataIngestion. </summary>
        public virtual FarmOperationsDataIngestion GetFarmOperationsDataIngestionClient()
        {
            return Volatile.Read(ref _cachedFarmOperationsDataIngestion) ?? Interlocked.CompareExchange(ref _cachedFarmOperationsDataIngestion, new FarmOperationsDataIngestion(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedFarmOperationsDataIngestion;
        }

        /// <summary> Initializes a new instance of Farms. </summary>
        public virtual Farms GetFarmsClient()
        {
            return Volatile.Read(ref _cachedFarms) ?? Interlocked.CompareExchange(ref _cachedFarms, new Farms(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedFarms;
        }

        /// <summary> Initializes a new instance of Fields. </summary>
        public virtual Fields GetFieldsClient()
        {
            return Volatile.Read(ref _cachedFields) ?? Interlocked.CompareExchange(ref _cachedFields, new Fields(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedFields;
        }

        /// <summary> Initializes a new instance of HarvestData. </summary>
        public virtual HarvestData GetHarvestDataClient()
        {
            return Volatile.Read(ref _cachedHarvestData) ?? Interlocked.CompareExchange(ref _cachedHarvestData, new HarvestData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedHarvestData;
        }

        /// <summary> Initializes a new instance of ImageProcessing. </summary>
        public virtual ImageProcessing GetImageProcessingClient()
        {
            return Volatile.Read(ref _cachedImageProcessing) ?? Interlocked.CompareExchange(ref _cachedImageProcessing, new ImageProcessing(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedImageProcessing;
        }

        /// <summary> Initializes a new instance of InsightAttachments. </summary>
        public virtual InsightAttachments GetInsightAttachmentsClient()
        {
            return Volatile.Read(ref _cachedInsightAttachments) ?? Interlocked.CompareExchange(ref _cachedInsightAttachments, new InsightAttachments(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedInsightAttachments;
        }

        /// <summary> Initializes a new instance of Insights. </summary>
        public virtual Insights GetInsightsClient()
        {
            return Volatile.Read(ref _cachedInsights) ?? Interlocked.CompareExchange(ref _cachedInsights, new Insights(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedInsights;
        }

        /// <summary> Initializes a new instance of ManagementZones. </summary>
        public virtual ManagementZones GetManagementZonesClient()
        {
            return Volatile.Read(ref _cachedManagementZones) ?? Interlocked.CompareExchange(ref _cachedManagementZones, new ManagementZones(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedManagementZones;
        }

        /// <summary> Initializes a new instance of ModelInference. </summary>
        public virtual ModelInference GetModelInferenceClient()
        {
            return Volatile.Read(ref _cachedModelInference) ?? Interlocked.CompareExchange(ref _cachedModelInference, new ModelInference(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedModelInference;
        }

        /// <summary> Initializes a new instance of NutrientAnalyses. </summary>
        public virtual NutrientAnalyses GetNutrientAnalysesClient()
        {
            return Volatile.Read(ref _cachedNutrientAnalyses) ?? Interlocked.CompareExchange(ref _cachedNutrientAnalyses, new NutrientAnalyses(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedNutrientAnalyses;
        }

        /// <summary> Initializes a new instance of OAuthProviders. </summary>
        public virtual OAuthProviders GetOAuthProvidersClient()
        {
            return Volatile.Read(ref _cachedOAuthProviders) ?? Interlocked.CompareExchange(ref _cachedOAuthProviders, new OAuthProviders(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedOAuthProviders;
        }

        /// <summary> Initializes a new instance of FarmerOAuthTokens. </summary>
        public virtual FarmerOAuthTokens GetFarmerOAuthTokensClient()
        {
            return Volatile.Read(ref _cachedFarmerOAuthTokens) ?? Interlocked.CompareExchange(ref _cachedFarmerOAuthTokens, new FarmerOAuthTokens(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedFarmerOAuthTokens;
        }

        /// <summary> Initializes a new instance of Parties. </summary>
        public virtual Parties GetPartiesClient()
        {
            return Volatile.Read(ref _cachedParties) ?? Interlocked.CompareExchange(ref _cachedParties, new Parties(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedParties;
        }

        /// <summary> Initializes a new instance of PlantingData. </summary>
        public virtual PlantingData GetPlantingDataClient()
        {
            return Volatile.Read(ref _cachedPlantingData) ?? Interlocked.CompareExchange(ref _cachedPlantingData, new PlantingData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPlantingData;
        }

        /// <summary> Initializes a new instance of PlantTissueAnalyses. </summary>
        public virtual PlantTissueAnalyses GetPlantTissueAnalysesClient()
        {
            return Volatile.Read(ref _cachedPlantTissueAnalyses) ?? Interlocked.CompareExchange(ref _cachedPlantTissueAnalyses, new PlantTissueAnalyses(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPlantTissueAnalyses;
        }

        /// <summary> Initializes a new instance of PrescriptionMaps. </summary>
        public virtual PrescriptionMaps GetPrescriptionMapsClient()
        {
            return Volatile.Read(ref _cachedPrescriptionMaps) ?? Interlocked.CompareExchange(ref _cachedPrescriptionMaps, new PrescriptionMaps(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPrescriptionMaps;
        }

        /// <summary> Initializes a new instance of Prescriptions. </summary>
        public virtual Prescriptions GetPrescriptionsClient()
        {
            return Volatile.Read(ref _cachedPrescriptions) ?? Interlocked.CompareExchange(ref _cachedPrescriptions, new Prescriptions(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPrescriptions;
        }

        /// <summary> Initializes a new instance of Scenes. </summary>
        public virtual Scenes GetScenesClient()
        {
            return Volatile.Read(ref _cachedScenes) ?? Interlocked.CompareExchange(ref _cachedScenes, new Scenes(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedScenes;
        }

        /// <summary> Initializes a new instance of SeasonalFields. </summary>
        public virtual SeasonalFields GetSeasonalFieldsClient()
        {
            return Volatile.Read(ref _cachedSeasonalFields) ?? Interlocked.CompareExchange(ref _cachedSeasonalFields, new SeasonalFields(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSeasonalFields;
        }

        /// <summary> Initializes a new instance of Seasons. </summary>
        public virtual Seasons GetSeasonsClient()
        {
            return Volatile.Read(ref _cachedSeasons) ?? Interlocked.CompareExchange(ref _cachedSeasons, new Seasons(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSeasons;
        }

        /// <summary> Initializes a new instance of SensorDataModels. </summary>
        public virtual SensorDataModels GetSensorDataModelsClient()
        {
            return Volatile.Read(ref _cachedSensorDataModels) ?? Interlocked.CompareExchange(ref _cachedSensorDataModels, new SensorDataModels(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSensorDataModels;
        }

        /// <summary> Initializes a new instance of SensorEvents. </summary>
        public virtual SensorEvents GetSensorEventsClient()
        {
            return Volatile.Read(ref _cachedSensorEvents) ?? Interlocked.CompareExchange(ref _cachedSensorEvents, new SensorEvents(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSensorEvents;
        }

        /// <summary> Initializes a new instance of SensorMappings. </summary>
        public virtual SensorMappings GetSensorMappingsClient()
        {
            return Volatile.Read(ref _cachedSensorMappings) ?? Interlocked.CompareExchange(ref _cachedSensorMappings, new SensorMappings(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSensorMappings;
        }

        /// <summary> Initializes a new instance of SensorPartnerIntegrations. </summary>
        public virtual SensorPartnerIntegrations GetSensorPartnerIntegrationsClient()
        {
            return Volatile.Read(ref _cachedSensorPartnerIntegrations) ?? Interlocked.CompareExchange(ref _cachedSensorPartnerIntegrations, new SensorPartnerIntegrations(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSensorPartnerIntegrations;
        }

        /// <summary> Initializes a new instance of Sensors. </summary>
        public virtual Sensors GetSensorsClient()
        {
            return Volatile.Read(ref _cachedSensors) ?? Interlocked.CompareExchange(ref _cachedSensors, new Sensors(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSensors;
        }

        /// <summary> Initializes a new instance of SolutionInference. </summary>
        public virtual SolutionInference GetSolutionInferenceClient()
        {
            return Volatile.Read(ref _cachedSolutionInference) ?? Interlocked.CompareExchange(ref _cachedSolutionInference, new SolutionInference(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedSolutionInference;
        }

        /// <summary> Initializes a new instance of TillageData. </summary>
        public virtual TillageData GetTillageDataClient()
        {
            return Volatile.Read(ref _cachedTillageData) ?? Interlocked.CompareExchange(ref _cachedTillageData, new TillageData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedTillageData;
        }

        /// <summary> Initializes a new instance of Weather. </summary>
        public virtual Weather GetWeatherClient()
        {
            return Volatile.Read(ref _cachedWeather) ?? Interlocked.CompareExchange(ref _cachedWeather, new Weather(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedWeather;
        }

        /// <summary> Initializes a new instance of WeatherData. </summary>
        public virtual WeatherData GetWeatherDataClient()
        {
            return Volatile.Read(ref _cachedWeatherData) ?? Interlocked.CompareExchange(ref _cachedWeatherData, new WeatherData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedWeatherData;
        }

        /// <summary> Initializes a new instance of Zones. </summary>
        public virtual Zones GetZonesClient()
        {
            return Volatile.Read(ref _cachedZones) ?? Interlocked.CompareExchange(ref _cachedZones, new Zones(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedZones;
        }
    }
}
