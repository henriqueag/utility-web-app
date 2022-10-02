using MediatR;
using SalesManager.Application.Dtos;

namespace SalesManager.Application.Commands.CreateCustomerCommand;

public record CreateCustomerCommand : CustomerData, IRequest<Guid>
{
}
