using Microsoft.Extensions.Logging;
using UnitTestToolbox.Models;

namespace UnitTestToolbox.Mocks
{
  internal class LoggerMock : ILogger<Sample>
  {
    public List<(LogLevel Level, string Message, IReadOnlyList<KeyValuePair<string, object>> Properties, Exception Exception)> Entries { get; } =
      new List<(LogLevel Level, string Message, IReadOnlyList<KeyValuePair<string, object>> Properties, Exception Exception)>();
    public IDisposable BeginScope<TState>(TState state)
    {
      throw new NotImplementedException();
    }

    public bool IsEnabled(LogLevel logLevel)
    {
      throw new NotImplementedException();
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
      // These are relying on an internal implementation detail, they will break!
      var message = state.ToString();
      var properties = state as IReadOnlyList<KeyValuePair<string, object>>;

      Entries.Add((logLevel, message, properties, exception));
    }
  }
}
