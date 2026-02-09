using PaymentCore.Domain.Aggregates;

namespace PaymentCore.Application.Mappers;

interface IMappers
{
  SolicitationAggregate ToDomain();
  void ToOut();
}
