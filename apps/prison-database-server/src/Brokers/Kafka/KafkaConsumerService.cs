using Microsoft.Extensions.DependencyInjection;
using PrisonDatabase.Brokers.Infrastructure;
using PrisonDatabase.Brokers.Kafka;

namespace PrisonDatabase.Brokers.Kafka;

public class KafkaConsumerService : KafkaConsumerService<KafkaMessageHandlersController>
{
    public KafkaConsumerService(IServiceScopeFactory serviceScopeFactory, KafkaOptions kafkaOptions)
        : base(serviceScopeFactory, kafkaOptions) { }
}
