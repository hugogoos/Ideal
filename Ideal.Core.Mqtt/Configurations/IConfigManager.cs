using Ideal.Core.Mqtt.Configurations.Options;

namespace Ideal.Core.Mqtt.Configurations
{
    /// <summary>
    /// 配置管理
    /// </summary>
    public interface IConfigManager
    {
        /// <summary>
        /// MQTT配置
        /// </summary>
        MQTTOptions MQTTOptions { get; }
    }
}
