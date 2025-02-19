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
    /// Node network parameters.
    /// </summary>
    public class HostNetwork 
    {

        /// <summary>
        /// 用于创建控制节点的VPC的ID。该值在[[创建VPC和子网](https://support.huaweicloud.com/api-cce/cce_02_0100.html)](tag:hws)[[创建VPC和子网](https://support.huaweicloud.com/intl/zh-cn/api-cce/cce_02_0100.html)](tag:hws_hk)中获取。   获取方法如下：    - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。  - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[[查询VPC列表](https://support.huaweicloud.com/api-vpc/vpc_api01_0003.html)](tag:hws)[[查询VPC列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_api01_0003.html)](tag:hws_hk)    &gt; - 当前vpc-router容器网络模型不支持对接含拓展网段的VPC。 &gt; - 若您的用户类型为企业用户，则需要保证vpc所属的企业项目ID和集群创建时选择的企业项目ID一致。集群所属的企业项目ID通过extendParam字段下的enterpriseProjectId体现，该值默认为\&quot;0\&quot;，表示默认的企业项目。
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Vpc { get; set; }

        /// <summary>
        /// 用于创建控制节点的subnet的网络ID。获取方法如下：    - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。  - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)](tag:hws)[[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)](tag:hws_hk)  
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnet { get; set; }

        /// <summary>
        /// 节点安全组ID，创建时指定无效 
        /// </summary>
        [JsonProperty("SecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostNetwork {\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  subnet: ").Append(Subnet).Append("\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.SecurityGroup == input.SecurityGroup ||
                    (this.SecurityGroup != null &&
                    this.SecurityGroup.Equals(input.SecurityGroup))
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
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.SecurityGroup != null)
                    hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
