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
    /// CadenceSettings
    /// </summary>
    [DataContract(Name = "CadenceSettings")]
    public partial class CadenceSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadenceSettings" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="targetDailyPeople">targetDailyPeople.</param>
        /// <param name="removeReplied">removeReplied.</param>
        /// <param name="removeBounced">removeBounced.</param>
        /// <param name="cadenceFunction">cadenceFunction.</param>
        public CadenceSettings(string name = default(string), int? targetDailyPeople = default(int?), bool? removeReplied = default(bool?), bool? removeBounced = default(bool?), string cadenceFunction = default(string))
        {
            this.Name = name;
            this.TargetDailyPeople = targetDailyPeople;
            this.RemoveReplied = removeReplied;
            this.RemoveBounced = removeBounced;
            this.CadenceFunction = cadenceFunction;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TargetDailyPeople
        /// </summary>
        [DataMember(Name = "target_daily_people", EmitDefaultValue = true)]
        public int? TargetDailyPeople { get; set; }

        /// <summary>
        /// Gets or Sets RemoveReplied
        /// </summary>
        [DataMember(Name = "remove_replied", EmitDefaultValue = true)]
        public bool? RemoveReplied { get; set; }

        /// <summary>
        /// Gets or Sets RemoveBounced
        /// </summary>
        [DataMember(Name = "remove_bounced", EmitDefaultValue = true)]
        public bool? RemoveBounced { get; set; }

        /// <summary>
        /// Gets or Sets CadenceFunction
        /// </summary>
        [DataMember(Name = "cadence_function", EmitDefaultValue = true)]
        public string CadenceFunction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CadenceSettings {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TargetDailyPeople: ").Append(TargetDailyPeople).Append("\n");
            sb.Append("  RemoveReplied: ").Append(RemoveReplied).Append("\n");
            sb.Append("  RemoveBounced: ").Append(RemoveBounced).Append("\n");
            sb.Append("  CadenceFunction: ").Append(CadenceFunction).Append("\n");
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
