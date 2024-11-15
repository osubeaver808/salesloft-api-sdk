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
    /// StaticData
    /// </summary>
    [DataContract(Name = "StaticData")]
    public partial class StaticData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticData" /> class.
        /// </summary>
        /// <param name="varClient">varClient.</param>
        /// <param name="crmActivityId">crmActivityId.</param>
        /// <param name="emailId">emailId.</param>
        /// <param name="mailingId">mailingId.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        public StaticData(string varClient = default(string), int? crmActivityId = default(int?), int? emailId = default(int?), int? mailingId = default(int?), string status = default(string), string subject = default(string))
        {
            this.VarClient = varClient;
            this.CrmActivityId = crmActivityId;
            this.EmailId = emailId;
            this.MailingId = mailingId;
            this.Status = status;
            this.Subject = subject;
        }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = true)]
        public string VarClient { get; set; }

        /// <summary>
        /// Gets or Sets CrmActivityId
        /// </summary>
        [DataMember(Name = "crm_activity_id", EmitDefaultValue = true)]
        public int? CrmActivityId { get; set; }

        /// <summary>
        /// Gets or Sets EmailId
        /// </summary>
        [DataMember(Name = "email_id", EmitDefaultValue = true)]
        public int? EmailId { get; set; }

        /// <summary>
        /// Gets or Sets MailingId
        /// </summary>
        [DataMember(Name = "mailing_id", EmitDefaultValue = true)]
        public int? MailingId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StaticData {\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  CrmActivityId: ").Append(CrmActivityId).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  MailingId: ").Append(MailingId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
