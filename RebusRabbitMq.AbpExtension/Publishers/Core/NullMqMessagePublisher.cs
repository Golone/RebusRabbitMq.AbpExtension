﻿using System.Threading.Tasks;

namespace RebusRabbitMq.AbpExtension.Publishers.Core
{
    public class NullMqMessagePublisher : IMqMessagePublisher
    {
        public static NullMqMessagePublisher Instance { get { return SingletonInstance; } }
        private static readonly NullMqMessagePublisher SingletonInstance = new NullMqMessagePublisher();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mqMessages"></param>
        /// <returns></returns>
        public Task PublishAsync(object mqMessages)
        {
            //do nothing.
            return Task.FromResult(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mqMessages"></param>
        public void Publish(object mqMessages)
        {
            //do nothing.
        }
    }
}
