using PaymentCore.Api.Controllers;
using PaymentCore.Api.Models;

namespace PaymentCore.Api.Routes;

public static class PaymentRoutes
{
  
  public static void MapPaymentRoutes(this WebApplication app)
  {
    var routes = app.MapGroup("api/payment");

    routes.MapPost("order/transactions", async (CreatePaymentRequest request, PaymentController controller) =>
    {
      return await controller.CreateOrderPayment(request);
    });
  }

}
