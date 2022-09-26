namespace SalesManager.Api.Domain.Entities;

public class Customer : BaseEntity
{
    public const int FullNameMaxLength = 128;
    public const int EmailMaxLength = 256;

    private Customer() { }

    public Customer(string fullName, string cpf, DateTime birthDate, string phone, string email, bool isActive)
    {
        FullName = fullName;
        Cpf = cpf;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
        IsActive = isActive;
    }

    public string FullName { get; private set; }
    public string Cpf { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Phone { get; private set; }
    public string Email { get; private set; }
    public bool IsActive { get; private set; }
    public IReadOnlyCollection<SaleOrder> SalesOrders { get; set; }

    public void UpdateCustomer(Customer customer)
    {
        UpdatedAt = DateTime.Now;
        FullName = customer.FullName;
        BirthDate = customer.BirthDate;
        Phone = customer.Phone;
        Email = customer.Email;
        IsActive = customer.IsActive;
    }
}