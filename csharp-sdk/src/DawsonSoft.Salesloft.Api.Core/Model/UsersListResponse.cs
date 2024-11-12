/*
 * Salesloft
 *
 * Salesloft
 *
 * The version of the OpenAPI document: 1.0.alpha
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DawsonSoft.Salesloft.Api.Core.Client.OpenAPIDateConverter;

namespace DawsonSoft.Salesloft.Api.Core.Model
{
    /// <summary>
    /// UsersListResponse
    /// </summary>
    [DataContract(Name = "UsersListResponse")]
    public partial class UsersListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListResponse" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="data">data.</param>
        public UsersListResponse(SortFilterResult metadata = default(SortFilterResult), List<User> data = default(List<User>))
        {
            this.Metadata = metadata;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public SortFilterResult Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<User> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersListResponse {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
