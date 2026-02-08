
namespace PaymentCore.Api.Controllers
{
  public class PaymentController
  {
    private readonly ILogger<PaymentController> _logger;

    public PaymentController(ILogger<PaymentController> logger)
    {
      _logger = logger;
    }

    public async Task<IResult> CreateOrderPayment()
    {
      LogMessages.ProcessingOrder(_logger, 1, "pedro-123", 100);

      await Task.Delay(1000);
      return Results.Ok("Order Created");
    }
  }
}

public static partial class LogMessages
{
  [LoggerMessage(EventId = 2001, Level = LogLevel.Information,
      Message = "Processando o pedido {OrderId} para o usuário {UserId} com o valor de {Amount}")]
  public static partial void ProcessingOrder(ILogger logger, int orderId, string userId, decimal amount);
}
