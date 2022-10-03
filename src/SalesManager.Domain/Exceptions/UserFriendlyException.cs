using SalesManager.Domain.ValueObjects;

namespace SalesManager.Domain.Exceptions;

public class UserFriendlyException : Exception
{
    public UserFriendlyException(string code, string message) : base(message)
    {
        Code = code;
    }

    public UserFriendlyException(string code,string message, IEnumerable<ErrorMessageWithDetails> errors) 
        : base(message)
    {
        Code = code;
        Errors = errors;
    }

    public string Code { get; set; }
    public IEnumerable<ErrorMessageWithDetails> Errors { get; set; }
}
