namespace MonoCloud.Management.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Keys Api endpoints
/// </summary>
public class KeysClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="KeysClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public KeysClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="KeysClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public KeysClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Get All Valid Keys
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;KeyMaterial&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<KeyMaterial>, PageModel>> GetAllKeyMaterialsAsync(int? page = 1, int? size = 10, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("keys?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

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

    return ProcessRequestAsync<List<KeyMaterial>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Rotate Current Key
  /// </summary>
  /// <param name="keyId">Key Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RotateKeyAsync(string keyId, CancellationToken cancellationToken = default)
  {
    if (keyId == null)
    {
      throw new ArgumentNullException(nameof(keyId));
    }

    var encodedKeyId = HttpUtility.UrlEncode(keyId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"keys/{encodedKeyId}/rotate?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke Current Key
  /// </summary>
  /// <param name="keyId">Key Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeKeyAsync(string keyId, CancellationToken cancellationToken = default)
  {
    if (keyId == null)
    {
      throw new ArgumentNullException(nameof(keyId));
    }

    var encodedKeyId = HttpUtility.UrlEncode(keyId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"keys/{encodedKeyId}/revoke?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

