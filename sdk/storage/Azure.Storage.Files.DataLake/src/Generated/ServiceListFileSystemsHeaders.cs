// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class ServiceListFileSystemsHeaders
    {
        private readonly Response _response;
        public ServiceListFileSystemsHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> If the number of filesystems to be listed exceeds the maxResults limit, a continuation token is returned in this response header.  When a continuation token is returned in the response, it must be specified in a subsequent invocation of the list operation to continue listing the filesystems. </summary>
        public string Continuation => _response.Headers.TryGetValue("x-ms-continuation", out string value) ? value : null;
        /// <summary> The content type of list filesystem response. The default content type is application/json. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
    }
}
