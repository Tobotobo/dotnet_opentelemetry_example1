using Microsoft.Extensions.Logging;

static partial class CalculatorLoggerExtensions
{
    [LoggerMessage(LogLevel.Information, "`{a}` + `{b}`")]
    public static partial void AddCalling(this ILogger logger, int a, int b);

    [LoggerMessage(LogLevel.Information, "`{a}` + `{b}` = `{result}`")]
    public static partial void AddCalled(this ILogger logger, int a, int b, int result);

}