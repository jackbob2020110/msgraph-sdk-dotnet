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
    /// The type Video.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Video
    {
    
        /// <summary>
        /// Gets or sets bitrate.
        /// </summary>
        [DataMember(Name = "bitrate", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Bitrate { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Duration { get; set; }
    
        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Width { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
