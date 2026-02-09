using PaymentCore.Domain.Aggregates;

namespace PaymentCore.Application.Mappers;

public class SolicitationMapper : IMappers
{
  public SolicitationAggregate ToDomain()
  {
    return new SolicitationAggregate();
  }

  public void ToOut()
  {
    
  }

}

