
using PaymentCore.Application.Mappers;
using PaymentCore.Domain.Aggregates;

namespace PaymentCore.Application.Repository;

interface IPaymentRepository
{
  SolicitationAggregate SearchSolicitation(IMappers _mapper);
}

