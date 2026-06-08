namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the NetworkZones Api endpoints
/// </summary>
public class NetworkZonesClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="NetworkZonesClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public NetworkZonesClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="NetworkZonesClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public NetworkZonesClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List network zones
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of network zones across all types (IP and regional). Each item is discriminated by its `type` field. Optional query parameters may be used to search, filter, and sort the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of zones to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;category&#x60;, &#x60;operator&#x60;, &#x60;type&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;INetworkZone&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<INetworkZone>, PageModel>> GetAllNetworkZonesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("network_zones?");

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

    return ProcessRequestAsync<List<INetworkZone>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an IP network zone
  /// </summary>
  /// <remarks>
  /// Creates a new IP network zone containing IP address ranges that can be referenced by policies to allow or restrict access.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="createIpNetworkZoneRequest">The request payload used to create the IP network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>IpNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<IpNetworkZone>> CreateIpNetworkZoneAsync(CreateIpNetworkZoneRequest createIpNetworkZoneRequest, CancellationToken cancellationToken = default)
  {
    if (createIpNetworkZoneRequest == null)
    {
      throw new ArgumentNullException(nameof(createIpNetworkZoneRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("network_zones/ip?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createIpNetworkZoneRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<IpNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an IP network zone
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified IP network zone.
  /// </remarks>>
  /// <param name="zoneId">The unique identifier of the IP network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>IpNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<IpNetworkZone>> FindIpNetworkZoneByIdAsync(string zoneId, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/ip/{encodedZoneId}?");

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

    return ProcessRequestAsync<IpNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Update an IP network zone
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified IP network zone. Only fields included in the request are updated.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="zoneId">The unique identifier of the IP network zone.</param>
  /// <param name="patchIpNetworkZoneRequest">The request payload used to update an IP network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>IpNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<IpNetworkZone>> PatchIpNetworkZoneAsync(string zoneId, PatchIpNetworkZoneRequest patchIpNetworkZoneRequest, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    if (patchIpNetworkZoneRequest == null)
    {
      throw new ArgumentNullException(nameof(patchIpNetworkZoneRequest));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/ip/{encodedZoneId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchIpNetworkZoneRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<IpNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an IP network zone
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified IP network zone.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="zoneId">The unique identifier of the IP network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteIpNetworkZoneAsync(string zoneId, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/ip/{encodedZoneId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Create a regional network zone
  /// </summary>
  /// <remarks>
  /// Creates a new regional network zone containing countries that can be referenced by policies to allow or restrict access.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="createRegionalNetworkZoneRequest">The request payload used to create the regional network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>RegionalNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<RegionalNetworkZone>> CreateRegionalNetworkZoneAsync(CreateRegionalNetworkZoneRequest createRegionalNetworkZoneRequest, CancellationToken cancellationToken = default)
  {
    if (createRegionalNetworkZoneRequest == null)
    {
      throw new ArgumentNullException(nameof(createRegionalNetworkZoneRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("network_zones/regional?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createRegionalNetworkZoneRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<RegionalNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a regional network zone
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified regional network zone.
  /// </remarks>>
  /// <param name="zoneId">The unique identifier of the regional network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>RegionalNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<RegionalNetworkZone>> FindRegionalNetworkZoneByIdAsync(string zoneId, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/regional/{encodedZoneId}?");

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

    return ProcessRequestAsync<RegionalNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Update a regional network zone
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified regional network zone. Only fields included in the request are updated.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="zoneId">The unique identifier of the regional network zone.</param>
  /// <param name="patchRegionalNetworkZoneRequest">The request payload used to update a regional network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>RegionalNetworkZone</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<RegionalNetworkZone>> PatchRegionalNetworkZoneAsync(string zoneId, PatchRegionalNetworkZoneRequest patchRegionalNetworkZoneRequest, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    if (patchRegionalNetworkZoneRequest == null)
    {
      throw new ArgumentNullException(nameof(patchRegionalNetworkZoneRequest));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/regional/{encodedZoneId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchRegionalNetworkZoneRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<RegionalNetworkZone>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a regional network zone
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified regional network zone.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="zoneId">The unique identifier of the regional network zone.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteRegionalNetworkZoneAsync(string zoneId, CancellationToken cancellationToken = default)
  {
    if (zoneId == null)
    {
      throw new ArgumentNullException(nameof(zoneId));
    }

    var encodedZoneId = HttpUtility.UrlEncode(zoneId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"network_zones/regional/{encodedZoneId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

