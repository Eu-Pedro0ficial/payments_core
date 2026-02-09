using PaymentCore.Api.Models;

namespace PaymentCore.Api.Controllers
{
  public class PaymentController
  {
    private readonly ILogger<PaymentController> _logger;

    public PaymentController(ILogger<PaymentController> logger)
    {
      _logger = logger;
    }

    public async Task<IResult> CreateOrderPayment(CreatePaymentRequest Order)
    {
      var transactionId = Guid.NewGuid().ToString();
      LogMessages.ProcessingOrder(
        _logger, 
        transactionId, 
        Order.Payer.Id, 
        Order.Amount.Value
      );

      var response = new PaymentSuccessResponse
      {
        TransactionId = transactionId,
        Status = "PENDING"
      };
      return Results.Ok(response);
    }
  }
}

public static partial class LogMessages
{
  [LoggerMessage(EventId = 2001, Level = LogLevel.Information,
      Message = "Processando o pedido {OrderId} para o usuário {UserId} com o valor de {Amount}")]
  public static partial void ProcessingOrder(ILogger logger, string orderId, string userId, decimal amount);
}
