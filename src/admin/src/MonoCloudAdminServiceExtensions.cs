namespace MonoCloud.Management.Admin;

public static class MonoCloudAdminServiceExtensions
{
  public static IServiceCollection AddMonoCloudAdminClient(this IServiceCollection services, IConfiguration configuration) =>
    services.AddMonoCloudAdminClient(configuration, null);

  public static IServiceCollection AddMonoCloudAdminClient(this IServiceCollection services, Action<MonoCloudAdminOptions> options) =>
    services.AddMonoCloudAdminClient(null, options);

  public static IServiceCollection AddMonoCloudAdminClient(this IServiceCollection services, IConfiguration? configuration, Action<MonoCloudAdminOptions>? options)
  {
    string? domain = null;
    string? apiKey = null;
    int? timeout = null;

    if (configuration is not null)
    {
      var monocloudSection = configuration.GetSection("MonoCloud").GetSection("Admin");
      domain = monocloudSection["Domain"];
      apiKey = monocloudSection["ApiKey"];

      if (int.TryParse(monocloudSection["Timeout"], out var result))
      {
        timeout = result;
      }
    }

    if (options is not null)
    {
      var settings = new MonoCloudAdminOptions();
      options.Invoke(settings);

      if (settings.Domain is not null)
      {
        domain = settings.Domain;
      }

      if (settings.ApiKey is not null)
      {
        apiKey = settings.ApiKey;
      }

      if (settings.Timeout.HasValue)
      {
        timeout = settings.Timeout.Value.Seconds;
      }
    }

    if (domain is null || string.IsNullOrEmpty(domain))
    {
      throw new ArgumentNullException(nameof(MonoCloudAdminOptions.Domain), "The domain for the MonoCloud Admin client has not been set.");
    }

    if (apiKey is null || string.IsNullOrEmpty(apiKey))
    {
      throw new ArgumentNullException(nameof(MonoCloudAdminOptions.ApiKey), "The api key for the MonoCloud Admin client has not been set.");
    }

    var config = new MonoCloudConfig(domain, apiKey, timeout.HasValue ? TimeSpan.FromSeconds(timeout.Value) : null);

    var clientName = "MonoCloudAdminClient";

    services.AddHttpClient(clientName)
      .ConfigureHttpClient(client =>
      {
        client.BaseAddress = new Uri($"{config.Domain}/api/");
        client.Timeout = config.Timeout;
        client.DefaultRequestHeaders.Add("X-API-KEY", config.ApiKey);
      });

    services.AddTransient(s =>
    {
      var factory = s.GetRequiredService<IHttpClientFactory>();
      var client = factory.CreateClient(clientName);
      return new MonoCloudAdminClient(client);
    });

    return services;
  }
}
