using PrisonDatabase.Brokers.Infrastructure;

namespace PrisonDatabase.Brokers.Kafka;

public class KafkaProducerService : InternalProducer
{
    public KafkaProducerService(string bootstrapServers)
        : base(bootstrapServers) { }
}
