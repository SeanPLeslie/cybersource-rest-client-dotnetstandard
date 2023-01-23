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
    /// PtsV2PayoutsPost201ResponseIssuerInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PayoutsPost201ResponseIssuerInformation :  IEquatable<PtsV2PayoutsPost201ResponseIssuerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PayoutsPost201ResponseIssuerInformation" /> class.
        /// </summary>
        /// <param name="ServiceProcessingType">This field contains values that identify the service type under which the transaction should be processed. The valid value for the Visa Alias Directory Service is A0 (Alias) and 00 (normal transaction). .</param>
        public PtsV2PayoutsPost201ResponseIssuerInformation(string ServiceProcessingType = default(string))
        {
            this.ServiceProcessingType = ServiceProcessingType;
        }
        
        /// <summary>
        /// This field contains values that identify the service type under which the transaction should be processed. The valid value for the Visa Alias Directory Service is A0 (Alias) and 00 (normal transaction). 
        /// </summary>
        /// <value>This field contains values that identify the service type under which the transaction should be processed. The valid value for the Visa Alias Directory Service is A0 (Alias) and 00 (normal transaction). </value>
        [DataMember(Name="serviceProcessingType", EmitDefaultValue=false)]
        public string ServiceProcessingType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PayoutsPost201ResponseIssuerInformation {\n");
            sb.Append("  ServiceProcessingType: ").Append(ServiceProcessingType).Append("\n");
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
            return this.Equals(obj as PtsV2PayoutsPost201ResponseIssuerInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PayoutsPost201ResponseIssuerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PayoutsPost201ResponseIssuerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PayoutsPost201ResponseIssuerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceProcessingType == other.ServiceProcessingType ||
                    this.ServiceProcessingType != null &&
                    this.ServiceProcessingType.Equals(other.ServiceProcessingType)
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
                if (this.ServiceProcessingType != null)
                    hash = hash * 59 + this.ServiceProcessingType.GetHashCode();
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