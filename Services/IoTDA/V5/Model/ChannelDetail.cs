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
    /// 物联网平台转发数据的通道配置参数。
    /// </summary>
    public class ChannelDetail 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public HttpForwarding HttpForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dis_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public DisForwarding DisForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ObsForwarding ObsForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amqp_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public AmqpForwarding AmqpForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dms_kafka_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public DmsKafkaForwarding DmsKafkaForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("roma_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public RomaForwarding RomaForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iota_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public IoTAForwarding IotaForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mqs_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public MqsForwarding MqsForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mysql_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlForwarding MysqlForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mqtt_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public MqttForwarding MqttForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lts_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public LtsForwarding LtsForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("influxdb_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public InfluxDBForwarding InfluxdbForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("functiongraph_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionGraphForwarding FunctiongraphForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mrs_kafka_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public MrsKafkaForwarding MrsKafkaForwarding { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelDetail {\n");
            sb.Append("  httpForwarding: ").Append(HttpForwarding).Append("\n");
            sb.Append("  disForwarding: ").Append(DisForwarding).Append("\n");
            sb.Append("  obsForwarding: ").Append(ObsForwarding).Append("\n");
            sb.Append("  amqpForwarding: ").Append(AmqpForwarding).Append("\n");
            sb.Append("  dmsKafkaForwarding: ").Append(DmsKafkaForwarding).Append("\n");
            sb.Append("  romaForwarding: ").Append(RomaForwarding).Append("\n");
            sb.Append("  iotaForwarding: ").Append(IotaForwarding).Append("\n");
            sb.Append("  mqsForwarding: ").Append(MqsForwarding).Append("\n");
            sb.Append("  mysqlForwarding: ").Append(MysqlForwarding).Append("\n");
            sb.Append("  mqttForwarding: ").Append(MqttForwarding).Append("\n");
            sb.Append("  ltsForwarding: ").Append(LtsForwarding).Append("\n");
            sb.Append("  influxdbForwarding: ").Append(InfluxdbForwarding).Append("\n");
            sb.Append("  functiongraphForwarding: ").Append(FunctiongraphForwarding).Append("\n");
            sb.Append("  mrsKafkaForwarding: ").Append(MrsKafkaForwarding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChannelDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpForwarding == input.HttpForwarding ||
                    (this.HttpForwarding != null &&
                    this.HttpForwarding.Equals(input.HttpForwarding))
                ) && 
                (
                    this.DisForwarding == input.DisForwarding ||
                    (this.DisForwarding != null &&
                    this.DisForwarding.Equals(input.DisForwarding))
                ) && 
                (
                    this.ObsForwarding == input.ObsForwarding ||
                    (this.ObsForwarding != null &&
                    this.ObsForwarding.Equals(input.ObsForwarding))
                ) && 
                (
                    this.AmqpForwarding == input.AmqpForwarding ||
                    (this.AmqpForwarding != null &&
                    this.AmqpForwarding.Equals(input.AmqpForwarding))
                ) && 
                (
                    this.DmsKafkaForwarding == input.DmsKafkaForwarding ||
                    (this.DmsKafkaForwarding != null &&
                    this.DmsKafkaForwarding.Equals(input.DmsKafkaForwarding))
                ) && 
                (
                    this.RomaForwarding == input.RomaForwarding ||
                    (this.RomaForwarding != null &&
                    this.RomaForwarding.Equals(input.RomaForwarding))
                ) && 
                (
                    this.IotaForwarding == input.IotaForwarding ||
                    (this.IotaForwarding != null &&
                    this.IotaForwarding.Equals(input.IotaForwarding))
                ) && 
                (
                    this.MqsForwarding == input.MqsForwarding ||
                    (this.MqsForwarding != null &&
                    this.MqsForwarding.Equals(input.MqsForwarding))
                ) && 
                (
                    this.MysqlForwarding == input.MysqlForwarding ||
                    (this.MysqlForwarding != null &&
                    this.MysqlForwarding.Equals(input.MysqlForwarding))
                ) && 
                (
                    this.MqttForwarding == input.MqttForwarding ||
                    (this.MqttForwarding != null &&
                    this.MqttForwarding.Equals(input.MqttForwarding))
                ) && 
                (
                    this.LtsForwarding == input.LtsForwarding ||
                    (this.LtsForwarding != null &&
                    this.LtsForwarding.Equals(input.LtsForwarding))
                ) && 
                (
                    this.InfluxdbForwarding == input.InfluxdbForwarding ||
                    (this.InfluxdbForwarding != null &&
                    this.InfluxdbForwarding.Equals(input.InfluxdbForwarding))
                ) && 
                (
                    this.FunctiongraphForwarding == input.FunctiongraphForwarding ||
                    (this.FunctiongraphForwarding != null &&
                    this.FunctiongraphForwarding.Equals(input.FunctiongraphForwarding))
                ) && 
                (
                    this.MrsKafkaForwarding == input.MrsKafkaForwarding ||
                    (this.MrsKafkaForwarding != null &&
                    this.MrsKafkaForwarding.Equals(input.MrsKafkaForwarding))
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
                if (this.HttpForwarding != null)
                    hashCode = hashCode * 59 + this.HttpForwarding.GetHashCode();
                if (this.DisForwarding != null)
                    hashCode = hashCode * 59 + this.DisForwarding.GetHashCode();
                if (this.ObsForwarding != null)
                    hashCode = hashCode * 59 + this.ObsForwarding.GetHashCode();
                if (this.AmqpForwarding != null)
                    hashCode = hashCode * 59 + this.AmqpForwarding.GetHashCode();
                if (this.DmsKafkaForwarding != null)
                    hashCode = hashCode * 59 + this.DmsKafkaForwarding.GetHashCode();
                if (this.RomaForwarding != null)
                    hashCode = hashCode * 59 + this.RomaForwarding.GetHashCode();
                if (this.IotaForwarding != null)
                    hashCode = hashCode * 59 + this.IotaForwarding.GetHashCode();
                if (this.MqsForwarding != null)
                    hashCode = hashCode * 59 + this.MqsForwarding.GetHashCode();
                if (this.MysqlForwarding != null)
                    hashCode = hashCode * 59 + this.MysqlForwarding.GetHashCode();
                if (this.MqttForwarding != null)
                    hashCode = hashCode * 59 + this.MqttForwarding.GetHashCode();
                if (this.LtsForwarding != null)
                    hashCode = hashCode * 59 + this.LtsForwarding.GetHashCode();
                if (this.InfluxdbForwarding != null)
                    hashCode = hashCode * 59 + this.InfluxdbForwarding.GetHashCode();
                if (this.FunctiongraphForwarding != null)
                    hashCode = hashCode * 59 + this.FunctiongraphForwarding.GetHashCode();
                if (this.MrsKafkaForwarding != null)
                    hashCode = hashCode * 59 + this.MrsKafkaForwarding.GetHashCode();
                return hashCode;
            }
        }
    }
}
