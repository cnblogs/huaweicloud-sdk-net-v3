using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeEIPSpec 
    {

        /// <summary>
        /// 弹性IP类型，取值请参见“[[创建云服务器](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0167957246.html)](tag:hws)[[创建云服务器](https://support.huaweicloud.com/intl/zh-cn/api-ecs/zh-cn_topic_0167957246.html)](tag:hws_hk) &gt; eip字段数据结构说明”表中“iptype”参数的描述。
        /// </summary>
        [JsonProperty("iptype", NullValueHandling = NullValueHandling.Ignore)]
        public string Iptype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public NodeBandwidth Bandwidth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeEIPSpec {\n");
            sb.Append("  iptype: ").Append(Iptype).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeEIPSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeEIPSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iptype == input.Iptype ||
                    (this.Iptype != null &&
                    this.Iptype.Equals(input.Iptype))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
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
                if (this.Iptype != null)
                    hashCode = hashCode * 59 + this.Iptype.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
