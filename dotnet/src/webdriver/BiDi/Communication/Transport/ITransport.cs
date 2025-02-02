using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System;

#nullable enable

namespace OpenQA.Selenium.BiDi.Communication.Transport;

interface ITransport : IDisposable
{
    Task ConnectAsync(CancellationToken cancellationToken);

    Task<T> ReceiveAsJsonAsync<T>(JsonSerializerOptions jsonSerializerOptions, CancellationToken cancellationToken);

    Task SendAsJsonAsync(Command command, JsonSerializerOptions jsonSerializerOptions, CancellationToken cancellationToken);
}
