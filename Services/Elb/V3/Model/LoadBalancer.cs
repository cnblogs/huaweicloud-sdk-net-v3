using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建loadbalancer的消息返回体
    /// </summary>
    public class LoadBalancer 
    {
        /// <summary>
        /// 功能描述：负载均衡器的操作状态。 取值范围：ONLINE、OFFLINE、DEGRADED、DISABLED或NO_MONITOR。 约束：该字段为预留字段，暂未启用，默认为ONLINE。
        /// </summary>
        /// <value>功能描述：负载均衡器的操作状态。 取值范围：ONLINE、OFFLINE、DEGRADED、DISABLED或NO_MONITOR。 约束：该字段为预留字段，暂未启用，默认为ONLINE。</value>
        [JsonConverter(typeof(EnumClassConverter<OperatingStatusEnum>))]
        public class OperatingStatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            public static readonly OperatingStatusEnum ONLINE = new OperatingStatusEnum("ONLINE");

            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            public static readonly OperatingStatusEnum OFFLINE = new OperatingStatusEnum("OFFLINE");

            /// <summary>
            /// Enum DEGRADED for value: DEGRADED
            /// </summary>
            public static readonly OperatingStatusEnum DEGRADED = new OperatingStatusEnum("DEGRADED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly OperatingStatusEnum DISABLED = new OperatingStatusEnum("DISABLED");

            /// <summary>
            /// Enum NO_MONITOR for value: NO_MONITOR
            /// </summary>
            public static readonly OperatingStatusEnum NO_MONITOR = new OperatingStatusEnum("NO_MONITOR");

            private static readonly Dictionary<string, OperatingStatusEnum> StaticFields =
            new Dictionary<string, OperatingStatusEnum>()
            {
                { "ONLINE", ONLINE },
                { "OFFLINE", OFFLINE },
                { "DEGRADED", DEGRADED },
                { "DISABLED", DISABLED },
                { "NO_MONITOR", NO_MONITOR },
            };

            private string Value;

            public OperatingStatusEnum(string value)
            {
                Value = value;
            }

            public static OperatingStatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OperatingStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperatingStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OperatingStatusEnum a, OperatingStatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OperatingStatusEnum a, OperatingStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能描述：下联面子网类型
        /// </summary>
        /// <value>功能描述：下联面子网类型</value>
        [JsonConverter(typeof(EnumClassConverter<ElbVirsubnetTypeEnum>))]
        public class ElbVirsubnetTypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: ipv4
            /// </summary>
            public static readonly ElbVirsubnetTypeEnum IPV4 = new ElbVirsubnetTypeEnum("ipv4");

            /// <summary>
            /// Enum DUALSTACK for value: dualstack
            /// </summary>
            public static readonly ElbVirsubnetTypeEnum DUALSTACK = new ElbVirsubnetTypeEnum("dualstack");

            private static readonly Dictionary<string, ElbVirsubnetTypeEnum> StaticFields =
            new Dictionary<string, ElbVirsubnetTypeEnum>()
            {
                { "ipv4", IPV4 },
                { "dualstack", DUALSTACK },
            };

            private string Value;

            public ElbVirsubnetTypeEnum(string value)
            {
                Value = value;
            }

            public static ElbVirsubnetTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ElbVirsubnetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ElbVirsubnetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ElbVirsubnetTypeEnum a, ElbVirsubnetTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ElbVirsubnetTypeEnum a, ElbVirsubnetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能描述：负载均衡器ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的配置状态。 取值范围：ACTIVE、PENDING_CREATE 或者ERROR。 约束：该字段为预留字段，暂未启用，默认为ACTIVE。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的管理状态。 约束：只支持设定为true。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的生产者名称。 约束：只支持vlb。
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器关联的后端云服务器组ID的列表。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolRef> Pools { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器关联的监听器ID的列表。
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerRef> Listeners { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的操作状态。 取值范围：ONLINE、OFFLINE、DEGRADED、DISABLED或NO_MONITOR。 约束：该字段为预留字段，暂未启用，默认为ONLINE。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public OperatingStatusEnum OperatingStatus { get; set; }
        /// <summary>
        /// 功能描述：负载均衡器的虚拟IP。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器所在的子网ID。 约束：vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的负载均衡器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 负载均衡器所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 负载均衡器虚拟IP对应的端口ID。
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 功能描述：负载均衡的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 功能描述：负载均衡器的更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 功能描述：是否是性能保障性实例 取值范围：共享型：false；性能保障型：true
        /// </summary>
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        /// <summary>
        /// 功能描述：实例对应的vpc属性。若无，则从vip_subnet_cidr_id获取。  约束：vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 功能描述：公网ELB实例绑定EIP信息。
        /// </summary>
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipInfo> Eips { get; set; }

        /// <summary>
        /// 功能描述：双栈实例对应v6的ip地址。 
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// 功能描述：双栈实例对应v6的网络id 。 约束： 1、默认为空，只有开启IPv6时才会传入。 2、vpc_id , vip_subnet_cidr_id, ipv6_vip_virsubnet_id不能同时为空，且需要在同一个vpc下。
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 功能描述：IPv6的VIP端口id。
        /// </summary>
        [JsonProperty("ipv6_vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipPortId { get; set; }

        /// <summary>
        /// 功能描述：可用区列表。默认指定所有可利用的AZ。可调用nova接口（/v2/{project_id}/os-availability-zone）查询可用AZ
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 功能描述：企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 功能描述：四层Flavor。
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// 功能描述：预留L4 弹性flavor。
        /// </summary>
        [JsonProperty("l4_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4ScaleFlavorId { get; set; }

        /// <summary>
        /// 功能描述：七层Flavor。
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 功能描述：预留弹性flavor。 
        /// </summary>
        [JsonProperty("l7_scale_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7ScaleFlavorId { get; set; }

        /// <summary>
        /// 功能描述：弹性公网EIP信息
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpInfo> Publicips { get; set; }

        /// <summary>
        /// 功能描述：下联面子网ID  loadbalancer使用的下联面端口会动态的从这些网络中占用IP
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// 功能描述：下联面子网类型
        /// </summary>
        [JsonProperty("elb_virsubnet_type", NullValueHandling = NullValueHandling.Ignore)]
        public ElbVirsubnetTypeEnum ElbVirsubnetType { get; set; }
        /// <summary>
        /// 是否启用跨VPC后端转发
        /// </summary>
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// 是否开启删除保护
        /// </summary>
        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        /// <summary>
        /// 负载均衡器的冻结场景。若负载均衡器有多个冻结场景，用逗号分隔 POLICE：公安冻结场景。 ILLEGAL：违规冻结场景。 VERIFY：客户未实名认证冻结场景。 PARTNER：合作伙伴冻结（合作伙伴冻结子客户资源）。 ARREAR：欠费冻结场景。
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenScene { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancer {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  ipv6VipPortId: ").Append(Ipv6VipPortId).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l4ScaleFlavorId: ").Append(L4ScaleFlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  l7ScaleFlavorId: ").Append(L7ScaleFlavorId).Append("\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  elbVirsubnetType: ").Append(ElbVirsubnetType).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  frozenScene: ").Append(FrozenScene).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Pools == input.Pools ||
                    this.Pools != null &&
                    input.Pools != null &&
                    this.Pools.SequenceEqual(input.Pools)
                ) && 
                (
                    this.Listeners == input.Listeners ||
                    this.Listeners != null &&
                    input.Listeners != null &&
                    this.Listeners.SequenceEqual(input.Listeners)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.VipAddress == input.VipAddress ||
                    (this.VipAddress != null &&
                    this.VipAddress.Equals(input.VipAddress))
                ) && 
                (
                    this.VipSubnetCidrId == input.VipSubnetCidrId ||
                    (this.VipSubnetCidrId != null &&
                    this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    (this.VipPortId != null &&
                    this.VipPortId.Equals(input.VipPortId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Guaranteed == input.Guaranteed ||
                    (this.Guaranteed != null &&
                    this.Guaranteed.Equals(input.Guaranteed))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Eips == input.Eips ||
                    this.Eips != null &&
                    input.Eips != null &&
                    this.Eips.SequenceEqual(input.Eips)
                ) && 
                (
                    this.Ipv6VipAddress == input.Ipv6VipAddress ||
                    (this.Ipv6VipAddress != null &&
                    this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))
                ) && 
                (
                    this.Ipv6VipVirsubnetId == input.Ipv6VipVirsubnetId ||
                    (this.Ipv6VipVirsubnetId != null &&
                    this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))
                ) && 
                (
                    this.Ipv6VipPortId == input.Ipv6VipPortId ||
                    (this.Ipv6VipPortId != null &&
                    this.Ipv6VipPortId.Equals(input.Ipv6VipPortId))
                ) && 
                (
                    this.AvailabilityZoneList == input.AvailabilityZoneList ||
                    this.AvailabilityZoneList != null &&
                    input.AvailabilityZoneList != null &&
                    this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.L4FlavorId == input.L4FlavorId ||
                    (this.L4FlavorId != null &&
                    this.L4FlavorId.Equals(input.L4FlavorId))
                ) && 
                (
                    this.L4ScaleFlavorId == input.L4ScaleFlavorId ||
                    (this.L4ScaleFlavorId != null &&
                    this.L4ScaleFlavorId.Equals(input.L4ScaleFlavorId))
                ) && 
                (
                    this.L7FlavorId == input.L7FlavorId ||
                    (this.L7FlavorId != null &&
                    this.L7FlavorId.Equals(input.L7FlavorId))
                ) && 
                (
                    this.L7ScaleFlavorId == input.L7ScaleFlavorId ||
                    (this.L7ScaleFlavorId != null &&
                    this.L7ScaleFlavorId.Equals(input.L7ScaleFlavorId))
                ) && 
                (
                    this.Publicips == input.Publicips ||
                    this.Publicips != null &&
                    input.Publicips != null &&
                    this.Publicips.SequenceEqual(input.Publicips)
                ) && 
                (
                    this.ElbVirsubnetIds == input.ElbVirsubnetIds ||
                    this.ElbVirsubnetIds != null &&
                    input.ElbVirsubnetIds != null &&
                    this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds)
                ) && 
                (
                    this.ElbVirsubnetType == input.ElbVirsubnetType ||
                    (this.ElbVirsubnetType != null &&
                    this.ElbVirsubnetType.Equals(input.ElbVirsubnetType))
                ) && 
                (
                    this.IpTargetEnable == input.IpTargetEnable ||
                    (this.IpTargetEnable != null &&
                    this.IpTargetEnable.Equals(input.IpTargetEnable))
                ) && 
                (
                    this.DeletionProtectionEnable == input.DeletionProtectionEnable ||
                    (this.DeletionProtectionEnable != null &&
                    this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))
                ) && 
                (
                    this.FrozenScene == input.FrozenScene ||
                    (this.FrozenScene != null &&
                    this.FrozenScene.Equals(input.FrozenScene))
                ) && 
                (
                    this.Ipv6Bandwidth == input.Ipv6Bandwidth ||
                    (this.Ipv6Bandwidth != null &&
                    this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Pools != null)
                    hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.Listeners != null)
                    hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipSubnetCidrId != null)
                    hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Guaranteed != null)
                    hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Eips != null)
                    hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.Ipv6VipAddress != null)
                    hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Ipv6VipPortId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipPortId.GetHashCode();
                if (this.AvailabilityZoneList != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.L4FlavorId != null)
                    hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L4ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L4ScaleFlavorId.GetHashCode();
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.L7ScaleFlavorId != null)
                    hashCode = hashCode * 59 + this.L7ScaleFlavorId.GetHashCode();
                if (this.Publicips != null)
                    hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.ElbVirsubnetIds != null)
                    hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.ElbVirsubnetType != null)
                    hashCode = hashCode * 59 + this.ElbVirsubnetType.GetHashCode();
                if (this.IpTargetEnable != null)
                    hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.DeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.FrozenScene != null)
                    hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                if (this.Ipv6Bandwidth != null)
                    hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
