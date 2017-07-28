﻿using System;
using MessageQuequeAPI.Kafka;
using Microsoft.Extensions.DependencyInjection;
using MessageQuequeAPI.Interface;

// ReSharper disable once CheckNamespace
namespace MessageQuequeAPI
{
    public class KafkaCapOptionsExtension : ICapOptionsExtension
    {
        private readonly Action<KafkaOptions> _configure;

        public KafkaCapOptionsExtension(Action<KafkaOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.Configure(_configure);

            var kafkaOptions = new KafkaOptions();
            _configure(kafkaOptions);
            services.AddSingleton(kafkaOptions);
            
            services.AddSingleton<IConsumerClientFactory, KafkaConsumerClientFactory>();
            services.AddTransient<IQueueExecutor, PublishQueueExecutor>();
        }
    }
}