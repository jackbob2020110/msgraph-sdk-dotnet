// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    /// <summary>
    /// The type RecurrenceRange.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RecurrenceRange
    {
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public RecurrenceRangeType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets startDate.
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false, IsRequired = false)]
        public Date StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets endDate.
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false, IsRequired = false)]
        public Date EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets recurrenceTimeZone.
        /// </summary>
        [DataMember(Name = "recurrenceTimeZone", EmitDefaultValue = false, IsRequired = false)]
        public string RecurrenceTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets numberOfOccurrences.
        /// </summary>
        [DataMember(Name = "numberOfOccurrences", EmitDefaultValue = false, IsRequired = false)]
        public Int32? NumberOfOccurrences { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
