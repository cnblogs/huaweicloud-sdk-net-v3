using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowSecretVersionRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("secret_id", IsPath = true)]
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("version_id", IsPath = true)]
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecretVersionRequest {\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecretVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecretVersionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
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
                if (this.SecretId != null)
                    hashCode = hashCode * 59 + this.SecretId.GetHashCode();
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
