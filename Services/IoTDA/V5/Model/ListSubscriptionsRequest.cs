using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSubscriptionsRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Sp-Auth-Token", IsHeader = true)]
        [JsonProperty("Sp-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string SpAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Stage-Auth-Token", IsHeader = true)]
        [JsonProperty("Stage-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string StageAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("resource", IsQuery = true)]
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("event", IsQuery = true)]
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("callbackurl", IsQuery = true)]
        [JsonProperty("callbackurl", NullValueHandling = NullValueHandling.Ignore)]
        public string Callbackurl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("channel", IsQuery = true)]
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionsRequest {\n");
            sb.Append("  spAuthToken: ").Append(SpAuthToken).Append("\n");
            sb.Append("  stageAuthToken: ").Append(StageAuthToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  callbackurl: ").Append(Callbackurl).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpAuthToken == input.SpAuthToken ||
                    (this.SpAuthToken != null &&
                    this.SpAuthToken.Equals(input.SpAuthToken))
                ) && 
                (
                    this.StageAuthToken == input.StageAuthToken ||
                    (this.StageAuthToken != null &&
                    this.StageAuthToken.Equals(input.StageAuthToken))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Callbackurl == input.Callbackurl ||
                    (this.Callbackurl != null &&
                    this.Callbackurl.Equals(input.Callbackurl))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.SpAuthToken != null)
                    hashCode = hashCode * 59 + this.SpAuthToken.GetHashCode();
                if (this.StageAuthToken != null)
                    hashCode = hashCode * 59 + this.StageAuthToken.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Callbackurl != null)
                    hashCode = hashCode * 59 + this.Callbackurl.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
