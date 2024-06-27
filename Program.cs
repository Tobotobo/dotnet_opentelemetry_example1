using Microsoft.Extensions.Logging;
using OpenTelemetry.Logs;

var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddOpenTelemetry(logging =>
    {
        logging
            .AddConsoleExporter()
            .AddOtlpExporter(options => {
                options.Endpoint = new Uri("http://localhost:4317");
            });
    });
});

var calculator = new Calculator(loggerFactory.CreateLogger<Calculator>());

var result = calculator.Add(1, 2);

loggerFactory.Dispose();