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
    /// EntityRefrence
    /// </summary>
    [DataContract(Name = "EntityRefrence")]
    public partial class EntityRefrence : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRefrence" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="id">id.</param>
        public EntityRefrence(string href = default(string), int? id = default(int?))
        {
            this.Href = href;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "_href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityRefrence {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
