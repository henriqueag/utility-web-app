namespace SalesManager.Domain.Exceptions;

public class UserFriendlyException : Exception
{
    public UserFriendlyException(string code,string message, IEnumerable<object> errors) : base(message)
    {
        Code = code;
        Errors = errors;
    }

    public string Code { get; set; }
    public IEnumerable<object> Errors { get; set; }
}
