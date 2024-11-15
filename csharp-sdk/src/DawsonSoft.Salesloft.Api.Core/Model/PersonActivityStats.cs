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
    /// PersonActivityStats
    /// </summary>
    [DataContract(Name = "PersonActivityStats")]
    public partial class PersonActivityStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonActivityStats" /> class.
        /// </summary>
        /// <param name="emailsSent">emailsSent.</param>
        /// <param name="emailsViewed">emailsViewed.</param>
        /// <param name="emailsClicked">emailsClicked.</param>
        /// <param name="emailsRepliedTo">emailsRepliedTo.</param>
        /// <param name="emailsBounced">emailsBounced.</param>
        /// <param name="calls">calls.</param>
        public PersonActivityStats(int? emailsSent = default(int?), int? emailsViewed = default(int?), int? emailsClicked = default(int?), int? emailsRepliedTo = default(int?), int? emailsBounced = default(int?), int? calls = default(int?))
        {
            this.EmailsSent = emailsSent;
            this.EmailsViewed = emailsViewed;
            this.EmailsClicked = emailsClicked;
            this.EmailsRepliedTo = emailsRepliedTo;
            this.EmailsBounced = emailsBounced;
            this.Calls = calls;
        }

        /// <summary>
        /// Gets or Sets EmailsSent
        /// </summary>
        [DataMember(Name = "emails_sent", EmitDefaultValue = true)]
        public int? EmailsSent { get; set; }

        /// <summary>
        /// Gets or Sets EmailsViewed
        /// </summary>
        [DataMember(Name = "emails_viewed", EmitDefaultValue = true)]
        public int? EmailsViewed { get; set; }

        /// <summary>
        /// Gets or Sets EmailsClicked
        /// </summary>
        [DataMember(Name = "emails_clicked", EmitDefaultValue = true)]
        public int? EmailsClicked { get; set; }

        /// <summary>
        /// Gets or Sets EmailsRepliedTo
        /// </summary>
        [DataMember(Name = "emails_replied_to", EmitDefaultValue = true)]
        public int? EmailsRepliedTo { get; set; }

        /// <summary>
        /// Gets or Sets EmailsBounced
        /// </summary>
        [DataMember(Name = "emails_bounced", EmitDefaultValue = true)]
        public int? EmailsBounced { get; set; }

        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name = "calls", EmitDefaultValue = true)]
        public int? Calls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonActivityStats {\n");
            sb.Append("  EmailsSent: ").Append(EmailsSent).Append("\n");
            sb.Append("  EmailsViewed: ").Append(EmailsViewed).Append("\n");
            sb.Append("  EmailsClicked: ").Append(EmailsClicked).Append("\n");
            sb.Append("  EmailsRepliedTo: ").Append(EmailsRepliedTo).Append("\n");
            sb.Append("  EmailsBounced: ").Append(EmailsBounced).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
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
