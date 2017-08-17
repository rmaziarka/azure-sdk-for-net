// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a receiver that should be resubscribed.
    /// </summary>
    public partial class EnableRequest
    {
        /// <summary>
        /// Initializes a new instance of the EnableRequest class.
        /// </summary>
        public EnableRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnableRequest class.
        /// </summary>
        /// <param name="receiverName">The name of the receiver to
        /// resubscribe.</param>
        public EnableRequest(string receiverName)
        {
            ReceiverName = receiverName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the receiver to resubscribe.
        /// </summary>
        [JsonProperty(PropertyName = "receiverName")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReceiverName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReceiverName");
            }
        }
    }
}