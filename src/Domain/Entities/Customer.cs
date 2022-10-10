namespace Domain.Entities;

public partial class Customer : BaseEntity
{
    public const int FullNameMinLength = 4;
    public const int FullNameMaxLength = 128;
    public const int EmailMaxLength = 256;

    public Customer() 
    {
        IsActive = true;
    }

    public Customer(string fullName, string cpf, DateTime birthDate, string phone, string email)
        : this()
    {
        FullName = fullName;
        Cpf = cpf;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
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