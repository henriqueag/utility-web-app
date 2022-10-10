namespace Application.Extensions;

public static class LoggerExtensions
{
    public static void LogCommand(this ILogger logger, string commandName, object request)
    {
        logger.LogInformation("Comando {CommandName} payload: {@CommandPayload}", commandName, request);
    }

    public static void LogQuery(this ILogger logger, string queryName, object request)
    {
        logger.LogInformation("Consulta {QueryName} payload: {@QueryPayload}", queryName, request);        
    }
}
