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
    /// TssV2GetEmvTags200ResponseEmvTagBreakdownList
    /// </summary>
    [DataContract]
    public partial class TssV2GetEmvTags200ResponseEmvTagBreakdownList :  IEquatable<TssV2GetEmvTags200ResponseEmvTagBreakdownList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2GetEmvTags200ResponseEmvTagBreakdownList" /> class.
        /// </summary>
        /// <param name="Tag">Hexadecimal code of tag. .</param>
        /// <param name="Name">Name of tag. .</param>
        public TssV2GetEmvTags200ResponseEmvTagBreakdownList(string Tag = default(string), string Name = default(string))
        {
            this.Tag = Tag;
            this.Name = Name;
        }
        
        /// <summary>
        /// Hexadecimal code of tag. 
        /// </summary>
        /// <value>Hexadecimal code of tag. </value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Name of tag. 
        /// </summary>
        /// <value>Name of tag. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2GetEmvTags200ResponseEmvTagBreakdownList {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as TssV2GetEmvTags200ResponseEmvTagBreakdownList);
        }

        /// <summary>
        /// Returns true if TssV2GetEmvTags200ResponseEmvTagBreakdownList instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2GetEmvTags200ResponseEmvTagBreakdownList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2GetEmvTags200ResponseEmvTagBreakdownList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
            // Tag (string) pattern
            Regex regexTag = new Regex(@"^[0-9A-F]*$", RegexOptions.CultureInvariant);
            if (false == regexTag.Match(this.Tag).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tag, must match a pattern of " + regexTag, new [] { "Tag" });
            }

            yield break;
        }
    }

}