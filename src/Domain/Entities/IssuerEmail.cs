using Domain.Contracts;

namespace Domain.Entities;

public class IssuerEmail : IHasUniqueKey
{
    public const int SmtpServerMaxLength = 256;
    public const int EmailMaxLength = 256;
    public const int EmailPasswordMaxLength = 256;

    private IssuerEmail() { }

    public IssuerEmail(string smtpServer, string email, string emailPassword, int port, bool enableSSL)
    {
        Id = Guid.NewGuid();
        SmtpServer = smtpServer;
        Email = email;
        EmailPassword = emailPassword;
        Port = port;
        EnableSSL = enableSSL;
    }

    public Guid Id { get; private set; }
    public string SmtpServer { get; private set; }
    public string Email { get; private set; }
    public string EmailPassword { get; private set; }
    public int Port { get; private set; }
    public bool EnableSSL { get; private set; }
}
