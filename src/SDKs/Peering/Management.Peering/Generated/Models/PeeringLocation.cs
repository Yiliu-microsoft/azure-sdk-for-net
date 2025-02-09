// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Peering location is where connectivity could be established to the
    /// Microsoft Cloud Edge.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringLocation
    {
        /// <summary>
        /// Initializes a new instance of the PeeringLocation class.
        /// </summary>
        public PeeringLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringLocation class.
        /// </summary>
        /// <param name="kind">The kind of peering that the peering location
        /// supports. Possible values include: 'Direct', 'Exchange'</param>
        /// <param name="direct">The properties that define a direct peering
        /// location.</param>
        /// <param name="exchange">The properties that define an exchange
        /// peering location.</param>
        /// <param name="peeringLocationProperty">The name of the peering
        /// location.</param>
        /// <param name="country">The country in which the peering location
        /// exists.</param>
        /// <param name="azureRegion">The Azure region associated with the
        /// peering location.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public PeeringLocation(string kind = default(string), PeeringLocationPropertiesDirect direct = default(PeeringLocationPropertiesDirect), PeeringLocationPropertiesExchange exchange = default(PeeringLocationPropertiesExchange), string peeringLocationProperty = default(string), string country = default(string), string azureRegion = default(string), string name = default(string), string id = default(string), string type = default(string))
        {
            Kind = kind;
            Direct = direct;
            Exchange = exchange;
            PeeringLocationProperty = peeringLocationProperty;
            Country = country;
            AzureRegion = azureRegion;
            Name = name;
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the kind of peering that the peering location
        /// supports. Possible values include: 'Direct', 'Exchange'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the properties that define a direct peering location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.direct")]
        public PeeringLocationPropertiesDirect Direct { get; set; }

        /// <summary>
        /// Gets or sets the properties that define an exchange peering
        /// location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exchange")]
        public PeeringLocationPropertiesExchange Exchange { get; set; }

        /// <summary>
        /// Gets or sets the name of the peering location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocation")]
        public string PeeringLocationProperty { get; set; }

        /// <summary>
        /// Gets or sets the country in which the peering location exists.
        /// </summary>
        [JsonProperty(PropertyName = "properties.country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Azure region associated with the peering location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureRegion")]
        public string AzureRegion { get; set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
