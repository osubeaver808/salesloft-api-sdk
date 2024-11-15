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
    /// PageFilterResult
    /// </summary>
    [DataContract(Name = "PageFilterResult")]
    public partial class PageFilterResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageFilterResult" /> class.
        /// </summary>
        /// <param name="perPage">perPage.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="totalCount">totalCount.</param>
        public PageFilterResult(int? perPage = default(int?), int? currentPage = default(int?), int? nextPage = default(int?), int? totalPages = default(int?), int? totalCount = default(int?))
        {
            this.PerPage = perPage;
            this.CurrentPage = currentPage;
            this.NextPage = nextPage;
            this.TotalPages = totalPages;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name = "per_page", EmitDefaultValue = true)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name = "current_page", EmitDefaultValue = true)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name = "next_page", EmitDefaultValue = true)]
        public int? NextPage { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "total_pages", EmitDefaultValue = true)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "total_count", EmitDefaultValue = true)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageFilterResult {\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
