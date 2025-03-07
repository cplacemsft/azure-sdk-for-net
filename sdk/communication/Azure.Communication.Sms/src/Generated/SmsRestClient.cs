// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Sms.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Sms
{
    internal partial class SmsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SmsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SmsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2024-12-10-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateSendRequest(string @from, IEnumerable<SmsRecipient> smsRecipients, string message, SmsSendOptions smsSendOptions)
        {
            var message0 = _pipeline.CreateMessage();
            var request = message0.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sms", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new SendMessageRequest(@from, smsRecipients.ToList(), message)
            {
                SmsSendOptions = smsSendOptions
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message0;
        }

        /// <summary> Sends a SMS message from a phone number that belongs to the authenticated account. </summary>
        /// <param name="from"> The sender's phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="smsRecipients"> The recipient's phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <param name="smsSendOptions"> Optional configuration for sending SMS messages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/>, <paramref name="smsRecipients"/> or <paramref name="message"/> is null. </exception>
        public async Task<Response<SmsSendResponse>> SendAsync(string @from, IEnumerable<SmsRecipient> smsRecipients, string message, SmsSendOptions smsSendOptions = null, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (smsRecipients == null)
            {
                throw new ArgumentNullException(nameof(smsRecipients));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateSendRequest(@from, smsRecipients, message, smsSendOptions);
            await _pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
            switch (message0.Response.Status)
            {
                case 202:
                    {
                        SmsSendResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message0.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SmsSendResponse.DeserializeSmsSendResponse(document.RootElement);
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw new RequestFailedException(message0.Response);
            }
        }

        /// <summary> Sends a SMS message from a phone number that belongs to the authenticated account. </summary>
        /// <param name="from"> The sender's phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="smsRecipients"> The recipient's phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <param name="smsSendOptions"> Optional configuration for sending SMS messages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/>, <paramref name="smsRecipients"/> or <paramref name="message"/> is null. </exception>
        public Response<SmsSendResponse> Send(string @from, IEnumerable<SmsRecipient> smsRecipients, string message, SmsSendOptions smsSendOptions = null, CancellationToken cancellationToken = default)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (smsRecipients == null)
            {
                throw new ArgumentNullException(nameof(smsRecipients));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            using var message0 = CreateSendRequest(@from, smsRecipients, message, smsSendOptions);
            _pipeline.Send(message0, cancellationToken);
            switch (message0.Response.Status)
            {
                case 202:
                    {
                        SmsSendResponse value = default;
                        using var document = JsonDocument.Parse(message0.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SmsSendResponse.DeserializeSmsSendResponse(document.RootElement);
                        return Response.FromValue(value, message0.Response);
                    }
                default:
                    throw new RequestFailedException(message0.Response);
            }
        }
    }
}
