using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateVersionAliasRequestBody 
    {

        /// <summary>
        /// 别名对应的版本名称。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 别名描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 灰度版本信息
        /// </summary>
        [JsonProperty("additional_version_weights", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> AdditionalVersionWeights { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVersionAliasRequestBody {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  additionalVersionWeights: ").Append(AdditionalVersionWeights).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVersionAliasRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateVersionAliasRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AdditionalVersionWeights == input.AdditionalVersionWeights ||
                    this.AdditionalVersionWeights != null &&
                    input.AdditionalVersionWeights != null &&
                    this.AdditionalVersionWeights.SequenceEqual(input.AdditionalVersionWeights)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdditionalVersionWeights != null)
                    hashCode = hashCode * 59 + this.AdditionalVersionWeights.GetHashCode();
                return hashCode;
            }
        }
    }
}
