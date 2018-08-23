﻿using System;
using System.Reflection;
using Rebus.Config;
using Rebus.Serialization;

namespace RebusRabbitMq.AbpExtension.Consumers
{
    public interface IRebusRabbitMqModuleConfig
    {
        /// <summary>
        /// 是否启用，默认启用
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// RabbitMq连接字符串
        /// </summary>
        string ConnectString { get; }

        /// <summary>
        /// 队列名
        /// </summary>
        string QueueName { get; }

        /// <summary>
        /// 最大并行数
        /// </summary>
        int MaxParallelism { get; }

        /// <summary>
        /// 最大Worker数
        /// </summary>
        int NumberOfWorkers { get; }

        /// <summary>
        /// 消息审计是否开启，默认不开启
        /// </summary>
        bool MessageAuditingEnabled { get; }

        /// <summary>
        /// 消息审计队列名，默认不启用
        /// </summary>
        string MessageAuditingQueueName { get; }

        /// <summary>
        /// 包含RebusMqMessageHandler的程序集(自动订阅消息和自动注册handler)
        /// </summary>
        Assembly[] AssemblysIncludeRebusMqMessageHandlers { get; }

        /// <summary>
        /// 配置日志组件
        /// </summary>
        Action<RebusLoggingConfigurer> LoggingConfigurer { get; }

        /// <summary>
        /// 其他选项配置
        /// </summary>
        Action<OptionsConfigurer> OptionsConfigurer { get; }

        /// <summary>
        /// 序列化组件配置
        /// </summary>
        Action<StandardConfigurer<ISerializer>> SerializerConfigurer { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enabled">是否启用，默认启用</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig Enable(bool enabled);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectString">RabbitMq连接字符串</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig ConnectTo(string connectString);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queueName">使用队列名</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig UseQueue(string queueName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxParallelism">最大并行数</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig SetMaxParallelism(int maxParallelism);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfWorkers">最大Worker数</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig SetNumberOfWorkers(int numberOfWorkers);

        /// <summary>
        /// 启用消息审计
        /// </summary>
        /// <param name="messageAuditingQueueName">消息审计队列名</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig EnableMessageAuditing(string messageAuditingQueueName);

        /// <summary>
        /// 注册Rebus Handlers
        /// </summary>
        /// <param name="assemblys">包含Rebus Handlers的程序集</param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig RegisterHandlerInAssemblys(params Assembly[] assemblys);

        /// <summary>
        /// 配置日志组件
        /// </summary>
        /// <param name="loggingConfigurer"></param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig UseLogging(Action<RebusLoggingConfigurer> loggingConfigurer);
        /// <summary>
        /// 配置其他选项
        /// </summary>
        /// <param name="optionsConfigurer"></param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig UseOptions(Action<OptionsConfigurer> optionsConfigurer);

        /// <summary>
        /// 配置序列化
        /// </summary>
        /// <param name="serializerConfigurer"></param>
        /// <returns></returns>
        IRebusRabbitMqModuleConfig UseSerializer(Action<StandardConfigurer<ISerializer>> serializerConfigurer);
    }
}
