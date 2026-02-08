
using PaymentCore.Api.Controllers;

namespace PaymentCore.Api.Routes;

public static class PaymentRoute
{
  
  public static void PaymentRoutes(this WebApplication app)
  {
    app.MapGet("/payment/order", async (PaymentController controller) =>
    {
      var orderResult = await controller.CreateOrderPayment();
      return orderResult;
    });
  }

}
