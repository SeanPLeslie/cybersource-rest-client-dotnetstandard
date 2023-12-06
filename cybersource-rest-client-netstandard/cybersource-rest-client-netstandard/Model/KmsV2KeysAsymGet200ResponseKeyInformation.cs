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
    /// key information 
    /// </summary>
    [DataContract]
    public partial class KmsV2KeysAsymGet200ResponseKeyInformation :  IEquatable<KmsV2KeysAsymGet200ResponseKeyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsV2KeysAsymGet200ResponseKeyInformation" /> class.
        /// </summary>
        /// <param name="OrganizationId">Merchant Id .</param>
        /// <param name="ReferenceNumber">Reference number is a unique identifier provided by the client along with the organization Id. This is an optional field provided solely for the client&#39;s convenience. If client specifies value for this field in the request, it is expected to be available in the response. .</param>
        /// <param name="KeyId">Key Serial Number .</param>
        /// <param name="Status">The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED .</param>
        /// <param name="ExpirationDate">The expiration time in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="Message">message in case of failed key.</param>
        /// <param name="Alias">Key alias.</param>
        /// <param name="ErrorInformation">ErrorInformation.</param>
        public KmsV2KeysAsymGet200ResponseKeyInformation(string OrganizationId = default(string), string ReferenceNumber = default(string), string KeyId = default(string), string Status = default(string), string ExpirationDate = default(string), string Message = default(string), string Alias = default(string), KmsV2KeysSymPost201ResponseErrorInformation ErrorInformation = default(KmsV2KeysSymPost201ResponseErrorInformation))
        {
            this.OrganizationId = OrganizationId;
            this.ReferenceNumber = ReferenceNumber;
            this.KeyId = KeyId;
            this.Status = Status;
            this.ExpirationDate = ExpirationDate;
            this.Message = Message;
            this.Alias = Alias;
            this.ErrorInformation = ErrorInformation;
        }
        
        /// <summary>
        /// Merchant Id 
        /// </summary>
        /// <value>Merchant Id </value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Reference number is a unique identifier provided by the client along with the organization Id. This is an optional field provided solely for the client&#39;s convenience. If client specifies value for this field in the request, it is expected to be available in the response. 
        /// </summary>
        /// <value>Reference number is a unique identifier provided by the client along with the organization Id. This is an optional field provided solely for the client&#39;s convenience. If client specifies value for this field in the request, it is expected to be available in the response. </value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Key Serial Number 
        /// </summary>
        /// <value>Key Serial Number </value>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED 
        /// </summary>
        /// <value>The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The expiration time in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>The expiration time in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// message in case of failed key
        /// </summary>
        /// <value>message in case of failed key</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Key alias
        /// </summary>
        /// <value>Key alias</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInformation
        /// </summary>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public KmsV2KeysSymPost201ResponseErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsV2KeysAsymGet200ResponseKeyInformation {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
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
            return this.Equals(obj as KmsV2KeysAsymGet200ResponseKeyInformation);
        }

        /// <summary>
        /// Returns true if KmsV2KeysAsymGet200ResponseKeyInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of KmsV2KeysAsymGet200ResponseKeyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsV2KeysAsymGet200ResponseKeyInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
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
