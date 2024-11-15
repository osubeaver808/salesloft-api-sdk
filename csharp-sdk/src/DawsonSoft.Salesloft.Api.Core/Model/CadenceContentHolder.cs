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
    /// CadenceContentHolder
    /// </summary>
    [DataContract(Name = "CadenceContentHolder")]
    public partial class CadenceContentHolder : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadenceContentHolder" /> class.
        /// </summary>
        /// <param name="cadenceContent">cadenceContent.</param>
        public CadenceContentHolder(CadenceContent cadenceContent = default(CadenceContent))
        {
            this.CadenceContent = cadenceContent;
        }

        /// <summary>
        /// Gets or Sets CadenceContent
        /// </summary>
        [DataMember(Name = "cadence_content", EmitDefaultValue = true)]
        public CadenceContent CadenceContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CadenceContentHolder {\n");
            sb.Append("  CadenceContent: ").Append(CadenceContent).Append("\n");
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
