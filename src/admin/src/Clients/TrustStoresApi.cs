namespace MonoCloud.Management.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the TrustStores Api endpoints
/// </summary>
public class TrustStoresClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public TrustStoresClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public TrustStoresClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Get All Trust Stores
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;creation_time&#39;, and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;TrustStoreSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<TrustStoreSummary>, PageModel>> GetAllTrustStoresAsync(int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores?");

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

    return ProcessRequestAsync<List<TrustStoreSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a Trust Store
  /// </summary>
  /// <param name="createTrustStoreRequest"></param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> CreateTrustStoreAsync(CreateTrustStoreRequest createTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (createTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(createTrustStoreRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Find a Trust Store
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> FindTrustStoreByIdAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

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

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Trust Store
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteTrustStoreAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a Trust Store
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="patchTrustStoreRequest"></param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> PatchTrustStoreAsync(string trustStoreId, PatchTrustStoreRequest patchTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (patchTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(patchTrustStoreRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Sets a trust store as default
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> SetTrustStoreDefaultAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/default?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Get All Revocations
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;creation_time&#39;, and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;RevocationGrouped&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<RevocationGrouped>, PageModel>> GetAllRevocationsAsync(string trustStoreId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations?");

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

    return ProcessRequestAsync<List<RevocationGrouped>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Add a Revocation
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="addCertificateRevocationRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CertificateRevocation>> AddCertificateRevocationAsync(string trustStoreId, AddCertificateRevocationRequest addCertificateRevocationRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (addCertificateRevocationRequest == null)
    {
      throw new ArgumentNullException(nameof(addCertificateRevocationRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addCertificateRevocationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<CertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Find a Revocation by Id
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="revocationId">RevocationId</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CertificateRevocation>> FindCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

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

    return ProcessRequestAsync<CertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Remove a Revocation
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="revocationId">Certificate Revocation Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Get All Banned Certificates
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;BannedCertificate&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<BannedCertificate>>> GetAllBannedCertificatesAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates?");

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

    return ProcessRequestAsync<List<BannedCertificate>>(request, cancellationToken);
  }

  /// <summary>
  /// Ban a certificate thumbprint
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="banTrustStoreCertificateRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BannedCertificate</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BannedCertificate>> BanTrustStoreCertificateAsync(string trustStoreId, BanTrustStoreCertificateRequest banTrustStoreCertificateRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banTrustStoreCertificateRequest == null)
    {
      throw new ArgumentNullException(nameof(banTrustStoreCertificateRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(banTrustStoreCertificateRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BannedCertificate>(request, cancellationToken);
  }

  /// <summary>
  /// Unban a certificate thumbprint
  /// </summary>
  /// <param name="trustStoreId">Trust Store Id</param>
  /// <param name="banId">Thumbprint</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> UnbanTrustStoreCertificateAsync(string trustStoreId, string banId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banId == null)
    {
      throw new ArgumentNullException(nameof(banId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedBanId = HttpUtility.UrlEncode(banId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates/{encodedBanId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

