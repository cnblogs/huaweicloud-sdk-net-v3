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
    /// Request Object
    /// </summary>
    public class DeleteEventRequest 
    {

        /// <summary>
        /// 事件ID。
        /// </summary>
        [SDKProperty("event_id", IsPath = true)]
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 函数的URN（Uniform Resource Name），唯一标识函数。
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteEventRequest {\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteEventRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteEventRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.FunctionUrn == input.FunctionUrn ||
                    (this.FunctionUrn != null &&
                    this.FunctionUrn.Equals(input.FunctionUrn))
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.FunctionUrn != null)
                    hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
