using MassTransit;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Threading.Tasks;

namespace InventoryService
{
    internal class OrderConsumer : IConsumer<Order>
    {
        private readonly ILogger<OrderConsumer> logger;

        public OrderConsumer(ILogger<OrderConsumer> logger)
        {
            this.logger = logger;
        }

        public async Task Consume(ConsumeContext<Order> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
            logger.LogInformation($"Got new message {context.Message.Name}");
        }
    }
}