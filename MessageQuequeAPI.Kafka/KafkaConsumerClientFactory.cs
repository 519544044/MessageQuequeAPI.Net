using Microsoft.Extensions.Options;

namespace MessageQuequeAPI.Kafka
{
    public class KafkaConsumerClientFactory : IConsumerClientFactory
    {
        private readonly KafkaOptions _kafkaOptions;

        public KafkaConsumerClientFactory(IOptions<KafkaOptions> kafkaOptions)
        {
            _kafkaOptions = kafkaOptions.Value;
        }

        public IConsumerClient Create(string groupId)
        {
            return new KafkaConsumerClient(groupId, _kafkaOptions);
        }
    }
}