namespace MonoCloud.Management.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Resources Api endpoints
/// </summary>
public class ResourcesClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public ResourcesClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public ResourcesClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Find an Api Resource by Id
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> FindApiResourceByIdAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

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

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Resource
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Resource
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="patchApiResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> PatchApiResourceAsync(string apiId, PatchApiResourceRequest patchApiResourceRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (patchApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Gets all Api Resource Secrets
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Secret&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Secret>>> GetAllApiResourceSecretsAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets?");

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

    return ProcessRequestAsync<List<Secret>>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource Secret
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="createSecretRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateApiResourceSecretAsync(string apiId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (createSecretRequest == null)
    {
      throw new ArgumentNullException(nameof(createSecretRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createSecretRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Resource Secret by Id
  /// </summary>
  /// <param name="secretId">Secret Id</param>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> FindApiResourceSecretByIdAsync(string secretId, string apiId, CancellationToken cancellationToken = default)
  {
    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets/{encodedSecretId}?");

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

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Resource Secret
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceSecretAsync(string apiId, string secretId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Scopes
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiScope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiScope>, PageModel>> GetAllApiScopesAsync(string apiId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<ApiScope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Scope
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="createApiScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> CreateApiScopeAsync(string apiId, CreateApiScopeRequest createApiScopeRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (createApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiScopeRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Scope by Id
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> FindApiScopeByIdAsync(string scopeId, string apiId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

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

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Scope
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="apiId">API Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiScopeAsync(string scopeId, string apiId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Scope
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="apiId">API Id</param>
  /// <param name="patchApiScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> PatchApiScopeAsync(string scopeId, string apiId, PatchApiScopeRequest patchApiScopeRequest, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (patchApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiScopeRequest));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Client Api Resource Associations
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_id&#39;, &#39;creation_time&#39; and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllClientApiResourcesAsync(string clientId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/clients/{encodedClientId}?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Resource Client Associations
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_id&#39;, &#39;creation_time&#39; and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllApiResourceClientsAsync(string apiId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Resource Client Association
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> FindApiResourceClientAsync(string apiId, string clientId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

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

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource Client Association
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="createApiResourceClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> CreateApiResourceClientAsync(string apiId, string clientId, CreateApiResourceClientRequest createApiResourceClientRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (createApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceClientRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Remove an Api Resource Client Association
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveApiResourceClientAsync(string apiId, string clientId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Resource Client Association
  /// </summary>
  /// <param name="apiId">API Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="patchApiResourceClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> PatchApiResourceClientAsync(string apiId, string clientId, PatchApiResourceClientRequest patchApiResourceClientRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (patchApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceClientRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Find a Scope by Id
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> FindScopeByIdAsync(string scopeId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

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

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Scope
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteScopeAsync(string scopeId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a scope
  /// </summary>
  /// <param name="scopeId">Scope Id</param>
  /// <param name="patchScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> PatchScopeAsync(string scopeId, PatchScopeRequest patchScopeRequest, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (patchScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchScopeRequest));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Claim Resource by Id
  /// </summary>
  /// <param name="claimId">Claim Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> FindClaimResourceByIdAsync(string claimId, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

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

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Claim Resource
  /// </summary>
  /// <param name="claimId">Claim Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteClaimResourceAsync(string claimId, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Claim Resource
  /// </summary>
  /// <param name="claimId">Claim Id</param>
  /// <param name="patchClaimResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> PatchClaimResourceAsync(string claimId, PatchClaimResourceRequest patchClaimResourceRequest, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    if (patchClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchClaimResourceRequest));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Resources
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResource>, PageModel>> GetAllApiResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<ApiResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource
  /// </summary>
  /// <param name="createApiResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> CreateApiResourceAsync(CreateApiResourceRequest createApiResourceRequest, CancellationToken cancellationToken = default)
  {
    if (createApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Scopes
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Scope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Scope>, PageModel>> GetAllScopesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<Scope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a Scope
  /// </summary>
  /// <param name="createScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> CreateScopeAsync(CreateScopeRequest createScopeRequest, CancellationToken cancellationToken = default)
  {
    if (createScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createScopeRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Claim Resources
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ClaimResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ClaimResource>, PageModel>> GetAllClaimResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
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

    return ProcessRequestAsync<List<ClaimResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Claim Resource
  /// </summary>
  /// <param name="createClaimResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> CreateClaimResourceAsync(CreateClaimResourceRequest createClaimResourceRequest, CancellationToken cancellationToken = default)
  {
    if (createClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createClaimResourceRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }
}

