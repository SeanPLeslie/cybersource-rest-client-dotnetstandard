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
    /// PtsV2PaymentsPost201ResponsePaymentInformationEWallet
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInformationEWallet :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInformationEWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInformationEWallet" /> class.
        /// </summary>
        /// <param name="FundingSource">Payment mode for the reference transaction. Possible values: - &#x60;INSTANT_TRANSFER&#x60; - &#x60;MANUAL_BANK_TRANSFER&#x60; - &#x60;DELAYED_TRANSFER&#x60; - &#x60;ECHECK&#x60; .</param>
        /// <param name="AccountId">The ID of the customer, passed in the return_url field by PayPal after customer approval. .</param>
        public PtsV2PaymentsPost201ResponsePaymentInformationEWallet(string FundingSource = default(string), string AccountId = default(string))
        {
            this.FundingSource = FundingSource;
            this.AccountId = AccountId;
        }
        
        /// <summary>
        /// Payment mode for the reference transaction. Possible values: - &#x60;INSTANT_TRANSFER&#x60; - &#x60;MANUAL_BANK_TRANSFER&#x60; - &#x60;DELAYED_TRANSFER&#x60; - &#x60;ECHECK&#x60; 
        /// </summary>
        /// <value>Payment mode for the reference transaction. Possible values: - &#x60;INSTANT_TRANSFER&#x60; - &#x60;MANUAL_BANK_TRANSFER&#x60; - &#x60;DELAYED_TRANSFER&#x60; - &#x60;ECHECK&#x60; </value>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public string FundingSource { get; set; }

        /// <summary>
        /// The ID of the customer, passed in the return_url field by PayPal after customer approval. 
        /// </summary>
        /// <value>The ID of the customer, passed in the return_url field by PayPal after customer approval. </value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInformationEWallet {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInformationEWallet);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInformationEWallet instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInformationEWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInformationEWallet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FundingSource == other.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(other.FundingSource)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
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
                if (this.FundingSource != null)
                    hash = hash * 59 + this.FundingSource.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
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