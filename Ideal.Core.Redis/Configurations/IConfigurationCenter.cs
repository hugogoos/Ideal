﻿using Ideal.Core.Redis.Configurations.Options;

namespace Ideal.Core.Redis.Configurations
{
    /// <summary>
    /// 配置管理
    /// </summary>
    public interface IConfigurationCenter
    {
        /// <summary>
        /// Redis配置
        /// </summary>
        RedisOptions RedisOptions { get; }
    }
}
