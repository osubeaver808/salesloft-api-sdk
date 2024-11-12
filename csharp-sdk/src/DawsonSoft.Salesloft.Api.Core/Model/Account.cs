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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="name">name.</param>
        /// <param name="domain">domain.</param>
        /// <param name="crmObjectType">crmObjectType.</param>
        /// <param name="lastContactedAt">lastContactedAt.</param>
        /// <param name="lastContactedType">lastContactedType.</param>
        /// <param name="doNotContact">doNotContact.</param>
        /// <param name="counts">counts.</param>
        /// <param name="owner">owner.</param>
        /// <param name="creator">creator.</param>
        /// <param name="lastContactedBy">lastContactedBy.</param>
        /// <param name="lastContactedPerson">lastContactedPerson.</param>
        public Account(int? id = default(int?), string createdAt = default(string), string updatedAt = default(string), string name = default(string), string domain = default(string), string crmObjectType = default(string), string lastContactedAt = default(string), string lastContactedType = default(string), bool? doNotContact = default(bool?), PeopleCount counts = default(PeopleCount), EntityRefrence owner = default(EntityRefrence), EntityRefrence creator = default(EntityRefrence), EntityRefrence lastContactedBy = default(EntityRefrence), EntityRefrence lastContactedPerson = default(EntityRefrence))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Domain = domain;
            this.CrmObjectType = crmObjectType;
            this.LastContactedAt = lastContactedAt;
            this.LastContactedType = lastContactedType;
            this.DoNotContact = doNotContact;
            this.Counts = counts;
            this.Owner = owner;
            this.Creator = creator;
            this.LastContactedBy = lastContactedBy;
            this.LastContactedPerson = lastContactedPerson;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets CrmObjectType
        /// </summary>
        [DataMember(Name = "crm_object_type", EmitDefaultValue = true)]
        public string CrmObjectType { get; set; }

        /// <summary>
        /// Gets or Sets LastContactedAt
        /// </summary>
        [DataMember(Name = "last_contacted_at", EmitDefaultValue = true)]
        public string LastContactedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastContactedType
        /// </summary>
        [DataMember(Name = "last_contacted_type", EmitDefaultValue = true)]
        public string LastContactedType { get; set; }

        /// <summary>
        /// Gets or Sets DoNotContact
        /// </summary>
        [DataMember(Name = "do_not_contact", EmitDefaultValue = true)]
        public bool? DoNotContact { get; set; }

        /// <summary>
        /// Gets or Sets Counts
        /// </summary>
        [DataMember(Name = "counts", EmitDefaultValue = true)]
        public PeopleCount Counts { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public EntityRefrence Owner { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = true)]
        public EntityRefrence Creator { get; set; }

        /// <summary>
        /// Gets or Sets LastContactedBy
        /// </summary>
        [DataMember(Name = "last_contacted_by", EmitDefaultValue = true)]
        public EntityRefrence LastContactedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastContactedPerson
        /// </summary>
        [DataMember(Name = "last_contacted_person", EmitDefaultValue = true)]
        public EntityRefrence LastContactedPerson { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  CrmObjectType: ").Append(CrmObjectType).Append("\n");
            sb.Append("  LastContactedAt: ").Append(LastContactedAt).Append("\n");
            sb.Append("  LastContactedType: ").Append(LastContactedType).Append("\n");
            sb.Append("  DoNotContact: ").Append(DoNotContact).Append("\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  LastContactedBy: ").Append(LastContactedBy).Append("\n");
            sb.Append("  LastContactedPerson: ").Append(LastContactedPerson).Append("\n");
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
