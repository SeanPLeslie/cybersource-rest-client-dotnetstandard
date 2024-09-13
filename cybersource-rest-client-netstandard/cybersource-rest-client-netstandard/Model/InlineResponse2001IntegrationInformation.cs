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
    /// InlineResponse2001IntegrationInformation
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001IntegrationInformation :  IEquatable<InlineResponse2001IntegrationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001IntegrationInformation" /> class.
        /// </summary>
        /// <param name="Oauth2">Oauth2.</param>
        /// <param name="TenantConfigurations">tenantConfigurations is an array of objects that includes the tenant information this merchant is associated with..</param>
        public InlineResponse2001IntegrationInformation(List<Boardingv1registrationsIntegrationInformationOauth2> Oauth2 = default(List<Boardingv1registrationsIntegrationInformationOauth2>), List<InlineResponse2001IntegrationInformationTenantConfigurations> TenantConfigurations = default(List<InlineResponse2001IntegrationInformationTenantConfigurations>))
        {
            this.Oauth2 = Oauth2;
            this.TenantConfigurations = TenantConfigurations;
        }
        
        /// <summary>
        /// Gets or Sets Oauth2
        /// </summary>
        [DataMember(Name="oauth2", EmitDefaultValue=false)]
        public List<Boardingv1registrationsIntegrationInformationOauth2> Oauth2 { get; set; }

        /// <summary>
        /// tenantConfigurations is an array of objects that includes the tenant information this merchant is associated with.
        /// </summary>
        /// <value>tenantConfigurations is an array of objects that includes the tenant information this merchant is associated with.</value>
        [DataMember(Name="tenantConfigurations", EmitDefaultValue=false)]
        public List<InlineResponse2001IntegrationInformationTenantConfigurations> TenantConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001IntegrationInformation {\n");
            sb.Append("  Oauth2: ").Append(Oauth2).Append("\n");
            sb.Append("  TenantConfigurations: ").Append(TenantConfigurations).Append("\n");
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
            return this.Equals(obj as InlineResponse2001IntegrationInformation);
        }

        /// <summary>
        /// Returns true if InlineResponse2001IntegrationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001IntegrationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001IntegrationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Oauth2 == other.Oauth2 ||
                    this.Oauth2 != null &&
                    this.Oauth2.SequenceEqual(other.Oauth2)
                ) && 
                (
                    this.TenantConfigurations == other.TenantConfigurations ||
                    this.TenantConfigurations != null &&
                    this.TenantConfigurations.SequenceEqual(other.TenantConfigurations)
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
                if (this.Oauth2 != null)
                    hash = hash * 59 + this.Oauth2.GetHashCode();
                if (this.TenantConfigurations != null)
                    hash = hash * 59 + this.TenantConfigurations.GetHashCode();
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