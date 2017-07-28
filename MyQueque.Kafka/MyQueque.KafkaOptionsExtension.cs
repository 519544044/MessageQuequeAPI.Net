using MyQueque.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyQueque
{
    public class KafkaOptionsExtension : ICapOptionsExtension
    {
        private readonly Action<KafkaOptions> _configure;

        public KafkaOptionsExtension(Action<KafkaOptions> configure)
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
