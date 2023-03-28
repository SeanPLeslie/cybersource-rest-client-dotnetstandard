/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse20013
    /// </summary>
    [DataContract]
    public partial class InlineResponse20013 :  IEquatable<InlineResponse20013>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20013" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="BatchId">Unique identification number assigned to the submitted request..</param>
        /// <param name="BatchCreatedDate">ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ.</param>
        /// <param name="BatchSource">Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE .</param>
        /// <param name="MerchantReference">Reference used by merchant to identify batch..</param>
        /// <param name="BatchCaEndpoints">BatchCaEndpoints.</param>
        /// <param name="Status">Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETED .</param>
        /// <param name="Totals">Totals.</param>
        /// <param name="Billing">Billing.</param>
        /// <param name="Description">Description.</param>
        public InlineResponse20013(InlineResponse20013Links Links = default(InlineResponse20013Links), string BatchId = default(string), string BatchCreatedDate = default(string), string BatchSource = default(string), string MerchantReference = default(string), string BatchCaEndpoints = default(string), string Status = default(string), InlineResponse20012EmbeddedTotals Totals = default(InlineResponse20012EmbeddedTotals), InlineResponse20013Billing Billing = default(InlineResponse20013Billing), string Description = default(string))
        {
            this.Links = Links;
            this.BatchId = BatchId;
            this.BatchCreatedDate = BatchCreatedDate;
            this.BatchSource = BatchSource;
            this.MerchantReference = MerchantReference;
            this.BatchCaEndpoints = BatchCaEndpoints;
            this.Status = Status;
            this.Totals = Totals;
            this.Billing = Billing;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public InlineResponse20013Links Links { get; set; }

        /// <summary>
        /// Unique identification number assigned to the submitted request.
        /// </summary>
        /// <value>Unique identification number assigned to the submitted request.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        /// <value>ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ</value>
        [DataMember(Name="batchCreatedDate", EmitDefaultValue=false)]
        public string BatchCreatedDate { get; set; }

        /// <summary>
        /// Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE 
        /// </summary>
        /// <value>Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE </value>
        [DataMember(Name="batchSource", EmitDefaultValue=false)]
        public string BatchSource { get; set; }

        /// <summary>
        /// Reference used by merchant to identify batch.
        /// </summary>
        /// <value>Reference used by merchant to identify batch.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets BatchCaEndpoints
        /// </summary>
        [DataMember(Name="batchCaEndpoints", EmitDefaultValue=false)]
        public string BatchCaEndpoints { get; set; }

        /// <summary>
        /// Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETED 
        /// </summary>
        /// <value>Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Totals
        /// </summary>
        [DataMember(Name="totals", EmitDefaultValue=false)]
        public InlineResponse20012EmbeddedTotals Totals { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public InlineResponse20013Billing Billing { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20013 {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BatchCreatedDate: ").Append(BatchCreatedDate).Append("\n");
            sb.Append("  BatchSource: ").Append(BatchSource).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  BatchCaEndpoints: ").Append(BatchCaEndpoints).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20013);
        }

        /// <summary>
        /// Returns true if InlineResponse20013 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20013 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20013 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.BatchCreatedDate == other.BatchCreatedDate ||
                    this.BatchCreatedDate != null &&
                    this.BatchCreatedDate.Equals(other.BatchCreatedDate)
                ) && 
                (
                    this.BatchSource == other.BatchSource ||
                    this.BatchSource != null &&
                    this.BatchSource.Equals(other.BatchSource)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.BatchCaEndpoints == other.BatchCaEndpoints ||
                    this.BatchCaEndpoints != null &&
                    this.BatchCaEndpoints.Equals(other.BatchCaEndpoints)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Totals == other.Totals ||
                    this.Totals != null &&
                    this.Totals.Equals(other.Totals)
                ) && 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.BatchCreatedDate != null)
                    hash = hash * 59 + this.BatchCreatedDate.GetHashCode();
                if (this.BatchSource != null)
                    hash = hash * 59 + this.BatchSource.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.BatchCaEndpoints != null)
                    hash = hash * 59 + this.BatchCaEndpoints.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Totals != null)
                    hash = hash * 59 + this.Totals.GetHashCode();
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
