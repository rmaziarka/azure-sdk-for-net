// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The device streams properties of iothub.
    /// </summary>
    public partial class IotHubPropertiesDeviceStreams
    {
        /// <summary>
        /// Initializes a new instance of the IotHubPropertiesDeviceStreams
        /// class.
        /// </summary>
        public IotHubPropertiesDeviceStreams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubPropertiesDeviceStreams
        /// class.
        /// </summary>
        /// <param name="streamingEndpoints">List of Device Streams
        /// Endpoints.</param>
        public IotHubPropertiesDeviceStreams(IList<string> streamingEndpoints = default(IList<string>))
        {
            StreamingEndpoints = streamingEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Device Streams Endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "streamingEndpoints")]
        public IList<string> StreamingEndpoints { get; set; }

    }
}
