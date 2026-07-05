namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the FeatureFlags Api endpoints
/// </summary>
public class FeatureFlagsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="FeatureFlagsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public FeatureFlagsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="FeatureFlagsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public FeatureFlagsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List feature flags with the current tenant&#39;s overrides.
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;HttpFeatureFlagResponse&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<HttpFeatureFlagResponse>>> GetFeatureFlagsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("feature_flags?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<HttpFeatureFlagResponse>>(request, cancellationToken);
  }

  /// <summary>
  /// Set the override for a flag for the current tenant.
  /// </summary>
  /// <param name="name">The feature flag name.</param>
  /// <param name="httpSetFeatureFlagRequest">The desired enabled state for the flag.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>HttpFeatureFlagResponse</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<HttpFeatureFlagResponse>> SetFeatureFlagAsync(string name, HttpSetFeatureFlagRequest httpSetFeatureFlagRequest, CancellationToken cancellationToken = default)
  {
    if (name == null)
    {
      throw new ArgumentNullException(nameof(name));
    }

    if (httpSetFeatureFlagRequest == null)
    {
      throw new ArgumentNullException(nameof(httpSetFeatureFlagRequest));
    }

    var encodedName = HttpUtility.UrlEncode(name);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"feature_flags/{encodedName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(httpSetFeatureFlagRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<HttpFeatureFlagResponse>(request, cancellationToken);
  }

  /// <summary>
  /// Clear the override for a flag for the current tenant so it reverts to the inherited value.
  /// </summary>
  /// <param name="name">The feature flag name.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> ClearFeatureFlagAsync(string name, CancellationToken cancellationToken = default)
  {
    if (name == null)
    {
      throw new ArgumentNullException(nameof(name));
    }

    var encodedName = HttpUtility.UrlEncode(name);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"feature_flags/{encodedName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

