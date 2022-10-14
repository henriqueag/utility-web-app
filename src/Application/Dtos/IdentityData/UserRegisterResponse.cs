namespace Application.Dtos.IdentityData;

public record UserRegisterResponse
{
    public bool Success { get; private set; }
    public List<string> Errors { get; private set; }

    public UserRegisterResponse() =>
        Errors = new List<string>();

    public UserRegisterResponse(bool sucesso = true) : this() =>
        Success = sucesso;

    public void AddErrors(IEnumerable<string> errors) =>
        Errors.AddRange(errors);
}
