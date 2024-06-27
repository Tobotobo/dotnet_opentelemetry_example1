using Microsoft.Extensions.Logging;

class Calculator(ILogger logger) : ICalculator
{
    public int Add(int a, int b) {
        logger.AddCalling(a, b);
        var result = a + b;
        logger.AddCalled(a, b, result);
        return result;
    }
}