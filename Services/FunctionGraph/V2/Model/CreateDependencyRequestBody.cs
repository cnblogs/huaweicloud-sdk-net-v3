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
    public class CreateDependencyRequestBody 
    {
        /// <summary>
        /// 运行时语言。
        /// </summary>
        /// <value>运行时语言。</value>
        [JsonConverter(typeof(EnumClassConverter<RuntimeEnum>))]
        public class RuntimeEnum
        {
            /// <summary>
            /// Enum JAVA8 for value: Java8
            /// </summary>
            public static readonly RuntimeEnum JAVA8 = new RuntimeEnum("Java8");

            /// <summary>
            /// Enum NODE_JS6_10 for value: Node.js6.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS6_10 = new RuntimeEnum("Node.js6.10");

            /// <summary>
            /// Enum NODE_JS8_10 for value: Node.js8.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS8_10 = new RuntimeEnum("Node.js8.10");

            /// <summary>
            /// Enum NODE_JS10_16 for value: Node.js10.16
            /// </summary>
            public static readonly RuntimeEnum NODE_JS10_16 = new RuntimeEnum("Node.js10.16");

            /// <summary>
            /// Enum NODE_JS12_13 for value: Node.js12.13
            /// </summary>
            public static readonly RuntimeEnum NODE_JS12_13 = new RuntimeEnum("Node.js12.13");

            /// <summary>
            /// Enum PYTHON2_7 for value: Python2.7
            /// </summary>
            public static readonly RuntimeEnum PYTHON2_7 = new RuntimeEnum("Python2.7");

            /// <summary>
            /// Enum PYTHON3_6 for value: Python3.6
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_6 = new RuntimeEnum("Python3.6");

            /// <summary>
            /// Enum GO1_8 for value: Go1.8
            /// </summary>
            public static readonly RuntimeEnum GO1_8 = new RuntimeEnum("Go1.8");

            /// <summary>
            /// Enum C_NET_CORE_2_0_ for value: C#(.NET Core 2.0)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_2_0_ = new RuntimeEnum("C#(.NET Core 2.0)");

            /// <summary>
            /// Enum C_NET_CORE_2_1_ for value: C#(.NET Core 2.1)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_2_1_ = new RuntimeEnum("C#(.NET Core 2.1)");

            /// <summary>
            /// Enum C_NET_CORE_3_1_ for value: C#(.NET Core 3.1)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_3_1_ = new RuntimeEnum("C#(.NET Core 3.1)");

            /// <summary>
            /// Enum PHP7_3 for value: PHP7.3
            /// </summary>
            public static readonly RuntimeEnum PHP7_3 = new RuntimeEnum("PHP7.3");

            private static readonly Dictionary<string, RuntimeEnum> StaticFields =
            new Dictionary<string, RuntimeEnum>()
            {
                { "Java8", JAVA8 },
                { "Node.js6.10", NODE_JS6_10 },
                { "Node.js8.10", NODE_JS8_10 },
                { "Node.js10.16", NODE_JS10_16 },
                { "Node.js12.13", NODE_JS12_13 },
                { "Python2.7", PYTHON2_7 },
                { "Python3.6", PYTHON3_6 },
                { "Go1.8", GO1_8 },
                { "C#(.NET Core 2.0)", C_NET_CORE_2_0_ },
                { "C#(.NET Core 2.1)", C_NET_CORE_2_1_ },
                { "C#(.NET Core 3.1)", C_NET_CORE_3_1_ },
                { "PHP7.3", PHP7_3 },
            };

            private string Value;

            public RuntimeEnum(string value)
            {
                Value = value;
            }

            public static RuntimeEnum FromValue(string value)
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

                if (this.Equals(obj as RuntimeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RuntimeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RuntimeEnum a, RuntimeEnum b)
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

            public static bool operator !=(RuntimeEnum a, RuntimeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// depend_type为zip类型时必填，为文件流格式。
        /// </summary>
        [JsonProperty("depend_file", NullValueHandling = NullValueHandling.Ignore)]
        public string DependFile { get; set; }

        /// <summary>
        /// depend_type为obs类型时，依赖包在obs的存储地址。
        /// </summary>
        [JsonProperty("depend_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DependLink { get; set; }

        /// <summary>
        /// 导入类型,目前支持obs和zip。
        /// </summary>
        [JsonProperty("depend_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DependType { get; set; }

        /// <summary>
        /// 运行时语言。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
        /// <summary>
        /// 依赖包名称。必须以大、小写字母开头，以字母或数字结尾，只能由字母、数字、下划线、点和中划线组成，长度不超过96个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 依赖包描述，不超过512个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDependencyRequestBody {\n");
            sb.Append("  dependFile: ").Append(DependFile).Append("\n");
            sb.Append("  dependLink: ").Append(DependLink).Append("\n");
            sb.Append("  dependType: ").Append(DependType).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDependencyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDependencyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DependFile == input.DependFile ||
                    (this.DependFile != null &&
                    this.DependFile.Equals(input.DependFile))
                ) && 
                (
                    this.DependLink == input.DependLink ||
                    (this.DependLink != null &&
                    this.DependLink.Equals(input.DependLink))
                ) && 
                (
                    this.DependType == input.DependType ||
                    (this.DependType != null &&
                    this.DependType.Equals(input.DependType))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.DependFile != null)
                    hashCode = hashCode * 59 + this.DependFile.GetHashCode();
                if (this.DependLink != null)
                    hashCode = hashCode * 59 + this.DependLink.GetHashCode();
                if (this.DependType != null)
                    hashCode = hashCode * 59 + this.DependType.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
