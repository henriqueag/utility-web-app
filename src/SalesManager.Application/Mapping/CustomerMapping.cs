using AutoMapper;
using SalesManager.Application.Dtos;
using SalesManager.Domain.Entities;

namespace SalesManager.Application.Mapping;

public class CustomerMapping : Profile
{
	public CustomerMapping()
	{
		CreateMap<Customer, CustomerData>();
		CreateMap<Customer, CustomerDetailedData>();
	}
}
