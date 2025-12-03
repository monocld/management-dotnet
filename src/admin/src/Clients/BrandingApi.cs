namespace MonoCloud.Management.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Branding Api endpoints
/// </summary>
public class BrandingClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="BrandingClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public BrandingClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BrandingClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public BrandingClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Get Branding Options
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BrandingOptions>> FindBrandingOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding?");

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

    return ProcessRequestAsync<BrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update Branding Options
  /// </summary>
  /// <param name="patchBrandingOptionsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BrandingOptions>> PatchBrandingOptionsAsync(PatchBrandingOptionsRequest patchBrandingOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchBrandingOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchBrandingOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchBrandingOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BrandingOptions>(request, cancellationToken);
  }
}

