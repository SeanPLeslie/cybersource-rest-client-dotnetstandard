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
    /// TmsEmbeddedInstrumentIdentifier
    /// </summary>
    [DataContract]
    public partial class TmsEmbeddedInstrumentIdentifier :  IEquatable<TmsEmbeddedInstrumentIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsEmbeddedInstrumentIdentifier" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The Id of the Instrument Identifier Token. .</param>
        /// <param name="Type">The type of Instrument Identifier. Possible Values: - enrollable card .</param>
        /// <param name="TokenProvisioningInformation">TokenProvisioningInformation.</param>
        /// <param name="Card">Card.</param>
        /// <param name="BankAccount">BankAccount.</param>
        /// <param name="TokenizedCard">TokenizedCard.</param>
        /// <param name="Issuer">Issuer.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="Metadata">Metadata.</param>
        public TmsEmbeddedInstrumentIdentifier(TmsEmbeddedInstrumentIdentifierLinks Links = default(TmsEmbeddedInstrumentIdentifierLinks), string Id = default(string), string Type = default(string), TmsEmbeddedInstrumentIdentifierTokenProvisioningInformation TokenProvisioningInformation = default(TmsEmbeddedInstrumentIdentifierTokenProvisioningInformation), TmsEmbeddedInstrumentIdentifierCard Card = default(TmsEmbeddedInstrumentIdentifierCard), TmsEmbeddedInstrumentIdentifierBankAccount BankAccount = default(TmsEmbeddedInstrumentIdentifierBankAccount), TmsEmbeddedInstrumentIdentifierTokenizedCard TokenizedCard = default(TmsEmbeddedInstrumentIdentifierTokenizedCard), TmsEmbeddedInstrumentIdentifierIssuer Issuer = default(TmsEmbeddedInstrumentIdentifierIssuer), TmsEmbeddedInstrumentIdentifierProcessingInformation ProcessingInformation = default(TmsEmbeddedInstrumentIdentifierProcessingInformation), TmsEmbeddedInstrumentIdentifierBillTo BillTo = default(TmsEmbeddedInstrumentIdentifierBillTo), TmsEmbeddedInstrumentIdentifierMetadata Metadata = default(TmsEmbeddedInstrumentIdentifierMetadata))
        {
            this.Links = Links;
            this.Id = Id;
            this.Type = Type;
            this.TokenProvisioningInformation = TokenProvisioningInformation;
            this.Card = Card;
            this.BankAccount = BankAccount;
            this.TokenizedCard = TokenizedCard;
            this.Issuer = Issuer;
            this.ProcessingInformation = ProcessingInformation;
            this.BillTo = BillTo;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierLinks Links { get; set; }

        /// <summary>
        /// The Id of the Instrument Identifier Token. 
        /// </summary>
        /// <value>The Id of the Instrument Identifier Token. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The type.  Possible Values: - instrumentIdentifier 
        /// </summary>
        /// <value>The type.  Possible Values: - instrumentIdentifier </value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; private set; }

        /// <summary>
        /// Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed. 
        /// </summary>
        /// <value>Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// The type of Instrument Identifier. Possible Values: - enrollable card 
        /// </summary>
        /// <value>The type of Instrument Identifier. Possible Values: - enrollable card </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TokenProvisioningInformation
        /// </summary>
        [DataMember(Name="tokenProvisioningInformation", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierTokenProvisioningInformation TokenProvisioningInformation { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierCard Card { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets TokenizedCard
        /// </summary>
        [DataMember(Name="tokenizedCard", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierIssuer Issuer { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public TmsEmbeddedInstrumentIdentifierMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsEmbeddedInstrumentIdentifier {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TokenProvisioningInformation: ").Append(TokenProvisioningInformation).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  TokenizedCard: ").Append(TokenizedCard).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as TmsEmbeddedInstrumentIdentifier);
        }

        /// <summary>
        /// Returns true if TmsEmbeddedInstrumentIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsEmbeddedInstrumentIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsEmbeddedInstrumentIdentifier other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Object == other.Object ||
                    this.Object != null &&
                    this.Object.Equals(other.Object)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TokenProvisioningInformation == other.TokenProvisioningInformation ||
                    this.TokenProvisioningInformation != null &&
                    this.TokenProvisioningInformation.Equals(other.TokenProvisioningInformation)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.BankAccount == other.BankAccount ||
                    this.BankAccount != null &&
                    this.BankAccount.Equals(other.BankAccount)
                ) && 
                (
                    this.TokenizedCard == other.TokenizedCard ||
                    this.TokenizedCard != null &&
                    this.TokenizedCard.Equals(other.TokenizedCard)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Object != null)
                    hash = hash * 59 + this.Object.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TokenProvisioningInformation != null)
                    hash = hash * 59 + this.TokenProvisioningInformation.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.BankAccount != null)
                    hash = hash * 59 + this.BankAccount.GetHashCode();
                if (this.TokenizedCard != null)
                    hash = hash * 59 + this.TokenizedCard.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
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