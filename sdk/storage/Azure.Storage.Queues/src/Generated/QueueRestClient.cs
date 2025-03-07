// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Queues.Models;

namespace Azure.Storage.Queues
{
    internal partial class QueueRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _version;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of QueueRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, queue or message that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. The default value is "2018-03-28". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public QueueRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        internal HttpMessage CreateCreateRequest(int? timeout, IDictionary<string, string> metadata)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            if (metadata != null)
            {
                request.Headers.Add("x-ms-meta-", metadata);
            }
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> creates a new queue under the given account. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="metadata"> Optional. Include this parameter to specify that the queue's metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueCreateHeaders>> CreateAsync(int? timeout = null, IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(timeout, metadata);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> creates a new queue under the given account. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="metadata"> Optional. Include this parameter to specify that the queue's metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueCreateHeaders> Create(int? timeout = null, IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(timeout, metadata);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueCreateHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> operation permanently deletes the specified queue. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueDeleteHeaders>> DeleteAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> operation permanently deletes the specified queue. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueDeleteHeaders> Delete(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPropertiesRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendQuery("comp", "metadata", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> Retrieves user-defined metadata and queue properties on the specified queue. Metadata is associated with the queue as name-values pairs. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueGetPropertiesHeaders>> GetPropertiesAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves user-defined metadata and queue properties on the specified queue. Metadata is associated with the queue as name-values pairs. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueGetPropertiesHeaders> GetProperties(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPropertiesRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueGetPropertiesHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetMetadataRequest(int? timeout, IDictionary<string, string> metadata)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendQuery("comp", "metadata", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            if (metadata != null)
            {
                request.Headers.Add("x-ms-meta-", metadata);
            }
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> sets user-defined metadata on the specified queue. Metadata is associated with the queue as name-value pairs. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="metadata"> Optional. Include this parameter to specify that the queue's metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueSetMetadataHeaders>> SetMetadataAsync(int? timeout = null, IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetMetadataRequest(timeout, metadata);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueSetMetadataHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> sets user-defined metadata on the specified queue. Metadata is associated with the queue as name-value pairs. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="metadata"> Optional. Include this parameter to specify that the queue's metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueSetMetadataHeaders> SetMetadata(int? timeout = null, IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetMetadataRequest(timeout, metadata);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueSetMetadataHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAccessPolicyRequest(int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendQuery("comp", "acl", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> returns details about any stored access policies specified on the queue that may be used with Shared Access Signatures. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<IReadOnlyList<QueueSignedIdentifier>, QueueGetAccessPolicyHeaders>> GetAccessPolicyAsync(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAccessPolicyRequest(timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueGetAccessPolicyHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<QueueSignedIdentifier> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("SignedIdentifiers") is XElement signedIdentifiersElement)
                        {
                            var array = new List<QueueSignedIdentifier>();
                            foreach (var e in signedIdentifiersElement.Elements("SignedIdentifier"))
                            {
                                array.Add(QueueSignedIdentifier.DeserializeQueueSignedIdentifier(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> returns details about any stored access policies specified on the queue that may be used with Shared Access Signatures. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<IReadOnlyList<QueueSignedIdentifier>, QueueGetAccessPolicyHeaders> GetAccessPolicy(int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAccessPolicyRequest(timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueGetAccessPolicyHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<QueueSignedIdentifier> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("SignedIdentifiers") is XElement signedIdentifiersElement)
                        {
                            var array = new List<QueueSignedIdentifier>();
                            foreach (var e in signedIdentifiersElement.Elements("SignedIdentifier"))
                            {
                                array.Add(QueueSignedIdentifier.DeserializeQueueSignedIdentifier(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetAccessPolicyRequest(int? timeout, IEnumerable<QueueSignedIdentifier> queueAcl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendQuery("comp", "acl", true);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/xml");
            if (queueAcl != null)
            {
                request.Headers.Add("Content-Type", "application/xml");
                var content = new XmlWriterContent();
                content.XmlWriter.WriteStartElement("SignedIdentifiers");
                foreach (var item in queueAcl)
                {
                    content.XmlWriter.WriteObjectValue(item, "SignedIdentifier");
                }
                content.XmlWriter.WriteEndElement();
                request.Content = content;
            }
            return message;
        }

        /// <summary> sets stored access policies for the queue that may be used with Shared Access Signatures. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="queueAcl"> the acls for the queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueueSetAccessPolicyHeaders>> SetAccessPolicyAsync(int? timeout = null, IEnumerable<QueueSignedIdentifier> queueAcl = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetAccessPolicyRequest(timeout, queueAcl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueueSetAccessPolicyHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> sets stored access policies for the queue that may be used with Shared Access Signatures. </summary>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="queueAcl"> the acls for the queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueueSetAccessPolicyHeaders> SetAccessPolicy(int? timeout = null, IEnumerable<QueueSignedIdentifier> queueAcl = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateSetAccessPolicyRequest(timeout, queueAcl);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueueSetAccessPolicyHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
