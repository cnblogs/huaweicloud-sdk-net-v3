using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceResp 
    {
        /// <summary>
        /// 保护状态
        /// </summary>
        /// <value>保护状态</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectStatusEnum>))]
        public class ProtectStatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly ProtectStatusEnum AVAILABLE = new ProtectStatusEnum("available");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly ProtectStatusEnum ERROR = new ProtectStatusEnum("error");

            /// <summary>
            /// Enum PROTECTING for value: protecting
            /// </summary>
            public static readonly ProtectStatusEnum PROTECTING = new ProtectStatusEnum("protecting");

            /// <summary>
            /// Enum RESTORING for value: restoring
            /// </summary>
            public static readonly ProtectStatusEnum RESTORING = new ProtectStatusEnum("restoring");

            /// <summary>
            /// Enum REMOVING for value: removing
            /// </summary>
            public static readonly ProtectStatusEnum REMOVING = new ProtectStatusEnum("removing");

            private static readonly Dictionary<string, ProtectStatusEnum> StaticFields =
            new Dictionary<string, ProtectStatusEnum>()
            {
                { "available", AVAILABLE },
                { "error", ERROR },
                { "protecting", PROTECTING },
                { "restoring", RESTORING },
                { "removing", REMOVING },
            };

            private string Value;

            public ProtectStatusEnum(string value)
            {
                Value = value;
            }

            public static ProtectStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProtectStatusEnum a, ProtectStatusEnum b)
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

            public static bool operator !=(ProtectStatusEnum a, ProtectStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 待备份资源id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 待备份资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 保护状态
        /// </summary>
        [JsonProperty("protect_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectStatusEnum ProtectStatus { get; set; }
        /// <summary>
        /// 资源已分配容量,单位为GB
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 待备份资源的类型, 云服务器: OS::Nova::Server, 云硬盘: OS::Cinder::Volume, 裸金属服务器: OS::Ironic::BareMetalServer, 线下本地服务器: OS::Native::Server, 弹性文件系统: OS::Sfs::Turbo
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 副本大小
        /// </summary>
        [JsonProperty("backup_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupSize { get; set; }

        /// <summary>
        /// 副本数量
        /// </summary>
        [JsonProperty("backup_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceResp {\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protectStatus: ").Append(ProtectStatus).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  backupSize: ").Append(BackupSize).Append("\n");
            sb.Append("  backupCount: ").Append(BackupCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProtectStatus == input.ProtectStatus ||
                    (this.ProtectStatus != null &&
                    this.ProtectStatus.Equals(input.ProtectStatus))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BackupSize == input.BackupSize ||
                    (this.BackupSize != null &&
                    this.BackupSize.Equals(input.BackupSize))
                ) && 
                (
                    this.BackupCount == input.BackupCount ||
                    (this.BackupCount != null &&
                    this.BackupCount.Equals(input.BackupCount))
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
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProtectStatus != null)
                    hashCode = hashCode * 59 + this.ProtectStatus.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BackupSize != null)
                    hashCode = hashCode * 59 + this.BackupSize.GetHashCode();
                if (this.BackupCount != null)
                    hashCode = hashCode * 59 + this.BackupCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
