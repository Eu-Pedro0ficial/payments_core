namespace PaymentCore.Api.Models;

public enum PaymentOperation
{
  PAYMENT,
  AUTHORIZE,
  CAPTURE,
  CANCEL,
  REFUND,
}

public record PayerModel
{
  public required string Id { get; init; }
}

public record PaymentMethodModel
{
  public required string Type { get; init; }
  public int Installments { get; init; }
}

public record AmountModel
{
  public required int Value { get; init; }
  public required string Currency { get; init; }
}

public record CreatePaymentRequest
{
  public required PaymentOperation Operation { get; init; }
  public required string ExternalReference { get; init; }
  public required AmountModel Amount { get; init; }
  public required PaymentMethodModel PaymentMethod { get; init; }
  public required PayerModel Payer { get; init; }
  public required string Provider { get; init; }
  public required string CallbackUrl { get; init; }
}
