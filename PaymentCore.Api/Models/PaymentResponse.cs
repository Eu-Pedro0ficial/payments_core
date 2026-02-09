namespace PaymentCore.Api.Models;

public record PaymentSuccessResponse
{
  public required string TransactionId { get; init; }
  public required string Status { get; init; }
}
