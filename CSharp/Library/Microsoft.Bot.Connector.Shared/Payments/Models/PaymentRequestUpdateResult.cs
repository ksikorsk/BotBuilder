// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Payments
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    

    /// <summary>
    /// A result object from a Payment Request Update invoke operation
    /// </summary>
    public partial class PaymentRequestUpdateResult
    {
        /// <summary>
        /// Initializes a new instance of the PaymentRequestUpdateResult class.
        /// </summary>
        public PaymentRequestUpdateResult() { }

        /// <summary>
        /// Initializes a new instance of the PaymentRequestUpdateResult class.
        /// </summary>
        public PaymentRequestUpdateResult(PaymentDetails details = default(PaymentDetails))
        {
            Details = details;
        }

        /// <summary>
        /// Update payment details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public PaymentDetails Details { get; set; }

    }
}
