﻿var builder = WebApplication.CreateBuilder(args);
var proxyPort = Environment.GetEnvironmentVariable("CFPROXY_PORT", EnvironmentVariableTarget.Process) ?? "36000";

var cfApiKey = Environment.GetEnvironmentVariable("CFPROXY_APIKEY", EnvironmentVariableTarget.Process);

if (cfApiKey == null)
{
    Console.Error.WriteLine("Need to set environment variable CFPROXY_APIKEY to valid CF Core API key");
    return -1;
}

builder.Services.AddHttpClient("curseForgeApi", options =>
{
    options.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", cfApiKey);
    options.BaseAddress = new Uri("https://api.curseforge.com");
});

var app = builder.Build();

app.Map("/{**catchAll}", async (HttpContext context) =>
{
    var client = app.Services.GetRequiredService<IHttpClientFactory>().CreateClient("curseForgeApi");

    using var ms = new MemoryStream();
    await context.Request.Body.CopyToAsync(ms);
    ms.Position = 0;

    var requestMessage = new HttpRequestMessage(new HttpMethod(context.Request.Method), $"{context.Request.Path}{context.Request.QueryString.Value}")
    {
        Content = new StreamContent(ms),
    };

    requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");
    requestMessage.Content?.Headers.TryAddWithoutValidation("Content-Type", "application/json");

    var result = await client.SendAsync(requestMessage);
    context.Response.StatusCode = (int)result.StatusCode;
    context.Response.ContentType = "application/json";

    await context.Response.WriteAsync(await result.Content.ReadAsStringAsync());
});

await app.RunAsync($"http://localhost:{proxyPort}");

return 0;